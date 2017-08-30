using POSS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;
using System.Drawing;

namespace POSS
{
   public class Member_TypeFrom:BaseDock
    {
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;

        public List<ProductPicerQuery> CheckProductPrice;
        public List<Member_typeInfo> clinetjblist = null;
        public List<Member_TypeQueryInfo> UpdateMemberList = null;

        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(372, 123);
            this.panelControl1.TabIndex = 0;
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.EnableEdit = true;
            this.winGridView1.EnableMenu = true;
            this.winGridView1.HaveProduct = false;
            this.winGridView1.Location = new System.Drawing.Point(2, 2);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = false;
            this.winGridView1.ShowBianSe = true;
            this.winGridView1.ShowBianSe2 = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = false;
            this.winGridView1.ShowEditMenu = false;
            this.winGridView1.ShowExportButton = false;
            this.winGridView1.Size = new System.Drawing.Size(368, 119);
            this.winGridView1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 123);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(372, 45);
            this.panelControl2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(229, 17);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "取 消";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(105, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "确 定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Member_TypeFrom
            // 
            this.ClientSize = new System.Drawing.Size(372, 168);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Member_TypeFrom";
            this.Text = "一书多会员折扣设置";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public Member_TypeFrom()
        {
            InitializeComponent();
            CheckProductPrice = new List<ProductPicerQuery>();
            this.Load += Member_TypeFrom_Load;
            this.winGridView1.ShowBianSe = false;
            this.winGridView1.ShowBianSe2 = false;
            this.winGridView1.GridView1.CellValueChanged += GridView1_CellValueChanged;
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "M_type_dic")
            {
                if ((decimal)e.Value <= 1 || (decimal)e.Value >=0 )
                {
                  // MessagboxUit.ShowTips( e.RowHandle.ToString() + "----->"+e.Value.ToString());
                    UpdateMemberList[e.RowHandle.ToString().ToInt32()].M_type_dic =(decimal) e.Value;
                   
                }
            }
        }

        private void Member_TypeFrom_Load(object sender, EventArgs e)
        {
            SetMember_typeQuery();
            SetDisplayColumn();
            AddGridViewReadOnly();
            AddColumnAlias();
            SetDataSource();
        }
        private void SetDisplayColumn()
        {
            this.winGridView1.DisplayColumns = "M_type,M_type_dic,M_type_name";
        }
        /// <summary>
        /// 获取会员级别表
        /// </summary>
        private void SetMember_typeQuery()
        {
            clinetjblist = new List<Member_typeInfo>();

            clinetjblist= BLLFactory<Product_discount_clientjb>.Instance.GetMember_type();
            UpdateMemberList = new List<Member_TypeQueryInfo>();
            Member_TypeQueryInfo info=null;
            foreach (var item in clinetjblist)
            {
                info = new Member_TypeQueryInfo();
                info.M_type = item.M_type;
                info.M_type_dic = 0.00m;
                info.M_type_name = item.M_type_name;
                UpdateMemberList.Add(info);
            }

        }
        private void AddColumnAlias()
        {
            winGridView1.AddColumnAlias("M_type", "级别编号");
            winGridView1.AddColumnAlias("M_type_dic", "级别折扣");
            winGridView1.AddColumnAlias("M_type_name", "级别名称");
           
           
        }
        private void AddGridViewReadOnly()
        {
            this.winGridView1.ReadOnlyList.Add("M_type");
            this.winGridView1.ReadOnlyList.Add("M_type_name");

        }
        private void SetDataSource()
        {
            this.winGridView1.DataSource = UpdateMemberList;

            SetDisplayFormat();
        }
        private void SetDisplayFormat()
        {

            winGridView1.GridView1.Columns["M_type_dic"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["M_type_dic"].DisplayFormat.FormatString = "p2";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (var MemberInfo in UpdateMemberList)
            {
                foreach (var item in CheckProductPrice)
                {
                    BLLFactory<Product_discount_clientjb>.Instance.update_M_typeToProduct_clentjt(item.CH_id, MemberInfo.M_type_dic, MemberInfo.M_type);
                }
            }
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (var item in CheckProductPrice)
            {
                BLLFactory<Product_discount_clientjb>.Instance.Delete_M_typeToProduct_clentjt(item.CH_id);
                BLLFactory<Product_discount_clientjb>.Instance.Delete_Product_h_bak2(item.CH_id);
            }
            this.Close();
        }
    }
}
