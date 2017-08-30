using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS
{
  public  class BaseDockQuery1: DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SplitterControl splitterControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;

        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl3 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.splitterControl3);
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1297, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 162);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1297, 419);
            this.panelControl2.TabIndex = 1;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 100);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1297, 5);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // splitterControl2
            // 
            this.splitterControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl2.Location = new System.Drawing.Point(0, 157);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(1297, 5);
            this.splitterControl2.TabIndex = 3;
            this.splitterControl2.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 105);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1297, 52);
            this.panelControl3.TabIndex = 4;
            // 
            // panelControl4
            // 
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(951, 96);
            this.panelControl4.TabIndex = 0;
            // 
            // splitterControl3
            // 
            this.splitterControl3.Location = new System.Drawing.Point(953, 2);
            this.splitterControl3.Name = "splitterControl3";
            this.splitterControl3.Size = new System.Drawing.Size(5, 96);
            this.splitterControl3.TabIndex = 1;
            this.splitterControl3.TabStop = false;
            // 
            // panelControl5
            // 
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(958, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(337, 96);
            this.panelControl5.TabIndex = 2;
            // 
            // BaseDockQuery1
            // 
            this.ClientSize = new System.Drawing.Size(1297, 581);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "BaseDockQuery1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.ResumeLayout(false);

        }

        public BaseDockQuery1()
        {
            InitializeComponent();
        }
    }
}
