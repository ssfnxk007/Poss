using CCWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonsHelper;
using POSS.Entity;
using WHC.Framework.ControlUtil;
using POSS.BLL;
using WHC.Framework.Commons;

namespace POSS
{
   public class login : CCSkinMain
    {
        #region 变量
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton skinButton3;
        private System.ComponentModel.IContainer components;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinComboBox CB_1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        #endregion

       
        private PossUits frompos = null;//零售主窗体
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.CB_1 = new CCWin.SkinControl.SkinComboBox();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.CB_1);
            this.skinPanel1.Controls.Add(this.skinButton3);
            this.skinPanel1.Controls.Add(this.skinButton2);
            this.skinPanel1.Controls.Add(this.skinButton1);
            this.skinPanel1.Controls.Add(this.skinTextBox2);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 28);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(461, 282);
            this.skinPanel1.TabIndex = 0;
            // 
            // CB_1
            // 
            this.CB_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_1.FormattingEnabled = true;
            this.CB_1.Location = new System.Drawing.Point(116, 56);
            this.CB_1.Name = "CB_1";
            this.CB_1.Size = new System.Drawing.Size(234, 22);
            this.CB_1.TabIndex = 5;
            this.CB_1.WaterText = "";
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(275, 238);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(75, 23);
            this.skinButton3.TabIndex = 4;
            this.skinButton3.Text = "配 置";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Visible = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(275, 159);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 4;
            this.skinButton2.Text = "退 出";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(116, 159);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "登 录";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '●';
            this.skinTextBox2.IsSystemPasswordChar = true;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(116, 98);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = false;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(234, 28);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.PasswordChar = '●';
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(224, 18);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.UseSystemPasswordChar = true;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 3;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.WaterText = "";
            this.skinTextBox2.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(58, 103);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "密码：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(58, 56);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "用户名：";
            // 
            // login
            // 
            this.ClientSize = new System.Drawing.Size(469, 314);
            this.Controls.Add(this.skinPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MobileApi = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录框";
            this.Load += new System.EventHandler(this.login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public login()
        {
            InitializeComponent();
            SetO_id();
        }
        public void SetO_id()
        {
            this.CB_1.DataSource = UserHelper.Get_UsersInfo();
            this.CB_1.DisplayMember = "O_name";
            this.CB_1.ValueMember = "O_id";
        }
        /// <summary>
        /// 设置窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton3_Click(object sender, EventArgs e)
        {
            //if (temform == null || temform.IsDisposed)//判断窗体是否打开了
           // {
           //     temform = new operators();
           //     temform.Show();
           // }
           // else
           // {
           //     temform.Activate();
           // }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string o_id = string.Empty;
            o_id = this.CB_1.SelectedValue.ToString();
            string passwd = this.skinTextBox2.Text.ToLower().ToString();
            if (!string.IsNullOrEmpty(o_id) && o_id!="0")
            {
              string reult= UserHelper.Validation_Users(o_id, passwd);
                if (reult == "成功")
                {
                    GetDengLu_UserInfo(o_id);
                    LoacdSystemPortal();
                    Cache.Instance.Add("loginUserInfo", Portal.gc.loginUserInfo);//加入缓存中 后面 在页面加载时还得 复值  
                    Cache.Instance.Add("QPossConfig", Portal.gc.QPossConfig);

                    if (frompos==null || frompos.IsDisposed)
                    {

                        frompos = new PossUits();
                        frompos.O_id = o_id;
                        frompos.Show();
                        
                        this.Hide();
                        
                    }
                    else
                    {
                        frompos.Activate();
                    }

                }
                else
                {
                    MessagboxUit.ShowError(reult);
                    skinTextBox2.Focus();
                }
            }
            else
            {
                MessagboxUit.ShowError("是否没有选择用户");
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                skinButton1_Click(null, null);
            }
        }

        #region 获取登录用户信息
        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <param name="o_id"></param>
        /// <returns></returns>
        private UsersInfo GetDengLu_UserInfo(string o_id)
        {
            UsersInfo userinfo = new UsersInfo();
            List<UsersInfo> list = new List<UsersInfo>();
            list = BLLFactory<Users>.Instance.GetDengLuInfo(o_id);
            if (list.Count == 1)
            {
                foreach (UsersInfo item in list)
                {
                    Cache.Instance.RemoveAll();
                    userinfo = item;
                    Portal.gc.loginUserInfo = Portal.gc.ConvertToLoginUser(item);
                   
                }
            }

            return userinfo;

        }
        #endregion


        #region 加载全局系统设置
        /// <summary>
        /// 加载全局系统设置
        /// </summary>
        private void LoacdSystemPortal()
        {
            List<Poss_conigInfo> list = new List<Poss_conigInfo>();

            list = BLLFactory<Poss_conig>.Instance.GetPossConfig();
            if (list != null)
            {
                foreach (var item in list)
                {
                    Portal.gc.QPossConfig = Portal.gc.ConvertToPossConfig(item);

                }
            }
        }

        #endregion

        private void login_Load(object sender, EventArgs e)
        {
            this.CB_1.Select();
        }


        private bool GetSyStemDateTime()
        {
            return true;
        }
    }
}
