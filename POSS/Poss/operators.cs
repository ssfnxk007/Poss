using CCWin;
using CommonsHelper;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;

namespace POSS
{
   public  class operators: CCSkinMain
    {
        #region 变量
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private System.ComponentModel.IContainer components;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.ComboBox cb_isword;
        private System.Windows.Forms.ComboBox cb_stand;
        private System.Windows.Forms.ComboBox cb_stock;
        private System.Windows.Forms.ComboBox cb_station;
        private System.Windows.Forms.ComboBox cb_oper;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel lab_2;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinTextBox tb_pass;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel lab_1; 
        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.lab_1 = new CCWin.SkinControl.SkinLabel();
            this.cb_oper = new System.Windows.Forms.ComboBox();
            this.lab_2 = new CCWin.SkinControl.SkinLabel();
            this.cb_station = new System.Windows.Forms.ComboBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.cb_stock = new System.Windows.Forms.ComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.cb_stand = new System.Windows.Forms.ComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.cb_isword = new System.Windows.Forms.ComboBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tb_pass = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.tb_pass);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinButton2);
            this.skinPanel1.Controls.Add(this.skinButton1);
            this.skinPanel1.Controls.Add(this.cb_isword);
            this.skinPanel1.Controls.Add(this.cb_stand);
            this.skinPanel1.Controls.Add(this.cb_stock);
            this.skinPanel1.Controls.Add(this.cb_station);
            this.skinPanel1.Controls.Add(this.cb_oper);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.lab_2);
            this.skinPanel1.Controls.Add(this.lab_1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 28);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(303, 306);
            this.skinPanel1.TabIndex = 0;
            // 
            // lab_1
            // 
            this.lab_1.AutoSize = true;
            this.lab_1.BackColor = System.Drawing.Color.Transparent;
            this.lab_1.BorderColor = System.Drawing.Color.White;
            this.lab_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_1.Location = new System.Drawing.Point(39, 25);
            this.lab_1.Name = "lab_1";
            this.lab_1.Size = new System.Drawing.Size(68, 17);
            this.lab_1.TabIndex = 0;
            this.lab_1.Text = "员工编号：";
            // 
            // cb_oper
            // 
            this.cb_oper.FormattingEnabled = true;
            this.cb_oper.Location = new System.Drawing.Point(114, 25);
            this.cb_oper.Name = "cb_oper";
            this.cb_oper.Size = new System.Drawing.Size(121, 20);
            this.cb_oper.TabIndex = 1;
            // 
            // lab_2
            // 
            this.lab_2.AutoSize = true;
            this.lab_2.BackColor = System.Drawing.Color.Transparent;
            this.lab_2.BorderColor = System.Drawing.Color.White;
            this.lab_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_2.Location = new System.Drawing.Point(39, 58);
            this.lab_2.Name = "lab_2";
            this.lab_2.Size = new System.Drawing.Size(68, 17);
            this.lab_2.TabIndex = 0;
            this.lab_2.Text = "站点编号：";
            // 
            // cb_station
            // 
            this.cb_station.FormattingEnabled = true;
            this.cb_station.Location = new System.Drawing.Point(114, 58);
            this.cb_station.Name = "cb_station";
            this.cb_station.Size = new System.Drawing.Size(121, 20);
            this.cb_station.TabIndex = 1;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(39, 96);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "库房编号：";
            // 
            // cb_stock
            // 
            this.cb_stock.FormattingEnabled = true;
            this.cb_stock.Location = new System.Drawing.Point(114, 96);
            this.cb_stock.Name = "cb_stock";
            this.cb_stock.Size = new System.Drawing.Size(121, 20);
            this.cb_stock.TabIndex = 1;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(39, 132);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(68, 17);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "零售台号：";
            // 
            // cb_stand
            // 
            this.cb_stand.FormattingEnabled = true;
            this.cb_stand.Location = new System.Drawing.Point(114, 132);
            this.cb_stand.Name = "cb_stand";
            this.cb_stand.Size = new System.Drawing.Size(121, 20);
            this.cb_stand.TabIndex = 1;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(39, 171);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "是否有效：";
            // 
            // cb_isword
            // 
            this.cb_isword.FormattingEnabled = true;
            this.cb_isword.Location = new System.Drawing.Point(114, 171);
            this.cb_isword.Name = "cb_isword";
            this.cb_isword.Size = new System.Drawing.Size(121, 20);
            this.cb_isword.TabIndex = 1;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(54, 262);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "确 定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(172, 262);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 2;
            this.skinButton2.Text = "取 消";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(56, 213);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(52, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "密  码：";
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.Transparent;
            this.tb_pass.DownBack = null;
            this.tb_pass.Icon = null;
            this.tb_pass.IconIsButton = false;
            this.tb_pass.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_pass.IsPasswordChat = '●';
            this.tb_pass.IsSystemPasswordChar = true;
            this.tb_pass.Lines = new string[0];
            this.tb_pass.Location = new System.Drawing.Point(114, 207);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(0);
            this.tb_pass.MaxLength = 32767;
            this.tb_pass.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_pass.MouseBack = null;
            this.tb_pass.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_pass.Multiline = false;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.NormlBack = null;
            this.tb_pass.Padding = new System.Windows.Forms.Padding(5);
            this.tb_pass.ReadOnly = false;
            this.tb_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pass.Size = new System.Drawing.Size(121, 28);
            // 
            // 
            // 
            this.tb_pass.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_pass.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_pass.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_pass.SkinTxt.Name = "BaseText";
            this.tb_pass.SkinTxt.PasswordChar = '●';
            this.tb_pass.SkinTxt.Size = new System.Drawing.Size(111, 18);
            this.tb_pass.SkinTxt.TabIndex = 0;
            this.tb_pass.SkinTxt.UseSystemPasswordChar = true;
            this.tb_pass.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_pass.SkinTxt.WaterText = "";
            this.tb_pass.TabIndex = 4;
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_pass.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_pass.WaterText = "";
            this.tb_pass.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.Crimson;
            this.skinLabel5.Location = new System.Drawing.Point(39, 242);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(224, 17);
            this.skinLabel5.TabIndex = 5;
            this.skinLabel5.Text = "这里的密码建议成益华软件一样的密码！";
            // 
            // operators
            // 
            this.ClientSize = new System.Drawing.Size(311, 338);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "operators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置员工";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.operators_FormClosed);
            this.Load += new System.EventHandler(this.operators_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public operators()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
        }

        #region 下拉框加载事件

        /// <summary>
        /// 下拉框加载事件
        /// </summary>
        public void InitDropDown()
        {
            cb_oper.DisplayMember = "O_name";
            cb_oper.ValueMember = "O_id";
            cb_oper.DataSource = UserHelper.GetO_id();//员工
            
            cb_station.DisplayMember = "Station_name";
            cb_station.ValueMember = "Station_id";
            cb_station.DataSource = UserHelper.Get_Station_id();//站点

            cb_stock.DisplayMember = "S_name";
            cb_stock.ValueMember = "S_ID";
            cb_stock.DataSource = UserHelper.Get_Stock();//库房

            cb_stand.DisplayMember = "Stand_name";
            cb_stand.ValueMember = "Stand_id";
            cb_stand.DataSource = UserHelper.Get_Stand();//零售台号


            cb_isword.DisplayMember = "项目值";
            cb_isword.ValueMember = "显示值";
            cb_isword.DataSource = UserHelper.Get_y_n();//是或否
        } 
        #endregion

        private void operators_Load(object sender, EventArgs e)
        {
            InitDropDown();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            SAVEUSER();
        }

        public bool SAVEUSER()
        {
            bool restult = false;
            if (cb_oper.SelectedIndex == 0 || cb_station.SelectedIndex == 0  || cb_stand.SelectedIndex==0)//保存检查
            {
                MessagboxUit.ShowTips("不能为空");
                 restult = false;
            }
            else
            {
                UsersInfo u = new UsersInfo();
                u.O_id = this.cb_oper.SelectedValue.ToString();
                u.Is_word = this.cb_isword.SelectedValue.ToString();
                u.O_name = this.cb_oper.Text.ToString();
                u.Station_id = this.cb_station.SelectedValue.ToString();
                u.Stock_id = this.cb_stock.SelectedValue.ToString();
                u.Yh_stand_id = this.cb_stand.SelectedValue.ToString();
                u.Passwd = this.tb_pass.Text.ToString();

                if(UserHelper.SaveUsers(u))
                {
                    MessagboxUit.ShowTips("保存成功！");
                     restult = true;
                }
                else
                {
                    MessagboxUit.ShowError("保存失败！");
                     restult = false;
                }
                
            }
            return restult;
            
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void operators_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            this.Close();

        }
        //TODO:加是否员工有前台改修折扣和改修折扣的权利
    }
}
