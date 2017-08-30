using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Erp.Base.Entity;
using System.Data;


namespace Erp.Base.UI
{
    /// <summary>
    /// 显示重复商品
    /// </summary>
    public class FrmShowRepeatProductInfo:BaseForm
    {
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DataTable productList = new DataTable();
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private SimpleProductInfo selectProduct = new SimpleProductInfo();
        private string selecedId = string.Empty;

        public string SelecedId
        {
            get { return selecedId; }
            set { selecedId = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SimpleProductInfo SelectProduct
        {
            get { return selectProduct; }
            set { selectProduct = value; }
        }


        [DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden)]
        public DataTable ProductList
        {
            get { return productList; }
            set { productList = value; }
        }

        public FrmShowRepeatProductInfo()
        {
            InitializeComponent();
        }
    
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            this.panelControl1.Location = new System.Drawing.Point(8, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(653, 368);
            this.panelControl1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(244, 397);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "复制(&C)";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&E)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.Location = new System.Drawing.Point(2, 2);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(649, 364);
            this.winGridView1.TabIndex = 0;
            // 
            // FrmShowRepeatProductInfo
            // 
            this.ClientSize = new System.Drawing.Size(667, 432);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowRepeatProductInfo";
            this.Text = "查看重复商品";
            this.Load += new System.EventHandler(this.FrmShowRepeatProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.winGridView1.gridView1.RowCount > 0) 
            {
                selecedId = this.winGridView1.gridView1.GetFocusedRowCellValue("唯一码").ToString();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectProduct = null;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FrmShowRepeatProductInfo_Load(object sender, EventArgs e)
        {
            this.winGridView1.DataSource = this.productList;
            
        }
    }
}
