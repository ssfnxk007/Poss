using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Erp.Base.Entity;
using Erp.Base.Facade;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using System.ComponentModel;

namespace Erp.Base.UI
{
   public class FactoryDisplay : XtraUserControl
   {
       #region 变量定义
       private DevExpress.XtraLayout.LayoutControl layoutControl1;
       private TextEdit txtPay_surplus;
       private TextEdit txtBackpercen;
       private TextEdit txtLimit;
       private TextEdit txtPre_money;
       private TextEdit txtBack;
       private TextEdit txtNosurplus;
       private TextEdit txtZip;
       private TextEdit txtCantact_man;
       private TextEdit txtInput_date;
       private TextEdit txtSurplus_money;
       private TextEdit txtTel;
       private TextEdit txtDerpartment;
       private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
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
       private LookUpEdit txtClients_credit;
       private System.ComponentModel.IContainer components; 
       #endregion

       /// <summary>
       /// 货源编号
       /// </summary>
       private string f_id;
       private SimpleFactory currentInfo;
       [Description("货源编号")]
       public string F_id
       {
           get{return  f_id;}
           set { 
               f_id = value;
               if (!DesignMode)
               {
                   if (value == null) return;
                   SimpleFactory info = CallerFactory<IFactoryService>.Instance.GetSimpleFactoryByFid(value);
                   if (info != null)
                   {
                       txtDerpartment.Text = info.F_department;
                       txtTel.Text = info.F_tel;
                       txtZip.Text = info.F_zip;
                       txtInput_date.Text = info.Input_date;
                       txtCantact_man.Text = info.F_contact_man;
                       txtCmid.EditValue = info.Cm_id;
                       txtO_id.EditValue = info.O_id;
                       txtBack.EditValue = info.F_back;
                       txtBackpercen.EditValue = info.F_backpercent;
                       txtClients_credit.EditValue = info.Clients_credit;
                       txtLimit.EditValue = info.M_limit_money;
                       txtSurplus_money.EditValue = info.F_surplus_money;
                       txtNosurplus.EditValue = info.F_no_surplus;
                       txtPay_surplus.EditValue = info.F_pay_surplus;
                       txtPre_money.EditValue = info.F_pre_money;
                   } 
               }
           }
       }
       /// <summary>
       /// 货源信息
       /// </summary>
     
       [Description("当前货源信息")]
       public SimpleFactory CurrentInfo
       {
           get { return currentInfo; }
           set { 
               currentInfo = value;
               if (value != null && !DesignMode)
               {
                   txtDerpartment.Text = value.F_department;
                   txtTel.Text = value.F_tel;
                   txtZip.Text = value.F_zip;
                   txtInput_date.Text = value.Input_date;
                   txtCantact_man.Text = value.F_contact_man;
                   txtCmid.EditValue = value.Cm_id;
                   txtO_id.EditValue = value.O_id;
                   txtBack.EditValue = value.F_back;
                   txtBackpercen.EditValue = value.F_backpercent;
                   txtClients_credit.EditValue = value.Clients_credit;
                   txtLimit.EditValue = value.M_limit_money;
                   txtSurplus_money.EditValue = value.F_surplus_money;
                   txtNosurplus.EditValue = value.F_no_surplus;
                   txtPay_surplus.EditValue = value.F_pay_surplus;
                   txtPre_money.EditValue = value.F_pre_money;
               }
               }
       }

       #region InitializeComponent

       private void InitializeComponent()
       {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtPay_surplus = new DevExpress.XtraEditors.TextEdit();
            this.txtBackpercen = new DevExpress.XtraEditors.TextEdit();
            this.txtLimit = new DevExpress.XtraEditors.TextEdit();
            this.txtPre_money = new DevExpress.XtraEditors.TextEdit();
            this.txtBack = new DevExpress.XtraEditors.TextEdit();
            this.txtNosurplus = new DevExpress.XtraEditors.TextEdit();
            this.txtZip = new DevExpress.XtraEditors.TextEdit();
            this.txtCantact_man = new DevExpress.XtraEditors.TextEdit();
            this.txtInput_date = new DevExpress.XtraEditors.TextEdit();
            this.txtSurplus_money = new DevExpress.XtraEditors.TextEdit();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtDerpartment = new DevExpress.XtraEditors.TextEdit();
            this.txtCmid = new DevExpress.XtraEditors.LookUpEdit();
            this.txtO_id = new DevExpress.XtraEditors.LookUpEdit();
            this.txtClients_credit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPay_surplus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackpercen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNosurplus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantact_man.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurplus_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDerpartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClients_credit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtPay_surplus);
            this.layoutControl1.Controls.Add(this.txtBackpercen);
            this.layoutControl1.Controls.Add(this.txtLimit);
            this.layoutControl1.Controls.Add(this.txtPre_money);
            this.layoutControl1.Controls.Add(this.txtBack);
            this.layoutControl1.Controls.Add(this.txtNosurplus);
            this.layoutControl1.Controls.Add(this.txtZip);
            this.layoutControl1.Controls.Add(this.txtCantact_man);
            this.layoutControl1.Controls.Add(this.txtInput_date);
            this.layoutControl1.Controls.Add(this.txtSurplus_money);
            this.layoutControl1.Controls.Add(this.txtTel);
            this.layoutControl1.Controls.Add(this.txtDerpartment);
            this.layoutControl1.Controls.Add(this.txtCmid);
            this.layoutControl1.Controls.Add(this.txtO_id);
            this.layoutControl1.Controls.Add(this.txtClients_credit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(700, 120);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtPay_surplus
            // 
            this.txtPay_surplus.Location = new System.Drawing.Point(585, 85);
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
            this.txtBackpercen.Location = new System.Drawing.Point(415, 85);
            this.txtBackpercen.Name = "txtBackpercen";
            this.txtBackpercen.Properties.DisplayFormat.FormatString = "p2";
            this.txtBackpercen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBackpercen.Properties.EditFormat.FormatString = "p2";
            this.txtBackpercen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBackpercen.Properties.Mask.EditMask = "p2";
            this.txtBackpercen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBackpercen.Properties.ReadOnly = true;
            this.txtBackpercen.Size = new System.Drawing.Size(103, 20);
            this.txtBackpercen.StyleController = this.layoutControl1;
            this.txtBackpercen.TabIndex = 17;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(245, 88);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Properties.DisplayFormat.FormatString = "c2";
            this.txtLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLimit.Properties.EditFormat.FormatString = "c2";
            this.txtLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLimit.Properties.ReadOnly = true;
            this.txtLimit.Size = new System.Drawing.Size(103, 20);
            this.txtLimit.StyleController = this.layoutControl1;
            this.txtLimit.TabIndex = 16;
            // 
            // txtPre_money
            // 
            this.txtPre_money.Location = new System.Drawing.Point(585, 61);
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
            this.txtBack.Location = new System.Drawing.Point(415, 61);
            this.txtBack.Name = "txtBack";
            this.txtBack.Properties.DisplayFormat.FormatString = "p2";
            this.txtBack.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBack.Properties.EditFormat.FormatString = "p2";
            this.txtBack.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBack.Properties.Mask.EditMask = "p2";
            this.txtBack.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBack.Properties.ReadOnly = true;
            this.txtBack.Size = new System.Drawing.Size(103, 20);
            this.txtBack.StyleController = this.layoutControl1;
            this.txtBack.TabIndex = 13;
            // 
            // txtNosurplus
            // 
            this.txtNosurplus.Location = new System.Drawing.Point(585, 36);
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
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(75, 61);
            this.txtZip.Name = "txtZip";
            this.txtZip.Properties.Mask.EditMask = "n0";
            this.txtZip.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtZip.Properties.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(103, 20);
            this.txtZip.StyleController = this.layoutControl1;
            this.txtZip.TabIndex = 10;
            // 
            // txtCantact_man
            // 
            this.txtCantact_man.Location = new System.Drawing.Point(245, 36);
            this.txtCantact_man.Name = "txtCantact_man";
            this.txtCantact_man.Properties.ReadOnly = true;
            this.txtCantact_man.Size = new System.Drawing.Size(103, 20);
            this.txtCantact_man.StyleController = this.layoutControl1;
            this.txtCantact_man.TabIndex = 8;
            // 
            // txtInput_date
            // 
            this.txtInput_date.Location = new System.Drawing.Point(75, 36);
            this.txtInput_date.Name = "txtInput_date";
            this.txtInput_date.Properties.DisplayFormat.FormatString = "yyyy-mm-dd";
            this.txtInput_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtInput_date.Properties.EditFormat.FormatString = "yyyy-mm-dd";
            this.txtInput_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtInput_date.Properties.Mask.EditMask = "yyyy-mm-dd";
            this.txtInput_date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtInput_date.Properties.ReadOnly = true;
            this.txtInput_date.Size = new System.Drawing.Size(103, 20);
            this.txtInput_date.StyleController = this.layoutControl1;
            this.txtInput_date.TabIndex = 7;
            // 
            // txtSurplus_money
            // 
            this.txtSurplus_money.Location = new System.Drawing.Point(585, 12);
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
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(415, 12);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(103, 20);
            this.txtTel.StyleController = this.layoutControl1;
            this.txtTel.TabIndex = 5;
            // 
            // txtDerpartment
            // 
            this.txtDerpartment.Location = new System.Drawing.Point(75, 12);
            this.txtDerpartment.Name = "txtDerpartment";
            this.txtDerpartment.Properties.ReadOnly = true;
            this.txtDerpartment.Size = new System.Drawing.Size(273, 20);
            this.txtDerpartment.StyleController = this.layoutControl1;
            this.txtDerpartment.TabIndex = 4;
            // 
            // txtCmid
            // 
            this.txtCmid.Location = new System.Drawing.Point(415, 36);
            this.txtCmid.Name = "txtCmid";
            this.txtCmid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCmid.Properties.NullText = "";
            this.txtCmid.Properties.ReadOnly = true;
            this.txtCmid.Size = new System.Drawing.Size(103, 20);
            this.txtCmid.StyleController = this.layoutControl1;
            this.txtCmid.TabIndex = 9;
            // 
            // txtO_id
            // 
            this.txtO_id.Location = new System.Drawing.Point(245, 61);
            this.txtO_id.Name = "txtO_id";
            this.txtO_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtO_id.Properties.NullText = "";
            this.txtO_id.Properties.ReadOnly = true;
            this.txtO_id.Size = new System.Drawing.Size(103, 20);
            this.txtO_id.StyleController = this.layoutControl1;
            this.txtO_id.TabIndex = 12;
            // 
            // txtClients_credit
            // 
            this.txtClients_credit.Location = new System.Drawing.Point(75, 85);
            this.txtClients_credit.Name = "txtClients_credit";
            this.txtClients_credit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtClients_credit.Properties.NullText = "";
            this.txtClients_credit.Properties.ReadOnly = true;
            this.txtClients_credit.Size = new System.Drawing.Size(103, 20);
            this.txtClients_credit.StyleController = this.layoutControl1;
            this.txtClients_credit.TabIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(700, 120);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDerpartment;
            this.layoutControlItem1.CustomizationFormText = "名称";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(420, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "名      称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtInput_date;
            this.layoutControlItem4.CustomizationFormText = "建档日期";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(170, 25);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "建档日期";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtZip;
            this.layoutControlItem7.CustomizationFormText = "邮政编码";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "邮政编码";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTel;
            this.layoutControlItem2.CustomizationFormText = "电话";
            this.layoutControlItem2.Location = new System.Drawing.Point(340, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "电      话";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSurplus_money;
            this.layoutControlItem3.CustomizationFormText = "已收票结余";
            this.layoutControlItem3.Location = new System.Drawing.Point(510, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "已收票结余";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtCantact_man;
            this.layoutControlItem5.CustomizationFormText = "联系人";
            this.layoutControlItem5.Location = new System.Drawing.Point(170, 24);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(170, 25);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "联 系 人";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtCmid;
            this.layoutControlItem6.CustomizationFormText = "销售方式";
            this.layoutControlItem6.Location = new System.Drawing.Point(340, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(170, 25);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "销售方式";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtNosurplus;
            this.layoutControlItem8.CustomizationFormText = "未收票结余";
            this.layoutControlItem8.Location = new System.Drawing.Point(510, 24);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(170, 25);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "未收票结余";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtO_id;
            this.layoutControlItem9.CustomizationFormText = "主管采购";
            this.layoutControlItem9.Location = new System.Drawing.Point(170, 49);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(170, 27);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "主管采购";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtBack;
            this.layoutControlItem10.CustomizationFormText = "协议退货率";
            this.layoutControlItem10.Location = new System.Drawing.Point(340, 49);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "协议退货率";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtPre_money;
            this.layoutControlItem11.CustomizationFormText = "预付结余";
            this.layoutControlItem11.Location = new System.Drawing.Point(510, 49);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "预付结余";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtClients_credit;
            this.layoutControlItem12.CustomizationFormText = "信用管制";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(170, 27);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "信用管制";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.txtLimit;
            this.layoutControlItem13.CustomizationFormText = "最大欠款";
            this.layoutControlItem13.Location = new System.Drawing.Point(170, 76);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.Text = "最大欠款";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtBackpercen;
            this.layoutControlItem14.CustomizationFormText = "实际退货率";
            this.layoutControlItem14.Location = new System.Drawing.Point(340, 73);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(170, 27);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.Text = "实际退货率";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.txtPay_surplus;
            this.layoutControlItem15.CustomizationFormText = "应付账款";
            this.layoutControlItem15.Location = new System.Drawing.Point(510, 73);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(170, 27);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.Text = "应付账款";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(60, 14);
            // 
            // FactoryDisplay
            // 
            this.Controls.Add(this.layoutControl1);
            this.Name = "FactoryDisplay";
            this.Size = new System.Drawing.Size(700, 120);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPay_surplus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackpercen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNosurplus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantact_man.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurplus_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDerpartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClients_credit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            this.ResumeLayout(false);

       } 
       #endregion

       #region 下拉列表初始化
        private void InitDropdown()
       {
           this.txtCmid.Properties.DisplayMember = "显示值";
           this.txtCmid.Properties.ValueMember = "项目值";
           this.txtCmid.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cm_idByEditor();

           this.txtO_id.Properties.DisplayMember = "显示值";
           this.txtO_id.Properties.ValueMember = "项目值";
           this.txtO_id.Properties.DataSource = WHC.Security.SecurityUtil.GetAccountDirectorByEditor();

           this.txtClients_credit.Properties.DisplayMember = "显示值";
           this.txtClients_credit.Properties.ValueMember = "项目值";
           this.txtClients_credit.Properties.DataSource = WHC.Dictionary.DictItemUtil.Clients_CreditbyEditor(); 
        }
        #endregion

        #region 加载
        public FactoryDisplay()
        {
            InitializeComponent();
            this.Load += FactoryDisplay_Load;
        }

        void FactoryDisplay_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                InitDropdown();
            }
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
