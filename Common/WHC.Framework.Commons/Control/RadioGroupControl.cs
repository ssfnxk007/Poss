using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;
namespace WHC.Framework.Commons
{
    public class RadioGroupControl : RadioGroup
    {
        [Description("字段中文名称")]
        public string ChineseColumnName { get; set; }

        [Description("字段名称")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 返回SQL语法文本
        /// </summary>
        /// <returns></returns>
        public string Syntax()
        {
            if (string.IsNullOrEmpty(this.ColumnName)) return string.Empty;
            if (this.Properties.Items[this.SelectedIndex].Value ==null || this.SelectedIndex ==-1) return string.Empty;
            return string.Format("{0}='{1}'", this.ColumnName, this.Properties.Items[this.SelectedIndex].Value.ToString());
        }

        /// <summary>
        /// 返回SQL语法中文描述
        /// </summary>
        /// <returns></returns>
        public string ChineseSyntax()
        {
            if (string.IsNullOrEmpty(this.ChineseColumnName)) return string.Empty;
            if (this.Properties.Items[this.SelectedIndex].Value == null || this.SelectedIndex ==-1) return string.Empty;
            return string.Format("〖{0}〗为『{1}』", this.ChineseColumnName, this.Properties.Items[this.SelectedIndex].Description);
        }

        public void Clear()
        {
            this.SelectedIndex = -1;
        }

    }
}
