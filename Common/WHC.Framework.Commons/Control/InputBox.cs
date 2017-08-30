using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Drawing;
namespace WHC.Framework.Commons
{
    public class InputBox : XtraForm
    {
        private TextEdit txtInput;
        private System.Windows.Forms.Label label1;
        private SimpleButton btnOK;
        private SimpleButton btnCancel;

        public InputBox()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.txtInput = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(67, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Properties.Appearance.Options.UseFont = true;
            this.txtInput.Size = new System.Drawing.Size(210, 26);
            this.txtInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(72, 79);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(165, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InputBox
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(326, 124);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "请输入";
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public static object ShowInput()
        {
            InputBox input = new InputBox();
            Point p = MousePosition;
            input.Location = p;
            input.ShowDialog();
            if (input.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return (object)input.txtInput.Text;
            }
            return null;
        }

        public static object ShowInput(string TitleName)
        {
            InputBox input = new InputBox();
            input.Text = TitleName;
            Point p = MousePosition;
            input.Location = p;
            input.ShowDialog();
            if (input.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return (object)input.txtInput.Text;
            }
            return null;
        }

        public static object ShowInputCenter()
        {
            InputBox input = new InputBox();
           
            input.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            input.ShowDialog();
            if (input.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return (object)input.txtInput.Text;
            }
            return null;
        }
      
    }
}
