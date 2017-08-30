using POSS.Entity;
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

namespace POSS
{
    public partial class DanBanFrom : BaseDock
    {
        public DangBanInfo csinfo;
        public bool YesOrNo = false;
        private DangBanInfo Sqlinfo = null;

        public DanBanFrom()
        {
            InitializeComponent();
           
        }

        private void DanBanFrom_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            
            t_o_id.Text = Portal.gc.loginUserInfo.O_Name;
            Sqlinfo = new DangBanInfo();
            Sqlinfo = BLLFactory<DangBan>.Instance.FindSingle(string.Format("o_id='{0}' AND DanBan_Date='{1}'AND Is_Jk='0' AND station_id='{2}'", csinfo.O_id, csinfo.DanBan_Date, csinfo.Station_id));

            this.t_Yj.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( t_o_id.Text.Trim())) return;
            if (string.IsNullOrEmpty(t_Yj.Text.Trim()))
            {
                MessagboxUit.ShowTips("请输入预备零钱金额！");
                this.t_Yj.Focus();
            }
            else
            {
                
                Sqlinfo.YuBeiLingQian = t_Yj.Text.Trim().ToDecimal();
               if(BLLFactory<DangBan>.Instance.Update(Sqlinfo, Sqlinfo.ID))
                {
                    YesOrNo = true;
                    MessagboxUit.ShowTips("当班成功！祝您上班有个好心情！");
                    this.Close();
                }
                else
                {
                    YesOrNo = false;
                    MessagboxUit.ShowTips("有错！！！");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessagboxUit.ShowYesNoAndTips("要删除此次当班信息吗？") == System.Windows.Forms.DialogResult.Yes)
            {
                BLLFactory<DangBan>.Instance.Delete(Sqlinfo.ID);
            }
            
            this.Close();
        }
    }
}
