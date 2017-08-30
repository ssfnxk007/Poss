using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS
{
   public class FrmPriont:BaseDock
    {
        #region 变量
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.CheckEdit IsUseMoneyBox;
        private DevExpress.XtraEditors.ComboBoxEdit MoneyBoxPort;
        private DevExpress.XtraEditors.RadioGroup OpenMoneyboxWay;
        private DevExpress.XtraEditors.ButtonEdit CustomerMoneyBox;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SpinEdit PaperFeed;
        private DevExpress.XtraEditors.SpinEdit PrintCount;
        private DevExpress.XtraEditors.ComboBoxEdit PrintName;
        private DevExpress.XtraEditors.ComboBoxEdit PapgerWidth;
        private DevExpress.XtraEditors.CheckEdit IsPrint;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit text_tou3;
        private DevExpress.XtraEditors.TextEdit text_wei4;
        private DevExpress.XtraEditors.TextEdit text_wei3;
        private DevExpress.XtraEditors.TextEdit text_wei2;
        private DevExpress.XtraEditors.TextEdit text_wei1;
        private DevExpress.XtraEditors.TextEdit text_tou2;
        private DevExpress.XtraEditors.TextEdit text_tou1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.PanelControl panelControl1; 
        #endregion

        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IsUseMoneyBox = new DevExpress.XtraEditors.CheckEdit();
            this.MoneyBoxPort = new DevExpress.XtraEditors.ComboBoxEdit();
            this.OpenMoneyboxWay = new DevExpress.XtraEditors.RadioGroup();
            this.CustomerMoneyBox = new DevExpress.XtraEditors.ButtonEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.PaperFeed = new DevExpress.XtraEditors.SpinEdit();
            this.PrintCount = new DevExpress.XtraEditors.SpinEdit();
            this.PrintName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PapgerWidth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.IsPrint = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.text_tou3 = new DevExpress.XtraEditors.TextEdit();
            this.text_wei4 = new DevExpress.XtraEditors.TextEdit();
            this.text_wei3 = new DevExpress.XtraEditors.TextEdit();
            this.text_wei2 = new DevExpress.XtraEditors.TextEdit();
            this.text_wei1 = new DevExpress.XtraEditors.TextEdit();
            this.text_tou2 = new DevExpress.XtraEditors.TextEdit();
            this.text_tou1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsUseMoneyBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBoxPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenMoneyboxWay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMoneyBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaperFeed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PapgerWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsPrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_tou3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_wei4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_wei3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_wei2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_wei1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tou2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tou1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(355, 456);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.groupBox2);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(2, 338);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(351, 104);
            this.panelControl5.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.IsUseMoneyBox);
            this.groupBox2.Controls.Add(this.MoneyBoxPort);
            this.groupBox2.Controls.Add(this.OpenMoneyboxWay);
            this.groupBox2.Controls.Add(this.CustomerMoneyBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "钱箱设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "钱箱端口：";
            // 
            // IsUseMoneyBox
            // 
            this.IsUseMoneyBox.EditValue = true;
            this.IsUseMoneyBox.Location = new System.Drawing.Point(8, 21);
            this.IsUseMoneyBox.Name = "IsUseMoneyBox";
            this.IsUseMoneyBox.Properties.Caption = "使用钱箱";
            this.IsUseMoneyBox.Size = new System.Drawing.Size(83, 19);
            this.IsUseMoneyBox.TabIndex = 4;
            this.IsUseMoneyBox.CheckedChanged += new System.EventHandler(this.IsUseMoneyBox_CheckedChanged);
            // 
            // MoneyBoxPort
            // 
            this.MoneyBoxPort.Location = new System.Drawing.Point(234, 15);
            this.MoneyBoxPort.Name = "MoneyBoxPort";
            this.MoneyBoxPort.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.MoneyBoxPort.Properties.Appearance.Options.UseBackColor = true;
            this.MoneyBoxPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MoneyBoxPort.Properties.Items.AddRange(new object[] {
            "钱箱接打印机",
            "LPT1",
            "LPT2",
            "LPT3",
            "COM1",
            "COM2",
            "COM3"});
            this.MoneyBoxPort.Size = new System.Drawing.Size(66, 20);
            this.MoneyBoxPort.TabIndex = 5;
            this.MoneyBoxPort.SelectedIndexChanged += new System.EventHandler(this.MoneyBoxPort_SelectedIndexChanged);
            // 
            // OpenMoneyboxWay
            // 
            this.OpenMoneyboxWay.Location = new System.Drawing.Point(8, 47);
            this.OpenMoneyboxWay.Name = "OpenMoneyboxWay";
            this.OpenMoneyboxWay.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "钱箱端口"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "使用外部钱箱命令")});
            this.OpenMoneyboxWay.Size = new System.Drawing.Size(295, 23);
            this.OpenMoneyboxWay.TabIndex = 3;
            this.OpenMoneyboxWay.SelectedIndexChanged += new System.EventHandler(this.OpenMoneyboxWay_SelectedIndexChanged);
            // 
            // CustomerMoneyBox
            // 
            this.CustomerMoneyBox.Location = new System.Drawing.Point(8, 76);
            this.CustomerMoneyBox.Name = "CustomerMoneyBox";
            this.CustomerMoneyBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CustomerMoneyBox.Size = new System.Drawing.Size(298, 20);
            this.CustomerMoneyBox.TabIndex = 6;
            this.CustomerMoneyBox.EditValueChanged += new System.EventHandler(this.CustomerMoneyBox_EditValueChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tableLayoutPanel1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 223);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(351, 115);
            this.panelControl3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.layoutControl2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(3, 3);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(339, 105);
            this.panelControl4.TabIndex = 0;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.PaperFeed);
            this.layoutControl2.Controls.Add(this.PrintCount);
            this.layoutControl2.Controls.Add(this.PrintName);
            this.layoutControl2.Controls.Add(this.PapgerWidth);
            this.layoutControl2.Controls.Add(this.IsPrint);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(335, 101);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // PaperFeed
            // 
            this.PaperFeed.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PaperFeed.Location = new System.Drawing.Point(273, 60);
            this.PaperFeed.Name = "PaperFeed";
            this.PaperFeed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PaperFeed.Size = new System.Drawing.Size(50, 20);
            this.PaperFeed.StyleController = this.layoutControl2;
            this.PaperFeed.TabIndex = 8;
            this.PaperFeed.EditValueChanged += new System.EventHandler(this.PaperFeed_EditValueChanged);
            // 
            // PrintCount
            // 
            this.PrintCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrintCount.Location = new System.Drawing.Point(87, 60);
            this.PrintCount.Name = "PrintCount";
            this.PrintCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PrintCount.Size = new System.Drawing.Size(107, 20);
            this.PrintCount.StyleController = this.layoutControl2;
            this.PrintCount.TabIndex = 7;
            this.PrintCount.EditValueChanged += new System.EventHandler(this.PrintCount_EditValueChanged);
            // 
            // PrintName
            // 
            this.PrintName.Location = new System.Drawing.Point(87, 36);
            this.PrintName.Name = "PrintName";
            this.PrintName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PrintName.Size = new System.Drawing.Size(236, 20);
            this.PrintName.StyleController = this.layoutControl2;
            this.PrintName.TabIndex = 6;
            this.PrintName.SelectedIndexChanged += new System.EventHandler(this.PrintName_SelectedIndexChanged);
            // 
            // PapgerWidth
            // 
            this.PapgerWidth.Location = new System.Drawing.Point(213, 12);
            this.PapgerWidth.Name = "PapgerWidth";
            this.PapgerWidth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PapgerWidth.Properties.Items.AddRange(new object[] {
            "58",
            "75"});
            this.PapgerWidth.Size = new System.Drawing.Size(110, 20);
            this.PapgerWidth.StyleController = this.layoutControl2;
            this.PapgerWidth.TabIndex = 5;
            this.PapgerWidth.SelectedIndexChanged += new System.EventHandler(this.PapgerWidth_SelectedIndexChanged);
            // 
            // IsPrint
            // 
            this.IsPrint.EditValue = true;
            this.IsPrint.Location = new System.Drawing.Point(12, 12);
            this.IsPrint.Name = "IsPrint";
            this.IsPrint.Properties.Caption = "使用打印";
            this.IsPrint.Size = new System.Drawing.Size(122, 19);
            this.IsPrint.StyleController = this.layoutControl2;
            this.IsPrint.TabIndex = 4;
            this.IsPrint.QueryValueByCheckState += new DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventHandler(this.IsPrint_QueryValueByCheckState);
            this.IsPrint.CheckedChanged += new System.EventHandler(this.IsPrint_CheckedChanged);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(335, 101);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.IsPrint;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.PapgerWidth;
            this.layoutControlItem9.Location = new System.Drawing.Point(126, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(189, 24);
            this.layoutControlItem9.Text = "纸张宽度：";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.PrintName;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(315, 24);
            this.layoutControlItem10.Text = "选择打印机：";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.PrintCount;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(186, 33);
            this.layoutControlItem11.Text = "打印份数：";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.PaperFeed;
            this.layoutControlItem12.Location = new System.Drawing.Point(186, 48);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(129, 33);
            this.layoutControlItem12.Text = "打印后走纸：";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(72, 14);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印信息";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.layoutControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 18);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(345, 200);
            this.panelControl2.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.text_tou3);
            this.layoutControl1.Controls.Add(this.text_wei4);
            this.layoutControl1.Controls.Add(this.text_wei3);
            this.layoutControl1.Controls.Add(this.text_wei2);
            this.layoutControl1.Controls.Add(this.text_wei1);
            this.layoutControl1.Controls.Add(this.text_tou2);
            this.layoutControl1.Controls.Add(this.text_tou1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(341, 196);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // text_tou3
            // 
            this.text_tou3.Location = new System.Drawing.Point(82, 60);
            this.text_tou3.Name = "text_tou3";
            this.text_tou3.Size = new System.Drawing.Size(247, 20);
            this.text_tou3.StyleController = this.layoutControl1;
            this.text_tou3.TabIndex = 10;
            this.text_tou3.EditValueChanged += new System.EventHandler(this.text_tou3_EditValueChanged);
            // 
            // text_wei4
            // 
            this.text_wei4.Location = new System.Drawing.Point(82, 156);
            this.text_wei4.Name = "text_wei4";
            this.text_wei4.Size = new System.Drawing.Size(247, 20);
            this.text_wei4.StyleController = this.layoutControl1;
            this.text_wei4.TabIndex = 9;
            this.text_wei4.EditValueChanged += new System.EventHandler(this.text_wei4_EditValueChanged);
            // 
            // text_wei3
            // 
            this.text_wei3.Location = new System.Drawing.Point(82, 132);
            this.text_wei3.Name = "text_wei3";
            this.text_wei3.Size = new System.Drawing.Size(247, 20);
            this.text_wei3.StyleController = this.layoutControl1;
            this.text_wei3.TabIndex = 8;
            this.text_wei3.EditValueChanged += new System.EventHandler(this.text_wei3_EditValueChanged);
            // 
            // text_wei2
            // 
            this.text_wei2.Location = new System.Drawing.Point(82, 108);
            this.text_wei2.Name = "text_wei2";
            this.text_wei2.Size = new System.Drawing.Size(247, 20);
            this.text_wei2.StyleController = this.layoutControl1;
            this.text_wei2.TabIndex = 7;
            this.text_wei2.EditValueChanged += new System.EventHandler(this.text_wei2_EditValueChanged);
            // 
            // text_wei1
            // 
            this.text_wei1.Location = new System.Drawing.Point(82, 84);
            this.text_wei1.Name = "text_wei1";
            this.text_wei1.Size = new System.Drawing.Size(247, 20);
            this.text_wei1.StyleController = this.layoutControl1;
            this.text_wei1.TabIndex = 6;
            this.text_wei1.EditValueChanged += new System.EventHandler(this.text_wei1_EditValueChanged);
            // 
            // text_tou2
            // 
            this.text_tou2.Location = new System.Drawing.Point(82, 36);
            this.text_tou2.Name = "text_tou2";
            this.text_tou2.Size = new System.Drawing.Size(247, 20);
            this.text_tou2.StyleController = this.layoutControl1;
            this.text_tou2.TabIndex = 5;
            this.text_tou2.EditValueChanged += new System.EventHandler(this.text_tou2_EditValueChanged);
            // 
            // text_tou1
            // 
            this.text_tou1.Location = new System.Drawing.Point(82, 12);
            this.text_tou1.Name = "text_tou1";
            this.text_tou1.Size = new System.Drawing.Size(247, 20);
            this.text_tou1.StyleController = this.layoutControl1;
            this.text_tou1.TabIndex = 4;
            this.text_tou1.EditValueChanged += new System.EventHandler(this.text_tou1_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(341, 196);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.text_tou1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem1.Text = "小票表头1：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.text_tou2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem2.Text = "小票表头2：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.text_wei1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem3.Text = "备注1：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.text_wei2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem4.Text = "备注2：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.text_wei3;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem5.Text = "备注3：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(67, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.text_wei4;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(321, 32);
            this.layoutControlItem6.Text = "备注4：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(67, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.text_tou3;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem7.Text = "小票表头3：";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(67, 14);
            // 
            // FrmPriont
            // 
            this.ClientSize = new System.Drawing.Size(355, 456);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPriont";
            this.Text = "小票打印设置";
            this.Load += new System.EventHandler(this.FrmPriont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsUseMoneyBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBoxPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenMoneyboxWay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMoneyBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaperFeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PapgerWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsPrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.text_tou3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_wei4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_wei3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_wei2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_wei1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tou2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tou1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        public FrmPriont()
        {
            InitializeComponent();
        }

        #region 写记录
        private void text_tou1_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "text_tou1", this.text_tou1.Text);
        }

        private void text_tou2_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "text_tou2", this.text_tou2.Text);
        }

        private void text_tou3_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "text_tou3", this.text_tou3.Text);
        }

        private void text_wei1_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "text_wei1", this.text_wei1.Text);
        }

        private void text_wei2_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "text_wei2", this.text_wei2.Text);

        }

        private void text_wei3_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "text_wei3", this.text_wei3.Text);

        }

        private void text_wei4_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "text_wei4", this.text_wei4.Text);

        }

        private void IsPrint_CheckedChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "IsPrint", this.IsPrint.Checked.ToString());

            bool k = Convert.ToBoolean(Portal.iniHelper.IniReadValue("PossSetup", "IsPrint"));
            if (k)
            {
                PrintName.ReadOnly = false;
            }
            else
            {
                PrintName.ReadOnly = true;
            }
        }

        private void PapgerWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "PapgerWidth", this.PapgerWidth.Text);

        }

        private void PrintName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "PrintName", this.PrintName.Text);

        }

        private void PrintCount_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "PrintCount", this.PrintCount.Text);

        }

        private void PaperFeed_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "PaperFeed", this.PaperFeed.Text);

        }

        private void IsUseMoneyBox_CheckedChanged(object sender, EventArgs e)
        {
           Portal.iniHelper.IniWriteValue("PossSetup", "IsUseMoneyBox", this.IsUseMoneyBox.Checked.ToString());

        }

        private void MoneyBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "MoneyBoxPort", this.MoneyBoxPort.Text);

        }

        private void OpenMoneyboxWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "OpenMoneyboxWay", this.OpenMoneyboxWay.Text);

        }

        private void CustomerMoneyBox_EditValueChanged(object sender, EventArgs e)
        {
            Portal.iniHelper.IniWriteValue("PossSetup", "CustomerMoneyBox", this.CustomerMoneyBox.Text);

        }

        #endregion

        private void FrmPriont_Load(object sender, EventArgs e)
        {
            InitPrinter();
            text_tou1.Text = Portal.iniHelper.IniReadValue("PossSetup", "text_tou1");
            text_tou2.Text= Portal.iniHelper.IniReadValue("PossSetup", "text_tou2");
            text_tou3.Text= Portal.iniHelper.IniReadValue("PossSetup", "text_tou3");
            this.text_wei1.Text= Portal.iniHelper.IniReadValue("PossSetup", "text_wei1");
            this.text_wei2.Text= Portal.iniHelper.IniReadValue("PossSetup", "text_wei2");
            this.text_wei3.Text= Portal.iniHelper.IniReadValue("PossSetup", "text_wei3");
            this.text_wei4.Text= Portal.iniHelper.IniReadValue("PossSetup", "text_wei4");
            
            this.IsPrint.Checked= Convert.ToBoolean(string.IsNullOrEmpty( Portal.iniHelper.IniReadValue("PossSetup", "IsPrint"))?true:false);
            this.PapgerWidth.Text= Portal.iniHelper.IniReadValue("PossSetup", "PapgerWidth");
            this.PrintName.Text= Portal.iniHelper.IniReadValue("PossSetup", "PrintName");
            this.PrintCount.Text= Portal.iniHelper.IniReadValue("PossSetup", "PrintCount");
            this.PaperFeed.Text= Portal.iniHelper.IniReadValue("PossSetup", "PaperFeed");
            this.IsUseMoneyBox.Checked = Convert.ToBoolean(string.IsNullOrEmpty( Portal.iniHelper.IniReadValue("PossSetup", "IsUseMoneyBox"))?true:false);
            //this.IsUseMoneyBox.Text= Portal.iniHelper.IniReadValue("PossSetup", "IsUseMoneyBox");
            this.MoneyBoxPort.Text= Portal.iniHelper.IniReadValue("PossSetup", "MoneyBoxPort");
            this.OpenMoneyboxWay.Text= Portal.iniHelper.IniReadValue("PossSetup", "OpenMoneyboxWay");
            this.CustomerMoneyBox.Text= Portal.iniHelper.IniReadValue("PossSetup", "CustomerMoneyBox");
        }

        private void IsPrint_QueryValueByCheckState(object sender, DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventArgs e)
        {
           


        }
        /// <summary>
        /// 初始化打印机列表
        /// </summary>
        private void InitPrinter()
        {
            this.PrintName.Properties.Items.Clear();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                this.PrintName.Properties.Items.Add(printer);
            }
        }
    }
}
