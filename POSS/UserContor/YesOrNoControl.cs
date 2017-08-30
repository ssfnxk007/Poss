using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;

namespace POSS
{
    public class YesOrNoControl : CheckedComboBoxEdit
    {
        private SearchCondition search = new SearchCondition();

        #region 属性

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
        #endregion

        #region 构造方法
        public YesOrNoControl()
        {
            SetDataSource();
            this.Properties.NullValuePromptShowForEmptyValue = true;
            this.Properties.NullValuePrompt = "请选择...";
            this.Properties.NullText = string.Empty;
        } 
        #endregion

        #region DesignMode
        protected new bool DesignMode
        {
            get
            {
                bool returnFlag = false;
#if DEBUG
                if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                {
                    returnFlag = true;
                }
                else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToUpper().Equals("DEVENV"))
                {
                    returnFlag = true;
                }
#endif
                return returnFlag;
            }
        }
        #endregion

        #region 条件语法方法

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
            search.AddCondition(this.ColumnName, this.ChineseColumnName, this.EditValue.ToString().TrimStart(), this.Text, SqlOperator.In, true);
            result = search.BuildConditionSqlNoWhere(DatabaseType.SqlServer);

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
        
        #endregion


        #region 初始化方法
        private void SetDataSource()
        {
            if (!DesignMode)
            {
                DataTable dt = DataTableHelper.CreateTable("显示值|string,项目值|string");
                DataRow dr = dt.NewRow();
                dr[0] = "1";
                dr[1] = "是";

                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "否";
                dt.Rows.Add(dr);

                this.Properties.DisplayMember = "项目值";
                this.Properties.ValueMember = "显示值";
                this.Properties.DataSource = dt;
            }
        }
        #endregion
    }
}
