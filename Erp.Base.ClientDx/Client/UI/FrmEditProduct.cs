using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using WHC.Pager.Entity;
using WHC.Dictionary;
using WHC.Dictionary.UI.Client;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using WHC.Framework.ControlUtil.Facade;
using Erp.Base.ServiceCaller;
using Erp.Base.Facade;
using Erp.Base.Entity;

namespace Erp.Base.UI
{
    public partial class FrmEditProduct : BaseEditForm
    {
    	/// <summary>
        /// 创建一个临时对象，方便在附件管理中获取存在的GUID
        /// </summary>
    	private ProductInfo tempInfo = new ProductInfo();

        private Product_discountInfo tempdiscountInfo = new Product_discountInfo();
        public string h_isbn = string.Empty;
        public FrmEditProduct()
        {
            InitializeComponent();
            InitLookUpEditItem();
            
        }

        #region 静态调用
        public static object ShowEditProduct(string h_id)
        {
            List<string> IdList = new List<string>();
            IdList.Add(h_id);
            FrmEditProduct fce = new FrmEditProduct();
            fce.Text = "商品基本数据";
            fce.rowIndex = 1;
            fce.ID = h_id;
            fce.tempInfo = CallerFactory<IProductService>.Instance.FindByID(h_id); 
            fce.ShowDialog();
            fce.Dispose();
            return fce.tempInfo;
        }

        #endregion

        #region 初始化

        private void InitLookUpEditItem()
        {
            this.txtIsbn_class.EditValue = string.Empty;
            this.txtKb_id.EditValue = string.Empty;
            this.txtPub_id.EditValue = string.Empty;
            this.txtFlag_sales_class.EditValue = string.Empty;
            this.txtH_type.EditValue = string.Empty;
            this.txtSales_type.EditValue = string.Empty;
            this.txtPrice_system.EditValue = string.Empty;
            this.txtH_banci.EditValue = string.Empty;
            this.txto_id_lastgr.EditValue = string.Empty;
            this.txtIs_my.EditValue = string.Empty;
            this.txtIs_focus.EditValue = string.Empty;
            this.txtU_id.EditValue = string.Empty;
            this.txtKb_id.EditValue = string.Empty;
            this.txtH_factory.EditValue = string.Empty;
            this.txtH_taozhuang.EditValue = string.Empty;
            this.txtH_run_style.EditValue = string.Empty;
            this.txtYz_id.EditValue = string.Empty;
            this.txtH_media.EditValue = string.Empty;
            this.txtH_bak1.EditValue = string.Empty;
            this.txtH_bak2.EditValue = string.Empty;
            this.txtH_serial_book.EditValue = string.Empty;
            this.txtBz_id.EditValue = string.Empty;
            this.txtZz_id.EditValue = string.Empty;
            this.txtH_exist.EditValue = string.Empty;
            this.txtSales_level.EditValue = string.Empty;
            this.txtH_id_other.EditValue = string.Empty;
            this.txtYylb_id.EditValue = string.Empty;
            this.txtH_serial_book.EditValue = string.Empty;
            this.txtO_id_input.EditValue = string.Empty;
            this.txtO_id_lastmodify.EditValue = string.Empty;


        } 
        #endregion
                
        /// <summary>
        /// 实现控件输入检查的函数
        /// </summary>
        /// <returns></returns>
        public override bool CheckInput()
        {
            bool result = true;//默认是可以通过

            #region MyRegion
            if (this.txtH_isbn.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入商品编号");
                this.txtH_isbn.Focus();
                result = false;
            }
            else if (this.txtIsbn_class.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择中图分类");
                this.txtIsbn_class.Focus();
                result = false;
            }
            else if (this.txtPub_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择出版社");
                this.txtPub_id.Focus();
                result = false;
            }
            else if (this.txtH_name.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入商品名称");
                this.txtH_name.Focus();
                result = false;
            }
            else if (this.txtH_output_price.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入定价");
                this.txtH_output_price.Focus();
                result = false;
            }
            else if (this.txtYylb_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择营业类别");
                this.txtYylb_id.Focus();
                result = false;
            }
            else if (this.txtFlag_sales_class.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择商品属性");
                this.txtFlag_sales_class.Focus();
                result = false;
            }
            else if (this.txtH_type.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择商品分类");
                this.txtH_type.Focus();
                result = false;
            }


          if (this.txtH_output_price.EditValue.ToString() == string.Empty || this.txtH_output_price.EditValue.ToString() == "¥0.00")
            {
                if (MessageDxUtil.ShowYesNoAndTips("商品售价为¥0.00，是否确定保存？") == System.Windows.Forms.DialogResult.Yes)
                    result = true;
                else
                {
                    this.txtH_output_price.Focus();
                    result = false;
                }

            }
        
            #endregion

            return result;
        }

        /// <summary>
        /// 初始化数据字典
        /// </summary>
        private void InitDictItem()
        {
            #region 字典
            //初始化代码
            this.txtIs_focus.BindData("显示值", "项目值", WHC.Dictionary.DictItemUtil.YesOrNoByEditor());

            this.txtIs_my.Properties.DisplayMember = "显示值";
            this.txtIs_my.Properties.ValueMember = "项目值";
            this.txtIs_my.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtAvoid_Flag.Properties.DisplayMember = "显示值";
            this.txtAvoid_Flag.Properties.ValueMember = "项目值";
            this.txtAvoid_Flag.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtIsbn_class.Properties.DisplayMember = "显示值";
            this.txtIsbn_class.Properties.ValueMember = "项目值";
            this.txtIsbn_class.Properties.DataSource = WHC.Dictionary.DictItemUtil.Isbn_ClassByEditor();

            this.txtPub_id.Properties.DisplayMember = "显示值";
            this.txtPub_id.Properties.ValueMember = "项目值";
            this.txtPub_id.Properties.DataSource = BaseUtil.PublishByEditor();

            this.txtH_type.Properties.DataSource = BaseUtil.H_TypeByEditor();


            this.txtFlag_sales_class.Properties.DisplayMember = "显示值";
            this.txtFlag_sales_class.Properties.ValueMember = "项目值";
            this.txtFlag_sales_class.Properties.DataSource = WHC.Dictionary.DictItemUtil.Flag_Sales_ClassByEditor();

            this.txtSales_level.Properties.DisplayMember = "显示值";
            this.txtSales_level.Properties.ValueMember = "项目值";
            this.txtSales_level.Properties.DataSource = WHC.Dictionary.DictItemUtil.Sales_levelByEditor();

            this.txtPrice_system.Properties.DisplayMember = "显示值";
            this.txtPrice_system.Properties.ValueMember = "项目值";
            this.txtPrice_system.Properties.DataSource = WHC.Dictionary.DictItemUtil.Price_systembyEditor();

            this.txto_id_lastgr.Properties.DisplayMember = "显示值";
            this.txto_id_lastgr.Properties.ValueMember = "项目值";
            this.txto_id_lastgr.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtSales_type.Properties.DisplayMember = "显示值";
            this.txtSales_type.Properties.ValueMember = "项目值";
            this.txtSales_type.Properties.DataSource = WHC.Dictionary.DictItemUtil.Sales_ClassByEditor();

            this.txtU_id.Properties.DisplayMember = "显示值";
            this.txtU_id.Properties.ValueMember = "项目值";
            this.txtU_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.U_idByEditor();

            this.txtKb_id.Properties.DisplayMember = "显示值";
            this.txtKb_id.Properties.ValueMember = "项目值";
            this.txtKb_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Kb_idByEditor();

            this.txtH_run_style.Properties.DisplayMember = "显示值";
            this.txtH_run_style.Properties.ValueMember = "项目值";
            this.txtH_run_style.Properties.DataSource = WHC.Dictionary.DictItemUtil.Sale_StyleByEditor();

            this.txtH_factory.Properties.DisplayMember = "显示值";
            this.txtH_factory.Properties.ValueMember = "项目值";
            this.txtH_factory.Properties.DataSource = BaseUtil.F_idByEditor();


            this.txtYz_id.Properties.DisplayMember = "显示值";
            this.txtYz_id.Properties.ValueMember = "项目值";
            this.txtYz_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Yz_idByEditor();


            this.txtH_media.Properties.DisplayMember = "显示值";
            this.txtH_media.Properties.ValueMember = "项目值";
            this.txtH_media.Properties.DataSource = WHC.Dictionary.DictItemUtil.H_mediaByEditor();


            this.txtH_banci.Properties.DisplayMember = "显示值";
            this.txtH_banci.Properties.ValueMember = "项目值";
            this.txtH_banci.Properties.DataSource = WHC.Dictionary.DictItemUtil.Banci_idByEditor();


            this.txtH_bak1.Properties.DisplayMember = "显示值";
            this.txtH_bak1.Properties.ValueMember = "项目值";
            this.txtH_bak1.Properties.DataSource = WHC.Dictionary.DictItemUtil.Bak1ByEditor();


            this.txtH_bak2.Properties.DisplayMember = "显示值";
            this.txtH_bak2.Properties.ValueMember = "项目值";
            this.txtH_bak2.Properties.DataSource = WHC.Dictionary.DictItemUtil.Bak2ByEditor();

            this.txtH_taozhuang.Properties.DisplayMember = "显示值";
            this.txtH_taozhuang.Properties.ValueMember = "项目值";
            this.txtH_taozhuang.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtH_exist.Properties.DisplayMember = "显示值";
            this.txtH_exist.Properties.ValueMember = "项目值";
            this.txtH_exist.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtH_serial_book.Properties.DisplayMember = "显示值";
            this.txtH_serial_book.Properties.ValueMember = "项目值";
            this.txtH_serial_book.Properties.DataSource = WHC.Dictionary.DictItemUtil.Serial_bookByEditor();


            this.txtZz_id.Properties.DisplayMember = "显示值";
            this.txtZz_id.Properties.ValueMember = "项目值";
            this.txtZz_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.ZhuangzhenByEditor();

            this.txtBz_id.Properties.DisplayMember = "显示值";
            this.txtBz_id.Properties.ValueMember = "项目值";
            this.txtBz_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.PackageByEditor();

            this.txtH_id_other.Properties.DisplayMember = "显示值";
            this.txtH_id_other.Properties.ValueMember = "项目值";
            this.txtH_id_other.Properties.DataSource = BaseUtil.H_idByEditor();

            this.txtYylb_id.Properties.DisplayMember = "项目值";
            this.txtYylb_id.Properties.ValueMember = "显示值";
            this.txtYylb_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.YylbByEditor();

            this.txtO_id_input.Properties.DisplayMember = "显示值";
            this.txtO_id_input.Properties.ValueMember = "项目值";
            this.txtO_id_input.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_lastmodify.Properties.DisplayMember = "显示值";
            this.txtO_id_lastmodify.Properties.ValueMember = "项目值";
            this.txtO_id_lastmodify.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            
            #endregion
        }                        

        /// <summary>
        /// 数据显示的函数
        /// </summary>
        public override void DisplayData()
        {
    #region 显示信息

            if (MasterView != null && tempdiscountInfo != null)
            {
                object o = MasterView.GetFocusedRow() as ProductInfo;
                if( o!=null)
                {
                    tempInfo = o as ProductInfo;
                }
            }
            
            if (tempInfo != null)
            {

                txtH_id.Text = tempInfo.H_id;
                tempdiscountInfo.H_id = tempInfo.H_id;
                tempdiscountInfo = CallerFactory<IProduct_discountService>.Instance.FindByID(tempdiscountInfo.H_id);
                txtH_type.EditValue = tempInfo.H_type;
                txtH_name.Text = tempInfo.H_name;
                txtH_run_style.EditValue = tempInfo.H_run_style;
                txtU_id.EditValue = tempInfo.U_id;
                txtBz_id.EditValue = tempInfo.Bz_id;
                txtH_mem.Text = tempInfo.H_mem;
                txtH_factory.EditValue = tempInfo.H_factory;
                txtH_exist.EditValue = tempInfo.H_exist;
                txtH_isbn.Text = tempInfo.H_isbn;
                txtH_input_price.EditValue = tempInfo.H_input_price;
                txtH_output_price.EditValue = tempInfo.H_output_price;
                txtPub_id.EditValue = tempInfo.Pub_id;
                txtH_mytm.Text = tempInfo.H_mytm;
                txtH_writer.Text = tempInfo.H_writer;
                txtH_translator.Text = tempInfo.H_translator;
                txtKb_id.EditValue = tempInfo.Kb_id;
                txtZz_id.EditValue = tempInfo.Zz_id;
                txtH_banci.EditValue = tempInfo.H_banci;
                txtH_taozhuang.EditValue = tempInfo.H_taozhuang;
                txtH_bak1.EditValue = tempInfo.H_bak1;
                txtH_bak2.EditValue = tempInfo.H_bak2;
                txtH_publish_date.Text = tempInfo.H_publish_date.ToShortDateString();
                txtMy_help_input.Text = tempInfo.My_help_input;
                txtH_word_number.Text = tempInfo.H_word_number.ToString();
                txtH_serial_book.EditValue = tempInfo.H_serial_book;
                txtH_yin_number.Text = tempInfo.H_yin_number.ToString();
                txtH_input_date.Text = tempInfo.H_input_date.ToString("yyyy-MM-dd HH:mm:ss");
                txtH_weight.Text = tempInfo.H_weight.ToString();
                txtH_height.Text = tempInfo.H_height.ToString();
                txtYylb_id.EditValue = tempInfo.Yylb_id;
                txtH_hopesell.Text = tempInfo.H_hopesell.ToShortDateString();
                txtIsbn_class.EditValue = tempInfo.Isbn_class;
                txtIs_my.EditValue = tempInfo.Is_my;
                txtIs_focus.EditValue = tempInfo.Is_focus;
                txtYz_id.EditValue = tempInfo.Yz_id;
                txtH_period_id.Text = tempInfo.H_period_id;
                txtH_media.EditValue = tempInfo.H_media;
                txtFlag_sales_class.EditValue = tempInfo.Flag_sales_class;
                txtInside_id.Text = tempInfo.Inside_id;
                txtSales_type.EditValue = tempInfo.Sales_type;
                txtImmobility_cost.EditValue = tempInfo.Immobility_cost;
                txtImmobility_cost_other.EditValue = tempInfo.Immobility_cost_other;
                txto_id_lastgr.EditValue = tempInfo.O_id_lastgr;
                txtPri_sheetcount.Text = tempInfo.Pri_sheetcount.ToString();
                txtPri_times.Text = tempInfo.Pri_times.ToString();
                txtPrice_system.EditValue = tempInfo.Price_system;
                txtSales_level.EditValue = tempInfo.Sales_level;
                txtH_id_other.EditValue = tempInfo.H_id_other;
                txtProduct_up.Text = tempInfo.Product_up.ToString();
                txtProduct_down.Text = tempInfo.Product_down.ToString();
                //txtdiscount_hy.EditValue = tempInfo.Discount_hy;
                //txtdiscount_ls.EditValue = tempInfo.Discount_ls;
                //txtdiscount_px.EditValue = tempInfo.Discount_px;
                //txtprice_ls.EditValue = tempInfo.Price_ls;
                //txtprice_px.EditValue = tempInfo.Price_px;
                //txtHy_price.EditValue = tempInfo.Price_hy;
                txtLast_mod_date.Text = tempInfo.Last_mod_date.ToString("yyyy-MM-dd HH:mm:ss");
                this.txtO_id_lastmodify.EditValue = Portal.gc.LoginUserInfo.O_id;
                this.txtO_id_input.EditValue = tempInfo.O_id_input;
                txtAvoid_Flag.EditValue = tempInfo.Avoid_flag;

                txtHy_price.EditValue = tempdiscountInfo.H_local_price_hy;
                txtprice_px.EditValue = tempdiscountInfo.H_local_price_px;
                txtprice_ls.EditValue = tempdiscountInfo.H_local_price_ls;

                txtdiscount_hy.EditValue = tempdiscountInfo.H_output_discount_member_ls;
                txtdiscount_px.EditValue = tempdiscountInfo.H_output_discount;
                txtdiscount_ls.EditValue = tempdiscountInfo.H_output_discount_ls;

            }
                #endregion
            //this.btnOK.Enabled = Portal.gc.HasFunction("Product/Edit");             


        }

        private void SetDefaultValue()
        {
            txtH_exist.EditValue = "1";
            txtFlag_sales_class.EditValue = "0";
            if (this.h_isbn != null)
            {
                txtH_isbn.Text = this.h_isbn;
            }
        }
      
        public override void ClearScreen()
        {
            this.tempInfo = new ProductInfo();
            this.tempdiscountInfo = new Product_discountInfo();

            base.ClearScreen();
        }

        /// <summary>
        /// 编辑或者保存状态下取值函数
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(ProductInfo info,Product_discountInfo disInfo)
        {      
               info.H_id = txtH_id.Text;
               disInfo.H_id = info.H_id;
               info.H_type = txtH_type.EditValue.ToString();
               info.H_name = txtH_name.Text;
               info.H_run_style = txtH_run_style.EditValue.ToString();
               info.U_id = txtU_id.EditValue.ToString();
               info.Bz_id = txtBz_id.EditValue.ToString();
               info.H_package_ammount =Convert.ToInt32(txtH_package_ammount.Text);
               info.H_mem = txtH_mem.Text;
               info.H_factory = txtH_factory.EditValue.ToString();
               info.H_exist = txtH_exist.EditValue.ToString();
               info.H_isbn = txtH_isbn.Text;
               info.H_input_price = txtH_input_price.EditValue.ToString().ToDecimal();
               info.H_output_price = txtH_output_price.EditValue.ToString().ToDecimal();
               info.Pub_id = txtPub_id.EditValue.ToString();
               info.H_mytm = txtH_mytm.Text;
               info.H_writer = txtH_writer.Text;
               info.H_translator = txtH_translator.Text;
               info.Kb_id = txtKb_id.EditValue.ToString();
               info.Zz_id = txtZz_id.EditValue.ToString();
               info.H_banci = txtH_banci.EditValue.ToString();
               info.H_taozhuang = txtH_taozhuang.EditValue.ToString();
               info.H_bak1 = txtH_bak1.EditValue.ToString();
               info.H_bak2 = txtH_bak2.EditValue.ToString();
               info.H_publish_date = txtH_publish_date.DateTime;
               info.My_help_input = txtMy_help_input.Text;
               info.H_word_number = txtH_word_number.EditValue.ToString().ToInt32();
               info.H_serial_book = txtH_serial_book.EditValue.ToString();
               info.H_yin_number = txtH_yin_number.EditValue.ToString().ToInt32();
               
               info.H_weight = txtH_weight.Text.ToInt32();
               info.H_height = txtH_height.Text.ToInt32();
               info.Yylb_id = txtYylb_id.EditValue.ToString();
               info.H_hopesell = txtH_hopesell.DateTime;
               info.Isbn_class = txtIsbn_class.EditValue.ToString();
               info.Is_my = txtIs_my.EditValue.ToString();
               info.Is_focus = txtIs_focus.EditValue.ToString();
               info.Yz_id = txtYz_id.EditValue.ToString();
               info.H_period_id = txtH_period_id.Text;
               info.H_media = txtH_media.EditValue.ToString();
               info.Flag_sales_class = txtFlag_sales_class.EditValue.ToString();
               info.Last_mod_date = txtLast_mod_date.Text.ToDateTime();
               info.Inside_id = txtInside_id.Text;
               info.Sales_type = txtSales_type.EditValue.ToString();
               info.Immobility_cost = txtImmobility_cost.Text.ToDecimal();
               info.Immobility_cost_other = txtImmobility_cost_other.Text.ToDecimal();
               info.O_id_lastmodify = txtO_id_lastmodify.EditValue.ToString();
               info.Pri_sheetcount = txtPri_sheetcount.Text.ToInt32();
               info.Pri_times = txtPri_times.Text.ToInt32();
               info.O_id_input = txtO_id_input.EditValue.ToString();
               info.Price_system = txtPrice_system.EditValue.ToString();
               info.Sales_level = txtSales_level.EditValue.ToString();
               info.H_id_other = txtH_id_other.EditValue.ToString();
               info.Product_up = txtProduct_up.EditValue.ToString().ToInt32();
               info.Product_down = txtProduct_down.EditValue.ToString().ToInt32();
               info.O_id_lastgr = txto_id_lastgr.EditValue.ToString();
              
               disInfo.H_local_price_hy = txtHy_price.EditValue.ToString().ToDecimal();
               disInfo.H_local_price_ls = txtprice_ls.EditValue.ToString().ToDecimal();
               disInfo.H_local_price_px = txtprice_px.EditValue.ToString().ToDecimal();
               info.Avoid_flag = txtAvoid_Flag.EditValue.ToString();

               disInfo.H_output_discount_member_ls = disInfo.H_local_price_hy / info.H_output_price;
               disInfo.H_output_discount_ls = disInfo.H_local_price_ls / info.H_output_price;
               disInfo.H_output_discount = disInfo.H_local_price_px / info.H_output_price;
           }
         
        /// <summary>
        /// 新增状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveAddNew()
        {
            
            ProductInfo info = tempInfo;//必须使用存在的局部变量，因为部分信息可能被附件使用
            Product_discountInfo disInfo = tempdiscountInfo;

            SetInfo(info, disInfo);
            info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;


            try
            {
                #region 新增数据
                bool succeed = CallerFactory<IProductService>.Instance.SaveUpdate(info, tempdiscountInfo);

                if (succeed)
                {
                    //可添加其他关联操作
                   if(tempInfo!=null)
                   {
                       GetNewProduct();
                   }

                    return true;
                }
                #endregion
            }
            catch (Exception ex)
            {
                LogTextHelper.Error(ex);
                MessageDxUtil.ShowError(ex.Message);
            }
            return false;
        }                 

        /// <summary>
        /// 编辑状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveUpdated()
        {

            ProductInfo info = CallerFactory<IProductService>.Instance.FindByID(tempInfo.H_id);
            if (tempdiscountInfo == null)
            {
                tempdiscountInfo = CallerFactory<IProduct_discountService>.Instance.FindByID(tempdiscountInfo.H_id);
            }
            if (info != null && tempdiscountInfo!=null)
            {
                SetInfo(info,tempdiscountInfo);
                info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;


                try
                {
                    #region 更新数据

                    bool succeed = CallerFactory<IProductService>.Instance.SaveUpdate(info, tempdiscountInfo);
                    if (succeed )
                    {
                        //可添加其他关联操作

                        return true;
                    }
                  
                    #endregion
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
            }
           return false;
        }

        private void SetReadOnly()
        {
            if (rowIndex==-1)
            {
                this.txtH_id.Text = System.Guid.NewGuid().ToString().ToUpper();
                this.SetDefaultValue();
                this.txtH_isbn.Focus();
                this.btnAdd.Visible = false;
            }
            this.txtH_id.Properties.ReadOnly = true;
        }

        private void FrmEditProduct_Load(object sender, EventArgs e)
        {
            if (this.txtO_id_input.Text == string.Empty)
            {
                SetValue();
            }
            if (this.ID == string.Empty)
            {
                this.txtH_input_date.EditValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            InitDictItem();//数据字典加载（公用）
            SetReadOnly();
            Saved = true;
        }

        private void txtH_id_other_EditValueChanged(object sender, EventArgs e)
        {
            if (this.txtH_id_other.EditValue != null) 
            {
                if (this.txtH_id_other.EditValue.ToString() == this.txtH_id.Text && !string.IsNullOrWhiteSpace(this.txtH_id.Text))
                {
                    MessageDxUtil.ShowError("请选择正确从属商品");
                    this.txtH_id_other.EditValue = string.Empty;
                    this.txtH_id_other.Focus();
                }
            }
        }

        private void txtH_output_price_Leave(object sender, EventArgs e)
        {
            if (txtH_input_price.EditValue.ToString().ToDecimal() == 0 )
            {
                txtH_input_price.EditValue = txtH_output_price.EditValue;
            }
            if (txtprice_ls.EditValue.ToString().ToDecimal() == 0)
            {
                txtprice_ls.EditValue = txtH_output_price.EditValue;
            }
            if (txtprice_px.EditValue.ToString().ToDecimal() == 0)
            {
                txtprice_px.EditValue = txtH_output_price.EditValue;
            }
            if (txtHy_price.EditValue.ToString().ToDecimal() == 0)
            {
                txtHy_price.EditValue = txtH_output_price.EditValue;
            }
        }

        private void txtH_isbn_Leave(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                if (string.IsNullOrWhiteSpace(this.txtH_mytm.Text))
                {
                    this.txtH_mytm.EditValue = txtH_isbn.EditValue;
                }
                if (!string.IsNullOrWhiteSpace(txtH_isbn.Text))
                {
                    DataTable list = CallerFactory<IProductService>.Instance.CheckIsbn(txtH_isbn.Text);
                    if (list.Rows.Count > 0)
                    {
                        if (MessageDxUtil.ShowYesNoAndTips("书号重复,继续录入吗?") == System.Windows.Forms.DialogResult.Yes)
                        {
                            FrmShowRepeatProductInfo frpi = new FrmShowRepeatProductInfo();
                            frpi.ProductList = list;
                            frpi.ShowDialog();
                            if (frpi.DialogResult == System.Windows.Forms.DialogResult.OK)
                            {
                                ProductInfo p = CallerFactory<IProductService>.Instance.FindByID(frpi.SelecedId);

                                txtprice_ls.EditValue = p.Price_ls;
                                txtprice_px.EditValue = p.Price_px;
                                txtHy_price.EditValue = p.Price_hy;
                                txtH_name.Text = p.H_name;
                                txtH_output_price.EditValue = p.H_output_price;
                                txtH_input_price.EditValue = p.H_input_price;
                                txtdiscount_hy.EditValue = p.Discount_hy;
                                txtdiscount_ls.EditValue = p.Discount_ls;
                                txtdiscount_px.EditValue = p.Discount_px;
                            }
                        }
                        else
                        {
                            txtH_isbn.Focus();
                            txtH_isbn.SelectAll();
                        }
                    }
                }
            }
        }
        private void txtH_name_EditValueChanged(object sender, EventArgs e)
        {
            txtMy_help_input.EditValue = PinYinUtil.GetFirstPY(txtH_name.Text.Trim());
        }
        private void SetValue()
        {
            this.txtO_id_input.EditValue = Portal.gc.LoginUserInfo.O_id;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 返回一个新增商品信息
        /// </summary>
        /// <returns></returns>
        public SimpleProductInfo  GetNewProduct( )
        {
           return SetNewProduct(tempInfo);
        }
        /// <summary>
        /// 数据库实体转换成简单实体
        /// </summary>
        /// <param name="tempInfo"></param>
        /// <returns></returns>
        public SimpleProductInfo SetNewProduct(ProductInfo  tempInfo)
        {
            SimpleProductInfo SimProduct = new SimpleProductInfo();
            SimProduct.H_id = tempInfo.H_id;
            SimProduct.H_input_price = tempInfo.H_input_price;
            SimProduct.H_isbn = tempInfo.H_isbn;
            SimProduct.H_name = tempInfo.H_name;
            SimProduct.H_type = tempInfo.H_type;
            SimProduct.Pub_id = tempInfo.Pub_id;
            SimProduct.Hy_price = tempInfo.Hy_price;
            SimProduct.H_input_price = tempInfo.H_input_price;
            SimProduct.H_output_price = tempInfo.H_output_price;
            return SimProduct;
        }

        #region 折扣,定价计算

        private void txtprice_ls_Properties_Leave(object sender, EventArgs e)
        {
            txtdiscount_ls.EditValue = txtprice_ls.EditValue.ToString().ToDecimal() / txtH_output_price.EditValue.ToString().ToDecimal();
        }

        private void txtprice_px_Properties_Leave(object sender, EventArgs e)
        {
            txtdiscount_px.EditValue = txtprice_px.EditValue.ToString().ToDecimal() / txtH_output_price.EditValue.ToString().ToDecimal();
        }

        private void txtHy_price_Properties_Leave(object sender, EventArgs e)
        {
            txtdiscount_hy.EditValue = txtHy_price.EditValue.ToString().ToDecimal() / txtH_output_price.EditValue.ToString().ToDecimal();
        }

        private void txtdiscount_ls_Properties_Leave(object sender, EventArgs e)
        {
            txtprice_ls.EditValue = txtdiscount_ls.EditValue.ToString().ToDecimal() * txtH_output_price.EditValue.ToString().ToDecimal();
        }

        private void txtdiscount_px_Properties_Leave(object sender, EventArgs e)
        {
            txtprice_px.EditValue = txtdiscount_px.EditValue.ToString().ToDecimal() * txtH_output_price.EditValue.ToString().ToDecimal();
        }

        private void txtdiscount_hy_Properties_Leave(object sender, EventArgs e)
        {
            txtHy_price.EditValue = txtdiscount_hy.EditValue.ToString().ToDecimal() * txtH_output_price.EditValue.ToString().ToDecimal();
        }
        
        #endregion


     
    }
}
