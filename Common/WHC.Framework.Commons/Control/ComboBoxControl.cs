using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// 条件ComboBox控件
    /// </summary>
    public class ComboBoxControl : CheckedComboBoxEdit
    {


        private SearchCondition search = new SearchCondition();

        /// <summary>
        /// 字段名称
        /// </summary>
        [Description("字段名称")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 字段中文描述
        /// </summary>
        [Description("字段中文描述")]
        public string ChineseColumnName { get; set; }

        public ComboBoxControl()
        {
            InitializeComponent();
            this.Properties.NullValuePromptShowForEmptyValue = true;
            this.Properties.NullValuePrompt = "请选择...";
            this.Properties.NullText = string.Empty;
        }
        /// <summary>
        /// 返回语法文本
        /// </summary>
        /// <returns></returns>
        public string Syntax()
        {
            search.ConditionTable.Clear();
            if (this.EditValue == null) return string.Empty;
            if (string.IsNullOrWhiteSpace(this.EditValue.ToString())) return string.Empty;
            string result = string.Empty;
            search.AddCondition(this.ColumnName, this.ChineseColumnName, this.EditValue.ToString().TrimStart(),this.Text, SqlOperator.In, true);
            result=search.BuildConditionSqlNoWhere(DatabaseType.SqlServer);
            
            return result;
        }

        /// <summary>
        /// 返回条件描述
        /// </summary>
        /// <returns></returns>
        public string ChineseSyntax()
        {
            if (this.EditValue == null) return string.Empty;
            if (string.IsNullOrWhiteSpace(this.EditValue.ToString())) return string.Empty;
            return search.BuildConditionDescribe();
        }

        /// <summary>
        /// 清空条件
        /// </summary>
        public void Clear()
        {
            this.EditValue = null;
            this.search.ConditionTable.Clear();
        }
        private void InitializeComponent()
        {

        }

    }
}
