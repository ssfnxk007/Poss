using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Erp.Base.Entity;

namespace Erp.Base.UI
{
    public class FrmSelectMember : BaseForm
    {
        #region 变量定义
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private List<SimpleMemberInfo> displayList = new List<SimpleMemberInfo>();
        private SimpleMemberInfo selectedMember = null;



        #region 属性
        public List<SimpleMemberInfo> DisplayList
        {
            get { return displayList; }
            set
            {
                this.displayList.Clear();
                displayList.AddRange(value);
            }
        }

        /// <summary>
        /// 用户选择的对象
        /// </summary>
        public SimpleMemberInfo SelectedMember
        {
            get { return selectedMember; }
            set { selectedMember = value; }
        }
        #endregion


        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.winGridView1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(829, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winGridView1.EnableEdit = false;
            this.winGridView1.EnableMenu = true;
            this.winGridView1.HaveProduct = false;
            this.winGridView1.Location = new System.Drawing.Point(2, 2);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(825, 446);
            this.winGridView1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSelect);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 450);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(829, 51);
            this.panelControl2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(424, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSelect.Location = new System.Drawing.Point(332, 14);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择(&O)";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmSelectMember
            // 
            this.AcceptButton = this.btnSelect;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(829, 501);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmSelectMember";
            this.Text = "重复对象选择";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSelectMember_FormClosing);
            this.Load += new System.EventHandler(this.FrmSelectMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region 构造方法,窗体加载
        public FrmSelectMember()
        {
            InitializeComponent();
            this.winGridView1.GridView1.DoubleClick += GridView1_DoubleClick;
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            this.btnSelect_Click(this.btnSelect, new EventArgs());
        }

        private void FrmSelectMember_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                InitGridView();
            }
        }
        #endregion

        #region 初始化GRID
        private void InitGridView()
        {
            this.winGridView1.DisplayColumns = "M_id,M_name,M_adress,M_tel,M_type,M_sex,M_birthday,M_email,Card_id,M_weichat,M_mobile,Station_id";

            this.winGridView1.AddColumnAlias("M_id", "会员编码");
            this.winGridView1.AddColumnAlias("M_name", "会员姓名");
            this.winGridView1.AddColumnAlias("M_adress", "地址");
            this.winGridView1.AddColumnAlias("M_tel", "电话");
            this.winGridView1.AddColumnAlias("M_type", "类型");
            this.winGridView1.AddColumnAlias("M_sex", "性别");
            this.winGridView1.AddColumnAlias("M_birthday", "生日");
            this.winGridView1.AddColumnAlias("M_email", "电子邮件");
            this.winGridView1.AddColumnAlias("Card_id", "卡号");
            this.winGridView1.AddColumnAlias("M_weichat", "微信号");
            this.winGridView1.AddColumnAlias("M_mobile", "手机号码");
            this.winGridView1.AddColumnAlias("Station_id", "所属站点");

            this.winGridView1.DataSource = this.displayList;
        }
        #endregion

        #region Closing
        private void FrmSelectMember_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.winGridView1.SaveGridParm();
        }
        #endregion

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.winGridView1.GridView1.RowCount == 0)
            {
                return;
            }
            if (this.winGridView1.GridView1.FocusedRowHandle < 0)
            {
                MessageDxUtil.ShowTips("请选择一行数据！");
                return;
            }
            this.selectedMember = (SimpleMemberInfo)winGridView1.GridView1.GetFocusedRow();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.selectedMember = null;
            this.Close();
        }


    }
}
