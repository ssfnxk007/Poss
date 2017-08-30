using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS
{
   public class FromMemberDoble:BaseDock
    {
        public string m_cord = string.Empty;

        private DevExpress.XtraEditors.TextEdit tb_member;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;

        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_member = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_member.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tb_member);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(423, 186);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入卡号：";
            // 
            // tb_member
            // 
            this.tb_member.Location = new System.Drawing.Point(107, 71);
            this.tb_member.Name = "tb_member";
            this.tb_member.Size = new System.Drawing.Size(245, 20);
            this.tb_member.TabIndex = 1;
            // 
            // FromMemberDoble
            // 
            this.ClientSize = new System.Drawing.Size(423, 186);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromMemberDoble";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FromMemberDoble_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_member.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        public FromMemberDoble()
        {
            InitializeComponent();
            this.tb_member.Focus();
        }

        private void FromMemberDoble_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                m_cord= this.tb_member.Text.Trim();
            }
        }
    }
}
