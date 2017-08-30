using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace WHC.Framework.Commons
{
    public class TextButtonControl : ButtonEdit
    {
        public event QueryModeChangedEventHandler QueryModeChanged;
        private SearchCondition seach = new SearchCondition();
        [Description("字段中文名称")]
        public string ChineseColumnName { get; set; }

        [Description("字段名称")]
        public string ColumnName { get; set; }
        private SqlOperator currentOperator = SqlOperator.Like;

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
        public TextButtonControl()
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

        /// <summary>
        /// 返回SQL语法文本
        /// </summary>
        /// <returns></returns>
        public string Syntax()
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

        /// <summary>
        /// 返回SQL语法中文描述
        /// </summary>
        /// <returns></returns>
        public string ChineseSyntax()
        {
            return seach.BuildConditionDescribe();
        }


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
        /// 显示查询类别
        /// </summary>    

        private void SetTip()
        {
            this.ToolTipController.HideHint();
            string text = SqlOperatorDescription();
            this.ToolTipController.ShowHint(text, this, DevExpress.Utils.ToolTipLocation.BottomRight);
            this.ToolTip = text;
        }
        private void InitializeComponent()
        {
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

        /// <summary>
        /// 清空条件
        /// </summary>
        public void Clear()
        {
            this.seach.ConditionTable.Clear();
            this.Text = string.Empty;
        }
    }
}
