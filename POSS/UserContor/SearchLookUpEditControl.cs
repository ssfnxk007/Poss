using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;
namespace POSS
{
    public class SearchLookUpEditControl: SearchLookUpEdit
    {
        private string m_ColumnName = string.Empty;
        private string fillValue = string.Empty;
        /// <summary>
        /// 填充条件的值
        /// </summary>
        [Description("填充条件的值")]
        [DefaultValue("")]
        public string FillValue
        {
            get { return fillValue; }
            set { fillValue = value; }
        }

        private bool isFill = false;
        /// <summary>
        /// 条件值是否为填充
        /// </summary>
        [Description("条件值是否为填充")]
        [DefaultValue(false)]
        public bool IsFill
        {
            get { return isFill; }
            set { isFill = value; }
        }
        public SearchLookUpEditControl()
        {
            InitializeComponent();
            this.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Properties.NullValuePrompt = "请选择...";
        }

        private void InitializeComponent()
        {

        }



        [Description("字段名称")]
        public string ColumnName
        {
            get
            {
                return m_ColumnName;
            }
            set
            {
                if (value!=null && !value.Contains("{0}") && isFill)
                {
                    throw new Exception("属性值设置不正确！");
                }
                else
                {
                    m_ColumnName = value;
                }
            }
        }

        /// <summary>
        /// 字段中文名称
        /// </summary>
        public string ChineseColumnName
        {
            get;
            set;
        }

        /// <summary>
        /// 获取SQL语法文本
        /// </summary>
        /// <returns></returns>
        public string Syntax()
        {
            if (string.IsNullOrEmpty(ColumnName)) return string.Empty;
            if (this.EditValue==null || string.IsNullOrEmpty(EditValue.ToString())) return string.Empty;
            if (this.isFill)
            {
                return string.Format("{0}='{1}'", string.Format(this.ColumnName, this.EditValue), this.fillValue);
            }
            else
            {
                return string.Format("{0}='{1}'", ColumnName, this.EditValue);
            }
        }

        /// <summary>
        /// 获取条件描述
        /// </summary>
        /// <returns></returns>
        public string ChineseSyntax()
        {
            if (string.IsNullOrEmpty(ColumnName)) return string.Empty;
            if (this.EditValue == null || string.IsNullOrEmpty(EditValue.ToString())) return string.Empty;
            if (isFill)
            {
                return string.Format("〖{0}〗 为 『{1}』", this.ChineseColumnName, this.Text);
            }
            else
            {
                return string.Format("〖{0}〗为『{1}』", ChineseColumnName, this.Text);
            }
        }

        /// <summary>
        /// 清空条件
        /// </summary>
        public void Clear()
        {
            this.EditValue = null;
        }

    }
}
