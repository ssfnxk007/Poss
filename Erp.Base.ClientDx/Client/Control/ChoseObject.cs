using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Erp.Base.Entity;
using WHC.Pager.WinControl;
using WHC.Dictionary;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using WHC.Security;

using Erp.Base.Facade;
using System.Data;

namespace Erp.Base.UI
{
    public class ChoseObject<T> : BaseDockQuery
        where T : new()
    {
        #region 界面布局
        private ClientsInfo selectedObject = new ClientsInfo();
        private FactoryInfo selectedFactory = new FactoryInfo();
        private DataTable objectdt = new DataTable();
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private TextBoxControl txt_help_input;
        private IContainer components;
        private TextBoxControl txt_contrat_man;
        private TextBoxControl txt_object_department;
        private TextBoxControl txt_object_id;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private ComboBoxControl txt_object_c_id;
        private TextBoxControl txt_object_address;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private ComboBoxControl txt_object_level;
        private ComboBoxControl txt_object_station;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private WinGridView winGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_condition;
        private string selecedId = string.Empty;

        public string SelecedId
        {
            get { return selecedId; }
            set { selecedId = value; }
        }
        #endregion
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataTable Objectdt
        {
            get { return objectdt; }
            set { objectdt = value; }
        }
       
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ClientsInfo SelectedObject
        {
            get { return selectedObject; }
            set { selectedObject = value; }
        }
        public FactoryInfo SelectedFactory
        {
            get { return selectedFactory; }
            set { selectedFactory = value; }
        }
        public ChoseObject()
        {
            InitializeComponent();
            InitDictItem();
            this.winGridView1.gridView1.DoubleClick += winGridView1_DoubleClick;
        }

        void winGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.btn_ok_Click(sender, e);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_condition = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_object_level = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_object_station = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_object_c_id = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_object_address = new WHC.Framework.Commons.TextBoxControl();
            this.txt_help_input = new WHC.Framework.Commons.TextBoxControl();
            this.txt_contrat_man = new WHC.Framework.Commons.TextBoxControl();
            this.txt_object_department = new WHC.Framework.Commons.TextBoxControl();
            this.txt_object_id = new WHC.Framework.Commons.TextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_level.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_station.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_c_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_help_input.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contrat_man.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.btn_ok);
            this.PanelButton.Controls.Add(this.btn_condition);
            this.PanelButton.Location = new System.Drawing.Point(681, 0);
            this.PanelButton.Size = new System.Drawing.Size(269, 100);
            this.PanelButton.Controls.SetChildIndex(this.btnQuery, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnReset, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnPrint, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnExport, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnAdd, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnExit, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_condition, 0);
            this.PanelButton.Controls.SetChildIndex(this.btn_ok, 0);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(676, 0);
            // 
            // PanelCondition
            // 
            this.PanelCondition.Controls.Add(this.layoutControl1);
            this.PanelCondition.Size = new System.Drawing.Size(676, 100);
            // 
            // PanelDisplayCondition
            // 
            this.PanelDisplayCondition.Size = new System.Drawing.Size(950, 40);
            // 
            // btnExit
            // 
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(178, -25);
            this.btnExit.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(178, -25);
            this.btnAdd.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(178, -25);
            this.btnExport.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(178, -25);
            this.btnPrint.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(22, 54);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(22, 25);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            this.panelControl1.Size = new System.Drawing.Size(950, 352);
            // 
            // LabelCondition
            // 
            this.LabelCondition.Size = new System.Drawing.Size(946, 36);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(950, 502);
            // 
            // btn_condition
            // 
            this.btn_condition.Location = new System.Drawing.Point(121, 25);
            this.btn_condition.Name = "btn_condition";
            this.btn_condition.Size = new System.Drawing.Size(75, 23);
            this.btn_condition.TabIndex = 1;
            this.btn_condition.Text = "条件(&C)";
            this.btn_condition.Click += new System.EventHandler(this.btn_condition_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(121, 54);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "确定(&O)";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.txt_object_level);
            this.layoutControl1.Controls.Add(this.txt_object_station);
            this.layoutControl1.Controls.Add(this.txt_object_c_id);
            this.layoutControl1.Controls.Add(this.txt_object_address);
            this.layoutControl1.Controls.Add(this.txt_help_input);
            this.layoutControl1.Controls.Add(this.txt_contrat_man);
            this.layoutControl1.Controls.Add(this.txt_object_department);
            this.layoutControl1.Controls.Add(this.txt_object_id);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(676, 100);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_object_level
            // 
            this.txt_object_level.ChineseColumnName = "是否有效";
            this.txt_object_level.ColumnName = "";
            this.txt_object_level.Location = new System.Drawing.Point(663, 36);
            this.txt_object_level.Name = "txt_object_level";
            this.txt_object_level.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_object_level.Properties.NullValuePrompt = "请选择...";
            this.txt_object_level.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_object_level.Size = new System.Drawing.Size(145, 20);
            this.txt_object_level.StyleController = this.layoutControl1;
            this.txt_object_level.TabIndex = 11;
            // 
            // txt_object_station
            // 
            this.txt_object_station.ChineseColumnName = "所属站点";
            this.txt_object_station.ColumnName = "";
            this.txt_object_station.Location = new System.Drawing.Point(463, 36);
            this.txt_object_station.Name = "txt_object_station";
            this.txt_object_station.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_object_station.Properties.NullValuePrompt = "请选择...";
            this.txt_object_station.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_object_station.Size = new System.Drawing.Size(145, 20);
            this.txt_object_station.StyleController = this.layoutControl1;
            this.txt_object_station.TabIndex = 10;
            // 
            // txt_object_c_id
            // 
            this.txt_object_c_id.ChineseColumnName = "类别";
            this.txt_object_c_id.ColumnName = "";
            this.txt_object_c_id.Location = new System.Drawing.Point(263, 36);
            this.txt_object_c_id.Name = "txt_object_c_id";
            this.txt_object_c_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_object_c_id.Properties.NullValuePrompt = "请选择...";
            this.txt_object_c_id.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_object_c_id.Size = new System.Drawing.Size(145, 20);
            this.txt_object_c_id.StyleController = this.layoutControl1;
            this.txt_object_c_id.TabIndex = 9;
            // 
            // txt_object_address
            // 
            this.txt_object_address.ChineseColumnName = "地址";
            this.txt_object_address.ColumnName = "";
            this.txt_object_address.Location = new System.Drawing.Point(63, 36);
            this.txt_object_address.Name = "txt_object_address";
            this.txt_object_address.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_object_address.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_object_address.Size = new System.Drawing.Size(145, 20);
            this.txt_object_address.StyleController = this.layoutControl1;
            this.txt_object_address.TabIndex = 8;
            this.txt_object_address.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_help_input
            // 
            this.txt_help_input.ChineseColumnName = "助记码";
            this.txt_help_input.ColumnName = "";
            this.txt_help_input.Location = new System.Drawing.Point(63, 12);
            this.txt_help_input.Name = "txt_help_input";
            this.txt_help_input.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_help_input.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_help_input.Size = new System.Drawing.Size(145, 20);
            this.txt_help_input.StyleController = this.layoutControl1;
            this.txt_help_input.TabIndex = 7;
            this.txt_help_input.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_contrat_man
            // 
            this.txt_contrat_man.ChineseColumnName = "联系人";
            this.txt_contrat_man.ColumnName = "";
            this.txt_contrat_man.Location = new System.Drawing.Point(663, 12);
            this.txt_contrat_man.Name = "txt_contrat_man";
            this.txt_contrat_man.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_contrat_man.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_contrat_man.Size = new System.Drawing.Size(145, 20);
            this.txt_contrat_man.StyleController = this.layoutControl1;
            this.txt_contrat_man.TabIndex = 6;
            this.txt_contrat_man.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_object_department
            // 
            this.txt_object_department.ChineseColumnName = "名称";
            this.txt_object_department.ColumnName = "";
            this.txt_object_department.Location = new System.Drawing.Point(463, 12);
            this.txt_object_department.Name = "txt_object_department";
            this.txt_object_department.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_object_department.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_object_department.Size = new System.Drawing.Size(145, 20);
            this.txt_object_department.StyleController = this.layoutControl1;
            this.txt_object_department.TabIndex = 5;
            this.txt_object_department.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_object_id
            // 
            this.txt_object_id.ChineseColumnName = "编码";
            this.txt_object_id.ColumnName = "";
            this.txt_object_id.Location = new System.Drawing.Point(263, 12);
            this.txt_object_id.Name = "txt_object_id";
            this.txt_object_id.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_object_id.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_object_id.Size = new System.Drawing.Size(145, 20);
            this.txt_object_id.StyleController = this.layoutControl1;
            this.txt_object_id.TabIndex = 4;
            this.txt_object_id.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(820, 83);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_object_department;
            this.layoutControlItem2.CustomizationFormText = "客户名称";
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_contrat_man;
            this.layoutControlItem3.CustomizationFormText = "联系人";
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(600, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "联系人";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_help_input;
            this.layoutControlItem4.CustomizationFormText = "助记码";
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "助记码";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_object_id;
            this.layoutControlItem1.CustomizationFormText = "客户编码";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "编码";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_object_address;
            this.layoutControlItem5.CustomizationFormText = "客户地址";
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "地址";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txt_object_station;
            this.layoutControlItem7.CustomizationFormText = "所属站点";
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(400, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "所属站点";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txt_object_c_id;
            this.layoutControlItem6.CustomizationFormText = "客户类别";
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "类别";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txt_object_level;
            this.layoutControlItem8.CustomizationFormText = "是否有效";
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Location = new System.Drawing.Point(600, 24);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "是否有效";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.Location = new System.Drawing.Point(0, 0);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(950, 352);
            this.winGridView1.TabIndex = 0;
            
            // 
            // ChoseObject
            // 
            this.ClientSize = new System.Drawing.Size(950, 502);
            this.Name = "ChoseObject";
            this.Text = "选择对象筛选";
            this.Load += new System.EventHandler(this.ChoseObject_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_level.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_station.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_c_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_help_input.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contrat_man.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_object_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }




        public override void BindData()
        {
            
            if (typeof(T) == typeof(ClientsInfo))
            {
                this.InitDict();
                Cursor = Cursors.WaitCursor;
                this.winGridView1.DataSource = CallerFactory<IClientsService>.Instance.SearchClient(this.SqlWhere);
                Cursor = Cursors.Default;
            }
            else if (typeof(T) == typeof(FactoryInfo)) 
            {
                this.InitDict();
                Cursor = Cursors.WaitCursor;
                this.winGridView1.DataSource = CallerFactory<IFactoryService>.Instance.SearchFactory(this.SqlWhere);
                Cursor = Cursors.Default;
            }
        }

        private void InitDict()
        {
            try
            {
                this.winGridView1.ColumnNameAlias.Add("OBJECT_ID", "编号");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_DEPARTMENT", "名称");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_C_NAME", "类别");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_O_NAME", "主管业务");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_JB_NAME", "级别");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_STATION_NAME", "所属站点");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_HELP_INPUT", "助记码");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_LEVEL", "是否有效");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_SELECT", "选择");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_ADRESS", "地址");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_CONTACT_MAN", "联系人");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_ZIP", "邮编");
                this.winGridView1.BestFitColumnWith = false;
                this.winGridView1.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Pink;
                this.winGridView1.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                this.winGridView1.GridView1.OptionsSelection.MultiSelect = true;
                winGridView1.GridView1.OptionsBehavior.Editable = false;
                winGridView1.GridView1.OptionsBehavior.ReadOnly = false;
                winGridView1.GridView1.OptionsSelection.MultiSelect = false;

            }
            catch (Exception ex)
            {
                LogTextHelper.Error(ex);
                
            }

        }

        /// <summary>
        /// 初始化数据字典
        /// </summary>
        private void InitDictItem()
        {
          
            
        }
        /// <summary>
        /// 设置列名
        /// </summary>
        /// <param name="object_id">编码列名</param>
        /// <param name="object_c_id">类别列名</param>
        /// <param name="object_address">地址列名</param>
        /// <param name="object_department">名称列名</param>
        /// <param name="object_level">是否有效列名</param>
        /// <param name="help_input">助记码列名</param>
        /// <param name="object_station">站点列名</param>
        /// <param name="contrat_man">联系人列名</param>
        private void SetColumnName(string object_id, string object_c_id, string object_address, string object_department, string object_level, string help_input, string object_station, string contrat_man) 
        {
            this.txt_help_input.ColumnName = help_input;
            this.txt_object_address.ColumnName = object_address;
            this.txt_object_c_id.ColumnName = object_c_id;
            this.txt_object_department.ColumnName = object_department;
            this.txt_object_id.ColumnName = object_id;
            this.txt_object_level.ColumnName = object_level;
            this.txt_object_station.ColumnName = object_station;
            this.txt_contrat_man.ColumnName = contrat_man;

        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
       
        }

        private void ChoseObject_Load(object sender, EventArgs e)
        {

            if (typeof(T) == typeof(ClientsInfo))
            {
                this.SetColumnName("DB_CLIENTS.C_ID", "DB_CLIENTS.CC_ID", "DB_CLIENTS.C_ADDRESS", "DB_CLIENTS.C_DEPARTMENT", "DB_CLIENTS.C_LEVEL", "DB_CLIENTS.C_HELP_INPUT", "DB_CLIENTS.STATION_ID", " DB_CLIENTS.C_CONTACT_MAN");
                this.txt_object_c_id.Properties.DisplayMember = "显示值";
                this.txt_object_c_id.Properties.ValueMember = "项目值";
                this.txt_object_c_id.Properties.DataSource = DictItemUtil.Cc_idByEditor();
            }
            else if (typeof(T) == typeof(FactoryInfo)) 
            {
                this.SetColumnName("f_id", "fc_id", "f_address", "f_department", "f_level", "f_help_input", "station_id", "f_contact_man");
                this.txt_object_c_id.Properties.DisplayMember = "显示值";
                this.txt_object_c_id.Properties.ValueMember = "项目值";
                this.txt_object_c_id.Properties.DataSource = DictItemUtil.Fc_idByEditor();
            }

            this.txt_object_level.Properties.DisplayMember = "显示值";
            this.txt_object_level.Properties.ValueMember = "项目值";
            this.txt_object_level.Properties.DataSource = DictItemUtil.YesOrNoByEditor();

            this.txt_object_station.Properties.DisplayMember = "站点名称";
            this.txt_object_station.Properties.ValueMember = "站点编码";
            this.txt_object_station.Properties.DataSource = SecurityUtil.GetAllStationForDropDown();
  
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
           
                if (this.winGridView1.gridView1.RowCount > 0)
                {
                    selecedId = this.winGridView1.gridView1.GetFocusedRowCellValue("OBJECT_ID").ToString();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
    
        }

        private void btn_condition_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.SqlWhere);
        }

     

      
    }
}
