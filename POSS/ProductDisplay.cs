using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using Erp.Base.Entity;
using Erp.Base.Facade;
using WHC.Framework.ControlUtil;
using WHC.Framework.ControlUtil.Facade;
using System.ComponentModel;

namespace Erp.Base.UI
{
    public class ProductDisplay : XtraUserControl
    {
        private TextEdit txt_h_isbn;
        private TextEdit txt_pub_id;
        private TextEdit txt_mytm;
        private TextEdit txt_h_name;
        private TextEdit txt_u_id;
        private TextEdit txth_output_price;
        private TextEdit txth_input_date;

        private SimpleProductInfo currentProduct = new SimpleProductInfo();
        private string h_id;
        /// <summary>
        /// 内部编码
        /// </summary>
        public string H_id
        {
            get {return h_id;}
            set {
                h_id = value;
                if (value == null) return;
                ProductInfo info = CallerFactory<IProductService>.Instance.FindByID(value);
                if (info != null)
                {
                    txt_h_name.Text = string.Format("商品名称： {0}", info.H_name);
                    txth_output_price.Text = string.Format("定价： {0}", info.H_output_price.ToString("c2"));
                    txt_u_id.Text = string.Format("计量单位： {0}", info.U_id);
                    txt_mytm.Text = string.Format("条码： {0}", info.H_mytm);
                    txt_pub_id.Text = string.Format("版别： {0}", info.Pub_id);
                    txt_h_isbn.Text = string.Format("书号： {0}", info.H_isbn);
                    this.txth_input_date.Text = string.Format("建档日期： {0}", info.H_input_date.ToString());

                }
                else
                {
                    Zd_productInfo zdInfo = CallerFactory<IZd_productService>.Instance.FindByID(value);
                    txt_h_name.Text = string.Format("商品名称： {0}", zdInfo.H_name);
                    txth_output_price.Text = string.Format("定价： {0}", zdInfo.H_price.ToString("c2"));
                    txt_u_id.Text = string.Format("计量单位： {0}", zdInfo.U_id);
                    txt_mytm.Text = string.Format("条码： {0}", zdInfo.Z_id);
                    txt_pub_id.Text = string.Format("版别： {0}", zdInfo.Pub_id);
                    txt_h_isbn.Text = string.Format("书号： {0}", zdInfo.H_isbn);
                    this.txth_input_date.Text = string.Format("建档日期： {0}", zdInfo.H_input_date.ToString());

                }
            }
        }
        /// <summary>
        /// 获取商品信息
        /// </summary>
        public SimpleProductInfo CurrentProduct
        {
            get { return currentProduct; }
            set
            {
                currentProduct = value;
                if (value != null)
                {
                    txt_h_name.Text = string.Format("商品名称： {0}", value.H_name);
                    txth_output_price.Text = string.Format("定价： {0}", value.H_output_price.ToString("c2"));
                    txt_u_id.Text = string.Format("计量单位： {0}", value.U_id);
                    txt_mytm.Text = string.Format("条码： {0}", value.H_mytm);
                    txt_pub_id.Text = string.Format("版别： {0}", value.Pub_id);
                    txt_h_isbn.Text = string.Format("书号： {0}", value.H_isbn);
                    this.txth_input_date.Text = string.Format("建档日期： {0}", value.H_input_date.ToString());


                }

            }
        }
        public ProductDisplay()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.txth_input_date = new DevExpress.XtraEditors.TextEdit();
            this.txt_h_isbn = new DevExpress.XtraEditors.TextEdit();
            this.txt_pub_id = new DevExpress.XtraEditors.TextEdit();
            this.txt_mytm = new DevExpress.XtraEditors.TextEdit();
            this.txt_h_name = new DevExpress.XtraEditors.TextEdit();
            this.txt_u_id = new DevExpress.XtraEditors.TextEdit();
            this.txth_output_price = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txth_input_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_h_isbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pub_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mytm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_h_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_u_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txth_output_price.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txth_input_date
            // 
            this.txth_input_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txth_input_date.Location = new System.Drawing.Point(649, 24);
            this.txth_input_date.Name = "txth_input_date";
            this.txth_input_date.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txth_input_date.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txth_input_date.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txth_input_date.Properties.Appearance.Options.UseBackColor = true;
            this.txth_input_date.Properties.Appearance.Options.UseFont = true;
            this.txth_input_date.Properties.Appearance.Options.UseForeColor = true;
            this.txth_input_date.Properties.ReadOnly = true;
            this.txth_input_date.Size = new System.Drawing.Size(238, 24);
            this.txth_input_date.TabIndex = 45;
            // 
            // txt_h_isbn
            // 
            this.txt_h_isbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_h_isbn.Location = new System.Drawing.Point(649, 0);
            this.txt_h_isbn.Name = "txt_h_isbn";
            this.txt_h_isbn.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txt_h_isbn.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txt_h_isbn.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_h_isbn.Properties.Appearance.Options.UseBackColor = true;
            this.txt_h_isbn.Properties.Appearance.Options.UseFont = true;
            this.txt_h_isbn.Properties.Appearance.Options.UseForeColor = true;
            this.txt_h_isbn.Properties.ReadOnly = true;
            this.txt_h_isbn.Size = new System.Drawing.Size(238, 24);
            this.txt_h_isbn.TabIndex = 56;
            // 
            // txt_pub_id
            // 
            this.txt_pub_id.Location = new System.Drawing.Point(437, 24);
            this.txt_pub_id.Name = "txt_pub_id";
            this.txt_pub_id.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txt_pub_id.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txt_pub_id.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_pub_id.Properties.Appearance.Options.UseBackColor = true;
            this.txt_pub_id.Properties.Appearance.Options.UseFont = true;
            this.txt_pub_id.Properties.Appearance.Options.UseForeColor = true;
            this.txt_pub_id.Properties.ReadOnly = true;
            this.txt_pub_id.Size = new System.Drawing.Size(212, 24);
            this.txt_pub_id.TabIndex = 57;
            // 
            // txt_mytm
            // 
            this.txt_mytm.Location = new System.Drawing.Point(437, 0);
            this.txt_mytm.Name = "txt_mytm";
            this.txt_mytm.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txt_mytm.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txt_mytm.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_mytm.Properties.Appearance.Options.UseBackColor = true;
            this.txt_mytm.Properties.Appearance.Options.UseFont = true;
            this.txt_mytm.Properties.Appearance.Options.UseForeColor = true;
            this.txt_mytm.Properties.ReadOnly = true;
            this.txt_mytm.Size = new System.Drawing.Size(212, 24);
            this.txt_mytm.TabIndex = 45;
            // 
            // txt_h_name
            // 
            this.txt_h_name.Location = new System.Drawing.Point(0, 24);
            this.txt_h_name.Name = "txt_h_name";
            this.txt_h_name.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txt_h_name.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txt_h_name.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_h_name.Properties.Appearance.Options.UseBackColor = true;
            this.txt_h_name.Properties.Appearance.Options.UseFont = true;
            this.txt_h_name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_h_name.Properties.ReadOnly = true;
            this.txt_h_name.Size = new System.Drawing.Size(437, 24);
            this.txt_h_name.TabIndex = 67;
            // 
            // txt_u_id
            // 
            this.txt_u_id.Location = new System.Drawing.Point(226, 0);
            this.txt_u_id.Name = "txt_u_id";
            this.txt_u_id.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txt_u_id.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txt_u_id.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_u_id.Properties.Appearance.Options.UseBackColor = true;
            this.txt_u_id.Properties.Appearance.Options.UseFont = true;
            this.txt_u_id.Properties.Appearance.Options.UseForeColor = true;
            this.txt_u_id.Properties.ReadOnly = true;
            this.txt_u_id.Size = new System.Drawing.Size(211, 24);
            this.txt_u_id.TabIndex = 43;
            // 
            // txth_output_price
            // 
            this.txth_output_price.Location = new System.Drawing.Point(0, 0);
            this.txth_output_price.Name = "txth_output_price";
            this.txth_output_price.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txth_output_price.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txth_output_price.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txth_output_price.Properties.Appearance.Options.UseBackColor = true;
            this.txth_output_price.Properties.Appearance.Options.UseFont = true;
            this.txth_output_price.Properties.Appearance.Options.UseForeColor = true;
            this.txth_output_price.Properties.ReadOnly = true;
            this.txth_output_price.Size = new System.Drawing.Size(226, 24);
            this.txth_output_price.TabIndex = 56;
            // 
            // ProductDisplay
            // 
            this.Controls.Add(this.txth_output_price);
            this.Controls.Add(this.txth_input_date);
            this.Controls.Add(this.txt_pub_id);
            this.Controls.Add(this.txt_h_name);
            this.Controls.Add(this.txt_u_id);
            this.Controls.Add(this.txt_mytm);
            this.Controls.Add(this.txt_h_isbn);
            this.Name = "ProductDisplay";
            this.Size = new System.Drawing.Size(887, 48);
            ((System.ComponentModel.ISupportInitialize)(this.txth_input_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_h_isbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pub_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mytm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_h_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_u_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txth_output_price.Properties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

