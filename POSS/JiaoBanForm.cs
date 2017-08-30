using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;
using POSS.Entity;
namespace POSS
{
    public partial class JiaoBanForm : BaseDock
    {
        public JiaoBanForm()
        {
            InitializeComponent();
        }
        DangBanInfo info = null;
        
        private void JiaoBanForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            string o_id = Portal.gc.loginUserInfo.O_id;
            string DanBan_Date=DateTime.Now.ToString("yyyy-MM-dd");
            string station_id = Portal.gc.loginUserInfo.Station_ID;
            if (!string.IsNullOrEmpty(o_id))
            {
                info = new DangBanInfo();
                info= BLLFactory<DangBan>.Instance.FindSingle(string.Format("o_id='{0}' AND DanBan_Date='{1}'AND Is_Jk='0' AND station_id='{2}'",o_id,DanBan_Date,station_id));
                if(string.IsNullOrEmpty(info.O_id) )
                {
                    MessagboxUit.ShowError(string.Format("没有当前人员{0}的当班记录！",o_id));
                }
                this.t_oper.Text = Portal.gc.loginUserInfo.O_Name;
                this.t_yujao.Text = info.YuBeiLingQian.ToString("#0.00");
            }
            this.t_xianjin.Focus();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(info.O_id)) return;
            if (!string.IsNullOrEmpty(this.t_xianjin.Text.Trim()))
            {
                info.JiaoKuanMoney = this.t_xianjin.Text.Trim().ToDecimal();
                info.JiaoBanDateTime = DateTime.Now;
                info.Is_Jk = "1";
                if(BLLFactory<DangBan>.Instance.Update(info, info.ID))
                {
                    MessagboxUit.ShowTips("交款成功！下班请注意安全~！");
                    this.Close();
                    
                }
                
            }
            else
            {
                MessagboxUit.ShowTips("请输入交款金额！");
                this.t_xianjin.Focus();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
