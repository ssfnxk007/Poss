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
    public partial class FormPassword : Form
    {
        public string m_id;
        public bool YesOrNo=false;
        public FormPassword()
        {
            InitializeComponent();
            this.ControlBox = false;//关闭退出按件
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void FormPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
             List<MemberInfo> minfo=   BLLFactory<Member>.Instance.Find(string.Format(" m_id='{0}'", m_id));
                if (minfo[0].M_password == this.textEdit1.Text.Trim())
                {
                    YesOrNo = true;
                    this.Close();
                }
                else
                {
                    MessagboxUit.ShowError("密码输入不正确！请重新输入！");
                    YesOrNo = false;
                }
            }
            else if(e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                YesOrNo = false;
                this.Close();
            }
        }
    }
}
