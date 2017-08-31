using CCWin;
using DevExpress.XtraGrid.Views.Grid;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;

namespace POSS
{
   public class InputMoveProductInfo : BaseForm
    {
        #region 变量
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton bt_ok;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label_name;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.SimpleButton tb_gl;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tb_price;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;

        private void InitializeComponent()
        {
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label_name = new System.Windows.Forms.Label();
            this.bt_ok = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.tb_gl = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_price = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_price.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label_name);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(907, 61);
            this.panelControl2.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_name.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(2, 2);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 58);
            this.label_name.TabIndex = 0;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(657, 558);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "确 定";
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(788, 558);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "取 消";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 61);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(907, 471);
            this.panelControl1.TabIndex = 3;
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.EnableEdit = false;
            this.winGridView1.EnableMenu = false;
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
            this.winGridView1.Size = new System.Drawing.Size(903, 467);
            this.winGridView1.TabIndex = 0;
            // 
            // tb_gl
            // 
            this.tb_gl.Location = new System.Drawing.Point(466, 558);
            this.tb_gl.Name = "tb_gl";
            this.tb_gl.Size = new System.Drawing.Size(117, 23);
            this.tb_gl.TabIndex = 4;
            this.tb_gl.Text = "过虑无库存图书";
            this.tb_gl.Click += new System.EventHandler(this.tb_gl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "定价过滤：";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(320, 559);
            this.tb_price.Name = "tb_price";
            this.tb_price.Properties.Mask.EditMask = "n2";
            this.tb_price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tb_price.Size = new System.Drawing.Size(100, 20);
            this.tb_price.TabIndex = 6;
            this.tb_price.Enter += new System.EventHandler(this.tb_price_Enter);
            // 
            // InputMoveProductInfo
            // 
            this.ClientSize = new System.Drawing.Size(907, 595);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_gl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.panelControl2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputMoveProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "一书多号选择";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputMoveProductInfo_FormClosing);
            this.Load += new System.EventHandler(this.InputMoveProductInfo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputMoveProductInfo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_price.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private List<SimpleProductInfo> moveproductList = new List<SimpleProductInfo>();
        private List<SimpleProductInfo> moveselectedList = new List<SimpleProductInfo>();

        /// <summary>
        /// 接收多条书目LIST
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<SimpleProductInfo> MoveProductList
        {
            get { return moveproductList; }
            set { moveproductList = value; }
        }
        /// <summary>
        /// 返回选择list
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<SimpleProductInfo> MoveSelectedList
        {
            get { return moveselectedList; }
            set { moveselectedList = value; }
        }
        public InputMoveProductInfo()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
            this.winGridView1.EnableMenu = false;
            this.winGridView1.GridView1.RowHeight = 30;//收变列高度
            this.winGridView1.BestFitColumnWith = true;
            this.winGridView1.gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;//鼠标选择改变时
            this.winGridView1.gridView1.RowCellClick += GridView1_RowCellClick;//行点击事件
            this.winGridView1.gridView1.CustomDrawCell += GridView1_CustomDrawCell;//重新绘制列样式事件
            
            
        }

  

        #region 重新绘制列样式事件
        /// <summary>
        /// 重新绘制列样式事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            if ((int)winGridView1.GridView1.GetRowCellValue(e.RowHandle, "Stock_amount") == 0)//库存是否为0
            {
                e.Appearance.BackColor = System.Drawing.Color.Red;
                e.Appearance.ForeColor = System.Drawing.Color.Black;
                if ((Boolean)winGridView1.GridView1.GetRowCellValue(e.RowHandle, "Checked"))//是否选中
                {
                    e.Appearance.BackColor = System.Drawing.Color.Blue;
                    e.Appearance.ForeColor = System.Drawing.Color.White;
                }
                return;
            }
            else
            {
                if ((Boolean)winGridView1.GridView1.GetRowCellValue(e.RowHandle, "Checked"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Blue;
                    e.Appearance.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    e.Appearance.BackColor = System.Drawing.Color.Transparent;
                    e.Appearance.ForeColor = System.Drawing.Color.Black;
                }
            }

        }
        #endregion

        #region 行点击事件
        /// <summary>
        /// 行点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            bool k = false;
            k = (Boolean)winGridView1.GridView1.GetRowCellValue(e.RowHandle, "Checked");
            if (k)
            {
                winGridView1.GridView1.SetRowCellValue(e.RowHandle, "Checked", false);

            }
            else
            {
                winGridView1.GridView1.SetRowCellValue(e.RowHandle, "Checked", true);

            }
            

        }
        
        #endregion

        #region 鼠标改变事件
        /// <summary>
        /// 鼠标改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SimpleProductInfo info = (SimpleProductInfo)winGridView1.GridView1.GetRow(e.FocusedRowHandle);
            if (info == null) return;
            label_name.Text = info.H_name;//显示到上面的Lable中
            //this.winGridView1.GridView1.Appearance.FocusedRow.BackColor = Color.White; 改变默认选中色

        } 
        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region WinGridView显示
        /// <summary>
        /// 只读
        /// </summary>
        private void ReadOnly()
        {
            this.winGridView1.ReadOnlyList.Add("H_isbn");
            this.winGridView1.ReadOnlyList.Add("H_name");
            this.winGridView1.ReadOnlyList.Add("H_output_price");
            //this.winGridView1.ReadOnlyList.Add("h_amount");
            this.winGridView1.ReadOnlyList.Add("Pub_name");
            this.winGridView1.ReadOnlyList.Add("Stock_amount");
        }
        /// <summary>
        /// 别名
        /// </summary>
        private void AddColumnAlias()
        {
            this.winGridView1.AddColumnAlias("h_isbn", "条码");
            this.winGridView1.AddColumnAlias("h_name", "商品名称");
            this.winGridView1.AddColumnAlias("h_amount", "数量");
            this.winGridView1.AddColumnAlias("H_output_price", "定价");
            this.winGridView1.AddColumnAlias("Pub_name", "出版社");
            this.winGridView1.AddColumnAlias("Stock_amount", "库存");
            this.winGridView1.AddColumnAlias("Checked", "选择");
        }
        /// <summary>
        /// 排序
        /// </summary>
        private void DisplayColumns()
        {
            this.winGridView1.DisplayColumns = "Checked|H_isbn|H_name|H_output_price|Pub_name|Stock_amount";
        } 
        #endregion

        private void InputMoveProductInfo_Load(object sender, EventArgs e)
        {
            
            DisplayColumns();
            AddColumnAlias();
            ReadOnly();
            this.winGridView1.DataSource = null;
            //this.MoveProductList.First(m => m.Checked = true);
            this.winGridView1.DataSource = MoveProductList;
            this.winGridView1.Select();
           
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            var list = from MoveProduct in MoveProductList
                       where MoveProduct.Checked == true
                       select MoveProduct;
            this.MoveSelectedList.AddRange(list);

            this.Close();          

        }

        private void InputMoveProductInfo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape )
            {
                InputMoveProductInfo_FormClosing(null, null);
                this.Close();
                this.Dispose();


            }
            if (!string.IsNullOrEmpty(tb_price.Text.Trim()))
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    tb_price_Enter(null, null);
                  
                }

            }
            else
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    //SimpleProductInfo info = winGridView1.gridView1.GetFocusedRow() as SimpleProductInfo;
                    //if (info.Checked)
                    //{
                    //    info.Checked = false;
                    //}
                    //else
                    //{
                    //    info.Checked = true;
                    //}
                    bt_ok_Click(null, null);
                }
            }

        }

       

        /// <summary>
        /// 库存过虑
        /// </summary>
        private void KuChunGuoLv()
        {
            
            if (MoveProductList != null)
            {
                var list = from MoveProduct in MoveProductList
                           where MoveProduct.Stock_amount!=0
                           select MoveProduct;
                List<SimpleProductInfo> kklist = new List<SimpleProductInfo>();
                kklist.AddRange(list);
                this.MoveProductList =kklist;
                this.winGridView1.DataSource = MoveProductList;
            }  
        }

        private void tb_gl_Click(object sender, EventArgs e)
        {
            KuChunGuoLv();
            this.bt_ok.Select();
        }

        /// <summary>
        /// 定价过滤
        /// </summary>
        /// <param name="k"></param>
        private void DingJiaGuoLv(decimal k)
        {

            if (MoveProductList != null)
            {
                var lists = from MoveProduct in MoveProductList
                           where MoveProduct.H_output_price == k
                           select MoveProduct;
                List<SimpleProductInfo> kklist = new List<SimpleProductInfo>();
                kklist.AddRange(lists);
                this.MoveProductList = kklist;
                this.winGridView1.DataSource = MoveProductList;
            }
        }



        private void tb_price_Enter(object sender, EventArgs e)
        {
            string k = this.tb_price.Text.Trim();
            if (string.IsNullOrEmpty(k)) return;
            decimal kk = k.ToDecimal();
            DingJiaGuoLv(kk);
            this.tb_price.Text = "";
        }

        private void InputMoveProductInfo_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.winGridView1.SaveGridParm();
           
        }
    }
}
