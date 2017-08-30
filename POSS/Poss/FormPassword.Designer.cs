namespace POSS
{
    partial class FormPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入密码：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Location = new System.Drawing.Point(12, 27);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(414, 42);
            this.panelControl1.TabIndex = 2;
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.Location = new System.Drawing.Point(2, 2);
            this.textEdit1.MaximumSize = new System.Drawing.Size(414, 36);
            this.textEdit1.MinimumSize = new System.Drawing.Size(414, 36);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.PasswordChar = '*';
            this.textEdit1.Size = new System.Drawing.Size(414, 36);
            this.textEdit1.TabIndex = 0;
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 108);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入会员密码";
            this.Load += new System.EventHandler(this.FormPassword_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPassword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}