using POSS.BLL;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;

namespace POSS
{
    public class Product_price : BaseDockQuery
    {

        #region 变量
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit t_name;
        private DevExpress.XtraEditors.TextEdit t_isbn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit t_type;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit t_fa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DateTimeControl t_input_date;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        List<ProductPicerQuery> Productlist = new List<ProductPicerQuery>();
        public Product_price()
        {
            InitializeComponent();
            this.Load += Product_price_Load;
            this.winGridView1.GridView1.CellValueChanged += GridView1_CellValueChanged; 
            this.winGridView1.GridView1.CustomDrawCell += GridView1_CustomDrawCell;
            this.winGridView1.GridView1.CustomColumnDisplayText += GridView1_CustomColumnDisplayText;
            this.winGridView1.ShowBianSe = false;
            this.winGridView1.ShowBianSe2 = false;
            winGridView1.gridView1.OptionsCustomization.AllowSort = false;



        }

        private void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "CIs_clents_dis" && e.Value!=null)
            {
                if (e.Value.ToString() == "0")
                {
                    e.DisplayText = "是多会员折扣";
                    
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }

        private void GridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "CH_output_Price_ls")
            {
                e.Appearance.BackColor = Color.Coral;
            }
            if (e.Column.FieldName == "CH_output_Price_member_ls")
            {
                e.Appearance.BackColor = Color.Azure;
            }
            if (e.Column.FieldName == "CIs_clents_dis" && e.CellValue.ToString()!="" )
            {
                e.Appearance.BackColor = Color.GreenYellow;
            }
           
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "CH_output_Price_ls")//用户修改定价
            {
                decimal price = this.winGridView1.GridView1.GetRowCellValue(e.RowHandle, "CH_output_price").ToString().ToDecimal();
                decimal discount = this.winGridView1.GridView1.GetRowCellValue(e.RowHandle, "CH_output_Price_ls").ToString().ToDecimal();
                string h_id = this.winGridView1.GridView1.GetRowCellValue(e.RowHandle, "CH_id").ToString();
                decimal discounts = discount / price;
                if (BLLFactory<Product>.Instance.UpdatePicer(discounts, h_id))
                {
                    winGridView1.GridView1.SetRowCellValue(e.RowHandle, "CH_output_discount_ls", discounts);
                }
            }
            if (e.Column.FieldName == "CH_output_Price_member_ls")//用户修改定价
            {
                decimal price = this.winGridView1.GridView1.GetRowCellValue(e.RowHandle, "CH_output_price").ToString().ToDecimal();
                decimal discount = this.winGridView1.GridView1.GetRowCellValue(e.RowHandle, "CH_output_Price_member_ls").ToString().ToDecimal();
                string h_id = this.winGridView1.GridView1.GetRowCellValue(e.RowHandle, "CH_id").ToString();
                decimal discounts = discount / price;
                if (BLLFactory<Product>.Instance.UpdatePicerToMerber(discounts, h_id))
                {
                    winGridView1.GridView1.SetRowCellValue(e.RowHandle, "CH_output_discount_member_ls", discounts);
                }
            }
        }

        private void Product_price_Load(object sender, EventArgs e)
        {
            SetDisplayColumn();
            AddGridViewReadOnly();
            AddColumnAlias();
            this.winGridView1.TextHorzAlignment.Add("CIs_clents_dis", DevExpress.Utils.HorzAlignment.Center);
            SetDripDownitem();
            SetDataSource();
           

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.t_input_date = new POSS.DateTimeControl();
            this.t_name = new DevExpress.XtraEditors.TextEdit();
            this.t_isbn = new DevExpress.XtraEditors.TextEdit();
            this.t_type = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.t_fa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButton)).BeginInit();
            this.PanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCondition)).BeginInit();
            this.PanelCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelDisplayCondition)).BeginInit();
            this.PanelDisplayCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_isbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_fa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.simpleButton2);
            this.PanelButton.Controls.Add(this.simpleButton1);
            this.PanelButton.Location = new System.Drawing.Point(900, 0);
            this.PanelButton.Size = new System.Drawing.Size(362, 86);
            this.PanelButton.Controls.SetChildIndex(this.btnQuery, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnReset, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnPrint, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnExport, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnAdd, 0);
            this.PanelButton.Controls.SetChildIndex(this.btnExit, 0);
            this.PanelButton.Controls.SetChildIndex(this.simpleButton1, 0);
            this.PanelButton.Controls.SetChildIndex(this.simpleButton2, 0);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(895, 0);
            this.splitterControl1.Size = new System.Drawing.Size(5, 86);
            // 
            // PanelCondition
            // 
            this.PanelCondition.Controls.Add(this.panelControl2);
            this.PanelCondition.Size = new System.Drawing.Size(895, 86);
            // 
            // PanelDisplayCondition
            // 
            this.PanelDisplayCondition.Size = new System.Drawing.Size(1262, 40);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(87, 44);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(202, 76);
            this.btnAdd.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(272, 75);
            this.btnExport.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 44);
            // 
            // btnQuery
            // 
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click_1);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Size = new System.Drawing.Size(1262, 463);
            // 
            // LabelCondition
            // 
            this.LabelCondition.Size = new System.Drawing.Size(1258, 36);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(1262, 599);
            this.splitContainerControl1.SplitterPosition = 86;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.layoutControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(895, 86);
            this.panelControl2.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.t_input_date);
            this.layoutControl1.Controls.Add(this.t_name);
            this.layoutControl1.Controls.Add(this.t_isbn);
            this.layoutControl1.Controls.Add(this.t_type);
            this.layoutControl1.Controls.Add(this.t_fa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(891, 82);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // t_input_date
            // 
            this.t_input_date.ChineseColumnName = null;
            this.t_input_date.ColumnName = null;
            this.t_input_date.EndDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.t_input_date.Location = new System.Drawing.Point(75, 36);
            this.t_input_date.Name = "t_input_date";
            this.t_input_date.Size = new System.Drawing.Size(804, 34);
            this.t_input_date.TabIndex = 8;
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(716, 12);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(163, 20);
            this.t_name.StyleController = this.layoutControl1;
            this.t_name.TabIndex = 5;
            // 
            // t_isbn
            // 
            this.t_isbn.Location = new System.Drawing.Point(75, 12);
            this.t_isbn.Name = "t_isbn";
            this.t_isbn.Size = new System.Drawing.Size(126, 20);
            this.t_isbn.StyleController = this.layoutControl1;
            this.t_isbn.TabIndex = 4;
            // 
            // t_type
            // 
            this.t_type.Location = new System.Drawing.Point(268, 12);
            this.t_type.Name = "t_type";
            this.t_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.t_type.Properties.NullText = "";
            this.t_type.Properties.PopupSizeable = false;
            this.t_type.Properties.View = this.searchLookUpEdit1View;
            this.t_type.Size = new System.Drawing.Size(139, 20);
            this.t_type.StyleController = this.layoutControl1;
            this.t_type.TabIndex = 6;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // t_fa
            // 
            this.t_fa.Location = new System.Drawing.Point(474, 12);
            this.t_fa.Name = "t_fa";
            this.t_fa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.t_fa.Properties.NullText = "";
            this.t_fa.Properties.PopupSizeable = false;
            this.t_fa.Properties.View = this.gridView1;
            this.t_fa.Size = new System.Drawing.Size(175, 20);
            this.t_fa.StyleController = this.layoutControl1;
            this.t_fa.TabIndex = 7;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(891, 82);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.t_isbn;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(193, 24);
            this.layoutControlItem1.Text = "书号：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.t_name;
            this.layoutControlItem2.Location = new System.Drawing.Point(641, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem2.Text = "书名：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.t_type;
            this.layoutControlItem3.Location = new System.Drawing.Point(193, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(206, 24);
            this.layoutControlItem3.Text = "商品类别：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.t_fa;
            this.layoutControlItem4.Location = new System.Drawing.Point(399, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(242, 24);
            this.layoutControlItem4.Text = "货源：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.t_input_date;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(871, 38);
            this.layoutControlItem5.Text = "建档日期：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.winGridView1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1262, 463);
            this.panelControl3.TabIndex = 0;
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.EnableEdit = true;
            this.winGridView1.EnableMenu = true;
            this.winGridView1.HaveProduct = false;
            this.winGridView1.Location = new System.Drawing.Point(2, 2);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = false;
            this.winGridView1.ShowBianSe = true;
            this.winGridView1.ShowBianSe2 = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = false;
            this.winGridView1.ShowEditMenu = false;
            this.winGridView1.ShowExportButton = false;
            this.winGridView1.Size = new System.Drawing.Size(1258, 459);
            this.winGridView1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(169, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "设置一书多会员折扣";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(169, 44);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(120, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "删除一书多会员品种";
            // 
            // Product_price
            // 
            this.ClientSize = new System.Drawing.Size(1262, 599);
            this.Name = "Product_price";
            this.Text = "定价算折扣";
            ((System.ComponentModel.ISupportInitialize)(this.PanelButton)).EndInit();
            this.PanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelCondition)).EndInit();
            this.PanelCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelDisplayCondition)).EndInit();
            this.PanelDisplayCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_isbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_fa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SetDisplayColumn()
        {
            this.winGridView1.DisplayColumns = "CH_id,CH_isbn,CH_name,CPub_name,CH_type,CH_factory,CH_output_price,CH_output_discount_ls,CH_output_Price_ls,CH_output_discount_member_ls,CH_output_Price_member_ls,CIs_clents_dis";
        }

        private void AddColumnAlias()
        {
            winGridView1.AddColumnAlias("CH_id", "商品唯一码");
            winGridView1.AddColumnAlias("CH_isbn", "书号");
            winGridView1.AddColumnAlias("CH_name", "书名");
            winGridView1.AddColumnAlias("CPub_name", "出版社");
            winGridView1.AddColumnAlias("CH_type", "商品分类");
            winGridView1.AddColumnAlias("CH_factory", "货源");
            winGridView1.AddColumnAlias("CH_output_discount_ls", "零售折扣");
            winGridView1.AddColumnAlias("CH_output_price", "定价");
            winGridView1.AddColumnAlias("CH_output_Price_ls", "零售折后价");
            winGridView1.AddColumnAlias("CH_output_Price_member_ls", "会员折后价");
            winGridView1.AddColumnAlias("CH_output_discount_member_ls", "会员折扣"); 
            winGridView1.AddColumnAlias("CIs_clents_dis", "是否有一书多会员折扣");
        }
        private void AddGridViewReadOnly()
        {
            this.winGridView1.ReadOnlyList.Add("CH_id");
            this.winGridView1.ReadOnlyList.Add("CH_isbn");
            this.winGridView1.ReadOnlyList.Add("CH_name");
            this.winGridView1.ReadOnlyList.Add("CPub_name");
            this.winGridView1.ReadOnlyList.Add("CH_type");
            this.winGridView1.ReadOnlyList.Add("CH_factory");
            this.winGridView1.ReadOnlyList.Add("CH_output_discount_member_ls");
            this.winGridView1.ReadOnlyList.Add("CH_output_discount_ls");

            this.winGridView1.ReadOnlyList.Add("CH_output_price");
            this.winGridView1.ReadOnlyList.Add("CIs_clents_dis");



        }
        private void SetDataSource()
        {
            this.winGridView1.DataSource = Productlist;

            SetDisplayFormat();
        }
        private void SetDisplayFormat()
        {

            winGridView1.GridView1.Columns["CH_output_price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["CH_output_price"].DisplayFormat.FormatString = "c2";
            winGridView1.GridView1.Columns["CH_output_Price_ls"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["CH_output_Price_ls"].DisplayFormat.FormatString = "c2";
            winGridView1.GridView1.Columns["CH_output_Price_member_ls"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["CH_output_Price_member_ls"].DisplayFormat.FormatString = "c2";
            winGridView1.GridView1.Columns["CH_output_discount_ls"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["CH_output_discount_ls"].DisplayFormat.FormatString = "p2";
            winGridView1.GridView1.Columns["CH_output_discount_member_ls"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["CH_output_discount_member_ls"].DisplayFormat.FormatString = "p2";

            
        }
        public void SetDripDownitem()
        {

            this.t_type.Properties.DisplayMember = "显示值";
            this.t_type.Properties.ValueMember = "项目值";
            t_type.Properties.DataSource = BLLFactory<Product>.Instance.GetH_type();

            this.t_fa.Properties.DisplayMember = "显示值";
            this.t_fa.Properties.ValueMember = "项目值";
            t_fa.Properties.DataSource = BLLFactory<Product>.Instance.GetFactory();
        }

        private void btnQuery_Click_1(object sender, EventArgs e)
        {
            string SqlWheres = string.Empty;
            StringBuilder strSql = new StringBuilder();
            //string[] column = new string[4] { "H_isbn", "H_name", "H_factory", "H_type" };
            List<string> wheres = new List<string>();
            if (!string.IsNullOrEmpty(t_fa.Text.ToString()))
            {
                wheres.Add(" H_factory like '%" + t_fa.EditValue.ToString().Trim() + "%'");
            }
            if (!string.IsNullOrEmpty(t_isbn.Text.ToString()))
            {
                wheres.Add(" H_isbn like '" + t_isbn.Text.ToString().Trim() + "%'");
            }
            if (!string.IsNullOrEmpty(t_name.Text.ToString()))
            {
                wheres.Add(" H_name like '%" + t_name.Text.ToString().Trim() + "%'");
            }
            if (!string.IsNullOrEmpty(t_type.Text.ToString()))
            {
                wheres.Add(" H_type like '%" + t_type.EditValue.ToString().Trim() + "%'");
            }
            if (!string.IsNullOrEmpty(t_input_date.StartDate.ToString()))
            {
                wheres.Add(" H_Input_date between  '" + t_input_date.StartDate.ToString().Trim() + "' and '" + t_input_date.EndDate.ToString().Trim() + "'");
            }
            if (wheres.Count > 0)
            {
                string wh = string.Join(" and ", wheres.ToArray());
                //strSql.Append(" where " + wh);
                SqlWheres = wh.ToString();
            }

            Productlist.Clear();
            Productlist.AddRange(BLLFactory<Product>.Instance.GetPriductPicer(SqlWheres));
            this.winGridView1.GridView1.RefreshData();
            this.t_fa.Text = "";
            this.t_isbn.Text = "";
            this.t_name.Text = "";
            this.t_type.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            List<int> selectrow = this.winGridView1.GridView1.GetSelectedRows().ToList();
            if (selectrow.Count > 0)
            {
                DialogResult dr = MessagboxUit.ShowYesNoAndTips("是否把所选商品应用为“一书多会员折扣商品”?");
                if (dr == DialogResult.Yes)
                {
                    List<ProductPicerQuery> CheckProduct = new List<ProductPicerQuery>();
                    foreach (var item in selectrow)
                    {
                        
                        ProductPicerQuery checkprouuctinfo = Productlist[item];
                        if( BLLFactory<Product_discount_clientjb>.Instance.InsertProduct_clentjt(checkprouuctinfo.CH_id))
                        {
                            CheckProduct.Add(checkprouuctinfo);
                            BLLFactory<Product_discount_clientjb>.Instance.Update_Product_h_bak2(checkprouuctinfo.CH_id);//更新为一号多会员标志 用的书目资料里的h_bak2
                        }
                        
                    }
                    Member_TypeFrom f = new Member_TypeFrom();
                    f.CheckProductPrice = CheckProduct;
                    f.ShowDialog(this);

                }
            }
            else
            {
                MessagboxUit.ShowTips("请选择商品！！！");
            }

        }
    }
}
