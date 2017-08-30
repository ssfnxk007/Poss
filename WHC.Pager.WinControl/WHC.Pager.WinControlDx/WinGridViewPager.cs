﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;

using WHC.Pager.Entity;
using WHC.Pager.WinControl;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.Utils.Design;
using DevExpress.Utils.Editors;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using WHC.Framework.Commons;

namespace WHC.Pager.WinControl
{
    /// <summary>
    /// 待分页导航的分页控件
    /// </summary>
    public partial class WinGridViewPager : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// 是否显示CheckBox列
        /// </summary>
        public bool ShowCheckBox { get; set; }

        private object dataSource;//数据源
        private string displayColumns = "";//显示的列
        private string printTitle = "";//报表标题

        private PagerInfo pagerInfo = null;
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private bool isExportAllPage = false;//是否导出所有页
        private Dictionary<string, string> columnNameAlias = new Dictionary<string, string>();//字段别名字典集合
        private ContextMenuStrip appendedMenu;//右键菜单
        private bool m_ShowExportButton = true;//是否显示导出按钮
        private bool m_ShowAddMenu = true;//是否显示新建菜单
        private bool m_ShowEditMenu = true;//是否显示编辑菜单
        private bool m_ShowDeleteMenu = true;//是否显示删除菜单
        private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.Ini");
        private Dictionary<System.Guid, FooterItem> sumItem = new Dictionary<System.Guid, FooterItem>();//需要汇总的列集合
        private Dictionary<string, string> formatString = new Dictionary<string, string>();//列格式集合
        private Dictionary<string, int> columnDict = new Dictionary<string, int>();//字段列顺序
        private List<string> readOnlyList = new List<string>(); //只读字段列表

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
        /// 是否显示表格页脚
        /// </summary>
        [Description("是否显示表格页脚")]
        [DefaultValue(false)]
        public bool ShowFooter
        {
            get { return gridView1.OptionsView.ShowFooter; }
            set { gridView1.OptionsView.ShowFooter = value; }
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
   

        #region 菜单显示文本
        /// <summary>
        /// 新建菜单的显示内容
        /// </summary>
        public string AddMenuText = "新建(&N)";
        /// <summary>
        /// 编辑菜单的显示内容
        /// </summary>
        public string EditMenuText = "编辑选定项(&E)";
        /// <summary>
        /// 删除菜单的显示内容
        /// </summary>
        public string DeleteMenuText = "删除选定项(&D)";
        /// <summary>
        /// 刷新菜单的显示内容
        /// </summary>
        public string RefreshMenuText = "刷新列表(&R)"; 
        #endregion

        /// <summary>
        /// 导出全部的数据源
        /// </summary>
        public object AllToExport;

        /// <summary>
        /// 是否显示行号
        /// </summary>
        public bool ShowLineNumber = false;
        /// <summary>
        /// 获取或设置奇数行的背景色
        /// </summary>
        public Color EventRowBackColor = Color.LightCyan;

        /// <summary>
        /// 是否使用最佳宽度
        /// </summary>
        public bool BestFitColumnWith = true;

        #region 权限功能控制
        /// <summary>
        /// 是否显示导出按钮
        /// </summary>
        [Category("分页"), Description("是否显示导出按钮。"), Browsable(true)]
        public bool ShowExportButton
        {
            get { return m_ShowExportButton; }
            set
            {
                m_ShowExportButton = value;
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
            string text = iniFile.IniReadValue(this.ParentForm.Name, this.Name);
            if (string.IsNullOrWhiteSpace(text)) return;
            string[] values = text.Split(',');
            if (values.Length == 0) return;
            foreach (string s in values)
            {
                string[] s1 = s.Split('/');
                if (s1.Length == 0) continue;
                try
                {
                    this.GridView1.Columns[s1[0]].Width = Convert.ToInt32(s1[1]);
                    this.GridView1.Columns[s1[0]].VisibleIndex = Convert.ToInt32(s1[2]);
                    this.GridView1.Columns[s1[0]].Visible = Convert.ToBoolean(s1[3]);
                }
                catch (Exception)
                {
                    continue;
                }
            }

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
                    this.gridView1.Columns[sumItem[key].FieldName].Summary.Add(DevExpress.Data.SummaryItemType.Sum, sumItem[key].FieldName, string.Format("{{0:{0}}}", sumItem[key].Format));
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
        /// 页面变化的操作
        /// </summary>
        public event EventHandler OnPageChanged;
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
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public WinGridViewPager()
        {
            InitializeComponent();
        }

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
        }

        /// <summary>
        /// 封装的GridView对象
        /// </summary>
        public GridView GridView1
        {
            get
            {
                return this.gridView1;
            }
        }

        private void pager_PageChanged(object sender, EventArgs e)
        {
            if (OnPageChanged != null)
            {
                OnPageChanged(this, new EventArgs());
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
                }

                dataSource = value;
                this.gridControl1.DataSource = dataSource;
                this.pager.InitPageInfo(PagerInfo.RecordCount, PagerInfo.PageSize);
            }
        }
        
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
        /// 返回对应字段的显示顺序，如果没有，返回-1
        /// </summary>
        /// <param name="columnName"></param>
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

        /// <summary>
        /// 分页信息
        /// </summary>
        public PagerInfo PagerInfo
        {
            get
            {
                if (pagerInfo == null)
                {
                    pagerInfo = new PagerInfo();
                    pagerInfo.RecordCount = this.pager.RecordCount;
                    pagerInfo.CurrenetPageIndex = this.pager.CurrentPageIndex;
                    pagerInfo.PageSize = this.pager.PageSize;
                }
                else
                {
                    pagerInfo.CurrenetPageIndex = this.pager.CurrentPageIndex;
                }

                return pagerInfo;
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
        /// 导出所有记录的事件
        /// </summary>
        private void pager_ExportAll(object sender, EventArgs e)
        {
            isExportAllPage = true;
            ExportToExcel();
        }

        /// <summary>
        /// 导出当前页记录的事件
        /// </summary>
        private void pager_ExportCurrent(object sender, EventArgs e)
        {
            isExportAllPage = false;
            ExportToExcel();
        }

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

        #region 菜单操作
        private void menu_Delete_Click(object sender, EventArgs e)
        {
            if (OnDeleteSelected != null && this.ShowDeleteMenu)
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
            if (OnEditSelected != null && this.ShowEditMenu)
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
            if (this.OnAddNew != null && this.ShowAddMenu)
            {
                this.OnAddNew(this.gridView1, new EventArgs());
            }
        } 

        private void menu_Buy_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.iqidi.com");
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
                this.gridView1.IndicatorWidth = 40;
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
                this.gridView1.OptionsBehavior.Editable = true;
                this.gridView1.OptionsBehavior.ReadOnly = false;
            }

            //从配置文件中加载列宽度等
            this.LoadGridParm();

            //显示页脚
            AddSumFooter();

            //添加格式化字符串
            AddFormatString();

            //列只读属性
            SetReadOnly();
        }

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
        }

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

        private void WinGridViewPager_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.pager.PageChanged += new PageChangedEventHandler(pager_PageChanged);
                this.pager.ExportCurrent += new ExportCurrentEventHandler(pager_ExportCurrent);
                this.pager.ExportAll += new ExportAllEventHandler(pager_ExportAll);

                LicenseCheckResult result = LicenseTool.CheckLicense();
                if (result.IsValided)
                {
                    menu_Buy.Visible = false;
                }
                this.contextMenuStrip1.Opening += new CancelEventHandler(contextMenuStrip1_Opening);
                this.gridControl1.MouseClick += new MouseEventHandler(dataGridView1_MouseClick);
                this.gridControl1.MouseDoubleClick += new MouseEventHandler(dataGridView1_MouseDoubleClick);

                this.gridView1.Appearance.EvenRow.BackColor = EventRowBackColor;                
            }

            this.pager.ShowExportButton = this.ShowExportButton;
        }

        private void menu_ColumnWidth_Click(object sender, EventArgs e)
        {
            this.BestFitColumnWith = !this.BestFitColumnWith;
            ShowWidthStatus();
            if (OnRefresh != null)
            {
                OnRefresh(sender, e);
            }
        }

        private void ShowWidthStatus()
        {
            if (this.BestFitColumnWith)
            {
                this.menu_ColumnWidth.Text = "设置列固定宽度(&W)";
            }
            else
            {
                this.menu_ColumnWidth.Text = "设置列自动适应宽度(&W)";
            }
        }

    }
}
