using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erp.Base.UI
{
    public class InputAmount:BaseForm
    {
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit txtAmount;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;

        public InputAmount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.CalcEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "数量：";
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = 0;
            this.txtAmount.Location = new System.Drawing.Point(59, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtAmount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAmount.Properties.Mask.EditMask = "n0";
            this.txtAmount.Size = new System.Drawing.Size(198, 48);
            this.txtAmount.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(68, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(149, 71);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // InputAmount
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(294, 106);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputAmount";
            this.ShowInTaskbar = false;
            this.Text = "请输入数量";
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
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

        public static int GetNumber()
        {
            InputAmount ia = new InputAmount();
            if (ia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return Convert.ToInt32(ia.txtAmount.EditValue);
            }
            else
            {
                return 0;
            }
            
        }
    }
}
