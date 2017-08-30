using System.Windows.Forms;
namespace POSS
{
    partial class BaseEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseEditForm));
            this.picPrint = new System.Windows.Forms.PictureBox();
            this.dataNavigator1 = new POSS.DataNavigator();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dataViewNavigator1 = new POSS.DataViewNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // picPrint
            // 
            this.picPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picPrint.Image = ((System.Drawing.Image)(resources.GetObject("picPrint.Image")));
            this.picPrint.Location = new System.Drawing.Point(210, 391);
            this.picPrint.Name = "picPrint";
            this.picPrint.Size = new System.Drawing.Size(32, 32);
            this.picPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrint.TabIndex = 5;
            this.picPrint.TabStop = false;
            this.picPrint.Click += new System.EventHandler(this.picPrint_Click);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataNavigator1.AutoSize = true;
            this.dataNavigator1.CurrentIndex = 0;
            this.dataNavigator1.Location = new System.Drawing.Point(-3, 378);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(256, 45);
            this.dataNavigator1.TabIndex = 3;
            this.dataNavigator1.Visible = false;
            this.dataNavigator1.PositionChanging += new POSS.PostionChangeingEventHandler(this.dataNavigator1_PositionChanging);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(270, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(351, 391);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "保存(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(432, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataViewNavigator1
            // 
            this.dataViewNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataViewNavigator1.Location = new System.Drawing.Point(12, 392);
            this.dataViewNavigator1.Name = "dataViewNavigator1";
            this.dataViewNavigator1.Size = new System.Drawing.Size(192, 24);
            this.dataViewNavigator1.TabIndex = 6;
            this.dataViewNavigator1.RowIndexChanged += new POSS.ViewRowIndexChanged(this.dataViewNavigator1_RowIndexChanged);
            this.dataViewNavigator1.RowIndexChanging += new POSS.ViewRowIndexChanging(this.dataViewNavigator1_RowIndexChanging);
            // 
            // BaseEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(535, 427);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picPrint);
            this.Controls.Add(this.dataViewNavigator1);
            this.Controls.Add(this.dataNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseEditForm";
            this.ShowInTaskbar = false;
            this.Text = "BaseEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseEditForm_FormClosing);
            this.Load += new System.EventHandler(this.BaseEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton btnOK;
        protected DevExpress.XtraEditors.SimpleButton btnCancel;
        protected DevExpress.XtraEditors.SimpleButton btnAdd;
        protected DataNavigator dataNavigator1;
        protected PictureBox picPrint;
        protected POSS.DataViewNavigator dataViewNavigator1;
    }
}