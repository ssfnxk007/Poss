using CCWin;
using DevExpress.XtraEditors.Repository;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;
using DevExpress.XtraGrid.Views.Base;

namespace POSS
{
    public class FromPay : CCSkinMain
    {
        #region 变量
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label l_real_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_existMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_chargeMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;


        public static bool Payed = false;//收款准备是否完成
        public decimal RealMoney = 0;          //应收金额
        private decimal ExistMoney = 0;         //已付金额
        public decimal ChargeMoney = 0;        //找零金额
        private int count = 0;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton bt_cel;
        private DevExpress.XtraEditors.SimpleButton bt_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public List<QueryPaymethods> PayedList = new List<QueryPaymethods>();//收款列表
        public static List<QueryPaymethods> paylist = new List<QueryPaymethods>();//要传到收银界面的收款列表

        DataTable dt = new DataTable();//后台返回的DT
        List<QueryPaymethods> alllist = null;//用于 收款列表 
        SimpleMemberInfo memberinfo = new SimpleMemberInfo(); //接收传过来的会员信息

        public SimpleMemberInfo lscardinfo = new SimpleMemberInfo();//接收的爱书卡会员
        private DevExpress.XtraEditors.SimpleButton bt_del;
        private System.Windows.Forms.ListView listView1;

        /// <summary>
        /// 积分兑换返回的数据
        /// </summary>
        public static string youfeijinger = string.Empty;
        #endregion

        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_del = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cel = new DevExpress.XtraEditors.SimpleButton();
            this.bt_save = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_real_money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_existMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.l_chargeMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panel5);
            this.panelControl1.Controls.Add(this.panel4);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(4, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(899, 608);
            this.panelControl1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(202, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(695, 504);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.winGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(695, 504);
            this.panel7.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.bt_del);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.bt_cel);
            this.panel4.Controls.Add(this.bt_save);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(2, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 504);
            this.panel4.TabIndex = 1;
            // 
            // bt_del
            // 
            this.bt_del.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.bt_del.Location = new System.Drawing.Point(-2, 36);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(202, 37);
            this.bt_del.TabIndex = 17;
            this.bt_del.Text = "删 除";
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(7, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "只需在【支付编码】处选择就行！";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(7, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "系统支持组合收款！如须组和收款";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "提示：";
            // 
            // bt_cel
            // 
            this.bt_cel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.bt_cel.Location = new System.Drawing.Point(-2, 66);
            this.bt_cel.Name = "bt_cel";
            this.bt_cel.Size = new System.Drawing.Size(202, 37);
            this.bt_cel.TabIndex = 7;
            this.bt_cel.Text = "取消";
            this.bt_cel.Click += new System.EventHandler(this.bt_cel_Click);
            // 
            // bt_save
            // 
            this.bt_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.bt_save.Location = new System.Drawing.Point(0, 0);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(200, 41);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "保存(F5)";
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tableLayoutPanel1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(895, 100);
            this.panelControl2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.50265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.49735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.l_real_money);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 90);
            this.panel1.TabIndex = 3;
            // 
            // l_real_money
            // 
            this.l_real_money.AutoSize = true;
            this.l_real_money.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_real_money.Location = new System.Drawing.Point(72, 41);
            this.l_real_money.Name = "l_real_money";
            this.l_real_money.Size = new System.Drawing.Size(87, 39);
            this.l_real_money.TabIndex = 0;
            this.l_real_money.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "应收：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.l_existMoney);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(276, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 90);
            this.panel2.TabIndex = 4;
            // 
            // l_existMoney
            // 
            this.l_existMoney.AutoSize = true;
            this.l_existMoney.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_existMoney.Location = new System.Drawing.Point(115, 41);
            this.l_existMoney.Name = "l_existMoney";
            this.l_existMoney.Size = new System.Drawing.Size(87, 39);
            this.l_existMoney.TabIndex = 0;
            this.l_existMoney.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "已收：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.l_chargeMoney);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(604, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 90);
            this.panel3.TabIndex = 5;
            // 
            // l_chargeMoney
            // 
            this.l_chargeMoney.AutoSize = true;
            this.l_chargeMoney.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_chargeMoney.Location = new System.Drawing.Point(88, 41);
            this.l_chargeMoney.Name = "l_chargeMoney";
            this.l_chargeMoney.Size = new System.Drawing.Size(87, 39);
            this.l_chargeMoney.TabIndex = 0;
            this.l_chargeMoney.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "找零：";
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
            this.winGridView1.Location = new System.Drawing.Point(0, 0);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = false;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = false;
            this.winGridView1.ShowEditMenu = false;
            this.winGridView1.ShowExportButton = false;
            this.winGridView1.Size = new System.Drawing.Size(695, 504);
            this.winGridView1.TabIndex = 0;
            this.winGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.winGridView1_Paint);
            this.winGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.winGridView1_KeyDown);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.Location = new System.Drawing.Point(1, 109);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(196, 220);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FromPay
            // 
            this.ClientSize = new System.Drawing.Size(907, 640);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromPay";
            this.ShadowColor = System.Drawing.Color.White;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收款框";
            this.Load += new System.EventHandler(this.FromPay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FromPay_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }


        public FromPay()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
            this.winGridView1.GridView1.CellValueChanged += GridView1_CellValueChanged;
            // this.winGridView1.GridView1.CustomDrawCell += GridView1_CustomDrawCell;
            this.winGridView1.GridView1.RowClick += GridView1_RowClick;


            this.winGridView1.Focus();

        }

        #region GridView事建

        /// <summary>
        /// 行点击事件 聚焦并编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ColumnView view = (ColumnView)winGridView1.gridControl1.FocusedView;
            view.FocusedColumn = view.Columns["Pay_money"];
            view.ShowEditor();


        }


        private void GridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            ComputeTotal();
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.FieldName == "Pay_money")
            {
                ComputeTotal();
                winGridView1.gridView1.RefreshData();
            }
            if (e.Column.FieldName == "Pay_id")
            {
                QueryPaymethods payinfo = (QueryPaymethods)winGridView1.GridView1.GetRow(e.RowHandle);
                if (payinfo.Pay_id == "6666")//微信
                {
                    ComputeTotal();

                    winGridView1.gridView1.RefreshData();
                    this.bt_save.Focus();
                }
                else if (payinfo.Pay_id == "7777")//支付宝
                {
                    //QueryPaymethods pay = PayedList.Find(item => item.Pay_id == "7777");
                    MessagboxUit.ShowTips(payinfo.Pay_money.ToString("c2"));

                }
                else if (payinfo.Pay_id == "8888")
                {
                    ComputeTotal();
                    MessagboxUit.ShowTips("打开银行卡");
                }
                else if (payinfo.Pay_id == "5555")//积分当钱花
                {
                    if (!string.IsNullOrEmpty(memberinfo.Card_id))
                    {

                        FromJiFenDangQianHua f = new FromJiFenDangQianHua();
                        f.memberinfo = this.memberinfo;
                        f.remal_money = payinfo.Pay_money;
                        f.ShowDialog();
                        if (f.OkOrNo)
                        {
                            decimal k = f.ShiYongJiFen;
                            if (k >= payinfo.Pay_money)
                            {
                                payinfo.Pay_money = payinfo.Pay_money;//没有找零
                            }
                            else
                            {
                                payinfo.Pay_money = k;//要返回一个用 积分以支付金额
                            }
                            youfeijinger = f.youfeijinger;
                            ComputeTotal();

                            //winGridView1.GridView1.OptionsBehavior.Editable = true;
                            winGridView1.GridView1.Columns["Pay_money"].OptionsColumn.ReadOnly = true;// 锁点支付金
                            ComputeTotal();
                        }
                    }
                    else
                    {
                        MessagboxUit.ShowError("请首先输入爱书卡会员信息！");
                    }

                }

                else if (payinfo.Pay_id == "####")//爱书卡
                {
                    if (!string.IsNullOrEmpty(this.memberinfo.M_id))
                    {
                        payinfo.Source_id = memberinfo.Card_id;
                        if (BLLFactory<Ls_card_surplus>.Instance.IsExistKey("m_id", memberinfo.M_id))
                        {
                            return;

                        }
                        else
                        {
                            MessagboxUit.ShowError(string.Format("些会员卡【{0}】！不是爱书卡会员！", memberinfo.Card_id.Trim()));

                        }

                    }
                    else
                    {
                        MessagboxUit.ShowError("请首先输入爱书卡会员信息！");
                        Payed = false;
                    }

                }

            }

            if (CheckInput())
            {
                this.winGridView1.gridView1.FocusedColumn = winGridView1.GridView1.Columns["Pay_id"];
                winGridView1.gridView1.Columns["Pay_id"].OptionsColumn.AllowEdit = true;
            }
            else
            {
                this.winGridView1.gridView1.FocusedColumn = winGridView1.GridView1.Columns["Pay_money"];
                winGridView1.gridView1.Columns["Pay_money"].OptionsColumn.AllowEdit = true;
            }


        }


        #endregion

        #region 合总计算 与计算找零
        /// <summary>
        /// 合总计算
        /// </summary>
        private void ComputeTotal()
        {
            var query = from p in PayedList
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
        /// 计算找零
        /// </summary>
        private void ComputeCharge()
        {
            decimal chargeMoney = this.ExistMoney - this.RealMoney;
            if (chargeMoney >= 0)
            {

                #region 找零金额首先冲减现金部分
                QueryPaymethods casher = PayedList.Find(item => item.Pay_id == "0001");
                if (casher != null)
                {
                    if (casher.Pay_money > chargeMoney)
                    {
                        casher.Change_money = chargeMoney;
                        //chargeMoney = 0;
                        this.ChargeMoney = chargeMoney;
                    }
                    else
                    {
                        casher.Change_money = chargeMoney;
                        this.ChargeMoney = chargeMoney;

                    }
                }

                #endregion
            }
            else
            {

                AddPaymenthod("6666", "组合收款", -chargeMoney);//当还有找零金额小于0时                                      
                // this.ChargeMoney = 0;
                ComputeTotal();
                winGridView1.GridView1.MoveLast();


            }


        }
        #endregion

        #region 上方三个lalbe的显示
        /// <summary>
        /// 上方三个lalbe的显示
        /// </summary>
        private void RefreshDisplay()
        {
            this.l_chargeMoney.Text = ChargeMoney.ToString("c2");
            this.l_existMoney.Text = ExistMoney.ToString("c2");
            this.l_real_money.Text = RealMoney.ToString("c2");
        }
        #endregion

        #region 设置GridView的显示
        /// <summary>
        /// 设置GridView的显示
        /// </summary>
        private void SetWinGridView()
        {

            this.bt_cel.Appearance.BackColor = Color.FromArgb(128, 208, 255);
            // this.bt_del.Appearance.BackColor = Color.FromArgb(128, 208, 255);
            this.bt_save.Appearance.BackColor = Color.FromArgb(128, 208, 255);
            //this.bt_zfb.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.PaintStyleName = "UltraFlat";
            this.winGridView1.GridView1.OptionsSelection.MultiSelect = false;//是否开起多选
            this.winGridView1.GridView1.BestFitColumns(true);
            this.winGridView1.GridView1.Appearance.HeaderPanel.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.Appearance.HeaderPanel.ForeColor = Color.Black;
            this.winGridView1.GridView1.Appearance.EvenRow.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.Appearance.EvenRow.ForeColor = Color.Black;
            this.winGridView1.GridView1.Appearance.OddRow.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.Appearance.OddRow.ForeColor = Color.Black;
            this.winGridView1.GridView1.Appearance.Empty.BackColor = Color.FromArgb(128, 208, 255);
            this.winGridView1.GridView1.Appearance.Empty.ForeColor = Color.Black;
            this.winGridView1.BestFitColumnWith = false;
            this.winGridView1.DisplayColumns = "Pay_name,Pay_money,Pay_id,Exchange_rate";
            this.winGridView1.AddColumnAlias("Pay_money", "支付金额");
            this.winGridView1.AddColumnAlias("Pay_id", "支付编码");
            this.winGridView1.AddColumnAlias("Pay_name", "支付名称");
            this.winGridView1.AddColumnAlias("Exchange_rate", "汇率");
            //this.winGridView1.ReadOnlyList.Add("Pay_id");
            this.winGridView1.ReadOnlyList.Add("Pay_name");
            this.winGridView1.ReadOnlyList.Add("Exchange_rate");
            this.winGridView1.GridView1.RowHeight = 40;
            this.winGridView1.DataSource = PayedList;

            //this.winGridView1.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
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
        #endregion

        private void FromPay_Load(object sender, EventArgs e)
        {
            dt = BLLFactory<Dz_paymethods>.Instance.GetPossConfig();
            alllist = SetPaymethods(dt);
            ExistMoney = RealMoney;
            this.ControlBox = false;//窗体不显示关闭按建
            ChargeMoney = 0.00m;
            RefreshDisplay();
            AddPaymenthod("0001", "现金");
            SetWinGridView();
            //paydb.Clear();
            //paydb.Add("0001");
            this.winGridView1.gridView1.Columns["Pay_id"].ColumnEdit = PaymehodsByGrid();
            winGridView1.gridView1.RefreshData();
            this.winGridView1.gridView1.FocusedColumn = winGridView1.GridView1.Columns["Pay_money"];
            //this.winGridView1.GridView1.Columns["Pay_id"].OptionsFilter.AllowFilter = true;

        }

        #region 关闭窗体事建
        /// <summary>
        /// 关闭窗体事建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void FromPay_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        //{
        //    this.winGridView1.SaveGridParm();//关闭写入INI文件 宽度 位置等信息  GridView里的
        //    if (PayedList.Count != 0)
        //    {
        //        MessagboxUit.ShowTips("以有收款明细不能退出！");
        //    }

        //}
        #endregion

        #region 添加支付方式判断
        /// <summary>
        /// 添加支付方式判断
        /// </summary>
        /// <param name="pay_id"></param>
        /// <param name="pay_name"></param>
        private void AddPaymenthod(string pay_id, string pay_name)
        {
            QueryPaymethods payinfo = null;
            var check = from c in PayedList
                        where c.Pay_id == pay_id
                        select c;
            if (check.Count() > 0)
            {

                MessagboxUit.ShowError(string.Format("支付方式:{0}以存在！不用重复添加！", pay_name));
            }
            else
            {
                QueryPaymethods allinfo = new QueryPaymethods();
                allinfo = alllist.Find(item => item.Pay_id == pay_id);
                if (pay_id == allinfo.Pay_id)
                {
                    payinfo = new QueryPaymethods();
                    payinfo.Pay_id = pay_id;
                    payinfo.Pay_name = allinfo.Pay_name;
                    payinfo.Exchange_rate = allinfo.Exchange_rate;
                    payinfo.Pay_money = this.RealMoney;

                    PayedList.Add(payinfo);
                }
                winGridView1.gridView1.RefreshData();

            }

        }

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
        /// 添加支付方式
        /// </summary>
        /// <param name="pay_id"></param>
        /// <param name="pay_name"></param>
        /// <param name="chargeMoney"></param>
        private void AddPaymenthod(string pay_id, string pay_name, decimal chargeMoney)
        {
            QueryPaymethods allinfo = new QueryPaymethods();
            allinfo = alllist.Find(item => item.Pay_id == pay_id);
            if (pay_id == allinfo.Pay_id)
            {
                QueryPaymethods payinfo = null;
                payinfo = new QueryPaymethods();
                payinfo.Pay_id = pay_id;
                payinfo.Pay_name = pay_name;
                payinfo.Exchange_rate = allinfo.Exchange_rate;
                payinfo.Pay_money = chargeMoney;
                PayedList.Add(payinfo);
            }

            winGridView1.gridView1.RefreshData();


        }
        #endregion

        #region 用于GridView生成 付款方式的combox
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

        #endregion

        private void bt_save_Click(object sender, EventArgs e)
        {
            this.winGridView1.SaveGridParm();
          if(CheckInput())
            {
                if (PayedList.Count != 0)
                {
                    if (PayedList.Count >= 1)
                    {
                        QueryPaymethods pay = PayedList.Find(p => p.Pay_id == "0001");

                        if (pay.Change_money > pay.Pay_money)
                        {
                            MessagboxUit.ShowError("非现金收款 禁止使用 现金找零！");
                            return;
                        }
                        else
                        {
                            decimal realmoney = pay.Pay_money - pay.Change_money;
                            if (realmoney > 0)
                            {
                                pay.Pay_money = realmoney;

                            }

                            QueryPaymethods k = PayedList.Find(p => p.Pay_id == "####");//如果是爱书卡收款要判断卡内于额
                            if (k != null)
                            {
                                if (memberinfo.SurplusMoney.ToDecimal() < k.Pay_money)
                                {
                                    MessagboxUit.ShowError("爱书卡内余额不足！请冲值！或者支付现金！");
                                }
                                else
                                {
                                    Payed = true;
                                    this.Close();
                                    this.Dispose();
                                }

                            }
                            else
                            {
                                Payed = true;
                                this.Close();
                                this.Dispose();
                            }
                        }
                    }

                }
            }
            
        }

        #region 聚焦winGridView
        /// <summary>
        /// 聚焦winGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void winGridView1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            this.winGridView1.Focus();
        }
        #endregion

        public static void ShowPay(decimal realMoney, SimpleMemberInfo member)
        {
            FromPay fp = new FromPay();
            fp.RealMoney = realMoney;
            fp.memberinfo = member;
            fp.ShowDialog();
            fp.Dispose();
            paylist.Clear();
            paylist.AddRange(fp.PayedList);
            fp.Dispose();
        }

     

        private void FromPay_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if(CheckInput() && count <= 0)
                {
                    count++;
                }
                else if (CheckInput() && count >= 1)
                {
                    bt_save_Click(null, null);
                }
            }


            if (e.KeyCode == System.Windows.Forms.Keys.F5)
            {
                bt_save_Click(null, null);
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                bt_cel_Click(null, null);
            }
        }

        private bool CheckInput()
        {
            if (this.ExistMoney >= this.RealMoney)
                return true;
            else
                return false;
        }

        private void winGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void bt_cel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void DeleteItem(int rowIndex)
        {

            QueryPaymethods info = new QueryPaymethods();
            info = (QueryPaymethods)winGridView1.GridView1.GetRow(rowIndex);
            if (MessagboxUit.ShowYesNoAndWarning(string.Format("名称：{0}\r\n支付金额：{1}\n\r确认要删除吗?", info.Pay_name, info.Pay_money)) == System.Windows.Forms.DialogResult.Yes)
            {
                winGridView1.GridView1.DeleteRow(rowIndex);
                winGridView1.GridView1.MoveBy(0);
                QueryPaymethods firstinfo = PayedList.First();//找到第一个收款方式 加入删除收款方式的金额
                //ComputeTotal();
                firstinfo.Pay_money = firstinfo.Pay_money + this.ChargeMoney;
            }
        }

        private void bt_del_Click_1(object sender, EventArgs e)
        {
            if (PayedList.Count > 1)//最少一种收款方式
            {
                int rowIndex = winGridView1.GridView1.FocusedRowHandle;
                if (rowIndex >= 0)
                {
                    DeleteItem(rowIndex);
                }
            }
            else
            {
                MessagboxUit.ShowError("最少一种收款方式~！");
            }


        }

        private List<QueryPaymethods> marginPaymaths(List<QueryPaymethods> list)
        {
            List<QueryPaymethods> cslist = new List<QueryPaymethods>();
            var margin = from u in list
                         group u by u.Pay_id
                         into newlist
                         select new
                         {
                             pay_id = newlist.Key,
                             pay_money = newlist.Sum(u => u.Pay_money),
                             pay_name = newlist.Max(u => u.Pay_name),
                             change_money = newlist.Sum(u => u.Change_money),
                             surplus_money = newlist.Sum(u => u.Surplus_money),
                             charge_back = newlist.Sum(u => u.Charge_back),
                             Exchange_rate = newlist.Max(u => u.Exchange_rate),
                             is_charge = newlist.Max(u => u.Is_charge),
                             source_id = newlist.Max(u => u.Source_id),
                             is_aishuka = newlist.Max(u => u.Is_aishuka),
                             is_ok = newlist.Max(u => u.Is_ok)
                         };
            List<QueryPaymethods> kk = margin as List<QueryPaymethods>;
            QueryPaymethods info = null;



            return cslist;
        }


    }
}
