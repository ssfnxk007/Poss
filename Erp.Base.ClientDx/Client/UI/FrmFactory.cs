using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using DevExpress.XtraGrid;
using DevExpress.Utils;

using WHC.Pager.Entity;
using WHC.Pager.WinControl;
using WHC.Dictionary;
using WHC.Framework;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using WHC.Framework.ControlUtil.Facade;
using WHC.Security.UI;
using WHC.Security;

using Erp.Base.Facade;
using Erp.Base.Entity;
using Erp.Base.ServiceCaller;
using WHC.Dictionary.UI;
using WHC.Framework.Commons;
using System.Reflection;

namespace Erp.Base.UI
{
   public  class FrmFactory :BaseDockQuery
   {
       #region 变量
       private DevExpress.XtraLayout.LayoutControl layoutControl1;
       private ComboBoxControl txtF_level;
       private ComboBoxControl txt_o_id;
       private ComboBoxControl txt_f_jb;
       private ComboBoxControl txt_charge_man;
       private ComboBoxControl txt_cm_id;
       private TextBoxControl textBoxControl1;
       private TextBoxControl textBoxControl2;
       private TextBoxControl textBoxControl3;
       private TextBoxControl textBoxControl4;
       private TextBoxControl textBoxControl5;
       private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
       private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;

       private WinGridView Wingridview1;
       List<FactoryInfo> infoList = new List<FactoryInfo>();
       #endregion

       #region InitializeComponent
       private void InitializeComponent()
       {
           System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactory));
           this.Wingridview1 = new WHC.Pager.WinControl.WinGridView();
           this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
           this.txtF_level = new WHC.Framework.Commons.ComboBoxControl();
           this.txt_o_id = new WHC.Framework.Commons.ComboBoxControl();
           this.txt_f_jb = new WHC.Framework.Commons.ComboBoxControl();
           this.txt_charge_man = new WHC.Framework.Commons.ComboBoxControl();
           this.txt_cm_id = new WHC.Framework.Commons.ComboBoxControl();
           this.textBoxControl1 = new WHC.Framework.Commons.TextBoxControl();
           this.textBoxControl2 = new WHC.Framework.Commons.TextBoxControl();
           this.textBoxControl3 = new WHC.Framework.Commons.TextBoxControl();
           this.textBoxControl4 = new WHC.Framework.Commons.TextBoxControl();
           this.textBoxControl5 = new WHC.Framework.Commons.TextBoxControl();
           this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
           this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
           this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
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
           ((System.ComponentModel.ISupportInitialize)(this.txtF_level.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.txt_o_id.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.txt_f_jb.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.txt_charge_man.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.txt_cm_id.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl1.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl2.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl3.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl4.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl5.Properties)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
           this.SuspendLayout();
           // 
           // PanelButton
           // 
           this.PanelButton.Location = new System.Drawing.Point(596, 0);
           this.PanelButton.Size = new System.Drawing.Size(232, 100);
           // 
           // splitterControl1
           // 
           this.splitterControl1.Location = new System.Drawing.Point(591, 0);
           // 
           // PanelCondition
           // 
           this.PanelCondition.Controls.Add(this.layoutControl1);
           this.PanelCondition.Size = new System.Drawing.Size(591, 100);
           // 
           // PanelDisplayCondition
           // 
           this.PanelDisplayCondition.Size = new System.Drawing.Size(828, 40);
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
           this.panelControl1.Controls.Add(this.Wingridview1);
           this.panelControl1.Size = new System.Drawing.Size(828, 225);
           // 
           // LabelCondition
           // 
           this.LabelCondition.Size = new System.Drawing.Size(824, 36);
           // 
           // splitContainerControl1
           // 
           this.splitContainerControl1.Size = new System.Drawing.Size(828, 375);
           // 
           // Wingridview1
           // 
           this.Wingridview1.AppendedMenu = null;
           this.Wingridview1.ColumnNameAlias = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("Wingridview1.ColumnNameAlias")));
           this.Wingridview1.DataSource = null;
           this.Wingridview1.DisplayColumns = "";
           this.Wingridview1.Dock = System.Windows.Forms.DockStyle.Fill;
           this.Wingridview1.Location = new System.Drawing.Point(0, 0);
           this.Wingridview1.Name = "Wingridview1";
           this.Wingridview1.PrintTitle = "";
           this.Wingridview1.ShowAddMenu = true;
           this.Wingridview1.ShowCheckBox = false;
           this.Wingridview1.ShowDeleteMenu = true;
           this.Wingridview1.ShowEditMenu = true;
           this.Wingridview1.ShowExportButton = true;
           this.Wingridview1.Size = new System.Drawing.Size(828, 225);
           this.Wingridview1.TabIndex = 0;
           // 
           // layoutControl1
           // 
           this.layoutControl1.Controls.Add(this.txtF_level);
           this.layoutControl1.Controls.Add(this.txt_o_id);
           this.layoutControl1.Controls.Add(this.txt_f_jb);
           this.layoutControl1.Controls.Add(this.txt_charge_man);
           this.layoutControl1.Controls.Add(this.txt_cm_id);
           this.layoutControl1.Controls.Add(this.textBoxControl1);
           this.layoutControl1.Controls.Add(this.textBoxControl2);
           this.layoutControl1.Controls.Add(this.textBoxControl3);
           this.layoutControl1.Controls.Add(this.textBoxControl4);
           this.layoutControl1.Controls.Add(this.textBoxControl5);
           this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
           this.layoutControl1.Location = new System.Drawing.Point(0, 0);
           this.layoutControl1.Name = "layoutControl1";
           this.layoutControl1.Root = this.layoutControlGroup1;
           this.layoutControl1.Size = new System.Drawing.Size(591, 100);
           this.layoutControl1.TabIndex = 0;
           this.layoutControl1.Text = "layoutControl1";
           // 
           // txtF_level
           // 
           this.txtF_level.ChineseColumnName = "状态";
           this.txtF_level.ColumnName = "f_level";
           this.txtF_level.Location = new System.Drawing.Point(520, 36);
           this.txtF_level.Name = "txtF_level";
           this.txtF_level.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
           this.txtF_level.Properties.NullValuePrompt = "请选择...";
           this.txtF_level.Properties.NullValuePromptShowForEmptyValue = true;
           this.txtF_level.Size = new System.Drawing.Size(59, 20);
           this.txtF_level.StyleController = this.layoutControl1;
           this.txtF_level.TabIndex = 1;
           // 
           // txt_o_id
           // 
           this.txt_o_id.ChineseColumnName = "业务员";
           this.txt_o_id.ColumnName = "o_id";
           this.txt_o_id.Location = new System.Drawing.Point(405, 36);
           this.txt_o_id.Name = "txt_o_id";
           this.txt_o_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
           this.txt_o_id.Properties.NullValuePrompt = "请选择...";
           this.txt_o_id.Properties.NullValuePromptShowForEmptyValue = true;
           this.txt_o_id.Size = new System.Drawing.Size(60, 20);
           this.txt_o_id.StyleController = this.layoutControl1;
           this.txt_o_id.TabIndex = 2;
           // 
           // txt_f_jb
           // 
           this.txt_f_jb.ChineseColumnName = "货源级别";
           this.txt_f_jb.ColumnName = "f_jb";
           this.txt_f_jb.Location = new System.Drawing.Point(63, 36);
           this.txt_f_jb.Name = "txt_f_jb";
           this.txt_f_jb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
           this.txt_f_jb.Properties.NullValuePrompt = "请选择...";
           this.txt_f_jb.Properties.NullValuePromptShowForEmptyValue = true;
           this.txt_f_jb.Size = new System.Drawing.Size(59, 20);
           this.txt_f_jb.StyleController = this.layoutControl1;
           this.txt_f_jb.TabIndex = 3;
           // 
           // txt_charge_man
           // 
           this.txt_charge_man.ChineseColumnName = "业务主管";
           this.txt_charge_man.ColumnName = "f_charge_man";
           this.txt_charge_man.Location = new System.Drawing.Point(291, 36);
           this.txt_charge_man.Name = "txt_charge_man";
           this.txt_charge_man.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
           this.txt_charge_man.Properties.NullValuePrompt = "请选择...";
           this.txt_charge_man.Properties.NullValuePromptShowForEmptyValue = true;
           this.txt_charge_man.Size = new System.Drawing.Size(59, 20);
           this.txt_charge_man.StyleController = this.layoutControl1;
           this.txt_charge_man.TabIndex = 4;
           // 
           // txt_cm_id
           // 
           this.txt_cm_id.ChineseColumnName = "营销分类";
           this.txt_cm_id.ColumnName = "cm_id";
           this.txt_cm_id.Location = new System.Drawing.Point(177, 36);
           this.txt_cm_id.Name = "txt_cm_id";
           this.txt_cm_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
           this.txt_cm_id.Properties.NullValuePrompt = "请选择...";
           this.txt_cm_id.Properties.NullValuePromptShowForEmptyValue = true;
           this.txt_cm_id.Size = new System.Drawing.Size(59, 20);
           this.txt_cm_id.StyleController = this.layoutControl1;
           this.txt_cm_id.TabIndex = 5;
           // 
           // textBoxControl1
           // 
           this.textBoxControl1.ChineseColumnName = "货源名称";
           this.textBoxControl1.ColumnName = "f_department";
           this.textBoxControl1.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
           this.textBoxControl1.Location = new System.Drawing.Point(291, 12);
           this.textBoxControl1.Name = "textBoxControl1";
           this.textBoxControl1.Properties.NullValuePrompt = "F4键切换查询模式";
           this.textBoxControl1.Properties.NullValuePromptShowForEmptyValue = true;
           this.textBoxControl1.Size = new System.Drawing.Size(59, 20);
           this.textBoxControl1.StyleController = this.layoutControl1;
           this.textBoxControl1.TabIndex = 1;
           this.textBoxControl1.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
           // 
           // textBoxControl2
           // 
           this.textBoxControl2.ChineseColumnName = "货源地址";
           this.textBoxControl2.ColumnName = "f_address";
           this.textBoxControl2.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
           this.textBoxControl2.Location = new System.Drawing.Point(405, 12);
           this.textBoxControl2.Name = "textBoxControl2";
           this.textBoxControl2.Properties.NullValuePrompt = "F4键切换查询模式";
           this.textBoxControl2.Properties.NullValuePromptShowForEmptyValue = true;
           this.textBoxControl2.Size = new System.Drawing.Size(60, 20);
           this.textBoxControl2.StyleController = this.layoutControl1;
           this.textBoxControl2.TabIndex = 2;
           this.textBoxControl2.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
           // 
           // textBoxControl3
           // 
           this.textBoxControl3.ChineseColumnName = "货源编号";
           this.textBoxControl3.ColumnName = "f_id";
           this.textBoxControl3.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
           this.textBoxControl3.Location = new System.Drawing.Point(177, 12);
           this.textBoxControl3.Name = "textBoxControl3";
           this.textBoxControl3.Properties.NullValuePrompt = "F4键切换查询模式";
           this.textBoxControl3.Properties.NullValuePromptShowForEmptyValue = true;
           this.textBoxControl3.Size = new System.Drawing.Size(59, 20);
           this.textBoxControl3.StyleController = this.layoutControl1;
           this.textBoxControl3.TabIndex = 3;
           this.textBoxControl3.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
           // 
           // textBoxControl4
           // 
           this.textBoxControl4.ChineseColumnName = "联系人";
           this.textBoxControl4.ColumnName = "f_contact_man";
           this.textBoxControl4.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
           this.textBoxControl4.Location = new System.Drawing.Point(520, 12);
           this.textBoxControl4.Name = "textBoxControl4";
           this.textBoxControl4.Properties.NullValuePrompt = "F4键切换查询模式";
           this.textBoxControl4.Properties.NullValuePromptShowForEmptyValue = true;
           this.textBoxControl4.Size = new System.Drawing.Size(59, 20);
           this.textBoxControl4.StyleController = this.layoutControl1;
           this.textBoxControl4.TabIndex = 4;
           this.textBoxControl4.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
           // 
           // textBoxControl5
           // 
           this.textBoxControl5.ChineseColumnName = "谐音";
           this.textBoxControl5.ColumnName = "f_help_input";
           this.textBoxControl5.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
           this.textBoxControl5.Location = new System.Drawing.Point(63, 12);
           this.textBoxControl5.Name = "textBoxControl5";
           this.textBoxControl5.Properties.NullValuePrompt = "F4键切换查询模式";
           this.textBoxControl5.Properties.NullValuePromptShowForEmptyValue = true;
           this.textBoxControl5.Size = new System.Drawing.Size(59, 20);
           this.textBoxControl5.StyleController = this.layoutControl1;
           this.textBoxControl5.TabIndex = 5;
           this.textBoxControl5.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
           // 
           // layoutControlGroup1
           // 
           this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
           this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
           this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
           this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
           this.layoutControlGroup1.Name = "layoutControlGroup1";
           this.layoutControlGroup1.Size = new System.Drawing.Size(591, 100);
           this.layoutControlGroup1.Text = "layoutControlGroup1";
           this.layoutControlGroup1.TextVisible = false;
           // 
           // layoutControlItem1
           // 
           this.layoutControlItem1.Control = this.textBoxControl5;
           this.layoutControlItem1.CustomizationFormText = "谐音";
           this.layoutControlItem1.FillControlToClientArea = false;
           this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
           this.layoutControlItem1.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem1.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem1.Name = "layoutControlItem1";
           this.layoutControlItem1.Size = new System.Drawing.Size(114, 24);
           this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem1.Text = "谐音";
           this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem4
           // 
           this.layoutControlItem4.Control = this.textBoxControl2;
           this.layoutControlItem4.CustomizationFormText = "货源地址";
           this.layoutControlItem4.FillControlToClientArea = false;
           this.layoutControlItem4.Location = new System.Drawing.Point(342, 0);
           this.layoutControlItem4.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem4.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem4.Name = "layoutControlItem4";
           this.layoutControlItem4.Size = new System.Drawing.Size(115, 24);
           this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem4.Text = "货源地址";
           this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem3
           // 
           this.layoutControlItem3.Control = this.textBoxControl3;
           this.layoutControlItem3.CustomizationFormText = "货源编号";
           this.layoutControlItem3.FillControlToClientArea = false;
           this.layoutControlItem3.Location = new System.Drawing.Point(114, 0);
           this.layoutControlItem3.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem3.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem3.Name = "layoutControlItem3";
           this.layoutControlItem3.Size = new System.Drawing.Size(114, 24);
           this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem3.Text = "货源编号";
           this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem5
           // 
           this.layoutControlItem5.Control = this.textBoxControl1;
           this.layoutControlItem5.CustomizationFormText = "货源名称";
           this.layoutControlItem5.FillControlToClientArea = false;
           this.layoutControlItem5.Location = new System.Drawing.Point(228, 0);
           this.layoutControlItem5.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem5.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem5.Name = "layoutControlItem5";
           this.layoutControlItem5.Size = new System.Drawing.Size(114, 24);
           this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem5.Text = "货源名称";
           this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem2
           // 
           this.layoutControlItem2.Control = this.textBoxControl4;
           this.layoutControlItem2.CustomizationFormText = "联系人";
           this.layoutControlItem2.FillControlToClientArea = false;
           this.layoutControlItem2.Location = new System.Drawing.Point(457, 0);
           this.layoutControlItem2.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem2.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem2.Name = "layoutControlItem2";
           this.layoutControlItem2.Size = new System.Drawing.Size(114, 24);
           this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem2.Text = "联系人";
           this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem6
           // 
           this.layoutControlItem6.Control = this.txt_cm_id;
           this.layoutControlItem6.CustomizationFormText = "营销分类";
           this.layoutControlItem6.FillControlToClientArea = false;
           this.layoutControlItem6.Location = new System.Drawing.Point(114, 24);
           this.layoutControlItem6.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem6.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem6.Name = "layoutControlItem6";
           this.layoutControlItem6.Size = new System.Drawing.Size(114, 56);
           this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem6.Text = "营销分类";
           this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem7
           // 
           this.layoutControlItem7.Control = this.txt_charge_man;
           this.layoutControlItem7.CustomizationFormText = "业务主管";
           this.layoutControlItem7.FillControlToClientArea = false;
           this.layoutControlItem7.Location = new System.Drawing.Point(228, 24);
           this.layoutControlItem7.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem7.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem7.Name = "layoutControlItem7";
           this.layoutControlItem7.Size = new System.Drawing.Size(114, 56);
           this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem7.Text = "业务主管";
           this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem8
           // 
           this.layoutControlItem8.Control = this.txt_f_jb;
           this.layoutControlItem8.CustomizationFormText = "货源级别";
           this.layoutControlItem8.FillControlToClientArea = false;
           this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
           this.layoutControlItem8.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem8.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem8.Name = "layoutControlItem8";
           this.layoutControlItem8.Size = new System.Drawing.Size(114, 56);
           this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem8.Text = "货源级别";
           this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem9
           // 
           this.layoutControlItem9.Control = this.txt_o_id;
           this.layoutControlItem9.CustomizationFormText = "业务员";
           this.layoutControlItem9.FillControlToClientArea = false;
           this.layoutControlItem9.Location = new System.Drawing.Point(342, 24);
           this.layoutControlItem9.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem9.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem9.Name = "layoutControlItem9";
           this.layoutControlItem9.Size = new System.Drawing.Size(115, 56);
           this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem9.Text = "业务员";
           this.layoutControlItem9.TextSize = new System.Drawing.Size(48, 14);
           // 
           // layoutControlItem10
           // 
           this.layoutControlItem10.Control = this.txtF_level;
           this.layoutControlItem10.CustomizationFormText = "状态";
           this.layoutControlItem10.FillControlToClientArea = false;
           this.layoutControlItem10.Location = new System.Drawing.Point(457, 24);
           this.layoutControlItem10.MaxSize = new System.Drawing.Size(200, 24);
           this.layoutControlItem10.MinSize = new System.Drawing.Size(100, 24);
           this.layoutControlItem10.Name = "layoutControlItem10";
           this.layoutControlItem10.Size = new System.Drawing.Size(114, 56);
           this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
           this.layoutControlItem10.Text = "状态";
           this.layoutControlItem10.TextSize = new System.Drawing.Size(48, 14);
           // 
           // FrmFactory
           // 
           this.ClientSize = new System.Drawing.Size(828, 375);
           this.Name = "FrmFactory";
           this.Text = "货源信息";
           this.Load += new System.EventHandler(this.FrmFactory_Load);
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
           ((System.ComponentModel.ISupportInitialize)(this.txtF_level.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.txt_o_id.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.txt_f_jb.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.txt_charge_man.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.txt_cm_id.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl1.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl2.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl3.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl4.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.textBoxControl5.Properties)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
           this.ResumeLayout(false);

       } 
       #endregion


        public FrmFactory() 
        {
            InitializeComponent();
            this.Wingridview1.BestFitColumnWith = false;
        }

        public override void BindData()
        {
            Cursor = Cursors.WaitCursor;
           
            this.infoList.Clear();
            this.infoList.AddRange( CallerFactory<IFactoryService>.Instance.Find(SqlWhere));
            this.InitDict();
            Wingridview1.GridView1.RefreshData();
            Cursor = Cursors.Default;
        }
        #region 格式
        private void InitDict()
        {
            try
            {
                this.Wingridview1.gridView1.Columns["F_jb"].ColumnEdit = DictItemUtil.F_jbByGrid();
                this.Wingridview1.gridView1.Columns["P_id"].ColumnEdit = DictItemUtil.PathByGrid();
                this.Wingridview1.gridView1.Columns["F_level"].ColumnEdit = DictItemUtil.ClientC_LevelByGrid();
                this.Wingridview1.gridView1.Columns["Fc_id"].ColumnEdit = DictItemUtil.Fc_idByGrid();
                this.Wingridview1.gridView1.Columns["I_class_id"].ColumnEdit = DictItemUtil.I_class_idByGrid();
                this.Wingridview1.gridView1.Columns["Station_id"].ColumnEdit = SecurityUtil.AllStationTreeListByGrid();
                this.Wingridview1.gridView1.Columns["Station_account"].ColumnEdit = SecurityUtil.AllStationTreeListByGrid();
                this.Wingridview1.gridView1.Columns["Cm_id"].ColumnEdit = DictItemUtil.Cm_idByGrid();
                this.Wingridview1.gridView1.Columns["Hy_id"].ColumnEdit = DictItemUtil.Hy_idByGrid();
                this.Wingridview1.gridView1.Columns["O_id"].ColumnEdit = SecurityUtil.O_idByGrid();
                this.Wingridview1.gridView1.Columns["Clients_credit"].ColumnEdit = DictItemUtil.Clients_CreditByGrid();
                this.Wingridview1.gridView1.Columns["O_id_input"].ColumnEdit = WHC.Security.SecurityUtil.O_idByGrid();
                this.Wingridview1.gridView1.Columns["O_id_lastmodify"].ColumnEdit = WHC.Security.SecurityUtil.O_idByGrid();


            }
            catch (Exception ex)
            {
                LogTextHelper.Error(ex);
                MessageDxUtil.ShowError(ex.Message);
            }


        } 
        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
            this.Wingridview1.AutoSize = false;
        }

        private void FrmFactory_Load(object sender, EventArgs e)
        {
            SelectChose();
         
            this.Wingridview1.OnAddNew += new EventHandler(winGridView1_OnAddNew);
            this.Wingridview1.OnEditSelected += new EventHandler(winGridView1_OnEditSelected);     
            this.PKey = "f_id";
            this.btnAdd.Enabled = Portal.gc.HasFunction("FactoryInfo/Add");
            this.Wingridview1.ColumnNameAlias = CallerFactory<IFactoryService>.Instance.GetColumnNameAlias();
            this.Wingridview1.DisplayColumns = this.Wingridview1.ColumnNameAlias.GetDisplayByAlias();
            this.Wingridview1.DataSource = infoList;
            
           
        }


        private void winGridView1_OnEditSelected(object sender, EventArgs e)
        {
           // EditItem();
    
                FrmEditFactory spi = new FrmEditFactory();
                spi.MasterView = this.Wingridview1.GridView1;
                spi.rowIndex = Wingridview1.GridView1.FocusedRowHandle; 
                spi.ShowDialog();
                this.Wingridview1.GridView1.RefreshData();
                spi.Dispose();
        
        }
        /// <summary>
        /// 编辑对照信息
        /// </summary>
        /// <typeparam name="T">编辑对照信息的窗体</typeparam>
        public void EditItem()
        {
            if (!Portal.gc.HasFunction("FactoryInfo/Edit"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("FactoryInfo/Edit", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                return;
            }
            string ID = this.Wingridview1.gridView1.GetFocusedRowCellDisplayText(PKey);
            List<string> IDList = new List<string>();
            for (int i = 0; i < this.Wingridview1.gridView1.RowCount; i++)
            {
                string strTemp = this.Wingridview1.GridView1.GetRowCellDisplayText(i, PKey);
                IDList.Add(strTemp);
            }

            if (!string.IsNullOrEmpty(ID))
            {
                FrmEditFactory dlg = new FrmEditFactory();
                dlg.ID = ID;
                dlg.Text = "货源信息";
                dlg.IDList = IDList;
                dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
                if (DialogResult.OK == dlg.ShowDialog())
                {
                    BindData();
                }
            }

        }
        private void winGridView1_OnAddNew(object sender, EventArgs e)
        {

            AddItem();
        }
        /// <summary>
        /// 增加项目
        /// </summary>
        public void AddItem()
        {
           
            if (!Portal.gc.HasFunction("FactoryInfo/Add"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("FactoryInfo/Add", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                return ;
            }

            FrmEditFactory dlg = new FrmEditFactory();
            dlg.Text = "新建";
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

        private void SelectChose()
        {
            this.txt_cm_id.Properties.DisplayMember = "显示值";
            this.txt_cm_id.Properties.ValueMember = "项目值";
            this.txt_cm_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cm_idByEditor();


            this.txt_charge_man.Properties.DisplayMember = "显示值";
            this.txt_charge_man.Properties.ValueMember = "项目值";
            this.txt_charge_man.Properties.DataSource = SecurityUtil.GetOperatorOrSaleManByEditor();

        

            this.txtF_level.Properties.DisplayMember = "显示值";
            this.txtF_level.Properties.ValueMember = "项目值";
            this.txtF_level.Properties.DataSource = WHC.Dictionary.DictItemUtil.ClientC_LevelbyEditor();


            this.txt_f_jb.Properties.DisplayMember = "显示值";
            this.txt_f_jb.Properties.ValueMember = "项目值";
            this.txt_f_jb.Properties.DataSource = WHC.Dictionary.DictItemUtil.F_jbByEditor();

            this.txt_o_id.Properties.DisplayMember = "显示值";
            this.txt_o_id.Properties.ValueMember = "项目值";
            this.txt_o_id.Properties.DataSource = SecurityUtil.GetOperatorOrSaleManByEditor();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            AddItem();
        }

   


   }
}
