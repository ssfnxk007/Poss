using CCWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;
using POSS.Entity;
namespace POSS
{
   public class FromLoveBookCardConsumption: CCSkinMain
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_card_id;
       public SimpleMemberInfo cardinfo =null;
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_card_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "爱书卡卡号：";
            // 
            // tb_card_id
            // 
            this.tb_card_id.Location = new System.Drawing.Point(83, 31);
            this.tb_card_id.Name = "tb_card_id";
            this.tb_card_id.Size = new System.Drawing.Size(200, 21);
            this.tb_card_id.TabIndex = 1;
            this.tb_card_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_card_id_KeyDown);
            // 
            // FromLoveBookCardConsumption
            // 
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(319, 87);
            this.ControlBox = false;
            this.Controls.Add(this.tb_card_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromLoveBookCardConsumption";
            this.Shadow = false;
            this.ShadowColor = System.Drawing.Color.White;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.FromLoveBookCardConsumption_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FromLoveBookCardConsumption_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FromLoveBookCardConsumption()
        {
            InitializeComponent();
        }

      
        private void FromLoveBookCardConsumption_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
        }

        private void FromLoveBookCardConsumption_Load(object sender, EventArgs e)
        {
            this.tb_card_id.Focus();
        }

        private void tb_card_id_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
              if( BLLFactory<Ls_card_surplus>.Instance.IsExistKey("card_id", tb_card_id.Text.Trim()))
                {
                    List<SimpleMemberInfo> smlist = new List<SimpleMemberInfo>();
                    smlist= BLLFactory<Ls_card_surplus>.Instance.GetMemberByCard(this.tb_card_id.Text.Trim());
                    foreach (var item in smlist)
                    {
                        cardinfo = new SimpleMemberInfo();
                        cardinfo = item;
                        this.Close();
                        this.Dispose();
                    }
                }
                else
                {
                    MessagboxUit.ShowError(string.Format("你所查找的:【{0}】不存在或者不是爱书卡会员！",tb_card_id.Text));
                }
                
            }
        }
    }
}
