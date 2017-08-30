using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Erp.Base.Entity;
using System.Data;
using System.ComponentModel;
using WHC.Framework.ControlUtil;
using WHC.Framework.Commons;

namespace Erp.Base.UI
{
    public class SelectInfo<T> : BaseForm
        where T : new()
    {
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private List<T> objectList = new List<T>();
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private string selecedId = string.Empty;
        private DataTable objectdt = new DataTable();
        public string SelecedId
        {
            get { return selecedId; }
            set { selecedId = value; }
        }
    

        public DataTable Objectdt
        {
            get { return objectdt; }
            set { objectdt = value; }
        }




        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<T> ObjectList
        {
            get { return objectList; }
            set { objectList = value; }
        }

        public SelectInfo()
        {
            InitializeComponent();
            if (!DesignMode)
            {

                this.winGridView1.ColumnNameAlias.Add("OBJECT_ID", "编号");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_DEPARTMENT", "名称");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_C_NAME", "类别");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_O_NAME", "主管业务");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_JB_NAME", "级别");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_STATION_NAME", "所属站点");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_HELP_INPUT", "助记码");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_LEVEL", "是否有效");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_SELECT", "选择");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_ADRESS", "地址");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_CONTACT_MAN", "联系人");
                this.winGridView1.ColumnNameAlias.Add("OBJECT_ZIP", "邮编");
                this.winGridView1.BestFitColumnWith = false;
                this.winGridView1.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Pink;
                this.winGridView1.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                this.winGridView1.GridView1.OptionsSelection.MultiSelect = true;
                winGridView1.GridView1.OptionsBehavior.Editable = false;
                winGridView1.GridView1.OptionsBehavior.ReadOnly = false;
                winGridView1.GridView1.OptionsSelection.MultiSelect = false;
                winGridView1.GridView1.DoubleClick += GridView1_DoubleClick;

            }
        }

        void GridView1_DoubleClick(object sender, EventArgs e)
        {   
             btn_OK_Click(sender, e);
        }

        private void InitializeComponent()
        {
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // winGridView1
            // 
            this.winGridView1.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.winGridView1.Appearance.Options.UseBackColor = true;
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.winGridView1.EnableEdit = false;
            this.winGridView1.EnableMenu = true;
            this.winGridView1.HaveProduct = false;
            this.winGridView1.Location = new System.Drawing.Point(0, 0);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.Padding = new System.Windows.Forms.Padding(2);
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(900, 495);
            this.winGridView1.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(313, 514);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "确定(&O)";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(445, 514);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "取消(&C)";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // SelectInfo
            // 
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.winGridView1);
            this.Name = "SelectInfo";
            this.ShowInTaskbar = false;
            this.Text = "选择对象";
            this.Load += new System.EventHandler(this.SelectClientInfo_Load);
            this.ResumeLayout(false);

        }

        private void SelectClientInfo_Load(object sender, EventArgs e)
        {
            if (this.objectdt != null)
            {
                if (this.objectdt.Rows.Count == 0)
                {
                    this.Close();
                }
                else
                {
                    this.winGridView1.DataSource = this.objectdt;// new WHC.Pager.WinControl.SortableBindingList<SimpleProductInfo>(this.productList);

                }
            }
          
        }

      


        private void btn_OK_Click(object sender, EventArgs e)
        {  
            if(this.winGridView1.gridView1.RowCount>0)
            {
             selecedId = this.winGridView1.gridView1.GetFocusedRowCellValue("OBJECT_ID").ToString();
             this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.ObjectList = null;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
 

        }

      
    }
}
