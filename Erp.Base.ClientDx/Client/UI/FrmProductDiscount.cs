using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Erp.Base.Facade;
using Erp.Base.Entity;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;

namespace Erp.Base.UI
{
   public class FrmProductDiscount:BaseDockQuery
    {

        #region 定义变量
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private WHC.Framework.Commons.TextBoxControl txt_isbn;
        private System.ComponentModel.IContainer components;
        private WHC.Framework.Commons.TextBoxControl txt_discount_ls;
        private WHC.Framework.Commons.TextBoxControl txt_discount_pf;
        private WHC.Framework.Commons.TextBoxControl txt_h_name;
        private WHC.Framework.Commons.TextBoxControl txt_pub_id;
        private WHC.Framework.Commons.DateTimeControl dateTimeControl2;
        private WHC.Framework.Commons.DateTimeControl dateTimeControl1;
        private WHC.Framework.Commons.YesOrNoControl yesOrNoControl1;
        private WHC.Framework.Commons.TextBoxControl txt_discount_xz;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_pf;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_ls;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_hy;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_ps;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_wg;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_limit;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_cancel;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_cl;
        private System.Windows.Forms.ToolStripMenuItem btn_discount_hyl;
        private DevExpress.XtraEditors.SimpleButton btn_select;
        private DevExpress.XtraEditors.SimpleButton btn_limit_care;
        private DevExpress.XtraEditors.SimpleButton btn_limitdate;
        private DevExpress.XtraEditors.SimpleButton btn_set;
        private DevExpress.XtraEditors.SimpleButton btn_discount; DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private WHC.Framework.Commons.ComboBoxControl txt_h_type;

        List<SimpleProductInfo> listsp = new List<SimpleProductInfo>();

        double discount;
        string h_id=string.Empty;
        int state = 0;
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_isbn = new WHC.Framework.Commons.TextBoxControl();
            this.txt_discount_ls = new WHC.Framework.Commons.TextBoxControl();
            this.txt_discount_pf = new WHC.Framework.Commons.TextBoxControl();
            this.txt_h_name = new WHC.Framework.Commons.TextBoxControl();
            this.txt_pub_id = new WHC.Framework.Commons.TextBoxControl();
            this.dateTimeControl2 = new WHC.Framework.Commons.DateTimeControl();
            this.dateTimeControl1 = new WHC.Framework.Commons.DateTimeControl();
            this.yesOrNoControl1 = new WHC.Framework.Commons.YesOrNoControl();
            this.txt_discount_xz = new WHC.Framework.Commons.TextBoxControl();
            this.txt_h_type = new WHC.Framework.Commons.ComboBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.dropDownButton2 = new DevExpress.XtraEditors.DropDownButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_discount_pf = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_discount_ls = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_discount_hy = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_discount_ps = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_discount_wg = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_discount_limit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_discount_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_discount_cl = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_discount_hyl = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_limit_care = new DevExpress.XtraEditors.SimpleButton();
            this.btn_select = new DevExpress.XtraEditors.SimpleButton();
            this.btn_discount = new DevExpress.XtraEditors.SimpleButton();
            this.btn_set = new DevExpress.XtraEditors.SimpleButton();
            this.btn_limitdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButton)).BeginInit();
            this.PanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCondition)).BeginInit();
            this.PanelCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelDisplayCondition)).BeginInit();
            this.PanelDisplayCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount_ls.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount_pf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_h_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pub_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesOrNoControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount_xz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_h_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.btn_limitdate);
            this.PanelButton.Controls.Add(this.btn_set);
            this.PanelButton.Controls.Add(this.btn_discount);
            this.PanelButton.Controls.Add(this.btn_select);
            this.PanelButton.Controls.Add(this.btn_limit_care);
            this.PanelButton.Controls.Add(this.dropDownButton2);
            this.PanelButton.Location = new System.Drawing.Point(628, 0);
            this.PanelButton.Size = new System.Drawing.Size(246, 102);
            this.PanelButton.Controls.SetChildIndex(this.btnQuery, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnReset, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnPrint, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnExport, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnAdd, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnExit, 0);
            this.PanelButton.Controls.SetChildIndex(this.dropDownButton2, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_limit_care, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_select, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_discount, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_set, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_limitdate, 0);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(623, 0);
            this.splitterControl1.Size = new System.Drawing.Size(5, 102);
            // 
            // PanelCondition
            // 
            this.PanelCondition.Controls.Add(this.layoutControl1);
            this.PanelCondition.Size = new System.Drawing.Size(623, 102);
            // 
            // PanelDisplayCondition
            // 
            this.PanelDisplayCondition.Size = new System.Drawing.Size(874, 40);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 69);
            // 
            // btnAdd
            // 
            this.btnAdd.Text = "预销期限";
            // 
            // btnExport
            // 
            this.btnExport.Text = "批量设置";
            // 
            // btnPrint
            // 
            this.btnPrint.Text = "本地定价";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            this.panelControl1.Size = new System.Drawing.Size(874, 313);
            // 
            // LabelCondition
            // 
            this.LabelCondition.Size = new System.Drawing.Size(870, 36);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(874, 465);
            this.splitContainerControl1.SplitterPosition = 102;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.txt_isbn);
            this.layoutControl1.Controls.Add(this.txt_discount_ls);
            this.layoutControl1.Controls.Add(this.txt_discount_pf);
            this.layoutControl1.Controls.Add(this.txt_h_name);
            this.layoutControl1.Controls.Add(this.txt_pub_id);
            this.layoutControl1.Controls.Add(this.dateTimeControl2);
            this.layoutControl1.Controls.Add(this.dateTimeControl1);
            this.layoutControl1.Controls.Add(this.yesOrNoControl1);
            this.layoutControl1.Controls.Add(this.txt_discount_xz);
            this.layoutControl1.Controls.Add(this.txt_h_type);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(623, 102);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_isbn
            // 
            this.txt_isbn.ChineseColumnName = "书号";
            this.txt_isbn.ColumnName = "db_product.h_isbn";
            this.txt_isbn.Location = new System.Drawing.Point(263, 61);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_isbn.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_isbn.Size = new System.Drawing.Size(145, 20);
            this.txt_isbn.StyleController = this.layoutControl1;
            this.txt_isbn.TabIndex = 14;
            this.txt_isbn.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_discount_ls
            // 
            this.txt_discount_ls.ChineseColumnName = "零售折扣";
            this.txt_discount_ls.ColumnName = "db_product_discount.h_output_discount_ls";
            this.txt_discount_ls.Location = new System.Drawing.Point(63, 37);
            this.txt_discount_ls.Name = "txt_discount_ls";
            this.txt_discount_ls.Properties.DisplayFormat.FormatString = "p2";
            this.txt_discount_ls.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_discount_ls.Properties.EditFormat.FormatString = "p2";
            this.txt_discount_ls.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_discount_ls.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_discount_ls.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_discount_ls.Size = new System.Drawing.Size(145, 20);
            this.txt_discount_ls.StyleController = this.layoutControl1;
            this.txt_discount_ls.TabIndex = 10;
            this.txt_discount_ls.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_discount_pf
            // 
            this.txt_discount_pf.ChineseColumnName = "批发折扣";
            this.txt_discount_pf.ColumnName = "db_product_discount.h_output_discount";
            this.txt_discount_pf.Location = new System.Drawing.Point(263, 37);
            this.txt_discount_pf.Name = "txt_discount_pf";
            this.txt_discount_pf.Properties.DisplayFormat.FormatString = "p2";
            this.txt_discount_pf.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_discount_pf.Properties.EditFormat.FormatString = "p2";
            this.txt_discount_pf.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_discount_pf.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_discount_pf.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_discount_pf.Size = new System.Drawing.Size(145, 20);
            this.txt_discount_pf.StyleController = this.layoutControl1;
            this.txt_discount_pf.TabIndex = 9;
            this.txt_discount_pf.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_h_name
            // 
            this.txt_h_name.ChineseColumnName = "商品名称";
            this.txt_h_name.ColumnName = "db_product.h_name";
            this.txt_h_name.Location = new System.Drawing.Point(663, 12);
            this.txt_h_name.Name = "txt_h_name";
            this.txt_h_name.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_h_name.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_h_name.Size = new System.Drawing.Size(145, 20);
            this.txt_h_name.StyleController = this.layoutControl1;
            this.txt_h_name.TabIndex = 8;
            this.txt_h_name.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_pub_id
            // 
            this.txt_pub_id.ChineseColumnName = "出版社";
            this.txt_pub_id.ColumnName = "dbo.uf_getpubname (db_product.pub_id )";
            this.txt_pub_id.Location = new System.Drawing.Point(63, 61);
            this.txt_pub_id.Name = "txt_pub_id";
            this.txt_pub_id.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_pub_id.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_pub_id.Size = new System.Drawing.Size(145, 20);
            this.txt_pub_id.StyleController = this.layoutControl1;
            this.txt_pub_id.TabIndex = 7;
            this.txt_pub_id.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // dateTimeControl2
            // 
            this.dateTimeControl2.ChineseColumnName = "出版日期";
            this.dateTimeControl2.ColumnName = " db_product.h_hopesell";
            this.dateTimeControl2.EndDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeControl2.Location = new System.Drawing.Point(63, 12);
            this.dateTimeControl2.Name = "dateTimeControl2";
            this.dateTimeControl2.Size = new System.Drawing.Size(145, 20);
            this.dateTimeControl2.TabIndex = 6;
            // 
            // dateTimeControl1
            // 
            this.dateTimeControl1.ChineseColumnName = "建档日期";
            this.dateTimeControl1.ColumnName = "db_product.h_input_date";
            this.dateTimeControl1.EndDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeControl1.Location = new System.Drawing.Point(263, 12);
            this.dateTimeControl1.Name = "dateTimeControl1";
            this.dateTimeControl1.Size = new System.Drawing.Size(145, 20);
            this.dateTimeControl1.TabIndex = 5;
            // 
            // yesOrNoControl1
            // 
            this.yesOrNoControl1.ChineseColumnName = "是否限制";
            this.yesOrNoControl1.ColumnName = "db_product_discount.limite_zk_flag";
            this.yesOrNoControl1.Location = new System.Drawing.Point(663, 37);
            this.yesOrNoControl1.Name = "yesOrNoControl1";
            this.yesOrNoControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.yesOrNoControl1.Properties.NullValuePrompt = "请选择...";
            this.yesOrNoControl1.Properties.NullValuePromptShowForEmptyValue = true;
            this.yesOrNoControl1.Size = new System.Drawing.Size(145, 20);
            this.yesOrNoControl1.StyleController = this.layoutControl1;
            this.yesOrNoControl1.TabIndex = 4;
            // 
            // txt_discount_xz
            // 
            this.txt_discount_xz.ChineseColumnName = "限制折扣";
            this.txt_discount_xz.ColumnName = "db_product_discount.limite_zk";
            this.txt_discount_xz.Location = new System.Drawing.Point(463, 37);
            this.txt_discount_xz.Name = "txt_discount_xz";
            this.txt_discount_xz.Properties.DisplayFormat.FormatString = "p2";
            this.txt_discount_xz.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_discount_xz.Properties.EditFormat.FormatString = "p2";
            this.txt_discount_xz.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_discount_xz.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_discount_xz.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_discount_xz.Size = new System.Drawing.Size(145, 20);
            this.txt_discount_xz.StyleController = this.layoutControl1;
            this.txt_discount_xz.TabIndex = 12;
            this.txt_discount_xz.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_h_type
            // 
            this.txt_h_type.ChineseColumnName = "商品类别";
            this.txt_h_type.ColumnName = "db_product.h_type";
            this.txt_h_type.Location = new System.Drawing.Point(463, 12);
            this.txt_h_type.Name = "txt_h_type";
            this.txt_h_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_h_type.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_h_type.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_h_type.Size = new System.Drawing.Size(145, 20);
            this.txt_h_type.StyleController = this.layoutControl1;
            this.txt_h_type.TabIndex = 11;
            this.txt_h_type.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem11,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(820, 93);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.dateTimeControl2;
            this.layoutControlItem3.CustomizationFormText = "出版日期";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 25);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "出版日期";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.dateTimeControl1;
            this.layoutControlItem2.CustomizationFormText = "建档日期";
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 25);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "建档日期";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem8.Control = this.txt_h_type;
            this.layoutControlItem8.CustomizationFormText = "商品类别";
            this.layoutControlItem8.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 25);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "商品类别";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.txt_discount_pf;
            this.layoutControlItem6.CustomizationFormText = "批发折扣";
            this.layoutControlItem6.Location = new System.Drawing.Point(200, 25);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "批发折扣";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem9.Control = this.txt_discount_xz;
            this.layoutControlItem9.CustomizationFormText = "限制折扣";
            this.layoutControlItem9.Location = new System.Drawing.Point(400, 25);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "限制折扣";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem7.Control = this.txt_discount_ls;
            this.layoutControlItem7.CustomizationFormText = "零售折扣";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "零售折扣";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.txt_h_name;
            this.layoutControlItem5.CustomizationFormText = "商品名称";
            this.layoutControlItem5.Location = new System.Drawing.Point(600, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 25);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "商品名称";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.txt_pub_id;
            this.layoutControlItem4.CustomizationFormText = "出版社";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "出版社";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem11.Control = this.txt_isbn;
            this.layoutControlItem11.CustomizationFormText = "书号";
            this.layoutControlItem11.Location = new System.Drawing.Point(200, 49);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "书号";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.yesOrNoControl1;
            this.layoutControlItem1.CustomizationFormText = "是否限制";
            this.layoutControlItem1.Location = new System.Drawing.Point(600, 25);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 48);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "是否限制";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.winGridView1.Size = new System.Drawing.Size(874, 313);
            this.winGridView1.TabIndex = 0;
            // 
            // dropDownButton2
            // 
            this.dropDownButton2.Location = new System.Drawing.Point(6, 68);
            this.dropDownButton2.Name = "dropDownButton2";
            this.dropDownButton2.Size = new System.Drawing.Size(75, 24);
            this.dropDownButton2.TabIndex = 2;
            this.dropDownButton2.Text = "折扣";
            this.dropDownButton2.Click += new System.EventHandler(this.dropDownButton2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_discount_pf,
            this.btn_discount_ls,
            this.btn_discount_hy,
            this.btn_discount_ps,
            this.btn_discount_wg,
            this.btn_discount_limit,
            this.btn_discount_cancel,
            this.btn_discount_cl,
            this.btn_discount_hyl});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 202);
            // 
            // btn_discount_pf
            // 
            this.btn_discount_pf.Name = "btn_discount_pf";
            this.btn_discount_pf.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_pf.Text = "批发折扣";
            this.btn_discount_pf.Click += new System.EventHandler(this.btn_discount_pf_Click);
            // 
            // btn_discount_ls
            // 
            this.btn_discount_ls.Name = "btn_discount_ls";
            this.btn_discount_ls.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_ls.Text = "零售折扣";
            this.btn_discount_ls.Click += new System.EventHandler(this.btn_discount_ls_Click);
            // 
            // btn_discount_hy
            // 
            this.btn_discount_hy.Name = "btn_discount_hy";
            this.btn_discount_hy.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_hy.Text = "会员折扣";
            this.btn_discount_hy.Click += new System.EventHandler(this.btn_discount_hy_Click);
            // 
            // btn_discount_ps
            // 
            this.btn_discount_ps.Name = "btn_discount_ps";
            this.btn_discount_ps.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_ps.Text = "配送折扣";
            this.btn_discount_ps.Click += new System.EventHandler(this.btn_discount_ps_Click);
            // 
            // btn_discount_wg
            // 
            this.btn_discount_wg.Name = "btn_discount_wg";
            this.btn_discount_wg.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_wg.Text = "网购折扣";
            this.btn_discount_wg.Click += new System.EventHandler(this.btn_discount_wg_Click);
            // 
            // btn_discount_limit
            // 
            this.btn_discount_limit.Name = "btn_discount_limit";
            this.btn_discount_limit.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_limit.Text = "限制折扣";
            this.btn_discount_limit.Click += new System.EventHandler(this.btn_discount_limit_Click);
            // 
            // btn_discount_cancel
            // 
            this.btn_discount_cancel.Name = "btn_discount_cancel";
            this.btn_discount_cancel.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_cancel.Text = "取消限制";
            this.btn_discount_cancel.Click += new System.EventHandler(this.btn_discount_cancel_Click);
            // 
            // btn_discount_cl
            // 
            this.btn_discount_cl.Name = "btn_discount_cl";
            this.btn_discount_cl.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_cl.Text = "客户级别折扣";
            // 
            // btn_discount_hyl
            // 
            this.btn_discount_hyl.Name = "btn_discount_hyl";
            this.btn_discount_hyl.Size = new System.Drawing.Size(148, 22);
            this.btn_discount_hyl.Text = "会员级别折扣";
            // 
            // btn_limit_care
            // 
            this.btn_limit_care.Location = new System.Drawing.Point(87, 69);
            this.btn_limit_care.Name = "btn_limit_care";
            this.btn_limit_care.Size = new System.Drawing.Size(75, 23);
            this.btn_limit_care.TabIndex = 3;
            this.btn_limit_care.Text = "限制爱书卡";
            this.btn_limit_care.Click += new System.EventHandler(this.btn_limit_care_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(168, 42);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "商品条件(&T)";
            // 
            // btn_discount
            // 
            this.btn_discount.Location = new System.Drawing.Point(86, 15);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(75, 23);
            this.btn_discount.TabIndex = 5;
            this.btn_discount.Text = "本地价格";
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(87, 42);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 6;
            this.btn_set.Text = "本地设置";
            // 
            // btn_limitdate
            // 
            this.btn_limitdate.Location = new System.Drawing.Point(168, 12);
            this.btn_limitdate.Name = "btn_limitdate";
            this.btn_limitdate.Size = new System.Drawing.Size(75, 23);
            this.btn_limitdate.TabIndex = 7;
            this.btn_limitdate.Text = "预销期限";
            // 
            // FrmProductDiscount
            // 
            this.ClientSize = new System.Drawing.Size(874, 465);
            this.Name = "FrmProductDiscount";
            this.Text = "品种折扣";
            this.Load += new System.EventHandler(this.FrmProductDiscount_Load);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButton)).EndInit();
            this.PanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelCondition)).EndInit();
            this.PanelCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelDisplayCondition)).EndInit();
            this.PanelDisplayCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_isbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount_ls.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount_pf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_h_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pub_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesOrNoControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount_xz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_h_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        } 
        #endregion

        #region 构造方法，窗体加载
        public FrmProductDiscount()
        {
            InitializeComponent();
            winGridView1.GridView1.CustomColumnDisplayText += GridView1_CustomColumnDisplayText;
           
        }

     
        private void FrmProductDiscount_Load(object sender, EventArgs e)
        {
            this.btnPrint.Visible = false;
            this.btnAdd.Visible = false;
            this.btnExport.Visible = false;
            InitDropDown();
            AddColumnAlias();
            SetDisplayColumns();
            AddFormatString();
            DataSource();
            SetColumns();

        }
        
        #endregion

        #region gridView设置

        private void AddColumnAlias()
        {
            winGridView1.AddColumnAlias("H_isbn", "书号");
            winGridView1.AddColumnAlias("H_name", "商品名称");
            winGridView1.AddColumnAlias("H_output_price", "定价");
            winGridView1.AddColumnAlias("U_id", "单位");
            winGridView1.AddColumnAlias("Discount_rec", "最近到货折扣");
            winGridView1.AddColumnAlias("Price_system", "价格策略");
            winGridView1.AddColumnAlias("H_hopesell", "预销期限");
            winGridView1.AddColumnAlias("Output_discount", "批发折扣");
            winGridView1.AddColumnAlias("Discount_ps", "配送折扣");
            winGridView1.AddColumnAlias("Discount_ls", "零售折扣 ");
            winGridView1.AddColumnAlias("Discount_hy", "会员折扣");
            winGridView1.AddColumnAlias("Discount_yg", "网购折扣");
            winGridView1.AddColumnAlias("Zk_flag", "是否限制折扣");
            winGridView1.AddColumnAlias("Limite_zk", "限制折扣额");
            winGridView1.AddColumnAlias("Price_px", "批销价格");
            winGridView1.AddColumnAlias("Price_ps", "配送价格");
            winGridView1.AddColumnAlias("Price_ls", "零售价格");
            winGridView1.AddColumnAlias("Hy_price", "会员价格");
            winGridView1.AddColumnAlias("Card_flag", "是否禁用爱书卡");
        }

        private void SetDisplayColumns()
        {
            winGridView1.DisplayColumns = "H_isbn,H_name,H_output_price,U_id,Discount_rec,Price_system,H_hopesell,Output_discount,Discount_ps,Discount_ls,Discount_hy,Discount_yg,Zk_flag,Limite_zk,Price_px,Price_ps,Price_ls,Hy_price,Card_flag";
        }
        private void AddFormatString()
        {
            winGridView1.FormatString.Add("H_output_price", "c2");
            winGridView1.FormatString.Add("Price_px", "c2");
            winGridView1.FormatString.Add("Price_ps", "c2");
            winGridView1.FormatString.Add("Price_ls", "c2");
            winGridView1.FormatString.Add("Hy_price", "c2");
            winGridView1.FormatString.Add("Discount_rec", "p2");
            winGridView1.FormatString.Add("Output_discount", "p2");
            winGridView1.FormatString.Add("Discount_ps", "p2");
            winGridView1.FormatString.Add("Discount_ls", "p2");
            winGridView1.FormatString.Add("Discount_hy", "p2");
            winGridView1.FormatString.Add("Discount_yg", "p2");
            winGridView1.FormatString.Add("Limite_zk", "p2");

            winGridView1.FormatString.Add("H_hopesell", "yyyy-MM-dd HH:mm:ss");


            winGridView1.TextHorzAlignment.Add("Zk_flag", DevExpress.Utils.HorzAlignment.Center);
            winGridView1.TextHorzAlignment.Add("Card_flag", DevExpress.Utils.HorzAlignment.Center);
        }

        private void SetColumns()
        {
            winGridView1.GridView1.Columns["Zk_flag"].ColumnEdit = WHC.Dictionary.DictItemUtil.YesorNoByGrid();
            winGridView1.GridView1.Columns["U_id"].ColumnEdit = WHC.Dictionary.DictItemUtil.UseTypeByGrid();

        }
        private void DataSource()
        {
            winGridView1.DataSource = listsp;
        }

        public override void BindData()
        {
            listsp.Clear();
            listsp.AddRange(CallerFactory<IProduct_discountService>.Instance.GetProductDiscountQuery(SqlWhere));
            winGridView1.GridView1.RefreshData();
        }

        private void InitDropDown()
        {
            this.txt_h_type.Properties.DisplayMember = "项目值";
            this.txt_h_type.Properties.ValueMember = "显示值";
            this.txt_h_type.Properties.DataSource = WHC.Dictionary.DictItemUtil.TypeLevelByEditor();
        }

        #endregion

        #region gridview事件
        public void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Price_system")
            {
                if (e.Value != null && e.Value == "0")
                {
                    e.DisplayText = "无本地价";
                }
                else
                {
                    e.DisplayText = "有本地价";
                }
            }

            if (e.Column.FieldName == "Card_flag")
            {
                if (e.Value != null && e.Value == "0")
                {
                    e.DisplayText = "否";
                }
                else
                {
                    e.DisplayText = "是";
                }
            }
        } 
        #endregion

        #region 按钮事件
        private void dropDownButton2_Click(object sender, EventArgs e)
        {
            var info = winGridView1.GridView1.GetFocusedRow() as SimpleProductInfo;
            if (info != null)
            {
                contextMenuStrip1.Show(MousePosition.X + 4, MousePosition.Y + 5);
            }
            else
            {
                MessageDxUtil.ShowTips("请选择需要修改折扣的商品！");
            }
           
        }

        /// <summary>
        /// 本地折扣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_discount_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 批发折扣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_discount_pf_Click(object sender, EventArgs e)
        {
            state = 0;
            DiscountMehtod(state);
            winGridView1.GridView1.RefreshData();
        }
        /// <summary>
        /// 零售折扣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_discount_ls_Click(object sender, EventArgs e)
        {
            state = 2;
            DiscountMehtod(state);
            winGridView1.GridView1.RefreshData();
        }

        /// <summary>
        /// 会员折扣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_discount_hy_Click(object sender, EventArgs e)
        {
            state = 4;
            DiscountMehtod(state);
            winGridView1.GridView1.RefreshData();
        }

        /// <summary>
        /// 配送折扣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_discount_ps_Click(object sender, EventArgs e)
        {
            state = 1;
            DiscountMehtod(state);
            winGridView1.GridView1.RefreshData();
        }

        /// <summary>
        /// 网购折扣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_discount_wg_Click(object sender, EventArgs e)
        {
            state =3;
            DiscountMehtod(state);
            winGridView1.GridView1.RefreshData();
        }
        #endregion

        #region 折扣方法
        /// <summary>
        /// 修改折扣
        /// </summary>
        /// <param name="h_id"></param>
        /// <param name="dicount"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        private bool AlterDiscountWay(string h_id, double dicount, int state)
        {
            bool result = false;
            result = CallerFactory<IProduct_discountService>.Instance.DiscountWay(h_id, dicount, state);
            if (!result)
            {
                MessageDxUtil.ShowError(CallerFactory<IProduct_discountService>.Instance.SqlErrorText());
            }
            return result;
        }


        /// <summary>
        /// 获取当前行修改折扣
        /// </summary>
        /// <param name="State"></param>
        private void DiscountMehtod(int State)
        {
            var info = winGridView1.GridView1.GetFocusedRow() as SimpleProductInfo;
            if (info != null)
            {
                h_id = info.H_id;
                double discount= FrmSelectDiscount.ShowSelectDiscount();
                if (discount != -1)
                {
                    AlterDiscountWay(h_id, discount, State);
                }
             
            }
            else return;
           
        }

        /// <summary>
        /// 获取当前行限制/取消折扣
        /// </summary>
        /// <param name="State"></param>
        private void LimitDiscountMehtod(int State)
        {
            var info = winGridView1.GridView1.GetFocusedRow() as SimpleProductInfo;
            if (info != null)
            {
                h_id = info.H_id;
                double discount = FrmSelectDiscount.ShowSelectDiscount();
                if (discount != -1)
                {
                    bool result = false;
                    result = CallerFactory<IProduct_discountService>.Instance.LimitDiscountWay(h_id, discount, state);
                    if (!result)
                    {
                        MessageDxUtil.ShowError(CallerFactory<IProduct_discountService>.Instance.SqlErrorText());
                    }
                }

            }
            else return;

        } 
        #endregion

       /// <summary>
       /// 限制折扣
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_discount_limit_Click(object sender, EventArgs e)
        {
            state = 1;
            LimitDiscountMehtod(state);
        }

       /// <summary>
       /// 取消限制
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_discount_cancel_Click(object sender, EventArgs e)
        {
            state = 0;
            LimitDiscountMehtod(state);
        }

       /// <summary>
       /// 限制爱书卡
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

        private void btn_limit_care_Click(object sender, EventArgs e)
        {

            bool result = false;
            var info = winGridView1.GridView1.GetFocusedRow() as SimpleProductInfo;
            if (info != null)
            {
                if (MessageDxUtil.ShowYesNoAndTips("你确认禁止当前商品使用爱书卡的零售收款吗？")==System.Windows.Forms.DialogResult.Yes)
                {
                    h_id = info.H_id;
                    result = CallerFactory<IProduct_discountService>.Instance.LimitCard(h_id);
                    if (!result)
                    {
                        MessageDxUtil.ShowError(CallerFactory<IProduct_discountService>.Instance.SqlErrorText());
                    }
                }
            }
        }

      
   }
}
