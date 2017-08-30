using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Erp.Base.Entity;
using System.Data;
using System.ComponentModel;
using WHC.Framework.ControlUtil;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
namespace Erp.Base.UI
{
    public class ComditionFilter : BaseForm
    {
        private List<SimpleProductInfo> selectedProducts = new List<SimpleProductInfo>();//选择的商品列表
        private SimpleProductInfo tempInfo = new SimpleProductInfo();
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.TextEdit txt_priod_id;
        private DevExpress.XtraEditors.TextEdit txt_output_price;
        private DevExpress.XtraEditors.TextEdit txt_help_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_ok;

        public string WhereText_HelpInput
        {
            get
            {
                return this.txt_help_input.Text;
            }
        }
        public string WhereText_OutPrice
        {
            get
            {
                return this.txt_output_price.Text;
            }
        }
        public string WhereText_PriodId
        {
            get
            {      
                return this.txt_priod_id.Text;
            }
        }
        
        //if (!string.IsNullOrWhiteSpace(this.txt_pagecount.Text))
        //{
        //    whereText += string.Format("h_priod_id =\"{0}\"", this.txt_pagecount.Text).ToSqlSyntax(whereText);
        //}

        public ComditionFilter()
        {
            InitializeComponent();
        }

        public void Setinfo(SimpleProductInfo info)
        {
            info.H_period_id = txt_priod_id.Text;
            info.H_output_price = txt_output_price.Text.ToInt32();
            info.My_help_input = txt_help_input.Text;
        }

        private void InitializeComponent()
        {
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_priod_id = new DevExpress.XtraEditors.TextEdit();
            this.txt_output_price = new DevExpress.XtraEditors.TextEdit();
            this.txt_help_input = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_priod_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_output_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_help_input.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(71, 193);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 40;
            this.btn_ok.Text = "确定";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(172, 193);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 50;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_priod_id
            // 
            this.txt_priod_id.Location = new System.Drawing.Point(80, 14);
            this.txt_priod_id.Name = "txt_priod_id";
            this.txt_priod_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priod_id.Properties.Appearance.Options.UseFont = true;
            this.txt_priod_id.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_priod_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_priod_id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txt_priod_id.Properties.MaxLength = 8;
            this.txt_priod_id.Size = new System.Drawing.Size(212, 42);
            this.txt_priod_id.TabIndex = 10;
            this.txt_priod_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComditionFilter_KeyDown);
            // 
            // txt_output_price
            // 
            this.txt_output_price.Location = new System.Drawing.Point(80, 70);
            this.txt_output_price.Name = "txt_output_price";
            this.txt_output_price.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_output_price.Properties.Appearance.Options.UseFont = true;
            this.txt_output_price.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_output_price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_output_price.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txt_output_price.Properties.Mask.EditMask = "n2";
            this.txt_output_price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_output_price.Size = new System.Drawing.Size(212, 42);
            this.txt_output_price.TabIndex = 5;
            this.txt_output_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComditionFilter_KeyDown);
            // 
            // txt_help_input
            // 
            this.txt_help_input.Location = new System.Drawing.Point(80, 126);
            this.txt_help_input.Name = "txt_help_input";
            this.txt_help_input.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_help_input.Properties.Appearance.Options.UseFont = true;
            this.txt_help_input.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_help_input.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_help_input.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txt_help_input.Size = new System.Drawing.Size(212, 42);
            this.txt_help_input.TabIndex = 20;
            this.txt_help_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComditionFilter_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "页码F1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "助记码F3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "定价F2:";
            // 
            // ComditionFilter
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(322, 245);
            this.Controls.Add(this.txt_priod_id);
            this.Controls.Add(this.txt_output_price);
            this.Controls.Add(this.txt_help_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComditionFilter";
            this.Text = "条件过滤";
            this.Load += new System.EventHandler(this.ComditionFilter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComditionFilter_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txt_priod_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_output_price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_help_input.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_help_input.Text) || !string.IsNullOrWhiteSpace(txt_output_price.Text) || !string.IsNullOrWhiteSpace(txt_priod_id.Text))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void ComditionFilter_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F2)
            {
                txt_output_price.Focus();
            }
            if (e.KeyCode == System.Windows.Forms.Keys.F1)
            {
                txt_priod_id.Focus();
            }
            if (e.KeyCode == System.Windows.Forms.Keys.F3)
            {
                txt_help_input.Focus();
            }
        }

        private void ComditionFilter_Load(object sender, EventArgs e)
        {
            this.txt_output_price.Focus();
        }

      
    }
}
