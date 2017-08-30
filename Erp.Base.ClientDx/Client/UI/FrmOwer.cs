using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using WHC.Pager.WinControl;
using WHC.Dictionary;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using WHC.Security;

using Erp.Base.Facade;
using Erp.Base.Entity;

namespace Erp.Base.UI
{
    public class FrmOwer:BaseForm
    {
        #region 界面布局
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtOw_address;
        private DevExpress.XtraEditors.TextEdit txtOw_contact_man;
        private DevExpress.XtraEditors.TextEdit txtOw_tel;
        private DevExpress.XtraEditors.TextEdit txtOw_fax;
        private DevExpress.XtraEditors.TextEdit txtOw_account;
        private DevExpress.XtraEditors.TextEdit txtOw_bank;
        private DevExpress.XtraEditors.TextEdit txtOw_tax;
        private DevExpress.XtraEditors.TextEdit txtOw_zip;
        private DevExpress.XtraEditors.TextEdit txtOw_mail;
        private DevExpress.XtraEditors.TextEdit txtOw_tax_address;
        private DevExpress.XtraEditors.TextEdit txtOw_tax_account;
        private DevExpress.XtraEditors.TextEdit txtOw_tax_bank;
        private DevExpress.XtraEditors.DateEdit txtOw_date;
        private DevExpress.XtraEditors.TextEdit txtCurrent_month;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraEditors.TextEdit txtOw_departement;
        private DevExpress.XtraEditors.MemoEdit txtMemo;
        private DevExpress.XtraEditors.TextEdit txtMin_codenumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraEditors.SimpleButton btnStation;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.TreeListLookUpEdit txtStation_id_gyl;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.LookUpEdit txtCompute_method;
        private DevExpress.XtraEditors.LookUpEdit txtIs_posserver;
        private DevExpress.XtraEditors.LookUpEdit txtIs_network;
        private DevExpress.XtraEditors.LookUpEdit txtS_id;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraEditors.ComboBoxEdit txtDatabase_id;
        private DevExpress.XtraEditors.SimpleButton btnClose; 
        #endregion
        private OwnerInfo tempInfo = new OwnerInfo();
    
        public FrmOwer()
        {
            InitializeComponent();
            InitDict();
        }

        /// <summary>
        /// 初始化字典
        /// </summary>
        private void InitDict()
        {
            this.txtS_id.Properties.DisplayMember = "显示值";
            this.txtS_id.Properties.ValueMember = "项目值";
            this.txtS_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.StocksByEditor();

            this.txtStation_id_gyl.Properties.DisplayMember = "显示值";
            this.txtStation_id_gyl.Properties.ValueMember = "项目值";
            this.txtStation_id_gyl.Properties.DataSource = WHC.Security.SecurityUtil.GetAllStationForDropDown();

            this.txtCompute_method.Properties.DisplayMember = "显示值";
            this.txtCompute_method.Properties.ValueMember = "项目值";
            this.txtCompute_method.Properties.DataSource = BaseUtil.Compute_methodByEditor();

            this.txtIs_network.Properties.DisplayMember = "显示值";
            this.txtIs_network.Properties.ValueMember = "项目值";
            this.txtIs_network.Properties.DataSource = BaseUtil.Is_networkByEditor();

            this.txtIs_posserver.Properties.DisplayMember = "显示值";
            this.txtIs_posserver.Properties.ValueMember = "项目值";
            this.txtIs_posserver.Properties.DataSource =WHC.Dictionary.DictItemUtil.YesOrNoByEditor();       

        }


        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtStation_id_gyl = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.txtOw_departement = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_address = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_contact_man = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_tel = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_fax = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_account = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_bank = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_tax = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_zip = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_mail = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_tax_address = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_tax_account = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_tax_bank = new DevExpress.XtraEditors.TextEdit();
            this.txtOw_date = new DevExpress.XtraEditors.DateEdit();
            this.txtCurrent_month = new DevExpress.XtraEditors.TextEdit();
            this.txtMemo = new DevExpress.XtraEditors.MemoEdit();
            this.txtMin_codenumber = new DevExpress.XtraEditors.TextEdit();
            this.txtCompute_method = new DevExpress.XtraEditors.LookUpEdit();
            this.txtIs_posserver = new DevExpress.XtraEditors.LookUpEdit();
            this.txtIs_network = new DevExpress.XtraEditors.LookUpEdit();
            this.txtS_id = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDatabase_id = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnStation = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStation_id_gyl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_departement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_contact_man.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_fax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_bank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_zip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tax_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tax_account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tax_bank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrent_month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin_codenumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompute_method.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIs_posserver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIs_network.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtS_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtStation_id_gyl);
            this.layoutControl1.Controls.Add(this.txtOw_departement);
            this.layoutControl1.Controls.Add(this.txtOw_address);
            this.layoutControl1.Controls.Add(this.txtOw_contact_man);
            this.layoutControl1.Controls.Add(this.txtOw_tel);
            this.layoutControl1.Controls.Add(this.txtOw_fax);
            this.layoutControl1.Controls.Add(this.txtOw_account);
            this.layoutControl1.Controls.Add(this.txtOw_bank);
            this.layoutControl1.Controls.Add(this.txtOw_tax);
            this.layoutControl1.Controls.Add(this.txtOw_zip);
            this.layoutControl1.Controls.Add(this.txtOw_mail);
            this.layoutControl1.Controls.Add(this.txtOw_tax_address);
            this.layoutControl1.Controls.Add(this.txtOw_tax_account);
            this.layoutControl1.Controls.Add(this.txtOw_tax_bank);
            this.layoutControl1.Controls.Add(this.txtOw_date);
            this.layoutControl1.Controls.Add(this.txtCurrent_month);
            this.layoutControl1.Controls.Add(this.txtMemo);
            this.layoutControl1.Controls.Add(this.txtMin_codenumber);
            this.layoutControl1.Controls.Add(this.txtCompute_method);
            this.layoutControl1.Controls.Add(this.txtIs_posserver);
            this.layoutControl1.Controls.Add(this.txtIs_network);
            this.layoutControl1.Controls.Add(this.txtS_id);
            this.layoutControl1.Controls.Add(this.txtDatabase_id);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 335);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtStation_id_gyl
            // 
            this.txtStation_id_gyl.EditValue = "root";
            this.txtStation_id_gyl.Location = new System.Drawing.Point(391, 108);
            this.txtStation_id_gyl.Name = "txtStation_id_gyl";
            this.txtStation_id_gyl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStation_id_gyl.Properties.DisplayMember = "站点名称";
            this.txtStation_id_gyl.Properties.NullText = "";
            this.txtStation_id_gyl.Properties.PopupFormSize = new System.Drawing.Size(300, 400);
            this.txtStation_id_gyl.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.txtStation_id_gyl.Properties.ValueMember = "站点编码";
            this.txtStation_id_gyl.Size = new System.Drawing.Size(177, 20);
            this.txtStation_id_gyl.StyleController = this.layoutControl1;
            this.txtStation_id_gyl.TabIndex = 48;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.KeyFieldName = "站点编码";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(102, 88);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "父站点";
            this.treeListLookUpEdit1TreeList.RootValue = "ROOT";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // txtOw_departement
            // 
            this.txtOw_departement.Location = new System.Drawing.Point(111, 12);
            this.txtOw_departement.Name = "txtOw_departement";
            this.txtOw_departement.Size = new System.Drawing.Size(177, 20);
            this.txtOw_departement.StyleController = this.layoutControl1;
            this.txtOw_departement.TabIndex = 27;
            // 
            // txtOw_address
            // 
            this.txtOw_address.Location = new System.Drawing.Point(111, 36);
            this.txtOw_address.Name = "txtOw_address";
            this.txtOw_address.Size = new System.Drawing.Size(177, 20);
            this.txtOw_address.StyleController = this.layoutControl1;
            this.txtOw_address.TabIndex = 1;
            // 
            // txtOw_contact_man
            // 
            this.txtOw_contact_man.Location = new System.Drawing.Point(111, 60);
            this.txtOw_contact_man.Name = "txtOw_contact_man";
            this.txtOw_contact_man.Size = new System.Drawing.Size(177, 20);
            this.txtOw_contact_man.StyleController = this.layoutControl1;
            this.txtOw_contact_man.TabIndex = 2;
            // 
            // txtOw_tel
            // 
            this.txtOw_tel.Location = new System.Drawing.Point(111, 84);
            this.txtOw_tel.Name = "txtOw_tel";
            this.txtOw_tel.Size = new System.Drawing.Size(177, 20);
            this.txtOw_tel.StyleController = this.layoutControl1;
            this.txtOw_tel.TabIndex = 3;
            // 
            // txtOw_fax
            // 
            this.txtOw_fax.Location = new System.Drawing.Point(111, 108);
            this.txtOw_fax.Name = "txtOw_fax";
            this.txtOw_fax.Size = new System.Drawing.Size(177, 20);
            this.txtOw_fax.StyleController = this.layoutControl1;
            this.txtOw_fax.TabIndex = 4;
            // 
            // txtOw_account
            // 
            this.txtOw_account.Location = new System.Drawing.Point(111, 156);
            this.txtOw_account.Name = "txtOw_account";
            this.txtOw_account.Size = new System.Drawing.Size(177, 20);
            this.txtOw_account.StyleController = this.layoutControl1;
            this.txtOw_account.TabIndex = 5;
            // 
            // txtOw_bank
            // 
            this.txtOw_bank.Location = new System.Drawing.Point(111, 132);
            this.txtOw_bank.Name = "txtOw_bank";
            this.txtOw_bank.Size = new System.Drawing.Size(177, 20);
            this.txtOw_bank.StyleController = this.layoutControl1;
            this.txtOw_bank.TabIndex = 6;
            // 
            // txtOw_tax
            // 
            this.txtOw_tax.Location = new System.Drawing.Point(391, 132);
            this.txtOw_tax.Name = "txtOw_tax";
            this.txtOw_tax.Size = new System.Drawing.Size(177, 20);
            this.txtOw_tax.StyleController = this.layoutControl1;
            this.txtOw_tax.TabIndex = 7;
            // 
            // txtOw_zip
            // 
            this.txtOw_zip.Location = new System.Drawing.Point(391, 84);
            this.txtOw_zip.Name = "txtOw_zip";
            this.txtOw_zip.Size = new System.Drawing.Size(177, 20);
            this.txtOw_zip.StyleController = this.layoutControl1;
            this.txtOw_zip.TabIndex = 8;
            // 
            // txtOw_mail
            // 
            this.txtOw_mail.Location = new System.Drawing.Point(391, 156);
            this.txtOw_mail.Name = "txtOw_mail";
            this.txtOw_mail.Size = new System.Drawing.Size(177, 20);
            this.txtOw_mail.StyleController = this.layoutControl1;
            this.txtOw_mail.TabIndex = 9;
            // 
            // txtOw_tax_address
            // 
            this.txtOw_tax_address.Location = new System.Drawing.Point(111, 204);
            this.txtOw_tax_address.Name = "txtOw_tax_address";
            this.txtOw_tax_address.Size = new System.Drawing.Size(177, 20);
            this.txtOw_tax_address.StyleController = this.layoutControl1;
            this.txtOw_tax_address.TabIndex = 10;
            // 
            // txtOw_tax_account
            // 
            this.txtOw_tax_account.Location = new System.Drawing.Point(111, 180);
            this.txtOw_tax_account.Name = "txtOw_tax_account";
            this.txtOw_tax_account.Size = new System.Drawing.Size(177, 20);
            this.txtOw_tax_account.StyleController = this.layoutControl1;
            this.txtOw_tax_account.TabIndex = 11;
            // 
            // txtOw_tax_bank
            // 
            this.txtOw_tax_bank.Location = new System.Drawing.Point(111, 228);
            this.txtOw_tax_bank.Name = "txtOw_tax_bank";
            this.txtOw_tax_bank.Size = new System.Drawing.Size(177, 20);
            this.txtOw_tax_bank.StyleController = this.layoutControl1;
            this.txtOw_tax_bank.TabIndex = 12;
            // 
            // txtOw_date
            // 
            this.txtOw_date.EditValue = null;
            this.txtOw_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtOw_date.Location = new System.Drawing.Point(391, 12);
            this.txtOw_date.Name = "txtOw_date";
            this.txtOw_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOw_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOw_date.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.txtOw_date.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.txtOw_date.Size = new System.Drawing.Size(177, 20);
            this.txtOw_date.StyleController = this.layoutControl1;
            this.txtOw_date.TabIndex = 13;
            // 
            // txtCurrent_month
            // 
            this.txtCurrent_month.Location = new System.Drawing.Point(391, 252);
            this.txtCurrent_month.Name = "txtCurrent_month";
            this.txtCurrent_month.Size = new System.Drawing.Size(177, 20);
            this.txtCurrent_month.StyleController = this.layoutControl1;
            this.txtCurrent_month.TabIndex = 23;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(111, 276);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(457, 46);
            this.txtMemo.StyleController = this.layoutControl1;
            this.txtMemo.TabIndex = 22;
            // 
            // txtMin_codenumber
            // 
            this.txtMin_codenumber.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMin_codenumber.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMin_codenumber.Location = new System.Drawing.Point(391, 228);
            this.txtMin_codenumber.Name = "txtMin_codenumber";
            this.txtMin_codenumber.Size = new System.Drawing.Size(177, 20);
            this.txtMin_codenumber.StyleController = this.layoutControl1;
            this.txtMin_codenumber.TabIndex = 18;
            // 
            // txtCompute_method
            // 
            this.txtCompute_method.EditValue = "";
            this.txtCompute_method.Location = new System.Drawing.Point(391, 60);
            this.txtCompute_method.Name = "txtCompute_method";
            this.txtCompute_method.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCompute_method.Properties.NullText = "";
            this.txtCompute_method.Size = new System.Drawing.Size(177, 20);
            this.txtCompute_method.StyleController = this.layoutControl1;
            this.txtCompute_method.TabIndex = 28;
            // 
            // txtIs_posserver
            // 
            this.txtIs_posserver.EditValue = "";
            this.txtIs_posserver.Location = new System.Drawing.Point(391, 204);
            this.txtIs_posserver.Name = "txtIs_posserver";
            this.txtIs_posserver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIs_posserver.Properties.NullText = "";
            this.txtIs_posserver.Size = new System.Drawing.Size(177, 20);
            this.txtIs_posserver.StyleController = this.layoutControl1;
            this.txtIs_posserver.TabIndex = 15;
            // 
            // txtIs_network
            // 
            this.txtIs_network.EditValue = "*";
            this.txtIs_network.Location = new System.Drawing.Point(391, 36);
            this.txtIs_network.Name = "txtIs_network";
            this.txtIs_network.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIs_network.Properties.NullText = "";
            this.txtIs_network.Size = new System.Drawing.Size(177, 20);
            this.txtIs_network.StyleController = this.layoutControl1;
            this.txtIs_network.TabIndex = 14;
            // 
            // txtS_id
            // 
            this.txtS_id.EditValue = "";
            this.txtS_id.Location = new System.Drawing.Point(111, 252);
            this.txtS_id.Name = "txtS_id";
            this.txtS_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtS_id.Properties.NullText = "";
            this.txtS_id.Properties.ReadOnly = true;
            this.txtS_id.Size = new System.Drawing.Size(177, 20);
            this.txtS_id.StyleController = this.layoutControl1;
            this.txtS_id.TabIndex = 17;
            // 
            // txtDatabase_id
            // 
            this.txtDatabase_id.EditValue = "";
            this.txtDatabase_id.Location = new System.Drawing.Point(391, 180);
            this.txtDatabase_id.Name = "txtDatabase_id";
            this.txtDatabase_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDatabase_id.Properties.PopupSizeable = true;
            this.txtDatabase_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDatabase_id.Size = new System.Drawing.Size(177, 20);
            this.txtDatabase_id.StyleController = this.layoutControl1;
            this.txtDatabase_id.TabIndex = 21;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem17,
            this.layoutControlItem22,
            this.layoutControlItem16,
            this.layoutControlItem6,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem21,
            this.layoutControlItem15,
            this.layoutControlItem18,
            this.layoutControlItem23,
            this.layoutControlItem19,
            this.layoutControlItem20});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 335);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtOw_address;
            this.layoutControlItem1.CustomizationFormText = "通讯地址";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "通讯地址";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtOw_contact_man;
            this.layoutControlItem2.CustomizationFormText = "联系人";
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "联系人";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtOw_tel;
            this.layoutControlItem3.CustomizationFormText = "电话";
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "电话";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtOw_fax;
            this.layoutControlItem4.CustomizationFormText = "传真";
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "传真";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtOw_account;
            this.layoutControlItem5.CustomizationFormText = "账号";
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "账号";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtOw_tax_account;
            this.layoutControlItem11.CustomizationFormText = "增值税发票账号";
            this.layoutControlItem11.FillControlToClientArea = false;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "增值税发票账号";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtOw_tax_bank;
            this.layoutControlItem12.CustomizationFormText = "增值税发票开户行";
            this.layoutControlItem12.FillControlToClientArea = false;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "增值税发票开户行";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem17.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem17.Control = this.txtS_id;
            this.layoutControlItem17.CustomizationFormText = "出入库房";
            this.layoutControlItem17.FillControlToClientArea = false;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem17.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.Text = "出入库房";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.txtMemo;
            this.layoutControlItem22.CustomizationFormText = "备注";
            this.layoutControlItem22.FillControlToClientArea = false;
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem22.MaxSize = new System.Drawing.Size(560, 50);
            this.layoutControlItem22.MinSize = new System.Drawing.Size(560, 50);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(564, 51);
            this.layoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem22.Text = "备注";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.txtOw_departement;
            this.layoutControlItem16.CustomizationFormText = "单位名称";
            this.layoutControlItem16.FillControlToClientArea = false;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.Text = "单位名称";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtOw_bank;
            this.layoutControlItem6.CustomizationFormText = "开户银行";
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "开户银行";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.txtOw_date;
            this.layoutControlItem13.CustomizationFormText = "录单时间";
            this.layoutControlItem13.FillControlToClientArea = false;
            this.layoutControlItem13.Location = new System.Drawing.Point(280, 0);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.Text = "录单时间";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtIs_network;
            this.layoutControlItem14.CustomizationFormText = "软件系列";
            this.layoutControlItem14.FillControlToClientArea = false;
            this.layoutControlItem14.Location = new System.Drawing.Point(280, 24);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.Text = "软件系列";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtOw_zip;
            this.layoutControlItem8.CustomizationFormText = "邮政编码";
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Location = new System.Drawing.Point(280, 72);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "邮政编码";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtOw_tax;
            this.layoutControlItem7.CustomizationFormText = "税号";
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(280, 120);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "税号";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtOw_mail;
            this.layoutControlItem9.CustomizationFormText = "电子邮件";
            this.layoutControlItem9.FillControlToClientArea = false;
            this.layoutControlItem9.Location = new System.Drawing.Point(280, 144);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "电子邮件";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtOw_tax_address;
            this.layoutControlItem10.CustomizationFormText = "增值发票地址";
            this.layoutControlItem10.FillControlToClientArea = false;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "增值发票地址";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem21.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem21.Control = this.txtDatabase_id;
            this.layoutControlItem21.CustomizationFormText = "数据库码";
            this.layoutControlItem21.FillControlToClientArea = false;
            this.layoutControlItem21.Location = new System.Drawing.Point(280, 168);
            this.layoutControlItem21.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem21.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem21.Text = "数据库码";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem15.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem15.Control = this.txtIs_posserver;
            this.layoutControlItem15.CustomizationFormText = "POS服务";
            this.layoutControlItem15.FillControlToClientArea = false;
            this.layoutControlItem15.Location = new System.Drawing.Point(280, 192);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.Text = "POS服务";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem18.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem18.Control = this.txtMin_codenumber;
            this.layoutControlItem18.CustomizationFormText = "开始单号";
            this.layoutControlItem18.FillControlToClientArea = false;
            this.layoutControlItem18.Location = new System.Drawing.Point(280, 216);
            this.layoutControlItem18.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem18.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem18.Text = "开始单号";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem23.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem23.Control = this.txtCurrent_month;
            this.layoutControlItem23.CustomizationFormText = "当前月份";
            this.layoutControlItem23.FillControlToClientArea = false;
            this.layoutControlItem23.Location = new System.Drawing.Point(280, 240);
            this.layoutControlItem23.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem23.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem23.Text = "当前月份";
            this.layoutControlItem23.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem19.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem19.Control = this.txtCompute_method;
            this.layoutControlItem19.CustomizationFormText = "计算模式";
            this.layoutControlItem19.FillControlToClientArea = false;
            this.layoutControlItem19.Location = new System.Drawing.Point(280, 48);
            this.layoutControlItem19.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem19.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem19.Text = "计算模式";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(96, 14);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.txtStation_id_gyl;
            this.layoutControlItem20.CustomizationFormText = "供应链站点";
            this.layoutControlItem20.FillControlToClientArea = false;
            this.layoutControlItem20.Location = new System.Drawing.Point(280, 96);
            this.layoutControlItem20.MaxSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem20.MinSize = new System.Drawing.Size(280, 24);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem20.Text = "供应链站点";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(96, 14);
            // 
            // btnStation
            // 
            this.btnStation.Location = new System.Drawing.Point(118, 348);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(85, 23);
            this.btnStation.TabIndex = 8;
            this.btnStation.Text = "站点单位定义";
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(246, 348);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(374, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmOwer
            // 
            this.ClientSize = new System.Drawing.Size(584, 380);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnStation);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmOwer";
            this.Text = "本单位定义";
            this.Load += new System.EventHandler(this.FrmOwer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStation_id_gyl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_departement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_contact_man.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_fax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_bank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_zip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tax_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tax_account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_tax_bank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOw_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrent_month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin_codenumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompute_method.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIs_posserver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIs_network.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtS_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// 显示信息
        /// </summary>
        private void DisplayData()
        {      
                #region 显示信息
                OwnerInfo info = CallerFactory<IOwnerService>.Instance.FindLast();
                if (info != null)
                {
                    tempInfo = info;//重新给临时对象赋值，使之指向存在的记录对象
                    txtOw_departement.Text = info.Ow_department;
                    txtOw_address.Text = info.Ow_address;
                    txtOw_contact_man.Text = info.Ow_contact_man;
                    txtOw_tel.Text = info.Ow_tel;
                    txtOw_fax.Text = info.Ow_fax;
                    txtOw_account.Text = info.Ow_account;
                    txtOw_bank.Text = info.Ow_bank;
                    txtOw_tax.Text = info.Ow_tax;
                    txtOw_zip.Text = info.Ow_zip;
                    txtOw_mail.Text = info.Ow_mail;
                    txtOw_tax_address.Text = info.Ow_tax_address;
                    txtOw_tax_account.Text = info.Ow_tax_account;
                    txtOw_tax_bank.Text = info.Ow_tax_bank;
                    txtOw_date.Text = info.Ow_date.ToString();
                    txtIs_network.EditValue = info.Is_network;
                    txtIs_posserver.EditValue = info.Is_posserver;
                    txtS_id.EditValue = info.S_id;
                    txtMin_codenumber.Text = info.Min_codenumber.ToString();
                    txtDatabase_id.EditValue = info.Database_id;
                    txtMemo.Text = info.Memo;
                    txtCurrent_month.Text = info.Current_month;
                    txtCompute_method.EditValue = info.Compute_method;
                    txtStation_id_gyl.EditValue = info.Station_id_gyl;
                }
                #endregion



        }

        private void FrmOwer_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        /// <summary>
        /// 实体赋值
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(OwnerInfo info)
        {
            info.Ow_department = txtOw_departement.Text;
            info.Ow_address = txtOw_address.Text;
            info.Ow_contact_man = txtOw_contact_man.Text;
            info.Ow_tel = txtOw_tel.Text;
            info.Ow_fax = txtOw_fax.Text;
            info.Ow_account = txtOw_account.Text;
            info.Ow_bank = txtOw_bank.Text;
            info.Ow_tax = txtOw_tax.Text;
            info.Ow_zip = txtOw_zip.Text;
            info.Ow_mail = txtOw_mail.Text;
            info.Ow_tax_address = txtOw_tax_address.Text;
            info.Ow_tax_account = txtOw_tax_account.Text;
            info.Ow_tax_bank = txtOw_tax_bank.Text;
            info.Ow_date = txtOw_date.DateTime;
            info.Is_network = txtIs_network.EditValue.ToString();
            info.Is_posserver = txtIs_posserver.EditValue.ToString();
            info.S_id = txtS_id.EditValue.ToString();
            info.Min_codenumber = txtMin_codenumber.Text.ToInt32();
            info.Database_id = txtDatabase_id.EditValue.ToString();
            info.Memo = txtMemo.Text;
            info.Current_month = txtCurrent_month.Text;
            info.Compute_method = txtCompute_method.EditValue.ToString();
            info.Station_id_gyl = txtStation_id_gyl.EditValue.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveUpdate();
        }

        private bool SaveUpdate()
        {
            OwnerInfo info = CallerFactory<IOwnerService>.Instance.FindByID(txtOw_departement.Text);
            if (info != null)
            {
                SetInfo(info);

                try
                {
                    #region 更新数据
                    bool succeed = CallerFactory<IOwnerService>.Instance.Update(info, info.Ow_department);
                    if (succeed)
                    {
                        MessageDxUtil.ShowTips("保存成功！");
                        return true;
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
            }
           return false;
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            FrmStationDepartment f = new FrmStationDepartment();
            f.ShowDialog();
        }
    }

}

