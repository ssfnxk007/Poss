using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;

namespace Erp.Base.UI
{
    public class FrmSelectDiscount : BaseForm
    {
        #region 定义变量
        private System.Windows.Forms.Label lblname;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.TextEdit txt_discount;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.lblname = new System.Windows.Forms.Label();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txt_discount = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblname.Location = new System.Drawing.Point(38, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(92, 17);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "请输入折扣：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(41, 60);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确认";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(133, 60);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "取消";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txt_discount
            // 
            this.txt_discount.EditValue = "0";
            this.txt_discount.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txt_discount.Location = new System.Drawing.Point(84, 34);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Properties.DisplayFormat.FormatString = "p2";
            this.txt_discount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_discount.Properties.EditFormat.FormatString = "p2";
            this.txt_discount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_discount.Properties.Mask.EditMask = "p2";
            this.txt_discount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_discount.ShowToolTips = false;
            this.txt_discount.Size = new System.Drawing.Size(124, 20);
            this.txt_discount.TabIndex = 0;
            // 
            // FrmSelectDiscount
            // 
            this.ClientSize = new System.Drawing.Size(247, 95);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblname);
            this.Name = "FrmSelectDiscount";
            this.ShowInTaskbar = false;
            this.Text = "输入折扣";
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region 构造方法
        public FrmSelectDiscount()
        {
            InitializeComponent();
        }
        #endregion

        #region 静态方法
        public static double ShowSelectDiscount()
        {
            FrmSelectDiscount frm = new FrmSelectDiscount();
            frm.ShowDialog();
            frm.Close();
            if (frm.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                frm.Discount = -1;
            }
            return frm.Discount;
        }
        #endregion

        #region 属性
        private double discount;
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        #endregion

        #region 按钮事件
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Discount = txt_discount.EditValue.ToString().ToDouble();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}