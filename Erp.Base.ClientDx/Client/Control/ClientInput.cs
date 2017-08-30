using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using DevExpress.XtraEditors;
using Erp.Base.Entity;
using Erp.Base.Facade;
using System.Data;
using System.Windows.Forms;
namespace Erp.Base.UI
{
    public delegate void SelectedObjectEventHandler(object sender,EventArgs e );
    public class ClientInput:XtraUserControl
    {
        public event SelectedObjectEventHandler ObjectSelectAfter;//对象选择后处理事件
        private TextEdit txtID;
        private IContainer components;
        private ClientsInfo selectedClient = new ClientsInfo();//用户选择的客户信息
        private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");
        private bool readOnly = false;
        private TextButtonControl txtName;
        private string sqlcommand;

        private string c_id = string.Empty;

        public string C_id
        {
            get { return c_id; }
            set
            {
                c_id = value;
                if (!string.IsNullOrEmpty(value))
                {
                    selectedClient = CallerFactory<IClientsService>.Instance.FindByID(value);
                    if (selectedClient != null)
                    {
                        this.txtName.Text = selectedClient.C_department;
                        this.txtID.Text = selectedClient.C_id;
                        if (ObjectSelectAfter != null)
                        {
                            ObjectSelectAfter(selectedClient, new EventArgs());
                        }
                    }
                }
                
            }
        }
        
       
        /// <summary>
        /// 已选择的客户信息
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ClientsInfo SelectedClient
        {
            get { return selectedClient; }
            set { selectedClient = value; }
        }

        /// <summary>
        /// 控件是否为只读
        /// </summary>
        [Description("控件是否为只读")]
        public bool ReadOnly
        {
            get { return readOnly; }
            set 
            {
                this.txtName.Properties.ReadOnly = value;
                readOnly = value;
            }
        }

        public ClientInput()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.txtName = new WHC.Framework.Commons.TextButtonControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.ChineseColumnName = null;
            this.txtName.ColumnName = null;
            this.txtName.Location = new System.Drawing.Point(95, 0);
            this.txtName.Name = "txtName";
            this.txtName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtName.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txtName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 0;
            this.txtName.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            this.txtName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtID_ButtonClick);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(0, 0);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(96, 20);
            this.txtID.TabIndex = 6;
            // 
            // ClientInput
            // 
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Name = "ClientInput";
            this.Size = new System.Drawing.Size(242, 20);
            this.Load += new System.EventHandler(this.ClientInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

       
        /// <summary>
        /// 加载查询模式
        /// </summary>
        private void InitQueryMode()
        {
            string mode = iniFile.IniReadValue(ParentForm.Name, "ClientInput");
            if (!string.IsNullOrWhiteSpace(mode))
            {
                txtName.CurrentOperator = EnumHelper.GetInstance<SqlOperator>(mode);
            }
        }

        private void txtID_QueryModeChanged(object sender, EventArgs e)
        {
            try
            {
                iniFile.IniWriteValue(this.ParentForm.Name, "ClientInput", ((SqlOperator)sender).ToString());
            }
            catch (Exception)
            {
            }
        }

        private void ClientInput_Load(object sender, EventArgs e)
        {

            if (!DesignMode)
            {

                
            }
        }

        /// <summary>
        /// 检索客户
        /// </summary>
        /// <param name="strWhere">检索条件</param>
        public void SeachClient(string strWhere)
        {
           
            if (string.IsNullOrWhiteSpace(strWhere))
                return;
            Cursor = Cursors.WaitCursor;
           DataTable dt = CallerFactory<IClientsService>.Instance.SearchClient(strWhere);
           Cursor = Cursors.Default;
               
                if (dt.Rows.Count > 1) //检索出的客户数量大于1,打开商品选择窗口
                {
                    SelectInfo<SimpleClientsInfo> spi = new SelectInfo<SimpleClientsInfo>();
                    spi.Objectdt = dt;
                    System.Windows.Forms.DialogResult result =spi.ShowDialog();
                   
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        selectedClient = CallerFactory<IClientsService>.Instance.FindByID(spi.SelecedId);
                        this.txtID.Text = selectedClient.C_id;
                        this.c_id = txtID.Text;
                        this.txtName.Text = selectedClient.C_department;
                       
                    }

                    spi.Dispose();
                }
                else if (dt.Rows.Count == 0) 
                {
                    MessageDxUtil.ShowTips("未找到");
                    
                }
                else
                {
                    selectedClient = CallerFactory<IClientsService>.Instance.FindByID(dt.Rows[0]["object_id"].ToString());
                    this.txtID.Text = selectedClient.C_id;
                    this.c_id = txtID.Text;
                    this.txtName.Text = selectedClient.C_department;
                   
                }
            
            if (this.selectedClient != null)
            {
                if (ObjectSelectAfter != null)
                {
                    ObjectSelectAfter(this.selectedClient, new EventArgs());
                }
            }
        }

        private void txtID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                sqlcommand = string.Empty;
                this.txtName.ColumnName = "db_clients.c_department";
                sqlcommand += txtName.Syntax().ToOrSqlSyntax(sqlcommand);
                this.txtName.ColumnName = "db_clients.c_help_input";
                sqlcommand += txtName.Syntax().ToOrSqlSyntax(sqlcommand);
                SeachClient(sqlcommand);
            }

        }

         /// <summary>
        /// 检索所有客户
        /// </summary>
        public void AllSeachClient()
        {
            DataTable dt = CallerFactory<IClientsService>.Instance.SearchClient(null);

            ChoseObject<ClientsInfo> spi = new ChoseObject<ClientsInfo>();
            spi.Objectdt = dt;
            System.Windows.Forms.DialogResult result = spi.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                selectedClient = CallerFactory<IClientsService>.Instance.FindByID(spi.SelecedId);
                this.txtID.Text = selectedClient.C_id;
                this.c_id = txtID.Text;
                this.txtName.Text = selectedClient.C_department;
            }
            spi.Dispose();
            if (dt.Rows.Count > 0)
            {
                if (ObjectSelectAfter != null)
                {
                    ObjectSelectAfter(this.selectedClient, new EventArgs());
                }
            }
           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            AllSeachClient();
        }

        private void txtID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.ReadOnly) 
            {
                return;

            }

            AllSeachClient();
        }
        public void ClearText()
        {
            this.txtID.ResetText();
            this.txtName.ResetText();
            this.selectedClient = null;

        }
      
    }
}
   
