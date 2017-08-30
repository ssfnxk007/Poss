namespace WHC.Framework.Commons
{
    partial class FrmPosPrintPreview
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintSetup = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(3, 17);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(456, 394);
            this.txtContent.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Location = new System.Drawing.Point(3, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印内容";
            // 
            // btnPrintSetup
            // 
            this.btnPrintSetup.Location = new System.Drawing.Point(12, 12);
            this.btnPrintSetup.Name = "btnPrintSetup";
            this.btnPrintSetup.Size = new System.Drawing.Size(98, 23);
            this.btnPrintSetup.TabIndex = 2;
            this.btnPrintSetup.Text = "打印设置";
            this.btnPrintSetup.Click += new System.EventHandler(this.btnPrintSetup_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(126, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(98, 23);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "打印预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(241, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(386, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmPosPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 472);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrintSetup);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPosPrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB口打印管理界面";
            this.Load += new System.EventHandler(this.FrmPosPrintPreview_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrintSetup;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}