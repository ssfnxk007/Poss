using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;
using WHC.Framework.Commons;

namespace POSS
{
    public delegate void QueryModeChangedEventHandler(object sender, EventArgs e);
    public class TextBoxControl : TextEdit
    {
        #region 变量定义
        private string m_ColumnName = string.Empty;
        private string fillValue = string.Empty;
        private bool isFill = false;
        private SearchCondition seach = new SearchCondition();
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit fProperties;
        private SqlOperator currentOperator = SqlOperator.Like;

        #endregion

        #region 属性
        /// <summary>
        /// 填充条件的值
        /// </summary>
        [Description("填充条件的值")]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FillValue
        {
            get { return fillValue; }
            set { fillValue = value; }
        }

        /// <summary>
        /// 条件值是否为填充
        /// </summary>
        [Description("条件值是否为填充")]
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFill
        {
            get { return isFill; }
            set { isFill = value; }
        }

        public event QueryModeChangedEventHandler QueryModeChanged;

        [Description("字段中文名称")]
        public string ChineseColumnName { get; set; }

        [Description("字段名称")]
        public string ColumnName
        {
            get
            {
                return m_ColumnName;
            }
            set
            {
                if (value != null && !value.Contains("{0}") && isFill)
                {
                    throw new Exception("属性值设置不正确！");
                }
                else
                {
                    m_ColumnName = value;
                }
            }
        }


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SqlOperator CurrentOperator
        {
            get { return currentOperator; }
            set
            {
                currentOperator = value;
                this.ToolTip = SqlOperatorDescription();
            }
        }
        #endregion

        #region 构造方法
        public TextBoxControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Properties.KeyDown += Properties_KeyDown;
                this.SuperTip = new DevExpress.Utils.SuperToolTip();
                this.Properties.NullValuePromptShowForEmptyValue = true;
                this.Properties.NullValuePrompt = "F4键切换查询模式";
                this.ToolTipController = new DevExpress.Utils.ToolTipController();
                this.ToolTipController.AutoPopDelay = 2000;
                this.ToolTip = SqlOperatorDescription();
            }
        }
        #endregion

        #region 键盘事件
        private void Properties_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.F4)
            {
                ChangeCurrentOperator();
                SetTip();
                if (QueryModeChanged != null)
                {
                    QueryModeChanged(this.CurrentOperator, new EventArgs());
                }
            }
        }
        #endregion

        #region 获取语法及语法描述
        /// <summary>
        /// 返回SQL语法文本
        /// </summary>
        /// <returns></returns>
        public string Syntax()
        {
            if (this.isFill)
            {
                if (string.IsNullOrEmpty(this.Text)) return string.Empty;
                return string.Format("{0}='{1}'", string.Format(this.ColumnName, this.Text), this.fillValue);
            }
            else
            {
                seach.ConditionTable.Clear();
                if (string.IsNullOrWhiteSpace(Text))
                    return string.Empty;

                string result = string.Empty;
                string text = this.Text.TrimEnd();
                text = text.Replace('　', ' ');
                text = text.Replace("'", "");
                string[] value = text.Split(' ');
                foreach (string s in value)
                {
                    if (!string.IsNullOrWhiteSpace(s))
                    {
                        seach.AddCondition(this.ColumnName, this.ChineseColumnName, s, this.CurrentOperator);
                    }
                }
                result = seach.BuildConditionSqlNoWhere(DatabaseType.SqlServer);
                return result;
            }

        }

        /// <summary>
        /// 返回SQL语法中文描述
        /// </summary>
        /// <returns></returns>
        public string ChineseSyntax()
        {
            if (isFill)
            {
                if (string.IsNullOrEmpty(this.Text)) return string.Empty;
                return string.Format("〖{0}〗 为 『{1}』", this.ChineseColumnName, this.Text);
            }
            else
            {
                return seach.BuildConditionDescribe();
            }
        }
        #endregion

        #region SQL操作符

        /// <summary>
        /// SQL查询类型描述
        /// </summary>
        /// <param name="CurrentOperator"></param>
        /// <returns></returns>
        public string SqlOperatorDescription()
        {
            return EnumHelper.GetDescription(typeof(SqlOperator), this.CurrentOperator);
        }

        /// <summary>
        /// 循环查询类别
        /// </summary>
        public void ChangeCurrentOperator()
        {
            if (CurrentOperator == SqlOperator.Like)
            {
                CurrentOperator = SqlOperator.NotLike;
            }
            else if (CurrentOperator == SqlOperator.NotLike)
            {
                CurrentOperator = SqlOperator.LikeStartAt;
            }
            else if (CurrentOperator == SqlOperator.LikeStartAt)
            {
                CurrentOperator = SqlOperator.LikeEndAt;
            }
            else if (CurrentOperator == SqlOperator.LikeEndAt)
            {
                CurrentOperator = SqlOperator.Equal;
            }
            else if (CurrentOperator == SqlOperator.Equal)
            {
                CurrentOperator = SqlOperator.NotEqual;
            }
            else if (CurrentOperator == SqlOperator.NotEqual)
            {
                CurrentOperator = SqlOperator.Like;
            }
        }

        #endregion

        #region ToolTip
        /// <summary>
        /// 显示查询类别
        /// </summary>
        private void SetTip()
        {
            this.ToolTipController.HideHint();
            string text = SqlOperatorDescription();
            this.ToolTipController.ShowHint(text, this, DevExpress.Utils.ToolTipLocation.BottomRight);
            this.ToolTip = text;
        }
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            

        }
        #endregion

        #region 条件清空

        /// <summary>
        /// 清空条件
        /// </summary>
        public void Clear()
        {
            this.seach.ConditionTable.Clear();
            this.Text = string.Empty;
        }

        #endregion

    }
}
