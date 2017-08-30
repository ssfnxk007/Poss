using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Erp.Base.BLL;
using Erp.Base.Entity;
using Erp.Base.Facade;

using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using WHC.Framework.ControlUtil.Facade;




namespace Erp.Base.UI
{
    public class FrmDz_Type:BaseForm
    {
        #region 变量
        private string ID = string.Empty;
        private bool isNew = false;
        /// <summary>
        /// 创建一个临时对象，方便在附件管理中获取存在的GUID
        /// </summary>
        private Dz_typeInfo tempInfo = new Dz_typeInfo();

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtpassword;
        private DevExpress.XtraEditors.TextEdit txtmin_tj_amount;
        private DevExpress.XtraEditors.TextEdit txtquery_days;
        private DevExpress.XtraEditors.TextEdit txtType_name;
        private DevExpress.XtraEditors.TextEdit txtH_type;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnExpandAll;
        private DevExpress.XtraEditors.SimpleButton btnCollapseAll;
        private ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.TreeListLookUpEdit txtType_id;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.SimpleButton btnDownAdd;
        private DevExpress.XtraEditors.MemoEdit txttype_mem;
        private DevExpress.XtraEditors.SearchLookUpEdit txth_charge_man;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txt_last_mod_time;
        private DevExpress.XtraLayout.LayoutControlItem itemlast_mod_date;
        private System.Windows.Forms.TreeView treeView1;
        
        #endregion
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDz_Type));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_last_mod_time = new DevExpress.XtraEditors.TextEdit();
            this.txtType_id = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.txtmin_tj_amount = new DevExpress.XtraEditors.TextEdit();
            this.txtquery_days = new DevExpress.XtraEditors.TextEdit();
            this.txtType_name = new DevExpress.XtraEditors.TextEdit();
            this.txtH_type = new DevExpress.XtraEditors.TextEdit();
            this.txttype_mem = new DevExpress.XtraEditors.MemoEdit();
            this.txth_charge_man = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemlast_mod_date = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDownAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpandAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnCollapseAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_last_mod_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmin_tj_amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquery_days.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype_mem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txth_charge_man.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemlast_mod_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TreeView.Icon.png");
            this.imageList1.Images.SetKeyName(1, "ok.ico");
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeView1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(880, 508);
            this.splitContainerControl1.SplitterPosition = 243;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 20;
            this.treeView1.LineColor = System.Drawing.Color.Green;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(243, 508);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.txt_last_mod_time);
            this.layoutControl1.Controls.Add(this.txtType_id);
            this.layoutControl1.Controls.Add(this.txtpassword);
            this.layoutControl1.Controls.Add(this.txtmin_tj_amount);
            this.layoutControl1.Controls.Add(this.txtquery_days);
            this.layoutControl1.Controls.Add(this.txtType_name);
            this.layoutControl1.Controls.Add(this.txtH_type);
            this.layoutControl1.Controls.Add(this.txttype_mem);
            this.layoutControl1.Controls.Add(this.txth_charge_man);
            this.layoutControl1.Location = new System.Drawing.Point(0, 70);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(0, -8, 1378, 780);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(627, 434);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_last_mod_time
            // 
            this.txt_last_mod_time.Location = new System.Drawing.Point(463, 56);
            this.txt_last_mod_time.Name = "txt_last_mod_time";
            this.txt_last_mod_time.Properties.Mask.EditMask = "F";
            this.txt_last_mod_time.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txt_last_mod_time.Properties.ReadOnly = true;
            this.txt_last_mod_time.Size = new System.Drawing.Size(145, 20);
            this.txt_last_mod_time.StyleController = this.layoutControl1;
            this.txt_last_mod_time.TabIndex = 12;
            // 
            // txtType_id
            // 
            this.txtType_id.EditValue = "";
            this.txtType_id.Location = new System.Drawing.Point(63, 56);
            this.txtType_id.Name = "txtType_id";
            this.txtType_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtType_id.Properties.DisplayMember = "类别名称";
            this.txtType_id.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.txtType_id.Properties.ValueMember = "类别编码";
            this.txtType_id.Size = new System.Drawing.Size(145, 20);
            this.txtType_id.StyleController = this.layoutControl1;
            this.txtType_id.TabIndex = 11;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.KeyFieldName = "类别编码";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "上级分类";
            this.treeListLookUpEdit1TreeList.RootValue = "ROOT";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(263, 80);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(145, 20);
            this.txtpassword.StyleController = this.layoutControl1;
            this.txtpassword.TabIndex = 10;
            // 
            // txtmin_tj_amount
            // 
            this.txtmin_tj_amount.Location = new System.Drawing.Point(63, 80);
            this.txtmin_tj_amount.Name = "txtmin_tj_amount";
            this.txtmin_tj_amount.Size = new System.Drawing.Size(145, 20);
            this.txtmin_tj_amount.StyleController = this.layoutControl1;
            this.txtmin_tj_amount.TabIndex = 9;
            // 
            // txtquery_days
            // 
            this.txtquery_days.Location = new System.Drawing.Point(263, 56);
            this.txtquery_days.Name = "txtquery_days";
            this.txtquery_days.Size = new System.Drawing.Size(145, 20);
            this.txtquery_days.StyleController = this.layoutControl1;
            this.txtquery_days.TabIndex = 7;
            // 
            // txtType_name
            // 
            this.txtType_name.Location = new System.Drawing.Point(363, 32);
            this.txtType_name.Name = "txtType_name";
            this.txtType_name.Size = new System.Drawing.Size(245, 20);
            this.txtType_name.StyleController = this.layoutControl1;
            this.txtType_name.TabIndex = 5;
            // 
            // txtH_type
            // 
            this.txtH_type.Location = new System.Drawing.Point(63, 32);
            this.txtH_type.Name = "txtH_type";
            this.txtH_type.Size = new System.Drawing.Size(245, 20);
            this.txtH_type.StyleController = this.layoutControl1;
            this.txtH_type.TabIndex = 4;
            // 
            // txttype_mem
            // 
            this.txttype_mem.Location = new System.Drawing.Point(63, 104);
            this.txttype_mem.MaximumSize = new System.Drawing.Size(0, 72);
            this.txttype_mem.MinimumSize = new System.Drawing.Size(0, 72);
            this.txttype_mem.Name = "txttype_mem";
            this.txttype_mem.Size = new System.Drawing.Size(545, 72);
            this.txttype_mem.StyleController = this.layoutControl1;
            this.txttype_mem.TabIndex = 8;
            // 
            // txth_charge_man
            // 
            this.txth_charge_man.Location = new System.Drawing.Point(463, 80);
            this.txth_charge_man.Name = "txth_charge_man";
            this.txth_charge_man.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txth_charge_man.Properties.NullText = "";
            this.txth_charge_man.Properties.PopupFormSize = new System.Drawing.Size(300, 200);
            this.txth_charge_man.Properties.View = this.searchLookUpEdit1View;
            this.txth_charge_man.Size = new System.Drawing.Size(145, 20);
            this.txth_charge_man.StyleController = this.layoutControl1;
            this.txth_charge_man.TabIndex = 6;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem10,
            this.itemlast_mod_date});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(627, 434);
            this.layoutControlGroup1.Text = "详细信息";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtH_type;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "类别编码";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtType_name;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(300, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(307, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "类别名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtquery_days;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "查询天数";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txttype_mem;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(600, 72);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(600, 25);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(607, 322);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "备注";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtmin_tj_amount;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "调剂阀值";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtpassword;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(200, 48);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "保护密码";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txth_charge_man;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(400, 48);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "主管人";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtType_id;
            this.layoutControlItem10.CustomizationFormText = "上级类别";
            this.layoutControlItem10.FillControlToClientArea = false;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "上级类别";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(48, 14);
            // 
            // itemlast_mod_date
            // 
            this.itemlast_mod_date.Control = this.txt_last_mod_time;
            this.itemlast_mod_date.CustomizationFormText = "最后修改日期";
            this.itemlast_mod_date.FillControlToClientArea = false;
            this.itemlast_mod_date.Location = new System.Drawing.Point(400, 24);
            this.itemlast_mod_date.MaxSize = new System.Drawing.Size(200, 24);
            this.itemlast_mod_date.MinSize = new System.Drawing.Size(200, 24);
            this.itemlast_mod_date.Name = "itemlast_mod_date";
            this.itemlast_mod_date.Size = new System.Drawing.Size(207, 24);
            this.itemlast_mod_date.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.itemlast_mod_date.Text = "修改日期";
            this.itemlast_mod_date.TextSize = new System.Drawing.Size(48, 14);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImagePadding = new System.Windows.Forms.Padding(3);
            this.groupControl1.Controls.Add(this.btnDownAdd);
            this.groupControl1.Controls.Add(this.btnExpandAll);
            this.groupControl1.Controls.Add(this.btnCollapseAll);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Location = new System.Drawing.Point(0, 4);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(627, 62);
            this.groupControl1.TabIndex = 0;
            // 
            // btnDownAdd
            // 
            this.btnDownAdd.Location = new System.Drawing.Point(95, 28);
            this.btnDownAdd.Name = "btnDownAdd";
            this.btnDownAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDownAdd.TabIndex = 5;
            this.btnDownAdd.Text = "向下分类";
            this.btnDownAdd.Click += new System.EventHandler(this.btnUpAdd_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Location = new System.Drawing.Point(411, 28);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(75, 23);
            this.btnExpandAll.TabIndex = 4;
            this.btnExpandAll.Text = "全部展开";
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Location = new System.Drawing.Point(332, 28);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(75, 23);
            this.btnCollapseAll.TabIndex = 4;
            this.btnCollapseAll.Text = "全部收起";
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmDz_Type
            // 
            this.ClientSize = new System.Drawing.Size(880, 508);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmDz_Type";
            this.Text = "商品类别维护";
            this.Load += new System.EventHandler(this.FrmDz_Type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_last_mod_time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmin_tj_amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquery_days.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype_mem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txth_charge_man.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemlast_mod_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public FrmDz_Type()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 树初始化
        /// </summary>
        private void InitTreeView()
        {
            Cursor = Cursors.WaitCursor;
            this.treeView1.Nodes.Clear();
            this.treeView1.BeginUpdate();
            List<Dz_typeInfo> typeNodeList=CallerFactory<IDz_typeService>.Instance.GetAllType();
            TreeNode node = treeView1.Nodes.Add("ROOT", "商品类别", 0, 1);
            node.Tag = "ROOT";
            List<Dz_typeInfo> listFind = typeNodeList.FindAll(delegate(Dz_typeInfo s)
            {
                return s.Type_id.Trim() == "ROOT";
            }
            );

            foreach (Dz_typeInfo info in listFind)
            {
                AddTree(node, info, typeNodeList);
            }
            this.treeView1.EndUpdate();
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// 添加Nodes
        /// </summary>
        /// <param name="pNode"></param>
        /// <param name="info"></param>
        /// <param name="allList"></param>
        private void AddTree(TreeNode pNode, Dz_typeInfo info ,List<Dz_typeInfo> allList)
        {
            TreeNode node = null;

            node = new TreeNode(info.Type_name, 0, 1);
            node.Tag = info.H_type.Trim();
            pNode.Nodes.Add(node);

            List<Dz_typeInfo> templist = allList.FindAll(delegate(Dz_typeInfo s)
            {
                return s.Type_id.Trim() == info.H_type.Trim();
            }
            );

            foreach (Dz_typeInfo subInfo in templist)
            {
                AddTree(node, subInfo,allList);
            }
        }

        private void FrmDz_Type_Load(object sender, EventArgs e)
        {
            this.InitTreeView();
            this.InitDictItem();
            btnAdd.Enabled = Portal.gc.HasFunction("TypeInfo/Add");
            btnDelete.Enabled = Portal.gc.HasFunction("TypeInfo/Delete");
            this.btnSave.Enabled = Portal.gc.HasFunction("TypeInfo/Edit");

       
        }

       

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            this.treeView1.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            this.treeView1.CollapseAll();
            this.ID = string.Empty;
            this.ClearScreen();
       
          
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                this.ID = e.Node.Tag.ToString();
                if (ID == "ROOT")
                {
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = false;
                    ClearScreen();
                    return;
                }
                DisplayData();
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;
            }
            else
            {
                ID = string.Empty;
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;
                this.ClearScreen();
            }
            this.txtH_type.Focus();
        }


        /// <summary>
        /// 实现控件输入检查的函数
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            bool result = true;//默认是可以通过

            #region MyRegion
            if (this.txtType_name.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入类别名称!");
                this.txtType_name.Focus();
                result = false;
            }
            else if (this.txtH_type.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入类别编码!");
                this.txtH_type.Focus();
                result = false;
            }
            else if (this.txtType_id.EditValue.ToString().Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择上级分类!");
                this.txtType_id.Focus();
                result = false;
            }
            #endregion

            return result;
        }

        /// <summary>
        /// 初始化数据字典
        /// </summary>
        private void InitDictItem()
        {
            //初始化代码
            txtType_id.Properties.DataSource = null;
            txtType_id.Properties.DataSource = CallerFactory<IDz_typeService>.Instance.GetTreeListType();

            txth_charge_man.Properties.DisplayMember = "显示值";
            txth_charge_man.Properties.ValueMember = "项目值";
            txth_charge_man.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

        }

        /// <summary>
        /// 数据显示的函数
        /// </summary>
        public void DisplayData()
        {
            InitDictItem();//数据字典加载（公用）
            txtH_type.Properties.ReadOnly = true;
            if (!string.IsNullOrEmpty(ID))
            {
                #region 显示信息
                Dz_typeInfo info = CallerFactory<IDz_typeService>.Instance.FindByID(ID);
                if (info != null)
                {
                    tempInfo = info;//重新给临时对象赋值，使之指向存在的记录对象

                    this.txtType_name.Text = info.Type_name;
                    this.txtH_type.Text = info.H_type.Trim();
                    this.txtpassword.Text = info.Password;
                    this.txth_charge_man.Text = info.H_charge_man;
                    this.txtmin_tj_amount.Text = info.Min_tj_amount.ToString();
                    this.txtpassword.Text = info.Password;
                    this.txtType_id.EditValue = info.Type_id.Trim();
                    this.txttype_mem.Text = info.Type_mem;
                    txt_last_mod_time.Text = info.Last_mod_date.ToString("yyyy-MM-dd HH:mm:ss");
                }
                #endregion
                //this.btnOK.Enabled = Portal.gc.HasFunction("Dz_type/Edit");             
            }
            else
            {
                //this.btnOK.Enabled = Portal.gc.HasFunction("Dz_type/Add");  
            }

            //tempInfo在对象存在则为指定对象，新建则是全新的对象，但有一些初始化的GUID用于附件上传
            //SetAttachInfo(tempInfo);
        }

        //private void SetAttachInfo(Dz_typeInfo info)
        //{
        //    this.attachmentGUID.AttachmentGUID = info.AttachGUID;
        //    this.attachmentGUID.userId = LoginUserInfo.Name;

        //    string name = txtName.Text;
        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        string dir = string.Format("{0}", name);
        //        this.attachmentGUID.Init(dir, tempInfo.ID, LoginUserInfo.Name);
        //    }
        //}

        public void ClearScreen()
        {
            this.tempInfo = new Dz_typeInfo();
            this.txtType_name.Text = string.Empty;
            this.txtH_type.Text = string.Empty;
            this.txtpassword.Text = string.Empty;
            this.txth_charge_man.Text = string.Empty;
            this.txtmin_tj_amount.Text = string.Empty;
            this.txtpassword.Text = string.Empty;
            this.txtType_id.EditValue = string.Empty;
            this.txttype_mem.Text = string.Empty;
        }

        /// <summary>
        /// 编辑或者保存状态下取值函数
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(Dz_typeInfo info)
        {
            info.Type_name = this.txtType_name.Text;
            info.H_type = this.txtH_type.Text.Trim();
            info.Password = this.txtpassword.Text;
            info.H_charge_man = this.txth_charge_man.Text;
            info.Min_tj_amount = this.txtmin_tj_amount.Text.ToInt32();
            info.Password = this.txtpassword.Text;
            info.Type_id = this.txtType_id.EditValue.ToString().Trim();
            info.Type_mem = this.txttype_mem.Text;
            info.Last_mod_date = itemlast_mod_date.ToString().ToDateTime();
        }

        /// <summary>
        /// 新增状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public bool SaveAddNew()
        {
            Dz_typeInfo info = tempInfo;//必须使用存在的局部变量，因为部分信息可能被附件使用
            SetInfo(info);
            if (!Portal.gc.HasFunction("TypeInfo/Add"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("TypeInfo/Add", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                return false;
            }

            try
            {
                #region 新增数据

                bool succeed = CallerFactory<IDz_typeService>.Instance.Insert(info);
                if (succeed)
                {
                    //可添加其他关联操作
                    TreeNode node = this.FindNode(treeView1.Nodes[0], info.Type_id);
                    TreeNode newNode = new TreeNode();
                    newNode.Text = info.Type_name;
                    newNode.Tag = info.H_type;
                    newNode.SelectedImageIndex = 1;
                    newNode.ImageIndex = 0;
                    if (node != null)
                    {
                        node.Nodes.Add(newNode);
                    }
                    else
                    {
                        this.treeView1.Nodes[0].Nodes.Add(newNode);
                    }
                    this.InitDictItem();
                    return true;
                }
                #endregion
            }
            catch (Exception ex)
            {
                LogTextHelper.Error(ex);
                MessageDxUtil.ShowError(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// 编辑状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public bool SaveUpdated()
        {

            Dz_typeInfo info = CallerFactory<IDz_typeService>.Instance.FindByID(ID);
            if (info != null)
            {
                SetInfo(info);
                if (!Portal.gc.HasFunction("TypeInfo/Edit"))
                {
                    string value = string.Empty;
                    Portal.gc.FunctionDict.TryGetValue("TypeInfo/Edit", out value);
                    MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                    return false;
                }

                try
                {
                    #region 更新数据
                    bool succeed = CallerFactory<IDz_typeService>.Instance.Update(info, info.H_type);
                    if (succeed)
                    {
                        //可添加其他关联操作
                        TreeNode node = treeView1.SelectedNode;
                        node.Text = info.Type_name;
                        node.Tag = info.H_type;
                        if (node.Parent.Tag.ToString() != info.Type_id)//修改过父节点
                        {
                            int index = 0;
                            TreeNode newNode = this.FindNode(this.treeView1.Nodes[0], info.Type_id);
                            if (newNode != null)
                            {
                                treeView1.SelectedNode.Remove();//删除原节点
                               index= newNode.Nodes.Add(node);//添加新节点
                            }
                            else
                            {
                                treeView1.SelectedNode.Remove();//删除原节点
                                index=this.treeView1.Nodes[0].Nodes.Add(node);//添加新节点
                            }
                            this.treeView1.SelectedNode = node;

                        }
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

        private TreeNode FindNode(TreeNode tnParent, string strValue)
        {
            if (tnParent == null) return null;
            if (tnParent.Tag.ToString().Trim() == strValue.Trim()) return tnParent;
            TreeNode tnRet = null;
            foreach (TreeNode tn in tnParent.Nodes)
            {
                tnRet = FindNode(tn, strValue);
                if (tnRet != null) break;
            }
            return tnRet;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID)) return;
            if (!CheckInput()) return;

            if (tempInfo == null) return;
            if (isNew)
            {
                if (this.SaveAddNew())
                {
                    isNew = false;
                }
            }
            else
            {
                this.SaveUpdated();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;
            if (node == null) return;
            if (node.Tag.ToString().Trim() == "ROOT")
            {
                MessageDxUtil.ShowWarning("根节点请选择向下分类!");
                return;
            }
            isNew = true;
            this.ClearScreen();
            this.txtType_id.EditValue = node.Parent.Tag.ToString();

        }

        private void btnUpAdd_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;
            if (node == null) return;
            isNew = true;
            this.ClearScreen();
            this.txtType_id.EditValue = node.Tag.ToString();
            this.txtH_type.Focus();
            this.txtH_type.Properties.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID)) return;
            if (!Portal.gc.HasFunction("TypeInfo/Delete"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("TypeInfo/Delete", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                return;
            }
            TreeNode node = FindNode(treeView1.Nodes[0], ID);

            if (MessageDxUtil.ShowYesNoAndTips(string.Format("你确认要删除:{0}吗?", node.Text)) != DialogResult.Yes)
            {
                return;
            }
            if (node.GetNodeCount(true) > 0)
            {
                MessageDxUtil.ShowWarning(string.Format("节点:{0}下有子节点,请从最下层节点删除!", node.Text));
                return;
            }
            try
            {
                if (CallerFactory<IDz_typeService>.Instance.Delete(ID))//成功删除
                {
                    if (node != null)
                    {
                        node.Remove();
                    }
                }
            }
            catch (Exception ex)
            {
                 LogTextHelper.Error(ex);
                 MessageDxUtil.ShowError(ex.Message);
           }
        }

    }
}
