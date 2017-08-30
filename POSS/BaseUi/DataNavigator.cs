using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace POSS
{
    public delegate void PostionChangeingEventHandler(object sender, HandledEventArgs e);
    public delegate void PostionChangedEventHandler(object sender, EventArgs e);
    public partial  class DataNavigator: DevExpress.XtraEditors.XtraUserControl
    {
        public event PostionChangeingEventHandler PositionChanging;
        public event PostionChangedEventHandler PositionChanged;
        private int m_CurrentIndex = 0;//当前的位置
        public List<string> IDList = new List<string>();

        protected DevExpress.XtraEditors.SimpleButton btnFirst;
        protected DevExpress.XtraEditors.SimpleButton btnPrevious;
        protected DevExpress.XtraEditors.SimpleButton btnNext;
        protected DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.TextEdit txtInfo;


        /// <summary>
        /// 获取或设置索引值
        /// </summary>
        public int CurrentIndex
        {
            get { return m_CurrentIndex; }
            set
            {
                m_CurrentIndex = value;
                ChangePosition(value);
            }
        }

        private void InitializeComponent()
        {
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.txtInfo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(14, 14);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(29, 28);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(49, 14);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(29, 28);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(189, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 28);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = ">";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(224, 14);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(29, 28);
            this.btnLast.TabIndex = 0;
            this.btnLast.Text = ">>";
            // 
            // txtInfo
            // 
            this.txtInfo.EditValue = "0/0";
            this.txtInfo.Location = new System.Drawing.Point(85, 18);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInfo.TabIndex = 1;
            // 
            // DataNavigator
            // 
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Name = "DataNavigator";
            this.Size = new System.Drawing.Size(283, 45);
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).EndInit();
            this.ResumeLayout(false);

        }


        public DataNavigator()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            ChangePosition(0);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ChangePosition(m_CurrentIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ChangePosition(m_CurrentIndex + 1);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ChangePosition(IDList.Count - 1);
        }

        private void EnableControl(bool enable)
        {
            this.btnFirst.Enabled = enable;
            this.btnLast.Enabled = enable;
            this.btnNext.Enabled = enable;
            this.btnPrevious.Enabled = enable;
        }

        private void ChangePosition(int newPos)
        {
            if (PositionChanging != null)
            {
                HandledEventArgs e = new HandledEventArgs();
                PositionChanging(this, e);
                if (e.Handled) return;
            }
            int count = IDList.Count;
            if (count == 0)
            {
                EnableControl(false);
                this.txtInfo.Text = "";
            }
            else
            {
                EnableControl(true);

                newPos = (newPos < 0) ? 0 : newPos;
                m_CurrentIndex = ((count - 1) > newPos) ? newPos : (count - 1);
                this.btnPrevious.Enabled = (m_CurrentIndex > 0);
                this.btnNext.Enabled = m_CurrentIndex < (count - 1);
                this.txtInfo.Text = string.Format("{0}/{1}", m_CurrentIndex + 1, count);
            }
            if (PositionChanged != null)
            {
                PositionChanged(this, new EventArgs());
            }
        }
    }
}
