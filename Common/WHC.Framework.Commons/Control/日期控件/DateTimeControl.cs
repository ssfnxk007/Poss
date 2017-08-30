using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Design;
using System.ComponentModel;

namespace WHC.Framework.Commons
{
    public delegate void DateTimeChangedHandler(object sender,EventArgs e);


   /// <summary>
   /// 日期条件控件
   /// </summary>
    public class DateTimeControl : UserControl
    {
        #region 变量定义
        public event DateTimeChangedHandler DateTimeChanged;
        private SearchCondition seach = null;
        private bool AutoMem = false;
        private string MemType = "Today";

        private string iniFile = DirectoryUtil.GetCurrentDirectory() + @"\Values.ini";
        private INIFileUtil iniHelper = null;
        private DateTime _StartDate = Convert.ToDateTime("1900-01-01");
        private string _ColumnName;
        private ContextMenuStrip contextMenuStrip1;
        private IContainer components;
        private ToolStripMenuItem 昨天ToolStripMenuItem;
        private ToolStripMenuItem 今天ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 本周ToolStripMenuItem;
        private ToolStripMenuItem 本月ToolStripMenuItem;
        private ToolStripMenuItem 本年ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem 近一周ToolStripMenuItem;
        private ToolStripMenuItem 近一月ToolStripMenuItem;
        private ToolStripMenuItem 近一年ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem 上周ToolStripMenuItem;
        private ToolStripMenuItem 上月ToolStripMenuItem;
        private ToolStripMenuItem 上年ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuItemAutoMember;

      
        #endregion

        #region 属性
        /// <summary>
        /// 开始日期
        /// </summary> 
        [Description("选择的开始日期")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set 
            { 
                _StartDate = value;
                if (value!=null)
                {
                    DisplayDateTime(); 
                }
            }
        }
        private DateTime _EndDate = Convert.ToDateTime("1900-01-01");
        private DevExpress.XtraEditors.ButtonEdit textEdit1;
        /// <summary>
        /// 结束日期
        /// </summary>
        [Description("选择的结束日期")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
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

        public DateTime EndDate
        {
            get { return _EndDate; }
            set 
            {
                _EndDate = value;
                if (value != null)
                {
                    DisplayDateTime();
                }
            }
        }
      
        

       
        /// <summary>
        /// 字段名称
        /// </summary>
        [Description("字段的名称")]
        public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }
        private string _ChineseColumnName;
        /// <summary>
        /// 字段中文名称
        /// </summary>
        [Description("字段的中文名称")]
        public string ChineseColumnName
        {
            get { return _ChineseColumnName; }
            set { _ChineseColumnName = value; }
        }

        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.昨天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.今天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.本周ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本年ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.近一周ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.近一月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.近一年ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.上周ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上年ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAutoMember = new System.Windows.Forms.ToolStripMenuItem();
            this.textEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.昨天ToolStripMenuItem,
            this.今天ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.本周ToolStripMenuItem,
            this.本月ToolStripMenuItem,
            this.本年ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.近一周ToolStripMenuItem,
            this.近一月ToolStripMenuItem,
            this.近一年ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.上周ToolStripMenuItem,
            this.上月ToolStripMenuItem,
            this.上年ToolStripMenuItem,
            this.toolStripSeparator1,
            this.MenuItemAutoMember});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 292);
            // 
            // 昨天ToolStripMenuItem
            // 
            this.昨天ToolStripMenuItem.Name = "昨天ToolStripMenuItem";
            this.昨天ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.昨天ToolStripMenuItem.Text = "昨天";
            // 
            // 今天ToolStripMenuItem
            // 
            this.今天ToolStripMenuItem.Name = "今天ToolStripMenuItem";
            this.今天ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.今天ToolStripMenuItem.Text = "今天";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // 本周ToolStripMenuItem
            // 
            this.本周ToolStripMenuItem.Name = "本周ToolStripMenuItem";
            this.本周ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.本周ToolStripMenuItem.Text = "本周";
            // 
            // 本月ToolStripMenuItem
            // 
            this.本月ToolStripMenuItem.Name = "本月ToolStripMenuItem";
            this.本月ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.本月ToolStripMenuItem.Text = "本月";
            // 
            // 本年ToolStripMenuItem
            // 
            this.本年ToolStripMenuItem.Name = "本年ToolStripMenuItem";
            this.本年ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.本年ToolStripMenuItem.Text = "本年";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // 近一周ToolStripMenuItem
            // 
            this.近一周ToolStripMenuItem.Name = "近一周ToolStripMenuItem";
            this.近一周ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.近一周ToolStripMenuItem.Text = "近一周";
            // 
            // 近一月ToolStripMenuItem
            // 
            this.近一月ToolStripMenuItem.Name = "近一月ToolStripMenuItem";
            this.近一月ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.近一月ToolStripMenuItem.Text = "近一月";
            // 
            // 近一年ToolStripMenuItem
            // 
            this.近一年ToolStripMenuItem.Name = "近一年ToolStripMenuItem";
            this.近一年ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.近一年ToolStripMenuItem.Text = "近一年";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 6);
            // 
            // 上周ToolStripMenuItem
            // 
            this.上周ToolStripMenuItem.Name = "上周ToolStripMenuItem";
            this.上周ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.上周ToolStripMenuItem.Text = "上周";
            // 
            // 上月ToolStripMenuItem
            // 
            this.上月ToolStripMenuItem.Name = "上月ToolStripMenuItem";
            this.上月ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.上月ToolStripMenuItem.Text = "上月";
            // 
            // 上年ToolStripMenuItem
            // 
            this.上年ToolStripMenuItem.Name = "上年ToolStripMenuItem";
            this.上年ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.上年ToolStripMenuItem.Text = "上年";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // MenuItemAutoMember
            // 
            this.MenuItemAutoMember.Name = "MenuItemAutoMember";
            this.MenuItemAutoMember.Size = new System.Drawing.Size(124, 22);
            this.MenuItemAutoMember.Text = "自动记忆";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(211, 20);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSelect_Click);
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // DateTimeControl
            // 
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textEdit1);
            this.Name = "DateTimeControl";
            this.Size = new System.Drawing.Size(211, 20);
            this.Load += new System.EventHandler(this.DateTimeControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        } 
        #endregion

        #region 构造方法，加载事件
        public DateTimeControl()
        {
            InitializeComponent();
            this.今天ToolStripMenuItem.Click += 今天ToolStripMenuItem_Click;
            this.昨天ToolStripMenuItem.Click += 昨天ToolStripMenuItem_Click;
            this.上周ToolStripMenuItem.Click += 上周ToolStripMenuItem_Click;
            this.上月ToolStripMenuItem.Click += 上月ToolStripMenuItem_Click;
            this.上年ToolStripMenuItem.Click += 上年ToolStripMenuItem_Click;
            this.近一周ToolStripMenuItem.Click += 近一周ToolStripMenuItem_Click;
            this.近一月ToolStripMenuItem.Click += 近一月ToolStripMenuItem_Click;
            this.近一年ToolStripMenuItem.Click += 近一年ToolStripMenuItem_Click;
            this.本周ToolStripMenuItem.Click += 本周ToolStripMenuItem_Click;
            this.本月ToolStripMenuItem.Click += 本月ToolStripMenuItem_Click;
            this.本年ToolStripMenuItem.Click += 本年ToolStripMenuItem_Click;
            this.contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            this.MenuItemAutoMember.Click += MenuItemAutoMember_Click;

            if (!DesignMode)
            {
                this.seach = new SearchCondition();
                iniHelper = new INIFileUtil(iniFile);
            }
        }

        //控件Load事件
        private void DateTimeControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                string value = iniHelper.IniReadValue(this.ParentForm.Name, this.Name);
                if ((value != "False"))
                {
                    this.AutoMem = true;
                    string[] s = value.Split('|');
                    try
                    {
                        this.MemType = s[1];
                    }
                    catch (Exception)
                    {
                        this.MemType = "Today";
                    }
                    switch (this.MemType)
                    {
                        case "Today":
                            this.今天ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "YesterDay":
                            this.昨天ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "NearWeek":
                            this.近一周ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "NearYear":
                            this.近一年ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "NearMonth":
                            this.近一月ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "LastWeek":
                            this.上周ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "LastMonth":
                            this.上月ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "LastYear":
                            this.上年ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "ThisMonth":
                            this.本月ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "ThisWeek":
                            this.本周ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        case "ThisYear":
                            this.本年ToolStripMenuItem_Click(this, new EventArgs());
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    this.AutoMem = false;
                }
                if (_StartDate == null && _EndDate == null)
                {
                    this._StartDate = DateTime.Parse("1900-01-01");
                    this._EndDate = DateTime.Parse("1900-01-01");
                }
                DisplayDateTime();
            }
        } 
        #endregion

        #region 其它事件

        private void btnSelect_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataTimeSelect datatimeslect = new DataTimeSelect();
            if (IsNullorDefault(this._StartDate, this._EndDate))  //
            {
                datatimeslect.SelectedStartDate = this._StartDate;
                datatimeslect.SelectedEndDate = this._EndDate;
            }
            DialogResult result = datatimeslect.ShowDialog();
            if (result == DialogResult.OK)
            {
                this._StartDate = datatimeslect.SelectedStartDate;
                this._EndDate = datatimeslect.SelectedEndDate;
                DisplayDateTime();
            }
            else if (result == DialogResult.Cancel)
            {

            }
            else if (result == DialogResult.Abort)
            {
                this._StartDate = DateTime.Parse("1900-01-01");
                this._EndDate = DateTime.Parse("1900-01-01");
                this.textEdit1.Text = _StartDate.ToString("yyyy.MM.dd") + "-" + _EndDate.ToString("yyyy.MM.dd");
            }
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (AutoMem)
            {
                iniHelper.IniWriteValue(this.ParentForm == null ? this.Parent.Name : this.ParentForm.Name, this.Name, string.Format("{0}|{1}", Boolean.TrueString, MemType));
            }
            else
            {
                iniHelper.IniWriteValue(this.ParentForm ==null ? this.Parent.Name :this.ParentForm.Name, this.Name, Boolean.FalseString);
            }

        }
        
        #endregion

        #region 其它方法


        private bool IsNullorDefault(DateTime d1, DateTime d2)
        {
            if (d1 == DateTime.Parse("1900-01-01") && d2 == DateTime.Parse("1900-01-01"))
                return false;
            else
                return true;
        }
        private void DisplayDateTime()
        {
            if (!DesignMode)
            {

                this.textEdit1.Text = _StartDate.ToString("yyyy.MM.dd") + "-" + _EndDate.ToString("yyyy.MM.dd");
                if (DateTimeChanged != null)
                {
                    DateTimeChanged(this, new EventArgs());
                }
                
            }
        }

        /// <summary>
        /// 返回语法文本
        /// </summary>
        public string Syntax()
        {
            string result = string.Empty;
            if (this.textEdit1.Text != "1900.01.01-1900.01.01")
            {
                seach.ConditionTable.Clear();
                seach.AddCondition(this._ColumnName, this._ChineseColumnName, string.Format("{0}", this._EndDate.ToString()), SqlOperator.LessThanOrEqual);
                seach.AddCondition(this._ColumnName, this._ChineseColumnName, string.Format("{0}", this._StartDate.ToString()), SqlOperator.MoreThanOrEqual);
                result = seach.BuildConditionSqlNoWhere(DatabaseType.SqlServer);
            }
            return result;

        }
        /// <summary>
        /// 返回语法中文文本
        /// </summary>
        public string ChineseSyntax()
        {

            string result = string.Empty;
            if (this.textEdit1.Text != "1900.01.01-1900.01.01")
            {
                result = seach.BuildConditionDescribe();
            }
            return result;

        }
        /// <summary>
        /// 清空条件
        /// </summary>
        public void Clear()
        {
            this.textEdit1.Text = "1900.01.01-1900.01.01";
            this.seach.ConditionTable.Clear();
        } 
        #endregion

        #region 右键菜单事件

        private void MenuItemAutoMember_Click(object sender, EventArgs e)
        {
            if (this.AutoMem)
            {
                AutoMem = false;
                iniHelper.IniWriteValue(this.ParentForm.Name, this.Name, Boolean.FalseString);
            }
            else
            {
                AutoMem = true;
                iniHelper.IniWriteValue(this.ParentForm.Name, this.Name, string.Format("{0}|{1}", Boolean.TrueString, MemType));
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.MenuItemAutoMember.Checked = this.AutoMem;
        }


        private void 今天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.Today();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "Today";
            DisplayDateTime();

        }


        private void 昨天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.YesterDay();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "YesterDay";
            DisplayDateTime();
        }

        private void 近一周ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.NearWeek();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "NearWeek";
            DisplayDateTime();


        }

        private void 近一年ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.NearYear();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "NearYear";
            DisplayDateTime();

        }

        private void 近一月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.NearMonth();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "NearMonth";
            DisplayDateTime();

        }

        private void 上周ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.LastWeek();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "LastWeek";
            DisplayDateTime();

        }

        private void 本月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.ThisMonth();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "ThisMonth";
            DisplayDateTime();


        }

        private void 本周ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.ThisWeek();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "ThisWeek";
            DisplayDateTime();

        }

        private void 上月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.LastMonth();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "LastMonth";
            DisplayDateTime();

        }

        private void 本年ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.ThisYear();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "ThisYear";
            DisplayDateTime();

        }

        private void 上年ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeValues v = DateTimeHelper.LastYear();
            this._StartDate = v.StartDateTime;
            this._EndDate = v.EndDateTime;
            this.MemType = "LastYear";
            DisplayDateTime();

        }
        
        #endregion

      }
}
