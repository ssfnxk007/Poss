using Erp.Base.Entity;
using Erp.Base.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace Erp.Base.UI
{
    public class QueryProduct : BaseDockQuery
    {
        #region 变量
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private WHC.Framework.Commons.TextBoxControl textBoxControl6;
        private System.ComponentModel.IContainer components;
        private WHC.Framework.Commons.TextBoxControl textBoxControl5;
        private WHC.Framework.Commons.DateTimeControl dateTimeControl1;
        private WHC.Framework.Commons.ComboBoxControl btn_type;
        private WHC.Framework.Commons.TextBoxControl textBoxControl4;
        private WHC.Framework.Commons.TextBoxControl textBoxControl3;
        private WHC.Framework.Commons.TextBoxControl textBoxControl2;
        private WHC.Framework.Commons.TextBoxControl textBoxControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_control;
         
        public List<ProductInfo> Querylist = new List<ProductInfo>();
        public List<SimpleProductInfo> selectlist = new List<SimpleProductInfo>();
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        public List<ProductInfo> sslist = new List<ProductInfo>();
        public BackgroundWorker QueryProductWorker = null;//建立一个后线程
        private string sqlWhere = string.Empty;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
       
        private string sqlWhereDescribe = string.Empty;
        public string SqlWhere
        {
            get
            {

                return sqlWhere;
            }
        }
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.btn_control = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textBoxControl6 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl5 = new WHC.Framework.Commons.TextBoxControl();
            this.dateTimeControl1 = new WHC.Framework.Commons.DateTimeControl();
            this.btn_type = new WHC.Framework.Commons.ComboBoxControl();
            this.textBoxControl4 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl3 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl2 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl1 = new WHC.Framework.Commons.TextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Erp.Base.UI.Client.Control.WaitForm1), true, true);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.simpleButton1);
            this.PanelButton.Controls.Add(this.btn_ok);
            this.PanelButton.Controls.Add(this.btn_control);
            this.PanelButton.Location = new System.Drawing.Point(649, 0);
            this.PanelButton.Size = new System.Drawing.Size(255, 100);
            this.PanelButton.Controls.SetChildIndex(this.btnQuery, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnReset, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnPrint, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnExport, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnAdd, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnExit, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_control, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_ok, 0);
            this.PanelButton.Controls.SetChildIndex(this.simpleButton1, 0);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(644, 0);
            // 
            // PanelCondition
            // 
            this.PanelCondition.Controls.Add(this.layoutControl1);
            this.PanelCondition.Size = new System.Drawing.Size(644, 100);
            // 
            // PanelDisplayCondition
            // 
            this.PanelDisplayCondition.Size = new System.Drawing.Size(904, 40);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 69);
            this.btnExit.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(171, 0);
            this.btnAdd.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(171, 42);
            this.btnExport.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(171, 15);
            this.btnPrint.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(5, 54);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(6, 20);
            this.btnQuery.Visible = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            this.panelControl1.Size = new System.Drawing.Size(904, 375);
            // 
            // LabelCondition
            // 
            this.LabelCondition.Size = new System.Drawing.Size(900, 36);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(904, 525);
            // 
            // btn_control
            // 
            this.btn_control.Location = new System.Drawing.Point(87, 20);
            this.btn_control.Name = "btn_control";
            this.btn_control.Size = new System.Drawing.Size(75, 23);
            this.btn_control.TabIndex = 1;
            this.btn_control.Text = "商品条件";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(87, 54);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "确定";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textBoxControl6);
            this.layoutControl1.Controls.Add(this.textBoxControl5);
            this.layoutControl1.Controls.Add(this.dateTimeControl1);
            this.layoutControl1.Controls.Add(this.btn_type);
            this.layoutControl1.Controls.Add(this.textBoxControl4);
            this.layoutControl1.Controls.Add(this.textBoxControl3);
            this.layoutControl1.Controls.Add(this.textBoxControl2);
            this.layoutControl1.Controls.Add(this.textBoxControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(644, 100);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textBoxControl6
            // 
            this.textBoxControl6.ChineseColumnName = "出版社";
            this.textBoxControl6.ColumnName = "pub_id";
            this.textBoxControl6.Location = new System.Drawing.Point(384, 74);
            this.textBoxControl6.MaximumSize = new System.Drawing.Size(120, 24);
            this.textBoxControl6.MinimumSize = new System.Drawing.Size(120, 24);
            this.textBoxControl6.Name = "textBoxControl6";
            this.textBoxControl6.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl6.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl6.Size = new System.Drawing.Size(120, 24);
            this.textBoxControl6.StyleController = this.layoutControl1;
            this.textBoxControl6.TabIndex = 11;
            this.textBoxControl6.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl5
            // 
            this.textBoxControl5.ChineseColumnName = "主要货源";
            this.textBoxControl5.ColumnName = "H_factory";
            this.textBoxControl5.Location = new System.Drawing.Point(260, 74);
            this.textBoxControl5.Name = "textBoxControl5";
            this.textBoxControl5.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl5.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl5.Size = new System.Drawing.Size(120, 20);
            this.textBoxControl5.StyleController = this.layoutControl1;
            this.textBoxControl5.TabIndex = 10;
            this.textBoxControl5.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // dateTimeControl1
            // 
            this.dateTimeControl1.ChineseColumnName = "建档日期";
            this.dateTimeControl1.ColumnName = "H_input_date";
            this.dateTimeControl1.EndDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeControl1.Location = new System.Drawing.Point(136, 74);
            this.dateTimeControl1.Name = "dateTimeControl1";
            this.dateTimeControl1.Size = new System.Drawing.Size(120, 24);
            this.dateTimeControl1.TabIndex = 9;
            // 
            // btn_type
            // 
            this.btn_type.ChineseColumnName = "商品类别";
            this.btn_type.ColumnName = "h_type";
            this.btn_type.Location = new System.Drawing.Point(12, 70);
            this.btn_type.Name = "btn_type";
            this.btn_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btn_type.Properties.NullValuePrompt = "请选择...";
            this.btn_type.Properties.NullValuePromptShowForEmptyValue = true;
            this.btn_type.Size = new System.Drawing.Size(120, 20);
            this.btn_type.StyleController = this.layoutControl1;
            this.btn_type.TabIndex = 8;
            // 
            // textBoxControl4
            // 
            this.textBoxControl4.ChineseColumnName = "定价";
            this.textBoxControl4.ColumnName = "db_product.H_output_price";
            this.textBoxControl4.Location = new System.Drawing.Point(384, 29);
            this.textBoxControl4.MaximumSize = new System.Drawing.Size(120, 24);
            this.textBoxControl4.MinimumSize = new System.Drawing.Size(120, 24);
            this.textBoxControl4.Name = "textBoxControl4";
            this.textBoxControl4.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl4.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl4.Size = new System.Drawing.Size(120, 24);
            this.textBoxControl4.StyleController = this.layoutControl1;
            this.textBoxControl4.TabIndex = 7;
            this.textBoxControl4.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl3
            // 
            this.textBoxControl3.ChineseColumnName = "书号";
            this.textBoxControl3.ColumnName = "db_product.h_isbn";
            this.textBoxControl3.Location = new System.Drawing.Point(260, 29);
            this.textBoxControl3.MaximumSize = new System.Drawing.Size(120, 24);
            this.textBoxControl3.MinimumSize = new System.Drawing.Size(120, 24);
            this.textBoxControl3.Name = "textBoxControl3";
            this.textBoxControl3.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl3.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl3.Size = new System.Drawing.Size(120, 24);
            this.textBoxControl3.StyleController = this.layoutControl1;
            this.textBoxControl3.TabIndex = 6;
            this.textBoxControl3.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl2
            // 
            this.textBoxControl2.ChineseColumnName = "商品名称";
            this.textBoxControl2.ColumnName = "db_product.h_name";
            this.textBoxControl2.Location = new System.Drawing.Point(136, 29);
            this.textBoxControl2.MaximumSize = new System.Drawing.Size(120, 24);
            this.textBoxControl2.MinimumSize = new System.Drawing.Size(120, 24);
            this.textBoxControl2.Name = "textBoxControl2";
            this.textBoxControl2.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl2.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl2.Size = new System.Drawing.Size(120, 24);
            this.textBoxControl2.StyleController = this.layoutControl1;
            this.textBoxControl2.TabIndex = 5;
            this.textBoxControl2.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl1
            // 
            this.textBoxControl1.ChineseColumnName = "商品谐音";
            this.textBoxControl1.ColumnName = "db_product.My_help_input";
            this.textBoxControl1.Location = new System.Drawing.Point(12, 29);
            this.textBoxControl1.MaximumSize = new System.Drawing.Size(120, 20);
            this.textBoxControl1.MinimumSize = new System.Drawing.Size(120, 20);
            this.textBoxControl1.Name = "textBoxControl1";
            this.textBoxControl1.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl1.Size = new System.Drawing.Size(120, 20);
            this.textBoxControl1.StyleController = this.layoutControl1;
            this.textBoxControl1.TabIndex = 4;
            this.textBoxControl1.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(627, 110);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBoxControl1;
            this.layoutControlItem1.CustomizationFormText = "商品谐音:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(124, 41);
            this.layoutControlItem1.Text = "商品谐音:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxControl2;
            this.layoutControlItem2.CustomizationFormText = "商品名称:";
            this.layoutControlItem2.Location = new System.Drawing.Point(124, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(124, 45);
            this.layoutControlItem2.Text = "商品名称:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBoxControl3;
            this.layoutControlItem3.CustomizationFormText = "书  号:";
            this.layoutControlItem3.Location = new System.Drawing.Point(248, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 45);
            this.layoutControlItem3.Text = "书  号:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textBoxControl4;
            this.layoutControlItem4.CustomizationFormText = "定  价:";
            this.layoutControlItem4.Location = new System.Drawing.Point(372, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(235, 45);
            this.layoutControlItem4.Text = "定  价:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_type;
            this.layoutControlItem5.CustomizationFormText = "商品类别:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(124, 49);
            this.layoutControlItem5.Text = "商品类别:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dateTimeControl1;
            this.layoutControlItem6.CustomizationFormText = "建档日期:";
            this.layoutControlItem6.Location = new System.Drawing.Point(124, 45);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(124, 45);
            this.layoutControlItem6.Text = "建档日期:";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textBoxControl5;
            this.layoutControlItem7.CustomizationFormText = "主要货源:";
            this.layoutControlItem7.Location = new System.Drawing.Point(248, 45);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(124, 45);
            this.layoutControlItem7.Text = "主要货源:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textBoxControl6;
            this.layoutControlItem8.CustomizationFormText = "出版社:";
            this.layoutControlItem8.Location = new System.Drawing.Point(372, 45);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(235, 45);
            this.layoutControlItem8.Text = "出版社:";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 14);
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.EnableEdit = true;
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
            this.winGridView1.ShowFooter = true;
            this.winGridView1.Size = new System.Drawing.Size(904, 375);
            this.winGridView1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // QueryProduct
            // 
            this.ClientSize = new System.Drawing.Size(904, 525);
            this.Name = "QueryProduct";
            this.Text = "商品查询";
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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region 构造
        public QueryProduct()
        {
            InitializeComponent();
            this.Load += QueryProduct_Load;
            //this.winGridView1.GridView1.OptionsBehavior.AutoSelectAllInEditor = true;
            
            this.winGridView1.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Pink;//设置背景色
            //多行可选
            this.winGridView1.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            this.winGridView1.GridView1.OptionsSelection.MultiSelect = true;

           
        }

     

        #endregion

        #region 加载
        public void QueryProduct_Load(object sender, EventArgs e)
        {
            this.btn_type.Properties.DataSource = BaseUtil.H_TypeByEditor();
            AddColumnNameAlias();
            SetDisplayColumns();
            AddGridViewReadOnly();

            SetDataSource();
            ChangeGridViewStyleToBackColor();
            ChangeGridViewStyle();
            AddGridViewSum();
            SetGridViewEdit();


        } 
        #endregion

        #region GridView设置

        public  void AddColumnNameAlias()
        {
            #region 列别名
            this.winGridView1.AddColumnAlias("Check", "是否选中");

            this.winGridView1.AddColumnAlias("H_type", "商品分类");
            this.winGridView1.AddColumnAlias("H_name", "商品名称");
            this.winGridView1.AddColumnAlias("H_factory", "货源名称");
            this.winGridView1.AddColumnAlias("H_exist", "是否有效");
            this.winGridView1.AddColumnAlias("H_isbn", "ISBN号");
            this.winGridView1.AddColumnAlias("H_amount", "录入数量");
            this.winGridView1.AddColumnAlias("H_output_price", "定价");
            this.winGridView1.AddColumnAlias("Pub_name", "出版社简称");
            this.winGridView1.AddColumnAlias("H_mytm", "条码");
            this.winGridView1.AddColumnAlias("H_writer", "作者");
            this.winGridView1.AddColumnAlias("H_input_date", "录入日期");
            this.winGridView1.AddColumnAlias("H_id", "商品编码");
            this.winGridView1.AddColumnAlias("Pub_fullname", "出版社全称");
            this.winGridView1.AddColumnAlias("Stock_all", "所有库存");
            this.winGridView1.AddColumnAlias("Stock_local", "本地库存");
            this.winGridView1.AddColumnAlias("F_department_main", "主要货源");
            this.winGridView1.AddColumnAlias("F_department_rec", "实际货源");
            this.winGridView1.AddColumnAlias("My_help_input", "谐音");

           
            #endregion

            winGridView1.FormatString.Add("H_output_price", "c2");
        }
        public  void SetDisplayColumns()
        {

            this.winGridView1.DisplayColumns = "Check,H_type,H_name,H_exist,H_isbn,H_mytm,H_amount,H_output_price,Pub_name,Stock_all,Stock_local,F_department_main,F_department_rec,Pub_fullname,H_writer,H_input_date,My_help_input";
            
        }
        public  void SetDataSource()
        {
            this.winGridView1.DataSource = Querylist;
        }
        public  void AddGridViewSum()
        {
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("H_amount", "n0"));
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("H_output_price", "c2"));
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("Stock_all", "n0"));
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("Stock_local", "n0"));
        }
        public  void SetGridViewEdit()
        {
           
            try
            {
                winGridView1.GridView1.Columns["H_type"].ColumnEdit = Erp.Base.BaseUtil.H_TypeByGrid();
              
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
            }

            #region 对齐方式

            winGridView1.GridView1.Columns["H_amount"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            winGridView1.GridView1.Columns["H_amount"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            winGridView1.GridView1.Columns["H_output_price"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            winGridView1.GridView1.Columns["H_output_price"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            winGridView1.GridView1.Columns["Stock_all"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            winGridView1.GridView1.Columns["Stock_all"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            winGridView1.GridView1.Columns["Stock_local"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            winGridView1.GridView1.Columns["Stock_local"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            #endregion

        }

        public  void AddGridViewReadOnly()
        {
          
            this.winGridView1.ReadOnlyList.Add("H_type");
            this.winGridView1.ReadOnlyList.Add("H_name");
            this.winGridView1.ReadOnlyList.Add("H_exist");
            this.winGridView1.ReadOnlyList.Add("H_isbn");
            this.winGridView1.ReadOnlyList.Add("H_mytm");
            //this.winGridView1.ReadOnlyList.Add("H_amount");
            this.winGridView1.ReadOnlyList.Add("H_output_price");
            this.winGridView1.ReadOnlyList.Add("Pub_name");
            this.winGridView1.ReadOnlyList.Add("Stock_all");
            this.winGridView1.ReadOnlyList.Add("Stock_local");
            this.winGridView1.ReadOnlyList.Add("F_department_main");
            this.winGridView1.ReadOnlyList.Add("F_department_rec");
            this.winGridView1.ReadOnlyList.Add("Pub_fullname");
            this.winGridView1.ReadOnlyList.Add("H_writer");
            this.winGridView1.ReadOnlyList.Add("H_input_date");
            this.winGridView1.ReadOnlyList.Add("My_help_input");

        }

        #endregion

        #region 显示数据
        public void DisplayData()
        {
            Querylist.Clear();
            string stock = string.Empty;
            stock = Portal.gc.LoginStationInfo.Station_id;
            Querylist.AddRange(CallerFactory<IProductService>.Instance.Querylist(stock, SqlWhere));
            winGridView1.GridView1.GetFocusedRowCellValue("H_amount");
        } 
        #endregion

        #region 查询
        public  void btnQuery_Click(object sender, EventArgs e)
        {
            //InitQuery();
            //this.splashScreenManager1.ShowWaitForm();
            //this.splashScreenManager1.SetWaitFormCaption("请稍候...");
            //this.splashScreenManager1.SetWaitFormDescription("正在查询...");
            //QueryProductWorker = new BackgroundWorker();//实例化后台线程
            //QueryProductWorker.DoWork += QueryProductWorker_DoWork;//工作时
            //QueryProductWorker.ProgressChanged += QueryProductWorker_ProgressChanged;//改变时
            //QueryProductWorker.RunWorkerCompleted += QueryProductWorker_RunWorkerCompleted;//结束时
           
            //QueryProductWorker.WorkerReportsProgress = true;
            //QueryProductWorker.RunWorkerAsync();

            

        }
        private void InitQuery()
        {

            this.sqlWhere = string.Empty;
            this.sqlWhereDescribe = string.Empty;
            base.LabelCondition.Text = string.Empty;
            GetConditionSql(base .PanelCondition);
            GetConditionDescribe(base.PanelCondition);
            base.LabelCondition.Text = "条件:" + sqlWhereDescribe.TrimStart();
        }

        /// <summary>
        /// 获取用户输入的条件
        /// </summary>
        private void GetConditionSql(Control control)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].HasChildren)
                {
                    GetConditionSql(control.Controls[i]);
                }
                if (control.Controls[i].GetType().Name == "TextBoxControl")
                {
                    sb.Append(((TextBoxControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "NumTextBoxControl")
                {
                    sb.Append(((NumTextBoxControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "DateTimeControl")
                {
                    sb.Append(((DateTimeControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "ComboBoxControl")
                {
                    sb.Append(((ComboBoxControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
            }
            sqlWhere += sb.ToString();
        }

        private void GetConditionDescribe(Control control)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].HasChildren)
                {
                    GetConditionDescribe(control.Controls[i]);
                }
                if (control.Controls[i].GetType().Name == "TextBoxControl")
                {
                    sb.Append(((TextBoxControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "NumTextBoxControl")
                {
                    sb.Append(((NumTextBoxControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "DateTimeControl")
                {
                    sb.Append(((DateTimeControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "ComboBoxControl")
                {
                    sb.Append(((ComboBoxControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
            }
            this.sqlWhereDescribe += sb.ToString();
        }

        #endregion

        #region 无库存背景色
        /// <summary>
        /// 无库存背景色
        /// </summary>
        public void ChangeGridViewStyle()
        {
            DevExpress.XtraGrid.StyleFormatCondition cn;
            cn = new DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Equal, this.winGridView1.GridView1.Columns["Stock_local"], true, 0, true, true);
            cn.Appearance.BackColor = System.Drawing.Color.Red;
            this.winGridView1.GridView1.FormatConditions.Add(cn);
            // this.winGridView1.GridView1.Columns["Selected"].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;

        } 
        #endregion

        #region 选中色
        /// <summary>
        /// 选中色
        /// </summary>
        public void ChangeGridViewStyleToBackColor()
        {
            DevExpress.XtraGrid.StyleFormatCondition cn;
            cn = new DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Greater, this.winGridView1.GridView1.Columns["H_amount"], true, 0, true, true);
            cn.Appearance.BackColor = System.Drawing.Color.Blue; ;
            this.winGridView1.GridView1.FormatConditions.Add(cn);
        } 
        #endregion

        #region  数据库实体转简单实体
        /// <summary>
        /// 数据库实体转简单实体
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public SimpleProductInfo SetSimpleToProductInfo(ProductInfo temp)
        {
            SimpleProductInfo info = new SimpleProductInfo();
            info.H_amount = temp.H_amount;
            info.H_exist = temp.H_exist;
            info.H_factory = temp.H_factory;
            info.H_id = temp.H_id;
            info.H_input_date = temp.H_input_date;
            info.H_isbn = temp.H_isbn;
            info.H_mytm = temp.H_mytm;
            info.H_name = temp.H_name;
            info.H_output_price = temp.H_output_price;
            info.H_type = temp.H_type;
            info.H_writer = temp.H_writer;
            info.My_help_input = temp.My_help_input;
            info.Pub_id = temp.Pub_id;
            return info;
        } 
        #endregion

        #region 确定
        private void btn_ok_Click(object sender, EventArgs e)
        {

            selectlist.Clear();
            if (Querylist != null)
            {
                var ss = from item in Querylist
                         where item.H_amount > 0
                         select item;
                foreach (var item in ss)
                {
                    SimpleProductInfo info = SetSimpleToProductInfo(item);
                    selectlist.Add(info);
                }
            }
            this.Close();

        } 
        #endregion

        #region 线程工作中,改变时,完在后

        void QueryProductWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            splashScreenManager1.CloseWaitForm();
            winGridView1.GridView1.RefreshData();
        }

        void QueryProductWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        void QueryProductWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.splashScreenManager1.ShowWaitForm();
            this.splashScreenManager1.SetWaitFormCaption("请稍候...");
            this.splashScreenManager1.SetWaitFormDescription("正在查询...");
            
            DisplayData();
        } 
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InitQuery();
           
        
            QueryProductWorker = new BackgroundWorker();//实例化后台线程
            QueryProductWorker.DoWork += QueryProductWorker_DoWork;//工作时
            QueryProductWorker.ProgressChanged += QueryProductWorker_ProgressChanged;//改变时
            QueryProductWorker.RunWorkerCompleted += QueryProductWorker_RunWorkerCompleted;//结束时
            
            QueryProductWorker.WorkerReportsProgress = true;
            QueryProductWorker.RunWorkerAsync();

        }

      
    }
}
