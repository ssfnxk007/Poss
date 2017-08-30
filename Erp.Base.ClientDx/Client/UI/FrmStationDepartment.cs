using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using DevExpress.XtraEditors.Repository;
using WHC.Pager.WinControl;
using WHC.Dictionary;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using WHC.Security;

using Erp.Base.Facade;
using WHC.Security.Facade;
using System.Data;
using WHC.Security.Entity;

namespace Erp.Base.UI
{
    public class FrmStationDepartment:BaseForm
    {
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private WinGridView winGridView1;
        
        List< Station_totalInfo> listinfo = new List<Station_totalInfo>();
    
        public FrmStationDepartment()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.winGridView1.EnableEdit = false;
            this.winGridView1.EnableMenu = true;
            this.winGridView1.HaveProduct = false;
            this.winGridView1.Location = new System.Drawing.Point(0, 0);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(521, 274);
            this.winGridView1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(152, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(277, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmStationDepartment
            // 
            this.ClientSize = new System.Drawing.Size(521, 313);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.winGridView1);
            this.Name = "FrmStationDepartment";
            this.Load += new System.EventHandler(this.FrmStationDepartment_Load);
            this.ResumeLayout(false);

        }

        private void BindData()
        {

            SetColumns();
            listinfo = CallerFactory<IStation_totalService>.Instance.GetAll();
            winGridView1.DataSource = listinfo;
        }

        /// <summary>
        /// 设置列表
        /// </summary>
        private void SetColumns()
        {
            winGridView1.AddColumnAlias("STATION_ID", "站点ID");
            winGridView1.AddColumnAlias("STATION_NAME", "站点名称");
            winGridView1.AddColumnAlias("MY_DEPARTMENT", "单位名称");
            winGridView1.AddColumnAlias("MY_ADRESS", "单位地址");
            winGridView1.AddColumnAlias("MY_CONTACT_MAN", "联系人");
            winGridView1.AddColumnAlias("MY_TEL", "联系电话");
            winGridView1.AddColumnAlias("MY_ZIP", "邮政编码");
            winGridView1.AddColumnAlias("MY_FAX", "传真");
            winGridView1.AddColumnAlias("MY_MAIL", "电子邮件");
            winGridView1.AddColumnAlias("MY_ACCOUNT", "账号");
            winGridView1.AddColumnAlias("MY_BANK", "开户行");
            winGridView1.AddColumnAlias("IS_EFFECTIVE", "是否有效"); 
            
        }

        private void FrmStationDepartment_Load(object sender, EventArgs e)
        {
            winGridView1.DisplayColumns = "station_id,station_name,my_department,my_adress,my_contact_man,my_tel,my_zip,my_fax,my_mail,my_account,my_bank,is_effective";
            this.winGridView1.EnableEdit = true;
            this.winGridView1.ReadOnlyList.Add("Station_id");
            this.winGridView1.ReadOnlyList.Add("Station_name");

            BindData();
            RepositoryItemLookUpEdit lookup = new RepositoryItemLookUpEdit();
            lookup.DisplayMember = "项目值";
            lookup.ValueMember = "显示值";
            lookup.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();
            winGridView1.gridView1.Columns["Is_effective"].ColumnEdit = lookup;
            winGridView1.gridView1.Columns["Is_effective"].ColumnEdit = WHC.Dictionary.DictItemUtil.YesorNoByGrid();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach(Station_totalInfo info in listinfo)
            {
                if(CallerFactory<IStation_totalService>.Instance.IsExistKey("Station_id",info.Station_id))
                {
                    try
                    {
                        bool Update = CallerFactory<IStation_totalService>.Instance.Update(info, info.Station_id);
                    }
                    catch (Exception ex)
                    {
                        MessageDxUtil.ShowError("更新失败！");
                    }
                }
            }
            MessageDxUtil.ShowTips("保存成功！");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
      
    }
}
