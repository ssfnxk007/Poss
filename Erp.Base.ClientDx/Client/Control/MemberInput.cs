using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using Erp.Base.Entity;
using Erp.Base.Facade;
using WHC.Framework.ControlUtil.Facade;
using System.ComponentModel;
using WHC.Framework.Commons;
using System.Windows.Forms;
using System.Data;

namespace Erp.Base.UI
{

    public class MemberInput : XtraUserControl
    {
        public event SelectedObjectEventHandler MemberSelectAfter;

        #region 变量定义
        private TextEdit txtM_id;
        private WHC.Framework.Commons.TextButtonControl txtM_name;
        private System.ComponentModel.IContainer components;
        private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");
        private string m_id;
        SimpleMemberInfo selectedMember = new SimpleMemberInfo();
        private string sqlcommand = string.Empty;   
       


        #endregion

        #region 属性
        /// <summary>
        /// 当前会员对象
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SimpleMemberInfo SelectedMember
        {
            get
            {
                return selectedMember;
            }
            set
            {
                selectedMember = value;
            }
        }


        /// <summary>
        /// 控件是否为只读
        /// </summary>
        [Description("控件是否为只读")]
        public bool ReadOnly
        {
            get
            {
                return this.txtM_name.Properties.ReadOnly;
            }
            set
            {
                this.txtM_name.Properties.ReadOnly = value;
            }
        }

        /// <summary>
        /// 当前会员编码
        /// </summary>
        public string M_id
        {
            get
            {
                return m_id;
            }
            set
            {
                if (!DesignMode)
                {
                    if (string.IsNullOrEmpty(value)) /*会员编码为空，将对象置空*/
                    {
                        this.ClearText();
                    }
                    else
                    {
                        this.selectedMember = CallerFactory<IMemberService>.Instance.FindSimpleInfoByID(value);
                        if (this.selectedMember != null)
                        {
                            this.txtM_id.Text = selectedMember.M_id;
                            this.txtM_name.Text = selectedMember.M_name;
                        }
                        else
                        {
                            this.txtM_id.Text = string.Empty;
                            this.txtM_name.Text = string.Empty;
                        }
                    }
                }
                m_id = value;
            }
        }

        protected new bool DesignMode
        {
            get
            {
                bool returnFlag = false;
#if DEBUG
                if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                {
                    returnFlag = true;
                }
                else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToUpper().Equals("DEVENV"))
                {
                    returnFlag = true;
                }
#endif
                return returnFlag;
            }
        }
        #endregion

        #region 构造方法
        public MemberInput()
        {
            InitializeComponent();
        }
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtM_id = new DevExpress.XtraEditors.TextEdit();
            this.txtM_name = new WHC.Framework.Commons.TextButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtM_id
            // 
            this.txtM_id.EditValue = "";
            this.txtM_id.Location = new System.Drawing.Point(0, 0);
            this.txtM_id.Name = "txtM_id";
            this.txtM_id.Properties.ReadOnly = true;
            this.txtM_id.Size = new System.Drawing.Size(142, 20);
            this.txtM_id.TabIndex = 2;
            // 
            // txtM_name
            // 
            this.txtM_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtM_name.ChineseColumnName = null;
            this.txtM_name.ColumnName = null;
            this.txtM_name.Location = new System.Drawing.Point(143, 0);
            this.txtM_name.Name = "txtM_name";
            this.txtM_name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtM_name.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtM_name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtM_name.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txtM_name.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtM_name.Size = new System.Drawing.Size(134, 20);
            this.txtM_name.TabIndex = 3;
            this.txtM_name.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            this.txtM_name.QueryModeChanged += new WHC.Framework.Commons.QueryModeChangedEventHandler(this.txtM_name_QueryModeChanged);
            this.txtM_name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtM_name_ButtonClick);
            this.txtM_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtM_name_KeyDown);
            // 
            // MemberInput
            // 
            this.Controls.Add(this.txtM_name);
            this.Controls.Add(this.txtM_id);
            this.Name = "MemberInput";
            this.Size = new System.Drawing.Size(277, 20);
            ((System.ComponentModel.ISupportInitialize)(this.txtM_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_name.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region 键盘处理事件
        private void txtM_name_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                sqlcommand = string.Empty;
                this.txtM_name.ColumnName = "db_member.card_id";
                sqlcommand += txtM_name.Syntax().ToOrSqlSyntax(sqlcommand);
                this.txtM_name.ColumnName = "db_member.m_help_input";
                sqlcommand += txtM_name.Syntax().ToOrSqlSyntax(sqlcommand);
                this.txtM_name.ColumnName = "db_member.m_name";
                sqlcommand += txtM_name.Syntax().ToOrSqlSyntax(sqlcommand);
                this.txtM_name.ColumnName = "db_member.m_email";
                sqlcommand += txtM_name.Syntax().ToOrSqlSyntax(sqlcommand);
                this.txtM_name.ColumnName = "db_member.m_mobile";
                sqlcommand += txtM_name.Syntax().ToOrSqlSyntax(sqlcommand);
                this.txtM_name.ColumnName = "db_member.m_weichat";
                sqlcommand += txtM_name.Syntax().ToOrSqlSyntax(sqlcommand);
                SearchMember(sqlcommand);
            }

        } 
        #endregion

        #region 查询模式改变事件 
        /// <summary>
        /// 加载查询模式
        /// </summary>
        private void InitQueryMode()
        {
            string mode = iniFile.IniReadValue(ParentForm.Name, "MemberInput");
            if (!string.IsNullOrWhiteSpace(mode))
            {
                this.txtM_name.CurrentOperator = EnumHelper.GetInstance<SqlOperator>(mode);
            }
        }

        private void txtM_name_QueryModeChanged(object sender, EventArgs e)
        {
            try
            {
                iniFile.IniWriteValue(this.ParentForm.Name, "MemberInput", ((SqlOperator)sender).ToString());
            }
            catch (Exception)
            {
            }
        } 
        #endregion

        #region 其它方法
        /// <summary>
        /// 清空数据
        /// </summary>
        public void ClearText()
        {
            this.txtM_name.Text = string.Empty;
            this.txtM_id.Text = string.Empty;
            this.selectedMember = null;
        }

        private void SetValue(SimpleMemberInfo info)
        {
            if (info == null)
            {
                this.selectedMember = null;
                this.m_id = string.Empty;
                this.txtM_id.Text = string.Empty;
                this.txtM_name.Text = string.Empty;
            }
            else
            {
                this.selectedMember = info;
                this.m_id = info.M_id;
                this.txtM_id.Text = info.M_id;
                this.txtM_name.Text = info.M_name;
                if (this.selectedMember != null && this.MemberSelectAfter != null)
                {

                    MemberSelectAfter(this.selectedMember, new EventArgs());

                }
            }

        }
        
        #endregion

        #region 检索指定数据
        private void SearchMember(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return;
            }
            else if (searchText == "ALL")
            {
                searchText = string.Empty;
            }

            Cursor = Cursors.WaitCursor;
            List<SimpleMemberInfo> searchList = CallerFactory<IMemberService>.Instance.SearchMember(searchText);
            Cursor = Cursors.Default;

            if (searchList.Count > 1) //检索出的会员数量大于1
            {
                FrmSelectMember fsm = new FrmSelectMember();
                fsm.DisplayList = searchList;
                fsm.ShowDialog();
                if (fsm.SelectedMember != null)
                {
                    SetValue(fsm.SelectedMember);
                }
            }
            else if (searchList.Count == 0)
            {
                MessageDxUtil.ShowTips("未找到");
                SetValue(null);
            }
            else
            {
                SetValue(searchList[0]);
            }
        } 
        #endregion
        
        #region 检索全部数据

        private void txtM_name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.ReadOnly) return;
            this.SearchMember("ALL");
        }
        
        #endregion
      
    }
}
