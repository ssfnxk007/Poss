using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHC.Framework.Commons;

namespace POSS
{
   public class TextBoxControls:TextBox
    {
        private string m_ColumnName = string.Empty;
        private string fillValue = string.Empty;
        private bool isFill = false;
        private SearchCondition seach = new SearchCondition();
        private string currentOperator =string.Empty;

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
        [Description("查询方式Like,NotLike,LikeStartAt,Equal,NotEqual,In等")]
        public string CurrentOperator { get; set; }
        /// <summary>
        /// 获取SQL语法
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
                        seach.AddCondition(this.ColumnName, this.ChineseColumnName, s,(SqlOperator) Enum.Parse(typeof(SqlOperator),CurrentOperator,true) );
                    }
                }
                result = seach.BuildConditionSqlNoWhere(DatabaseType.SqlServer);
                return result;
            }

        }
        /// <summary>
        /// 清除条件
        /// </summary>
        public void Clear()
        {
            this.Text = null;
            this.seach.ConditionTable.Clear();
        }

    }
}
