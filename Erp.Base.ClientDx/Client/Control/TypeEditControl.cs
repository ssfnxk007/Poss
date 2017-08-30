using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using System.ComponentModel;
using Erp.Base.Facade;

namespace Erp.Base.UI
{
   public class TypeEditControl:TreeListLookUpEdit
    {
       private DevExpress.XtraTreeList .TreeList treeList = new DevExpress.XtraTreeList.TreeList ();
       public TypeEditControl()
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
           this.Properties.AutoExpandAllNodes = false;
           SetDataSource();
       }

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

        //设置数据源
        private void SetDataSource()
        {
            if (!DesignMode)
            {
                this.Properties.DataSource = CallerFactory<IDz_typeService>.Instance.GetTypeLevelList();
            }
        }
    }
}
