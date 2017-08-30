using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;
using POSS.Entity;
using DevExpress.XtraGrid.Views.Base;

namespace POSS
{
  public  class FromJiFenDangQianHua:BaseDock
    {
        #region 变量
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        #endregion

        private System.Windows.Forms.Label Lab_mid;
        private System.Windows.Forms.Label Lab_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab_type;
        private System.Windows.Forms.Label Lab_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;

        public SimpleMemberInfo memberinfo = new SimpleMemberInfo();

        private List<QueryMemberRewardInfo> rewardlist = new List<QueryMemberRewardInfo>();
        private System.Windows.Forms.Label Lab_rember;
        private System.Windows.Forms.Label label2;
        public decimal remal_money;//收款实洋

        Member_reward_runInfo runinfo = null;//兑换奖励
        private System.Windows.Forms.Label Lab_ShiYong;
        private System.Windows.Forms.Label label4;
        QueryMemberRewardInfo into = null;//会员奖励

        public bool OkOrNo = false;//传回是否支付成功

        public decimal ShiYongJiFen = 0;//传回的使用积分（元）
        private System.Windows.Forms.Label label6;
        public string youfeijinger;


        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.Lab_type = new System.Windows.Forms.Label();
            this.Lab_ShiYong = new System.Windows.Forms.Label();
            this.Lab_mid = new System.Windows.Forms.Label();
            this.Lab_rember = new System.Windows.Forms.Label();
            this.Lab_number = new System.Windows.Forms.Label();
            this.Lab_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 309);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(744, 85);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.simpleButton2);
            this.panelControl4.Controls.Add(this.simpleButton1);
            this.panelControl4.Controls.Add(this.label6);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(467, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(275, 81);
            this.panelControl4.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(177, 39);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "退 出";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(27, 39);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "兑 换";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "积分支付，支付后无找零，无法退回！";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.Lab_type);
            this.panelControl3.Controls.Add(this.Lab_ShiYong);
            this.panelControl3.Controls.Add(this.Lab_mid);
            this.panelControl3.Controls.Add(this.Lab_rember);
            this.panelControl3.Controls.Add(this.Lab_number);
            this.panelControl3.Controls.Add(this.Lab_name);
            this.panelControl3.Controls.Add(this.label7);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(465, 81);
            this.panelControl3.TabIndex = 0;
            // 
            // Lab_type
            // 
            this.Lab_type.AutoSize = true;
            this.Lab_type.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_type.ForeColor = System.Drawing.Color.Red;
            this.Lab_type.Location = new System.Drawing.Point(322, 23);
            this.Lab_type.Name = "Lab_type";
            this.Lab_type.Size = new System.Drawing.Size(31, 14);
            this.Lab_type.TabIndex = 0;
            this.Lab_type.Text = "lab";
            // 
            // Lab_ShiYong
            // 
            this.Lab_ShiYong.AutoSize = true;
            this.Lab_ShiYong.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_ShiYong.ForeColor = System.Drawing.Color.Red;
            this.Lab_ShiYong.Location = new System.Drawing.Point(353, 43);
            this.Lab_ShiYong.Name = "Lab_ShiYong";
            this.Lab_ShiYong.Size = new System.Drawing.Size(0, 14);
            this.Lab_ShiYong.TabIndex = 0;
            // 
            // Lab_mid
            // 
            this.Lab_mid.AutoSize = true;
            this.Lab_mid.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_mid.ForeColor = System.Drawing.Color.Red;
            this.Lab_mid.Location = new System.Drawing.Point(322, 6);
            this.Lab_mid.Name = "Lab_mid";
            this.Lab_mid.Size = new System.Drawing.Size(31, 14);
            this.Lab_mid.TabIndex = 0;
            this.Lab_mid.Text = "lab";
            // 
            // Lab_rember
            // 
            this.Lab_rember.AutoSize = true;
            this.Lab_rember.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_rember.ForeColor = System.Drawing.Color.Red;
            this.Lab_rember.Location = new System.Drawing.Point(130, 43);
            this.Lab_rember.Name = "Lab_rember";
            this.Lab_rember.Size = new System.Drawing.Size(0, 14);
            this.Lab_rember.TabIndex = 0;
            // 
            // Lab_number
            // 
            this.Lab_number.AutoSize = true;
            this.Lab_number.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_number.ForeColor = System.Drawing.Color.Red;
            this.Lab_number.Location = new System.Drawing.Point(129, 23);
            this.Lab_number.Name = "Lab_number";
            this.Lab_number.Size = new System.Drawing.Size(31, 14);
            this.Lab_number.TabIndex = 0;
            this.Lab_number.Text = "lab";
            // 
            // Lab_name
            // 
            this.Lab_name.AutoSize = true;
            this.Lab_name.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_name.ForeColor = System.Drawing.Color.Red;
            this.Lab_name.Location = new System.Drawing.Point(99, 6);
            this.Lab_name.Name = "Lab_name";
            this.Lab_name.Size = new System.Drawing.Size(31, 14);
            this.Lab_name.TabIndex = 0;
            this.Lab_name.Text = "lab";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(234, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "会员类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(234, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "本次使用积分：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "收款所需积分：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "会员可用积分：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(234, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "会员卡号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员名称：";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.winGridView1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(744, 309);
            this.panelControl2.TabIndex = 1;
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
            this.winGridView1.Size = new System.Drawing.Size(740, 305);
            this.winGridView1.TabIndex = 0;
            // 
            // FromJiFenDangQianHua
            // 
            this.ClientSize = new System.Drawing.Size(744, 394);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromJiFenDangQianHua";
            this.Text = "积分当钱花";
            this.Load += new System.EventHandler(this.FromJiFenDangQianHua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public FromJiFenDangQianHua()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
            this.winGridView1.GridView1.RowClick += GridView1_RowClick;
            winGridView1.GridView1.CellValueChanged += GridView1_CellValueChanged;
        }

        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            into = new QueryMemberRewardInfo();
            into = (QueryMemberRewardInfo)winGridView1.GridView1.GetRow(e.RowHandle);
            
            if (e.Column.FieldName == "HH_amount")
            {
                if ((int)e.Value > into.H_amount)
                {
                    ColumnView view = (ColumnView)winGridView1.gridControl1.FocusedView;
                    view.FocusedColumn = view.Columns["HH_amount"];
                    view.SetColumnError(e.Column, "可兑数量小于兑换数量！请更正！");//错误提示框
                }
                else
                {
                    runinfo = new Member_reward_runInfo();
                    runinfo.Amount = into.HH_amount;
                    runinfo.Mr_id = "";
                    runinfo.Mr_style = into.Mr_style;
                    runinfo.Mr_type = into.Mr_type;
                    runinfo.M_id = memberinfo.M_id;
                    runinfo.M_reward_money = into.Mr_reward_money;
                    runinfo.M_reward_verify = "0";
                    runinfo.Occur_date = DateTime.Now;
                    runinfo.Occur_money = into.Mr_condition * runinfo.Amount;
                    runinfo.O_id = Portal.gc.loginUserInfo.O_id;
                    runinfo.Source_id = "";
                    runinfo.Station_id = Portal.gc.loginUserInfo.Station_ID;
                    this.Lab_rember.Text = (this.remal_money * into.Mr_condition).ToString("#0.00");
                    this.Lab_ShiYong.Text = ((int)e.Value * into.Mr_condition).ToString("#0.00");
                    this.ShiYongJiFen = (int)e.Value;
                    
                }
            }
        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ColumnView view = (ColumnView)winGridView1.gridControl1.FocusedView;
            view.FocusedColumn = view.Columns["HH_amount"];
            view.ShowEditor();
        }

        private void FromJiFenDangQianHua_Load(object sender, EventArgs e)
        {
            SetMember();
            SetWinGridView();
            DataBing();
        }
        /// <summary>
        /// 设置会员Lab
        /// </summary>
        private void SetMember()
        {
            this.Lab_mid.Text = memberinfo.Card_id;
            this.Lab_name.Text = memberinfo.M_name;
            this.Lab_number.Text = memberinfo.Integral.ToString("#0.00");
            this.Lab_type.Text = memberinfo.M_type;
            decimal kk = Convert.ToDecimal( Portal.gc.QPossConfig.Ls_jfdhbl);
            decimal mm = (kk) * (this.remal_money);
            this.Lab_rember.Text = mm.ToString("#0.00");
         
        }
        /// <summary>
        /// 显示设置
        /// </summary>
        private void SetWinGridView()
        {
            this.winGridView1.GridView1.PaintStyleName = "UltraFlat";
            this.winGridView1.EnableMenu = false;
            this.winGridView1.BestFitColumnWith = false;
            this.winGridView1.GridView1.RowHeight = 30;//收变列高度
            this.winGridView1.GridView1.OptionsSelection.MultiSelect = false;//是否开起多选
            this.winGridView1.DisplayColumns = "Mr_type,Mr_type_name,Mr_condition,H_amount,Mr_reward_money,M_type,HH_amount,Memo";
            this.winGridView1.AddColumnAlias("Mr_type", "奖品编号");
            //this.winGridView1.AddColumnAlias("Checked", "选择");
            this.winGridView1.AddColumnAlias("Mr_type_name", "奖品名称");
            this.winGridView1.AddColumnAlias("Mr_condition", "奖品所需分数");
            this.winGridView1.AddColumnAlias("Mr_reward_money", "奖品价值");
            this.winGridView1.AddColumnAlias("M_type", "会员类别");
            this.winGridView1.AddColumnAlias("Memo", "备注");
            this.winGridView1.AddColumnAlias("H_amount", "可兑换数量");
            this.winGridView1.AddColumnAlias("HH_amount", "本次使用数量");
            this.winGridView1.ReadOnlyList.Add("Mr_type");
            this.winGridView1.ReadOnlyList.Add("Mr_type_name");
            this.winGridView1.ReadOnlyList.Add("Mr_condition");
            this.winGridView1.ReadOnlyList.Add("H_amount");
            this.winGridView1.ReadOnlyList.Add("Mr_reward_money");
            this.winGridView1.ReadOnlyList.Add("Exchange_rate");
            this.winGridView1.ReadOnlyList.Add("Memo");
            //this.winGridView1.DataSource = rewardlist;

        }

        private void DataBing()
        {
            rewardlist.Clear();
            rewardlist=(BLLFactory<Member_reward_run>.Instance.GetMemberRewardToJiFenDanQianHuo(memberinfo));
            this.winGridView1.DataSource = rewardlist;
            this.winGridView1.gridView1.RefreshData();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
             youfeijinger = string.Format("会员{0}积分抵扣现金{1}元|{1}", Lab_name.Text, this.ShiYongJiFen);
            //Portal.iniHelper.IniWriteValue("ZhiFuFangShi", "JiFenDangQianHuo",kk );
            if (runinfo != null)
            {
                bool k = BLLFactory<Member_reward_run>.Instance.save(runinfo);
                if (k)
                {
                   // MessagboxUit.ShowTips("兑换成功！");
                    this.OkOrNo = true;
                    this.Close();
                    this.Dispose();
                    
                }
                else
                {
                    // MessagboxUit.ShowError(BLLFactory<Member_reward_run>.Instance.SqlErrorText());
                    LogTextHelper.Error(BLLFactory<Member_reward_run>.Instance.SqlErrorText());
                }
            }
            else
            {
                MessagboxUit.ShowError("请填写【本次兑换数量】");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.OkOrNo = false;
            this.Close();
            this.Dispose();
        }
    }
}
