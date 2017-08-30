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
using System.Text;

namespace Erp.Base.UI
{
   public  class FrmProduct : BaseDockQuery
   {
       #region 定义变量
       private DevExpress.XtraLayout.LayoutControl layoutControl1;
       private DateTimeControl dateTimeControl1;
       private ComboBoxControl txt_o_id;
       private ComboBoxControl txtFlag_sales_class;
       private ComboBoxControl txt_exit;
       private ComboBoxControl txtH_type;
       private NumTextBoxControl numTextBoxControl2;
       private TextBoxControl textBoxControl4;
       private TextBoxControl textBoxControl3;
       private TextBoxControl textBoxControl2;
       private TextBoxControl textBoxControl1;
       private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
       private WinGridView winGridView1;
       private TextBoxControl textBoxControl5;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
       private IContainer components;

       public List<ProductInfo> productlist = new List<ProductInfo>();
       #endregion

       #region InitializeComponent
       private void InitializeComponent()
       {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textBoxControl5 = new WHC.Framework.Commons.TextBoxControl();
            this.dateTimeControl1 = new WHC.Framework.Commons.DateTimeControl();
            this.txt_o_id = new WHC.Framework.Commons.ComboBoxControl();
            this.txtFlag_sales_class = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_exit = new WHC.Framework.Commons.ComboBoxControl();
            this.txtH_type = new WHC.Framework.Commons.ComboBoxControl();
            this.numTextBoxControl2 = new WHC.Framework.Commons.NumTextBoxControl();
            this.textBoxControl4 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl3 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl2 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl1 = new WHC.Framework.Commons.TextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_o_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlag_sales_class.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_exit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTextBoxControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Location = new System.Drawing.Point(564, 0);
            this.PanelButton.Size = new System.Drawing.Size(225, 100);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(559, 0);
            // 
            // PanelCondition
            // 
            this.PanelCondition.Controls.Add(this.layoutControl1);
            this.PanelCondition.Size = new System.Drawing.Size(559, 100);
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textBoxControl5);
            this.layoutControl1.Controls.Add(this.dateTimeControl1);
            this.layoutControl1.Controls.Add(this.txt_o_id);
            this.layoutControl1.Controls.Add(this.txtFlag_sales_class);
            this.layoutControl1.Controls.Add(this.txt_exit);
            this.layoutControl1.Controls.Add(this.txtH_type);
            this.layoutControl1.Controls.Add(this.numTextBoxControl2);
            this.layoutControl1.Controls.Add(this.textBoxControl4);
            this.layoutControl1.Controls.Add(this.textBoxControl3);
            this.layoutControl1.Controls.Add(this.textBoxControl2);
            this.layoutControl1.Controls.Add(this.textBoxControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(559, 100);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textBoxControl5
            // 
            this.textBoxControl5.ChineseColumnName = "书号";
            this.textBoxControl5.ColumnName = "h_isbn";
            this.textBoxControl5.Location = new System.Drawing.Point(463, 12);
            this.textBoxControl5.Name = "textBoxControl5";
            this.textBoxControl5.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl5.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl5.Size = new System.Drawing.Size(145, 20);
            this.textBoxControl5.StyleController = this.layoutControl1;
            this.textBoxControl5.TabIndex = 8;
            this.textBoxControl5.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // dateTimeControl1
            // 
            this.dateTimeControl1.ChineseColumnName = "建党日期";
            this.dateTimeControl1.ColumnName = "h_input_date";
            this.dateTimeControl1.EndDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeControl1.Location = new System.Drawing.Point(463, 36);
            this.dateTimeControl1.Name = "dateTimeControl1";
            this.dateTimeControl1.Size = new System.Drawing.Size(145, 20);
            this.dateTimeControl1.TabIndex = 1;
            // 
            // txt_o_id
            // 
            this.txt_o_id.ChineseColumnName = "采购主管";
            this.txt_o_id.ColumnName = "o_id_lastgr";
            this.txt_o_id.Location = new System.Drawing.Point(663, 36);
            this.txt_o_id.Name = "txt_o_id";
            this.txt_o_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_o_id.Properties.NullValuePrompt = "请选择...";
            this.txt_o_id.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_o_id.Size = new System.Drawing.Size(145, 20);
            this.txt_o_id.StyleController = this.layoutControl1;
            this.txt_o_id.TabIndex = 1;
            // 
            // txtFlag_sales_class
            // 
            this.txtFlag_sales_class.ChineseColumnName = "商品属性";
            this.txtFlag_sales_class.ColumnName = "flag_sales_class";
            this.txtFlag_sales_class.Location = new System.Drawing.Point(463, 60);
            this.txtFlag_sales_class.Name = "txtFlag_sales_class";
            this.txtFlag_sales_class.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFlag_sales_class.Properties.NullValuePrompt = "请选择...";
            this.txtFlag_sales_class.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtFlag_sales_class.Size = new System.Drawing.Size(145, 20);
            this.txtFlag_sales_class.StyleController = this.layoutControl1;
            this.txtFlag_sales_class.TabIndex = 2;
            // 
            // txt_exit
            // 
            this.txt_exit.ChineseColumnName = "是否经销";
            this.txt_exit.ColumnName = "h_exist";
            this.txt_exit.Location = new System.Drawing.Point(263, 60);
            this.txt_exit.Name = "txt_exit";
            this.txt_exit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_exit.Properties.NullValuePrompt = "请选择...";
            this.txt_exit.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_exit.Size = new System.Drawing.Size(145, 20);
            this.txt_exit.StyleController = this.layoutControl1;
            this.txt_exit.TabIndex = 3;
            // 
            // txtH_type
            // 
            this.txtH_type.ChineseColumnName = "商品类别";
            this.txtH_type.ColumnName = "h_type";
            this.txtH_type.Location = new System.Drawing.Point(63, 60);
            this.txtH_type.Name = "txtH_type";
            this.txtH_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtH_type.Properties.NullValuePrompt = "请选择...";
            this.txtH_type.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtH_type.Size = new System.Drawing.Size(145, 20);
            this.txtH_type.StyleController = this.layoutControl1;
            this.txtH_type.TabIndex = 4;
            // 
            // numTextBoxControl2
            // 
            this.numTextBoxControl2.ChineseColumnName = "定价";
            this.numTextBoxControl2.ColumnName = "h_output_price";
            this.numTextBoxControl2.Location = new System.Drawing.Point(663, 12);
            this.numTextBoxControl2.Name = "numTextBoxControl2";
            this.numTextBoxControl2.Size = new System.Drawing.Size(145, 20);
            this.numTextBoxControl2.StyleController = this.layoutControl1;
            this.numTextBoxControl2.TabIndex = 1;
            this.numTextBoxControl2.ToolTip = "有效条件：>100，<100，1-100，>=100，<=100，<>100，100\n\r条件描述：大于100，小于100，1至100，大于等于100.....\n\r" +
    "多条件以,分开如：100,200,300\n\r条件描述：值等于100，或者等于200，或者等于300";
            // 
            // textBoxControl4
            // 
            this.textBoxControl4.ChineseColumnName = "出版社";
            this.textBoxControl4.ColumnName = "pub_id";
            this.textBoxControl4.Location = new System.Drawing.Point(263, 36);
            this.textBoxControl4.Name = "textBoxControl4";
            this.textBoxControl4.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl4.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl4.Size = new System.Drawing.Size(145, 20);
            this.textBoxControl4.StyleController = this.layoutControl1;
            this.textBoxControl4.TabIndex = 7;
            this.textBoxControl4.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl3
            // 
            this.textBoxControl3.ChineseColumnName = "主要货源";
            this.textBoxControl3.ColumnName = "h_factory";
            this.textBoxControl3.Location = new System.Drawing.Point(63, 36);
            this.textBoxControl3.Name = "textBoxControl3";
            this.textBoxControl3.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl3.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl3.Size = new System.Drawing.Size(145, 20);
            this.textBoxControl3.StyleController = this.layoutControl1;
            this.textBoxControl3.TabIndex = 6;
            this.textBoxControl3.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl2
            // 
            this.textBoxControl2.ChineseColumnName = "商品名称";
            this.textBoxControl2.ColumnName = "h_name";
            this.textBoxControl2.Location = new System.Drawing.Point(263, 12);
            this.textBoxControl2.Name = "textBoxControl2";
            this.textBoxControl2.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl2.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl2.Size = new System.Drawing.Size(145, 20);
            this.textBoxControl2.StyleController = this.layoutControl1;
            this.textBoxControl2.TabIndex = 5;
            this.textBoxControl2.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl1
            // 
            this.textBoxControl1.ChineseColumnName = "商品谐音";
            this.textBoxControl1.ColumnName = "my_help_input";
            this.textBoxControl1.Location = new System.Drawing.Point(63, 12);
            this.textBoxControl1.Name = "textBoxControl1";
            this.textBoxControl1.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl1.Size = new System.Drawing.Size(145, 20);
            this.textBoxControl1.StyleController = this.layoutControl1;
            this.textBoxControl1.TabIndex = 4;
            this.textBoxControl1.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(820, 92);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBoxControl1;
            this.layoutControlItem1.CustomizationFormText = "商品谐音";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "商品谐音";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxControl2;
            this.layoutControlItem2.CustomizationFormText = "商品名称";
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "商品名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.numTextBoxControl2;
            this.layoutControlItem6.CustomizationFormText = "定价";
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(600, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "定价";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBoxControl3;
            this.layoutControlItem3.CustomizationFormText = "主要货源";
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "主要货源";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textBoxControl4;
            this.layoutControlItem4.CustomizationFormText = "出版社";
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "出版社";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtH_type;
            this.layoutControlItem7.CustomizationFormText = "商品类别";
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "商品类别";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txt_exit;
            this.layoutControlItem8.CustomizationFormText = "经销否";
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Location = new System.Drawing.Point(200, 48);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "经销否";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtFlag_sales_class;
            this.layoutControlItem9.CustomizationFormText = "属性";
            this.layoutControlItem9.FillControlToClientArea = false;
            this.layoutControlItem9.Location = new System.Drawing.Point(400, 48);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "属性";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txt_o_id;
            this.layoutControlItem10.CustomizationFormText = "采购主管";
            this.layoutControlItem10.FillControlToClientArea = false;
            this.layoutControlItem10.Location = new System.Drawing.Point(600, 24);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(200, 48);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "采购主管";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.dateTimeControl1;
            this.layoutControlItem11.CustomizationFormText = "建档日期";
            this.layoutControlItem11.FillControlToClientArea = false;
            this.layoutControlItem11.Location = new System.Drawing.Point(400, 24);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "建档日期";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textBoxControl5;
            this.layoutControlItem5.CustomizationFormText = "书号";
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "书号";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
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
            this.winGridView1.Size = new System.Drawing.Size(789, 225);
            this.winGridView1.TabIndex = 1;
            // 
            // FrmProduct
            // 
            this.ClientSize = new System.Drawing.Size(789, 375);
            this.Name = "FrmProduct";
            this.Text = "商品信息";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_o_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlag_sales_class.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_exit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTextBoxControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

       } 
       #endregion


       #region 构造
       public FrmProduct()
       {
           InitializeComponent();
           this.winGridView1.BestFitColumnWith = false;
       }

       #endregion

       #region 格式


       private void InitDict()
       {
           try
           {
               this.winGridView1.gridView1.Columns["Is_focus"].ColumnEdit = DictItemUtil.YesorNoByGrid();
               this.winGridView1.gridView1.Columns["Is_my"].ColumnEdit = DictItemUtil.YesorNoByGrid();
               this.winGridView1.gridView1.Columns["Isbn_class"].ColumnEdit = DictItemUtil.Isbn_ClassByGrid();
               this.winGridView1.gridView1.Columns["Pub_id"].ColumnEdit = BaseUtil.PublishByGrid();
               // this.winGridView1.gridView1.Columns["h_type"].ColumnEdit = BaseUtil.H_TypeByGrid();
               this.winGridView1.gridView1.Columns["Flag_sales_class"].ColumnEdit = DictItemUtil.Flag_Sales_ClassByGrid();
               this.winGridView1.gridView1.Columns["Sales_level"].ColumnEdit = DictItemUtil.Sales_levelByGrid();
               this.winGridView1.gridView1.Columns["Price_system"].ColumnEdit = DictItemUtil.Price_systemByGrid();
               this.winGridView1.gridView1.Columns["O_id_lastgr"].ColumnEdit = SecurityUtil.O_idByGrid();
               this.winGridView1.gridView1.Columns["Sales_type"].ColumnEdit = DictItemUtil.Sales_ClassByGrid();
               this.winGridView1.gridView1.Columns["U_id"].ColumnEdit = DictItemUtil.U_idByGrid();
               this.winGridView1.gridView1.Columns["Kb_id"].ColumnEdit = DictItemUtil.Kb_idByGrid();
               this.winGridView1.gridView1.Columns["H_run_style"].ColumnEdit = DictItemUtil.Sale_StyleByGrid();
               this.winGridView1.gridView1.Columns["H_factory"].ColumnEdit = BaseUtil.F_idByGrid();
               this.winGridView1.gridView1.Columns["Yz_id"].ColumnEdit = DictItemUtil.Yz_idByGrid();
               this.winGridView1.gridView1.Columns["H_media"].ColumnEdit = DictItemUtil.H_mediaByGrid();
               this.winGridView1.gridView1.Columns["H_banci"].ColumnEdit = DictItemUtil.Banci_idByGrid();
               this.winGridView1.gridView1.Columns["H_bak1"].ColumnEdit = DictItemUtil.Bak1ByGrid();
               this.winGridView1.gridView1.Columns["H_bak2"].ColumnEdit = DictItemUtil.Bak2ByGrid();
               this.winGridView1.gridView1.Columns["H_taozhuang"].ColumnEdit = DictItemUtil.YesorNoByGrid();
               this.winGridView1.gridView1.Columns["H_exist"].ColumnEdit = DictItemUtil.YesorNoByGrid();
               this.winGridView1.gridView1.Columns["Zz_id"].ColumnEdit = DictItemUtil.ZhuangzhenByGrid();
               this.winGridView1.gridView1.Columns["Bz_id"].ColumnEdit = DictItemUtil.PackageByGrid();
               this.winGridView1.gridView1.Columns["H_id_other"].ColumnEdit = BaseUtil.H_idByGrid();
               this.winGridView1.gridView1.Columns["Yylb_id"].ColumnEdit = DictItemUtil.YylbByGrid();
               this.winGridView1.gridView1.Columns["H_serial_book"].ColumnEdit = DictItemUtil.Serial_bookByGrid();
               this.winGridView1.gridView1.Columns["O_id_input"].ColumnEdit = WHC.Security.SecurityUtil.O_idByGrid();
               this.winGridView1.gridView1.Columns["O_id_lastmodify"].ColumnEdit = WHC.Security.SecurityUtil.O_idByGrid();


           }
           catch (Exception ex)
           {
               LogTextHelper.Error(ex);
               MessageDxUtil.ShowError(ex.Message);
           }


       } 
       #endregion


       #region 绑定数据
       public override void BindData()
       {
           Cursor = Cursors.WaitCursor;

           productlist.Clear();
           productlist.AddRange(CallerFactory<IProductService>.Instance.Find(this.SqlWhere));
           this.InitDict();
           this.winGridView1.GridView1.RefreshData();
           Cursor = Cursors.Default;
       } 
       #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
            this.winGridView1.AutoSize = false;

        }

        #region 加载
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            SelectChose();
            this.winGridView1.OnAddNew += new EventHandler(winGridView1_OnAddNew);
            this.winGridView1.OnEditSelected += new EventHandler(winGridView1_OnEditSelected);
            this.PKey = "h_id";
            this.btnAdd.Enabled = Portal.gc.HasFunction("Product/Add");
            this.winGridView1.ColumnNameAlias = CallerFactory<IProductService>.Instance.GetColumnNameAlias();
            this.winGridView1.DisplayColumns = this.winGridView1.ColumnNameAlias.GetDisplayByAlias();
            winGridView1.DataSource = productlist;
        }

        //private string GetDisplayColumn(Dictionary<string, string> alias)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (string s in alias.Keys)
        //    {
        //        sb.AppendFormat("{0}|", s);
        //    }

        //    return sb.ToString();
        //}
        #endregion

        #region 下拉

        private void SelectChose()
        {
            this.txt_exit.Properties.DisplayMember = "显示值";
            this.txt_exit.Properties.ValueMember = "项目值";
            this.txt_exit.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txt_o_id.Properties.DisplayMember = "显示值";
            this.txt_o_id.Properties.ValueMember = "项目值";
            this.txt_o_id.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtFlag_sales_class.Properties.DisplayMember = "显示值";
            this.txtFlag_sales_class.Properties.ValueMember = "项目值";
            this.txtFlag_sales_class.Properties.DataSource = WHC.Dictionary.DictItemUtil.Flag_Sales_ClassByEditor();


            this.txtH_type.Properties.DisplayMember = "显示值";
            this.txtH_type.Properties.ValueMember = "项目值";
            this.txtH_type.Properties.DataSource = BaseUtil.H_TypeByEditor();


        } 
        #endregion

        #region 双击
        private void winGridView1_OnEditSelected(object sender, EventArgs e)
        {
            EditItem();
        } 
        #endregion

        #region 编辑对照信息

        /// <summary>
        /// 编辑对照信息
        /// </summary>
        /// <typeparam name="T">编辑对照信息的窗体</typeparam>
        public void EditItem()
        {
            if (!Portal.gc.HasFunction(" Product/Edit"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("Product/Edit", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                return;
            }

            FrmEditProduct dlg = new FrmEditProduct();
            dlg.Text = "商品信息";
            dlg.MasterView = this.winGridView1.GridView1;
            dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
            if (DialogResult.OK == dlg.ShowDialog())
            {
                BindData();
            }
        }
        
        #endregion
        

        private void winGridView1_OnAddNew(object sender, EventArgs e)
        {

            AddItem();
        }
        /// <summary>
        /// 增加项目
        /// </summary>
        public void AddItem()
        {
            if (!Portal.gc.HasFunction(" Product/Add"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("Product/Add", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                return ;
            } 
            FrmEditProduct dlg = new FrmEditProduct();
            dlg.Text = "商品信息";
            dlg.rowIndex = -1;
            dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
            if (DialogResult.OK == dlg.ShowDialog())
            {
                BindData();
            }
            dlg.Dispose();
        }
        void dlg_OnDataSaved(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            winGridView1_OnAddNew(null, null);
        }
       
       
   }
}
