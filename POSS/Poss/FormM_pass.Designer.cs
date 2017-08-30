namespace POSS
{
    partial class FormM_pass
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
            this.t_newb = new DevExpress.XtraEditors.TextEdit();
            this.t_new = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.t_newb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_new.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // t_newb
            // 
            this.t_newb.Location = new System.Drawing.Point(141, 119);
            this.t_newb.Name = "t_newb";
            this.t_newb.Properties.PasswordChar = '#';
            this.t_newb.Size = new System.Drawing.Size(157, 20);
            this.t_newb.TabIndex = 2;
            // 
            // t_new
            // 
            this.t_new.Location = new System.Drawing.Point(142, 83);
            this.t_new.Name = "t_new";
            this.t_new.Properties.PasswordChar = '#';
            this.t_new.Size = new System.Drawing.Size(157, 20);
            this.t_new.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "重复输入：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码：";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Location = new System.Drawing.Point(154, 47);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(41, 12);
            this.la_name.TabIndex = 1;
            this.la_name.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前用户：";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(69, 189);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "修 改";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(224, 189);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "退 出";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FormM_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 246);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.t_newb);
            this.Controls.Add(this.t_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormM_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工密码修改";
            this.Load += new System.EventHandler(this.FormM_pass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_newb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_new.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit t_newb;
        private DevExpress.XtraEditors.TextEdit t_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}