using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WHC.Pager.WinControl
{

    using DevExpress.XtraGrid.Views.Base;
    using WHC.Framework.Commons;
    /// <summary>
    /// 不带分页导航的列表展示控件
    /// </summary>
    /// 
    
    public delegate void ModifyProductHandler(object sender, string h_id);

    public delegate void QueryProductRelevanceHandler(string h_id);
    public partial class WinGridView : DevExpress.XtraEditors.XtraUserControl
    {
        public event ModifyProductHandler ModifyProduct;
        public event QueryProductRelevanceHandler ProductRelevanceQuery;

        #region 变量定义
        private Dictionary<string, string> GetColumnNameTypes(DataTable dt)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (DataColumn col in dt.Columns)
            {
                if (!dict.ContainsKey(col.ColumnName))
                {
                    dict.Add(col.ColumnName, col.DataType.FullName);
                }
            }
            return dict;
        }

        private object dataSource;//数据源
        private string displayColumns = "";//显示的列
        private string printTitle = "";//报表标题
        private Dictionary<string, int> columnDict = new Dictionary<string, int>();//字段列顺序

        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private bool isExportAllPage = false;//是否导出所有页
        private Dictionary<string, string> columnNameAlias = new Dictionary<string, string>();//字段别名字典集合
        private ContextMenuStrip appendedMenu;//右键菜单
        private bool m_ShowAddMenu = true;//是否显示新建菜单
        private bool m_ShowEditMenu = true;//是否显示编辑菜单
        private bool m_ShowDeleteMenu = true;//是否显示删除菜单
        private Dictionary<System.Guid, FooterItem> sumItem = new Dictionary<System.Guid, FooterItem>();//需要汇总的列集合
        private Dictionary<System.Guid, FooterItem> avgItem = new Dictionary<System.Guid, FooterItem>();//需要求平均值的列集合
        private Dictionary<System.Guid, FooterItem> countItem = new Dictionary<Guid, FooterItem>();//需要计数的列
        private Dictionary<string, string> formatString = new Dictionary<string, string>();//列格式集合
        private Dictionary<string, HorzAlignment> textHorzAlignment = new Dictionary<string, HorzAlignment>();


        private List<string> readOnlyList = new List<string>();//只读字段列表
        private bool isFiltered = false;//是否过滤
        private bool enableMenu = true; //是否允许右键菜单
        private bool enableEdit = false; //是否允许编辑
        private bool haveProduct = false; //是否有商品明细编码列 
        private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.Ini");

        #endregion

        #region 属性

        /// <summary>
        /// 是否显示CheckBox列
        /// </summary>
        public bool ShowCheckBox { get; set; }

        /// <summary>
        /// 显示的列内容，需要指定以防止GridView乱序
        /// 使用"|"或者","分开每个列，如“ID|Name”
        /// </summary>
        public string DisplayColumns
        {
            get { return displayColumns; }
            set
            {
                displayColumns = value;
                columnDict = new Dictionary<string, int>();
                string[] items = displayColumns.Split(new char[] { '|', ',' });
                for (int i = 0; i < items.Length; i++)
                {
                    string str = items[i];
                    if (!string.IsNullOrEmpty(str))
                    {
                        str = str.Trim();
                        if (!columnDict.ContainsKey(str.ToUpper()))
                        {
                            columnDict.Add(str.ToUpper(), i);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 打印报表的抬头（标题）
        /// </summary>
        public string PrintTitle
        {
            get { return printTitle; }
            set { printTitle = value; }
        }


        /// <summary>
        /// 是否有商品明细编码列
        /// </summary>
        public bool HaveProduct
        {
            get { return haveProduct; }
            set { haveProduct = value; }
        }

        /// <summary>
        /// 是否允许编辑
        /// </summary>
        public bool EnableEdit
        {
            get { return enableEdit; }
            set { enableEdit = value; }
        }


        /// <summary>
        /// 只读字段列表
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> ReadOnlyList
        {
            get { return readOnlyList; }
            set { readOnlyList = value; }
        }
        /// <summary>
        /// 列格式字符串
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, string> FormatString
        {
            get { return formatString; }
            set { formatString = value; }
        }

        /// <summary>
        /// 列文本对齐方式
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, HorzAlignment> TextHorzAlignment
        {
            get { return textHorzAlignment; }
            set { textHorzAlignment = value; }
        }

        /// <summary>
        /// 需要计数的列
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<System.Guid, FooterItem> CountItem
        {
            get { return countItem; }
            set { countItem = value; }
        }

        /// <summary>
        /// 是否过滤
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFiltered
        {
            get { return isFiltered; }
            set
            {
                isFiltered = value;
                if (!value)
                {
                    this.gridView1.ApplyFindFilter("");
                    
                }
            }
        }


        /// <summary>
        /// 是否显示表格页脚
        /// </summary>
        [Description("是否显示表格页脚")]
        [DefaultValue(false)]
        public bool ShowFooter
        {
            get { return gridView1.OptionsView.ShowFooter; }
            set { gridView1.OptionsView.ShowFooter = value; }
        }
        /// <summary>
        /// 是否显示隔行变色1
        /// </summary>
        [Description("是否显示格行变色1")]
        [DefaultValue(false)]
        public bool ShowBianSe
        {
            get { return this.gridView1.OptionsView.EnableAppearanceEvenRow;  }
            set { this.gridView1.OptionsView.EnableAppearanceEvenRow = value; }
        }/// <summary>
         /// 是否显示隔行变色2
         /// </summary>
        [Description("是否显示格行变色2")]
        [DefaultValue(false)]
        public bool ShowBianSe2
        {
            get { return this.gridView1.OptionsView.EnableAppearanceOddRow; }
            set { this.gridView1.OptionsView.EnableAppearanceOddRow = value; }
        }

        //<summary>
        //汇总字段集合
        //</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<System.Guid, FooterItem> SumItem
        {
            get { return sumItem; }
            set { sumItem = value; }
        }
        //<summary>
        //平均值字段集合
        //</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<System.Guid, FooterItem> AvgItem
        {
            get { return avgItem; }
            set { avgItem = value; }
        }
        /// <summary>
        /// 是否允许右键菜单
        /// </summary>
        public bool EnableMenu
        {
            get { return enableMenu; }
            set { enableMenu = value; }
        }


        /// <summary>
        /// 新建菜单的显示内容
        /// </summary>
        public string AddMenuText = "新建(&N)";
        /// <summary>
        /// 编辑菜单的显示内容
        /// </summary>
        public string EditMenuText = "编辑选定(&E)";
        /// <summary>
        /// 删除菜单的显示内容
        /// </summary>
        public string DeleteMenuText = "删除选定(&D)";
        /// <summary>
        /// 刷新菜单的显示内容
        /// </summary>
        public string RefreshMenuText = "刷新列表(&R)";

        /// <summary>
        /// 导出全部的数据源
        /// </summary>
        public object AllToExport;

        /// <summary>
        /// 是否显示行号
        /// </summary>
        public bool ShowLineNumber = true;
        /// <summary>
        /// 获取或设置奇数行的背景色
        /// </summary>
        public Color EventRowBackColor = Color.LightCyan;

        /// <summary>
        /// 是否使用最佳宽度
        /// </summary>
        public bool BestFitColumnWith = false;

        #region 权限功能控制
        /// <summary>
        /// 设置是否显示导出菜单
        /// </summary>
        [Category("分页"), Description("是否显示导出菜单。"), Browsable(true)]
        public bool ShowExportButton
        {
            get
            {
                return this.menu_Export.Enabled;
            }
            set
            {
                this.menu_Export.Enabled = value;
            }
        }
        /// <summary>
        /// 是否显示新建菜单
        /// </summary>
        [Category("分页"), Description("是否显示新建菜单。"), Browsable(true)]
        public bool ShowAddMenu
        {
            get { return m_ShowAddMenu; }
            set { m_ShowAddMenu = value; }
        }
        /// <summary>
        /// 是否显示编辑菜单
        /// </summary>
        [Category("分页"), Description("是否显示编辑菜单。"), Browsable(true)]
        public bool ShowEditMenu
        {
            get { return m_ShowEditMenu; }
            set { m_ShowEditMenu = value; }
        }

        /// <summary>
        /// 是否显示删除菜单
        /// </summary>
        [Category("分页"), Description("是否显示删除菜单。"), Browsable(true)]
        public bool ShowDeleteMenu
        {
            get { return m_ShowDeleteMenu; }
            set { m_ShowDeleteMenu = value; }
        }
        #endregion

        /// <summary>
        /// 列名的别名字典集合
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, string> ColumnNameAlias
        {
            get { return columnNameAlias; }
            set
            {
                if (value != null)
                {
                    foreach (string key in value.Keys)
                    {
                        AddColumnAlias(key, value[key]);
                    }
                }
            }
        }

        #region 事件处理

        /// <summary>
        /// 导出Excel前执行的操作
        /// </summary>
        public event EventHandler OnStartExport;
        /// <summary>
        /// 导出Excel后执行的操作
        /// </summary>
        public event EventHandler OnEndExport;
        /// <summary>
        /// 双击控件实现的操作，实现后出现右键菜单“编辑选定项”
        /// </summary>
        public event EventHandler OnEditSelected;
        /// <summary>
        /// 实现事件后出现“删除选定项”菜单项
        /// </summary>
        public event EventHandler OnDeleteSelected;
        /// <summary>
        /// 实现事件后出现“更新”菜单项
        /// </summary>
        public event EventHandler OnRefresh;
        /// <summary>
        /// 实现事件后，出现“新建”菜单项
        /// </summary>
        public event EventHandler OnAddNew;
        /// <summary>
        /// 实现对单击GirdView控件的响应
        /// </summary>
        public event EventHandler OnGridViewMouseClick;
        /// <summary>
        /// 实现对双击GirdView控件的响应
        /// </summary>
        public event EventHandler OnGridViewMouseDoubleClick;

        #endregion

        /// <summary>
        /// 追加的菜单项目
        /// </summary>
        public ContextMenuStrip AppendedMenu
        {
            get
            {
                return appendedMenu;
            }
            set
            {
                if (value != null)
                {
                    appendedMenu = value;
                    for (int i = 0; appendedMenu.Items.Count > 0; i++)
                    {
                        this.contextMenuStrip1.Items.Insert(i, appendedMenu.Items[0]);
                    }
                }
                else
                {
                    toolStripSeparator1.Visible = false;
                }
            }
        }

        /// <summary>
        /// 封装的GridView1
        /// </summary>
        public GridView GridView1
        {
            get
            {
                return this.gridView1;
            }
        }

        /// <summary>
        /// 获取或设置数据源
        /// </summary>
        public object DataSource
        {
            get { return dataSource; }
            set
            {
                if (this.gridView1.Columns != null)
                {
                    this.gridView1.Columns.Clear();
                    this.IsFiltered = false;
                }

                dataSource = value;
                this.gridControl1.DataSource = dataSource;
            }
        }

        #endregion

        #region 构造方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public WinGridView()
        {
            InitializeComponent();
            this.gridView1.CustomDrawFooterCell += gridView1_CustomDrawFooterCell;
            this.GridView1.CustomDrawCell += GridView1_CustomDrawCell;


        }



        void GridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "H_name")
            //{
            //    e.Appearance.ForeColor = Color.Blue;
            //    System.Drawing.Font f = new System.Drawing.Font("f", 8, System.Drawing.FontStyle.Underline);
            //    e.Appearance.Font = f;
            //}
           
            //if (!this.enableEdit) return;
            //if (this.readOnlyList.Contains(e.Column.FieldName)) return;
            //e.Column.AppearanceCell.BackColor = Color.LightSteelBlue;
           

        }

        #endregion

        #region 表格参数保存及加载
        /// <summary>
        /// 保存列属性到配置文件Values.ini中
        /// </summary>
        public void SaveGridParm()
        {
            if (this.dataSource == null) return;
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < this.gridView1.Columns.Count; index++)
            {
                if (string.IsNullOrWhiteSpace(sb.ToString()))
                {
                    sb.AppendFormat("{0}/{1}/{2}/{3}", this.gridView1.Columns[index].FieldName, this.gridView1.Columns[index].Width.ToString(), this.gridView1.Columns[index].VisibleIndex.ToString(), this.gridView1.Columns[index].Visible.ToString());
                }
                else
                {
                    sb.AppendFormat(",{0}/{1}/{2}/{3}", this.gridView1.Columns[index].FieldName, this.gridView1.Columns[index].Width.ToString(), this.gridView1.Columns[index].VisibleIndex.ToString(), this.gridView1.Columns[index].Visible.ToString());
                }
            }
            iniFile.IniWriteValue(this.ParentForm.Name, this.Name, sb.ToString());
        }

        /// <summary>
        /// 从配置文件中读取表格参数
        /// </summary>
        private void LoadGridParm()
        {
            string text = iniFile.IniReadValue(this.ParentForm == null ? this.Parent.Name : this.ParentForm.Name, this.Name, 2048);
            if (string.IsNullOrWhiteSpace(text)) return;
            string[] values = text.Split(',');
            if (values.Length == 0) return;
            foreach (string s in values)
            {
                string[] s1 = s.Split('/');
                if (s1.Length == 0) continue;

                try
                {
                    if (this.displayColumns.Contains(s1[0]) || this.displayColumns.Contains(s1[0].ToUpper()))
                    {
                        GridView1.Columns[s1[0]].Width = Convert.ToInt32(s1[1]);
                        GridView1.Columns[s1[0]].VisibleIndex = Convert.ToInt32(s1[2]);
                        GridView1.Columns[s1[0]].Visible = Convert.ToBoolean(s1[3]);
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }

        }
        #endregion

        #region 菜单事件
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.menu_Add.Visible = (this.OnAddNew != null && this.ShowAddMenu);
            this.menu_Delete.Visible = (this.OnDeleteSelected != null && this.ShowDeleteMenu);
            this.menu_Edit.Visible = (this.OnEditSelected != null && this.ShowEditMenu);
            this.menu_Refresh.Visible = (this.OnRefresh != null);

            this.menu_Add.Text = AddMenuText;
            this.menu_Edit.Text = EditMenuText;
            this.menu_Delete.Text = DeleteMenuText;
            this.menu_Refresh.Text = RefreshMenuText;


            this.menu_Edit.Enabled = this.gridView1.RowCount > 0 ? true : false;
            this.menu_Delete.Enabled = this.gridView1.RowCount > 0 ? true : false;
            this.menu_Copy.Enabled = this.gridView1.RowCount > 0 ? true : false;
            menu_ClearFilter.Enabled = isFiltered ? (this.gridView1.RowCount > 0 ? true : false) : false;
            menu_Filter.Enabled = this.gridView1.RowCount > 0 ? true : false;
            menu_sampling.Enabled = this.gridView1.RowCount > 0 ? true : false;
            samplingExtract.Enabled = this.enableEdit;
            samplingAdd.Enabled = haveProduct;
            samplingConver.Enabled = haveProduct;
        }
        #endregion

        #region DisplayColumnIndex
        /// <summary>
        /// 返回对应字段的显示顺序，如果没有，返回-1
        /// </summary>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        private int GetDisplayColumnIndex(string columnName)
        {
            int result = -1;
            if (columnDict.ContainsKey(columnName.ToUpper()))
            {
                result = columnDict[columnName.ToUpper()];
            }

            return result;
        }
        #endregion

        #region 别名
        /// <summary>
        /// 添加列名的别名
        /// </summary>
        /// <param name="key">列的原始名称</param>
        /// <param name="alias">列的别名</param>
        public void AddColumnAlias(string key, string alias)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(alias))
            {
                if (!columnNameAlias.ContainsKey(key.ToUpper()))
                {
                    columnNameAlias.Add(key.ToUpper(), alias);
                }
                else
                {
                    columnNameAlias[key.ToUpper()] = alias;
                }
            }
        }
        #endregion

        #region 导出Excel操作

        private void ExportToExcel()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xls)|*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!saveFileDialog.FileName.Equals(String.Empty))
                {
                    FileInfo f = new FileInfo(saveFileDialog.FileName);
                    if (f.Extension.ToLower().Equals(".xls"))
                    {
                        StartExport(saveFileDialog.FileName);
                    }
                    else
                    {
                        MessageBox.Show("文件格式不正确");
                    }
                }
                else
                {
                    MessageBox.Show("需要指定一个保存的目录");
                }
            }
        }

        /// <summary>
        /// starts the export to new excel document
        /// </summary>
        /// <param name="filepath">the file to export to</param>
        private void StartExport(String filepath)
        {
            if (OnStartExport != null)
            {
                OnStartExport(this, new EventArgs());
            }

            //create a new background worker, to do the exporting
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += new DoWorkEventHandler(bg_DoWork);
            bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_RunWorkerCompleted);
            bg.RunWorkerAsync(filepath);
        }

        /// <summary>
        /// 使用背景线程导出Excel文档
        /// </summary>
        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable table = new DataTable();
            if (AllToExport != null && isExportAllPage)
            {
                if (AllToExport is DataView)
                {
                    DataView dv = (DataView)AllToExport;//默认导出显示内容
                    table = dv.ToTable();
                }
                else if (AllToExport is DataTable)
                {
                    table = AllToExport as DataTable;
                }
                else
                {
                    table = ReflectionUtil.CreateTable(AllToExport);
                }

                //解析标题
                string originalName = string.Empty;
                foreach (DataColumn column in table.Columns)
                {
                    originalName = column.Caption;
                    if (columnNameAlias.ContainsKey(originalName.ToUpper()))
                    {
                        column.Caption = columnNameAlias[originalName.ToUpper()];
                        column.ColumnName = columnNameAlias[originalName.ToUpper()];
                    }
                }
                //for (int i = 0; i < this.gridView1.Columns.Count; i++)
                //{
                //    if (!this.gridView1.Columns[i].Visible)
                //    {
                //        table.Columns.Remove(this.gridView1.Columns[i].FieldName);
                //    }
                //}
            }
            else
            {
                DataColumn column;
                DataRow row;
                for (int i = 0; i < this.gridView1.Columns.Count; i++)
                {
                    if (this.gridView1.Columns[i].Visible)
                    {
                        column = new DataColumn(this.gridView1.Columns[i].FieldName, typeof(string));
                        column.Caption = this.gridView1.Columns[i].Caption;
                        table.Columns.Add(column);
                    }
                }

                object cellValue = "";
                string fieldName = "";
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    row = table.NewRow();
                    for (int j = 0; j < gridView1.Columns.Count; j++)
                    {
                        if (this.gridView1.Columns[j].Visible)
                        {
                            fieldName = gridView1.Columns[j].FieldName;
                            cellValue = gridView1.GetRowCellValue(i, fieldName);
                            row[fieldName] = cellValue ?? "";
                        }
                    }
                    table.Rows.Add(row);
                }
            }

            string outError = "";
            AsposeExcelTools.DataTableToExcel2(table, (String)e.Argument, out outError);
        }

        /// <summary>
        /// 添加汇总显示列
        /// </summary>
        private void AddSumFooter()
        {
            if (sumItem == null) return;
            if (this.sumItem.Count == 0 || !this.ShowFooter) return;
            foreach (System.Guid key in sumItem.Keys)
            {
                try
                {
                    this.gridView1.Columns[sumItem[key].FieldName].Summary.Add(DevExpress.Data.SummaryItemType.Sum, sumItem[key].FieldName, string.IsNullOrEmpty(sumItem[key].Describe) ? string.Format("{{0:{0}}}", sumItem[key].Format) : string.Format("{1}{{0:{0}}}", sumItem[key].Format, sumItem[key].Describe));

                }
                catch (Exception)
                {
                    continue;
                }
            }

        }
        /// <summary>
        /// 添加平均值显示列
        /// </summary>
        private void AddAvgFooter()
        {
            if (avgItem == null) return;
            if (this.avgItem.Count == 0 || !this.ShowFooter) return;
            foreach (System.Guid key in avgItem.Keys)
            {
                try
                {
                    this.gridView1.Columns[avgItem[key].FieldName].Summary.Add(DevExpress.Data.SummaryItemType.Average, avgItem[key].FieldName, string.IsNullOrEmpty(avgItem[key].Describe) ? string.Format("{{0:{0}}}", avgItem[key].Format) : string.Format("{1}{{0:{0}}}", avgItem[key].Format, avgItem[key].Describe));
                }
                catch (Exception)
                {
                    continue;
                }
            }

        }
        /// <summary>
        /// 设置字段只读
        /// </summary>
        private void SetReadOnly()
        {
            if (this.readOnlyList.Count == 0) return;
            if (!this.gridView1.Editable) return;
            foreach (string s in readOnlyList)
            {
                try
                {
                    this.gridView1.Columns[s].OptionsColumn.AllowEdit = false;
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// 添加列格式化字符串
        /// </summary>
        private void AddFormatString()
        {
            if (this.formatString.Count == 0) return;
            foreach (string s in formatString.Keys)
            {
                try
                {
                    this.gridView1.Columns[s].DisplayFormat.FormatType = FormatType.Custom;
                    this.gridView1.Columns[s].DisplayFormat.FormatString = formatString[s];
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// 添加列文本对齐方式
        /// </summary>
        private void AddTextHorzAlignment()
        {
            if (this.textHorzAlignment.Count == 0) return;
            foreach (string s in textHorzAlignment.Keys)
            {
                try
                {
                    this.gridView1.Columns[s].AppearanceCell.TextOptions.HAlignment = textHorzAlignment[s];
                    this.gridView1.Columns[s].AppearanceHeader.TextOptions.HAlignment = textHorzAlignment[s];
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// 添加计数的列
        /// </summary>
        private void AddCountItem()
        {
            if (countItem == null) return;
            if (this.countItem.Count == 0 || !this.ShowFooter) return;
            foreach (System.Guid key in countItem.Keys)
            {
                try
                {
                    this.gridView1.Columns[sumItem[key].FieldName].Summary.Add(DevExpress.Data.SummaryItemType.Count, sumItem[key].FieldName, string.IsNullOrEmpty(sumItem[key].Describe) ? string.Format("{{0:{0}}}", sumItem[key].Format) : string.Format("{1}{{0:{0}}}", sumItem[key].Format, sumItem[key].Describe));
                }
                catch (Exception)
                {
                    continue;
                }
            }

        }
        /// <summary>
        /// 添加计算平均值的列
        /// </summary>
        private void AddAvgCountItem()
        {
            if (countItem == null) return;
            if (this.countItem.Count == 0 || !this.ShowFooter) return;
            foreach (System.Guid key in countItem.Keys)
            {
                try
                {
                    this.gridView1.Columns[avgItem[key].FieldName].Summary.Add(DevExpress.Data.SummaryItemType.Count, avgItem[key].FieldName, string.IsNullOrEmpty(avgItem[key].Describe) ? string.Format("{{0:{0}}}", avgItem[key].Format) : string.Format("{1}{{0:{0}}}", avgItem[key].Format, avgItem[key].Describe));
                }
                catch (Exception)
                {
                    continue;
                }
            }

        }

        //show a message to the user when the background worker has finished
        //and re-enable the export buttons
        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (OnEndExport != null)
            {
                OnEndExport(this, new EventArgs());
            }

            if (MessageBox.Show("导出操作完成, 您想打开该Excel文件么?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(saveFileDialog.FileName);
            }
        }

        #endregion

        #region DataSourceChanged
        private void gridView1_DataSourceChanged(object sender, EventArgs e)
        {
            #region 修改别名及可见
            //先判断设置显示的列(如果没有则显示全部）
            string originalName = string.Empty;
            string tempColumns = string.Empty;
            if (string.IsNullOrEmpty(this.DisplayColumns))
            {
                for (int i = 0; i < this.gridView1.Columns.Count; i++)
                {
                    originalName = this.gridView1.Columns[i].FieldName;
                    tempColumns += string.Format("{0},", originalName);
                }
                tempColumns = tempColumns.Trim(',');
                this.DisplayColumns = tempColumns;//全部显示
            }

            for (int i = 0; i < this.gridView1.Columns.Count; i++)
            {
                originalName = this.gridView1.Columns[i].FieldName;
                if (columnNameAlias.ContainsKey(originalName.ToUpper()))
                {
                    this.gridView1.Columns[i].Caption = columnNameAlias[originalName.ToUpper()];
                }
                else
                {
                    this.gridView1.Columns[i].Caption = originalName;//如果没有别名用原始字段名称，如ID
                }

                if (!columnDict.ContainsKey(originalName.ToUpper()))
                {
                    this.gridView1.Columns[i].Visible = false;
                }
                this.gridView1.Columns[i].VisibleIndex = GetDisplayColumnIndex(originalName.ToUpper());
            }
            #endregion

            #region 设置特殊内容显示
            object cellValue = "";
            string fieldName = "";
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                for (int j = 0; j < gridView1.Columns.Count; j++)
                {
                    fieldName = gridView1.Columns[j].FieldName;
                    cellValue = gridView1.GetRowCellValue(i, fieldName);
                    if (cellValue != null && cellValue.GetType() == typeof(DateTime))
                    {
                        if (cellValue != DBNull.Value)
                        {
                            DateTime dtTemp = DateTime.MinValue;
                            DateTime.TryParse(cellValue.ToString(), out dtTemp);
                            TimeSpan ts = dtTemp.Subtract(Convert.ToDateTime("1753/1/1"));
                            if (ts.TotalDays < 1)
                            {
                                gridView1.SetRowCellValue(i, fieldName, DBNull.Value);
                            }
                        }
                    }
                }
            }
            #endregion

            if (this.ShowLineNumber)
            {
                this.gridView1.IndicatorWidth = 60;
            }

            this.gridView1.OptionsView.ColumnAutoWidth = BestFitColumnWith;
            if (BestFitColumnWith)
            {
                this.gridView1.BestFitColumns();
            }
            if (ShowCheckBox)
            {
                GridCheckMarksSelection selection = new GridCheckMarksSelection(gridView1);
                selection.CheckMarkColumn.VisibleIndex = 0;
                selection.CheckMarkColumn.Width = 60;
            }
            this.gridView1.OptionsBehavior.Editable = enableEdit;
            this.gridView1.OptionsBehavior.ReadOnly = !enableEdit;

            //从配置文件中加载列宽度等
            this.LoadGridParm();

            //显示页脚
            AddSumFooter();

            AddAvgFooter();
            //添加格式化字符串
            AddFormatString();

            //列只读属性
            SetReadOnly();

            //寻找商品编码列
            HaveProductID();

            //添加列文本对齐方式
            AddTextHorzAlignment();

            //添加页脚计数
            AddCountItem();

            //添加页脚计数
            AddAvgCountItem();
            //添加条件显示
            AddConditionDisplay();

        }
        #endregion

        #region Hid
        /// <summary>
        /// 寻找商品编码列
        /// </summary>
        private void HaveProductID()
        {
            for (int index = 0; index < this.gridView1.Columns.Count; index++)
            {
                if (gridView1.Columns[index].FieldName.ToUpper() == "H_ID")
                {
                    this.haveProduct = true;
                    break;
                }
                else
                    this.haveProduct = false;
            }
        }
        #endregion

        #region Checked
        /// <summary>
        /// 获取勾选上的行索引列表
        /// </summary>
        /// <returns></returns>
        public List<int> GetCheckedRows()
        {
            List<int> list = new List<int>();
            if (this.ShowCheckBox)
            {
                for (int rowIndex = 0; rowIndex < this.gridView1.RowCount; rowIndex++)
                {
                    object objValue = this.gridView1.GetRowCellValue(rowIndex, "CheckMarkSelection");
                    if (objValue != null)
                    {
                        bool check = false;
                        bool.TryParse(objValue.ToString(), out check);
                        if (check)
                        {
                            list.Add(rowIndex);
                        }
                    }
                }
            }
            return list;
        }
        #endregion

        #region Mouse Event
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (OnGridViewMouseClick != null)
            {
                OnGridViewMouseClick(sender, e);
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.OnEditSelected != null && this.ShowEditMenu)
            {
                this.OnEditSelected(this.gridView1, new EventArgs());
            }
            else if (OnGridViewMouseDoubleClick != null)
            {
                OnGridViewMouseDoubleClick(this.gridView1, new EventArgs());
            }
            try
            {
                if (this.GridView1.FocusedColumn.FieldName.ToUpper() == "H_NAME")
                {
                    if (this.ModifyProduct != null)
                    {
                        object o = this.GridView1.GetRow(this.GridView1.FocusedRowHandle);
                        string h_id = this.GridView1.GetFocusedRowCellValue("H_id").ToString();
                        ModifyProduct(o, h_id);
                    }
                }
                else
                {
                    if (this.ProductRelevanceQuery != null)
                    {
                        string h_id = this.GridView1.GetFocusedRowCellValue("H_id").ToString();
                        ProductRelevanceQuery(h_id);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion
        
        #region ToolTip
        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl != gridControl1) return;

            ToolTipControlInfo info = null;
            //Get the view at the current mouse position
            GridView view = gridControl1.GetViewAt(e.ControlMousePosition) as GridView;
            if (view == null) return;

            //Get the view's element information that resides at the current position
            GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
            //Display a hint for row indicator cells
            if (hi.HitTest == GridHitTest.RowIndicator)
            {
                //An object that uniquely identifies a row indicator cell
                object o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("行数据基本信息：");
                foreach (GridColumn gridCol in view.Columns)
                {
                    if (gridCol.Visible)
                    {
                        sb.AppendFormat("    {0}：{1}\r\n", gridCol.Caption, view.GetRowCellDisplayText(hi.RowHandle, gridCol.FieldName));
                    }
                }
                info = new ToolTipControlInfo(o, sb.ToString());
            }

            //Supply tooltip information if applicable, otherwise preserve default tooltip (if any)
            if (info != null)
            {
                e.Info = info;
            }
        }
        #endregion

        #region 行号
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (ShowLineNumber)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle >= 0)
                    {
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                }
            }
        }


        #endregion

        #region 过滤
        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (this.gridView1.ActiveFilter.Count == 0)
            {
                this.isFiltered = false;
            }
            else
            {
                this.isFiltered = true;
            }
        }
        #endregion

        #region 菜单事件
        private void btnExport_Click(object sender, EventArgs e)
        {
            isExportAllPage = true;
            ExportToExcel();
        }

        private void btnExportCurrent_Click(object sender, EventArgs e)
        {
            isExportAllPage = false;
            ExportToExcel();
        }
        private void menu_CopyColInfo_Click(object sender, EventArgs e)
        {

            object value = gridView1.GetFocusedValue();
            if (value != null)
            {
                try
                {
                    Clipboard.SetText(value.ToString());
                }
                catch (Exception)
                {
                }
            }
        }

        private void menu_Filter_Click(object sender, EventArgs e)
        {
            object value = gridView1.GetFocusedValue();
            if (value != null)
            {
                ColumnView view = gridView1;
                view.ActiveFilter.Add(view.FocusedColumn,
                new ColumnFilterInfo(string.Format("{0}='{1}'", view.FocusedColumn.FieldName, value.ToString())));
                this.isFiltered = true;
            }
        }

        private void menu_ClearFilter_Click(object sender, EventArgs e)
        {
            try
            {
                ColumnView view = gridView1;
                view.ActiveFilter.Clear();
                this.isFiltered = false;
            }
            catch (Exception)
            {
            }

        }


        private void menu_Delete_Click(object sender, EventArgs e)
        {
            if (OnDeleteSelected != null)
            {
                OnDeleteSelected(this.gridView1, new EventArgs());
            }
        }

        private void menu_Refresh_Click(object sender, EventArgs e)
        {
            if (this.OnRefresh != null)
            {
                OnRefresh(this.gridView1, new EventArgs());
            }
        }

        private void menu_Edit_Click(object sender, EventArgs e)
        {
            if (OnEditSelected != null)
            {
                OnEditSelected(this.gridView1, new EventArgs());
            }
        }

        private void menu_Print_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_GridView(this.gridView1, this.printTitle);
        }

        private void menu_Add_Click(object sender, EventArgs e)
        {
            if (this.OnAddNew != null)
            {
                this.OnAddNew(this.gridView1, new EventArgs());
            }
        }

        private void menu_Export_Click(object sender, EventArgs e)
        {
            isExportAllPage = false;
            ExportToExcel();
        }

        private void menu_Buy_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.i-wit.com");
        }


        private void menu_CopyInfo_Click(object sender, EventArgs e)
        {
            int[] selectedRow = this.gridView1.GetSelectedRows();
            if (selectedRow == null || selectedRow.Length == 0)
                return;

            StringBuilder sbHeader = new StringBuilder();
            StringBuilder sb = new StringBuilder();

            if (selectedRow.Length == 1)
            {
                //单行复制的时候
                foreach (GridColumn gridCol in this.gridView1.Columns)
                {
                    if (gridCol.Visible)
                    {
                        sbHeader.AppendFormat("{0}：{1} \r\n", gridCol.Caption, this.gridView1.GetRowCellDisplayText(selectedRow[0], gridCol.FieldName));
                    }
                }
                sb.AppendLine();
            }
            else
            {
                //多行复制的时候
                foreach (GridColumn gridCol in this.gridView1.Columns)
                {
                    if (gridCol.Visible)
                    {
                        sbHeader.AppendFormat("{0}\t", gridCol.Caption);
                    }
                }

                foreach (int row in selectedRow)
                {
                    foreach (GridColumn gridCol in this.gridView1.Columns)
                    {
                        if (gridCol.Visible)
                        {
                            sb.AppendFormat("{0}\t", this.gridView1.GetRowCellDisplayText(row, gridCol.FieldName));
                        }
                    }
                    sb.AppendLine();
                }
            }

            Clipboard.SetText(sbHeader.ToString() + "\r\n" + sb.ToString());
        }

        private void menu_SetColumn_Click(object sender, EventArgs e)
        {
            FrmSelectColumnDisplay dlg = new FrmSelectColumnDisplay();
            dlg.DisplayColumNames = this.displayColumns;
            dlg.ColumnNameAlias = columnNameAlias;
            dlg.DataGridView = this.gridView1;
            dlg.ShowDialog();
        }
        #endregion

        #region 条件样式

        private void AddConditionDisplay()
        {

            if (DesignMode) return;
            if (this.GridView1.Columns.ColumnByFieldName("Is_destroy") != null)
            {
                DevExpress.XtraGrid.StyleFormatCondition Is_destroyCondition;
                Is_destroyCondition = new DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Equal, this.GridView1.Columns["Is_destroy"], true, "1", true, true);
                Is_destroyCondition.Appearance.Font = new Font(Font, FontStyle.Strikeout);
                this.GridView1.FormatConditions.Add(Is_destroyCondition);
            }
            else if (this.GridView1.Columns.ColumnByFieldName("New_flag") != null)
            {
                DevExpress.XtraGrid.StyleFormatCondition New_flagCondition;
                New_flagCondition = new DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Equal, this.GridView1.Columns["New_flag"], true, "1", true, true);
                New_flagCondition.Appearance.Font = new Font(Font, FontStyle.Bold);
                this.GridView1.FormatConditions.Add(New_flagCondition);
            }
            else if (this.GridView1.Columns.ColumnByFieldName("Is_checked") != null)
            {
                DevExpress.XtraGrid.StyleFormatCondition Is_check;
                Is_check = new DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Equal, this.GridView1.Columns["Is_checked"], true, true, true, true);
                Is_check.Appearance.BackColor = Color.Wheat;
                this.GridView1.FormatConditions.Add(Is_check);
            }



        }
        #endregion

        #region Loading
        private void WinGridView_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                //LicenseCheckResult result = LicenseTool.CheckLicense();
                this.contextMenuStrip1.Opening += new CancelEventHandler(contextMenuStrip1_Opening);
                this.gridControl1.MouseClick += new MouseEventHandler(dataGridView1_MouseClick);
                this.gridControl1.MouseDoubleClick += new MouseEventHandler(dataGridView1_MouseDoubleClick);
                this.gridView1.Appearance.EvenRow.BackColor = EventRowBackColor;


                this.gridView1.ColumnFilterChanged += gridView1_ColumnFilterChanged;
                if (!enableMenu)
                {
                    this.gridControl1.ContextMenuStrip = null;
                }
            }

        }
        #endregion

        #region CustomDrawFooterCell
        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (sumItem == null || sumItem.Count == 0) return;
            foreach (var item in sumItem.Values)
            {
                if (e.Column.FieldName == item.FieldName)
                {
                    try
                    {
                        e.Appearance.TextOptions.HAlignment = this.textHorzAlignment[item.FieldName];
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
        }
        #endregion
    }
}
