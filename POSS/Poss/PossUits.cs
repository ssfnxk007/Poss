using DevExpress.XtraGrid.Views.Base;
using Microsoft.VisualBasic;
using POSS.BLL;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;

namespace POSS
{
    public class PossUits : DevExpress.XtraEditors.XtraForm
    {

        #region 窗体变量
        private System.ComponentModel.IContainer components;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl24;
        private TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.PanelControl panelControl21;
        private Label l_changemoney;
        private Label label21;
        private DevExpress.XtraEditors.PanelControl panelControl18;
        private Label label16;
        private Label l_paymoney;
        private DevExpress.XtraEditors.PanelControl panelControl19;
        private Label label17;
        private Label l_realMoney;
        private DevExpress.XtraEditors.PanelControl panelControl17;
        private Label label15;
        private DevExpress.XtraEditors.PanelControl panelControl14;
        private Label label12;
        private DevExpress.XtraEditors.PanelControl panelControl13;
        private TextBox tb_remal_money;
        private Label label11;
        private DevExpress.XtraEditors.PanelControl panelControl12;
        private TextBox t_total_money;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private TextBox tb_count;
        private Label label8;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private TextBox tb_total_num;
        private Label label9;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private TextBox tb_o_name;
        private Label label7;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private ComboBox cb_stock;
        private Label label6;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private TextBox tb_ph;
        private Label label4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private ComboBox cb_stand;
        private Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private ComboBox cb_station;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.PanelControl panelControl16;
        private TextBox tb_Member_SurplusMoney;
        private Label label14;
        private DevExpress.XtraEditors.PanelControl panelControl15;
        private Label l_member;
        private TextBox tb_menber_Integral;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.PanelControl panelControl23;
        private TextBox lblStatus;
        private Label label19;
        private DevExpress.XtraEditors.PanelControl panelControl22;
        private Label label18;
        private DevExpress.XtraEditors.PanelControl panelControl20;
        private Label label5;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.TextEdit tb_isbn;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton bt_delete;
        private DevExpress.XtraEditors.TextEdit tb_member;
        private DevExpress.XtraEditors.TextEdit tb_sm;
        private DevExpress.XtraEditors.TextEdit tb_xy;
        private System.Drawing.Printing.PrintDocument pintxiaopiao;
        private DevExpress.XtraEditors.LabelControl l_type;
        private ToolStripMenuItem 系统设置ToolStripMenuItem;
        private ToolStripMenuItem 员工设置ToolStripMenuItem;
        private ToolStripMenuItem 修改密码ToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel7;
        private DevExpress.XtraEditors.PanelControl panelControl25;
        private DevExpress.XtraEditors.PanelControl panelControl26;
        private DevExpress.XtraEditors.TextEdit tb_tyzk;
        private Label label20;
        private DevExpress.XtraEditors.TextEdit tb_submoney;
        private DevExpress.XtraEditors.PanelControl panelControl28;
        private DevExpress.XtraEditors.LabelControl la_remol;
        private DevExpress.XtraEditors.PanelControl panelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl1;


        private PageSetupDialog pagesetupdialog;
        #endregion

       

        private OperatorsFrom temform = null;//全局窗体变量(设置窗体)
        private SystemFrom systemform = null;
        private FormM_pass formm_poss = null;

        private FromEditMember cordfrom = null;


        /// <summary>
        /// 接收登录窗传过的用户编号
        /// </summary>
        public string O_id
        {
            get; set;
        }
        public UsersInfo userinfo = null;//全局登录用户信息

        public Sell_info sellinfo = null;//更新批号后用说前台显示的 用户信息 与 批量信息

        List<SimpleProductInfo> Productlist = new List<SimpleProductInfo>();//全据商品列表

        List<SimpleProductInfo> MerageList = new List<SimpleProductInfo>();//相同品咱合并转用List

        List<SimpleProductInfo> SelectProductlist = new List<SimpleProductInfo>();//多打记录时 子窗体返回 选择商品列表

        List<Ls_itemInfo> ItemList = new List<Ls_itemInfo>();//数据库零售细表实体

        //LsInfo lsinfo = new LsInfo();//数据库 主表实体

        List<SimpleMemberInfo> memberlist = new List<SimpleMemberInfo>();//会员简单实体
        /// <summary>
        /// 去领头金额
        /// </summary>
        decimal SubMoney = 0;//去领头金额
        /// <summary>
        /// 总码洋
        /// </summary>
        private decimal Ls_Sum = 0;//总码洋
        private decimal total_money = 0;

        SimpleMemberInfo cdmember = new SimpleMemberInfo();//用于接回 传回来的选择会员信息

        private List<QueryPaymethods> payedList = new List<QueryPaymethods>();//付款信息

        private BackgroundWorker saveBackgroundWorker = null;       //保存单据后台工作
        private BackgroundWorker stockBackgroundWorker = null;      //出库后台工作

        private LsInfo WanZhengLsInfo = null;//保存取得 零售单号 完整 零售信息
        List<QueryPaymethods> paylist = new List<QueryPaymethods>();//组装完成的 收款表
        LsInfo lsinfo = new LsInfo();//数据库 主表实体 组装完成
        /// <summary>
        /// 实收金额
        /// </summary>
        decimal paymoney = 0;//收款金额
        /// <summary>
        /// 找零金额
        /// </summary>
        decimal changemoney = 0;//找零金额

        Ls_card_runInfo cardruninfo = new Ls_card_runInfo();//爱书卡流水表

        //RoundType roundtype = EnumHelper.GetInstance<RoundType>(Portal.gc.QPossConfig.Ls_qltfs);//通过字符串获取枚举成员
        /// <summary>
        /// 积分兑换返回的数据
        /// </summary>
        string youfeijinger = string.Empty;
        /// <summary>
        /// 积分兑换返回的备注
        /// </summary>
        string youfeibeizhu = string.Empty;//优惠的备注
        /// <summary>
        /// 积分兑换返回的金额
        /// </summary>
        decimal youfeimoney = 0;//优惠金额

        /// <summary>
        /// 系统书积分实洋
        /// </summary>
        decimal real_money_avoid = 0;
        /// <summary>
        /// POSS打印设置
        /// </summary>
        PosSetup possetup = new PosSetup();//POSS打印设置

        List<SimpleProductInfo> kklist = null;//用于打印时的商品信息

        string pay_name = string.Empty;//用于打印时的收款方式名称
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private PrintDialog printDialog1;
        private DangBanInfo danbaninfo = null;//当班

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PossUits));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl24 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl21 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl28 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.la_remol = new DevExpress.XtraEditors.LabelControl();
            this.panelControl27 = new DevExpress.XtraEditors.PanelControl();
            this.label21 = new System.Windows.Forms.Label();
            this.l_changemoney = new System.Windows.Forms.Label();
            this.panelControl18 = new DevExpress.XtraEditors.PanelControl();
            this.label16 = new System.Windows.Forms.Label();
            this.l_paymoney = new System.Windows.Forms.Label();
            this.panelControl19 = new DevExpress.XtraEditors.PanelControl();
            this.label17 = new System.Windows.Forms.Label();
            this.l_realMoney = new System.Windows.Forms.Label();
            this.panelControl17 = new DevExpress.XtraEditors.PanelControl();
            this.tb_member = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.panelControl14 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl25 = new DevExpress.XtraEditors.PanelControl();
            this.tb_submoney = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.panelControl26 = new DevExpress.XtraEditors.PanelControl();
            this.tb_tyzk = new DevExpress.XtraEditors.TextEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.panelControl13 = new DevExpress.XtraEditors.PanelControl();
            this.tb_remal_money = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelControl12 = new DevExpress.XtraEditors.PanelControl();
            this.t_total_money = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.tb_total_num = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.tb_o_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.cb_stock = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.tb_ph = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cb_stand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.cb_station = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl16 = new DevExpress.XtraEditors.PanelControl();
            this.l_type = new DevExpress.XtraEditors.LabelControl();
            this.tb_Member_SurplusMoney = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panelControl15 = new DevExpress.XtraEditors.PanelControl();
            this.l_member = new System.Windows.Forms.Label();
            this.tb_menber_Integral = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl23 = new DevExpress.XtraEditors.PanelControl();
            this.lblStatus = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panelControl22 = new DevExpress.XtraEditors.PanelControl();
            this.tb_sm = new DevExpress.XtraEditors.TextEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.panelControl20 = new DevExpress.XtraEditors.PanelControl();
            this.tb_xy = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.tb_isbn = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.bt_delete = new DevExpress.XtraEditors.SimpleButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl24)).BeginInit();
            this.panelControl24.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl21)).BeginInit();
            this.panelControl21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl28)).BeginInit();
            this.panelControl28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl27)).BeginInit();
            this.panelControl27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl18)).BeginInit();
            this.panelControl18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl19)).BeginInit();
            this.panelControl19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl17)).BeginInit();
            this.panelControl17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_member.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl14)).BeginInit();
            this.panelControl14.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl25)).BeginInit();
            this.panelControl25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_submoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl26)).BeginInit();
            this.panelControl26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tyzk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl13)).BeginInit();
            this.panelControl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl12)).BeginInit();
            this.panelControl12.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            this.panelControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl16)).BeginInit();
            this.panelControl16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl15)).BeginInit();
            this.panelControl15.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl23)).BeginInit();
            this.panelControl23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl22)).BeginInit();
            this.panelControl22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_sm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl20)).BeginInit();
            this.panelControl20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_xy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_isbn.Properties)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 843);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1411, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1396, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "欢迎使用新版Poss零售系统！联系QQ：85530815，联系电话：13668146830";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1411, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.员工设置ToolStripMenuItem,
            this.toolStripSeparator1,
            this.修改密码ToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.退出ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.系统设置ToolStripMenuItem_Click_1);
            // 
            // 员工设置ToolStripMenuItem
            // 
            this.员工设置ToolStripMenuItem.Name = "员工设置ToolStripMenuItem";
            this.员工设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.员工设置ToolStripMenuItem.Text = "员工设置";
            this.员工设置ToolStripMenuItem.Click += new System.EventHandler(this.员工设置ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(124, 22);
            this.toolStripTextBox1.Text = "交班";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // panelControl24
            // 
            this.panelControl24.Controls.Add(this.tableLayoutPanel1);
            this.panelControl24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl24.Location = new System.Drawing.Point(0, 25);
            this.panelControl24.Name = "panelControl24";
            this.panelControl24.Size = new System.Drawing.Size(1411, 818);
            this.panelControl24.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.39773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.60227F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1407, 814);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1125, 737);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.winGridView1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(2, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1121, 733);
            this.panelControl5.TabIndex = 0;
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.EnableEdit = true;
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
            this.winGridView1.ShowFooter = true;
            this.winGridView1.Size = new System.Drawing.Size(1117, 729);
            this.winGridView1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tableLayoutPanel2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(1134, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(270, 737);
            this.panelControl2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panelControl21, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.panelControl18, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.panelControl19, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.panelControl17, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.panelControl14, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.panelControl13, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.panelControl12, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.panelControl9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.panelControl8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panelControl6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelControl3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelControl4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 14;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.997636F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.997636F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.997636F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.997636F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.997636F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.82726F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.477733F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.34278F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.636977F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.557355F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.906882F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.588394F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.588394F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.60594F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(266, 733);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelControl21
            // 
            this.panelControl21.Controls.Add(this.panelControl28);
            this.panelControl21.Controls.Add(this.panelControl27);
            this.panelControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl21.Location = new System.Drawing.Point(3, 646);
            this.panelControl21.Name = "panelControl21";
            this.panelControl21.Size = new System.Drawing.Size(260, 84);
            this.panelControl21.TabIndex = 11;
            // 
            // panelControl28
            // 
            this.panelControl28.Controls.Add(this.labelControl1);
            this.panelControl28.Controls.Add(this.la_remol);
            this.panelControl28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl28.Location = new System.Drawing.Point(2, 29);
            this.panelControl28.Name = "panelControl28";
            this.panelControl28.Size = new System.Drawing.Size(256, 53);
            this.panelControl28.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Location = new System.Drawing.Point(10, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 39);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "应收：";
            // 
            // la_remol
            // 
            this.la_remol.Appearance.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_remol.Appearance.ForeColor = System.Drawing.Color.Red;
            this.la_remol.Location = new System.Drawing.Point(103, 10);
            this.la_remol.Name = "la_remol";
            this.la_remol.Size = new System.Drawing.Size(98, 39);
            this.la_remol.TabIndex = 0;
            this.la_remol.Text = "0.0000";
            // 
            // panelControl27
            // 
            this.panelControl27.Controls.Add(this.label21);
            this.panelControl27.Controls.Add(this.l_changemoney);
            this.panelControl27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl27.Location = new System.Drawing.Point(2, 2);
            this.panelControl27.Name = "panelControl27";
            this.panelControl27.Size = new System.Drawing.Size(256, 27);
            this.panelControl27.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(5, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 22);
            this.label21.TabIndex = 5;
            this.label21.Text = "上单找零：";
            // 
            // l_changemoney
            // 
            this.l_changemoney.AutoSize = true;
            this.l_changemoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_changemoney.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.l_changemoney.Location = new System.Drawing.Point(99, 3);
            this.l_changemoney.Name = "l_changemoney";
            this.l_changemoney.Size = new System.Drawing.Size(75, 22);
            this.l_changemoney.TabIndex = 4;
            this.l_changemoney.Text = "0000.00";
            // 
            // panelControl18
            // 
            this.panelControl18.Controls.Add(this.label16);
            this.panelControl18.Controls.Add(this.l_paymoney);
            this.panelControl18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl18.Location = new System.Drawing.Point(3, 613);
            this.panelControl18.Name = "panelControl18";
            this.panelControl18.Size = new System.Drawing.Size(260, 27);
            this.panelControl18.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(5, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 22);
            this.label16.TabIndex = 3;
            this.label16.Text = "上单实收：";
            // 
            // l_paymoney
            // 
            this.l_paymoney.AutoSize = true;
            this.l_paymoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_paymoney.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.l_paymoney.Location = new System.Drawing.Point(100, 4);
            this.l_paymoney.Name = "l_paymoney";
            this.l_paymoney.Size = new System.Drawing.Size(75, 22);
            this.l_paymoney.TabIndex = 2;
            this.l_paymoney.Text = "0000.00";
            // 
            // panelControl19
            // 
            this.panelControl19.Controls.Add(this.label17);
            this.panelControl19.Controls.Add(this.l_realMoney);
            this.panelControl19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl19.Location = new System.Drawing.Point(3, 580);
            this.panelControl19.Name = "panelControl19";
            this.panelControl19.Size = new System.Drawing.Size(260, 27);
            this.panelControl19.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(5, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 22);
            this.label17.TabIndex = 7;
            this.label17.Text = "上单应收：";
            // 
            // l_realMoney
            // 
            this.l_realMoney.AutoSize = true;
            this.l_realMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_realMoney.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.l_realMoney.Location = new System.Drawing.Point(101, 2);
            this.l_realMoney.Name = "l_realMoney";
            this.l_realMoney.Size = new System.Drawing.Size(75, 22);
            this.l_realMoney.TabIndex = 8;
            this.l_realMoney.Text = "0000.00";
            // 
            // panelControl17
            // 
            this.panelControl17.Controls.Add(this.tb_member);
            this.panelControl17.Controls.Add(this.label15);
            this.panelControl17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl17.Location = new System.Drawing.Point(3, 516);
            this.panelControl17.Name = "panelControl17";
            this.panelControl17.Size = new System.Drawing.Size(260, 58);
            this.panelControl17.TabIndex = 4;
            // 
            // tb_member
            // 
            this.tb_member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_member.Location = new System.Drawing.Point(2, 16);
            this.tb_member.MaximumSize = new System.Drawing.Size(600, 38);
            this.tb_member.MinimumSize = new System.Drawing.Size(250, 38);
            this.tb_member.Name = "tb_member";
            this.tb_member.Size = new System.Drawing.Size(256, 38);
            this.tb_member.TabIndex = 1;
            this.tb_member.EditValueChanged += new System.EventHandler(this.tb_member_TextChanged_1);
            this.tb_member.DoubleClick += new System.EventHandler(this.tb_member_DoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(2, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "(F8)会员：";
            // 
            // panelControl14
            // 
            this.panelControl14.Controls.Add(this.tableLayoutPanel7);
            this.panelControl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl14.Location = new System.Drawing.Point(3, 400);
            this.panelControl14.Name = "panelControl14";
            this.panelControl14.Size = new System.Drawing.Size(260, 56);
            this.panelControl14.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.panelControl25, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panelControl26, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(256, 52);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // panelControl25
            // 
            this.panelControl25.Controls.Add(this.tb_submoney);
            this.panelControl25.Controls.Add(this.label12);
            this.panelControl25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl25.Location = new System.Drawing.Point(3, 3);
            this.panelControl25.Name = "panelControl25";
            this.panelControl25.Size = new System.Drawing.Size(122, 46);
            this.panelControl25.TabIndex = 0;
            // 
            // tb_submoney
            // 
            this.tb_submoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_submoney.Location = new System.Drawing.Point(2, 16);
            this.tb_submoney.MaximumSize = new System.Drawing.Size(300, 28);
            this.tb_submoney.MinimumSize = new System.Drawing.Size(120, 28);
            this.tb_submoney.Name = "tb_submoney";
            this.tb_submoney.Properties.Mask.EditMask = "n2";
            this.tb_submoney.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tb_submoney.Size = new System.Drawing.Size(120, 28);
            this.tb_submoney.TabIndex = 1;
            this.tb_submoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_submoney_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(2, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "去零头(F6)：";
            // 
            // panelControl26
            // 
            this.panelControl26.Controls.Add(this.tb_tyzk);
            this.panelControl26.Controls.Add(this.label20);
            this.panelControl26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl26.Location = new System.Drawing.Point(131, 3);
            this.panelControl26.Name = "panelControl26";
            this.panelControl26.Size = new System.Drawing.Size(122, 46);
            this.panelControl26.TabIndex = 1;
            // 
            // tb_tyzk
            // 
            this.tb_tyzk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_tyzk.EditValue = "0.00";
            this.tb_tyzk.Location = new System.Drawing.Point(2, 16);
            this.tb_tyzk.MaximumSize = new System.Drawing.Size(300, 28);
            this.tb_tyzk.MinimumSize = new System.Drawing.Size(120, 28);
            this.tb_tyzk.Name = "tb_tyzk";
            this.tb_tyzk.Size = new System.Drawing.Size(120, 28);
            this.tb_tyzk.TabIndex = 1;
            this.tb_tyzk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_tyzk_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Location = new System.Drawing.Point(2, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 14);
            this.label20.TabIndex = 0;
            this.label20.Text = "统一折扣:(F9)";
            // 
            // panelControl13
            // 
            this.panelControl13.Controls.Add(this.tb_remal_money);
            this.panelControl13.Controls.Add(this.label11);
            this.panelControl13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl13.Location = new System.Drawing.Point(3, 355);
            this.panelControl13.Name = "panelControl13";
            this.panelControl13.Size = new System.Drawing.Size(260, 39);
            this.panelControl13.TabIndex = 4;
            // 
            // tb_remal_money
            // 
            this.tb_remal_money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_remal_money.ForeColor = System.Drawing.Color.Red;
            this.tb_remal_money.Location = new System.Drawing.Point(2, 16);
            this.tb_remal_money.Name = "tb_remal_money";
            this.tb_remal_money.ReadOnly = true;
            this.tb_remal_money.Size = new System.Drawing.Size(256, 22);
            this.tb_remal_money.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(2, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "总实洋：";
            // 
            // panelControl12
            // 
            this.panelControl12.Controls.Add(this.t_total_money);
            this.panelControl12.Controls.Add(this.label10);
            this.panelControl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl12.Location = new System.Drawing.Point(3, 309);
            this.panelControl12.Name = "panelControl12";
            this.panelControl12.Size = new System.Drawing.Size(260, 40);
            this.panelControl12.TabIndex = 4;
            // 
            // t_total_money
            // 
            this.t_total_money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_total_money.Location = new System.Drawing.Point(2, 16);
            this.t_total_money.Name = "t_total_money";
            this.t_total_money.ReadOnly = true;
            this.t_total_money.Size = new System.Drawing.Size(256, 22);
            this.t_total_money.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(2, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "总码洋：";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panelControl10, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelControl11, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 253);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 50);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // panelControl10
            // 
            this.panelControl10.Controls.Add(this.tb_count);
            this.panelControl10.Controls.Add(this.label8);
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl10.Location = new System.Drawing.Point(133, 3);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(124, 44);
            this.panelControl10.TabIndex = 4;
            // 
            // tb_count
            // 
            this.tb_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_count.Location = new System.Drawing.Point(2, 16);
            this.tb_count.Name = "tb_count";
            this.tb_count.ReadOnly = true;
            this.tb_count.Size = new System.Drawing.Size(120, 22);
            this.tb_count.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(2, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "总品种数：";
            // 
            // panelControl11
            // 
            this.panelControl11.Controls.Add(this.tb_total_num);
            this.panelControl11.Controls.Add(this.label9);
            this.panelControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl11.Location = new System.Drawing.Point(3, 3);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(124, 44);
            this.panelControl11.TabIndex = 4;
            // 
            // tb_total_num
            // 
            this.tb_total_num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_total_num.Location = new System.Drawing.Point(2, 16);
            this.tb_total_num.Name = "tb_total_num";
            this.tb_total_num.ReadOnly = true;
            this.tb_total_num.Size = new System.Drawing.Size(120, 22);
            this.tb_total_num.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(2, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "总数量：";
            // 
            // panelControl9
            // 
            this.panelControl9.Controls.Add(this.tb_o_name);
            this.panelControl9.Controls.Add(this.label7);
            this.panelControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl9.Location = new System.Drawing.Point(3, 203);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(260, 44);
            this.panelControl9.TabIndex = 4;
            // 
            // tb_o_name
            // 
            this.tb_o_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_o_name.Location = new System.Drawing.Point(2, 16);
            this.tb_o_name.Name = "tb_o_name";
            this.tb_o_name.ReadOnly = true;
            this.tb_o_name.Size = new System.Drawing.Size(256, 22);
            this.tb_o_name.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(2, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "当前员工：";
            // 
            // panelControl8
            // 
            this.panelControl8.Controls.Add(this.cb_stock);
            this.panelControl8.Controls.Add(this.label6);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl8.Location = new System.Drawing.Point(3, 153);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(260, 44);
            this.panelControl8.TabIndex = 4;
            // 
            // cb_stock
            // 
            this.cb_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_stock.Enabled = false;
            this.cb_stock.FormattingEnabled = true;
            this.cb_stock.Location = new System.Drawing.Point(2, 16);
            this.cb_stock.Name = "cb_stock";
            this.cb_stock.Size = new System.Drawing.Size(256, 22);
            this.cb_stock.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "所属库房：";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.tb_ph);
            this.panelControl6.Controls.Add(this.label4);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl6.Location = new System.Drawing.Point(3, 53);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(260, 44);
            this.panelControl6.TabIndex = 4;
            // 
            // tb_ph
            // 
            this.tb_ph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ph.Location = new System.Drawing.Point(2, 16);
            this.tb_ph.Name = "tb_ph";
            this.tb_ph.ReadOnly = true;
            this.tb_ph.Size = new System.Drawing.Size(256, 22);
            this.tb_ph.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "批号：";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.cb_stand);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(3, 3);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(260, 44);
            this.panelControl3.TabIndex = 1;
            // 
            // cb_stand
            // 
            this.cb_stand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_stand.Enabled = false;
            this.cb_stand.FormattingEnabled = true;
            this.cb_stand.Location = new System.Drawing.Point(2, 16);
            this.cb_stand.Name = "cb_stand";
            this.cb_stand.Size = new System.Drawing.Size(256, 22);
            this.cb_stand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "台号：";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.cb_station);
            this.panelControl4.Controls.Add(this.label2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(3, 103);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(260, 44);
            this.panelControl4.TabIndex = 2;
            // 
            // cb_station
            // 
            this.cb_station.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_station.Enabled = false;
            this.cb_station.FormattingEnabled = true;
            this.cb_station.Location = new System.Drawing.Point(2, 16);
            this.cb_station.Name = "cb_station";
            this.cb_station.Size = new System.Drawing.Size(256, 22);
            this.cb_station.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "所属站点：";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panelControl16, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panelControl15, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 462);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(260, 48);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // panelControl16
            // 
            this.panelControl16.Controls.Add(this.l_type);
            this.panelControl16.Controls.Add(this.tb_Member_SurplusMoney);
            this.panelControl16.Controls.Add(this.label14);
            this.panelControl16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl16.Location = new System.Drawing.Point(133, 3);
            this.panelControl16.Name = "panelControl16";
            this.panelControl16.Size = new System.Drawing.Size(124, 42);
            this.panelControl16.TabIndex = 5;
            // 
            // l_type
            // 
            this.l_type.Location = new System.Drawing.Point(61, 2);
            this.l_type.Name = "l_type";
            this.l_type.Size = new System.Drawing.Size(0, 14);
            this.l_type.TabIndex = 2;
            this.l_type.Visible = false;
            // 
            // tb_Member_SurplusMoney
            // 
            this.tb_Member_SurplusMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Member_SurplusMoney.Location = new System.Drawing.Point(2, 16);
            this.tb_Member_SurplusMoney.Name = "tb_Member_SurplusMoney";
            this.tb_Member_SurplusMoney.ReadOnly = true;
            this.tb_Member_SurplusMoney.Size = new System.Drawing.Size(120, 22);
            this.tb_Member_SurplusMoney.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(2, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "卡内余额：";
            // 
            // panelControl15
            // 
            this.panelControl15.Controls.Add(this.l_member);
            this.panelControl15.Controls.Add(this.tb_menber_Integral);
            this.panelControl15.Controls.Add(this.label13);
            this.panelControl15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl15.Location = new System.Drawing.Point(3, 3);
            this.panelControl15.Name = "panelControl15";
            this.panelControl15.Size = new System.Drawing.Size(124, 42);
            this.panelControl15.TabIndex = 4;
            // 
            // l_member
            // 
            this.l_member.AutoSize = true;
            this.l_member.Location = new System.Drawing.Point(61, 2);
            this.l_member.Name = "l_member";
            this.l_member.Size = new System.Drawing.Size(69, 14);
            this.l_member.TabIndex = 2;
            this.l_member.Text = " <RETAIL>";
            this.l_member.Visible = false;
            // 
            // tb_menber_Integral
            // 
            this.tb_menber_Integral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_menber_Integral.Location = new System.Drawing.Point(2, 16);
            this.tb_menber_Integral.Name = "tb_menber_Integral";
            this.tb_menber_Integral.ReadOnly = true;
            this.tb_menber_Integral.Size = new System.Drawing.Size(120, 22);
            this.tb_menber_Integral.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(2, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "会员积分：";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42629F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.5151F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42629F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.63233F));
            this.tableLayoutPanel5.Controls.Add(this.panelControl23, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.panelControl22, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.panelControl20, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panelControl7, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 746);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1125, 65);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // panelControl23
            // 
            this.panelControl23.Controls.Add(this.lblStatus);
            this.panelControl23.Controls.Add(this.label19);
            this.panelControl23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl23.Location = new System.Drawing.Point(691, 3);
            this.panelControl23.Name = "panelControl23";
            this.panelControl23.Size = new System.Drawing.Size(431, 59);
            this.panelControl23.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(2, 16);
            this.lblStatus.Multiline = true;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblStatus.Size = new System.Drawing.Size(427, 41);
            this.lblStatus.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Location = new System.Drawing.Point(2, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 14);
            this.label19.TabIndex = 1;
            this.label19.Text = "系统信息：";
            // 
            // panelControl22
            // 
            this.panelControl22.Controls.Add(this.tb_sm);
            this.panelControl22.Controls.Add(this.label18);
            this.panelControl22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl22.Location = new System.Drawing.Point(462, 3);
            this.panelControl22.Name = "panelControl22";
            this.panelControl22.Size = new System.Drawing.Size(223, 59);
            this.panelControl22.TabIndex = 5;
            // 
            // tb_sm
            // 
            this.tb_sm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sm.Location = new System.Drawing.Point(2, 16);
            this.tb_sm.MaximumSize = new System.Drawing.Size(600, 38);
            this.tb_sm.MinimumSize = new System.Drawing.Size(217, 38);
            this.tb_sm.Name = "tb_sm";
            this.tb_sm.Size = new System.Drawing.Size(219, 38);
            this.tb_sm.TabIndex = 1;
            this.tb_sm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SkinTxt_KeyDown1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Location = new System.Drawing.Point(2, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 14);
            this.label18.TabIndex = 1;
            this.label18.Text = "(F4)书名：*为模糊标记";
            // 
            // panelControl20
            // 
            this.panelControl20.Controls.Add(this.tb_xy);
            this.panelControl20.Controls.Add(this.label5);
            this.panelControl20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl20.Location = new System.Drawing.Point(232, 3);
            this.panelControl20.Name = "panelControl20";
            this.panelControl20.Size = new System.Drawing.Size(224, 59);
            this.panelControl20.TabIndex = 4;
            // 
            // tb_xy
            // 
            this.tb_xy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_xy.Location = new System.Drawing.Point(2, 16);
            this.tb_xy.MaximumSize = new System.Drawing.Size(600, 38);
            this.tb_xy.MinimumSize = new System.Drawing.Size(217, 38);
            this.tb_xy.Name = "tb_xy";
            this.tb_xy.Size = new System.Drawing.Size(220, 38);
            this.tb_xy.TabIndex = 1;
            this.tb_xy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SkinTxt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(2, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "(F3)谐音：";
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.tb_isbn);
            this.panelControl7.Controls.Add(this.label3);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl7.Location = new System.Drawing.Point(3, 3);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(223, 59);
            this.panelControl7.TabIndex = 3;
            // 
            // tb_isbn
            // 
            this.tb_isbn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_isbn.Location = new System.Drawing.Point(2, 16);
            this.tb_isbn.MaximumSize = new System.Drawing.Size(600, 38);
            this.tb_isbn.MinimumSize = new System.Drawing.Size(217, 38);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(219, 38);
            this.tb_isbn.TabIndex = 1;
            this.tb_isbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SkinTxt_KeyDown2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "(F1)书号：";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.simpleButton2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.bt_delete, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1134, 746);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(270, 65);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.Location = new System.Drawing.Point(138, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(129, 59);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "收款(F5)";
            this.simpleButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_delete.Location = new System.Drawing.Point(3, 3);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(129, 59);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "置 零(del)";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PossUits
            // 
            this.ClientSize = new System.Drawing.Size(1411, 865);
            this.Controls.Add(this.panelControl24);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PossUits";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PossUits_FormClosing);
            this.Load += new System.EventHandler(this.PossUits_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl24)).EndInit();
            this.panelControl24.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl21)).EndInit();
            this.panelControl21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl28)).EndInit();
            this.panelControl28.ResumeLayout(false);
            this.panelControl28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl27)).EndInit();
            this.panelControl27.ResumeLayout(false);
            this.panelControl27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl18)).EndInit();
            this.panelControl18.ResumeLayout(false);
            this.panelControl18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl19)).EndInit();
            this.panelControl19.ResumeLayout(false);
            this.panelControl19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl17)).EndInit();
            this.panelControl17.ResumeLayout(false);
            this.panelControl17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_member.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl14)).EndInit();
            this.panelControl14.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl25)).EndInit();
            this.panelControl25.ResumeLayout(false);
            this.panelControl25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_submoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl26)).EndInit();
            this.panelControl26.ResumeLayout(false);
            this.panelControl26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tyzk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl13)).EndInit();
            this.panelControl13.ResumeLayout(false);
            this.panelControl13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl12)).EndInit();
            this.panelControl12.ResumeLayout(false);
            this.panelControl12.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.panelControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            this.panelControl11.ResumeLayout(false);
            this.panelControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            this.panelControl9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.panelControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl16)).EndInit();
            this.panelControl16.ResumeLayout(false);
            this.panelControl16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl15)).EndInit();
            this.panelControl15.ResumeLayout(false);
            this.panelControl15.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl23)).EndInit();
            this.panelControl23.ResumeLayout(false);
            this.panelControl23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl22)).EndInit();
            this.panelControl22.ResumeLayout(false);
            this.panelControl22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_sm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl20)).EndInit();
            this.panelControl20.ResumeLayout(false);
            this.panelControl20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_xy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_isbn.Properties)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        public PossUits()
        {
            InitializeComponent();
            this.IsMdiContainer = true;//设置为MDI窗体

            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;

            //是否可以修改数量或修改折扣
            this.tb_member.KeyDown += SkinTxt_KeyDown3;//会员事件
            this.tb_isbn.KeyDown += SkinTxt_KeyDown2; //商品H_ISBN回车事件

            this.winGridView1.GridView1.CellValueChanged += GridView1_CellValueChanged;//表格改变事件
            this.tb_xy.KeyDown += SkinTxt_KeyDown;//商品H_ISBN回车事件
            this.tb_sm.KeyDown += SkinTxt_KeyDown1;//商品书名回画事件
            this.winGridView1.GridView1.RowClick += GridView1_RowClick;//点击行事件
            this.KeyDown += PossUits_KeyDown;//键盘事件

           
        }



        /// <summary>
        /// 键盘事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PossUits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                int rowIndex = winGridView1.GridView1.FocusedRowHandle;
                if (rowIndex >= 0)
                {
                    bt_delete_Click(null, null);                    //删除某条明细
                }
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F5)
            {
                skinButton2_Click(null, null);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F1)
            {
                this.tb_isbn.Focus();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F8)
            {
                this.tb_member.Focus();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F3)
            {
                this.tb_xy.Focus();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F4)
            {
                this.tb_sm.Focus();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F6)
            {
                this.tb_submoney.Focus();
                this.tb_submoney.SelectAll();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F9)
            {
                this.tb_tyzk.Focus();
                this.tb_tyzk.SelectAll();
            }

        }


        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ColumnView view = (ColumnView)winGridView1.gridControl1.FocusedView;
            view.FocusedColumn = view.Columns["H_amount"];//焦点聚焦
            view.ShowEditor();//编辑单元格


        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            // ComputeTotal();
        }



        #region 加载事件
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PossUits_Load(object sender, EventArgs e)
        {
            this.tb_isbn.Enabled = false;
            this.tb_xy.Enabled = false;
            this.tb_sm.Enabled = false;
            this.tb_member.Enabled = false;

            this.WindowState = FormWindowState.Maximized;
            GetPh_id(O_id);
            if (PanDuanIs_DanBan() == false)
            {
                if (MessagboxUit.ShowYesNoAndTips("你当前没有“当班”现在开始当班吗？") == System.Windows.Forms.DialogResult.Yes)
                {
                    if (BLLFactory<DangBan>.Instance.Insert(danbaninfo))
                    {
                        DanBanFrom DB = new DanBanFrom();
                        DB.csinfo = danbaninfo;
                        DB.ShowDialog();
                        if (DB.YesOrNo)
                        {
                            this.tb_isbn.Enabled = true;
                            this.tb_xy.Enabled = true;
                            this.tb_sm.Enabled = true;
                            this.tb_member.Enabled = true;
                        }
                    }
                    else
                    {
                        MessagboxUit.ShowTips("未知错误！");
                    }
                }
                //else
                //{
                //    this.PossUits_FormClosing(null, null);//不安班退出软件
                //}
            }
            this.tb_isbn.Focus();
            tb_isbn.Select();
            Detection_tb_submoney();
            //小票打印初始化
            if (pintxiaopiao == null)
            {
                pintxiaopiao = new PrintDocument();
            }
            SetWindoForm();

        }
        private void SetWindoForm()
        {
            this.winGridView1.EnableMenu = false;
            this.winGridView1.GridView1.RowHeight = 40;//收变列高度
            this.winGridView1.GridView1.Appearance.Row.Font = new Font("Tahoma", 14);
            this.winGridView1.GridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 14);
            this.winGridView1.GridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 14);
            this.winGridView1.GridView1.Appearance.FooterPanel.BackColor = Color.Silver;
            this.winGridView1.GridView1.Appearance.FooterPanel.BorderColor = Color.Silver;
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("Ls_Sum", "c2", "合计:"));
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("H_amount", "n0"));
            //this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("Ls_Sum", "c2"));
            //DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit H_name = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            //DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit H_isbn = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.winGridView1.BestFitColumnWith = false;
            this.winGridView1.DisplayColumns = "H_isbn|H_name|H_output_price|H_amount|H_output_discount_ls|Ls_Sum";
            this.winGridView1.GridView1.OptionsView.RowAutoHeight = true;
            this.winGridView1.GridView1.BestFitColumns(true);
            this.winGridView1.ReadOnlyList.Add("H_isbn");
            this.winGridView1.ReadOnlyList.Add("H_name");
            this.winGridView1.ReadOnlyList.Add("H_output_price");
            this.winGridView1.ReadOnlyList.Add("Ls_Sum");
            if (Portal.gc.loginUserInfo.is_sl == "0")//控制 员工是否可以修改数量与折扣
            {
                this.winGridView1.ReadOnlyList.Add("H_amount");
                
            }
            if (Portal.gc.loginUserInfo.is_zk == "0")
            {
                this.winGridView1.ReadOnlyList.Add("H_output_discount_ls");
            }

            this.winGridView1.AddColumnAlias("h_isbn", "条码");
            this.winGridView1.AddColumnAlias("h_name", "商品名称");
            this.winGridView1.AddColumnAlias("h_amount", "数量");
            this.winGridView1.AddColumnAlias("H_output_price", "定价");
            this.winGridView1.AddColumnAlias("H_output_discount_ls", "折扣");
            this.winGridView1.AddColumnAlias("Ls_Sum", "合计");

            this.winGridView1.DataSource = Productlist;
        }


        #endregion

        #region 获取PH或者更新Ph
        /// <summary>
        /// 获取PH或者更新Ph
        /// </summary>
        /// <param name="o_id">员工ID</param>
        /// <returns></returns>
        public string GetPh_id(string o_id)
        {
            string Result = string.Empty;
            if (o_id != null)
            {
                string ph_id = BLLFactory<Ph>.Instance.GetPh_id(o_id);

                if (!string.IsNullOrEmpty(ph_id))
                {
                    bool TrueOrFalse = false;
                    TrueOrFalse = BLLFactory<Ph>.Instance.Update_PH_id(ph_id);//更新批号时间
                    if (TrueOrFalse)
                    {
                        bool yNo = BLLFactory<Ph>.Instance.update_Ph_id_commit(ph_id);//更新批号状态
                        if (yNo)
                        {
                            bool k = BLLFactory<Ph>.Instance.update_Ph_stand_id(ph_id, Portal.gc.loginUserInfo.Yh_stand_id);//更新台号信息
                            if (k)
                            {
                                //sellinfo.O_id = userinfo.O_id;
                                tb_o_name.Text = Portal.gc.loginUserInfo.O_Name;
                                tb_ph.Text = ph_id;
                                SetComBox();

                            }
                        }
                    }
                    this.tb_ph.Text = ph_id.ToUpper();
                }
                else
                {
                    if (Portal.gc.loginUserInfo.O_Name != "administrator")
                    {

                        if (MessagboxUit.ShowYesNoAndTips("批号不存在！是否请增批号？") == DialogResult.Yes)
                        {
                            bool result = false;
                            PhInfo phinfo = new PhInfo();
                            phinfo = SetPhInfo(userinfo);
                            result = BLLFactory<Ph>.Instance.Insert_PH(phinfo);
                            if (!result)
                            {
                                MessagboxUit.ShowError("插入批量出现问题~！");
                            }
                            else
                            {

                                SetComBox();
                                tb_o_name.Text = Portal.gc.loginUserInfo.O_Name;
                                string phh_id = BLLFactory<Ph>.Instance.GetPh_id(o_id);
                                tb_ph.Text = phh_id;
                            }
                        }
                    }
                    else
                    {
                        this.tb_isbn.ReadOnly = true;
                        this.tb_xy.ReadOnly = true;
                        this.tb_sm.ReadOnly = true;
                    }

                }
            }


            return Result;
        }
        #endregion

        #region 设置更新Ph必要条件
        /// <summary>
        /// 设置更新Ph必要条件
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public PhInfo SetPhInfo(UsersInfo userinfo)
        {
            DateTime date = DateTime.Now;
            PhInfo phinfo = new PhInfo();
            phinfo.Input_date = date;
            phinfo.Is_commit = "1";
            phinfo.O_id = Portal.gc.loginUserInfo.O_id;
            phinfo.Last_mod_date = date;
            phinfo.Off_time = date;
            phinfo.On_time = date;
            phinfo.Stand_id = Portal.gc.loginUserInfo.Yh_stand_id;
            phinfo.Station_id = Portal.gc.loginUserInfo.Station_ID;

            return phinfo;
        }
        #endregion

        #region 邦定combox数据库值
        /// <summary>
        /// 邦定combox数据库值
        /// </summary>
        public void SetComBox()
        {
            cb_stock.DisplayMember = "S_name";
            cb_stock.ValueMember = "S_id";
            cb_stock.DataSource = BLLFactory<Users>.Instance.GetStocks_idByName();
            cb_stock.SelectedValue = Portal.gc.loginUserInfo.Stock_id;

            cb_station.DisplayMember = "Station_name";
            cb_station.ValueMember = "Station_id";
            cb_station.DataSource = BLLFactory<Users>.Instance.GetSatation_idByName();
            cb_station.SelectedValue = Portal.gc.loginUserInfo.Station_ID;

            cb_stand.DisplayMember = "Stand_name";
            cb_stand.ValueMember = "Stand_id";
            cb_stand.DataSource = BLLFactory<Users>.Instance.GetStand_idByName();
            cb_stand.SelectedValue = Portal.gc.loginUserInfo.Yh_stand_id;

        }



        #endregion

        #region 根据 条件查询 书目信息
        /// <summary>
        /// 根据 条件查询 书目信息
        /// </summary>
        /// <param name="where">要传入的where条件</param>
        /// <param name="m_id">会员编号</param>
        /// <param name="staton_iid">站点信息</param>
        /// <param name="WHC_Num">显示条数</param>
        /// <returns></returns>
        /// 
        List<SimpleProductInfo> xxlist = null;//一号多书判断重复所用
        List<SimpleProductInfo> kklists = null;//一号多书判断重复所用

        private bool SearchProduct(string where, string m_id, string staton_iid, string WHC_Num)
        {
            // DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(POSS.WaitFormSeach));//开启等待控件
            this.Cursor = Cursors.WaitCursor;//改变鼠标样式
            bool result = false;
            List<SimpleProductInfo> list = null;
            List<SimpleProductInfo> infolist = new List<SimpleProductInfo>();//准备合并相当品种的 list
            string sqlwhere = string.Empty;
            sqlwhere = where;
            list = new List<SimpleProductInfo>();
            string mm_id = m_id;
            list = BLLFactory<Product>.Instance.Get_simpleproduct(sqlwhere, staton_iid, mm_id, WHC_Num);
            if (list.Count == 1)
            {
                infolist = Productlist;
                if (PanDuanShuHaoChongFu(list))//判断是不是重复品种
                {
                    if (MessagboxUit.ShowYesNoAndTips("已有此品种是否增加?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        infolist.AddRange(list);//只有一条的直接加入到商品列表里
                                                //TODO:这里可能要用一个单品多行。因为如果员工没有置零权后 没法在一张零售单上减数量
                        Productlist = MergeListJoinMember(infolist);//代会员的合并
                        winGridView1.DataSource = null;
                        winGridView1.DataSource = Productlist;
                        SetGeShi();
                        winGridView1.GridView1.RefreshData();
                        //解决:扫码后光标跟到跑~！
                        winGridView1.GridView1.MoveLast();
                        result = true;
                    }
                    else
                    {
                        return result = true;//这里也返回true是上面以经找到 但是不想增加数量 没有必要要去检索h-mytm了
                    }

                }
                else
                {
                    infolist.AddRange(list);//只有一条的直接加入到商品列表里
                    Productlist = MergeListJoinMember(infolist);//代会员的合并
                    winGridView1.DataSource = null;
                    winGridView1.DataSource = Productlist;
                    SetGeShi();
                    winGridView1.GridView1.RefreshData();
                    //解决:扫码后光标跟到跑~！
                    winGridView1.GridView1.MoveLast();
                    result = true;
                }

            }
            else if (list.Count == 0)
            {
                result = false;
                if (result == false && tb_isbn.Text.Trim().Length == 0)//判断用于条码查询
                {
                    MessagboxUit.ShowTips("没有检索到数据！");
                }
            }
            else if (list.Count > 1)
            {
                InputMoveProductInfo move = new InputMoveProductInfo();//多书目选择框
                move.MoveProductList = null;
                move.MoveProductList = list;
                move.ShowDialog();
                move.Dispose();
                this.SelectProductlist.Clear();
                this.SelectProductlist = move.MoveSelectedList;
                xxlist = new List<SimpleProductInfo>();//过读list
                                                       //TODO:多选结果 提示是否重复
                xxlist = Productlist;
                kklists = new List<SimpleProductInfo>();

                foreach (var item in SelectProductlist.ToArray())//这里为什么用ToArray啦 防止 报 “集合已修改;可能无法执行枚举操作”
                {
                    YiHaoDuoSuPanDuanChongFu(item);
                }
                xxlist.AddRange(SelectProductlist);
                Productlist = MergeListJoinMember(xxlist);
                winGridView1.DataSource = null;
                winGridView1.DataSource = Productlist;
                SetGeShi();
                winGridView1.GridView1.RefreshData();
                //解决:扫码后光标跟到跑~！
                winGridView1.GridView1.MoveLast();
                result = true;
            }

            // DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();//关闭等待控件
            // // 设置鼠标默认状态
            this.Cursor = Cursors.Default;

            return result;

        }
        /// <summary>
        /// 查询启用单品多行
        /// </summary>
        /// <param name="where"></param>
        /// <param name="m_id"></param>
        /// <param name="staton_iid"></param>
        /// <param name="WHC_Num"></param>
        /// <returns></returns>
        private bool SearchProductToOney(string where, string m_id, string staton_iid, string WHC_Num)
        {
            this.Cursor = Cursors.WaitCursor;//改变鼠标样式
            bool result = false;
            List<SimpleProductInfo> list = null;
            List<SimpleProductInfo> infolist = new List<SimpleProductInfo>();//准备合并相当品种的 list
            string sqlwhere = string.Empty;
            sqlwhere = where;
            list = new List<SimpleProductInfo>();
            string mm_id = m_id;
            list = BLLFactory<Product>.Instance.Get_simpleproduct(sqlwhere, staton_iid, mm_id, WHC_Num);
            foreach (var item in list)
            {
                string k = BLLFactory<Product_discount_clientjb>.Instance.GetProduct_h_risediscount(item.H_id, l_member.Text.Trim());
                if (!string.IsNullOrEmpty(k))
                {
                    item.H_output_discount_ls = k.ToDecimal();
                }
                else
                {
                    item.H_output_discount_ls = BLLFactory<Product>.Instance.GetMemberDiscountByProduct(item.H_id, Portal.gc.loginUserInfo.Station_ID, l_member.Text.Trim(), item.H_amount, item.H_output_price);
                }
                item.Ls_Sum = item.H_output_price * item.H_output_discount_ls * item.H_amount;
            }
            if (list.Count == 1)
            {
                infolist = Productlist;
                infolist.AddRange(list);
                Productlist = infolist;
                winGridView1.DataSource = null;
                winGridView1.DataSource = Productlist;
                SetGeShi();
                winGridView1.GridView1.RefreshData();
                //解决:扫码后光标跟到跑~！
                winGridView1.GridView1.MoveLast();
                result = true;
            }
            else if (list.Count == 0)
            {
                result = false;
                if (result == false && tb_isbn.Text.Trim().Length == 0)//判断用于条码查询
                {
                    MessagboxUit.ShowTips("没有检索到数据！");
                }
            }
            else if (list.Count > 1)
            {
                InputMoveProductInfo move = new InputMoveProductInfo();//多书目选择框
                move.MoveProductList = null;
                move.MoveProductList = list;
                move.ShowDialog();
                move.Dispose();
                this.SelectProductlist.Clear();
                this.SelectProductlist = move.MoveSelectedList;
                xxlist = new List<SimpleProductInfo>();//过读list
                                                       //TODO:多选结果 提示是否重复
                xxlist = Productlist;
                xxlist.AddRange(SelectProductlist);
                Productlist = xxlist;
                winGridView1.DataSource = null;
                winGridView1.DataSource = Productlist;
                SetGeShi();
                winGridView1.GridView1.RefreshData();
                //解决:扫码后光标跟到跑~！
                winGridView1.GridView1.MoveLast();
                result = true;
            }

            this.Cursor = Cursors.Default;

            return result;
        }
        /// <summary>
        /// 一号多书去判断是否有重复书
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        private void YiHaoDuoSuPanDuanChongFu(SimpleProductInfo info)
        {

            for (int i = 0; i < xxlist.Count; i++)
            {
                if (info.H_id == xxlist[i].H_id)
                {
                    if (MessagboxUit.ShowYesNoAndTips(string.Format("已有【{0}】品种是否增加?", info.H_name)) == System.Windows.Forms.DialogResult.No)
                    {

                        SelectProductlist.Remove(info);
                    }

                }

            }

        }



        #region 书号，书名 谐音 查询书目信息

        private void SkinTxt_KeyDown1(object sender, KeyEventArgs e)
        {
            string text = this.tb_sm.Text.TrimEnd();
            text = text.Replace('　', ' ');
            text = text.Replace("'", "");
            //解决：把用*号代替%号
            text = text.Replace("*", "%");
            string sqlwhere = string.Format(" and db_product.h_name like '%{0}%'", text);
            string m_id = this.l_member.Text.Trim();
            string station_id = Portal.gc.loginUserInfo.Station_ID.Trim();
            string whc_mun = Portal.gc.QPossConfig.Taosu.Trim();
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    //if (Portal.gc.loginUserInfo.is_zl.Trim() == "1")
                    //{
                    //    SearchProductToOney(sqlwhere, m_id, station_id, whc_mun);
                    //}
                    //else
                    //{
                        SearchProduct(sqlwhere, m_id, station_id, whc_mun);
                    //}

                    this.tb_xy.Text = "";
                    this.tb_isbn.Text = "";
                    this.tb_sm.Text = "";
                    ComputeTotal();
                }
            }
        }

        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            string text = this.tb_xy.Text.TrimEnd();
            text = text.Replace('　', ' ');
            text = text.Replace("'", "");
            text = text.Replace("*", "%");
            string sqlwhere = string.Format(" and db_product.my_help_input like '%{0}%'", text);
            string m_id = this.l_member.Text.Trim();
            string station_id = Portal.gc.loginUserInfo.Station_ID.Trim();
            string whc_mun = Portal.gc.QPossConfig.Taosu.Trim();
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (!string.IsNullOrEmpty(text))
                {

                    //if (Portal.gc.loginUserInfo.is_zl.Trim() == "1")
                    //{
                    //    SearchProductToOney(sqlwhere, m_id, station_id, whc_mun);
                    //}
                    //else
                    //{
                        SearchProduct(sqlwhere, m_id, station_id, whc_mun);
                    //}
                    this.tb_xy.Text = "";
                    this.tb_isbn.Text = "";
                    this.tb_sm.Text = "";
                    ComputeTotal();
                }
            }


        }


        /// <summary>
        /// 商品H_ISBN回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinTxt_KeyDown2(object sender, KeyEventArgs e)
        {

            string text = this.tb_isbn.Text.TrimEnd();
            text = text.Replace('　', ' ');
            text = text.Replace("'", "");
            text = text.Replace("*", "%");
            string sqlwhere = string.Format(" and db_product.h_isbn = '{0}'", text);
            string m_id = this.l_member.Text.Trim();
            string station_id = Portal.gc.loginUserInfo.Station_ID.Trim();
            string whc_mun = Portal.gc.QPossConfig.Taosu.Trim();
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    this.tb_xy.Text = "";
                    this.tb_sm.Text = "";
                    //if (Portal.gc.loginUserInfo.is_zl.Trim() == "1")
                    //{
                    //    if (SearchProductToOney(sqlwhere, m_id, station_id, whc_mun) == false)
                    //    {
                    //        sqlwhere = string.Format(" and db_product.h_mytm='{0}'", text);
                    //        // string text = tb_isbn.Text.Trim();
                    //        this.tb_xy.Text = "";
                    //        this.tb_isbn.Text = "";
                    //        this.tb_sm.Text = "";
                    //        List<SimpleProductInfo> list = null;
                    //        List<SimpleProductInfo> infolist = new List<SimpleProductInfo>();//准备合并相当品种的 list
                    //        list = new List<SimpleProductInfo>();
                    //        list = BLLFactory<Product>.Instance.Get_simpleproduct(sqlwhere, station_id, m_id, whc_mun);
                    //        SearchProductToOney(sqlwhere, m_id, station_id, whc_mun);
                    //    }
                    //    else
                    //    {
                    //        this.tb_xy.Text = "";
                    //        this.tb_isbn.Text = "";
                    //        this.tb_sm.Text = "";
                    //    }
                    //}
                    //else
                    //{
                        if (SearchProduct(sqlwhere, m_id, station_id, whc_mun) == false)
                        {
                            sqlwhere = string.Format(" and db_product.h_mytm='{0}'", text);
                            // string text = tb_isbn.Text.Trim();
                            this.tb_xy.Text = "";
                            this.tb_isbn.Text = "";
                            this.tb_sm.Text = "";
                            List<SimpleProductInfo> list = null;
                            List<SimpleProductInfo> infolist = new List<SimpleProductInfo>();//准备合并相当品种的 list
                            list = new List<SimpleProductInfo>();
                            list = BLLFactory<Product>.Instance.Get_simpleproduct(sqlwhere, station_id, m_id, whc_mun);
                            SearchProduct(sqlwhere, m_id, station_id, whc_mun);
                        }
                        else
                        {
                            this.tb_xy.Text = "";
                            this.tb_isbn.Text = "";
                            this.tb_sm.Text = "";
                        }
                    //}

                    //if (SearchProduct(sqlwhere, m_id, station_id, whc_mun) == false)
                    //{
                    //    sqlwhere = string.Format(" and db_product.h_mytm='{0}'", text);
                    //    // string text = tb_isbn.Text.Trim();
                    //    this.tb_xy.Text = "";
                    //    this.tb_isbn.Text = "";
                    //    this.tb_sm.Text = "";
                    //    List<SimpleProductInfo> list = null;
                    //    List<SimpleProductInfo> infolist = new List<SimpleProductInfo>();//准备合并相当品种的 list
                    //    list = new List<SimpleProductInfo>();
                    //    list = BLLFactory<Product>.Instance.Get_simpleproduct(sqlwhere, station_id, m_id, whc_mun);
                    //    SearchProduct(sqlwhere, m_id, station_id, whc_mun);

                    //}
                    //else
                    //{
                    //    this.tb_xy.Text = "";
                    //    this.tb_isbn.Text = "";
                    //    this.tb_sm.Text = "";
                    //}

                    ComputeTotal();
                }
            }


        }
        /// <summary>
        /// 条码搜索
        /// </summary>
        private void productToH_mytm()
        {
            string sqlwhere = string.Format(" and db_product.h_mytm='{0}'", this.tb_isbn.Text.Trim().Replace("'", ""));
            string m_id = this.l_member.Text.Trim();
            string station_id = Portal.gc.loginUserInfo.Station_ID.Trim();
            string whc_mun = Portal.gc.QPossConfig.Taosu.Trim();
            if (!string.IsNullOrEmpty(this.tb_isbn.Text))
            {
                ComputeTotal();
            }

        }

        #endregion


        #endregion

        #region 系统设置
        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (systemform == null || systemform.IsDisposed)
            {
                if (Portal.gc.loginUserInfo.O_Name == "administrator")
                {
                    systemform = new SystemFrom();
                    systemform.Show(this);
                }
                else
                {
                    //SystemFrom sf = new SystemFrom();
                    //sf.Close();
                    MessagboxUit.ShowError("请用超级管理员登录！");

                }
            }


        }
        #endregion

        #region 设置显示格式
        /// <summary>
        /// 设置显示格式
        /// </summary>
        public void SetGeShi()
        {

            this.winGridView1.GridView1.Columns["H_amount"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["H_output_discount_ls"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["H_amount"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //this.winGridView1.GridView1.Columns["U_id"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["H_output_discount_ls"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView1.GridView1.Columns["Ls_Sum"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


            this.winGridView1.GridView1.Columns["H_output_price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.winGridView1.GridView1.Columns["H_output_price"].DisplayFormat.FormatString = "c2";
            this.winGridView1.GridView1.Columns["Ls_Sum"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.winGridView1.GridView1.Columns["Ls_Sum"].DisplayFormat.FormatString = "c2";
            //this.winGridView1.GridView1.Columns["Sub_money"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //this.winGridView1.GridView1.Columns["Sub_money"].DisplayFormat.FormatString = "c2";
            this.winGridView1.GridView1.Columns["H_output_discount_ls"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.winGridView1.GridView1.Columns["H_output_discount_ls"].DisplayFormat.FormatString = "p2";
        }
        #endregion

        #region 数量与折扣更改后改变

        /// <summary>
        /// 表格改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "H_amount" || e.Column.FieldName == "H_output_discount_ls")
            {
                ComputeRow(e.RowHandle);
                if (e.Column.FieldName == "H_output_discount_ls")
                {
                    float k = e.Value.ToString().ToFloat();
                    if (k >= 0 && k <= 1)
                    {
                        return;
                    }
                    else
                    {
                        MessagboxUit.ShowError("折扣在0到1之间！");
                    }
                }
            }
            ComputeTotal();//计算汇总

            winGridView1.GridView1.RefreshData();

            //解决:数入完数量后 光标不到F1的位置
            this.tb_isbn.Select();

        }

        /// <summary>
        /// 计算汇总
        /// </summary>

        //TODO:扫一同一书提示是否需要新增数量
        private void ComputeTotal()
        {
            var query = from item in Productlist
                        group item by item.H_id
                            into newitem
                        select new
                        {
                            h_id = newitem.Key,
                            ls_sum = newitem.Sum(item => item.H_amount * item.H_output_discount_ls * item.H_output_price),
                            total_amount = newitem.Sum(item => item.H_amount),
                            total_count = newitem.Count(),
                            total_money = newitem.Sum(item => item.H_amount * item.H_output_price),
                            real_money_avoid = newitem.Sum(item => item.H_serial_book == "系统书" ? 0 : item.H_amount * item.H_output_price * item.H_output_discount_ls)//系统书积0分  如果不是积实洋
                        };
            this.Ls_Sum = query.Sum(item => item.ls_sum).ToRound(EnumHelper.GetInstance<RoundType>(Portal.gc.QPossConfig.Ls_qltfs));//  通过字符串获取枚举成员
            this.SubMoney = Ls_Sum - query.Sum(item => item.ls_sum);
            this.tb_submoney.Text = SubMoney.ToString("#0.00");
            this.real_money_avoid = query.Sum(item => item.real_money_avoid);

            this.tb_remal_money.Text = Ls_Sum.ToString("#0.00"); // Math.Round( Ls_Sum,3).ToString();//第三位开始四舍5信 或都tostring("#0.000")
            this.la_remol.Text = this.tb_remal_money.Text;
            this.tb_total_num.Text = query.Sum(item => item.total_amount).ToString();
            this.tb_count.Text = string.Format("{0:n0}", query.Sum(item => item.total_count));
            this.total_money = query.Sum(item => item.total_money);
            this.t_total_money.Text = string.Format("{0:c2}", total_money);

        }

        private void ComputeRow(int rowIndex)
        {
            SimpleProductInfo liinfo = new SimpleProductInfo();
            liinfo = (SimpleProductInfo)winGridView1.GridView1.GetRow(rowIndex);
            //LsItemInfo itemInfo = ContaineTOLsItemInfo(liinfo);
            if (liinfo == null) return;
            winGridView1.GridView1.SetRowCellValue(rowIndex, "Ls_Sum", liinfo.H_output_price * liinfo.H_amount * liinfo.H_output_discount_ls);
            // winGridView1.GridView1.SetRowCellValue(rowIndex, "Ls_Sum", itemInfo.H_price * itemInfo.H_amount * (1 - itemInfo.H_discount));
        }

        #endregion

        #region 保存前转换 与合并相同品种
        #region MyRegion


        //public List<SimpleProductInfo> MergeList(List<SimpleProductInfo> prlist)
        //{
        //    List<SimpleProductInfo> mergelist = new List<SimpleProductInfo>();
        //    SimpleProductInfo Mergeinfo = null;


        //    //foreach (var item in query)
        //    //{
        //    //    Mergeinfo = new SimpleProductInfo();

        //    //    Mergeinfo.H_id = item.h_id;
        //    //    Mergeinfo.H_amount = item.h_amount_ls;
        //    //    Mergeinfo.H_output_price = item.h_price;
        //    //    Mergeinfo.H_name = item.h_name;
        //    //    Mergeinfo.H_output_discount_ls = item.h_output_discount_ls;
        //    //    Mergeinfo.Ls_Sum = Mergeinfo.H_amount * Mergeinfo.H_output_price * Mergeinfo.H_output_discount_ls;
        //    //    Mergeinfo.H_isbn = item.h_isbn;
        //    //    Mergeinfo.H_Member_Ls = item.h_member_ls;
        //    //    //库房编码,如用户未指定库位或者为:AUTO则自动获取uf_GetStockId函数中的库位编码
        //    //    Mergeinfo.S_id = (string.IsNullOrEmpty(item.s_id) || item.s_id == "AUTO") ? BLLFactory<Product>.Instance.GetStockByProductType(Mergeinfo.H_id, Portal.gc.loginUserInfo.Station_ID) : item.s_id;
        //    //    mergelist.Add(Mergeinfo);
        //    //}
        //    //return mergelist;
        //}
        #endregion

        /// <summary>
        /// 判断是否重复
        /// </summary>
        /// <param name="prlist"></param>
        /// <returns></returns>
        private bool PanDuanShuHaoChongFu(List<SimpleProductInfo> prlist)
        {
            bool result = false;
            if (Productlist.Count == 0) return false;
            for (int i = 0; i < Productlist.Count; i++)
            {
                result = prlist.TrueForAll(m => m.H_id == Productlist[i].H_id);
                if (result) return result;
            }


            return result;

        }


        /// <summary>
        /// 存前转换 与合并相同品种 (代会员)
        /// </summary>
        /// <param name="prlist"></param>
        /// <returns></returns>
        public List<SimpleProductInfo> MergeListJoinMember(List<SimpleProductInfo> prlist)
        {
            List<SimpleProductInfo> mergelist = new List<SimpleProductInfo>();
            SimpleProductInfo Mergeinfo = null;
            var query = from item in prlist
                        group item by item.H_id
                      into newitem
                        select new
                        {
                            h_id = newitem.Key,
                            h_amount_ls = newitem.Sum(item => item.H_amount),
                            h_price = newitem.Max(item => item.H_output_price),
                            //h_member_ls = newitem.Min(item => item.H_Member_Ls),
                            h_output_discount_ls = newitem.Min(item => item.H_output_discount_ls),
                            h_name = newitem.Max(item => item.H_name),
                            h_isbn = newitem.Max(item => item.H_isbn),
                            s_id = Portal.gc.loginUserInfo.Stock_id,
                            h_type = newitem.Max(item => item.H_type),
                            m_id = newitem.Max(item => item.M_id),
                            h_serial_book = newitem.Max(item => item.H_serial_book),

                        };
            foreach (var item in query)
            {
                Mergeinfo = new SimpleProductInfo();

                Mergeinfo.H_id = item.h_id;
                Mergeinfo.H_amount = item.h_amount_ls;
                Mergeinfo.H_output_price = item.h_price;
                //Mergeinfo.H_Member_Ls = item.h_member_ls;
                Mergeinfo.H_name = item.h_name;
                string k = BLLFactory<Product_discount_clientjb>.Instance.GetProduct_h_risediscount(item.h_id, l_member.Text.Trim());
                if (!string.IsNullOrEmpty(k))
                {
                    Mergeinfo.H_output_discount_ls = k.ToDecimal();
                }
                else
                {
                    Mergeinfo.H_output_discount_ls = BLLFactory<Product>.Instance.GetMemberDiscountByProduct(item.h_id, Portal.gc.loginUserInfo.Station_ID, l_member.Text.Trim(), item.h_amount_ls, item.h_price);
                }
                Mergeinfo.Ls_Sum = Mergeinfo.H_amount * Mergeinfo.H_output_price * Mergeinfo.H_output_discount_ls;
                Mergeinfo.H_isbn = item.h_isbn;
                //库房编码,如用户未指定库位或者为:AUTO则自动获取uf_GetStockId函数中的库位编码
                Mergeinfo.S_id = (string.IsNullOrEmpty(item.s_id) || item.s_id == "AUTO") ? BLLFactory<Product>.Instance.GetStockByProductType(Mergeinfo.H_id, Portal.gc.loginUserInfo.Station_ID) : item.s_id;

                Mergeinfo.H_serial_book = item.h_serial_book;
                mergelist.Add(Mergeinfo);

            }
            return mergelist;
        }
        #endregion

        #region 退出
        private void PossUits_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Productlist.Count != 0)
            {
                MessagboxUit.ShowTips("还有零售数据,不能退出！");
                e.Cancel = true;//取消关闭！
                return;
            }
            else
            {
                this.winGridView1.SaveGridParm();//关闭写入INI文件 宽度 位置等信息  GridView里的
                this.Dispose();
                System.Environment.Exit(0); //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。
            }


            // System.Diagnostics.Process.GetCurrentProcess().Kill();

        }


        #endregion



        #region 删除一行明细
        /// <summary>
        /// 置零功能
        /// </summary>
        /// <param name="rowIndex"></param>
        private void DeleteItem(int rowIndex)
        {
            SimpleProductInfo info = new SimpleProductInfo();
            info = (SimpleProductInfo)winGridView1.GridView1.GetRow(rowIndex);
            if (MessagboxUit.ShowYesNoAndWarning(string.Format("名称：{0}\r\n条码：{1}\n\r数量：{2}\n\r确认要删除吗?", info.H_name, info.H_isbn, info.H_amount)) == System.Windows.Forms.DialogResult.Yes)
            {
                winGridView1.GridView1.DeleteRow(rowIndex);
                winGridView1.GridView1.MoveBy(0);
            }
        }
        /// <summary>
        ///置零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (Portal.gc.loginUserInfo.is_zl.Trim() != "0" && Portal.gc.loginUserInfo.is_sl == "0")// 判断是否有置零权
            {
                int rowIndex = winGridView1.GridView1.FocusedRowHandle;
                if (rowIndex >= 0)
                {
                    //DeleteItem(rowIndex);
                    Productlist[rowIndex].H_amount = 0;

                    winGridView1.DataSource = null;
                    winGridView1.DataSource = Productlist;
                    SetGeShi();
                    ComputeTotal();
                    winGridView1.gridView1.RefreshData();
                }
            }
            else
            {
                MessagboxUit.ShowTips("你没有置零权限！");
            }

        }
        #endregion

        #region 收款按建
        /// <summary>
        /// 收款按建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (Productlist.Count == 0) return;

            this.payedList.Clear();
            FrmPay.Payed = false;
            FrmPay.ShowPay(SetRemal_money(), cdmember);
            if (FrmPay.Payed)
            {
                this.payedList.AddRange(FrmPay.PayedList);
                this.youfeijinger = FrmPay.youfeijinger;
                if (!string.IsNullOrEmpty(this.youfeijinger))
                {
                    string[] k = this.youfeijinger.Split('|');
                    youfeibeizhu = k[0];
                    decimal.TryParse(k[1], out youfeimoney);
                }
                Save();
            }
        }
        private void Save()
        {
            Cursor = Cursors.WaitCursor;
            this.saveBackgroundWorker = new BackgroundWorker();
            saveBackgroundWorker.DoWork += SaveBackgroundWorker_DoWork;
            saveBackgroundWorker.RunWorkerCompleted += SaveBackgroundWorker_RunWorkerCompleted;
            while (saveBackgroundWorker.IsBusy) { }
            saveBackgroundWorker.RunWorkerAsync();
            this.SetStatus("正在提交...");
        }

        private void SaveBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Saveing();
        }

        private void SaveBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Saveed();
        }
        private void Saveing()
        {
            paylist = PaylistMerge();
            lsinfo = SetLsInfo();//得到主表信息
            QueryPaymethods kk = payedList.Find(pay => pay.Pay_id == "####");//判断是不 是 爱书卡 消费
            if (kk != null)
            {
                lsinfo.Ls_flag = "3";//爱书卡消费 值为3  正在零售为 0
            }
            if (Portal.gc.loginUserInfo.is_zl.Trim() == "1")
            {
                List<SimpleProductInfo> huobinglist = new List<SimpleProductInfo>();
                huobinglist = Productlist;
                ItemList = SetLsItemInfo(MergeListJoinMember(huobinglist));
            }
            else
            {
                ItemList = SetLsItemInfo(Productlist);//得到细表信息
            }


            // this.payedList 收款条目信息
            WanZhengLsInfo = new LsInfo();
            WanZhengLsInfo = BLLFactory<Pos_muli_pay>.Instance.Save(lsinfo, ItemList, paylist);

        }
        private void Saveed()
        {
            this.Cursor = Cursors.Default;
            if (string.IsNullOrEmpty(WanZhengLsInfo.Ls_id))
            {
                MessagboxUit.ShowError(BLLFactory<Pos_muli_pay>.Instance.SqlErrorText());
            }
            else
            {
                this.SetStatus(string.Format("提交成功!单号:{0}", WanZhengLsInfo.Ls_id));
                l_paymoney.Text = string.Format("{0:c2}", paymoney);
                l_changemoney.Text = string.Format("{0:c2}", changemoney);
                l_realMoney.Text = string.Format("{0:c2}", Ls_Sum);
                //:打印方法。。。。。。。。
                if (Productlist.Sum(k => k.H_amount) != 0)//判断明细表的数量是否为0 如果为0不打印不出库
                {
                    Priont();
                    StockArrear();
                    #region 前台奖励
                    if (Portal.gc.QPossConfig.Is_qtjl == "1")//是否选择前台奖励
                    {
                        if (l_member.Text != " <RETAIL>")//判断是不是会员
                        {
                            if (cdmember != null)
                            {
                                List<QueryMemberRewardInfo> rewadlist = new List<QueryMemberRewardInfo>();
                                rewadlist.AddRange(BLLFactory<Member_reward_run>.Instance.GetMemberReward(cdmember));
                                if (rewadlist.Count == 0)
                                {

                                }
                                else
                                {
                                    foreach (var item in rewadlist)
                                    {
                                        if (item.Mr_condition <= cdmember.Integral)
                                        {
                                            FromQueryMemberRawRun f = new FromQueryMemberRawRun();
                                            f.csmemberinfo = this.cdmember;
                                            f.member_rewardlist = rewadlist;
                                            f.ls_id = WanZhengLsInfo.Ls_id;
                                            f.ShowDialog();
                                        }
                                        break;//跳出只用一次就行 
                                    }
                                }

                            }
                        }

                    }
                    #endregion

                    #region 爱书卡消费
                    if (WanZhengLsInfo.Ls_flag == "3")
                    {
                        QueryPaymethods kk = payedList.Find(pay => pay.Pay_id == "####");

                        if (kk != null)
                        {
                            cardruninfo = new Ls_card_runInfo();
                            cardruninfo.Card_id = cdmember.Card_id;
                            cardruninfo.Source_id = lsinfo.Ls_id;
                            cardruninfo.Money = kk.Pay_money;
                            cardruninfo.O_id_operator = Portal.gc.loginUserInfo.O_id;
                            cardruninfo.Inout_flag = "1";
                            cardruninfo.Input_date = DateTime.Now;
                            cardruninfo.Mem = "零售消费";
                            cardruninfo.Discount = kk.Exchange_rate;
                            //List<MemberInfo> kkk= BLLFactory<Member>.Instance.Find(cdmember.M_id);
                            //if(string.IsNullOrEmpty(kkk[0].M_password))
                            // {
                            if (BLLFactory<Ls_card_run>.Instance.Insert(cardruninfo))
                            {
                                MessagboxUit.ShowTips("消费成功！");
                            }
                            else
                            {
                                MessagboxUit.ShowTips("消费 【失败】！");
                            }
                            //}
                            //else
                            //{
                            //    MessagboxUit.ShowTips("请输入密码！");
                            //}



                        }
                    }
                    #endregion
                }
                New();
            }
        }
        /// <summary>
        /// 出库
        /// </summary>
        private void StockArrear()
        {
            SetStatus("正在出库...");
            if (BLLFactory<Pos_muli_pay>.Instance.Is_stockLs(WanZhengLsInfo) == false)
            {

                SetStatus(BLLFactory<Pos_muli_pay>.Instance.SqlErrorText());
                SetStatus("出库失败！...");

            }
            else
            {
                SetStatus("出库成功...");

            }

        }



        /// <summary>
        /// 起新单清空
        /// </summary>
        private void New()
        {
            Productlist.Clear();
            memberlist.Clear();
            cdmember = null;
            payedList.Clear();
            //paymoney = 0;//收款金额
            //changemoney = 0;//找零金额
            SubMoney = 0;//去领头金额
            Ls_Sum = 0;//总码洋
            WanZhengLsInfo = null;
            ItemList.Clear();
            lsinfo = null;
            tb_count.Text = "";
            tb_isbn.Text = "";
            tb_member.Text = "";
            tb_Member_SurplusMoney.Text = "";
            tb_menber_Integral.Text = "";
            tb_remal_money.Text = "";
            tb_sm.Text = "";
            tb_submoney.Text = "";
            tb_total_num.Text = "";
            tb_xy.Text = "";
            l_member.Text = " <RETAIL>";
            l_type.Text = "";
            t_total_money.Text = "";
            this.winGridView1.GridView1.RefreshData();
            Portal.iniHelper.ClearSection("ZhiFuFangShi");
            this.real_money_avoid = 0;
            kklist.Clear();
            this.tb_tyzk.Text = "";
            this.la_remol.Text = "";
            this.tb_isbn.Focus();
        }

        /// <summary>
        /// 付款合并
        /// </summary>
        public List<QueryPaymethods> PaylistMerge()
        {
            List<QueryPaymethods> paylist = new List<QueryPaymethods>();

            //付款合并 避免有收款金额为0的
            var pay_query = from p in payedList
                            where p.Pay_money != 0
                            select p;
            paymoney = pay_query.Sum(p => p.Pay_money);//实收金额
            changemoney = pay_query.Sum(p => p.Change_money);//找零金额

            QueryPaymethods info = null;
            foreach (QueryPaymethods item in pay_query)
            {
                info = new QueryPaymethods();
                info.Change_money = item.Change_money;
                info.Exchange_rate = item.Exchange_rate;
                info.Pay_id = item.Pay_id;
                info.Is_charge = item.Is_charge;
                if (info.Is_charge == "1")
                {
                    info.Pay_money = item.Surplus_money;//以后可以扩展加入 汇率
                }
                else
                {
                    info.Pay_money = item.Pay_money / (item.Exchange_rate == 0 ? 1 : item.Exchange_rate);
                }
                //info.Pay_money = item.Pay_money / (item.Exchange_rate == 0 ? 1 : item.Exchange_rate);
                info.Pay_name = item.Pay_name;
                info.Source_id = !string.IsNullOrEmpty(item.Source_id) ? item.Pay_id : cdmember.Card_id;
                info.Surplus_money = item.Surplus_money;

                paylist.Add(info);
                pay_name = string.Empty;
                pay_name = payedList.Count > 1 ? "组合收款" : item.Pay_name;
            }
            return paylist;
        }

        #endregion

        #region 主细表 传值前转换
        /// <summary>
        /// 设置主表需要字段
        /// </summary>
        private LsInfo SetLsInfo()
        {
            LsInfo zbinfo = null;

            zbinfo = new LsInfo();
            zbinfo.Charge = SubMoney + (-youfeimoney);//去零头金额 如果有积分消零头的 也做成费用里
            zbinfo.Already_money = paymoney;
            zbinfo.Change = changemoney;
            zbinfo.Desk_id = null;
            zbinfo.Is_stock = "0";
            zbinfo.Is_sum = "0";
            zbinfo.Last_mod_date = DateTime.Now;
            zbinfo.Last_trans_date = DateTime.Now;
            zbinfo.Ls_back_id = null;
            zbinfo.Ls_datetime = DateTime.Now;
            zbinfo.Ls_flag = "0";//如果有爱书卡  这里的值是3
            zbinfo.Ls_id = null;
            zbinfo.Memo = string.IsNullOrEmpty(youfeibeizhu) ? "" : youfeibeizhu;
            zbinfo.M_id = l_member.Text;
            zbinfo.Notrigger = null;
            zbinfo.O_id = Portal.gc.loginUserInfo.O_id;
            zbinfo.Ph_id = tb_ph.Text;
            zbinfo.Real_money = SetRemal_money();//this.Ls_Sum;

            if (Portal.gc.QPossConfig.Is_xitongshu == "1")//:还要加入~系统书不积分
            {
                zbinfo.Real_money_avoid = real_money_avoid;//this.Ls_Sum;

            }
            else
            {
                zbinfo.Real_money_avoid = SetRemal_money();
            }
            zbinfo.Salesother_id = null;
            zbinfo.Stand_id = Portal.gc.loginUserInfo.Yh_stand_id;
            zbinfo.Station_id = Portal.gc.loginUserInfo.Station_ID;
            zbinfo.Sum_flag = Portal.gc.QPossConfig.Is_jifen == "1" ? "1" : "0";//判断是否积分
            zbinfo.Sum_id = null;
            zbinfo.Tax_id = null;
            zbinfo.Total_amount = tb_total_num.Text.ToInt32();
            zbinfo.Total_count = tb_count.Text.ToInt32();
            zbinfo.Total_money = total_money;
            zbinfo.Total_money_avoid = total_money;
            zbinfo.Waiter_id = null;
            return zbinfo;
        }

        /// <summary>
        /// 商品简单实体转换为 零售细表list
        /// </summary>
        private List<Ls_itemInfo> SetLsItemInfo(List<SimpleProductInfo> productList)
        {
            //TODO:这里去掉了 数量为0的明细
            //var list = from k in productList
            //           where k.H_amount != 0
            //           select k;//去掉数量为0的数据


            var list = productList;


            List<Ls_itemInfo> itemlist = new List<Ls_itemInfo>();
            Ls_itemInfo iteminfo = null;
            int Sort_number = 1;
            kklist = new List<SimpleProductInfo>();
            foreach (SimpleProductInfo item in list)
            {
                iteminfo = new Ls_itemInfo();
                iteminfo.H_amount = item.H_amount;
                iteminfo.H_discount = item.H_output_discount_ls;
                iteminfo.H_id = item.H_id;
                iteminfo.H_price = item.H_output_price;
                iteminfo.S_id = item.S_id;
                //iteminfo.Crush_money = 0.00M;
                iteminfo.Sort_number = Sort_number;
                iteminfo.Tax_crush_money = 0.00M;
                Sort_number++;
                itemlist.Add(iteminfo);
                kklist.Add(item);//用于打印时使用的明细表
            }

            return itemlist;



        }


        #endregion

        /// <summary>
        /// 窗体重晖时加在（代好像没效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromPos_Paint(object sender, PaintEventArgs e)
        {
            this.tb_isbn.Focus();
        }

        #region 会员相关

        /// <summary>
        /// 会员折扣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinTxt_KeyDown3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (this.tb_member.BackColor == Color.LightGreen)
                {
                    this.tb_isbn.Focus();
                    return;
                }
                if (tb_member.Text.Trim().Length != 0)
                {
                    memberlist.Clear();
                    memberlist = BLLFactory<Member>.Instance.GetMemberInfo(tb_member.Text.Trim());
                    if (memberlist.Count == 1)
                    {
                        cdmember = null;
                        cdmember = GetMemberInfo(memberlist);
                        SetmemberText(cdmember);
                        //this.tb_member.BackColor = Color.LightGreen;
                        //刷新商品折扣
                        RefreshMemberDiscount(Productlist);
                        ComputeTotal();
                        winGridView1.DataSource = null;
                        winGridView1.DataSource = Productlist;
                        SetGeShi();
                        winGridView1.gridView1.RefreshData();
                    }
                    else if (memberlist.Count > 1)
                    {
                        //会员多选框
                        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(POSS.WaitFormSeach));//开启等待控件
                        FromSelectedMember sm = new FromSelectedMember();
                        sm.MM_id = tb_member.Text.Trim();
                        sm.ShowDialog();
                        sm.Dispose();
                        cdmember = null;
                        this.cdmember = sm.selected;
                        if (cdmember != null)
                        {
                            SetmemberText(cdmember);

                            //刷新商品折扣
                            RefreshMemberDiscount(Productlist);
                            ComputeTotal();
                            winGridView1.DataSource = null;
                            winGridView1.DataSource = Productlist;
                            SetGeShi();
                            winGridView1.gridView1.RefreshData();
                        }
                        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();//关闭等待控件

                    }
                    else if (memberlist.Count == 0)
                    {

                        if (MessagboxUit.ShowYesNoAndTips("没有找到信息信息！【新增会员】？") == System.Windows.Forms.DialogResult.Yes)
                        {
                            FromEditMember edmember = new FromEditMember();

                            edmember.rowIndex = -1;
                            edmember.ShowDialog();
                            //解决:注册了会员在代回前台
                            if (tb_member.Text != null)
                            {
                                tb_member.Text = edmember.memberCord;
                                SkinTxt_KeyDown3(null, e);//sender 相当于动作
                            }

                        }
                    }
                }

            }


        }
        /// <summary>
        /// 刷新会员折扣
        /// </summary>
        /// <param name="prlist"></param>
        /// <returns></returns>
        private List<SimpleProductInfo> RefreshMemberDiscount(List<SimpleProductInfo> prlist)
        {
            if (prlist.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (var item in prlist)
                {
                    //item.H_output_discount_ls = BLLFactory<Product>.Instance.GetMemberDiscountByProduct(item.H_id, Portal.gc.loginUserInfo.Station_ID, l_member.Text.Trim(), item.H_amount, item.H_output_price);
                    if (Portal.gc.QPossConfig.Is_MoveMember == "1")//当H_id在db_product_discount_clientjb 会员商品折扣表里时按会员类别读取折扣
                    {
                        //解决:这里可以启用A与F系列 不同折扣方式 一书多会员折扣
                        string kk = BLLFactory<Product_discount_clientjb>.Instance.GetProduct_h_risediscount(item.H_id, l_member.Text.Trim());
                        if (!string.IsNullOrEmpty(kk))
                        {
                            item.H_output_discount_ls = kk.ToDecimal();
                        }
                        else
                        {
                            item.H_output_discount_ls = BLLFactory<Product>.Instance.GetMemberDiscountByProduct(item.H_id, Portal.gc.loginUserInfo.Station_ID, l_member.Text.Trim(), item.H_amount, item.H_output_price);
                        }
                    }
                    else//不用一书多会员折扣 就用A系列自代折扣体制
                    {
                        item.H_output_discount_ls = BLLFactory<Product>.Instance.GetMemberDiscountByProduct(item.H_id, Portal.gc.loginUserInfo.Station_ID, l_member.Text.Trim(), item.H_amount, item.H_output_price);
                    }

                    item.Ls_Sum = item.H_output_price * item.H_amount * item.H_output_discount_ls;

                }
            }
            return prlist;
        }

        /// <summary>
        /// 会员信息显示
        /// </summary>
        /// <param name="mlist"></param>
        private void SetmemberText(SimpleMemberInfo minfo)
        {
            this.tb_member.Text = "";
            this.l_member.Text = "<RETAIL>";
            this.tb_menber_Integral.Text = "";
            this.tb_Member_SurplusMoney.Text = "";
            this.l_type.Text = "";
            this.tb_member.BackColor = Color.White;
            if (minfo.End_date >= DateTime.Now)
            {
                this.tb_member.Text = minfo.M_name;
                this.l_member.Text = minfo.M_id;
                this.tb_menber_Integral.Text = minfo.Integral.ToString();
                this.tb_Member_SurplusMoney.Text = minfo.SurplusMoney;
                this.l_type.Text = minfo.M_type;
                this.tb_member.BackColor = Color.LightGreen;
            }
            else
            {
                MessagboxUit.ShowTips("会员以过期！");
                this.tb_member.BackColor = Color.White;
            }
        }
        /// <summary>
        /// 得到会员Info
        /// </summary>
        /// <param name="mlist"></param>
        /// <returns></returns>
        private SimpleMemberInfo GetMemberInfo(List<SimpleMemberInfo> mlist)
        {
            SimpleMemberInfo minfo = null;
            foreach (var item in mlist)
            {
                minfo = new SimpleMemberInfo();
                minfo.Card_id = item.Card_id;
                minfo.End_date = item.End_date;
                minfo.Integral = item.Integral;
                minfo.M_adress = item.M_adress;
                minfo.M_department_song = item.M_department_song;
                minfo.M_id = item.M_id;
                minfo.M_name = item.M_name;
                minfo.M_tel = item.M_tel;
                minfo.M_type = item.M_type;
                minfo.Station_id = item.Station_id;
                minfo.SurplusMoney = item.SurplusMoney;
            }

            return minfo;
        }
        /// <summary>
        /// 会员框输入判断为空的情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_member_TextChanged_1(object sender, EventArgs e)
        {
            if (this.tb_member.Text.Trim().Length == 0)
            {
                this.tb_member.BackColor = Color.White;
                this.l_member.Text = "<RETAIL>";

                this.tb_menber_Integral.Text = "";
                this.tb_Member_SurplusMoney.Text = "";
                this.l_type.Text = "";
                RefreshMemberDiscount(Productlist);
                ComputeTotal();
                winGridView1.DataSource = null;
                winGridView1.DataSource = Productlist;
                SetGeShi();
                winGridView1.gridView1.RefreshData();
            }
        }
        #endregion


        public void SetStatus(string txt)
        {

            if (lblStatus.TextLength + txt.Length > 32767)
            {
                lblStatus.ResetText();
            }
            lblStatus.AppendText(string.Format("[{0}] {1}\r\n", DateTime.Now.ToString("HH:mm:ss"), txt));
            lblStatus.ScrollToCaret();
        }

        /// <summary>
        /// 去零头框事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_submoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyChar==13
            if (e.KeyChar == 13)
            {
                decimal k = Ls_Sum;
                decimal m = k;
                decimal kd;
                decimal.TryParse(this.tb_submoney.Text, out kd);
                // decimal m = decimal.Parse(this.tb_remal_money.Text);
                decimal nn = m + kd;
                this.tb_remal_money.Text = nn.ToString("#0.00");
                //this.Ls_Sum = nn;
                this.SubMoney = kd;
                this.la_remol.Text = nn.ToString("#0.00");//增加了一个lab来显示应收

            }
        }

        /// <summary>
        /// 检测是否去零头
        /// </summary>
        private void Detection_tb_submoney()
        {
            if (Portal.gc.QPossConfig.Ls_qltfs == "None")
            {
                this.tb_submoney.ReadOnly = false;
            }
            else
            {
                this.tb_submoney.ReadOnly = true;
            }
        }
        /// <summary>
        /// 设置应收
        /// </summary>
        /// <returns></returns>
        private decimal SetRemal_money()
        {
            decimal reaml;
            decimal.TryParse(this.tb_remal_money.Text, out reaml);
            la_remol.Text = this.tb_remal_money.Text;
            return reaml;
        }


        /// <summary>
        /// 打印小票
        /// </summary>
        private void Priont()
        {
            if (!possetup.IsPrint)
            {
                return;
            }
            pintxiaopiao = new PrintDocument();
            MultipadPrintDocument print = new MultipadPrintDocument();//小票打印.分页
            PrintDialog pd = new PrintDialog();
            
            print.Text = PrintText();
            print.Font = new Font("宋体", 9f);

            print.DefaultPageSettings.Landscape =false; 
            int posMargin = 2;
            print.DefaultPageSettings.Margins = new Margins(posMargin, posMargin, posMargin, posMargin);
            print.PrinterSettings.PrinterName = this.possetup.PrintName;
            print.PrintController = new StandardPrintController();
            pd.Document = print;
            print.Print();
            /// <summary>
            /// 设置待打印的内容
            /// </summary>


        }
        private string PrintText()
        {
            string printtext = string.Empty;

            try
            {

                StringBuilder sb = new StringBuilder();
                Font f = SystemFonts.DefaultFont;
                Brush fbrush = SystemBrushes.ControlText;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Near;
                if (!string.IsNullOrEmpty(possetup.Tou1))
                {
                    sb.AppendLine(string.Format("{0}", possetup.Tou1).PadLeft(15, ' '));
                }
                if (!string.IsNullOrEmpty(possetup.Tou2))
                {
                    sb.AppendLine(string.Format("{0}", possetup.Tou2).PadLeft(15, ' '));
                }
                sb.AppendLine(string.Format("单号：{0}", WanZhengLsInfo.Ls_id));
                sb.AppendLine(string.Format("品名 "));
                sb.AppendLine(string.Format("折扣   数量   售价   合计"));
                sb.AppendLine(string.Format("------------------------------"));
                foreach (var item in kklist)
                {
                    sb.AppendLine(string.Format("{0}", AutomaticLine(item.H_name,22,28)));
                    sb.AppendLine(string.Format("{0}{1}{2}{3:c2}", string.Format("{0:0.00%}", item.H_output_discount_ls).PadRight(6, ' '), string.Format("  {0:n0}", item.H_amount).PadRight(6, ' '), string.Format("{0:c2}", item.H_output_price).PadRight(8, ' '), item.H_output_price * item.H_output_discount_ls * item.H_amount));
                }
                sb.AppendLine(string.Format("------------------------------"));
                sb.AppendLine(string.Format("总数量   总码洋   总实洋"));
                sb.AppendLine(string.Format("{0}  {1}  {2}", string.Format("{0:n0}", WanZhengLsInfo.Total_amount).PadRight(8, ' '), string.Format("{0:c2}", WanZhengLsInfo.Total_money).PadRight(8, ' '), string.Format("{0:c2}", WanZhengLsInfo.Real_money).PadRight(8, ' ')));
                sb.AppendLine(string.Format("------------------------------"));
                sb.AppendLine(string.Format("支付方式:{0}", string.IsNullOrEmpty(pay_name) ? pay_name : pay_name));
                if (cdmember != null && !string.IsNullOrEmpty(cdmember.M_id))
                {
                    sb.AppendLine(string.Format("会员名称:{0}", string.IsNullOrEmpty(cdmember.M_name) ? "" : cdmember.M_name));
                    sb.AppendLine(string.Format("会员积分:{0}", string.IsNullOrEmpty(cdmember.Integral.ToString("n2")) ? "" : cdmember.Integral.ToString("n2")));
                    sb.AppendLine(string.Format("会员卡内余额:{0}", string.IsNullOrEmpty(cdmember.SurplusMoney) ? "" : string.Format("{0:c2}", cdmember.SurplusMoney)));
                }
                sb.AppendLine(string.Format("品种:{0}应收:{1}", string.Format("{0:n0}", WanZhengLsInfo.Total_amount).PadRight(13, ' '), string.Format("{0:c2}", Ls_Sum).PadRight(13,' ')));
                sb.AppendLine(string.Format("收银:{0}实收:{1}", string.Format("{0}", Portal.gc.loginUserInfo.O_Name).PadRight(13, ' '), string.Format("{0:c2}", paymoney)));
                sb.AppendLine(string.Format("费用:{0}找零:{1}", string.Format("{0:c2}", SubMoney).PadRight(13, ' '), string.Format("{0:c2}", changemoney)));
                sb.AppendLine(string.Format("台号:{0}站点:{1}", string.Format("{0}", Portal.gc.loginUserInfo.Yh_stand_id).PadRight(13, ' '), Portal.gc.loginUserInfo.Station_ID));
                sb.AppendLine(string.Format("日期:{0:yyyy-MM-dd HH:mm:ss}", WanZhengLsInfo.Ls_datetime));
                if (!string.IsNullOrEmpty(possetup.Wei1))
                {
                    sb.AppendLine(string.Format("{0}", possetup.Wei1));
                }
                if (!string.IsNullOrEmpty(possetup.Wei2))
                {
                    sb.AppendLine(string.Format("{0}", possetup.Wei2));
                }
                if (!string.IsNullOrEmpty(possetup.Wei3))
                {
                    sb.AppendLine(string.Format("{0}", possetup.Wei3));
                }
                if (!string.IsNullOrEmpty(possetup.Wei4))
                {
                    sb.AppendLine(string.Format("{0}", possetup.Wei4));
                }

                //e.Graphics.DrawString(sb.ToString(), f, fbrush, new Rectangle(3, 3, (int)(58 / 25.4) * 100, Height), sf);//this.ClientRectangle
                printtext = sb.ToString();

            }
            catch (Exception ex)
            {
                MessagboxUit.ShowTips(ex.Message);
            }
            return printtext;

        }
       

       
        


        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 系统设置ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (systemform == null || systemform.IsDisposed)
            {
                if (Portal.gc.loginUserInfo.O_Name == "administrator")
                {
                    systemform = new SystemFrom();
                    systemform.Show(this);
                }
                else
                {
                    //SystemFrom sf = new SystemFrom();
                    //sf.Close();
                    MessagboxUit.ShowError("请用超级管理员登录！");

                }
            }
        }

        private void 员工设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Portal.gc.loginUserInfo.O_Name == "administrator")
            {
                if (temform == null || temform.IsDisposed)//判断窗体是否打开了
                {
                    temform = new OperatorsFrom();
                    temform.Show();
                }
                else
                {
                    temform.Activate();
                }
            }
            else
            {
                MessagboxUit.ShowError("请用超级管理员登录！");
            }

        }

        private void 修改密码ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (formm_poss == null || formm_poss.IsDisposed)
            {
                formm_poss = new FormM_pass();
                formm_poss.Show();
            }
            else
            {
                formm_poss.Activate();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PossUits_FormClosing(null, null);
        }

        /// <summary>
        /// 统一折扣事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_tyzk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal tyzk = this.tb_tyzk.Text.Trim().ToString().ToDecimal();
                if (tyzk >= 0.0000m && tyzk <= 1.0000m)
                {
                    foreach (var item in Productlist)
                    {
                        item.H_output_discount_ls = tyzk;
                    }
                    ComputeTotal();//计算汇总
                    for (int i = 0; i < Productlist.Count; i++)
                    {
                        ComputeRow(i);//这个方法是计算汇总的
                    }

                    winGridView1.GridView1.RefreshData();
                }
                else
                {
                    MessagboxUit.ShowError("折扣非法！");
                    this.tb_tyzk.Focus();
                    this.tb_tyzk.SelectAll();
                }


            }

        }


        /// <summary>
        /// 会员编辑，冲值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_member_DoubleClick(object sender, EventArgs e)
        {
            if (this.cdmember.Card_id == null) return;
            if (cordfrom == null || cordfrom.IsDisposed)
            {
                cordfrom = new FromEditMember();
                cordfrom.MMCord_id = cdmember.Card_id;
                cordfrom.MMM_id = cdmember.M_id;
                cordfrom.ShowDialog();
                cordfrom.Close();

            }
            else
            {
                cordfrom.Activate();
            }
        }


        /// <summary>
        /// 判断是否当班
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        private bool PanDuanIs_DanBan()
        {
            bool result = false;

            danbaninfo = new DangBanInfo();
            danbaninfo.DanBan_Date = DateTime.Now.ToString("yyyy-MM-dd");
            danbaninfo.DangBan_DateTime = DateTime.Now;
            danbaninfo.Is_Jk = "0";
            danbaninfo.O_id = Portal.gc.loginUserInfo.O_id;
            if (danbaninfo.O_id.Trim() == "1") return result = true;
            danbaninfo.Station_id = Portal.gc.loginUserInfo.Station_ID;
            //info.YuBeiLingQian = this.t_total_money.Text.ToDecimal();
            if (BLLFactory<DangBan>.Instance.SelectDangBan(danbaninfo))
            {
                this.tb_isbn.Enabled = true;
                this.tb_xy.Enabled = true;
                this.tb_sm.Enabled = true;
                this.tb_member.Enabled = true;
                result = true;
            }
            else
            {
                result = false;//BLLFactory<DangBan>.Instance.Insert(info);
            }
            return result;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (MessagboxUit.ShowYesNoAndTips("请问你现在是要交班了吗？") == System.Windows.Forms.DialogResult.Yes)
            {
                JiaoBanForm jb = null;
                if (jb == null || jb.IsDisposed)
                {
                    jb = new JiaoBanForm();
                    jb.ShowDialog();
                    jb.Close();
                    this.PossUits_FormClosing(null, null);

                }
                else
                {
                    jb.Activate();
                }
            }
        }



        #region "把字符串按指定最大长度分行，使得最后一行长度为指定的最低长度"  

        /// <summary>    
        /// 处理字符串自动换行问题。最短为intLenMin，最长为intLenMax，最后一行用空格补齐到intLenMin长度。http://blog.csdn.net/xiaoxian8023/article/details/7276220    
        /// </summary>    
        /// <param name="strOldText">原字符串</param>    
        /// <param name="intLenMin">最短字节长度</param>    
        /// <param name="intLenMax">最长字节长度</param>    
        /// <returns>string</returns>    
        /// <remarks></remarks>    
        public string AutomaticLine(string strOldText, int intLenMin, int intLenMax)
        {

            int intLength = 0;
            string strResult = "";

            //获取原字符串的字节长度    
            intLength = System.Text.Encoding.GetEncoding("gb2312").GetByteCount(strOldText);

            if (intLength > intLenMax)
            {
                //总字节数> 最长截取的最长字节数，    
                //则截取最长字节数, 然后对剩余字符串再处理    

                //获取字符串的UCS2码    
                byte[] bytes = System.Text.Encoding.Unicode.GetBytes(strOldText);
                //获取字符的实际截取位置    
                int intCutPos = RealCutPos(bytes, intLenMax);
                //采用递归调用    
                strResult = System.Text.Encoding.Unicode.GetString(bytes, 0, intCutPos * 2) + "\r\n" + AutomaticLine(Strings.Mid(strOldText, intCutPos + 1), intLenMin, intLenMax);

            }
            else if (intLength > intLenMin)
            {
                //如果 最长字节数 >总字节数 > 最短字节数，则 换行，并补齐空格到最短字节数位置    
                strResult = strOldText + "\r\n" + Strings.Space(intLenMin);

            }
            else
            {
                //如果 总字节数 < 最短字节数，则直接补齐空格到最短字节数的位置    
                strResult = strOldText + Strings.Space(intLenMin - intLength);
            }
            return strResult;
        }

        /// <summary>    
        /// 返回字符的实际截取位置    
        /// </summary>    
        /// <param name="bytes">UCS2码</param>    
        /// <param name="intLength">要截取的字节长度</param>    
        /// <returns></returns>    
        /// <remarks></remarks>    
        public int RealCutPos(byte[] bytes, int intLength)
        {
            //获取UCS2编码    
            int intCountB = 0;
            // 统计当前的字节数     
            int intCutPos = 0;
            //记录要截取字节的位置      

            while ((intCutPos < bytes.GetLength(0) && intCountB < intLength))
            {
                // 偶数位置，如0、2、4等，为UCS2编码中两个字节的第一个字节    
                if (intCutPos % 2 == 0)
                {
                    // 在UCS2第一个字节时，字节数加1    
                    intCountB += 1;
                }
                else
                {
                    // 当UCS2编码的第二个字节大于0时，该UCS2字符为汉字，一个汉字算两个字节    
                    if (bytes[intCutPos] > 0)
                    {
                        intCountB += 1;
                    }
                }
                intCutPos += 1;
            }

            // 如果intCutPos为奇数时，处理成偶数      
            if (intCutPos % 2 == 1)
            {
                // 该UCS2字符是汉字时，去掉这个截一半的汉字    
                if (bytes[intCutPos] > 0)
                {
                    intCutPos = intCutPos - 1;
                }
                else
                {
                    // 该UCS2字符是字母或数字，则保留该字符    
                    intCutPos = intCutPos + 1;
                }
            }

            return intCutPos / 2;
        }
        /// <summary>  
        /// 设置小票各部分的分隔线  
        /// </summary>  
        /// <param name="ticketwidth">小票的宽度，按照字符个数计算</param>  
        /// <param name="signChar">分隔线的样式</param>  
        /// <returns>小票的分隔线</returns>  
        private String CreateLine(int ticketwidth, Char signChar)
        {
            String result = String.Empty;
            try
            {
                for (int i = 0; i < ticketwidth; i++)
                {
                    result += signChar;
                }
                result += "\r\n";
            }
            catch (Exception ex)
            {
                LogTextHelper.Info(ex.Message);

            }


            return result;
        }



        #endregion
    }
}
