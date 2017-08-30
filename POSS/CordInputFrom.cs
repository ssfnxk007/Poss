using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSS.Entity;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;
using System.Drawing.Printing;
using static DevExpress.Data.Filtering.Helpers.PropertyDescriptorCriteriaCompilationSupport;

namespace POSS
{
    public partial class CordInputFrom : BaseForm
    {
        private string iniFile = string.Format(@"{0}\{1}", DirectoryUtil.GetCurrentDirectory(), "PosSetupValues.ini");
        public MemberInfo memberinfo;

        private System.Drawing.Printing.PrintDocument pintxiaopiaoCz;//小票打印
        private INIFileUtil iniHelper;
        private string Section = "PosSetup";
        public SimpleMemberInfo simmemberinfo;
        string SurplusMoney = string.Empty;//卡内余额
        public CordInputFrom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 字典
        /// </summary>
        private void InitDictItem()
        {
            this.t_oper.Text = Portal.gc.loginUserInfo.O_Name;

            this.t_pamds.DisplayMember = "显示值";
            this.t_pamds.ValueMember = "项目值";
            this.t_pamds.DataSource = DictItemUtil.Get_paymods();

            this.t_input.EditValue = DateTime.Now;


        }

        private void CordInputFrom_Load(object sender, EventArgs e)
        {
            InitDictItem();
            this.t_card_id.Text = memberinfo.Card_id;
            this.t_m_id.Text = memberinfo.M_id;
            this.t_pamds.SelectedValue = "0001";
           
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.t_money.Text.Length == 0)
            {
                MessagboxUit.ShowTips("请输入冲值金额！");
                this.t_money.Focus();
            }
            else
            {
                Ls_card_runInfo info = new Ls_card_runInfo();
                info.Card_id = t_card_id.Text.Trim();
                info.Discount = 1;
                info.Inout_flag = "0";
                info.Input_date = DateTime.Now;
                info.Mem = t_beizhu.Text.Trim();
                info.Money = t_money.Text.ToDecimal();
                info.O_id_operator = Portal.gc.loginUserInfo.O_id;
                info.Source_id = "";
                if (BLLFactory<Ls_card_run>.Instance.InserLS_Card_run(info, Portal.gc.loginUserInfo.Station_ID))
                {
                    SurplusMoney = BLLFactory<Ls_card_run>.Instance.GetMemberSurplusMoney(info.Card_id);
                    MessagboxUit.ShowTips(string.Format("冲值成功！卡内余额为{0}元！", SurplusMoney));
                    Print();
                    this.t_money.Text = "";
                }
            }
            this.Close();
           
        }


        private void Print()
        {
            if (c_print.Checked)
            {
                pintxiaopiaoCz = new System.Drawing.Printing.PrintDocument();
                pintxiaopiaoCz.PrintController = new StandardPrintController();//不出现正在打印框
                pintxiaopiaoCz.PrintPage += new PrintPageEventHandler(PintxiaopiaoCz_PrintPage);
                pintxiaopiaoCz.Print();
            }
        }

        private void PintxiaopiaoCz_PrintPage(object sender, PrintPageEventArgs e)
        {
            string kk = this.t_card_id.Text.Trim();
            this.iniHelper = new INIFileUtil(iniFile);
            try
            {
                StringBuilder sb = new StringBuilder();
                Font f = SystemFonts.DefaultFont;
                Brush fbrush = SystemBrushes.ControlText;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Near;
                string tou1 = this.iniHelper.IniReadValue(Section, "Tou1");
                string tou2 = this.iniHelper.IniReadValue(Section, "Tou2");
                string wei1 = this.iniHelper.IniReadValue(Section, "Wei1");
                string wei2 = this.iniHelper.IniReadValue(Section, "Wei2");
                string wei3 = this.iniHelper.IniReadValue(Section, "Wei3");
                string wei4 = this.iniHelper.IniReadValue(Section, "Wei4");
                if (!string.IsNullOrEmpty(tou1))
                {
                    sb.AppendLine(string.Format("{0}", tou1).PadLeft(15, ' '));
                }
                if (!string.IsNullOrEmpty(tou2))
                {
                    sb.AppendLine(string.Format("{0}", tou2).PadLeft(15, ' '));
                }
                sb.AppendLine(string.Format("卡号   冲值金额   卡内金额"));
                sb.AppendLine(string.Format("------------------------------"));
                sb.AppendLine(string.Format("{0:c2}   {1:c2}元 {2:c2}元", kk.PadRight(6, ' '),this.t_money.Text.PadRight(4, ' '),SurplusMoney));
                if (!string.IsNullOrEmpty(wei1))
                {
                    sb.AppendLine(string.Format("{0}", wei1).PadLeft(15, ' '));
                }
                if (!string.IsNullOrEmpty(wei2))
                {
                    sb.AppendLine(string.Format("{0}", wei2).PadLeft(15, ' '));
                }
                if (!string.IsNullOrEmpty(wei3))
                {
                    sb.AppendLine(string.Format("{0}", wei3).PadLeft(15, ' '));
                }
                if (!string.IsNullOrEmpty(wei4))
                {
                    sb.AppendLine(string.Format("{0}", wei4).PadLeft(15, ' '));
                }
                sb.AppendLine(string.Format("日期:{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now));
                e.Graphics.DrawString(sb.ToString(), f, fbrush, new Rectangle(3, 3, (int)(58 / 25.4) * 100, 500), sf);//this.ClientRectangle
            }
            catch (Exception ex)
            {
                MessagboxUit.ShowError(ex.Message);
                LogTextHelper.Debug(ex.Message);
            }
        }
    }
}
