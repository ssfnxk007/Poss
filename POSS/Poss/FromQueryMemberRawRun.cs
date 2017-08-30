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
  public  class FromQueryMemberRawRun :BaseDock
    {
        #region 变量
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_cel;
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        #endregion

       public SimpleMemberInfo csmemberinfo ;
        public string ls_id;

        public List<QueryMemberRewardInfo> member_rewardlist = new List<QueryMemberRewardInfo>();
        private List<QueryMemberRewardInfo> rewardlist = new List<QueryMemberRewardInfo>();
        QueryMemberRewardInfo into=null;//会员奖励

        Member_reward_runInfo runinfo = null;//兑换奖励
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_cel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(662, 322);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.winGridView1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(658, 266);
            this.panelControl3.TabIndex = 1;
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
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = false;
            this.winGridView1.ShowEditMenu = false;
            this.winGridView1.ShowExportButton = false;
            this.winGridView1.Size = new System.Drawing.Size(654, 262);
            this.winGridView1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_cel);
            this.panelControl2.Controls.Add(this.btn_ok);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 268);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(658, 52);
            this.panelControl2.TabIndex = 0;
            // 
            // btn_cel
            // 
            this.btn_cel.Location = new System.Drawing.Point(527, 19);
            this.btn_cel.Name = "btn_cel";
            this.btn_cel.Size = new System.Drawing.Size(75, 23);
            this.btn_cel.TabIndex = 0;
            this.btn_cel.Text = "取 消";
            this.btn_cel.Click += new System.EventHandler(this.btn_cel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(424, 19);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "确 定";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FromQueryMemberRawRun
            // 
            this.ClientSize = new System.Drawing.Size(662, 322);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromQueryMemberRawRun";
            this.Text = "积分对换";
            this.Load += new System.EventHandler(this.FromQueryMemberRawRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FromQueryMemberRawRun_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public FromQueryMemberRawRun()
        {
            InitializeComponent();
            this.winGridView1.GridView1.RowClick += GridView1_RowClick;
            winGridView1.GridView1.CellValueChanged += GridView1_CellValueChanged;
        }

        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            into = new QueryMemberRewardInfo();
            into = (QueryMemberRewardInfo)winGridView1.GridView1.GetRow(e.RowHandle);
            
            if (e.Column.FieldName == "HH_amount")
            {
                if((int )e.Value>into.H_amount)
                {
                    ColumnView view =(ColumnView) winGridView1.gridControl1.FocusedView;
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
                    runinfo.M_id = csmemberinfo.M_id;
                    runinfo.M_reward_money = into.Mr_reward_money;
                    runinfo.M_reward_verify = "0";
                    runinfo.Occur_date = DateTime.Now;
                    runinfo.Occur_money = into.Mr_condition * runinfo.Amount;
                    runinfo.O_id = Portal.gc.loginUserInfo.O_id;
                    runinfo.Source_id = ls_id;
                    runinfo.Station_id = Portal.gc.loginUserInfo.Station_ID;
                }
            }
        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ColumnView view = (ColumnView)winGridView1.gridControl1.FocusedView;
            view.FocusedColumn = view.Columns["HH_amount"];
            view.ShowEditor();
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
            this.winGridView1.AddColumnAlias("HH_amount", "本次兑换数量");
            this.winGridView1.ReadOnlyList.Add("Mr_type");
            this.winGridView1.ReadOnlyList.Add("Mr_type_name");
            this.winGridView1.ReadOnlyList.Add("Mr_condition");
            this.winGridView1.ReadOnlyList.Add("H_amount");
            this.winGridView1.ReadOnlyList.Add("Mr_reward_money");
            this.winGridView1.ReadOnlyList.Add("Exchange_rate");
            this.winGridView1.ReadOnlyList.Add("Memo");
            this.winGridView1.DataSource = rewardlist;

        }

        private void DataScruse()
        {
            BLLFactory<Member_reward_run>.Instance.memberjiancha(ls_id, Portal.gc.loginUserInfo.O_id);
            if (csmemberinfo != null)
            {
            this.rewardlist.Clear();
                 rewardlist= member_rewardlist;
            winGridView1.gridView1.RefreshData();
            }
        }

        private void FromQueryMemberRawRun_Load(object sender, EventArgs e)
        {
            DataScruse();
            SetWinGridView();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (runinfo!=null)
            {
               bool k= BLLFactory<Member_reward_run>.Instance.save(runinfo);
                if (k)
                {
                    MessagboxUit.ShowTips("兑换成功！");
                    this.Close();
                    this.Dispose();
                }
                else
                {
                  MessagboxUit.ShowError(  BLLFactory<Member_reward_run>.Instance.SqlErrorText());
                }
            }
            else
            {
                MessagboxUit.ShowError("请填写【本次兑换数量】");
            }
        }

        private void btn_cel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FromQueryMemberRawRun_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                btn_cel_Click(null,null);

            }
        }
    }
}
