using CCWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSS.BLL;
using POSS.Entity;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using DevExpress.Utils;

namespace POSS
{
   public class FromSelectedMember: BaseForm
    {
        private System.Windows.Forms.Panel panel1;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton bt_cel;
        private DevExpress.XtraEditors.SimpleButton bt_ok;

        private List<SimpleMemberInfo> memberlist = new List<SimpleMemberInfo>();//会员信息list

        public  SimpleMemberInfo selected = null;//选择的会员信息
        public string MM_id = string.Empty;//接收传过来的会员ID

     
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_cel = new DevExpress.XtraEditors.SimpleButton();
            this.bt_ok = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.winGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 339);
            this.panel1.TabIndex = 0;
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.EnableEdit = false;
            this.winGridView1.EnableMenu = false;
            this.winGridView1.HaveProduct = false;
            this.winGridView1.Location = new System.Drawing.Point(0, 0);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = false;
            this.winGridView1.ShowEditMenu = false;
            this.winGridView1.ShowExportButton = false;
            this.winGridView1.Size = new System.Drawing.Size(702, 339);
            this.winGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_cel);
            this.panel2.Controls.Add(this.bt_ok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 53);
            this.panel2.TabIndex = 1;
            // 
            // bt_cel
            // 
            this.bt_cel.Location = new System.Drawing.Point(433, 19);
            this.bt_cel.Name = "bt_cel";
            this.bt_cel.Size = new System.Drawing.Size(75, 23);
            this.bt_cel.TabIndex = 0;
            this.bt_cel.Text = "退 出";
            this.bt_cel.Click += new System.EventHandler(this.bt_cel_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(174, 19);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 0;
            this.bt_ok.Text = "确 定";
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // FromSelectedMember
            // 
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromSelectedMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromSelectedMember_FormClosing);
            this.Load += new System.EventHandler(this.FromSelectedMember_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FromSelectedMember_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        public FromSelectedMember()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
            winGridView1.gridControl1.MouseDoubleClick += GridControl1_MouseDoubleClick;
        }

        private void GridControl1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SelectInfo();
        }



        /// <summary>
        /// 显示设置
        /// </summary>
        private void SetWinGridView()
        {
            this.winGridView1.GridView1.PaintStyleName = "UltraFlat";
            this.winGridView1.EnableMenu = false;
            this.winGridView1.BestFitColumnWith = false;
            this.winGridView1.DisplayColumns = "M_id,M_name,M_tel,M_type,M_adress,Card_id,End_date,M_department_song";
            this.winGridView1.AddColumnAlias("M_id", "会员编码");
            this.winGridView1.AddColumnAlias("M_name", "会员名称");
            this.winGridView1.AddColumnAlias("M_tel", "联系电话");
            this.winGridView1.AddColumnAlias("M_type", "会员级别");
            this.winGridView1.AddColumnAlias("M_adress", "微信号");
            this.winGridView1.AddColumnAlias("Card_id", "卡号");
            this.winGridView1.AddColumnAlias("M_department_song", "扩展列");
            this.winGridView1.AddColumnAlias("End_date", "到期日期");
            this.winGridView1.DataSource = memberlist;

        }

        private void FromSelectedMember_Load(object sender, EventArgs e)
        {
            DataScruse();
            SetWinGridView();
        }

        private void FromSelectedMember_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.winGridView1.SaveGridParm();
        }
        private void DataScruse()
        {
           
            this.memberlist.Clear();
            memberlist.AddRange(BLLFactory<Member>.Instance.GetMemberInfo(MM_id.Trim()));
            winGridView1.gridView1.RefreshData();
           
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            SelectInfo();
        }
        private void SelectInfo()
        {
            var info = (SimpleMemberInfo)this.winGridView1.GridView1.GetFocusedRow();
            selected = info;

            if (selected != null)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessagboxUit.ShowWarning("请选择一行数据！");
            }
        }

        private void bt_cel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FromSelectedMember_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                bt_ok_Click(null, null);
            }
        }
    }
}
