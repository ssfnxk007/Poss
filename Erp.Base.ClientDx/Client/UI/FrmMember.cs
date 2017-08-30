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
    public class FrmMember:BaseDockQuery
    {
        #region 变量
        private TextBoxControl txtM_introduce;
        private TextBoxControl txtHlep_input;
        private TextBoxControl txtCard_id;
        private TextBoxControl txtM_name;
        private TextBoxControl txtM_id;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DateTimeControl txtJoin_date;
        private ComboBoxControl txtJy_class_id;
        private ComboBoxControl txtM_zy;
        private ComboBoxControl txtActive_flag;
        private ComboBoxControl txtStation_id;
        private ComboBoxControl txtM_type;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private WinGridView winGridView1;
        private IContainer components;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;

         List<MemberInfo> memlist = new List<MemberInfo>();
        #endregion
        
        public FrmMember()
        {
            InitializeComponent();
        }

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtJoin_date = new WHC.Framework.Commons.DateTimeControl();
            this.txtJy_class_id = new WHC.Framework.Commons.ComboBoxControl();
            this.txtM_zy = new WHC.Framework.Commons.ComboBoxControl();
            this.txtActive_flag = new WHC.Framework.Commons.ComboBoxControl();
            this.txtStation_id = new WHC.Framework.Commons.ComboBoxControl();
            this.txtM_type = new WHC.Framework.Commons.ComboBoxControl();
            this.txtM_introduce = new WHC.Framework.Commons.TextBoxControl();
            this.txtHlep_input = new WHC.Framework.Commons.TextBoxControl();
            this.txtCard_id = new WHC.Framework.Commons.TextBoxControl();
            this.txtM_name = new WHC.Framework.Commons.TextBoxControl();
            this.txtM_id = new WHC.Framework.Commons.TextBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtJy_class_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActive_flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStation_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_introduce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHlep_input.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCard_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Size = new System.Drawing.Size(258, 109);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Size = new System.Drawing.Size(5, 109);
            // 
            // PanelCondition
            // 
            this.PanelCondition.Controls.Add(this.layoutControl1);
            this.PanelCondition.Size = new System.Drawing.Size(526, 109);
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
            this.panelControl1.Size = new System.Drawing.Size(789, 216);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.SplitterPosition = 109;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.txtJoin_date);
            this.layoutControl1.Controls.Add(this.txtJy_class_id);
            this.layoutControl1.Controls.Add(this.txtM_zy);
            this.layoutControl1.Controls.Add(this.txtActive_flag);
            this.layoutControl1.Controls.Add(this.txtStation_id);
            this.layoutControl1.Controls.Add(this.txtM_type);
            this.layoutControl1.Controls.Add(this.txtM_introduce);
            this.layoutControl1.Controls.Add(this.txtHlep_input);
            this.layoutControl1.Controls.Add(this.txtCard_id);
            this.layoutControl1.Controls.Add(this.txtM_name);
            this.layoutControl1.Controls.Add(this.txtM_id);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(526, 109);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtJoin_date
            // 
            this.txtJoin_date.ChineseColumnName = "入会时间";
            this.txtJoin_date.ColumnName = "db_member.join_date";
            this.txtJoin_date.EndDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtJoin_date.Location = new System.Drawing.Point(-284, 60);
            this.txtJoin_date.Name = "txtJoin_date";
            this.txtJoin_date.Size = new System.Drawing.Size(141, 20);
            this.txtJoin_date.TabIndex = 15;
            // 
            // txtJy_class_id
            // 
            this.txtJy_class_id.ChineseColumnName = "当前借阅分类";
            this.txtJy_class_id.ColumnName = "db_member.jy_class_id ";
            this.txtJy_class_id.Location = new System.Drawing.Point(156, 60);
            this.txtJy_class_id.Name = "txtJy_class_id";
            this.txtJy_class_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtJy_class_id.Properties.NullValuePrompt = "请选择...";
            this.txtJy_class_id.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtJy_class_id.Size = new System.Drawing.Size(141, 20);
            this.txtJy_class_id.StyleController = this.layoutControl1;
            this.txtJy_class_id.TabIndex = 13;
            // 
            // txtM_zy
            // 
            this.txtM_zy.ChineseColumnName = "会员类别";
            this.txtM_zy.ColumnName = "db_member.m_zy";
            this.txtM_zy.Location = new System.Drawing.Point(156, 36);
            this.txtM_zy.Name = "txtM_zy";
            this.txtM_zy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_zy.Properties.NullValuePrompt = "请选择...";
            this.txtM_zy.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtM_zy.Size = new System.Drawing.Size(141, 20);
            this.txtM_zy.StyleController = this.layoutControl1;
            this.txtM_zy.TabIndex = 12;
            // 
            // txtActive_flag
            // 
            this.txtActive_flag.ChineseColumnName = "是否有效";
            this.txtActive_flag.ColumnName = "db_member.active_flag";
            this.txtActive_flag.Location = new System.Drawing.Point(376, 36);
            this.txtActive_flag.Name = "txtActive_flag";
            this.txtActive_flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtActive_flag.Properties.NullValuePrompt = "请选择...";
            this.txtActive_flag.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtActive_flag.Size = new System.Drawing.Size(141, 20);
            this.txtActive_flag.StyleController = this.layoutControl1;
            this.txtActive_flag.TabIndex = 11;
            // 
            // txtStation_id
            // 
            this.txtStation_id.ChineseColumnName = "所属站点";
            this.txtStation_id.ColumnName = "db_member.station_id";
            this.txtStation_id.Location = new System.Drawing.Point(-284, 36);
            this.txtStation_id.Name = "txtStation_id";
            this.txtStation_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStation_id.Properties.NullValuePrompt = "请选择...";
            this.txtStation_id.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStation_id.Size = new System.Drawing.Size(141, 20);
            this.txtStation_id.StyleController = this.layoutControl1;
            this.txtStation_id.TabIndex = 10;
            // 
            // txtM_type
            // 
            this.txtM_type.ChineseColumnName = "会员级别";
            this.txtM_type.ColumnName = "db_member.m_type";
            this.txtM_type.Location = new System.Drawing.Point(-64, 36);
            this.txtM_type.Name = "txtM_type";
            this.txtM_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_type.Properties.NullValuePrompt = "请选择...";
            this.txtM_type.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtM_type.Size = new System.Drawing.Size(141, 20);
            this.txtM_type.StyleController = this.layoutControl1;
            this.txtM_type.TabIndex = 9;
            // 
            // txtM_introduce
            // 
            this.txtM_introduce.ChineseColumnName = "介绍人";
            this.txtM_introduce.ColumnName = "db_member.m_introduce";
            this.txtM_introduce.Location = new System.Drawing.Point(-64, 60);
            this.txtM_introduce.Name = "txtM_introduce";
            this.txtM_introduce.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txtM_introduce.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtM_introduce.Size = new System.Drawing.Size(141, 20);
            this.txtM_introduce.StyleController = this.layoutControl1;
            this.txtM_introduce.TabIndex = 8;
            this.txtM_introduce.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txtHlep_input
            // 
            this.txtHlep_input.ChineseColumnName = "助记码";
            this.txtHlep_input.ColumnName = "db_member.m_help_input";
            this.txtHlep_input.Location = new System.Drawing.Point(376, 12);
            this.txtHlep_input.Name = "txtHlep_input";
            this.txtHlep_input.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txtHlep_input.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtHlep_input.Size = new System.Drawing.Size(141, 20);
            this.txtHlep_input.StyleController = this.layoutControl1;
            this.txtHlep_input.TabIndex = 7;
            this.txtHlep_input.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txtCard_id
            // 
            this.txtCard_id.ChineseColumnName = "会员卡号";
            this.txtCard_id.ColumnName = "db_member.card_id";
            this.txtCard_id.Location = new System.Drawing.Point(-64, 12);
            this.txtCard_id.Name = "txtCard_id";
            this.txtCard_id.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txtCard_id.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCard_id.Size = new System.Drawing.Size(141, 20);
            this.txtCard_id.StyleController = this.layoutControl1;
            this.txtCard_id.TabIndex = 6;
            this.txtCard_id.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txtM_name
            // 
            this.txtM_name.ChineseColumnName = "会员名称";
            this.txtM_name.ColumnName = "db_member.m_name";
            this.txtM_name.Location = new System.Drawing.Point(156, 12);
            this.txtM_name.Name = "txtM_name";
            this.txtM_name.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txtM_name.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtM_name.Size = new System.Drawing.Size(141, 20);
            this.txtM_name.StyleController = this.layoutControl1;
            this.txtM_name.TabIndex = 5;
            this.txtM_name.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // txtM_id
            // 
            this.txtM_id.ChineseColumnName = "会员编码";
            this.txtM_id.ColumnName = "db_member.m_id";
            this.txtM_id.Location = new System.Drawing.Point(-284, 12);
            this.txtM_id.Name = "txtM_id";
            this.txtM_id.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txtM_id.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtM_id.Size = new System.Drawing.Size(141, 20);
            this.txtM_id.StyleController = this.layoutControl1;
            this.txtM_id.TabIndex = 4;
            this.txtM_id.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem5,
            this.layoutControlItem10,
            this.layoutControlItem12,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(-371, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(900, 92);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtM_id;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "会员编码";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtM_name;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(440, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "会员名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtHlep_input;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(660, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "助记码";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtStation_id;
            this.layoutControlItem7.CustomizationFormText = "所属站点";
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "所属站点";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtActive_flag;
            this.layoutControlItem8.CustomizationFormText = "是否有效";
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Location = new System.Drawing.Point(660, 24);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "是否有效";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtM_zy;
            this.layoutControlItem9.CustomizationFormText = "会员类别";
            this.layoutControlItem9.FillControlToClientArea = false;
            this.layoutControlItem9.Location = new System.Drawing.Point(440, 24);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "会员类别";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtM_introduce;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(220, 48);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "介绍人";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtJy_class_id;
            this.layoutControlItem10.CustomizationFormText = "当前借阅分类";
            this.layoutControlItem10.FillControlToClientArea = false;
            this.layoutControlItem10.Location = new System.Drawing.Point(440, 48);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(440, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "当前借阅分类";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtJoin_date;
            this.layoutControlItem12.CustomizationFormText = "入会时间";
            this.layoutControlItem12.FillControlToClientArea = false;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "入会时间";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCard_id;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(220, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "会员卡号";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtM_type;
            this.layoutControlItem6.CustomizationFormText = "会员级别";
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(220, 24);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(220, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "会员级别";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 14);
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
            this.winGridView1.Size = new System.Drawing.Size(789, 216);
            this.winGridView1.TabIndex = 0;
            // 
            // FrmMember
            // 
            this.ClientSize = new System.Drawing.Size(789, 375);
            this.Name = "FrmMember";
            this.Text = "会员信息";
            this.Load += new System.EventHandler(this.FrmMember_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtJy_class_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActive_flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStation_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_introduce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHlep_input.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCard_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        } 
        #endregion

        #region 绑定数据

        public override void BindData()
        {
            Cursor = Cursors.WaitCursor;
            this.memlist.Clear();
            this.memlist.AddRange(CallerFactory<IMemberService>.Instance.Find(this.SqlWhere));

            InitGird();
            this.winGridView1.GridView1.RefreshData();

            Cursor = Cursors.Default;


        } 
        #endregion

        #region 加载
        private void FrmMember_Load(object sender, EventArgs e)
        {
            
            this.InitDict();
            this.winGridView1.OnAddNew += new EventHandler(winGridView1_OnAddNew);
            this.winGridView1.OnEditSelected += new EventHandler(winGridView1_OnEditSelected);
            this.PKey = "m_id";
            this.winGridView1.ColumnNameAlias = CallerFactory<IMemberService>.Instance.GetColumnNameAlias();
            this.winGridView1.DisplayColumns = this.winGridView1.ColumnNameAlias.GetDisplayByAlias();
            this.winGridView1.GridView1.CustomColumnDisplayText += GridView1_CustomColumnDisplayText;
            winGridView1.DataSource = memlist;
            // this.btnAdd.Enabled = Portal.gc.HasFunction("MemberInfo/Add");           


        }

        void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Ls_flag" || e.Column.FieldName == "Yg_flag" || e.Column.FieldName == "M_send_letter" || e.Column.FieldName == "Focus_flag" || e.Column.FieldName == "M_send_letter")
            {
                if (e.Value == "0" && e.Value != null)
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
        //private string GetDisplayColumn(Dictionary<string, string> alias)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (string s in alias.Keys)
        //    {
        //        sb.AppendFormat("{0}|", s);
        //    }

        //    return sb.ToString();
        //}

        #region GridView
        private void InitGird()
        {
        
            this.winGridView1.gridView1.Columns["Station_id"].ColumnEdit = SecurityUtil.AllStationTreeListByGrid();
            this.winGridView1.gridView1.Columns["M_type"].ColumnEdit = DictItemUtil.M_typeByGrid();
            this.winGridView1.gridView1.Columns["M_national"].ColumnEdit = DictItemUtil.NationalByGrid();
            this.winGridView1.gridView1.Columns["M_native"].ColumnEdit = DictItemUtil.NativeByGrid();
            this.winGridView1.gridView1.Columns["M_city"].ColumnEdit = DictItemUtil.City_idByGrid();
            this.winGridView1.gridView1.Columns["M_province"].ColumnEdit = DictItemUtil.ProvinceByGrid();
            this.winGridView1.gridView1.Columns["M_arears"].ColumnEdit = DictItemUtil.A_idByGrid();
            this.winGridView1.gridView1.Columns["M_degree"].ColumnEdit = DictItemUtil.DegreeByGrid();
            this.winGridView1.gridView1.Columns["Active_flag"].ColumnEdit = DictItemUtil.YesorNoByGrid();
            this.winGridView1.gridView1.Columns["M_zy"].ColumnEdit = DictItemUtil.M_ZyByGrid();
            this.winGridView1.gridView1.Columns["M_ziye"].ColumnEdit = DictItemUtil.M_ZiyeByGrid();
            this.winGridView1.gridView1.Columns["M_sex"].ColumnEdit = DictItemUtil.SexByGrid();
            this.winGridView1.gridView1.Columns["M_join_type"].ColumnEdit = DictItemUtil.M_Join_typeByGrid();
            this.winGridView1.gridView1.Columns["M_mobile_type"].ColumnEdit = BaseUtil.MoblieTypeByGrid();

            this.winGridView1.gridView1.Columns["O_id_charge"].ColumnEdit = WHC.Security.SecurityUtil.OperatorOrSaleManByGrid();
            this.winGridView1.gridView1.Columns["O_id_modify"].ColumnEdit = WHC.Security.SecurityUtil.OperatorOrSaleManByGrid();
            this.winGridView1.gridView1.Columns["Station_id_yg"].ColumnEdit = WHC.Security.SecurityUtil.AllStationTreeListByGrid();
        }

        private void InitDict()
        {
            this.txtActive_flag.Properties.DisplayMember = "显示值";
            this.txtActive_flag.Properties.ValueMember = "项目值";
            this.txtActive_flag.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtStation_id.Properties.DisplayMember = "显示值";
            this.txtStation_id.Properties.ValueMember = "项目值";
            this.txtStation_id.Properties.DataSource = SecurityUtil.GetAllStationForDropDown();

            this.txtM_zy.Properties.DisplayMember = "显示值";
            this.txtM_zy.Properties.ValueMember = "项目值";
            this.txtM_zy.Properties.DataSource = WHC.Dictionary.DictItemUtil.M_zyByEditor();

            this.txtM_type.Properties.DisplayMember = "显示值";
            this.txtM_type.Properties.ValueMember = "项目值";
            this.txtM_type.Properties.DataSource = WHC.Dictionary.DictItemUtil.M_typeByEditor();

        } 
        #endregion

        #region 查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
            this.winGridView1.AutoSize = false;
        } 
        #endregion


        #region 编辑
        private void winGridView1_OnEditSelected(object sender, EventArgs e)
        {
            EditItem();
        }
        /// <summary>
        /// 双击编辑
        /// </summary>
        private void EditItem()
        {
            if (!Portal.gc.HasFunction("MemberInfo/Edit"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("MemberInfo/Edit", out value);
                MessageDxUtil.ShowWarning(string.Format("该用户没有{0}权限", value));
                return;
            }


            FrmEditMember dlg = new FrmEditMember();
            dlg.MasterView = this.winGridView1.GridView1;
            dlg.Text = "会员信息";
            dlg.ShowDialog();



        } 
        #endregion

        #region 新增
        private void winGridView1_OnAddNew(object sender, EventArgs e)
        {
            AddItem();
        }
        /// <summary>
        /// 新增
        /// </summary>
        private void AddItem()
        {
            if (!Portal.gc.HasFunction("MemberInfo/Add"))
            {
                string value = string.Empty;
                Portal.gc.FunctionDict.TryGetValue("MemberInfo/Add", out value);
                MessageDxUtil.ShowWarning(string.Format("该用户没有{0}权限", value));
                return;
            }

            FrmEditMember dlg = new FrmEditMember();
            dlg.Text = "会员信息";
            //dlg.MasterView = this.winGridView1.GridView1;
            dlg.rowIndex = -1;
            dlg.ShowDialog();
            dlg.Dispose();
        } 
        #endregion

        private void dlg_OnDataSaved(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            winGridView1_OnAddNew(null, null);
        }




    }
}
