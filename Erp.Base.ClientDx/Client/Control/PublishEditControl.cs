using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WHC.Dictionary;

namespace Erp.Base.UI
{
    public class PublishEditControl : SearchLookUpEdit
    {
        #region 变量定义
        private new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit fProperties;
        private DevExpress.XtraGrid.Views.Grid.GridView fPropertiesView;

        #endregion

        #region 属性


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

        #region 构造方法
        public PublishEditControl()
        {
            InitializeComponent();
            this.Properties.NullValuePromptShowForEmptyValue = true;
            this.Properties.NullValuePrompt = "请选择...";
            this.Properties.DisplayMember = "显示值";
            this.Properties.ValueMember = "项目值";
            this.Properties.PopupFormMinSize = new System.Drawing.Size(300, 250);
            this.Properties.PopupFormSize = new System.Drawing.Size(300, 250);
            this.SetDataSource();
        }
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.fPropertiesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPropertiesView)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fProperties.Name = "fProperties";
            this.fProperties.View = this.fPropertiesView;
            // 
            // fPropertiesView
            // 
            this.fPropertiesView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.fPropertiesView.Name = "fPropertiesView";
            this.fPropertiesView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fPropertiesView.OptionsView.ShowGroupPanel = false;
            // 
            // StationEditControl
            // 
            this.EditValue = "";
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPropertiesView)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region 数据源
        private void SetDataSource()
        {
            if (!DesignMode)
            {
                this.Properties.DataSource = DictItemUtil.PubByEditor();
            }

        }
        #endregion
    }
}
