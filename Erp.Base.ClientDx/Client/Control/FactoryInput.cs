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
    public class FactoryInput : XtraUserControl
    {
        public event SelectedObjectEventHandler ObjectSelectAfter;//对象选择后处理事件
        private FactoryInfo selectedFactory =new FactoryInfo();//用户选择的客户信息
        private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");
        private string sqlcommand;
        private TextButtonControl txtName;
        private TextEdit txtId;
        private IContainer components;

        private string f_id = string.Empty;

        public string F_id
        {
            get { return f_id; }
            set 
            {   
                f_id = value;
                if (!string.IsNullOrEmpty(value)) 
                {
                    selectedFactory = CallerFactory<IFactoryService>.Instance.FindByID(value);
                    if (selectedFactory!=null)
                    {
                        this.txtId.Text = selectedFactory.F_id;
                        this.f_id = this.txtId.Text;
                        this.txtName.Text = selectedFactory.F_department;
                        if (ObjectSelectAfter!=null)
                        {
                            ObjectSelectAfter(selectedFactory, new EventArgs());
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
        public FactoryInfo SelectedFactory
        {
            get { return selectedFactory; }
            set { selectedFactory = value; }
        }
        /// <summary>
        /// 控件是否为只读
        /// </summary>
        [Description("控件是否为只读")]
        public bool ReadOnly
        {
            get
            { 
                return this.txtName.Properties.ReadOnly; 
            }
            set
            {
                this.txtName.Properties.ReadOnly = value;
            }
        }
        /// <summary>
        /// 加载查询模式
        /// </summary>
        private void InitQueryMode()
        {
            string mode = iniFile.IniReadValue(ParentForm.Name, "FactoryInput");
            if (!string.IsNullOrWhiteSpace(mode))
            {
                txtName.CurrentOperator = EnumHelper.GetInstance<SqlOperator>(mode);
            }
        }
        private void txtID_QueryModeChanged(object sender, EventArgs e)
        {
            try
            {
                iniFile.IniWriteValue(this.ParentForm.Name, "FactoryInput", ((SqlOperator)sender).ToString());
            }
            catch (Exception)
            {
            }
        } /// <summary>
        /// 检索货源
        /// </summary>
        /// <param name="strWhere">检索条件</param>
        public void SeachFactory(string strWhere)
        {

            if (string.IsNullOrWhiteSpace(strWhere))
                return;
            Cursor = Cursors.WaitCursor;
            DataTable dt = CallerFactory<IFactoryService>.Instance.SearchFactory(strWhere);
            Cursor = Cursors.Default;

            if (dt.Rows.Count > 1) //检索出的客户数量大于1,打开商品选择窗口
            {
                SelectInfo<SimpleFactory> spi = new SelectInfo<SimpleFactory>();
                spi.Objectdt = dt;
                System.Windows.Forms.DialogResult result = spi.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    selectedFactory = CallerFactory<IFactoryService>.Instance.FindByID(spi.SelecedId);
                    this.txtId.Text = selectedFactory.F_id;
                    this.f_id = this.txtId.Text;
                    this.txtName.Text = selectedFactory.F_department;

                }

                spi.Dispose();
            }
            else if (dt.Rows.Count == 0)
            {
                MessageDxUtil.ShowTips("未找到");
                this.selectedFactory = null;
                this.F_id=string.Empty;

            }
            else
            {
                selectedFactory = CallerFactory<IFactoryService>.Instance.FindByID(dt.Rows[0]["object_id"].ToString());
                this.txtId.Text = selectedFactory.F_id;
                this.f_id = txtId.Text;
                this.txtName.Text = selectedFactory.F_department;

            }

            if (this.selectedFactory != null && ObjectSelectAfter != null)
            {

                ObjectSelectAfter(this.selectedFactory, new EventArgs());

            }
        }

        private void txtID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                sqlcommand = string.Empty;
                this.txtName.ColumnName = "db_factory.f_department";
                sqlcommand += txtName.Syntax().ToOrSqlSyntax(sqlcommand);
                this.txtName.ColumnName = "db_factory.f_help_input";
                sqlcommand += txtName.Syntax().ToOrSqlSyntax(sqlcommand);
                SeachFactory(sqlcommand);
            }

        }
        /// <summary>
        /// 检索所有客户
        /// </summary>
        public void AllSeachFactory()
        {
            DataTable dt = CallerFactory<IFactoryService>.Instance.SearchFactory(null);

            ChoseObject<FactoryInfo> spi = new ChoseObject<FactoryInfo>();
            spi.Objectdt = dt;
            System.Windows.Forms.DialogResult result = spi.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                selectedFactory = CallerFactory<IFactoryService>.Instance.FindByID(spi.SelecedId);
                this.txtId.Text = selectedFactory.F_id;
                this.f_id = txtId.Text;
                this.txtName.Text = selectedFactory.F_department;
                if (this.ObjectSelectAfter != null && this.selectedFactory!=null)
                {
                    ObjectSelectAfter(this.selectedFactory, new EventArgs());
                }
             
            }
            spi.Dispose();
        }


        #region InitializeComponent
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new WHC.Framework.Commons.TextButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtId.EditValue = "";
            this.txtId.Location = new System.Drawing.Point(0, 0);
            this.txtId.Name = "txtId";
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(114, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.ChineseColumnName = null;
            this.txtName.ColumnName = null;
            this.txtName.Location = new System.Drawing.Point(113, 0);
            this.txtName.Name = "txtName";
            this.txtName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtName.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txtName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 1;
            this.txtName.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            this.txtName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtName_ButtonClick);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // FactoryInput
            // 
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "FactoryInput";
            this.Size = new System.Drawing.Size(298, 20);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        } 
        #endregion

        public FactoryInput()
        {
            InitializeComponent();
            this.ForeColorChanged += FactoryInput_ForeColorChanged;
        }

       private void FactoryInput_ForeColorChanged(object sender, EventArgs e)
        {
            this.txtName.ForeColor = this.ForeColor;
        }

        private void txtName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtName.Properties.ReadOnly) return;
            AllSeachFactory();
        }
        public void ClearText()
        {
            this.txtName.ResetText();
            this.txtId.ResetText();
            this.selectedFactory = null;
        }
     
    }
}
