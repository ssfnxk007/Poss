using CCWin;
using CommonsHelper;
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

namespace POSS
{
    public partial class FormM_pass : CCSkinMain
    {
        LoginUserInfo userinfo = null;
        UsersInfo info = null;
        public FormM_pass()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.t_new.Text.Trim() == this.t_newb.Text.Trim())
            {
                info = new UsersInfo();
                info.Is_word = "1";
                info.O_id = userinfo.O_id;
                info.O_name = userinfo.O_Name;
                info.Passwd = this.t_new.Text.Trim();
                info.Station_id = userinfo.Station_ID;
                info.Stock_id = userinfo.Stock_id;
                info.Yh_stand_id = userinfo.Yh_stand_id;
               if(UserHelper.SaveUsers(info))
                {
                    MessagboxUit.ShowTips("修改成功！");
                }
                else
                {
                    MessagboxUit.ShowTips("修改 失败~！");
                }
            }
            else
            {
                MessagboxUit.ShowTips("二次密码不一致！");
            }
            
        }

        private void FormM_pass_Load(object sender, EventArgs e)
        {
            userinfo = new LoginUserInfo();
            userinfo = Portal.gc.loginUserInfo;
            if (!string.IsNullOrEmpty(userinfo.O_Name))
            {
                this.la_name.Text = userinfo.O_Name;
                
            }
            this.t_new.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
