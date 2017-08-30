using CCWin;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSS.BLL;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
namespace POSS
{
    public partial class SystemFrom : BaseDock
    {
        public string O_name//用户名
        {
            get; set;
        }
        public SystemFrom()
        {
            InitializeComponent();


        }
        PosSetup posconfig = new PosSetup();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void insert()
        {
            SetInfo();
            Poss_conigInfo info = new Poss_conigInfo();
            info = insertinfo(insertSet());
            if (info != null)
            {
                if (BLLFactory<Poss_conig>.Instance.insetOrUpdate(info))
                {

                    MessagboxUit.ShowTips("保存成功！必须完全退出软件修改才能生效！");
                }
                else
                {
                    MessagboxUit.ShowError("保存失败！");
                }
            }

        }
        /// <summary>
        /// 插入或更新
        /// </summary>
        /// <returns></returns>
        public QueryPossConfig insertSet()
        {
            QueryPossConfig config = new QueryPossConfig();
            config.Id = "1";
            if (this.c_jifen.Checked == true)
            {
                config.Is_jifen = "1";
            }
            if (this.c_ysdh.Checked == true)
            {
                config.Is_ysdh = "1";
            }
            if (this.c_is_xitongshu.Checked == true)
            {
                config.Is_xitongshu = "1";
            }
            if (this.c_movemember.Checked == true)
            {
                config.Is_MoveMember = "1";
            }
            config.Taosu = this.t_tiaosu.Text.Trim();
            config.Wx_appid = t_wxappid.Text.Trim();
            config.Wx_appsecret = t_wxappsecret.Text.Trim();
            config.Wx_key = t_wxkey.Text.Trim();
            config.Wx_mchid = t_wxmchid.Text.Trim();
            config.Wx_miaosu = t_wxmiaoshu.Text.Trim();
            config.Ls_qltfs = tb_qltfs.EditValue.ToString();
            config.Ls_jfdhbl = tb_jfdhbl.Text.Trim();
            config.Is_qtjl = tb_YesOrNo.EditValue.ToString();
            config.Zfb_alipay_public_key = zfb_alipay_public_key.Text.Trim();
            config.Zfb_appid = zfb_appid.Text.Trim();
            config.Zfb_merchant_private_key = zfb_merchant_private_key.Text.Trim();
            config.Zfb_miaoshu = zfb_goods_name.Text.Trim();
            config.Zfb_merchant_public_key = zfb_merchant_public_key.Text.Trim();
            config.Zfb_pid = zfb_pid.Text.Trim();
           




            return config;
        }
        /// <summary>
        /// 实体转数据库实体
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        private Poss_conigInfo insertinfo(QueryPossConfig con)
        {
            Poss_conigInfo info = new Poss_conigInfo();
            info.Id = con.Id;
            info.Is_jifen = con.Is_jifen;
            info.Is_ysdh = con.Is_ysdh;
            info.Taosu = con.Taosu;
            info.Wx_appid = con.Wx_appid;
            info.Wx_appsecret = con.Wx_appsecret;
            info.Wx_kdy = con.Wx_key;
            info.Wx_mchid = con.Wx_mchid;
            info.Wx_miaosu = con.Wx_miaosu;
            info.Is_qtjl = con.Is_qtjl;
            info.Ls_jfdhbl = con.Ls_jfdhbl;
            info.Ls_qltfs = con.Ls_qltfs;
            info.Is_xitongshu = con.Is_xitongshu;
            //还有支付宝的
            info.Zfb_alipay_public_key = con.Zfb_alipay_public_key;
            info.Zfb_appid = con.Zfb_appid;
            info.Zfb_merchant_private_key = con.Zfb_merchant_private_key;
            info.Zfb_merchant_public_key = con.Zfb_merchant_public_key;
            info.Zfb_miaoshu = con.Zfb_miaoshu;
            info.Zfb_pid = con.Zfb_pid;
            info.Is_MoveMember = con.Is_MoveMember;

            return info;
        }

        private void SystemFrom_Load(object sender, EventArgs e)
        {
            this.OpenMoneyboxWay.SelectedIndex = -1;
            Readonly(true);
            jiazhai();
            SetQLTFS();
            SetYseOrNo();
            if (this.tb_YesOrNo.Text == "是")
            {
                tb_jfdhbl.Enabled = false;
            }
            else
            {
                tb_jfdhbl.Enabled = true;
            }
            InitPrinter();
            DisplayData();
        }

        private void jiazhai()
        {
            // List<Poss_conigInfo> list = new List<Poss_conigInfo>();

            //list= BLLFactory<Poss_conig>.Instance.GetPossConfig();
            // if (list != null)
            // {
            //     foreach (var item in list)
            //     {
            //         Portal.gc.
            //     }
            // }
            QueryPossConfig info = Portal.gc.QPossConfig;
            SetText(info);

        }
        private void SetText(QueryPossConfig info)
        {
            if (info != null)
            {

                this.t_tiaosu.Text = info.Taosu;
                this.t_wxappid.Text = info.Wx_appid;
                t_wxappsecret.Text = info.Wx_appsecret;
                t_wxkey.Text = info.Wx_key;
                t_wxmchid.Text = info.Wx_mchid;
                t_wxmiaoshu.Text = info.Wx_miaosu;
                tb_jfdhbl.Text = info.Ls_jfdhbl;
                tb_qltfs.EditValue = info.Ls_qltfs;
                tb_YesOrNo.EditValue = info.Is_qtjl;
                zfb_alipay_public_key.Text = info.Zfb_alipay_public_key;
                zfb_appid.Text = info.Zfb_appid;
                zfb_goods_name.Text = info.Zfb_miaoshu;
                zfb_merchant_private_key.Text = info.Zfb_merchant_private_key;
                zfb_merchant_public_key.Text = info.Zfb_merchant_public_key;
                zfb_pid.Text = info.Zfb_pid;
                if (info.Is_jifen == "1")
                {
                    c_jifen.Checked = true;
                }
                else
                {
                    c_jifen.Checked = false;

                }
                if (info.Is_ysdh == "1")
                {
                    c_ysdh.Checked = true;
                }
                else
                {
                    c_ysdh.Checked = false;
                }
                if (info.Is_xitongshu == "1")
                {
                    c_is_xitongshu.Checked = true;
                }
                else
                {
                    c_is_xitongshu.Checked = false;
                }
                if (info.Is_MoveMember == "1")
                {
                    c_movemember.Checked = true;
                }
                else
                {
                    c_movemember.Checked = false;
                }

            }

        }


        /// <summary>
        /// 设置去零头方式
        /// </summary>
        private void SetQLTFS()
        {
            DataTable dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
            string[] Values = EnumHelper.GetMemberNames<RoundType>();
            DataRow dr;
            foreach (string s in Values)
            {
                dr = dt.NewRow();
                dr[0] = s;
                dr[1] = EnumHelper.GetDescription(typeof(RoundType), EnumHelper.GetMemberValue<RoundType>(s));
                dt.Rows.Add(dr);
            }
            this.tb_qltfs.Properties.DisplayMember = "显示值";
            this.tb_qltfs.Properties.ValueMember = "项目值";
            this.tb_qltfs.Properties.DataSource = dt;
        }
        private void SetYseOrNo()
        {
            DataTable dt = DataTableHelper.CreateTable("显示值|string,项目值|string");
            DataRow dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "是";

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "0";
            dr[1] = "否";
            dt.Rows.Add(dr);

            this.tb_YesOrNo.Properties.DisplayMember = "项目值";
            this.tb_YesOrNo.Properties.ValueMember = "显示值";
            this.tb_YesOrNo.Properties.DataSource = dt;
        }

        private void tb_YesOrNo_EditValueChanged(object sender, EventArgs e)
        {
            if (this.tb_YesOrNo.Text == "是")
            {
                tb_jfdhbl.Enabled = false;
            }
            else
            {
                tb_jfdhbl.Enabled = true;
            }
        }

        #region PosSteup
        /// <summary>
        /// PosSteup
        /// </summary>
        private void SetInfo()
        {

            posconfig = new PosSetup();

            this.posconfig.CustomerMoneyBox = this.CustomerMoneyBox.Text;
            this.posconfig.IsPrint = this.IsPrint.Checked;
            this.posconfig.IsUseMoneyBox = this.IsUseMoneyBox.Checked;
            this.posconfig.MoneyBoxPort = this.MoneyBoxPort.Text;
            this.posconfig.OpenMoneyboxWay = this.OpenMoneyboxWay.SelectedIndex == 0 ? "Post" : "Ext";
            this.posconfig.PaperFeed = this.PaperFeed.Text.ToInt32();
            this.posconfig.PapgerWidth = this.PapgerWidth.Text.ToInt32();
            this.posconfig.PrintCount = this.PrintCount.Text.ToInt32();
            this.posconfig.PrintName = this.PrintName.Text;
            this.posconfig.Tou1 = this.text_tou1.Text;
            this.posconfig.Tou2 = this.text_tou2.Text;
            this.posconfig.Wei1 = this.text_wei1.Text;
            this.posconfig.Wei2 = this.text_wei2.Text;
            this.posconfig.Wei3 = this.text_wei3.Text;
            this.posconfig.Wei4 = this.text_wei4.Text;
            //this.posconfig.Is_MoveMember = this.c_movemember.Checked;
            BLLFactory<PosSetup>.Instance.Save(posconfig);
        }

        private void DisplayData()
        {

            posconfig = new PosSetup();

            this.CustomerMoneyBox.Text = this.posconfig.CustomerMoneyBox;
            this.CustomerMoneyBox.Text = this.posconfig.CustomerMoneyBox;
            this.IsPrint.Checked = this.posconfig.IsPrint;
            this.IsUseMoneyBox.Checked = this.posconfig.IsUseMoneyBox;
            this.MoneyBoxPort.Text = this.posconfig.MoneyBoxPort;
            this.OpenMoneyboxWay.SelectedIndex = this.posconfig.OpenMoneyboxWay == "Post" ? 0 : 1;
            this.PaperFeed.Text = this.posconfig.PaperFeed.ToString();
            this.PapgerWidth.Text = this.posconfig.PapgerWidth.ToString();
            this.PrintCount.Text = this.posconfig.PrintCount.ToString();
            this.PrintName.Text = this.posconfig.PrintName;
            this.text_tou1.Text = this.posconfig.Tou1;
            this.text_tou2.Text = this.posconfig.Tou2;
            this.text_wei1.Text = this.posconfig.Wei1;
            this.text_wei2.Text = this.posconfig.Wei2;
            this.text_wei3.Text = this.posconfig.Wei3;
            this.text_wei4.Text = this.posconfig.Wei4;
        }
        /// <summary>
        /// 初始化打印机列表
        /// </summary>
        private void InitPrinter()
        {
            this.PrintName.Properties.Items.Clear();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                this.PrintName.Properties.Items.Add(printer);
            }
        }
        private void IsPrint_QueryValueByCheckState(object sender, DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventArgs e)
        {
            bool check = e.CheckState == CheckState.Checked ? true : false;
            PapgerWidth.Properties.ReadOnly = !check;
            PrintName.Properties.ReadOnly = !check;
            PrintCount.Properties.ReadOnly = !check;
            PaperFeed.Properties.ReadOnly = !check;

        }

        private void IsUseMoneyBox_QueryValueByCheckState(object sender, DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventArgs e)
        {
            bool check = e.CheckState == CheckState.Checked ? true : false;
            MoneyBoxPort.Properties.ReadOnly = !check;
            OpenMoneyboxWay.Enabled = check;
            CustomerMoneyBox.Enabled = check;
            this.OpenMoneyboxWay.SelectedIndex = check ? (this.posconfig.OpenMoneyboxWay == "Port" ? 0 : 1) : -1;
        } 
        #endregion

        private void Readonly(bool k)
        {
            t_tiaosu.ReadOnly = k;
            t_wxappid.ReadOnly = k;
            t_wxappsecret.ReadOnly = k;
            t_wxkey.ReadOnly = k;
            t_wxmchid.ReadOnly = k;
            t_wxmiaoshu.ReadOnly = k;
            c_jifen.ReadOnly = k;
            tb_qltfs.ReadOnly = k;
            tb_YesOrNo.ReadOnly = k;
            tb_jfdhbl.ReadOnly = k;
            c_is_xitongshu.ReadOnly = k;
            zfb_alipay_public_key.ReadOnly = k;
            zfb_appid.ReadOnly = k;
            zfb_goods_name.ReadOnly = k;
            zfb_merchant_private_key.ReadOnly = k;
            zfb_merchant_public_key.ReadOnly = k;
            zfb_pid.ReadOnly = k;
            tb_jfdhbl.ReadOnly = k;
            c_movemember.ReadOnly = k;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Readonly(false);
        }
    }
}
