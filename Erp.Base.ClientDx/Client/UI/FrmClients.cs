using System;
using System.Windows.Forms;
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
    public class FrmClients : BaseDockQuery
    {
        #region 界面布局
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private TextBoxControl textBoxControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private TextBoxControl textBoxControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private TextBoxControl textBoxControl4;
        private TextBoxControl txt_adress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private TextBoxControl textBoxControl5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private WinGridView winGridView1;
        private ComboBoxControl txt_station_id;
        private ComboBoxControl txt_hy_id;
        private ComboBoxControl txt_province;
        private ComboBoxControl txt_o_id;
        private ComboBoxControl txtcc_id;
        private ComboBoxControl txt_cm_id;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private ComboBoxControl txtC_level;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;

        List<ClientsInfo> infoList = new List<ClientsInfo>();
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClients));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtC_level = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_station_id = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_hy_id = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_province = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_o_id = new WHC.Framework.Commons.ComboBoxControl();
            this.txtcc_id = new WHC.Framework.Commons.ComboBoxControl();
            this.txt_cm_id = new WHC.Framework.Commons.ComboBoxControl();
            this.textBoxControl5 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl4 = new WHC.Framework.Commons.TextBoxControl();
            this.txt_adress = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl2 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl1 = new WHC.Framework.Commons.TextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtC_level.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_station_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hy_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_province.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_o_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcc_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cm_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Location = new System.Drawing.Point(721, 0);
            this.PanelButton.Size = new System.Drawing.Size(286, 112);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(716, 0);
            this.splitterControl1.Size = new System.Drawing.Size(5, 112);
            // 
            // PanelCondition
            // 
            this.PanelCondition.Controls.Add(this.layoutControl1);
            this.PanelCondition.Size = new System.Drawing.Size(716, 112);
            // 
            // PanelDisplayCondition
            // 
            this.PanelDisplayCondition.Size = new System.Drawing.Size(1007, 40);
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            this.panelControl1.Size = new System.Drawing.Size(1007, 319);
            // 
            // LabelCondition
            // 
            this.LabelCondition.Size = new System.Drawing.Size(1003, 36);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(1007, 481);
            this.splitContainerControl1.SplitterPosition = 112;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtC_level);
            this.layoutControl1.Controls.Add(this.txt_station_id);
            this.layoutControl1.Controls.Add(this.txt_hy_id);
            this.layoutControl1.Controls.Add(this.txt_province);
            this.layoutControl1.Controls.Add(this.txt_o_id);
            this.layoutControl1.Controls.Add(this.txtcc_id);
            this.layoutControl1.Controls.Add(this.txt_cm_id);
            this.layoutControl1.Controls.Add(this.textBoxControl5);
            this.layoutControl1.Controls.Add(this.textBoxControl4);
            this.layoutControl1.Controls.Add(this.txt_adress);
            this.layoutControl1.Controls.Add(this.textBoxControl2);
            this.layoutControl1.Controls.Add(this.textBoxControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(716, 112);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtC_level
            // 
            this.txtC_level.ChineseColumnName = "客户状态";
            this.txtC_level.ColumnName = "c_level";
            this.txtC_level.EditValue = "";
            this.txtC_level.Location = new System.Drawing.Point(615, 60);
            this.txtC_level.Name = "txtC_level";
            this.txtC_level.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtC_level.Size = new System.Drawing.Size(89, 20);
            this.txtC_level.StyleController = this.layoutControl1;
            this.txtC_level.TabIndex = 1;
            // 
            // txt_station_id
            // 
            this.txt_station_id.ChineseColumnName = "所属站点";
            this.txt_station_id.ColumnName = "station_id";
            this.txt_station_id.EditValue = "";
            this.txt_station_id.Location = new System.Drawing.Point(453, 36);
            this.txt_station_id.Name = "txt_station_id";
            this.txt_station_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_station_id.Size = new System.Drawing.Size(91, 20);
            this.txt_station_id.StyleController = this.layoutControl1;
            this.txt_station_id.TabIndex = 1;
            // 
            // txt_hy_id
            // 
            this.txt_hy_id.ChineseColumnName = "行业分类";
            this.txt_hy_id.ColumnName = "c_hy_id";
            this.txt_hy_id.EditValue = "";
            this.txt_hy_id.Location = new System.Drawing.Point(292, 60);
            this.txt_hy_id.Name = "txt_hy_id";
            this.txt_hy_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_hy_id.Size = new System.Drawing.Size(90, 20);
            this.txt_hy_id.StyleController = this.layoutControl1;
            this.txt_hy_id.TabIndex = 2;
            // 
            // txt_province
            // 
            this.txt_province.ChineseColumnName = "所在省";
            this.txt_province.ColumnName = "p_id";
            this.txt_province.EditValue = "";
            this.txt_province.Location = new System.Drawing.Point(453, 60);
            this.txt_province.Name = "txt_province";
            this.txt_province.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_province.Size = new System.Drawing.Size(91, 20);
            this.txt_province.StyleController = this.layoutControl1;
            this.txt_province.TabIndex = 1;
            // 
            // txt_o_id
            // 
            this.txt_o_id.ChineseColumnName = "主管业务";
            this.txt_o_id.ColumnName = "o_id";
            this.txt_o_id.EditValue = "";
            this.txt_o_id.Location = new System.Drawing.Point(292, 36);
            this.txt_o_id.Name = "txt_o_id";
            this.txt_o_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_o_id.Size = new System.Drawing.Size(90, 20);
            this.txt_o_id.StyleController = this.layoutControl1;
            this.txt_o_id.TabIndex = 2;
            // 
            // txtcc_id
            // 
            this.txtcc_id.ChineseColumnName = "客户类别";
            this.txtcc_id.ColumnName = "cc_id";
            this.txtcc_id.EditValue = "";
            this.txtcc_id.Location = new System.Drawing.Point(79, 36);
            this.txtcc_id.Name = "txtcc_id";
            this.txtcc_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtcc_id.Size = new System.Drawing.Size(142, 20);
            this.txtcc_id.StyleController = this.layoutControl1;
            this.txtcc_id.TabIndex = 3;
            // 
            // txt_cm_id
            // 
            this.txt_cm_id.ChineseColumnName = "营销分类";
            this.txt_cm_id.ColumnName = "cm_id";
            this.txt_cm_id.EditValue = "";
            this.txt_cm_id.Location = new System.Drawing.Point(79, 60);
            this.txt_cm_id.Name = "txt_cm_id";
            this.txt_cm_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_cm_id.Size = new System.Drawing.Size(142, 20);
            this.txt_cm_id.StyleController = this.layoutControl1;
            this.txt_cm_id.TabIndex = 4;
            // 
            // textBoxControl5
            // 
            this.textBoxControl5.ChineseColumnName = "客户编号";
            this.textBoxControl5.ColumnName = "db_clients.c_id";
            this.textBoxControl5.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl5.Location = new System.Drawing.Point(453, 12);
            this.textBoxControl5.Name = "textBoxControl5";
            this.textBoxControl5.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl5.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl5.Size = new System.Drawing.Size(91, 20);
            this.textBoxControl5.StyleController = this.layoutControl1;
            this.textBoxControl5.TabIndex = 6;
            this.textBoxControl5.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl4
            // 
            this.textBoxControl4.ChineseColumnName = "备注";
            this.textBoxControl4.ColumnName = "db_clients.c_mem";
            this.textBoxControl4.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl4.Location = new System.Drawing.Point(615, 12);
            this.textBoxControl4.Name = "textBoxControl4";
            this.textBoxControl4.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl4.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl4.Size = new System.Drawing.Size(89, 20);
            this.textBoxControl4.StyleController = this.layoutControl1;
            this.textBoxControl4.TabIndex = 1;
            this.textBoxControl4.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txt_adress
            // 
            this.txt_adress.ChineseColumnName = "客户地址";
            this.txt_adress.ColumnName = "db_clients.c_address";
            this.txt_adress.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.txt_adress.Location = new System.Drawing.Point(615, 36);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_adress.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_adress.Size = new System.Drawing.Size(89, 20);
            this.txt_adress.StyleController = this.layoutControl1;
            this.txt_adress.TabIndex = 4;
            this.txt_adress.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl2
            // 
            this.textBoxControl2.ChineseColumnName = "客户名称";
            this.textBoxControl2.ColumnName = "db_clients.c_department";
            this.textBoxControl2.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl2.Location = new System.Drawing.Point(292, 12);
            this.textBoxControl2.Name = "textBoxControl2";
            this.textBoxControl2.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl2.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl2.Size = new System.Drawing.Size(90, 20);
            this.textBoxControl2.StyleController = this.layoutControl1;
            this.textBoxControl2.TabIndex = 1;
            this.textBoxControl2.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl1
            // 
            this.textBoxControl1.ChineseColumnName = "客户谐音";
            this.textBoxControl1.ColumnName = "db_clients.c_help_input";
            this.textBoxControl1.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl1.Location = new System.Drawing.Point(79, 12);
            this.textBoxControl1.Name = "textBoxControl1";
            this.textBoxControl1.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl1.Size = new System.Drawing.Size(142, 20);
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
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem5,
            this.layoutControlItem11,
            this.layoutControlItem9,
            this.layoutControlItem12,
            this.layoutControlItem4,
            this.layoutControlItem10});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(716, 112);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBoxControl1;
            this.layoutControlItem1.CustomizationFormText = "谐音：";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(260, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(160, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(213, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "谐音：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBoxControl2;
            this.layoutControlItem3.CustomizationFormText = "客户名称:";
            this.layoutControlItem3.Location = new System.Drawing.Point(213, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(161, 24);
            this.layoutControlItem3.Text = "客户名称:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textBoxControl4;
            this.layoutControlItem6.CustomizationFormText = "备注：";
            this.layoutControlItem6.Location = new System.Drawing.Point(536, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem6.Text = "备注：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxControl5;
            this.layoutControlItem2.CustomizationFormText = "客户编号：";
            this.layoutControlItem2.Location = new System.Drawing.Point(374, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(162, 24);
            this.layoutControlItem2.Text = "客户编号：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtcc_id;
            this.layoutControlItem7.CustomizationFormText = "客户类别";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(213, 24);
            this.layoutControlItem7.Text = "客户类别";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txt_o_id;
            this.layoutControlItem8.CustomizationFormText = "主管业务";
            this.layoutControlItem8.Location = new System.Drawing.Point(213, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(161, 24);
            this.layoutControlItem8.Text = "主管业务";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_cm_id;
            this.layoutControlItem5.CustomizationFormText = "营销分类";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(213, 44);
            this.layoutControlItem5.Text = "营销分类";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txt_hy_id;
            this.layoutControlItem11.CustomizationFormText = "行业分类";
            this.layoutControlItem11.Location = new System.Drawing.Point(213, 48);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(161, 44);
            this.layoutControlItem11.Text = "行业分类";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txt_province;
            this.layoutControlItem9.CustomizationFormText = "所在省";
            this.layoutControlItem9.Location = new System.Drawing.Point(374, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(162, 44);
            this.layoutControlItem9.Text = "所在省";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txt_station_id;
            this.layoutControlItem12.CustomizationFormText = "所属站点";
            this.layoutControlItem12.Location = new System.Drawing.Point(374, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(162, 24);
            this.layoutControlItem12.Text = "所属站点";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_adress;
            this.layoutControlItem4.CustomizationFormText = "客户地址： ";
            this.layoutControlItem4.Location = new System.Drawing.Point(536, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem4.Text = "客户地址： ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtC_level;
            this.layoutControlItem10.CustomizationFormText = "客户状态";
            this.layoutControlItem10.Location = new System.Drawing.Point(536, 48);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(160, 44);
            this.layoutControlItem10.Text = "客户状态";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(64, 14);
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.ColumnNameAlias = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("winGridView1.ColumnNameAlias")));
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
            this.winGridView1.Size = new System.Drawing.Size(1007, 319);
            this.winGridView1.TabIndex = 0;
            // 
            // FrmClients
            // 
            this.ClientSize = new System.Drawing.Size(1007, 481);
            this.Name = "FrmClients";
            this.Text = "客户信息";
            this.Load += new System.EventHandler(this.FrmClients_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtC_level.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_station_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hy_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_province.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_o_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcc_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cm_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region 构造方法
        public FrmClients()
        {
            InitializeComponent();
            this.winGridView1.BestFitColumnWith = false;
        }
        #endregion

        #region InitDict
        private void InitDict()
        {
            try
            {
                this.winGridView1.gridView1.Columns["C_jb"].ColumnEdit = DictItemUtil.C_jbByGrid();
                this.winGridView1.gridView1.Columns["A_id"].ColumnEdit = DictItemUtil.A_idByGrid();
                this.winGridView1.gridView1.Columns["P_id"].ColumnEdit = DictItemUtil.P_idByGrid();
                this.winGridView1.gridView1.Columns["City_id"].ColumnEdit = DictItemUtil.City_idByGrid();
                this.winGridView1.gridView1.Columns["C_level"].ColumnEdit = DictItemUtil.ClientC_LevelByGrid();
                this.winGridView1.gridView1.Columns["Cc_id"].ColumnEdit = DictItemUtil.Cc_idByGrid();
                this.winGridView1.gridView1.Columns["I_class_id"].ColumnEdit = DictItemUtil.I_class_idByGrid();
                this.winGridView1.gridView1.Columns["Station_id_xs"].ColumnEdit = SecurityUtil.AllStationTreeListByGrid();
                this.winGridView1.gridView1.Columns["Station_id"].ColumnEdit = SecurityUtil.AllStationTreeListByGrid();
                this.winGridView1.gridView1.Columns["Station_account"].ColumnEdit = SecurityUtil.AllStationTreeListByGrid();
                this.winGridView1.gridView1.Columns["C_source"].ColumnEdit = DictItemUtil.C_sourceByGrid();
                this.winGridView1.gridView1.Columns["Cm_id"].ColumnEdit = DictItemUtil.Cm_idByGrid();
                this.winGridView1.gridView1.Columns["C_hy_id"].ColumnEdit = DictItemUtil.Hy_idByGrid();
                this.winGridView1.gridView1.Columns["O_id"].ColumnEdit = SecurityUtil.O_idByGrid();
                this.winGridView1.gridView1.Columns["Clients_credit"].ColumnEdit = DictItemUtil.Clients_CreditByGrid();
                this.winGridView1.gridView1.Columns["Account_credit"].ColumnEdit = DictItemUtil.Clients_CreditByGrid();
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

        #region BindData
        public override void BindData()
        {
            Cursor = Cursors.WaitCursor;
            this.infoList.Clear();
            this.infoList.AddRange(CallerFactory<IClientsService>.Instance.Find(this.SqlWhere));
            this.winGridView1.GridView1.RefreshData();

            Cursor = Cursors.Default;
        }
        #endregion

        //#region GetDisplayColumn
        //private string GetDisplayColumn(Dictionary<string, string> alias)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (string s in alias.Keys)
        //    {
        //        sb.AppendFormat("{0}|", s);
        //    }

        //    return sb.ToString();
        //} 
        //#endregion

        #region Loading
        private void FrmClients_Load(object sender, EventArgs e)
        {
            InitCondtionDict();
            this.winGridView1.OnAddNew += new EventHandler(winGridView1_OnAddNew);
            this.winGridView1.OnEditSelected += new EventHandler(winGridView1_OnEditSelected);
            this.PKey = "c_id";
            this.btnAdd.Enabled = Portal.gc.HasFunction("ClientInfo/Add");
            this.winGridView1.ColumnNameAlias = CallerFactory<IClientsService>.Instance.GetColumnNameAlias();
            this.winGridView1.DisplayColumns = this.winGridView1.ColumnNameAlias.GetDisplayByAlias();
            this.winGridView1.DataSource = infoList;
        }

        #endregion

        #region 条件区域数据绑定
        private void InitCondtionDict()
        {
            this.txt_cm_id.Properties.DisplayMember = "显示值";
            this.txt_cm_id.Properties.ValueMember = "项目值";
            this.txt_cm_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cm_idByEditor();

            this.txt_station_id.Properties.DisplayMember = "父站点";
            this.txt_station_id.Properties.DisplayMember = "站点名称";
            this.txt_station_id.Properties.ValueMember = "站点编码";
            this.txt_station_id.Properties.DataSource = SecurityUtil.GetAllStationForDropDown();

            this.txt_o_id.Properties.DisplayMember = "显示值";
            this.txt_o_id.Properties.ValueMember = "项目值";
            this.txt_o_id.Properties.DataSource = SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txt_hy_id.Properties.DisplayMember = "显示值";
            this.txt_hy_id.Properties.ValueMember = "项目值";
            this.txt_hy_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Hy_idByEditor();

            this.txt_province.Properties.DisplayMember = "地区名称";
            this.txt_province.Properties.DisplayMember = "省份名称";
            this.txt_province.Properties.ValueMember = "省份编码";
            this.txt_province.Properties.DataSource = WHC.Dictionary.DictItemUtil.ProvinceByEditor();

            this.txtC_level.Properties.DisplayMember = "显示值";
            this.txtC_level.Properties.ValueMember = "项目值";
            this.txtC_level.Properties.DataSource = WHC.Dictionary.DictItemUtil.ClientC_LevelbyEditor();

            this.txtcc_id.Properties.DisplayMember = "显示值";
            this.txtcc_id.Properties.ValueMember = "项目值";
            this.txtcc_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cc_idByEditor();

        }
        #endregion

        #region 编辑事件
        private void winGridView1_OnEditSelected(object sender, EventArgs e)
        {
            if (!Portal.gc.HasFunction("ClientInfo/Edit"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("ClientInfo/Edit", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}权限", value));
                return;
            }
            FrmEditClients dlg = new FrmEditClients();
            dlg.Text = "客户信息";
            dlg.MasterView = this.winGridView1.GridView1;
            dlg.rowIndex = winGridView1.GridView1.FocusedRowHandle;
            dlg.ShowDialog();
        }
        #endregion

        #region 增加事件

        private void winGridView1_OnAddNew(object sender, EventArgs e)
        {
            if (!Portal.gc.HasFunction("ClientInfo/Add"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("ClientInfo/Add", out value);
                MessageDxUtil.ShowWarning("用户没有该权限");
                return;
            }
            FrmEditClients dlg = new FrmEditClients();
            dlg.Text = "客户信息";
            dlg.rowIndex = -1;
            dlg.ShowDialog();
            dlg.Dispose();
        }

        #endregion

        #region 增加按钮事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            winGridView1_OnAddNew(null, null);
        } 
        #endregion

    }
}