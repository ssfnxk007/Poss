using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using WHC.Framework.Commons;

using DevExpress.XtraEditors;
using WHC.Framework.Commons;

using System.Data;
using System.Windows.Forms;
using POSS.Entity;

namespace Erp.Base.UI
{
    public delegate void SelectedProductEventHandler(object sender,EventArgs e);
    public delegate bool SelectProductBeforeEventHander(object sender,EventArgs e );
    /// <summary>
    /// 商品录入控件
    /// </summary>
   public  class ProductInput:XtraUserControl
   {
       public event SelectedProductEventHandler ProductSelectAfter;//商品选择后处理事件
       public event SelectProductBeforeEventHander ProductSelectBefore;//商品检索之前发生

       #region 变量定义
       private int topCount = 100;   //默认检索行数
       private List<SimpleProductInfo> selectedProducts = new List<SimpleProductInfo>();//选择的商品列表
       private IContainer components;
       private TextBoxControl txt_Helpinput;
       private TextBoxControl txt_Isbn;
       private System.Windows.Forms.Label label1;
       private System.Windows.Forms.Label label2;
       private System.Windows.Forms.Label label3;
       private TextButtonControl txt_Name;
       private PanelControl panelControl1;
       private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");
       private bool readOnly = false;
       
       #endregion

       #region 属性



       /// <summary>
       /// 附加条件
       /// </summary>
       public string AddCondition { get; set; }


       public bool ReadOnly
       {
           get { return readOnly; }
           set
           {
               readOnly = value;
           }
       }

       /// <summary>
       /// 已选择的商品列表
       /// </summary>
       [Browsable(false)]
       [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

       public List<SimpleProductInfo> SelectedProducts
       {
           get { return selectedProducts; }
           set { selectedProducts = value; }
       }

       /// <summary>
       /// 最大检索行数,默认100
       /// </summary>
       [Browsable(false)]
       [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
       public int TopCount
       {
           get
           {
               string top = iniFile.IniReadValue(this.ParentForm.Name, "MaxRetrieve");
               if (string.IsNullOrWhiteSpace(top)) topCount = 100;
               return topCount;
           }
       } 
       #endregion

       #region InitializeComponent
       private void InitializeComponent()
       {
            this.components = new System.ComponentModel.Container();
            this.txt_Helpinput = new WHC.Framework.Commons.TextBoxControl();
            this.txt_Isbn = new WHC.Framework.Commons.TextBoxControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new WHC.Framework.Commons.TextButtonControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Helpinput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Isbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Helpinput
            // 
            this.txt_Helpinput.ChineseColumnName = null;
            this.txt_Helpinput.ColumnName = null;
            this.txt_Helpinput.Location = new System.Drawing.Point(148, 19);
            this.txt_Helpinput.Name = "txt_Helpinput";
            this.txt_Helpinput.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_Helpinput.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_Helpinput.Properties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHelp_input_Properties_KeyDown);
            this.txt_Helpinput.Size = new System.Drawing.Size(146, 20);
            this.txt_Helpinput.TabIndex = 9;
            this.txt_Helpinput.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            this.txt_Helpinput.QueryModeChanged += new WHC.Framework.Commons.QueryModeChangedEventHandler(this.txt_Helpinput_QueryModeChanged);
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.ChineseColumnName = null;
            this.txt_Isbn.ColumnName = null;
            this.txt_Isbn.EditValue = "";
            this.txt_Isbn.Location = new System.Drawing.Point(2, 19);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Properties.MaxLength = 15;
            this.txt_Isbn.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_Isbn.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_Isbn.Properties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIsbn_Properties_KeyDown);
            this.txt_Isbn.Size = new System.Drawing.Size(145, 20);
            this.txt_Isbn.TabIndex = 8;
            this.txt_Isbn.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            this.txt_Isbn.QueryModeChanged += new WHC.Framework.Commons.QueryModeChangedEventHandler(this.txt_Isbn_QueryModeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "条码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "谐音";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "商品名称";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.ChineseColumnName = null;
            this.txt_Name.ColumnName = null;
            this.txt_Name.Location = new System.Drawing.Point(295, 19);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_Name.Properties.NullValuePrompt = "F4键切换查询模式";
            this.txt_Name.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_Name.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_Name_Properties_ButtonClick);
            this.txt_Name.Properties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Name_Properties_KeyDown);
            this.txt_Name.Size = new System.Drawing.Size(146, 20);
            this.txt_Name.TabIndex = 12;
            this.txt_Name.ToolTip = "包含模糊查询,如:Like \'%ABC%\'";
            this.txt_Name.QueryModeChanged += new WHC.Framework.Commons.QueryModeChangedEventHandler(this.txt_Name_QueryModeChanged);
            this.txt_Name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_Name_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txt_Name);
            this.panelControl1.Controls.Add(this.txt_Isbn);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txt_Helpinput);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(443, 41);
            this.panelControl1.TabIndex = 13;
            // 
            // ProductInput
            // 
            this.Controls.Add(this.panelControl1);
            this.Name = "ProductInput";
            this.Size = new System.Drawing.Size(443, 41);
            this.Load += new System.EventHandler(this.ProductInput_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.layoutControl1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Helpinput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Isbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

       }
       
       #endregion
       public ProductInput()
       {
           InitializeComponent();
       }

       private void txtHelp_input_Properties_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
       {
           if (readOnly) return;
           if (e.KeyCode == System.Windows.Forms.Keys.Enter && !string.IsNullOrWhiteSpace(txt_Helpinput.Text))
           {
               SeachProduct(txt_Helpinput.Syntax());
               txt_Helpinput.ResetText();
           }
           this.layoutControl1_KeyDown(txt_Helpinput, e);
       }

       private void txtIsbn_Properties_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
       {
           if (readOnly) return;
           if (e.KeyCode == System.Windows.Forms.Keys.Enter && !string.IsNullOrWhiteSpace(txt_Isbn.Text))
           {
               SeachProduct(txt_Isbn.Syntax());
               txt_Isbn.ResetText();
           }
           this.layoutControl1_KeyDown(txt_Isbn, e);
       }

       private void txt_Name_Properties_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
       {
           if (readOnly) return;
           if (e.KeyCode == System.Windows.Forms.Keys.Enter && !string.IsNullOrWhiteSpace(txt_Name.Text))
           {
               SeachProduct(txt_Name.Syntax());
               txt_Name.ResetText();
           }
           this.layoutControl1_KeyDown(txt_Name, e);
       }

       private void layoutControl1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
       {
           if (e.KeyCode == System.Windows.Forms.Keys.F1)
           {
               this.txt_Isbn.Focus();
           }
           else if (e.KeyCode == System.Windows.Forms.Keys.F2)
           {
               this.txt_Helpinput.Focus();
           }
           else if (e.KeyCode == System.Windows.Forms.Keys.F3)
           {
               this.txt_Name.Focus();
           }
       }

       /// <summary>
       /// 检索商品
       /// </summary>
       /// <param name="strWhere">检索条件</param>
       public void SeachProduct(string strWhere)
       {
           //if (txt_Isbn.Text == "+".ToString().Trim())
           //{
           //    FrmEditProduct product = new FrmEditProduct();
           //    product.rowIndex = -1;
           //    product.ShowDialog();
           //    selectedProducts.Clear();
           //    selectedProducts.Add(product.GetNewProduct());
           //    if (selectedProducts.Count > 0)
           //    {
           //        if (ProductSelectAfter != null)
           //        {
           //            ProductSelectAfter(this.selectedProducts, new EventArgs());
           //        }
           //    }
           //    return;
           //}
           //else
           //{
           //    if (this.ProductSelectBefore != null)
           //    {
           //        if (!this.ProductSelectBefore(this, new EventArgs()))
           //        {
           //            this.txt_Isbn.ResetText();
           //            this.txt_Name.ResetText();
           //            this.txt_Helpinput.ResetText();
           //            return;
           //        }
           //    }

           //    if (string.IsNullOrWhiteSpace(strWhere)) return;
           //    this.selectedProducts.Clear();//清空检索商品列表
           //     selectedProducts = null;// CallerFactory<IProductService>.Instance.SeachProduct(string.Format("{0} {1} ", strWhere, string.IsNullOrEmpty(AddCondition) ? "" : string.Format(" AND {0}", AddCondition)), TopCount, Portal.gc.LoginStationInfo.Station_id);
           //    if (selectedProducts != null)
           //    {

           //        if (selectedProducts.Count > 1) //检索出的商品数量大于1,打开商品选择窗口
           //        {
                       
           //            SelectProductInfo spi = new SelectProductInfo();
           //            spi.ProductList = selectedProducts;
           //            spi.ShowDialog();
           //            this.selectedProducts = spi.SelectedList;
           //            spi.Dispose();
           //        }
           //        else if (selectedProducts.Count == 0) //检索出的商品数量为0,提示用户新增
           //        {
           //            DialogResult dr = MessageDxUtil.ShowYesNoAndTips("没有查询到你要的商品，现在是否【新增】?");
           //            if (dr == DialogResult.Yes)
           //            {
           //                FrmEditProduct product = new FrmEditProduct();
           //                product.rowIndex = -1;
           //                product.h_isbn = txt_Isbn.Text.Trim();
           //                product.ShowDialog();
           //                if (product.DialogResult == DialogResult.OK)
           //                {
           //                    selectedProducts.Clear();
           //                    selectedProducts.Add(product.GetNewProduct());
                               
           //                }
           //            }

           //        }

           //    }


           //    if (selectedProducts.Count > 0)
           //    {
           //        if (ProductSelectAfter != null)
           //        {
           //            ProductSelectAfter(this.selectedProducts, new EventArgs());
           //        }
           //    }
           //}
       }

       private string  GetBarCodeSql(string strWhere)
       {
           if (strWhere.Contains("db_product.h_isbn"))
           {
               return strWhere.Replace("db_product.h_isbn", "db_product.h_mytm");
           }
           return strWhere;
       }

       private void AddProduct(string newValue)
       { 
        
       }
       private void ProductInput_Load(object sender, EventArgs e)
       {
           if (!DesignMode)
           { 
               this.txt_Isbn.ColumnName = "db_product.h_isbn";
               this.txt_Name.ColumnName = "db_product.h_name";
               this.txt_Helpinput.ColumnName = "db_product.my_help_input";
               InitQueryMode();
           }


       }

       private void txt_Isbn_QueryModeChanged(object sender, EventArgs e)
       {
           try
           {
               iniFile.IniWriteValue(this.ParentForm.Name, "ISBN", ((SqlOperator)sender).ToString());
           }
           catch (Exception)
           {
           }
       }

       private void txt_Helpinput_QueryModeChanged(object sender, EventArgs e)
       {
           try
           {
               iniFile.IniWriteValue(this.ParentForm.Name, "HelpInput", ((SqlOperator)sender).ToString());
           }
           catch (Exception)
           {
           }
       }

       private void txt_Name_QueryModeChanged(object sender, EventArgs e)
       {
           try
           {
               iniFile.IniWriteValue(this.ParentForm.Name, "Name", ((SqlOperator)sender).ToString());
           }
           catch (Exception)
           {
           }
       }
       /// <summary>
       /// 加载查询模式
       /// </summary>
       private void InitQueryMode()
       {
           string mode = iniFile.IniReadValue(ParentForm.Name, "ISBN");
           if (!string.IsNullOrWhiteSpace(mode))
           {
               txt_Isbn.CurrentOperator = EnumHelper.GetInstance<SqlOperator>(mode);
           }
           mode = iniFile.IniReadValue(ParentForm.Name, "HelpInput");
           if (!string.IsNullOrWhiteSpace(mode))
           {
               txt_Helpinput.CurrentOperator = EnumHelper.GetInstance<SqlOperator>(mode);
           }
           mode = iniFile.IniReadValue(ParentForm.Name, "Name");
           if (!string.IsNullOrWhiteSpace(mode))
           {
               txt_Name.CurrentOperator = EnumHelper.GetInstance<SqlOperator>(mode);
           }
       }


       private void txt_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
       {
          
       }

       private void txt_Name_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
       {
           if (this.ProductSelectBefore != null)
           {
               if (!this.ProductSelectBefore(this, new EventArgs()))
               {
                   this.txt_Isbn.ResetText();
                   this.txt_Name.ResetText();
                   this.txt_Helpinput.ResetText();
                   return;
               }
           }


           selectedProducts.Clear();
           QueryProduct qp = new QueryProduct();
          // qp.ShowDialog();
         //  selectedProducts = qp.selectlist;
           if (selectedProducts.Count > 0)
           {
               if (ProductSelectAfter != null)
               {
                   ProductSelectAfter(this.selectedProducts, new EventArgs());
               }
           }
       }
   }
}
