using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Erp.Base.Entity;
using Erp.Base.Facade;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Erp.Base.UI
{
    public class ClientsDisplay : XtraUserControl
    {
        #region 变量定义
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private TextEdit txtPay_surplus;
        private TextEdit txtBackpercen;
        private TextEdit txtLimit;
        private TextEdit txtPre_money;
        private TextEdit txtBack;
        private TextEdit txtNosurplus;
        private TextEdit txtTel;
        private TextEdit txtCantact_man;
        private TextEdit txtSurplus_money;
        private TextEdit txtC_id;
        private TextEdit txtDerpartment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private LookUpEdit txtCmid;
        private LookUpEdit txtO_id;
        private TextEdit txtDicount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private TextEdit txtAddress;
        private LookUpEdit txtCcid; 
        #endregion

        private string c_id;
        /// <summary>
        /// 客户编号
        /// </summary>
        [Description("客户编号")]
        public string C_id
        {
            get { return c_id; }
            set { 
                c_id = value;
                if (!DesignMode)
                {
                    if (value != null)
                    {
                        SimpleClientsInfo info = CallerFactory<IClientsService>.Instance.GetSimpleClientsByFid(value);
                        if (info != null)
                        {
                            txtDerpartment.Text = info.C_department;
                            txtTel.Text = info.C_tel;
                            txtCantact_man.Text = info.C_contact_man;
                            txtCmid.EditValue = info.Cm_id;
                            txtO_id.EditValue = info.O_id;
                            txtBack.EditValue = info.C_back;
                            txtBackpercen.EditValue = info.Backpercent;
                            txtLimit.EditValue = info.C_limit;
                            txtSurplus_money.EditValue = info.C_surplus_money;
                            txtNosurplus.EditValue = info.No_surplus;
                            txtPay_surplus.EditValue = info.Pay_money;
                            txtPre_money.EditValue = info.C_pre_money;
                            txtC_id.Text = info.C_id;
                            txtCcid.EditValue = info.Cc_id;
                            txtDicount.EditValue = info.C_discount;
                            txtAddress.Text = info.C_address;
                        }
                    }
                }
            }
        }

        private SimpleClientsInfo currentInfo;
        /// <summary>
        /// 当前客户对象
        /// </summary>
        [Description("当前客户对象")]
        public SimpleClientsInfo CurrentInfo
        {
            get { return currentInfo; }
            set
            {
                currentInfo = value;
                if (!DesignMode && value != null)
                {
                    txtDerpartment.Text = value.C_department;
                    txtTel.Text = value.C_tel;
                    txtCantact_man.Text = value.C_contact_man;
                    txtCmid.EditValue = value.Cm_id;
                    txtO_id.EditValue = value.O_id;
                    txtBack.EditValue = value.C_back;
                    txtBackpercen.EditValue = value.Backpercent;
                    txtLimit.EditValue = value.C_limit;
                    txtSurplus_money.EditValue = value.C_surplus_money;
                    txtNosurplus.EditValue = value.No_surplus;
                    txtPay_surplus.EditValue = value.Pay_money;
                    txtPre_money.EditValue = value.C_pre_money;
                    txtC_id.Text = value.C_id;
                    txtCcid.EditValue = value.Cc_id;
                    txtDicount.EditValue = value.C_discount;
                    txtAddress.Text = value.C_address;
                }
            }
              
        }

        #region 加载
        public ClientsDisplay()
        {
            InitializeComponent();
            this.Load += ClientsDisplay_Load;
        }

        void ClientsDisplay_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                InitDropdown();
            }
        } 
        #endregion

        #region 下拉列表初始化
        private void InitDropdown()
        {
            this.txtCmid.Properties.DisplayMember = "显示值";
            this.txtCmid.Properties.ValueMember = "项目值";
            this.txtCmid.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cm_idByEditor();

            this.txtCcid.Properties.DisplayMember = "显示值";
            this.txtCcid.Properties.ValueMember = "项目值";
            this.txtCcid.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cc_idByEditor();

            this.txtO_id.Properties.DisplayMember = "显示值";
            this.txtO_id.Properties.ValueMember = "项目值";
            this.txtO_id.Properties.DataSource = WHC.Security.SecurityUtil.GetAccountDirectorByEditor();
        } 
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDicount = new DevExpress.XtraEditors.TextEdit();
            this.txtPay_surplus = new DevExpress.XtraEditors.TextEdit();
            this.txtBackpercen = new DevExpress.XtraEditors.TextEdit();
            this.txtLimit = new DevExpress.XtraEditors.TextEdit();
            this.txtPre_money = new DevExpress.XtraEditors.TextEdit();
            this.txtBack = new DevExpress.XtraEditors.TextEdit();
            this.txtNosurplus = new DevExpress.XtraEditors.TextEdit();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtCantact_man = new DevExpress.XtraEditors.TextEdit();
            this.txtSurplus_money = new DevExpress.XtraEditors.TextEdit();
            this.txtC_id = new DevExpress.XtraEditors.TextEdit();
            this.txtDerpartment = new DevExpress.XtraEditors.TextEdit();
            this.txtCmid = new DevExpress.XtraEditors.LookUpEdit();
            this.txtO_id = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCcid = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDicount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPay_surplus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackpercen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNosurplus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantact_man.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurplus_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDerpartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCcid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDicount);
            this.layoutControl1.Controls.Add(this.txtPay_surplus);
            this.layoutControl1.Controls.Add(this.txtBackpercen);
            this.layoutControl1.Controls.Add(this.txtLimit);
            this.layoutControl1.Controls.Add(this.txtPre_money);
            this.layoutControl1.Controls.Add(this.txtBack);
            this.layoutControl1.Controls.Add(this.txtNosurplus);
            this.layoutControl1.Controls.Add(this.txtTel);
            this.layoutControl1.Controls.Add(this.txtCantact_man);
            this.layoutControl1.Controls.Add(this.txtSurplus_money);
            this.layoutControl1.Controls.Add(this.txtC_id);
            this.layoutControl1.Controls.Add(this.txtDerpartment);
            this.layoutControl1.Controls.Add(this.txtCmid);
            this.layoutControl1.Controls.Add(this.txtO_id);
            this.layoutControl1.Controls.Add(this.txtCcid);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(780, 118);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDicount
            // 
            this.txtDicount.Location = new System.Drawing.Point(535, 36);
            this.txtDicount.Name = "txtDicount";
            this.txtDicount.Properties.DisplayFormat.FormatString = "p2";
            this.txtDicount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDicount.Properties.EditFormat.FormatString = "p2";
            this.txtDicount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDicount.Properties.Mask.EditMask = "p2";
            this.txtDicount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDicount.Properties.ReadOnly = true;
            this.txtDicount.Size = new System.Drawing.Size(63, 20);
            this.txtDicount.StyleController = this.layoutControl1;
            this.txtDicount.TabIndex = 1;
            // 
            // txtPay_surplus
            // 
            this.txtPay_surplus.Location = new System.Drawing.Point(665, 85);
            this.txtPay_surplus.Name = "txtPay_surplus";
            this.txtPay_surplus.Properties.DisplayFormat.FormatString = "c2";
            this.txtPay_surplus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPay_surplus.Properties.EditFormat.FormatString = "c2";
            this.txtPay_surplus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPay_surplus.Properties.ReadOnly = true;
            this.txtPay_surplus.Size = new System.Drawing.Size(103, 20);
            this.txtPay_surplus.StyleController = this.layoutControl1;
            this.txtPay_surplus.TabIndex = 18;
            // 
            // txtBackpercen
            // 
            this.txtBackpercen.Location = new System.Drawing.Point(470, 85);
            this.txtBackpercen.Name = "txtBackpercen";
            this.txtBackpercen.Properties.DisplayFormat.FormatString = "p2";
            this.txtBackpercen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBackpercen.Properties.EditFormat.FormatString = "p2";
            this.txtBackpercen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBackpercen.Properties.Mask.EditMask = "p2";
            this.txtBackpercen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBackpercen.Properties.ReadOnly = true;
            this.txtBackpercen.Size = new System.Drawing.Size(128, 20);
            this.txtBackpercen.StyleController = this.layoutControl1;
            this.txtBackpercen.TabIndex = 17;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(275, 85);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Properties.DisplayFormat.FormatString = "c2";
            this.txtLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLimit.Properties.EditFormat.FormatString = "c2";
            this.txtLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLimit.Properties.ReadOnly = true;
            this.txtLimit.Size = new System.Drawing.Size(128, 20);
            this.txtLimit.StyleController = this.layoutControl1;
            this.txtLimit.TabIndex = 16;
            // 
            // txtPre_money
            // 
            this.txtPre_money.Location = new System.Drawing.Point(665, 61);
            this.txtPre_money.Name = "txtPre_money";
            this.txtPre_money.Properties.DisplayFormat.FormatString = "c2";
            this.txtPre_money.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPre_money.Properties.EditFormat.FormatString = "c2";
            this.txtPre_money.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPre_money.Properties.ReadOnly = true;
            this.txtPre_money.Size = new System.Drawing.Size(103, 20);
            this.txtPre_money.StyleController = this.layoutControl1;
            this.txtPre_money.TabIndex = 14;
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(470, 61);
            this.txtBack.Name = "txtBack";
            this.txtBack.Properties.DisplayFormat.FormatString = "p2";
            this.txtBack.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBack.Properties.EditFormat.FormatString = "p2";
            this.txtBack.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBack.Properties.Mask.EditMask = "p2";
            this.txtBack.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBack.Properties.ReadOnly = true;
            this.txtBack.Size = new System.Drawing.Size(128, 20);
            this.txtBack.StyleController = this.layoutControl1;
            this.txtBack.TabIndex = 13;
            // 
            // txtNosurplus
            // 
            this.txtNosurplus.Location = new System.Drawing.Point(665, 36);
            this.txtNosurplus.Name = "txtNosurplus";
            this.txtNosurplus.Properties.DisplayFormat.FormatString = "c2";
            this.txtNosurplus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtNosurplus.Properties.EditFormat.FormatString = "c2";
            this.txtNosurplus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtNosurplus.Properties.ReadOnly = true;
            this.txtNosurplus.Size = new System.Drawing.Size(103, 20);
            this.txtNosurplus.StyleController = this.layoutControl1;
            this.txtNosurplus.TabIndex = 11;
            // 
            // txtTel
            // 
            this.txtTel.EditValue = "";
            this.txtTel.Location = new System.Drawing.Point(75, 61);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(133, 20);
            this.txtTel.StyleController = this.layoutControl1;
            this.txtTel.TabIndex = 10;
            // 
            // txtCantact_man
            // 
            this.txtCantact_man.Location = new System.Drawing.Point(405, 36);
            this.txtCantact_man.Name = "txtCantact_man";
            this.txtCantact_man.Properties.ReadOnly = true;
            this.txtCantact_man.Size = new System.Drawing.Size(63, 20);
            this.txtCantact_man.StyleController = this.layoutControl1;
            this.txtCantact_man.TabIndex = 8;
            // 
            // txtSurplus_money
            // 
            this.txtSurplus_money.Location = new System.Drawing.Point(665, 12);
            this.txtSurplus_money.Name = "txtSurplus_money";
            this.txtSurplus_money.Properties.DisplayFormat.FormatString = "c2";
            this.txtSurplus_money.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtSurplus_money.Properties.EditFormat.FormatString = "c2";
            this.txtSurplus_money.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtSurplus_money.Properties.Mask.EditMask = "c2";
            this.txtSurplus_money.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSurplus_money.Properties.ReadOnly = true;
            this.txtSurplus_money.Size = new System.Drawing.Size(103, 20);
            this.txtSurplus_money.StyleController = this.layoutControl1;
            this.txtSurplus_money.TabIndex = 6;
            // 
            // txtC_id
            // 
            this.txtC_id.Location = new System.Drawing.Point(75, 12);
            this.txtC_id.Name = "txtC_id";
            this.txtC_id.Properties.ReadOnly = true;
            this.txtC_id.Size = new System.Drawing.Size(133, 20);
            this.txtC_id.StyleController = this.layoutControl1;
            this.txtC_id.TabIndex = 5;
            // 
            // txtDerpartment
            // 
            this.txtDerpartment.Location = new System.Drawing.Point(275, 12);
            this.txtDerpartment.Name = "txtDerpartment";
            this.txtDerpartment.Properties.ReadOnly = true;
            this.txtDerpartment.Size = new System.Drawing.Size(323, 20);
            this.txtDerpartment.StyleController = this.layoutControl1;
            this.txtDerpartment.TabIndex = 4;
            // 
            // txtCmid
            // 
            this.txtCmid.Location = new System.Drawing.Point(275, 36);
            this.txtCmid.Name = "txtCmid";
            this.txtCmid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCmid.Properties.NullText = "";
            this.txtCmid.Properties.ReadOnly = true;
            this.txtCmid.Size = new System.Drawing.Size(63, 20);
            this.txtCmid.StyleController = this.layoutControl1;
            this.txtCmid.TabIndex = 9;
            // 
            // txtO_id
            // 
            this.txtO_id.Location = new System.Drawing.Point(275, 61);
            this.txtO_id.Name = "txtO_id";
            this.txtO_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtO_id.Properties.NullText = "";
            this.txtO_id.Properties.ReadOnly = true;
            this.txtO_id.Size = new System.Drawing.Size(128, 20);
            this.txtO_id.StyleController = this.layoutControl1;
            this.txtO_id.TabIndex = 12;
            // 
            // txtCcid
            // 
            this.txtCcid.Location = new System.Drawing.Point(75, 36);
            this.txtCcid.Name = "txtCcid";
            this.txtCcid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCcid.Properties.DisplayFormat.FormatString = "yyyy-mm-dd";
            this.txtCcid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtCcid.Properties.EditFormat.FormatString = "yyyy-mm-dd";
            this.txtCcid.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtCcid.Properties.NullText = "";
            this.txtCcid.Properties.ReadOnly = true;
            this.txtCcid.Size = new System.Drawing.Size(133, 20);
            this.txtCcid.StyleController = this.layoutControl1;
            this.txtCcid.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(75, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(133, 20);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem12,
            this.layoutControlItem15,
            this.layoutControlItem9,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem11,
            this.layoutControlItem8,
            this.layoutControlItem16,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem10});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 118);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCcid;
            this.layoutControlItem4.CustomizationFormText = "建档日期";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 25);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "客户类别";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtC_id;
            this.layoutControlItem2.CustomizationFormText = "电话";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "客户编号";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSurplus_money;
            this.layoutControlItem3.CustomizationFormText = "已收票结余";
            this.layoutControlItem3.Location = new System.Drawing.Point(590, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "已收票结余";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDerpartment;
            this.layoutControlItem1.CustomizationFormText = "名称";
            this.layoutControlItem1.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(390, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(390, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(390, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "名      称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTel;
            this.layoutControlItem7.CustomizationFormText = "邮政编码";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "电      话";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtAddress;
            this.layoutControlItem12.CustomizationFormText = "信用管制";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(200, 25);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "通信地址";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.txtPay_surplus;
            this.layoutControlItem15.CustomizationFormText = "应付账款";
            this.layoutControlItem15.Location = new System.Drawing.Point(590, 73);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(170, 25);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.Text = "应付账款";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtO_id;
            this.layoutControlItem9.CustomizationFormText = "主管采购";
            this.layoutControlItem9.Location = new System.Drawing.Point(200, 49);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(195, 24);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(195, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(195, 24);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "主管业务";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtCmid;
            this.layoutControlItem6.CustomizationFormText = "销售方式";
            this.layoutControlItem6.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(130, 25);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "销售方式";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtCantact_man;
            this.layoutControlItem5.CustomizationFormText = "联系人";
            this.layoutControlItem5.Location = new System.Drawing.Point(330, 24);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(130, 25);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "联 系 人";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtPre_money;
            this.layoutControlItem11.CustomizationFormText = "预付结余";
            this.layoutControlItem11.Location = new System.Drawing.Point(590, 49);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "预付结余";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtNosurplus;
            this.layoutControlItem8.CustomizationFormText = "未收票结余";
            this.layoutControlItem8.Location = new System.Drawing.Point(590, 24);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(170, 25);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "未收票结余";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.txtDicount;
            this.layoutControlItem16.CustomizationFormText = "预设折扣";
            this.layoutControlItem16.Location = new System.Drawing.Point(460, 24);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(130, 24);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(130, 25);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.Text = "预设折扣";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.txtLimit;
            this.layoutControlItem13.CustomizationFormText = "最大欠款";
            this.layoutControlItem13.Location = new System.Drawing.Point(200, 73);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(195, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(195, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(195, 25);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.Text = "最大欠款";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtBackpercen;
            this.layoutControlItem14.CustomizationFormText = "实际退货率";
            this.layoutControlItem14.Location = new System.Drawing.Point(395, 73);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(195, 24);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(195, 24);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(195, 25);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.Text = "实际退货率";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtBack;
            this.layoutControlItem10.CustomizationFormText = "协议退货率";
            this.layoutControlItem10.Location = new System.Drawing.Point(395, 49);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(195, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(195, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(195, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "协议退货率";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(60, 14);
            // 
            // ClientsDisplay
            // 
            this.Controls.Add(this.layoutControl1);
            this.Name = "ClientsDisplay";
            this.Size = new System.Drawing.Size(780, 118);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDicount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPay_surplus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackpercen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNosurplus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantact_man.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurplus_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDerpartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCcid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

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
    }
}
