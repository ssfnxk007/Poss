namespace WHC.Pager.WinControl
{
    partial class WinGridView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinGridView));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_sampling = new System.Windows.Forms.ToolStripMenuItem();
            this.samplingAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.samplingConver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.samplingExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.samplingEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.samplingRead = new System.Windows.Forms.ToolStripMenuItem();
            this.samplingSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.samplingInputAmount = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CopyRowInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CopyColInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Filter = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ClearFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_SetColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.menu_Add,
            this.menu_Edit,
            this.menu_Delete,
            this.menu_Refresh,
            this.toolStripSeparator2,
            this.menu_sampling,
            this.menu_Copy,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.menu_Print,
            this.menu_Export,
            this.toolStripSeparator4,
            this.menu_SetColumn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 248);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // menu_Add
            // 
            this.menu_Add.Image = ((System.Drawing.Image)(resources.GetObject("menu_Add.Image")));
            this.menu_Add.Name = "menu_Add";
            this.menu_Add.Size = new System.Drawing.Size(141, 22);
            this.menu_Add.Text = "新建(&N)";
            this.menu_Add.Click += new System.EventHandler(this.menu_Add_Click);
            // 
            // menu_Edit
            // 
            this.menu_Edit.Image = ((System.Drawing.Image)(resources.GetObject("menu_Edit.Image")));
            this.menu_Edit.Name = "menu_Edit";
            this.menu_Edit.Size = new System.Drawing.Size(141, 22);
            this.menu_Edit.Text = "编辑选定(&E)";
            this.menu_Edit.Click += new System.EventHandler(this.menu_Edit_Click);
            // 
            // menu_Delete
            // 
            this.menu_Delete.Image = ((System.Drawing.Image)(resources.GetObject("menu_Delete.Image")));
            this.menu_Delete.Name = "menu_Delete";
            this.menu_Delete.Size = new System.Drawing.Size(141, 22);
            this.menu_Delete.Text = "删除选定(&D)";
            this.menu_Delete.Click += new System.EventHandler(this.menu_Delete_Click);
            // 
            // menu_Refresh
            // 
            this.menu_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("menu_Refresh.Image")));
            this.menu_Refresh.Name = "menu_Refresh";
            this.menu_Refresh.Size = new System.Drawing.Size(141, 22);
            this.menu_Refresh.Text = "刷新列表(&R)";
            this.menu_Refresh.Click += new System.EventHandler(this.menu_Refresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // menu_sampling
            // 
            this.menu_sampling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samplingAdd,
            this.samplingConver,
            this.toolStripSeparator5,
            this.samplingExtract,
            this.toolStripSeparator6,
            this.samplingEdit,
            this.samplingRead,
            this.samplingSave,
            this.toolStripSeparator7,
            this.samplingInputAmount});
            this.menu_sampling.Image = global::WHC.Pager.WinControl.Properties.Resources.Tables_and_Borders;
            this.menu_sampling.Name = "menu_sampling";
            this.menu_sampling.Size = new System.Drawing.Size(141, 22);
            this.menu_sampling.Text = "数据采样(&X)";
            // 
            // samplingAdd
            // 
            this.samplingAdd.Name = "samplingAdd";
            this.samplingAdd.Size = new System.Drawing.Size(144, 22);
            this.samplingAdd.Text = "添加采样(&A)";
            // 
            // samplingConver
            // 
            this.samplingConver.Name = "samplingConver";
            this.samplingConver.Size = new System.Drawing.Size(144, 22);
            this.samplingConver.Text = "覆盖采样(&D)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
            // 
            // samplingExtract
            // 
            this.samplingExtract.Name = "samplingExtract";
            this.samplingExtract.Size = new System.Drawing.Size(144, 22);
            this.samplingExtract.Text = "提取采样(&C)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(141, 6);
            // 
            // samplingEdit
            // 
            this.samplingEdit.Name = "samplingEdit";
            this.samplingEdit.Size = new System.Drawing.Size(144, 22);
            this.samplingEdit.Text = "编辑采样(&E)";
            // 
            // samplingRead
            // 
            this.samplingRead.Name = "samplingRead";
            this.samplingRead.Size = new System.Drawing.Size(144, 22);
            this.samplingRead.Text = "读取采样(&R)";
            // 
            // samplingSave
            // 
            this.samplingSave.Name = "samplingSave";
            this.samplingSave.Size = new System.Drawing.Size(144, 22);
            this.samplingSave.Text = "保存采样(&S)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(141, 6);
            // 
            // samplingInputAmount
            // 
            this.samplingInputAmount.Name = "samplingInputAmount";
            this.samplingInputAmount.Size = new System.Drawing.Size(144, 22);
            this.samplingInputAmount.Text = "输入数量(&M)";
            // 
            // menu_Copy
            // 
            this.menu_Copy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_CopyRowInfo,
            this.menu_CopyColInfo});
            this.menu_Copy.Image = global::WHC.Pager.WinControl.Properties.Resources.tECopy;
            this.menu_Copy.Name = "menu_Copy";
            this.menu_Copy.Size = new System.Drawing.Size(141, 22);
            this.menu_Copy.Text = "数据复制(&G)";
            // 
            // menu_CopyRowInfo
            // 
            this.menu_CopyRowInfo.Image = ((System.Drawing.Image)(resources.GetObject("menu_CopyRowInfo.Image")));
            this.menu_CopyRowInfo.Name = "menu_CopyRowInfo";
            this.menu_CopyRowInfo.Size = new System.Drawing.Size(176, 22);
            this.menu_CopyRowInfo.Text = "复制选定行信息(&C)";
            this.menu_CopyRowInfo.Click += new System.EventHandler(this.menu_CopyInfo_Click);
            // 
            // menu_CopyColInfo
            // 
            this.menu_CopyColInfo.Image = global::WHC.Pager.WinControl.Properties.Resources.Columns_2;
            this.menu_CopyColInfo.Name = "menu_CopyColInfo";
            this.menu_CopyColInfo.Size = new System.Drawing.Size(176, 22);
            this.menu_CopyColInfo.Text = "复制选定列信息(&L)";
            this.menu_CopyColInfo.Click += new System.EventHandler(this.menu_CopyColInfo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Filter,
            this.menu_ClearFilter});
            this.toolStripMenuItem1.Image = global::WHC.Pager.WinControl.Properties.Resources.Search1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1.Text = "数据过滤(&F)";
            // 
            // menu_Filter
            // 
            this.menu_Filter.Image = global::WHC.Pager.WinControl.Properties.Resources.Find;
            this.menu_Filter.Name = "menu_Filter";
            this.menu_Filter.Size = new System.Drawing.Size(140, 22);
            this.menu_Filter.Text = "添加过滤(&A)";
            this.menu_Filter.Click += new System.EventHandler(this.menu_Filter_Click);
            // 
            // menu_ClearFilter
            // 
            this.menu_ClearFilter.Image = global::WHC.Pager.WinControl.Properties.Resources.Clean;
            this.menu_ClearFilter.Name = "menu_ClearFilter";
            this.menu_ClearFilter.Size = new System.Drawing.Size(140, 22);
            this.menu_ClearFilter.Text = "清除过滤(&C)";
            this.menu_ClearFilter.Click += new System.EventHandler(this.menu_ClearFilter_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // menu_Print
            // 
            this.menu_Print.Image = ((System.Drawing.Image)(resources.GetObject("menu_Print.Image")));
            this.menu_Print.Name = "menu_Print";
            this.menu_Print.Size = new System.Drawing.Size(141, 22);
            this.menu_Print.Text = "打印列表(&P)";
            this.menu_Print.Click += new System.EventHandler(this.menu_Print_Click);
            // 
            // menu_Export
            // 
            this.menu_Export.Image = ((System.Drawing.Image)(resources.GetObject("menu_Export.Image")));
            this.menu_Export.Name = "menu_Export";
            this.menu_Export.Size = new System.Drawing.Size(141, 22);
            this.menu_Export.Text = "导出数据(&S)";
            this.menu_Export.Click += new System.EventHandler(this.menu_Export_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            // 
            // menu_SetColumn
            // 
            this.menu_SetColumn.Image = ((System.Drawing.Image)(resources.GetObject("menu_SetColumn.Image")));
            this.menu_SetColumn.Name = "menu_SetColumn";
            this.menu_SetColumn.Size = new System.Drawing.Size(141, 22);
            this.menu_SetColumn.Text = "列属性(&A)";
            this.menu_SetColumn.Click += new System.EventHandler(this.menu_SetColumn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(540, 212);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ToolTipController = this.toolTipController1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridView1_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.LightCyan;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // toolTipController1
            // 
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // WinGridView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.gridControl1);
            this.Name = "WinGridView";
            this.Size = new System.Drawing.Size(540, 212);
            this.Load += new System.EventHandler(this.WinGridView_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menu_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Export;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_SetColumn;
        public System.Windows.Forms.ToolStripMenuItem menu_Delete;
        public System.Windows.Forms.ToolStripMenuItem menu_Refresh;
        public System.Windows.Forms.ToolStripMenuItem menu_Edit;
        public System.Windows.Forms.ToolStripMenuItem menu_Add;
        private System.Windows.Forms.ToolStripMenuItem menu_Copy;
        private System.Windows.Forms.ToolStripMenuItem menu_CopyRowInfo;
        private System.Windows.Forms.ToolStripMenuItem menu_CopyColInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_Filter;
        private System.Windows.Forms.ToolStripMenuItem menu_ClearFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menu_sampling;
        private System.Windows.Forms.ToolStripMenuItem samplingAdd;
        private System.Windows.Forms.ToolStripMenuItem samplingConver;
        private System.Windows.Forms.ToolStripMenuItem samplingExtract;
        private System.Windows.Forms.ToolStripMenuItem samplingEdit;
        private System.Windows.Forms.ToolStripMenuItem samplingRead;
        private System.Windows.Forms.ToolStripMenuItem samplingSave;
        private System.Windows.Forms.ToolStripMenuItem samplingInputAmount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}
