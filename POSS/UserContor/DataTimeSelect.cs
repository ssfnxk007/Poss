using POSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHC.Framework.Commons
{
    public class DataTimeSelect : DevExpress.XtraEditors.XtraForm
    {
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 昨天ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 今天ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 本月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本年ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 近一周ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 近一月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 近一年ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 上周ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上年ToolStripMenuItem;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl lbl_nowtime;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit EndDate;
        private DevExpress.XtraEditors.DateEdit StartDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStripMenuItem 本周ToolStripMenuItem;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.昨天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.今天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.本周ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本年ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.近一周ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.近一月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.近一年ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.上周ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上年ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_nowtime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndDate = new DevExpress.XtraEditors.DateEdit();
            this.StartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.昨天ToolStripMenuItem,
            this.今天ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.本周ToolStripMenuItem,
            this.本月ToolStripMenuItem,
            this.本年ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.近一周ToolStripMenuItem,
            this.近一月ToolStripMenuItem,
            this.近一年ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.上周ToolStripMenuItem,
            this.上月ToolStripMenuItem,
            this.上年ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 264);
            // 
            // 昨天ToolStripMenuItem
            // 
            this.昨天ToolStripMenuItem.Name = "昨天ToolStripMenuItem";
            this.昨天ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.昨天ToolStripMenuItem.Text = "昨天";
            this.昨天ToolStripMenuItem.Click += new System.EventHandler(this.昨天ToolStripMenuItem_Click);
            // 
            // 今天ToolStripMenuItem
            // 
            this.今天ToolStripMenuItem.Name = "今天ToolStripMenuItem";
            this.今天ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.今天ToolStripMenuItem.Text = "今天";
            this.今天ToolStripMenuItem.Click += new System.EventHandler(this.今天ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // 本周ToolStripMenuItem
            // 
            this.本周ToolStripMenuItem.Name = "本周ToolStripMenuItem";
            this.本周ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.本周ToolStripMenuItem.Text = "本周";
            this.本周ToolStripMenuItem.Click += new System.EventHandler(this.本周ToolStripMenuItem_Click);
            // 
            // 本月ToolStripMenuItem
            // 
            this.本月ToolStripMenuItem.Name = "本月ToolStripMenuItem";
            this.本月ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.本月ToolStripMenuItem.Text = "本月";
            this.本月ToolStripMenuItem.Click += new System.EventHandler(this.本月ToolStripMenuItem_Click);
            // 
            // 本年ToolStripMenuItem
            // 
            this.本年ToolStripMenuItem.Name = "本年ToolStripMenuItem";
            this.本年ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.本年ToolStripMenuItem.Text = "本年";
            this.本年ToolStripMenuItem.Click += new System.EventHandler(this.本年ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 6);
            // 
            // 近一周ToolStripMenuItem
            // 
            this.近一周ToolStripMenuItem.Name = "近一周ToolStripMenuItem";
            this.近一周ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.近一周ToolStripMenuItem.Text = "近一周";
            this.近一周ToolStripMenuItem.Click += new System.EventHandler(this.近一周ToolStripMenuItem_Click);
            // 
            // 近一月ToolStripMenuItem
            // 
            this.近一月ToolStripMenuItem.Name = "近一月ToolStripMenuItem";
            this.近一月ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.近一月ToolStripMenuItem.Text = "近一月";
            this.近一月ToolStripMenuItem.Click += new System.EventHandler(this.近一月ToolStripMenuItem_Click);
            // 
            // 近一年ToolStripMenuItem
            // 
            this.近一年ToolStripMenuItem.Name = "近一年ToolStripMenuItem";
            this.近一年ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.近一年ToolStripMenuItem.Text = "近一年";
            this.近一年ToolStripMenuItem.Click += new System.EventHandler(this.近一年ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(109, 6);
            // 
            // 上周ToolStripMenuItem
            // 
            this.上周ToolStripMenuItem.Name = "上周ToolStripMenuItem";
            this.上周ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.上周ToolStripMenuItem.Text = "上周";
            this.上周ToolStripMenuItem.Click += new System.EventHandler(this.上周ToolStripMenuItem_Click);
            // 
            // 上月ToolStripMenuItem
            // 
            this.上月ToolStripMenuItem.Name = "上月ToolStripMenuItem";
            this.上月ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.上月ToolStripMenuItem.Text = "上月";
            this.上月ToolStripMenuItem.Click += new System.EventHandler(this.上月ToolStripMenuItem_Click);
            // 
            // 上年ToolStripMenuItem
            // 
            this.上年ToolStripMenuItem.Name = "上年ToolStripMenuItem";
            this.上年ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.上年ToolStripMenuItem.Text = "上年";
            this.上年ToolStripMenuItem.Click += new System.EventHandler(this.上年ToolStripMenuItem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnReset);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Controls.Add(this.lbl_nowtime);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(317, 182);
            this.panelControl1.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnReset.Location = new System.Drawing.Point(203, 151);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(130, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(57, 151);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(66, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbl_nowtime
            // 
            this.lbl_nowtime.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_nowtime.Location = new System.Drawing.Point(87, 119);
            this.lbl_nowtime.Name = "lbl_nowtime";
            this.lbl_nowtime.Size = new System.Drawing.Size(0, 14);
            this.lbl_nowtime.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "当前日期：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EndDate);
            this.groupBox1.Controls.Add(this.StartDate);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择建档日期";
            // 
            // EndDate
            // 
            this.EndDate.EditValue = null;
            this.EndDate.Location = new System.Drawing.Point(88, 63);
            this.EndDate.Name = "EndDate";
            this.EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.EndDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.EndDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.EndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EndDate.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.EndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EndDate.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.EndDate.Size = new System.Drawing.Size(149, 20);
            this.EndDate.TabIndex = 2;
            // 
            // StartDate
            // 
            this.StartDate.EditValue = null;
            this.StartDate.Location = new System.Drawing.Point(88, 29);
            this.StartDate.Name = "StartDate";
            this.StartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.StartDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.StartDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.StartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.StartDate.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.StartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.StartDate.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.StartDate.Size = new System.Drawing.Size(149, 20);
            this.StartDate.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "结束时间：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "开始时间：";
            // 
            // DataTimeSelect
            // 
            this.ClientSize = new System.Drawing.Size(317, 182);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataTimeSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "时间选择";
            this.Load += new System.EventHandler(this.DataTimeSelect_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private DateTime selectedStartDate = DateTime.Now;

        public DateTime SelectedStartDate
        {
            get { return selectedStartDate; }
            set { selectedStartDate = value; }
        }
        private DateTime selectedEndDate = DateTime.Now;

        public DateTime SelectedEndDate
        {
            get { return selectedEndDate; }
            set { selectedEndDate = value; }
        }

        public DataTimeSelect()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_nowtime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (StartDate.EditValue.ToString().ToDateTime() <= EndDate.EditValue.ToString().ToDateTime())
            {
                this.selectedStartDate = StartDate.EditValue.ToString().ToDateTime();
                this.selectedEndDate = EndDate.EditValue.ToString().ToDateTime();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessagboxUit.ShowTips("请选择正确的时间段!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }
        private void BindTime()
        {
            StartDate.EditValue = this.selectedStartDate;
            EndDate.EditValue = this.selectedEndDate;
        }
        private void DataTimeSelect_Load(object sender, EventArgs e)
        {
            BindTime();
        }

        private void 昨天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.YesterDay();
            selectedStartDate = v.StartDateTime;
            selectedEndDate = v.EndDateTime;
            BindTime();
        }




        private void 今天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.Today();
            selectedStartDate = v.StartDateTime;
            selectedEndDate = v.EndDateTime;
            BindTime();
        }

        private void 近一周ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.NearWeek();
            this.selectedStartDate = v.StartDateTime;
            this.selectedEndDate = v.EndDateTime;
            BindTime();
        }

        private void 近一年ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.NearYear();
            this.selectedStartDate = v.StartDateTime;
            this.selectedEndDate = v.EndDateTime;
            BindTime();
        }

        private void 近一月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.NearMonth();
            this.selectedStartDate = v.StartDateTime;
            this.selectedEndDate = v.EndDateTime;
            BindTime();
        }

        private void 上周ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.LastWeek();
            this.selectedStartDate = v.StartDateTime;
            this.selectedEndDate = v.EndDateTime;
            BindTime();
        }

        private void 本月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.ThisMonth();
            this.selectedStartDate = v.StartDateTime;
            this.selectedEndDate = v.EndDateTime;
            BindTime();

        }

        private void 本周ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.ThisWeek();
            this.selectedEndDate = v.EndDateTime;
            this.selectedStartDate = v.StartDateTime;
            BindTime();
        }

        private void 上月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.LastMonth();
            this.selectedStartDate = v.StartDateTime;
            this.selectedEndDate = v.EndDateTime;
            BindTime();
        }

        private void 本年ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.ThisYear();
            this.selectedStartDate = v.StartDateTime;
            this.selectedEndDate = v.EndDateTime;
            BindTime();
        }

        private void 上年ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.LastYear();
            this.selectedStartDate = v.StartDateTime;
            this.selectedEndDate = v.EndDateTime;
            BindTime();
        }

    }
}
