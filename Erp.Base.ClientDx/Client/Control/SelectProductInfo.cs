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
    public class SelectProductInfo : BaseForm
    {
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WHC.Pager.WinControl.WinGridView SelectProductView;
        private bool StockFilter = false;
        private bool ConditionFilter = false;
        private List<SimpleProductInfo> productList = new List<SimpleProductInfo>();
        private List<SimpleProductInfo> selectedList = new List<SimpleProductInfo>();
        private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private ProductDisplay productDisplay1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnUnifyAmount;
        private DevExpress.XtraEditors.SimpleButton btnStock;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.CheckEdit ck_auto_filtration;
        private DevExpress.XtraEditors.CheckEdit ck_order_effictive;
        private DevExpress.XtraEditors.SimpleButton btn_allcheck;
        private DevExpress.XtraEditors.SimpleButton btn_cancel_check;
        private int selectOrder = 1;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<SimpleProductInfo> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<SimpleProductInfo> SelectedList
        {
            get { return selectedList; }
            set { selectedList = value; }
        }

        /// <summary>
        /// 获取选择项并排序
        /// </summary>
        private void GetSelect()
        {
            this.selectedList.Clear();
            List<SimpleProductInfo> list = ((List<SimpleProductInfo>)SelectProductView.GridView1.DataSource);

            if (ck_order_effictive.Checked)
            {
                try
                {
                    IEnumerable<SimpleProductInfo> items =
                        from selecteditem in list
                        where selecteditem.Selected
                        orderby selecteditem.Sort_number ascending
                        select selecteditem;

                    this.selectedList = items.ToList<SimpleProductInfo>();
                }
                catch (Exception ex)
                {
                    MessageDxUtil.ShowError(ex.Message);
                }
            }
            else
            {
                IEnumerable<SimpleProductInfo> items =
                        from selecteditem in list
                        where selecteditem.Selected
                        select selecteditem;
                this.selectedList = items.ToList<SimpleProductInfo>();
            }
        }
        public SelectProductInfo()
        {
            InitializeComponent();
            this.Load += SelectProductInfo_Load;
            this.Shown += SelectProductInfo_Shown;
            this.FormClosing += SelectProductInfo_FormClosing;
            if (!DesignMode)
            {
                this.SelectProductView.ReadOnlyList.Add("Sort_number");
                this.SelectProductView.ReadOnlyList.Add("H_isbn");
                this.SelectProductView.ReadOnlyList.Add("Stock_amount");
                this.SelectProductView.ReadOnlyList.Add("H_name");
                this.SelectProductView.ReadOnlyList.Add("H_output_price");
                this.SelectProductView.ReadOnlyList.Add("H_input_date");
                this.SelectProductView.ReadOnlyList.Add("Pubname");
                this.SelectProductView.FormatString.Add("H_output_price", "{0:c2}");
                this.SelectProductView.FormatString.Add("H_input_date", "{0:yyyy-MM-dd HH:mm:ss}");
                this.SelectProductView.DisplayColumns = "Selected,H_amount,h_isbn,stock_amount,h_name,h_output_price,pubname,h_input_date,sort_number";
                this.SelectProductView.ColumnNameAlias.Add("H_AMOUNT", "数量");
                this.SelectProductView.ColumnNameAlias.Add("SELECTED", "选择");
                this.SelectProductView.ColumnNameAlias.Add("H_ISBN", "书号");
                this.SelectProductView.ColumnNameAlias.Add("STOCK_AMOUNT", "库存");
                this.SelectProductView.ColumnNameAlias.Add("H_NAME", "商品名称");
                this.SelectProductView.ColumnNameAlias.Add("H_OUTPUT_PRICE", "定价");
                this.SelectProductView.ColumnNameAlias.Add("PUBNAME", "版别");
                this.SelectProductView.ColumnNameAlias.Add("SORT_NUMBER", "顺序");
                this.SelectProductView.ColumnNameAlias.Add("H_INPUT_DATE", "建档日期");
                this.SelectProductView.BestFitColumnWith = false;
                this.SelectProductView.GridView1.Appearance.Row.Font = new System.Drawing.Font("Arial", 12);
                this.SelectProductView.GridView1.CellValueChanged += GridView1_CellValueChanged;
                this.SelectProductView.GridView1.RowCellClick += GridView1_RowCellClick;
                this.SelectProductView.GridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
                this.SelectProductView.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Pink;
                this.SelectProductView.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                this.SelectProductView.GridView1.OptionsSelection.MultiSelect = true;
                SelectProductView.EnableEdit = true;
                this.SelectProductView.GridView1.RowHeight = 25;

            }
        }

        private void SelectProductInfo_Shown(object sender, EventArgs e)
        {
            if (this.ck_auto_filtration.Checked)
            {
                this.btnFilter_Click(this.btnFilter, new EventArgs());
            }
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SimpleProductInfo info = (SimpleProductInfo)SelectProductView.GridView1.GetRow(e.FocusedRowHandle);
            productDisplay1.CurrentProduct = info;
        }

        private void GridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName != "Selected")
            {
                if (((SimpleProductInfo)SelectProductView.GridView1.GetRow(e.RowHandle)).Selected)
                {
                    SelectProductView.GridView1.SetRowCellValue(e.RowHandle, "H_amount", 0);
                }
                else
                {
                    SelectProductView.GridView1.SetRowCellValue(e.RowHandle, "H_amount", 1);
                }
            }
        }

        private void UpdateSelectOrder(int RowHandle)
        {
            SelectProductView.GridView1.SetRowCellValue(RowHandle, "Sort_number", selectOrder++);
            SelectProductView.GridView1.UpdateCurrentRow();
        }

        private void ClearSelectOrder(int RowHandle)
        {
            SelectProductView.GridView1.SetRowCellValue(RowHandle, "Sort_number", 0);
            SelectProductView.GridView1.UpdateCurrentRow();
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "H_amount")
            {
                if (Convert.ToInt32(e.Value) > 0)
                {
                    SelectProductView.GridView1.SetRowCellValue(e.RowHandle, "Selected", true);
                }
                else
                {
                    SelectProductView.GridView1.SetRowCellValue(e.RowHandle, "Selected", false);
                }
            }
            if (e.Column.FieldName == "Selected")
            {
                if (Convert.ToBoolean(e.Value))
                {
                    UpdateSelectOrder(e.RowHandle);
                }
                else
                {
                    ClearSelectOrder(e.RowHandle);
                }
            }
        }






        private void DisplayFormat()
        {
            try
            {
                this.SelectProductView.GridView1.Columns["H_amount"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.SelectProductView.GridView1.Columns["H_amount"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.SelectProductView.GridView1.Columns["Selected"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.SelectProductView.GridView1.Columns["Stock_amount"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.SelectProductView.GridView1.Columns["Stock_amount"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.SelectProductView.GridView1.Columns["Sort_number"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.SelectProductView.GridView1.Columns["Sort_number"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                DevExpress.XtraGrid.StyleFormatCondition cn;
                cn = new DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Equal, this.SelectProductView.GridView1.Columns["Selected"], true, true, true, true);
                cn.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
                this.SelectProductView.GridView1.FormatConditions.Add(cn);
                this.SelectProductView.GridView1.Columns["Selected"].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;

                DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit h_name = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit h_isbn = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit pub_name = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit input_date = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                SelectProductView.GridView1.Columns["H_name"].ColumnEdit = h_name;
                SelectProductView.GridView1.Columns["H_isbn"].ColumnEdit = h_isbn;
                SelectProductView.GridView1.Columns["Pub_id"].ColumnEdit = pub_name;
                SelectProductView.GridView1.Columns["H_input_date"].ColumnEdit = input_date;
                this.SelectProductView.GridView1.OptionsView.RowAutoHeight = true;

            }
            catch (Exception)
            {
            }
        }

        private void SelectProductInfo_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.SelectProductView.SaveGridParm();
        }

        private void SelectProductInfo_Load(object sender, EventArgs e)
        {
            if (this.productList != null)
            {
                if (this.productList.Count == 0)
                {
                    this.Close();
                }
                else
                {
                    this.SelectProductView.DataSource = this.productList;// new WHC.Pager.WinControl.SortableBindingList<SimpleProductInfo>(this.productList);
                    this.DisplayFormat();

                }
            }
            if (iniFile.IniReadValue(this.Name, "AutoFiltr") == Boolean.TrueString)
            {
                this.ck_auto_filtration.Checked = true;
            }
            else
            {
                ck_auto_filtration.Checked = false;
            }
            if (iniFile.IniReadValue(this.Name, "Order_Effictive") == Boolean.TrueString)
            {
                this.ck_order_effictive.Checked = true;
            }
            else
            {
                ck_order_effictive.Checked = false;
            }
        }

        private void InitializeComponent()
        {
            Erp.Base.Entity.SimpleProductInfo simpleProductInfo1 = new Erp.Base.Entity.SimpleProductInfo();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnifyAmount = new DevExpress.XtraEditors.SimpleButton();
            this.btnStock = new DevExpress.XtraEditors.SimpleButton();
            this.btn_allcheck = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel_check = new DevExpress.XtraEditors.SimpleButton();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.ck_auto_filtration = new DevExpress.XtraEditors.CheckEdit();
            this.ck_order_effictive = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.productDisplay1 = new Erp.Base.UI.ProductDisplay();
            this.SelectProductView = new WHC.Pager.WinControl.WinGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_auto_filtration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_order_effictive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnOK);
            this.panelControl2.Controls.Add(this.btnUnifyAmount);
            this.panelControl2.Controls.Add(this.btnStock);
            this.panelControl2.Controls.Add(this.btn_allcheck);
            this.panelControl2.Controls.Add(this.btn_cancel_check);
            this.panelControl2.Controls.Add(this.btnFilter);
            this.panelControl2.Controls.Add(this.ck_auto_filtration);
            this.panelControl2.Controls.Add(this.ck_order_effictive);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 509);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1004, 51);
            this.panelControl2.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(827, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(905, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 90;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnUnifyAmount
            // 
            this.btnUnifyAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnifyAmount.Location = new System.Drawing.Point(749, 16);
            this.btnUnifyAmount.Name = "btnUnifyAmount";
            this.btnUnifyAmount.Size = new System.Drawing.Size(75, 22);
            this.btnUnifyAmount.TabIndex = 70;
            this.btnUnifyAmount.Text = "统一数量(&T)";
            this.btnUnifyAmount.Click += new System.EventHandler(this.btnUnifyAmount_Click);
            // 
            // btnStock
            // 
            this.btnStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStock.Location = new System.Drawing.Point(671, 16);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(75, 22);
            this.btnStock.TabIndex = 60;
            this.btnStock.Text = "库存过滤(&S)";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btn_allcheck
            // 
            this.btn_allcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_allcheck.Location = new System.Drawing.Point(437, 16);
            this.btn_allcheck.Name = "btn_allcheck";
            this.btn_allcheck.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_allcheck.Size = new System.Drawing.Size(75, 22);
            this.btn_allcheck.TabIndex = 30;
            this.btn_allcheck.Text = "全选(&A)";
            this.btn_allcheck.Click += new System.EventHandler(this.btnAllSelect_Click);
            // 
            // btn_cancel_check
            // 
            this.btn_cancel_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_check.Location = new System.Drawing.Point(515, 16);
            this.btn_cancel_check.Name = "btn_cancel_check";
            this.btn_cancel_check.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_cancel_check.Size = new System.Drawing.Size(75, 22);
            this.btn_cancel_check.TabIndex = 40;
            this.btn_cancel_check.Text = "全不选(&B)";
            this.btn_cancel_check.Click += new System.EventHandler(this.btn_cancel_check_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(593, 16);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnFilter.Size = new System.Drawing.Size(75, 22);
            this.btnFilter.TabIndex = 50;
            this.btnFilter.Text = "条件过滤(&E)";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ck_auto_filtration
            // 
            this.ck_auto_filtration.Location = new System.Drawing.Point(114, 18);
            this.ck_auto_filtration.Name = "ck_auto_filtration";
            this.ck_auto_filtration.Properties.Caption = "自动过滤(&F)";
            this.ck_auto_filtration.Size = new System.Drawing.Size(109, 19);
            this.ck_auto_filtration.TabIndex = 20;
            this.ck_auto_filtration.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // ck_order_effictive
            // 
            this.ck_order_effictive.Location = new System.Drawing.Point(12, 18);
            this.ck_order_effictive.Name = "ck_order_effictive";
            this.ck_order_effictive.Properties.Caption = "顺序有效(&R)";
            this.ck_order_effictive.Size = new System.Drawing.Size(96, 19);
            this.ck_order_effictive.TabIndex = 10;
            this.ck_order_effictive.CheckedChanged += new System.EventHandler(this.ck_order_effictive_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.AlwaysScrollActiveControlIntoView = false;
            this.panelControl1.Controls.Add(this.productDisplay1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1004, 62);
            this.panelControl1.TabIndex = 4;
            // 
            // productDisplay1
            // 
            simpleProductInfo1.Avoid_flag = "1";
            simpleProductInfo1.CurrentLoginUserId = null;
            simpleProductInfo1.Discount_hy = new decimal(new int[] {
            0,
            0,
            0,
            0});
            simpleProductInfo1.Discount_ls = new decimal(new int[] {
            0,
            0,
            0,
            0});
            simpleProductInfo1.Discount_px = new decimal(new int[] {
            0,
            0,
            0,
            0});
            simpleProductInfo1.H_amount = 0;
            simpleProductInfo1.H_exist = null;
            simpleProductInfo1.H_factory = null;
            simpleProductInfo1.H_id = null;
            simpleProductInfo1.H_input_date = new System.DateTime(2014, 5, 24, 13, 57, 57, 868);
            simpleProductInfo1.H_input_price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            simpleProductInfo1.H_isbn = null;
            simpleProductInfo1.H_mytm = "无";
            simpleProductInfo1.H_name = null;
            simpleProductInfo1.H_output_price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            simpleProductInfo1.H_period_id = null;
            simpleProductInfo1.H_publish_date = new System.DateTime(((long)(0)));
            simpleProductInfo1.Hy_price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            simpleProductInfo1.My_help_input = null;
            simpleProductInfo1.Price_ls = new decimal(new int[] {
            0,
            0,
            0,
            0});
            simpleProductInfo1.Price_px = new decimal(new int[] {
            0,
            0,
            0,
            0});
            simpleProductInfo1.Pub_id = null;
            simpleProductInfo1.Selected = false;
            simpleProductInfo1.Sort_number = 0;
            simpleProductInfo1.Stock_amount = 0;
            simpleProductInfo1.U_id = null;
            this.productDisplay1.CurrentProduct = simpleProductInfo1;
            this.productDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDisplay1.Location = new System.Drawing.Point(2, 2);
            this.productDisplay1.Name = "productDisplay1";
            this.productDisplay1.Size = new System.Drawing.Size(1000, 58);
            this.productDisplay1.TabIndex = 0;
            // 
            // SelectProductView
            // 
            this.SelectProductView.Appearance.Font = new System.Drawing.Font("Courier New", 9F);
            this.SelectProductView.Appearance.Options.UseFont = true;
            this.SelectProductView.AppendedMenu = null;
            this.SelectProductView.DataSource = null;
            this.SelectProductView.DisplayColumns = "";
            this.SelectProductView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectProductView.EnableEdit = false;
            this.SelectProductView.EnableMenu = true;
            this.SelectProductView.HaveProduct = false;
            this.SelectProductView.Location = new System.Drawing.Point(0, 62);
            this.SelectProductView.Name = "SelectProductView";
            this.SelectProductView.PrintTitle = "";
            this.SelectProductView.ShowAddMenu = false;
            this.SelectProductView.ShowCheckBox = false;
            this.SelectProductView.ShowDeleteMenu = false;
            this.SelectProductView.ShowEditMenu = false;
            this.SelectProductView.ShowExportButton = false;
            this.SelectProductView.Size = new System.Drawing.Size(1004, 447);
            this.SelectProductView.TabIndex = 1;
            this.SelectProductView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectProductView_KeyDown);
            // 
            // SelectProductInfo
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1004, 560);
            this.Controls.Add(this.SelectProductView);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.KeyPreview = true;
            this.Name = "SelectProductInfo";
            this.ShowInTaskbar = false;
            this.Text = "选择重复商品";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectProductView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ck_auto_filtration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_order_effictive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            GetSelect();
            this.Close();
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            iniFile.IniWriteValue(this.Name, "AutoFiltr", this.ck_auto_filtration.Checked.ToString());
        }

        private void btnAllSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.SelectProductView.gridView1.DataRowCount; i++)
            {
                int amount=Convert.ToInt32(this.SelectProductView.GridView1.GetRowCellValue(i,"H_amount"));
                if (amount<=0)
                {
                    this.SelectProductView.gridView1.SetRowCellValue(i, "H_amount", 1);
                }
                
            }
        }

        private void btn_cancel_check_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.SelectProductView.gridView1.DataRowCount; i++)
            {
                this.SelectProductView.gridView1.SetRowCellValue(i, "H_amount", 0);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ComditionFilter f = new ComditionFilter();
            List<SimpleProductInfo> list = (List<SimpleProductInfo>)this.SelectProductView.GridView1.DataSource;
            if (!ConditionFilter)
            {
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string helpinput = f.WhereText_HelpInput;
                    string outputprice = f.WhereText_OutPrice;
                    string periodid = f.WhereText_PriodId;
                    var filterList = from item in list
                                     where item.My_help_input == Check(item.My_help_input, helpinput)
                                          && item.H_output_price == Check(item.H_output_price, outputprice)
                                          && item.H_period_id == Check(item.H_period_id, periodid)
                                     select item;
                    this.SelectProductView.DataSource = filterList.ToList<SimpleProductInfo>();
                    this.btnFilter.Text = "取消过滤(&C)";
                    this.ConditionFilter = true;
                }
            }
            else
            {
                this.SelectProductView.DataSource = null;
                this.SelectProductView.DataSource = productList;
                this.btnFilter.Text = "条件过滤(&C)";
                this.ConditionFilter = false;
            }
            DisplayFormat();
        }

        private string Check(string ItemValue, string WhereValue)
        {
            return string.IsNullOrWhiteSpace(WhereValue) ? ItemValue : WhereValue;
        }
        private decimal Check(decimal ItemValue, string WhereValue)
        {
            return string.IsNullOrWhiteSpace(WhereValue) ? ItemValue : WhereValue.ToDecimal();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            List<SimpleProductInfo> list = (List<SimpleProductInfo>)SelectProductView.GridView1.DataSource;
            if (!StockFilter)
            {
                IEnumerable<SimpleProductInfo> items =
                              from selecteditem in list
                              where selecteditem.Stock_amount > 0
                              select selecteditem;
                this.SelectProductView.DataSource = items.ToList<SimpleProductInfo>();
                this.btnStock.Text = "取消过滤(&S)";
                this.StockFilter = true;
            }
            else
            {
                this.SelectProductView.DataSource = null;
                this.SelectProductView.DataSource = productList;
                this.btnStock.Text = "库存过滤(&S)";
                this.StockFilter = false;

            }
            DisplayFormat();
        }

        private void btnUnifyAmount_Click(object sender, EventArgs e)
        {
            int amount = InputAmount.GetNumber();
            if ( amount> 0)
            {
                for (int i = 0; i < this.SelectProductView.gridView1.DataRowCount; i++)
                {
                    this.SelectProductView.gridView1.SetRowCellValue(i, "H_amount", amount);
                }

            }
        }

        private void ck_order_effictive_CheckedChanged(object sender, EventArgs e)
        {
            iniFile.IniWriteValue(this.Name, "Order_Effictive", this.ck_order_effictive.Checked.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.selectedList.Clear();
            this.Close();
        }

        private void SelectProductView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Space)
            {
                if (this.SelectProductView.GridView1.RowCount > 0)
                {
                    if (((SimpleProductInfo)this.SelectProductView.GridView1.GetFocusedRow()).Selected)
                    {
                        this.SelectProductView.GridView1.SetFocusedRowCellValue("H_amount", 0);
                    }
                    else
                    {
                        this.SelectProductView.GridView1.SetFocusedRowCellValue("H_amount", 1);
                    }
                }
            }
        }
    }
}
