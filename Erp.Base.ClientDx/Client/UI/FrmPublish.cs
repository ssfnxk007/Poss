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

using System.Reflection;

namespace Erp.Base.UI
{

    public class FrmPublish : BaseDockQuery
    {

        #region 变量
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private TextBoxControl textBoxControl5;
        private TextBoxControl textBoxControl6;
        private TextBoxControl textBoxControl7;
        private ComboBoxControl comboBoxControl1;
        private TextBoxControl textBoxControl4;
        private TextBoxControl textBoxControl3;
        private TextBoxControl textBoxControl2;
        private TextBoxControl textBoxControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private WinGridView winGridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;

        List<PublishsInfo> publist = new List<PublishsInfo>();
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublish));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textBoxControl5 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl6 = new WHC.Framework.Commons.TextBoxControl();
            this.textBoxControl7 = new WHC.Framework.Commons.TextBoxControl();
            this.comboBoxControl1 = new WHC.Framework.Commons.ComboBoxControl();
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
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxControl1.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCondition
            // 
            this.PanelCondition.Controls.Add(this.layoutControl1);
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
            this.layoutControl1.Controls.Add(this.textBoxControl6);
            this.layoutControl1.Controls.Add(this.textBoxControl7);
            this.layoutControl1.Controls.Add(this.comboBoxControl1);
            this.layoutControl1.Controls.Add(this.textBoxControl4);
            this.layoutControl1.Controls.Add(this.textBoxControl3);
            this.layoutControl1.Controls.Add(this.textBoxControl2);
            this.layoutControl1.Controls.Add(this.textBoxControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(526, 100);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textBoxControl5
            // 
            this.textBoxControl5.ChineseColumnName = "地址";
            this.textBoxControl5.ColumnName = "address";
            this.textBoxControl5.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl5.Location = new System.Drawing.Point(675, 36);
            this.textBoxControl5.Name = "textBoxControl5";
            this.textBoxControl5.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl5.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl5.Size = new System.Drawing.Size(133, 20);
            this.textBoxControl5.StyleController = this.layoutControl1;
            this.textBoxControl5.TabIndex = 1;
            this.textBoxControl5.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl6
            // 
            this.textBoxControl6.ChineseColumnName = "邮编";
            this.textBoxControl6.ColumnName = "zip";
            this.textBoxControl6.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl6.Location = new System.Drawing.Point(275, 36);
            this.textBoxControl6.Name = "textBoxControl6";
            this.textBoxControl6.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl6.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl6.Size = new System.Drawing.Size(133, 20);
            this.textBoxControl6.StyleController = this.layoutControl1;
            this.textBoxControl6.TabIndex = 2;
            this.textBoxControl6.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl7
            // 
            this.textBoxControl7.ChineseColumnName = "电话";
            this.textBoxControl7.ColumnName = "tel";
            this.textBoxControl7.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl7.Location = new System.Drawing.Point(475, 36);
            this.textBoxControl7.Name = "textBoxControl7";
            this.textBoxControl7.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl7.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl7.Size = new System.Drawing.Size(133, 20);
            this.textBoxControl7.StyleController = this.layoutControl1;
            this.textBoxControl7.TabIndex = 3;
            this.textBoxControl7.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // comboBoxControl1
            // 
            this.comboBoxControl1.ChineseColumnName = "出版社类别";
            this.comboBoxControl1.ColumnName = "class_id";
            this.comboBoxControl1.Location = new System.Drawing.Point(75, 36);
            this.comboBoxControl1.Name = "comboBoxControl1";
            this.comboBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxControl1.Properties.NullValuePrompt = "请选择...";
            this.comboBoxControl1.Properties.NullValuePromptShowForEmptyValue = true;
            this.comboBoxControl1.Size = new System.Drawing.Size(133, 20);
            this.comboBoxControl1.StyleController = this.layoutControl1;
            this.comboBoxControl1.TabIndex = 1;
            // 
            // textBoxControl4
            // 
            this.textBoxControl4.ChineseColumnName = "出版社名称";
            this.textBoxControl4.ColumnName = "pub_name";
            this.textBoxControl4.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl4.Location = new System.Drawing.Point(675, 12);
            this.textBoxControl4.Name = "textBoxControl4";
            this.textBoxControl4.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl4.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl4.Size = new System.Drawing.Size(133, 20);
            this.textBoxControl4.StyleController = this.layoutControl1;
            this.textBoxControl4.TabIndex = 7;
            this.textBoxControl4.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl3
            // 
            this.textBoxControl3.ChineseColumnName = "联系人";
            this.textBoxControl3.ColumnName = "contact_man";
            this.textBoxControl3.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl3.Location = new System.Drawing.Point(475, 12);
            this.textBoxControl3.Name = "textBoxControl3";
            this.textBoxControl3.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl3.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl3.Size = new System.Drawing.Size(133, 20);
            this.textBoxControl3.StyleController = this.layoutControl1;
            this.textBoxControl3.TabIndex = 6;
            this.textBoxControl3.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl2
            // 
            this.textBoxControl2.ChineseColumnName = "谐音";
            this.textBoxControl2.ColumnName = "p_help_input";
            this.textBoxControl2.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl2.Location = new System.Drawing.Point(275, 12);
            this.textBoxControl2.Name = "textBoxControl2";
            this.textBoxControl2.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl2.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl2.Size = new System.Drawing.Size(133, 20);
            this.textBoxControl2.StyleController = this.layoutControl1;
            this.textBoxControl2.TabIndex = 5;
            this.textBoxControl2.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // textBoxControl1
            // 
            this.textBoxControl1.ChineseColumnName = "出版社编号";
            this.textBoxControl1.ColumnName = "pub_id";
            this.textBoxControl1.CurrentOperator = WHC.Framework.Commons.SqlOperator.Like;
            this.textBoxControl1.Location = new System.Drawing.Point(75, 12);
            this.textBoxControl1.Name = "textBoxControl1";
            this.textBoxControl1.Properties.NullValuePrompt = "F4键切换查询模式";
            this.textBoxControl1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textBoxControl1.Size = new System.Drawing.Size(133, 20);
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
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(820, 83);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBoxControl1;
            this.layoutControlItem1.CustomizationFormText = "出版社编号";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(100, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "出版社编号";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxControl2;
            this.layoutControlItem2.CustomizationFormText = "谐音";
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(100, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "谐音";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBoxControl3;
            this.layoutControlItem3.CustomizationFormText = "联系人";
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(100, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "联系人";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textBoxControl4;
            this.layoutControlItem4.CustomizationFormText = "出版社名称";
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(600, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(100, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "出版社名称";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.comboBoxControl1;
            this.layoutControlItem5.CustomizationFormText = "出版社类别";
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "出版社类别";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textBoxControl6;
            this.layoutControlItem7.CustomizationFormText = "邮编";
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "邮编";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textBoxControl5;
            this.layoutControlItem8.CustomizationFormText = "地址";
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Location = new System.Drawing.Point(600, 24);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "地址";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textBoxControl7;
            this.layoutControlItem6.CustomizationFormText = "电话";
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(400, 24);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "电话";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 14);
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
            this.winGridView1.Size = new System.Drawing.Size(789, 225);
            this.winGridView1.TabIndex = 0;
            // 
            // FrmPublish
            // 
            this.ClientSize = new System.Drawing.Size(789, 375);
            this.Name = "FrmPublish";
            this.Text = "出版社信息";
            this.Load += new System.EventHandler(this.FrmPublish_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxControl7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxControl1.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        } 
        #endregion

        #region 构造
        public FrmPublish()
        {
            InitializeComponent();
            this.winGridView1.BestFitColumnWith = false;
        } 
        #endregion

        #region 绑定数据

        public override void BindData()
        {
            Cursor = Cursors.WaitCursor;
            this.publist.Clear();
            this.publist.AddRange(CallerFactory<IPublishsService>.Instance.Find(this.SqlWhere));
            //this.winGridView1.ColumnNameAlias = CallerFactory<IPublishsService>.Instance.GetColumnNameAlias();
            this.InitDict();
            this.winGridView1.GridView1.RefreshData();
            Cursor = Cursors.Default;
        } 
        #endregion

        #region 格式
        private void InitDict()
        {
            this.winGridView1.gridView1.Columns["Class_id"].ColumnEdit = DictItemUtil.Class_idByGrid();
            this.winGridView1.gridView1.Columns["O_id_input"].ColumnEdit = WHC.Security.SecurityUtil.O_idByGrid();
            this.winGridView1.gridView1.Columns["O_id_lastmodify"].ColumnEdit = WHC.Security.SecurityUtil.O_idByGrid();
            this.winGridView1.gridView1.Columns["P_charge_man"].ColumnEdit = WHC.Security.SecurityUtil.O_idByGrid();

        } 
        #endregion

        #region 加载
        private void FrmPublish_Load(object sender, EventArgs e)
        {
            SelectChose();
            this.winGridView1.OnAddNew += new EventHandler(winGridView1_OnAddNew);
            this.winGridView1.OnEditSelected += new EventHandler(winGridView1_OnEditSelected);
            this.PKey = "pub_id";
            this.winGridView1.ColumnNameAlias = CallerFactory<IPublishsService>.Instance.GetColumnNameAlias();
            this.winGridView1.DisplayColumns = this.winGridView1.ColumnNameAlias.GetDisplayByAlias();
            winGridView1.DataSource = publist;
            // this.btnAdd.Enabled = Portal.gc.HasFunction("PublishInfo/Add");
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
            if (!Portal.gc.HasFunction("PublishInfo/Edit"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("PublishInfo/Edit", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                return;
            }


            FrmEditPublishs dlg = new FrmEditPublishs();
            dlg.Text = "出版社信息";
            dlg.MasterView = this.winGridView1.GridView1;
            dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
            if (DialogResult.OK == dlg.ShowDialog())
            {
                BindData();
            }


        } 
        #endregion

        #region 新增

        private void winGridView1_OnAddNew(object sender, EventArgs e)
        {

            AddItem();
        }
        /// <summary>
        /// 增加项目
        /// </summary>
        public void AddItem()
        {
            if (!Portal.gc.HasFunction(" PublishInfo/Add"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("PublishInfo/Add", out value);
                MessageDxUtil.ShowWarning(string.Format("用户没有{0}", value));
                return;
            }
            FrmEditPublishs dlg = new FrmEditPublishs();
            dlg.Text = "出版社信息";
            dlg.rowIndex = -1;
            dlg.OnDataSaved += new EventHandler(dlg_OnDataSaved);
            if (DialogResult.OK == dlg.ShowDialog())
            {
                BindData();
            }
            dlg.Dispose();
        } 
        #endregion

        #region 其它Chick

        private void SelectChose()
        {
            this.comboBoxControl1.Properties.DisplayMember = "显示值";
            this.comboBoxControl1.Properties.ValueMember = "项目值";
            this.comboBoxControl1.Properties.DataSource = WHC.Dictionary.DictItemUtil.Class_idByEditor();
        }


        void dlg_OnDataSaved(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
            this.winGridView1.AutoSize = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            winGridView1_OnAddNew(null, null);
        } 
        #endregion
    }

}