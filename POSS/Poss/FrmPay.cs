using CCWin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using POSS.BLL;
using POSS.Entity;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace POSS
{
    public class FrmPay : CCSkinMain
    {
        #region 变量
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblRealMOney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private System.Windows.Forms.Label lblExistMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChargeMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel7; 
        #endregion

        /// <summary>
        /// 以选择的收款方式LIST
        /// </summary>
        private List<QueryPaymethods> payitemList = new List<QueryPaymethods>();
        DataTable dt = new DataTable();//收款列表的DataTable
        List<QueryPaymethods> alllist = null;//转换DataTable为实体
        /// <summary>
        /// 最终返回去PossUit的收款信息
        /// </summary>
        public static List<QueryPaymethods> PayedList = new List<QueryPaymethods>();
        /// <summary>
        /// 应收金额
        /// </summary>
        private decimal RealMoney = 0;          //应收金额
        /// <summary>
        /// 已付金额
        /// </summary>
        private decimal ExistMoney = 0;         //已付金额
        /// <summary>
        /// 找零金额
        /// </summary>
        private decimal ChargeMoney = 0;        //找零金额

        private int count = 0;
        private Panel panel9;
        public static bool Payed = false;//是否完成收款

        SimpleMemberInfo member = new SimpleMemberInfo();//接收POSSUIT传过来的会员信息
        private Panel lap_tkjt;
        private Label la_tkzt;

        /// <summary>
        /// 积分兑换返回的数据
        /// </summary>
        public static string youfeijinger = string.Empty;
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRealMOney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblExistMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblChargeMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lap_tkjt = new System.Windows.Forms.Panel();
            this.la_tkzt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.lap_tkjt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 598);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 492F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 598);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 681F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(873, 486);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 480);
            this.panel3.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.Location = new System.Drawing.Point(3, 0);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(186, 383);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(195, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 480);
            this.panel4.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lap_tkjt);
            this.panel9.Controls.Add(this.winGridView1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(675, 480);
            this.panel9.TabIndex = 2;
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.EnableEdit = false;
            this.winGridView1.EnableMenu = true;
            this.winGridView1.HaveProduct = false;
            this.winGridView1.Location = new System.Drawing.Point(0, 0);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowBianSe = true;
            this.winGridView1.ShowBianSe2 = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(675, 480);
            this.winGridView1.TabIndex = 0;
            this.winGridView1.Enter += new System.EventHandler(this.winGridView1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 100);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(873, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblRealMOney);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 94);
            this.panel5.TabIndex = 0;
            // 
            // lblRealMOney
            // 
            this.lblRealMOney.AutoSize = true;
            this.lblRealMOney.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRealMOney.ForeColor = System.Drawing.Color.Black;
            this.lblRealMOney.Location = new System.Drawing.Point(83, 49);
            this.lblRealMOney.Name = "lblRealMOney";
            this.lblRealMOney.Size = new System.Drawing.Size(74, 37);
            this.lblRealMOney.TabIndex = 0;
            this.lblRealMOney.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(71, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "应收:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblExistMoney);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(294, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 94);
            this.panel6.TabIndex = 1;
            // 
            // lblExistMoney
            // 
            this.lblExistMoney.AutoSize = true;
            this.lblExistMoney.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExistMoney.ForeColor = System.Drawing.Color.Black;
            this.lblExistMoney.Location = new System.Drawing.Point(101, 49);
            this.lblExistMoney.Name = "lblExistMoney";
            this.lblExistMoney.Size = new System.Drawing.Size(74, 37);
            this.lblExistMoney.TabIndex = 0;
            this.lblExistMoney.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(89, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "已收：";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblChargeMoney);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(585, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 94);
            this.panel7.TabIndex = 2;
            // 
            // lblChargeMoney
            // 
            this.lblChargeMoney.AutoSize = true;
            this.lblChargeMoney.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblChargeMoney.ForeColor = System.Drawing.Color.Black;
            this.lblChargeMoney.Location = new System.Drawing.Point(101, 49);
            this.lblChargeMoney.Name = "lblChargeMoney";
            this.lblChargeMoney.Size = new System.Drawing.Size(74, 37);
            this.lblChargeMoney.TabIndex = 0;
            this.lblChargeMoney.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(89, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "找零：";
            // 
            // lap_tkjt
            // 
            this.lap_tkjt.BackColor = System.Drawing.Color.Red;
            this.lap_tkjt.Controls.Add(this.la_tkzt);
            this.lap_tkjt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lap_tkjt.Location = new System.Drawing.Point(0, 430);
            this.lap_tkjt.Name = "lap_tkjt";
            this.lap_tkjt.Size = new System.Drawing.Size(675, 50);
            this.lap_tkjt.TabIndex = 1;
            this.lap_tkjt.Visible = false;
            // 
            // la_tkzt
            // 
            this.la_tkzt.AutoSize = true;
            this.la_tkzt.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_tkzt.ForeColor = System.Drawing.Color.White;
            this.la_tkzt.Location = new System.Drawing.Point(244, 4);
            this.la_tkzt.Name = "la_tkzt";
            this.la_tkzt.Size = new System.Drawing.Size(160, 46);
            this.la_tkzt.TabIndex = 0;
            this.la_tkzt.Text = "退款状态";
            this.la_tkzt.Visible = false;
            // 
            // FrmPay
            // 
            this.ClientSize = new System.Drawing.Size(887, 630);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MdiStretchImage = true;
            this.MinimizeBox = false;
            this.Name = "FrmPay";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "收款";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPay_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.lap_tkjt.ResumeLayout(false);
            this.lap_tkjt.PerformLayout();
            this.ResumeLayout(false);

        }


        public FrmPay()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
            this.Load += FrmPay_Load;
            this.winGridView1.GridView1.CellValueChanged += GridView1_CellValueChanged;
            
            

        }


        private void FrmPay_FormClosing(object sender, FormClosingEventArgs e)
        {
            winGridView1.SaveGridParm();
        }

        /// <summary>
        /// 值改变时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ComputeTotal();
            this.winGridView1.GridView1.RefreshData();
        }
        /// <summary>
        /// 根据找零情况 计算是否还得新增加收款方式
        /// </summary>
        private void ComputeTotal()
        {
            var query = from p in payitemList
                        group p by p.Pay_id into g
                        select new
                        {
                            payId = g.Key,
                            payMoney = g.Sum(item => item.Pay_money * item.Exchange_rate)
                        };
            this.ExistMoney = query.Sum(item => item.payMoney);
            this.ComputeCharge();
            RefreshDisplay();
            this.count = 0;
        }

        /// <summary>
        /// 计算找零金额
        /// </summary>
        private void ComputeCharge()
        {
            decimal chargeMoney = this.ExistMoney - this.RealMoney;
            if (chargeMoney > 0)
            {
                #region 找零金额只冲减现金部分（非现金收款 不能找零！）
                QueryPaymethods casher = this.payitemList.Find(item => item.Pay_id == "0001");
                if (casher != null)
                {
                    if (casher.Pay_money > chargeMoney)
                    {
                        casher.Change_money = chargeMoney;
                        chargeMoney = casher.Change_money;
                        ChargeMoney = chargeMoney;
                        //casher.Surplus_money = chargeMoney;
                        //casher.Is_charge = "1";
                    }
                    else
                    {
                        if (casher.Pay_money <= chargeMoney)
                        {
                            casher.Change_money = chargeMoney;
                            chargeMoney = casher.Change_money;
                            ChargeMoney = chargeMoney;
                        }

                        else
                        {
                            casher.Change_money = casher.Pay_money;
                            chargeMoney = chargeMoney - casher.Pay_money;
                            ChargeMoney = chargeMoney;//更新找零
                        }
                    }
                }
                #endregion
            }
            else
            {
                if (chargeMoney == 0)
                {
                    ChargeMoney = chargeMoney;
                }
            }
        }

        private void FrmPay_Load(object sender, EventArgs e)
        {
            this.FormClosing += FrmPay_FormClosing;
            this.ControlBox = false;//窗体不显示关闭按建
            dt = BLLFactory<Dz_paymethods>.Instance.GetPossConfig();
            alllist = SetPaymethods(dt);
            InitPayMethods();
            SetGridView();
            if (RealMoney < 0)
            {
                this.lap_tkjt.Visible = true;
                this.la_tkzt.Visible = true;
            }
            // this.winGridView1.GridView1.Columns["Pay_id"].ColumnEdit = PaymehodsByGrid();
            this.winGridView1.Focus();


        }

        /// <summary>
        /// 设置WinGridView
        /// </summary>
        private void SetGridView()
        {
            this.winGridView1.GridView1.PaintStyleName = "UltraFlat";
            this.winGridView1.EnableMenu = false;
            this.winGridView1.EnableEdit = true;
            this.winGridView1.GridView1.OptionsSelection.MultiSelect = false;
            this.winGridView1.GridView1.Appearance.HeaderPanel.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.Appearance.HeaderPanel.ForeColor = Color.Black;
            this.winGridView1.GridView1.Appearance.EvenRow.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.Appearance.EvenRow.ForeColor = Color.Black;
            this.winGridView1.GridView1.Appearance.OddRow.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.Appearance.OddRow.ForeColor = Color.Black;
            this.winGridView1.GridView1.Appearance.Empty.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.Appearance.Empty.ForeColor = Color.Black;
            this.winGridView1.GridView1.Appearance.Row.Font = new Font("Tahoma", 26);
            this.winGridView1.GridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 26);
            this.winGridView1.GridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 26);
            this.winGridView1.GridView1.Appearance.FooterPanel.BackColor = Color.Silver;
            this.winGridView1.GridView1.Appearance.FooterPanel.BorderColor = Color.Silver;
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("Pay_money", "c2"));
            this.winGridView1.BestFitColumnWith = false;
            this.winGridView1.DisplayColumns = "Pay_name,Pay_money,Pay_id,Exchange_rate";
            this.winGridView1.AddColumnAlias("Pay_money", "支付金额");
            this.winGridView1.AddColumnAlias("Pay_id", "支付编码");
            this.winGridView1.AddColumnAlias("Pay_name", "支付名称");
            this.winGridView1.AddColumnAlias("Exchange_rate", "汇率");
            this.winGridView1.ReadOnlyList.Add("Pay_id");
            this.winGridView1.ReadOnlyList.Add("Pay_name");
            this.winGridView1.ReadOnlyList.Add("Exchange_rate");
            this.winGridView1.GridView1.RowHeight = 40;
            this.winGridView1.DataSource = payitemList;
            this.winGridView1.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.winGridView1.GridView1.Columns["Pay_money"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["Pay_id"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["Pay_name"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["Pay_money"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["Pay_id"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["Pay_name"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["Pay_money"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.winGridView1.GridView1.Columns["Pay_money"].DisplayFormat.FormatString = "c2";
            this.winGridView1.GridView1.Columns["Exchange_rate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.winGridView1.GridView1.Columns["Exchange_rate"].DisplayFormat.FormatString = "n4";
        }

        /// <summary>
        /// 加载listTiew
        /// </summary>
        private void InitPayMethods()
        {
            listView1.Items.Clear();
            string keys = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int index = 0;
            ListViewItem item;
            foreach (var pay in alllist)
            {
                item = new ListViewItem();
                item.Name = pay.Pay_id;
                item.Text = string.Format("{0} - {1} ", keys.Substring(index, 1), pay.Pay_name);
                item.Tag = index < 10 ? "D" + keys.Substring(index, 1) : keys.Substring(index, 1);
                this.listView1.Items.Add(item);
                index++;
            }
            AddPayMethod("0001", this.RealMoney);  //添加现金付款方式

        }

        /// <summary>
        /// 添加收款方式
        /// </summary>
        /// <param name="pay_id"></param>
        /// <param name="pay_money"></param>
        private void AddPayMethod(string pay_id, decimal pay_money = 0)
        {
            var checkQuery = from check in payitemList
                             where check.Pay_id == pay_id
                             select check;
            if (checkQuery.Count() > 0) //已经添加该付款方式
            {
                return;
            }

            var query = from p in alllist
                        where p.Pay_id == pay_id
                        select p;
            List<QueryPaymethods> payInfo = query.ToList<QueryPaymethods>();
            if (payInfo.Count == 1)
            {
                QueryPaymethods pitemInfo = new QueryPaymethods();
                pitemInfo.Pay_id = payInfo[0].Pay_id;
                pitemInfo.Pay_name = payInfo[0].Pay_name;
                pitemInfo.Pay_money = pay_money / (payInfo[0].Exchange_rate == 0 ? 1 : payInfo[0].Exchange_rate);
                pitemInfo.Surplus_money = 0;
                pitemInfo.Charge_back = 0;
                pitemInfo.Is_charge = payInfo[0].Is_charge;
                pitemInfo.Exchange_rate = payInfo[0].Exchange_rate;
                pitemInfo.Source_id = pay_id;
                this.ExistMoney += pitemInfo.Pay_money * pitemInfo.Exchange_rate;
                this.payitemList.Add(pitemInfo);
                this.winGridView1.GridView1.MoveLast();
                this.winGridView1.GridView1.RefreshData();
            }
            RefreshDisplay();
            count = 0;

        }

        /// <summary>
        /// 加载Lable显示
        /// </summary>
        private void RefreshDisplay()
        {
            this.lblChargeMoney.Text = ChargeMoney.ToString("c2");
            this.lblExistMoney.Text = ExistMoney.ToString("c2");
            this.lblRealMOney.Text = RealMoney.ToString("c2");
        }

        /// <summary>
        /// 将收款列表 转换成List实体
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<QueryPaymethods> SetPaymethods(DataTable dt)
        {
            alllist = new List<QueryPaymethods>();
            QueryPaymethods info = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                info = new QueryPaymethods();
                DataRow dr = dt.Rows[i];
                info.Exchange_rate = dr["Exchange_rate"].ToString().ToDecimal();
                info.Pay_id = dr["P_id"].ToString();
                info.Pay_name = dr["P_name"].ToString();
                alllist.Add(info);
            }
            return alllist;
        }

        /// <summary>
        /// 显示收款界面
        /// </summary>
        /// <param name="realMoney"></param>
        public static void ShowPay(decimal realMoney, SimpleMemberInfo csmember)
        {
            FrmPay fp = new FrmPay();
            fp.RealMoney = realMoney;
            fp.member = csmember == null ? null : csmember;//接收会员信息
            fp.ShowDialog();
            fp.Dispose();
            PayedList.Clear();
            PayedList.AddRange(fp.payitemList);
            fp.Dispose();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            decimal money = this.GetSurplusMoney();
            if (listView1.FocusedItem != null)
            {
                string pay_id = listView1.FocusedItem.Name;
                if (pay_id == "####")//爱书卡
                {
                    if (member != null)
                    {
                            PanduanHuiYuan(pay_id, money);

                    }
                    else
                    {
                        MessagboxUit.ShowTips("没有会员信息！");
                    }

                }
                else if (pay_id == "5555")//积分当钱花
                {
                    if (member != null)
                    {
                        if (RealMoney < 0)
                        {
                            MessagboxUit.ShowTips("此收款方式不支持退货!");
                        }
                        else
                        {
                            JiFenDangQianHua(pay_id, money);
                        }
                        
                    }
                    else
                    {
                        MessagboxUit.ShowError("输入会员信息！");
                    }


                }
                else if (pay_id == "6666")//微信
                {
                    WeiXinZhiFu(pay_id, money);
                    this.winGridView1.Focus();
                }
                else if (pay_id == "7777")//支付宝
                {
                    ZhiFuBao(pay_id, money);
                    this.winGridView1.Focus();
                }
                else if (pay_id == "8888")//银行卡
                {
                    YinHangKa(pay_id, money);
                }

            }
        }
        /// <summary>
        /// 返回未支付的金额
        /// </summary>
        private decimal GetSurplusMoney()
        {
            decimal money = this.RealMoney - this.ExistMoney;
            return money > 0 ? money : 0;
        }

        /// <summary>
        /// 用于GridView生成 付款方式的combox
        /// </summary>
        /// <returns></returns>
        public static RepositoryItemImageComboBox PaymehodsByGrid()
        {
            RepositoryItemImageComboBox cbx_result = new RepositoryItemImageComboBox();
            DevExpress.XtraEditors.Controls.ImageComboBoxItem item = null;
            cbx_result.Items.Clear();
            DataTable dt = BLLFactory<Dz_paymethods>.Instance.GetPaymathodsCombox();
            foreach (DataRow r in dt.Rows)
            {
                item = new DevExpress.XtraEditors.Controls.ImageComboBoxItem();
                item.Value = r[0].ToString();
                item.Description = r[1].ToString();
                cbx_result.Items.Add(item);
            }
            return cbx_result;
        }




        private void winGridView1_Enter(object sender, EventArgs e)
        {
            this.winGridView1.GridView1.FocusedColumn = winGridView1.GridView1.Columns["Pay_money"];
        }

        /// <summary>
        /// 窗体按建事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (CheckInput() && count < 1)
                {
                    RefreshDisplay();
                    this.count++;
                }
                else if (CheckInput() && count == 1)
                {
                    CheckInput();
                    if (ChongJianXianJing())
                    {
                        RefreshDisplay();
                        this.count++;
                    }
                    else
                    {
                        this.count--;
                    }


                }
                else if (CheckInput() && count >= 2)
                {
                    QueryPaymethods k = payitemList.Find(u => u.Pay_id == "####");
                    if (k != null)//判断是不是爱书卡收款
                    {
                        if (member.SurplusMoney.ToDecimal() < k.Pay_money)
                        {
                            MessagboxUit.ShowError(string.Format("当前卡内余额为{0}元，余额不足请冲值或补现金！",member.SurplusMoney.ToDecimal()));
                        }
                        else
                        {
                            FrmPay.Payed = true;
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                    }
                    else
                    {
                        FrmPay.Payed = true;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }

                }
                else
                {
                    // MessagboxUit.ShowTips("已收金额 小于 应收金额！\r\n 增加收款方式 或 检查输入！");
                }
            }
            if (e.Control)
            {
                // ExecuteKey(e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                int index = winGridView1.GridView1.FocusedRowHandle;
                if (index >= 0)
                {
                    winGridView1.GridView1.DeleteRow(index);
                    ComputeTotal();
                    winGridView1.GridView1.RefreshData();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                FrmPay.Payed = false;
                this.Close();
            }
        }

        /// <summary>
        /// 冲减现金收款
        /// </summary>
        /// <returns></returns>
        private bool ChongJianXianJing()

        {
            bool resutl = false;
            decimal pay001 = 0.0m;
            //if (payitemList.Count >= 2)
            //{
            foreach (var item in payitemList)
            {
                if (item.Pay_id == "0001")
                {
                    pay001 = item.Pay_money;
                    if (pay001 - this.ChargeMoney >= 0)
                    {
                        item.Is_charge = "1";
                        item.Surplus_money = pay001 - this.ChargeMoney;
                        //item.Pay_money = pay001 - this.ChargeMoney;
                        //item.Change_money = pay001-this.ChargeMoney ;
                        resutl = true;
                    }
                    else
                    {
                        //解决:退货会提示下面的message框
                        if(pay001== RealMoney)
                        {
                            resutl = true;
                        }
                        else
                        {
                            MessagboxUit.ShowTips(string.Format("现金金额：{0},找零金额:{1},现金金额不足以冲减找零金额！", item.Pay_money.ToString("c2"), this.ChargeMoney.ToString("c2")));
                            resutl = false;
                        }
                        
                    }
                }

            }
            return resutl;
        }
        //TODO:零售毛利有问题
        private bool CheckInput()
        {
            if (this.ExistMoney >= this.RealMoney)
                return true;
            else
                return false;
        }
        private void ExecuteKey(KeyEventArgs e)
        {
            foreach (ListViewItem k in listView1.Items)
            {
                if (EnumHelper.GetInstance<Keys>(k.Tag.ToString()) == e.KeyCode && e.Control)
                {
                    decimal money = this.GetSurplusMoney();
                    AddPayMethod(k.Name, money);
                }
            }
        }

        /// <summary>
        /// 爱书卡消费与 判断
        /// </summary>
        /// <param name="pay_id"></param>
        private void PanduanHuiYuan(string pay_id, decimal money)
        {
            if (!string.IsNullOrEmpty(member.Card_id))
            {
                this.winGridView1.Focus();
                foreach (var item in payitemList)
                {
                    item.Source_id = member.Card_id;

                    if (BLLFactory<Ls_card_surplus>.Instance.IsExistKey("card_id", member.Card_id))//是否有这个爱书卡
                    {
                      List<MemberInfo> info=  BLLFactory<Member>.Instance.Find(string.Format("card_id='{0}'", member.Card_id));
                        if (string.IsNullOrEmpty(info[0].M_password))
                        {
                            AddPayMethod(pay_id, money);
                        }
                        else
                        {
                            FormPassword pass = new FormPassword();//会员密码框
                            pass.m_id = member.M_id;
                            pass.ShowDialog();
                            if (pass.YesOrNo)
                            {
                                AddPayMethod(pay_id, money);
                            }
                            
                        }
                       
                        return;
                    }
                    else
                    {
                       
                        MessagboxUit.ShowError(string.Format("会员卡【{0}】！不是爱书卡会员！", member.Card_id.Trim()));
                    }
                }
            }
            else
            {
                MessagboxUit.ShowTips("请先输入会员信息！");
            }
        }

        /// <summary>
        /// 积分当钱花
        /// </summary>
        /// <param name="pay_id"></param>
        /// <param name="money"></param>
        private void JiFenDangQianHua(string pay_id, decimal money)
        {
            if (Portal.gc.QPossConfig.Is_qtjl != "1")//以启用前台奖励~不能进行积分当钱花
            {
                if (!string.IsNullOrEmpty(member.Card_id))
                {


                    FromJiFenDangQianHua f = new FromJiFenDangQianHua();
                    f.memberinfo = this.member;
                    f.remal_money = money;
                    f.ShowDialog();
                    if (f.OkOrNo)
                    {
                        AddPayMethod(pay_id, money);
                        QueryPaymethods kk = payitemList.Find(u => u.Pay_id == "5555");
                        decimal k = f.ShiYongJiFen;
                        if (k >= money)
                        {

                            kk.Pay_money = kk.Pay_money;//没有找零
                        }
                        else
                        {
                            kk.Pay_money = k;//要返回一个用 积分以支付金额
                        }
                        youfeijinger = f.youfeijinger;
                        ComputeTotal();
                        this.winGridView1.Focus();
                        // winGridView1.GridView1.Columns["Pay_money"].OptionsColumn.ReadOnly = true;// 锁点支付金
                    }
                }
                else
                {
                    MessagboxUit.ShowError("请首先输入会员信息！");
                }
            }
            else
            {
                MessagboxUit.ShowError("以启用前台奖励~不能进行积分当钱花！");
            }

        }

        /// <summary>
        /// 微信支付
        /// </summary>
        /// <param name="pay_id"></param>
        /// <param name="money"></param>
        private void WeiXinZhiFu(string pay_id, decimal money)
        {
            FrmWeiXinZhiFu.YesOrNo = false;//正常的
            FrmWeiXinZhiFu.ShowPay(money);
            if (FrmWeiXinZhiFu.YesOrNo)
            {
                AddPayMethod(pay_id, money);
                // string kk=string.Format("微信订单号：{0}", FrmWeiXinZhiFu.k.Out_trade_no);


            }

        }

        /// <summary>
        /// 支付宝
        /// </summary>
        /// <param name="pay_id"></param>
        /// <param name="money"></param>
        private void ZhiFuBao(string pay_id, decimal money)
        {
            FrmZhiFuBao.YesOrNo = false;//正常的
            FrmZhiFuBao.ShowPay(money);
            if (FrmZhiFuBao.YesOrNo)
            {
                AddPayMethod(pay_id, money);
            }
        }

        /// <summary>
        /// 银行卡
        /// </summary>
        /// <param name="pay_id"></param>
        /// <param name="money"></param>
        private void YinHangKa(string pay_id, decimal money)
        {
            AddPayMethod(pay_id, money);
        }
    }
}
