using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;


namespace Erp.Base.UI
{
    public class BaseDockQuery : BaseDock
    {
        #region 变量定义
        private string sqlWhere = string.Empty;
        protected string PKey = string.Empty;
        public string SqlWhere
        {
            get
            {

                return sqlWhere;
            }
        }
        private string sqlWhereDescribe = string.Empty;
        protected DevExpress.XtraEditors.PanelControl PanelButton;
        protected DevExpress.XtraEditors.SplitterControl splitterControl1;
        protected DevExpress.XtraEditors.PanelControl PanelCondition;
        protected DevExpress.XtraEditors.PanelControl PanelDisplayCondition;
        protected DevExpress.XtraEditors.SimpleButton btnExit;
        protected DevExpress.XtraEditors.SimpleButton btnAdd;
        protected DevExpress.XtraEditors.SimpleButton btnExport;
        protected DevExpress.XtraEditors.SimpleButton btnPrint;
        protected DevExpress.XtraEditors.SimpleButton btnReset;
        protected DevExpress.XtraEditors.SimpleButton btnQuery;
        public DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl3;
        public Label LabelCondition;
        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;

        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.PanelButton = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.PanelCondition = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl3 = new DevExpress.XtraEditors.SplitterControl();
            this.PanelDisplayCondition = new DevExpress.XtraEditors.PanelControl();
            this.LabelCondition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButton)).BeginInit();
            this.PanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelDisplayCondition)).BeginInit();
            this.PanelDisplayCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.PanelButton);
            this.splitContainerControl1.Panel1.Controls.Add(this.splitterControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.PanelCondition);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.splitterControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.PanelDisplayCondition);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(789, 375);
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.btnExit);
            this.PanelButton.Controls.Add(this.btnAdd);
            this.PanelButton.Controls.Add(this.btnExport);
            this.PanelButton.Controls.Add(this.btnPrint);
            this.PanelButton.Controls.Add(this.btnReset);
            this.PanelButton.Controls.Add(this.btnQuery);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelButton.Location = new System.Drawing.Point(531, 0);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(258, 100);
            this.PanelButton.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(87, 69);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "关闭(&C)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增(&A)";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(87, 42);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "输出(&E)";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(87, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(6, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(526, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 100);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // PanelCondition
            // 
            this.PanelCondition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelCondition.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelCondition.Location = new System.Drawing.Point(0, 0);
            this.PanelCondition.Name = "PanelCondition";
            this.PanelCondition.Size = new System.Drawing.Size(526, 100);
            this.PanelCondition.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(789, 225);
            this.panelControl1.TabIndex = 3;
            // 
            // splitterControl3
            // 
            this.splitterControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl3.Location = new System.Drawing.Point(0, 40);
            this.splitterControl3.Name = "splitterControl3";
            this.splitterControl3.Size = new System.Drawing.Size(789, 5);
            this.splitterControl3.TabIndex = 4;
            this.splitterControl3.TabStop = false;
            // 
            // PanelDisplayCondition
            // 
            this.PanelDisplayCondition.Controls.Add(this.LabelCondition);
            this.PanelDisplayCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDisplayCondition.Location = new System.Drawing.Point(0, 0);
            this.PanelDisplayCondition.Margin = new System.Windows.Forms.Padding(5);
            this.PanelDisplayCondition.Name = "PanelDisplayCondition";
            this.PanelDisplayCondition.Size = new System.Drawing.Size(789, 40);
            this.PanelDisplayCondition.TabIndex = 1;
            // 
            // LabelCondition
            // 
            this.LabelCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCondition.Location = new System.Drawing.Point(2, 2);
            this.LabelCondition.Name = "LabelCondition";
            this.LabelCondition.Size = new System.Drawing.Size(785, 36);
            this.LabelCondition.TabIndex = 0;
            this.LabelCondition.Text = "条件:";
            // 
            // BaseDockQuery
            // 
            this.ClientSize = new System.Drawing.Size(789, 375);
            this.Controls.Add(this.splitContainerControl1);
            this.KeyPreview = true;
            this.Name = "BaseDockQuery";
            this.Text = "BaseDockQuery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseDockQuery_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButton)).EndInit();
            this.PanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelDisplayCondition)).EndInit();
            this.PanelDisplayCondition.ResumeLayout(false);
            this.ResumeLayout(false);

        } 
        #endregion

        #region 构造方法
        public BaseDockQuery()
        {
            InitializeComponent();
            this.Resize += BaseDockQuery_Resize;

        }


        #endregion

        #region Resize
        private void BaseDockQuery_Resize(object sender, EventArgs e)
        {
            try
            {
                this.PanelCondition.Width = Convert.ToInt32(this.Width * 0.7);
                this.PanelDisplayCondition.Width = this.Width;
            }
            catch (Exception ex)
            {
                LogTextHelper.Error(ex);
                MessageDxUtil.ShowError(ex.Message);
            }
        }

        #endregion

        #region BindData
        public virtual void BindData()
        {

        } 
        #endregion
        
        #region 初始化查询
        private void InitQuery()
        {
            this.sqlWhere = string.Empty;
            this.sqlWhereDescribe = string.Empty;
            this.LabelCondition.Text = string.Empty;
            GetConditionSql(this.PanelCondition);
            GetConditionDescribe(this.PanelCondition);
            this.LabelCondition.Text = "条件:" + sqlWhereDescribe.TrimStart();
        } 
        #endregion

        #region 获取查询条件
        /// <summary>
        /// 获取用户输入的条件
        /// </summary>
        private void GetConditionSql(Control control)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].HasChildren)
                {
                    GetConditionSql(control.Controls[i]);
                }
                if (control.Controls[i].GetType().Name == "TextBoxControl")
                {
                    sb.Append(((TextBoxControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "NumTextBoxControl")
                {
                   // sb.Append(((NumTextBoxControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "DateTimeControl")
                {
                   // sb.Append(((DateTimeControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "ComboBoxControl")
                {
                  //  sb.Append(((ComboBoxControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "YesOrNoControl")
                {
                  //  sb.Append(((YesOrNoControl)control.Controls[i]).Syntax().ToAndSqlSyntax(sb.ToString()));
                }
            }
            sqlWhere += sb.ToString();
        }

        #endregion

        #region 获取条件查询描述

        private void GetConditionDescribe(Control control)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].HasChildren)
                {
                    GetConditionDescribe(control.Controls[i]);
                }
                if (control.Controls[i].GetType().Name == "TextBoxControl")
                {
                    sb.Append(((TextBoxControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "NumTextBoxControl")
                {
                   // sb.Append(((NumTextBoxControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "DateTimeControl")
                {
                    //sb.Append(((DateTimeControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "ComboBoxControl")
                {
                   // sb.Append(((ComboBoxControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
                else if (control.Controls[i].GetType().Name == "YesOrNoControl")
                {
                   // sb.Append(((YesOrNoControl)control.Controls[i]).ChineseSyntax().ToSqlSyntaxDescribe(sb.ToString()));
                }
            }
            this.sqlWhereDescribe += sb.ToString();
        }


        #endregion

        #region 重置条件

        /// <summary>
        /// 条件重置
        /// </summary>
        /// <param name="control"></param>
        private void Reset(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].HasChildren)
                {
                    Reset(control.Controls[i]);
                }
                if (control.Controls[i].GetType().Name == "TextBoxControl")
                {
                    ((TextBoxControl)control.Controls[i]).Clear();
                }
                else if (control.Controls[i].GetType().Name == "NumTextBoxControl")
                {
                    //((NumTextBoxControl)control.Controls[i]).Clear();
                }
                else if (control.Controls[i].GetType().Name == "DateTimeControl")
                {
                   // ((DateTimeControl)control.Controls[i]).Clear();
                }
                else if (control.Controls[i].GetType().Name == "ComboBoxControl")
                {
                   // ((ComboBoxControl)control.Controls[i]).Clear();
                }
                else if (control.Controls[i].GetType().Name == "YesOrNoControl")
                {
                    //((YesOrNoControl)control.Controls[i]).Clear();
                }
            }
        } 
        #endregion

        #region Button Event



        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset(this.PanelCondition);
            this.sqlWhere = string.Empty;
            this.sqlWhereDescribe = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Width.ToString());
            MessageBox.Show(this.LabelCondition.Text.Length.ToString());

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        public void btnQuery_Click(object sender, EventArgs e)
        {
            InitQuery();
            BindData();
        } 
        #endregion

        #region SaveWinGrid
        public virtual void SaveWinGrid(Control contrls)
        {
            for (int i = 0; i < contrls.Controls.Count; i++)
            {
                if (contrls.Controls[i].HasChildren)
                {
                    SaveWinGrid(contrls.Controls[i]);
                }
                if (contrls.Controls[i].GetType().Name == "WinGridView")
                {
                    ((WHC.Pager.WinControl.WinGridView)contrls.Controls[i]).SaveGridParm();
                }
            }
        } 
        #endregion

        #region FormClosing
        private void BaseDockQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveWinGrid(this);
            }
            catch (Exception)
            {
            }
        } 
        #endregion
    }
}

