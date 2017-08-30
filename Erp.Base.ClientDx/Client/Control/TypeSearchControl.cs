using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using Erp.Base.Facade;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraTreeList.Nodes;


namespace Erp.Base.UI
{
    public class TypeSearchControl : TreeListLookUpEdit
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit fProperties;
        private DevExpress.XtraTreeList.TreeList fPropertiesTreeList;
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

        #region 构造函数
        public TypeSearchControl()
        {
            this.Properties.NullValuePromptShowForEmptyValue = true;
            this.Properties.NullValuePrompt = "请选择...";
            this.Properties.NullText = string.Empty;
            this.Properties.ValueMember = "类别编码";
            this.Properties.DisplayMember = "类别名称";
            this.Properties.TreeList.KeyFieldName = "类别编码";
            this.Properties.TreeList.ParentFieldName = "上级分类";
            this.Properties.TreeList.RootValue = "ROOT";
            this.Properties.TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.Properties.TreeList.OptionsBehavior.EnableFiltering = true;
            this.Properties.TreeList.OptionsSelection.MultiSelect = true;
            this.Properties.TreeList.OptionsView.ShowCheckBoxes = true;
            this.Properties.AutoExpandAllNodes = false;
            SetDataSource();

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

        #region 设置数据源
        //设置数据源
        private void SetDataSource()
        {
            if (!DesignMode)
            {
                this.Properties.DataSource = CallerFactory<IDz_typeService>.Instance.GetTypeLevelList();
            }
        }
        #endregion

        #region 条件方法
        /// <summary>
        /// 返回语法文本
        /// </summary>
        /// <returns></returns>
        public string Syntax()
        {
            if (string.IsNullOrEmpty(this.ColumnName)) return string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < this.Properties.TreeList.Nodes.Count; index++)
            {
                GetChecked(this.Properties.TreeList.Nodes[index], sb);
            }
            return string.IsNullOrEmpty(sb.ToString()) ? string.Empty : string.Format("{0} IN ({1})", this.ColumnName, sb.ToString());
        }

        /// <summary>
        /// 返回条件描述
        /// </summary>
        /// <returns></returns>
        public string ChineseSyntax()
        {
            if (string.IsNullOrEmpty(this.ColumnName)) return string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < this.Properties.TreeList.Nodes.Count; index++)
            {
                GetNameChecked(this.Properties.TreeList.Nodes[index], sb);
            }
            return string.IsNullOrEmpty(sb.ToString()) ? string.Empty : string.Format("〖{0}〗 为 『{1}』", this.ChineseColumnName, sb.ToString());
        }

        /// <summary>
        /// 清空条件
        /// </summary>
        public void Clear()
        {
            this.EditValue = null;
            for (int index = 0; index < this.Properties.TreeList.Nodes.Count; index++)
            {
                ClearChecked(this.Properties.TreeList.Nodes[index]);
            }
        }
        #endregion

        #region 递归判断是否选择
        private void GetChecked(TreeListNode node, StringBuilder sb)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].HasChildren)
                {
                    GetChecked(node.Nodes[i], sb);
                }
                if (node.Nodes[i].Checked)
                {
                    DataRowView drv = this.Properties.TreeList.GetDataRecordByNode(node.Nodes[i]) as DataRowView;
                    if (drv != null)
                    {
                        string h_type = drv["类别编码"].ToString();
                        if (!string.IsNullOrEmpty(sb.ToString()))
                        {
                            sb.Append("，");
                        }
                        sb.AppendFormat("'{0}'", h_type);
                    }
                }
            }
        }
        private void GetNameChecked(TreeListNode node, StringBuilder sb)
        {

            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].HasChildren)
                {
                    GetNameChecked(node.Nodes[i], sb);
                }
                if (node.Nodes[i].Checked)
                {
                    DataRowView drv = this.Properties.TreeList.GetDataRecordByNode(node.Nodes[i]) as DataRowView;
                    if (drv != null)
                    {
                        string h_name = drv["类别名称"].ToString();
                        if (!string.IsNullOrEmpty(sb.ToString()))
                        {
                            sb.Append("，");
                        }
                        sb.AppendFormat("{0}", h_name);
                    }
                }
            }
        }
        #endregion

        #region 情况条件递归
        private void ClearChecked(TreeListNode node)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].HasChildren)
                {
                    ClearChecked(node.Nodes[i]);
                }
                if (node.Nodes[i].Checked)
                {
                    node.Nodes[i].CheckState = System.Windows.Forms.CheckState.Unchecked;
                }
            }
        }
        #endregion

        private void InitializeComponent()
        {
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.fPropertiesTreeList = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPropertiesTreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fProperties.Name = "fProperties";
            this.fProperties.TreeList = this.fPropertiesTreeList;
            // 
            // fPropertiesTreeList
            // 
            this.fPropertiesTreeList.Location = new System.Drawing.Point(0, 0);
            this.fPropertiesTreeList.Name = "fPropertiesTreeList";
            this.fPropertiesTreeList.OptionsBehavior.EnableFiltering = true;
            this.fPropertiesTreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.fPropertiesTreeList.Size = new System.Drawing.Size(400, 200);
            this.fPropertiesTreeList.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPropertiesTreeList)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
