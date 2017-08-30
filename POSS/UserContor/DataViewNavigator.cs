using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace POSS
{

    public delegate void ViewRowIndexChanged(object sender, EventArgs e);
    public delegate void ViewRowIndexChanging(object sender, HandledEventArgs e);
    /// <summary>
    /// 用于GridView数据导航
    /// </summary>
    public class DataViewNavigator : XtraUserControl
    {
        public event ViewRowIndexChanged RowIndexChanged;
        public event ViewRowIndexChanging RowIndexChanging;

        #region 变量定义
        private SimpleButton btnPrev;
        private SimpleButton btnNext;
        private SimpleButton btnLast;
        private TextEdit txtStatus;
        private SimpleButton btnFast;



        private DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView();


        #endregion

        #region 属性

        /// <summary>
        /// GridView视图
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DevExpress.XtraGrid.Views.Grid.GridView View
        {
            get { return view; }
            set
            {
                view = value;
                EventAfter();
                RefreshNavigator();
            }
        }
        #endregion

        #region 构造方法，窗体加载
        public DataViewNavigator()
        {
            InitializeComponent();
        }

       
        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewNavigator));
            this.btnFast = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFast
            // 
            this.btnFast.Image = ((System.Drawing.Image)(resources.GetObject("btnFast.Image")));
            this.btnFast.Location = new System.Drawing.Point(0, 0);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(24, 24);
            this.btnFast.TabIndex = 0;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(25, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(24, 24);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(185, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 24);
            this.btnNext.TabIndex = 0;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(210, 0);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(24, 24);
            this.btnLast.TabIndex = 0;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(50, 1);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Properties.Appearance.Options.UseFont = true;
            this.txtStatus.Properties.Appearance.Options.UseTextOptions = true;
            this.txtStatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtStatus.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtStatus.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtStatus.Properties.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(134, 22);
            this.txtStatus.TabIndex = 1;
            // 
            // DataViewNavigator
            // 
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFast);
            this.Name = "DataViewNavigator";
            this.Size = new System.Drawing.Size(234, 24);
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region 数据导航

        /// <summary>
        /// 首条
        /// </summary>
        private void First()
        {
            if (!EventBefore()) return;
            if (this.view != null)
            {
                view.MoveFirst();
            }
            EventAfter();
        }

        /// <summary>
        /// 上一条
        /// </summary>
        private void Prev()
        {
            if (!EventBefore()) return;
            if (this.view != null)
            {
                view.MovePrev();
            }
            EventAfter();
        }

        /// <summary>
        /// 下一条
        /// </summary>
        private void Next()
        {
            if (!EventBefore()) return;
            if (this.view != null)
            {
                view.MoveNext();
            }
            EventAfter();
        }

        /// <summary>
        /// 末条
        /// </summary>
        private void Last()
        {
            if (!EventBefore()) return;
            if (this.view != null)
            {
                view.MoveLast();
            }
            EventAfter();
        }

        #endregion

        #region 按钮事件
        private void btnFast_Click(object sender, EventArgs e)
        {
            this.First();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Prev();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Next();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.Last();
        }

        #endregion

        #region 事件处理
        private bool EventBefore()
        {
            HandledEventArgs e = new HandledEventArgs();
            if (this.RowIndexChanging != null)
            {
                RowIndexChanging(this.view.GetRow(this.view.FocusedRowHandle), e);
                return e.Handled;
            }
            else
            {
                return true;
            }

        }


        private void EventAfter()
        {
            if (this.RowIndexChanged != null)
            {
                RowIndexChanged(this.view.GetRow(this.view.FocusedRowHandle), new EventArgs());
            }
            RefreshNavigator();
        }

        private void RefreshNavigator()
        {
            if (view.FocusedRowHandle>=0)
            {
                this.txtStatus.Text = string.Format("{0}/{1}", view.FocusedRowHandle + 1, this.view.RowCount);
            }
            this.btnFast.Enabled = !(view.FocusedRowHandle == 0);
            this.btnPrev.Enabled = !(view.FocusedRowHandle == 0);
            this.btnNext.Enabled = !(view.FocusedRowHandle ==view.RowCount - 1);
            this.btnLast.Enabled = !(view.FocusedRowHandle == view.RowCount - 1);

        }
        #endregion
    }
}
