using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using POSS.BLL;
using POSS.Entity;
using WHC.Framework.ControlUtil;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using System.Drawing.Printing;

namespace POSS
{
    public partial class FromPos : CCSkinMain
    {
        private operators temform = null;//全局窗体变量(设置窗体)
        private SystemFrom systemform = null;
        private Bitmap bmp;

        #region 变量
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

        #endregion
        public FromPos()
        {

            this.IsMdiContainer = true;
            InitializeComponent();

            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
            this.tb_member.KeyDown += SkinTxt_KeyDown3;

            #region 加载设置

            this.tb_isbn.SkinTxt.KeyDown += SkinTxt_KeyDown2; //商品H_ISBN回车事件

            this.winGridView2.GridView1.CellValueChanged += GridView1_CellValueChanged;
            this.tb_xy.SkinTxt.KeyDown += SkinTxt_KeyDown;//商品H_ISBN回车事件
            this.tb_sm.SkinTxt.KeyDown += SkinTxt_KeyDown1;
            this.winGridView2.GridView1.RowClick += GridView1_RowClick;



            this.winGridView2.EnableMenu = false;
            this.winGridView2.GridView1.RowHeight = 50;//收变列高度
            this.winGridView2.GridView1.Appearance.Row.Font = new Font("Tahoma", 16);
            this.winGridView2.GridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 16);
            this.winGridView2.GridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 16);
            this.winGridView2.GridView1.Appearance.FooterPanel.BackColor = Color.Silver;
            this.winGridView2.GridView1.Appearance.FooterPanel.BorderColor = Color.Silver;
            this.winGridView2.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("Ls_Sum", "c2", "合计:"));
            this.winGridView2.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("H_amount", "n0"));
            //this.winGridView2.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("Ls_Sum", "c2"));
            this.winGridView2.BestFitColumnWith = false;
            this.winGridView2.DisplayColumns = "H_isbn|H_name|H_output_price|H_amount|H_output_discount_ls|Ls_Sum";
            this.winGridView2.AddColumnAlias("h_isbn", "条码");
            this.winGridView2.AddColumnAlias("h_name", "商品名称");
            this.winGridView2.AddColumnAlias("h_amount", "数量");
            this.winGridView2.AddColumnAlias("H_output_price", "定价");
            this.winGridView2.AddColumnAlias("H_output_discount_ls", "折扣");
            this.winGridView2.AddColumnAlias("Ls_Sum", "合计");

            this.winGridView2.DataSource = Productlist;
            //DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit h_name = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            //DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit h_isbn = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();

            //winGridView2.GridView1.Columns["H_name"].ColumnEdit = h_name;
            //winGridView2.GridView1.Columns["H_isbn"].ColumnEdit = h_isbn;

            this.winGridView2.GridView1.OptionsView.RowAutoHeight = true;
            this.winGridView2.GridView1.BestFitColumns(true);
            this.winGridView2.ReadOnlyList.Add("H_isbn");
            this.winGridView2.ReadOnlyList.Add("H_name");
            this.winGridView2.ReadOnlyList.Add("H_output_price");
            this.winGridView2.ReadOnlyList.Add("Ls_Sum");
            //是否可以修改数量或修改折扣
            #endregion

        }



        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ColumnView view = (ColumnView)winGridView2.gridControl1.FocusedView;
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
        private void FromPos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            GetPh_id(O_id);
            
            this.tb_isbn.Focus();
            tb_isbn.Select();
            Detection_tb_submoney();
            //小票打印初始化
            if (pintxiaopiao == null)
            {
                pintxiaopiao = new PrintDocument();
            }
            

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
                infolist.AddRange(list);//只有一条的直接加入到商品列表里
                Productlist = MergeListJoinMember(infolist);//代会员的合并
                winGridView2.DataSource = null;
                winGridView2.DataSource = Productlist;
                SetGeShi();
                winGridView2.GridView1.RefreshData();
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
                List<SimpleProductInfo> xxlist = new List<SimpleProductInfo>();//过读list
                xxlist = Productlist;
                xxlist.AddRange(SelectProductlist);
                Productlist = MergeListJoinMember(xxlist);
                //Productlist.AddRange(infolist);
                winGridView2.DataSource = null;
                //Productlist.AddRange(Productlist);
                winGridView2.DataSource = Productlist;
                SetGeShi();
                winGridView2.GridView1.RefreshData();
                result = true;
            }

            // DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();//关闭等待控件
            // // 设置鼠标默认状态
            this.Cursor = Cursors.Default;
            return result;

        }
        #region 书号，书名 谐音 查询书目信息

        private void SkinTxt_KeyDown1(object sender, KeyEventArgs e)
        {
            string text = this.tb_sm.Text.TrimEnd();
            text = text.Replace('　', ' ');
            text = text.Replace("'", "");

            string sqlwhere = string.Format(" and db_product.h_name like '%{0}%'",text);
            string m_id = this.l_member.Text.Trim();
            string station_id = Portal.gc.loginUserInfo.Station_ID.Trim();
            string whc_mun = Portal.gc.QPossConfig.Taosu.Trim();
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    SearchProduct(sqlwhere, m_id, station_id, whc_mun);
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
            string sqlwhere = string.Format(" and db_product.my_help_input like '%{0}%'", text);
            string m_id = this.l_member.Text.Trim();
            string station_id = Portal.gc.loginUserInfo.Station_ID.Trim();
            string whc_mun = Portal.gc.QPossConfig.Taosu.Trim();
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    SearchProduct(sqlwhere, m_id, station_id, whc_mun);
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
                    if (SearchProduct(sqlwhere, m_id, station_id, whc_mun) == false)
                    {
                        sqlwhere = string.Format(" and db_product.h_mytm='{0}'", text);
                       // string text = tb_isbn.Text.Trim();
                        this.tb_xy.Text = "";
                        this.tb_isbn.Text = "";
                        this.tb_sm.Text = "";
                        SearchProduct(sqlwhere, m_id, station_id, whc_mun);

                    }
                    else
                    {
                        this.tb_xy.Text = "";
                        this.tb_isbn.Text = "";
                        this.tb_sm.Text = "";
                    }

                    ComputeTotal();
                }
            }


        }
        /// <summary>
        /// 条码搜索
        /// </summary>
        private void productToH_mytm()
        {
            string sqlwhere = string.Format(" and db_product.h_mytm='{0}'", this.tb_isbn.Text.Trim());
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
            if(systemform==null || systemform.IsDisposed)
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

            this.winGridView2.GridView1.Columns["H_amount"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView2.GridView1.Columns["H_output_discount_ls"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView2.GridView1.Columns["H_amount"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //this.winGridView2.GridView1.Columns["U_id"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView2.GridView1.Columns["H_output_discount_ls"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winGridView2.GridView1.Columns["Ls_Sum"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


            this.winGridView2.GridView1.Columns["H_output_price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.winGridView2.GridView1.Columns["H_output_price"].DisplayFormat.FormatString = "c2";
            this.winGridView2.GridView1.Columns["Ls_Sum"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.winGridView2.GridView1.Columns["Ls_Sum"].DisplayFormat.FormatString = "c2";
            //this.winGridView2.GridView1.Columns["Sub_money"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //this.winGridView2.GridView1.Columns["Sub_money"].DisplayFormat.FormatString = "c2";
            this.winGridView2.GridView1.Columns["H_output_discount_ls"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.winGridView2.GridView1.Columns["H_output_discount_ls"].DisplayFormat.FormatString = "p2";
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

            winGridView2.GridView1.RefreshData();//这里刷新一次 要不汇总显示的 页脚 合计不会刷新

        }

        /// <summary>
        /// 计算汇总
        /// </summary>
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
                            real_money_avoid=newitem.Sum(item=>item.H_serial_book=="系统书"?0: item.H_amount * item.H_output_price * item.H_output_discount_ls)//系统书积0分  如果不是积实洋
                        };
            this.Ls_Sum = query.Sum(item => item.ls_sum).ToRound(EnumHelper.GetInstance<RoundType>(Portal.gc.QPossConfig.Ls_qltfs));//  通过字符串获取枚举成员
            this.SubMoney = Ls_Sum - query.Sum(item => item.ls_sum);
            this.tb_submoney.Text = SubMoney.ToString("#0.00");
            this.real_money_avoid = query.Sum(item => item.real_money_avoid);

            this.tb_remal_money.Text = Ls_Sum.ToString("#0.00"); // Math.Round( Ls_Sum,3).ToString();//第三位开始四舍5信 或都tostring("#0.000")
            this.tb_total_num.Text = query.Sum(item => item.total_amount).ToString();
            this.tb_count.Text = string.Format("{0:n0}", query.Sum(item => item.total_count));
            this.total_money = query.Sum(item => item.total_money);
            this.t_total_money.Text = string.Format("{0:c2}", total_money);

        }

        private void ComputeRow(int rowIndex)
        {
            SimpleProductInfo liinfo = new SimpleProductInfo();
            liinfo = (SimpleProductInfo)winGridView2.GridView1.GetRow(rowIndex);
            //LsItemInfo itemInfo = ContaineTOLsItemInfo(liinfo);
            winGridView2.GridView1.SetRowCellValue(rowIndex, "Ls_Sum", liinfo.H_output_price * liinfo.H_amount * liinfo.H_output_discount_ls);
            // winGridView2.GridView1.SetRowCellValue(rowIndex, "Ls_Sum", itemInfo.H_price * itemInfo.H_amount * (1 - itemInfo.H_discount));
        }

        #endregion

        #region 保存前转换 与合并相同品种
        #region MyRegion
        /// <summary>
        /// 保存前转换 与合并相同品种 (不代会员)
        /// </summary>
        /// <param name="prlist"></param>
        /// <returns></returns>
        //public List<SimpleProductInfo> MergeList(List<SimpleProductInfo> prlist)
        //{
        //    List<SimpleProductInfo> mergelist = new List<SimpleProductInfo>();
        //    SimpleProductInfo Mergeinfo = null;
        //    var query = from item in prlist
        //                    // where item.H_amount!=0
        //                group item by item.H_id
        //              into newitem
        //                select new
        //                {
        //                    h_id = newitem.Key,
        //                    h_amount_ls = newitem.Sum(item => item.H_amount),
        //                    h_price = newitem.Max(item => item.H_output_price),
        //                    h_output_discount_ls = newitem.Max(item => item.H_output_discount_ls),
        //                    h_member_ls = newitem.Max(item => item.H_Member_Ls),
        //                    h_name = newitem.Max(item => item.H_name),
        //                    h_isbn = newitem.Max(item => item.H_isbn),
        //                    s_id = Portal.gc.loginUserInfo.Stock_id,
        //                    h_type = newitem.Max(item => item.H_type),
        //                    m_id = newitem.Max(item => item.M_id),
        //                };
        //    foreach (var item in query)
        //    {
        //        Mergeinfo = new SimpleProductInfo();

        //        Mergeinfo.H_id = item.h_id;
        //        Mergeinfo.H_amount = item.h_amount_ls;
        //        Mergeinfo.H_output_price = item.h_price;
        //        Mergeinfo.H_name = item.h_name;
        //        Mergeinfo.H_output_discount_ls = item.h_output_discount_ls;
        //        Mergeinfo.Ls_Sum = Mergeinfo.H_amount * Mergeinfo.H_output_price * Mergeinfo.H_output_discount_ls;
        //        Mergeinfo.H_isbn = item.h_isbn;
        //        Mergeinfo.H_Member_Ls = item.h_member_ls;
        //        //库房编码,如用户未指定库位或者为:AUTO则自动获取uf_GetStockId函数中的库位编码
        //        Mergeinfo.S_id = (string.IsNullOrEmpty(item.s_id) || item.s_id == "AUTO") ? BLLFactory<Product>.Instance.GetStockByProductType(Mergeinfo.H_id, Portal.gc.loginUserInfo.Station_ID) : item.s_id;
        //        mergelist.Add(Mergeinfo);
        //    }
        //    return mergelist;
        //} 
        #endregion

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
                            h_serial_book=newitem.Max(item=>item.H_serial_book),

                        };
            foreach (var item in query)
            {
                Mergeinfo = new SimpleProductInfo();

                Mergeinfo.H_id = item.h_id;
                Mergeinfo.H_amount = item.h_amount_ls;
                Mergeinfo.H_output_price = item.h_price;
                //Mergeinfo.H_Member_Ls = item.h_member_ls;
                Mergeinfo.H_name = item.h_name;
                Mergeinfo.H_output_discount_ls = BLLFactory<Product>.Instance.GetMemberDiscountByProduct(item.h_id, Portal.gc.loginUserInfo.Station_ID, l_member.Text.Trim(), item.h_amount_ls, item.h_price);
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
        private void FromPos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.winGridView2.SaveGridParm();//关闭写入INI文件 宽度 位置等信息  GridView里的
            System.Environment.Exit(0); //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。

        }


        #endregion

        #region 零售主窗体键盘事建
        /// <summary>
        /// 零售主窗体键盘事建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromPos_KeyDown(object sender, KeyEventArgs e)//必须开起KeyPreview为true可不没有反应的
        {

            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                int rowIndex = winGridView2.GridView1.FocusedRowHandle;
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
            }else if(e.KeyCode == System.Windows.Forms.Keys.F3)
            {
                this.tb_xy.Focus();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F4)
            {
                this.tb_sm.Focus();
            }

        }
        #endregion

        #region 删除一行明细
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="rowIndex"></param>
        private void DeleteItem(int rowIndex)
        {
            SimpleProductInfo info = new SimpleProductInfo();
            info = (SimpleProductInfo)winGridView2.GridView1.GetRow(rowIndex);
            if (MessagboxUit.ShowYesNoAndWarning(string.Format("名称：{0}\r\n条码：{1}\n\r数量：{2}\n\r确认要删除吗?", info.H_name, info.H_isbn, info.H_amount)) == System.Windows.Forms.DialogResult.Yes)
            {
                winGridView2.GridView1.DeleteRow(rowIndex);
                winGridView2.GridView1.MoveBy(0);
            }
        }
        /// <summary>
        /// 删除一个品种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = winGridView2.GridView1.FocusedRowHandle;
            if (rowIndex >= 0)
            {
                DeleteItem(rowIndex);

                winGridView2.DataSource = null;
                winGridView2.DataSource = Productlist;
                SetGeShi();
                ComputeTotal();
                winGridView2.gridView1.RefreshData();

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
                    decimal.TryParse( k[1],out youfeimoney);
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
            ItemList = SetLsItemInfo(Productlist);//得到细表信息
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
                        cardruninfo.Card_id = kk.Source_id;
                        cardruninfo.Source_id = lsinfo.Ls_id;
                        cardruninfo.Money = kk.Pay_money;
                        cardruninfo.O_id_operator = Portal.gc.loginUserInfo.O_id;
                        cardruninfo.Inout_flag = "1";
                        cardruninfo.Input_date = DateTime.Now;
                        cardruninfo.Mem = "零售消费";
                        cardruninfo.Discount = kk.Exchange_rate;
                        if (BLLFactory<Ls_card_run>.Instance.Insert(cardruninfo))
                        {
                            MessagboxUit.ShowTips("消费成功！");
                        }
                        else
                        {
                            MessagboxUit.ShowTips("消费 【失败】！");
                        }


                    }
                } 
                #endregion

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
            this.winGridView2.GridView1.RefreshData();
            Portal.iniHelper.ClearSection("ZhiFuFangShi");
            this.real_money_avoid = 0;
            kklist.Clear();
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
                pay_name= payedList.Count > 1 ? "组合收款" : item.Pay_name;
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
            zbinfo.Charge = SubMoney+(-youfeimoney);//去零头金额 如果有积分消零头的 也做成费用里
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
            zbinfo.Memo =string.IsNullOrEmpty( youfeibeizhu)?"":youfeibeizhu;
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
            var list = from k in productList
                       where k.H_amount != 0
                       select k;//去掉数量为0的数据

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
                        winGridView2.DataSource = null;
                        winGridView2.DataSource = Productlist;
                        SetGeShi();
                        winGridView2.gridView1.RefreshData();
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
                            winGridView2.DataSource = null;
                            winGridView2.DataSource = Productlist;
                            SetGeShi();
                            winGridView2.gridView1.RefreshData();
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
                            //这里是解决:注册了会员在代回前台
                            if (tb_member.Text != null)
                            {
                                tb_member.Text = edmember.memberCord;
                                SkinTxt_KeyDown3(null ,e);//sender 相当于动作
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
                    item.H_output_discount_ls = BLLFactory<Product>.Instance.GetMemberDiscountByProduct(item.H_id, Portal.gc.loginUserInfo.Station_ID, l_member.Text.Trim(), item.H_amount, item.H_output_price);
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
                winGridView2.DataSource = null;
                winGridView2.DataSource = Productlist;
                SetGeShi();
                winGridView2.gridView1.RefreshData();
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

        private void tb_submoney_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            pintxiaopiao.PrintController = new StandardPrintController();//不出现正在打印框
            //PaperSize pagesize = new PaperSize("", (int)(58 / 25.4) * 100,);
            //pintxiaopiao.DefaultPageSettings.PaperSize = pagesize;
            pintxiaopiao.PrintPage += new PrintPageEventHandler(Pintxiaopiao_PrintPage);
            pintxiaopiao.Print();

        }

        private void Pintxiaopiao_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                Font f = SystemFonts.DefaultFont;
                Brush fbrush = SystemBrushes.ControlText;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Near;
                if(!string.IsNullOrEmpty(possetup.Tou1))
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
                    sb.AppendLine(string.Format("{0}", item.H_name));
                    sb.AppendLine(string.Format("{0}{1}{2}{3:c2}", string.Format("{0:0.00%}", item.H_output_discount_ls).PadRight(6, ' '), string.Format("  {0:n0}", item.H_amount).PadRight(6, ' '), string.Format("{0:c2}", item.H_output_price).PadRight(8, ' '), item.H_output_price * item.H_output_discount_ls * item.H_amount));
                }
                sb.AppendLine(string.Format("------------------------------"));
                sb.AppendLine(string.Format("总数量   总码洋   总实洋"));
                sb.AppendLine(string.Format("{0}  {1}  {2}", string.Format("{0:n0}", WanZhengLsInfo.Total_amount).PadRight(8, ' '), string.Format("{0:c2}", WanZhengLsInfo.Total_money).PadRight(8, ' '), string.Format("{0:c2}", WanZhengLsInfo.Real_money).PadRight(8, ' ')));
                sb.AppendLine(string.Format("------------------------------"));
                sb.AppendLine(string.Format("支付方式:{0}", string.IsNullOrEmpty(pay_name) ? pay_name : pay_name));
                if (cdmember != null && !string.IsNullOrEmpty( cdmember.M_id))
                {
                    sb.AppendLine(string.Format("会员名称:{0}", string.IsNullOrEmpty(cdmember.M_name) ? "" : cdmember.M_name));
                    sb.AppendLine(string.Format("会员积分:{0}", string.IsNullOrEmpty(cdmember.Integral.ToString("n2")) ? "" : cdmember.Integral.ToString("n2")));
                    sb.AppendLine(string.Format("会员卡内余额:{0}", string.IsNullOrEmpty(cdmember.SurplusMoney) ? "" :string.Format("{0:c2}", cdmember.SurplusMoney) ));
                }
                sb.AppendLine(string.Format("品种:{0}应收:{1}", string.Format("{0:n0}", WanZhengLsInfo.Total_amount).PadRight(14, ' '), string.Format("{0:c2}", Ls_Sum)));
                sb.AppendLine(string.Format("收银:{0}实收:{1}", string.Format("{0}", Portal.gc.loginUserInfo.O_Name).PadRight(14, ' '), string.Format("{0:c2}", paymoney)));
                sb.AppendLine(string.Format("费用:{0}找零:{1}", string.Format("{0:c2}", SubMoney).PadRight(14, ' '), string.Format("{0:c2}", changemoney)));
                sb.AppendLine(string.Format("台号:{0}站点:{1}", string.Format("{0}", Portal.gc.loginUserInfo.Yh_stand_id).PadRight(14, ' '), Portal.gc.loginUserInfo.Station_ID));
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
                e.Graphics.DrawString(sb.ToString(), f, fbrush, new Rectangle(3, 3, (int)(58 / 25.4) * 100, 500), sf);//this.ClientRectangle
            }
            catch (Exception ex)
            {
                MessagboxUit.ShowTips(ex.Message);
            }

        }
      
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (temform == null || temform.IsDisposed)//判断窗体是否打开了
            {
                temform = new operators();
                temform.Show();
            }
            else
            {
                temform.Activate();
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void textBoxControls1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
