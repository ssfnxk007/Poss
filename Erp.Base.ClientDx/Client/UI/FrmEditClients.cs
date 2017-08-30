using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using WHC.Pager.Entity;
using WHC.Dictionary;
using WHC.Dictionary.UI.Client.BaseUI;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;

using WHC.Security;
using WHC.Framework.ControlUtil.Facade;
using Erp.Base.ServiceCaller;
using Erp.Base.Facade;
using Erp.Base.Entity;
using System.ServiceModel;



namespace Erp.Base.UI
{
    public partial class FrmEditClients : BaseEditForm
    {
    	/// <summary>
        /// 创建一个临时对象，方便在附件管理中获取存在的GUID
        /// </summary>
    	private ClientsInfo tempInfo = new ClientsInfo();
    	
        public FrmEditClients()
        {
            InitializeComponent();
            InitLookUpEditItem();
        }
        #region 静态调用
        public static void ShowEditClients(string c_id)
        {
            List<string> IDList = new List<string>();
            IDList.Add(c_id);
            FrmEditClients ec = new FrmEditClients();
            ec.Text = "客户信息";
            ec.ID = c_id;
            ec.IDList = IDList;
            ec.ShowDialog();
            ec.Dispose();
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
            if (this.txtC_id.Text.Trim().Length == 0) 
            {
                MessageDxUtil.ShowTips("请输入客户编码");
                this.txtC_id.Focus();
                result = false;
            }
            else if (this.txtCc_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择客户类别");
                this.txtCc_id.Focus();
                result = false;
            }
             else if (this.txtC_department.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入客户名称");
                this.txtC_department.Focus();
                result = false;
            }
             else if (this.txtC_level.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择是否有效");
                this.txtC_level.Focus();
                result = false;
            }
             else if (this.txtC_jb.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择客户级别");
                this.txtC_jb.Focus();
                result = false;
            }
            else if (this.txtStation_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择所属站点!");
                this.txtC_jb.Focus();
                result = false;
            }
             else if (this.txtDiscountmethod.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择折扣设置");
                this.txtDiscountmethod.Focus();
                result = false;
            }
            #endregion

            return result;
        }

        /// <summary>
        /// 初始化数据字典
        /// </summary>
        private void InitDictItem()
        {
            
			//初始化代码
            this.txto_id_input.Properties.DisplayMember = "显示值";
            this.txto_id_input.Properties.ValueMember = "项目值";
            this.txto_id_input.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_lastmod.Properties.DisplayMember = "显示值";
            this.txtO_id_lastmod.Properties.ValueMember = "项目值";
            this.txtO_id_lastmod.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

        }

        private void InitLookUpEditItem() 
        {
            this.txtI_class_id.EditValue = string.Empty;
            this.txtCm_id.EditValue = string.Empty;
            this.txtStation_account.EditValue = string.Empty;
            this.txtStation_id_xs.EditValue = string.Empty;
            this.txtC_source.EditValue = string.Empty;
            this.txtC_hy_id.EditValue = string.Empty;
            this.txtO_id.EditValue = string.Empty;
            this.txtClients_credit.EditValue = string.Empty;
            this.txtAccount_credit.EditValue = string.Empty;
            this.txtA_id.EditValue = string.Empty;
            this.txtP_id.EditValue = string.Empty;
            this.txtCity_id.EditValue = string.Empty;
            txto_id_input.EditValue = string.Empty;
            txtO_id_lastmod.EditValue = string.Empty;

        }


        /// <summary>
        /// 显示数据
        /// </summary>
        public override void DisplayData()
        {
            InitDictItem();//数据字典加载（公用）
            if (this.MasterView != null)
            {

                #region tempInfo
                tempInfo = MasterView.GetFocusedRow() as ClientsInfo;
                txtC_discount.Text = tempInfo.C_discount.ToString("p2");
                txtCc_id.EditValue = tempInfo.Cc_id;
                txtInput_date.Text = tempInfo.Input_date.ToString("yyyy-MM-dd HH:mm:ss");
                txt_last_modi_time.Text = tempInfo.Last_mod_date.ToString("yyyy-MM-dd HH:mm:ss");
                txtC_birth.Text = tempInfo.C_birth.ToShortDateString();
                txtC_contact_man.Text = tempInfo.C_contact_man;
                txtC_department.Text = tempInfo.C_department;
                txtC_address.Text = tempInfo.C_address;
                txtC_tel.Text = tempInfo.C_tel;
                txtC_fax.Text = tempInfo.C_fax;
                txtC_level.EditValue = tempInfo.C_level;
                txtC_help_input.Text = tempInfo.C_help_input;
                txtC_account.Text = tempInfo.C_account;
                txtC_bank.Text = tempInfo.C_bank;
                txtC_tax.Text = tempInfo.C_tax;
                txtC_zip.Text = tempInfo.C_zip;
                txtC_mail.Text = tempInfo.C_mail;
                txtC_tax_address.Text = tempInfo.C_tax_address;
                txtO_id.EditValue = tempInfo.O_id;
                txtCm_id.EditValue = tempInfo.Cm_id;
                txtC_mem.Text = tempInfo.C_mem;
                txtA_id.EditValue = tempInfo.A_id;
                txtP_id.EditValue = tempInfo.P_id;
                txtCity_id.EditValue = tempInfo.City_id;
                txtC_tax_tel.Text = tempInfo.C_tax_tel;
                txtClients_credit.EditValue = tempInfo.Clients_credit;
                txtC_address_song.Text = tempInfo.C_address_song;
                txtConsignment_style.Text = tempInfo.Consignment_style;
                txtC_station.Text = tempInfo.C_station;
                txtC_account_name.Text = tempInfo.C_account_name;
                txtC_hy_id.EditValue = tempInfo.C_hy_id;
                txtC_department_simple.Text = tempInfo.C_department_simple;
                txtC_jb.EditValue = tempInfo.C_jb;
                txtC_source.EditValue = tempInfo.C_source;
                txtC_phase.Text = tempInfo.C_phase;
                txtC_money.Text = tempInfo.C_money.ToString("c2");
                txtC_law_man.Text = tempInfo.C_law_man;
                txtC_abstract.Text = tempInfo.C_abstract;
                txtLimit_money.Text = tempInfo.Limit_money.ToString("c2");
                txtLimit_day.Text = tempInfo.Limit_day.ToString();
                txtC_back.EditValue = tempInfo.C_back.ToString("p2");
                txtStation_id.EditValue = tempInfo.Station_id;
                txtBack_limit_date.Text = tempInfo.Back_limit_date.ToString();
                txtStation_account.EditValue = tempInfo.Station_account;
                txtParent_client.Text = tempInfo.Parent_client;
                txtDiscountmethod.EditValue = tempInfo.Discountmethod;
                txtDiscountrise.Text = tempInfo.Discountrise.ToString("p2");
                txtI_class_id.EditValue = tempInfo.I_class_id;
                txtStation_id_xs.EditValue = tempInfo.Station_id_xs;
                txtArrear_c_id.Text = tempInfo.Arrear_c_id;
                txtCard_id.Text = tempInfo.Card_id;
                txtC_handset.Text = tempInfo.C_handset;
                txtLeast_discount.Text = tempInfo.Least_discount.ToString("p2");
                txtC_hc_id.Text = tempInfo.C_hc_id;
                txtAccount_limit.Text = tempInfo.Account_limit.ToString();
                txtCustom_id.Text = tempInfo.Custom_id;
                txtC_id.Text = tempInfo.C_id;
                txtAccount_credit.EditValue = tempInfo.Account_credit;
                this.txtO_id_lastmod.EditValue = tempInfo.O_id_lastmodify;
                txto_id_input.EditValue = tempInfo.O_id_input; 
                #endregion

            }

            //tempInfo在对象存在则为指定对象，新建则是全新的对象，但有一些初始化的GUID用于附件上传
            //SetAttachInfo(tempInfo);
        }

        //private void SetAttachInfo(ClientsInfo info)
        //{
        //    this.attachmentGUID.AttachmentGUID = info.AttachGUID;
        //    this.attachmentGUID.userId = LoginUserInfo.Name;

        //    string name = txtName.Text;
        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        string dir = string.Format("{0}", name);
        //        this.attachmentGUID.Init(dir, tempInfo.ID, LoginUserInfo.Name);
        //    }
        //}

        public override void ClearScreen()
        {
            this.tempInfo = new ClientsInfo();
            base.ClearScreen();
        }

        /// <summary>
        /// 编辑或者保存状态下取值函数
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(ClientsInfo info)
        {      
               info.C_discount = txtC_discount.EditValue.ToString().ToDecimal();
               info.Cc_id = txtCc_id.EditValue.ToString();
               info.Input_date = txtInput_date.EditValue.ToString().ToDateTime();
               info.C_birth = txtC_birth.DateTime;
               info.C_contact_man = txtC_contact_man.Text;
               info.C_department = txtC_department.Text;
               info.C_address = txtC_address.Text;
               info.C_tel = txtC_tel.Text;
               info.C_fax = txtC_fax.Text;
               info.C_level = txtC_level.EditValue.ToString();
               info.C_help_input = txtC_help_input.Text;
               info.C_account = txtC_account.Text;
               info.C_bank = txtC_bank.Text;
               info.C_tax = txtC_tax.Text;
               info.C_zip = txtC_zip.Text;
               info.C_mail = txtC_mail.Text;
               info.C_tax_address = txtC_tax_address.Text;
               info.O_id = txtO_id.EditValue.ToString();
               info.Cm_id = txtCm_id.EditValue.ToString();
               info.C_mem = txtC_mem.Text;
               info.A_id = txtA_id.EditValue.ToString();
               info.P_id = txtP_id.EditValue.ToString();
               info.City_id = txtCity_id.EditValue.ToString();
               info.C_tax_tel = txtC_tax_tel.Text;
               info.Clients_credit = txtClients_credit.EditValue.ToString();
               info.C_address_song = txtC_address_song.Text;
               info.Consignment_style = txtConsignment_style.Text;
               info.C_station = txtC_station.Text;
               info.C_account_name = txtC_account_name.Text;
               info.C_hy_id = txtC_hy_id.EditValue.ToString();
               info.C_department_simple = txtC_department_simple.Text;
               info.C_jb = txtC_jb.EditValue.ToString();
               info.C_source = txtC_source.EditValue.ToString();
               info.C_phase = txtC_phase.EditValue.ToString();
               info.C_money =txtC_money.EditValue.ToString().ToDecimal();
               info.C_law_man = txtC_law_man.Text;
               info.C_abstract = txtC_abstract.Text;
               info.Limit_money = txtLimit_money.EditValue.ToString().ToInt32();
               info.Limit_day =txtLimit_day.EditValue.ToString().ToInt32();
               info.C_back = txtC_back.EditValue.ToString().ToDecimal();
               info.Station_id = txtStation_id.EditValue.ToString();
               info.Back_limit_date = txtBack_limit_date.Text.ToInt32();
               info.Station_account = txtStation_account.EditValue.ToString();
               info.Parent_client = txtParent_client.Text;
               info.Discountmethod = txtDiscountmethod.EditValue.ToString();
               info.Discountrise = txtDiscountrise.EditValue.ToString().ToDecimal();
               info.I_class_id = txtI_class_id.EditValue.ToString();
               info.Station_id_xs = txtStation_id_xs.EditValue.ToString();
               info.Arrear_c_id = txtArrear_c_id.Text;
               info.Card_id = txtCard_id.Text;
               info.C_handset = txtC_handset.Text;
               info.Least_discount = txtLeast_discount.Text.ToDecimal();
               info.C_hc_id = txtC_hc_id.Text;
               info.Account_limit = txtAccount_limit.Text.ToInt32();
               info.Custom_id = txtCustom_id.Text;
               info.C_id = txtC_id.Text;
               info.Account_credit = txtAccount_credit.EditValue.ToString();
               info.Last_mod_date = txt_last_modi_time.ToString().ToDateTime();
               info.O_id_input = txto_id_input.EditValue.ToString();
               info.Input_date = txtInput_date.Text.ToDateTime();
               info.O_id_lastmodify = txtO_id_lastmod.EditValue.ToString();
           }
         
        /// <summary>
        /// 新增状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveAddNew()
        {
            ClientsInfo info = tempInfo;//必须使用存在的局部变量，因为部分信息可能被附件使用
            SetInfo(info);
            info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;

            try
            {
                #region 新增数据

               
                bool succeed = CallerFactory<IClientsService>.Instance.Insert(info);
                if (succeed)
                {
                    //可添加其他关联操作

                    return true;
                }
                #endregion
            }
            catch (FaultException fe)
            {
                LogTextHelper.Error(fe);
                MessageDxUtil.ShowError(fe.Message);
            }
          
            return false;
        }                 

        /// <summary>
        /// 编辑状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveUpdated()
        {
 
           
            ClientsInfo info = CallerFactory<IClientsService>.Instance.FindByID(tempInfo.C_id);
            if (info != null)
            {
                SetInfo(info);
                info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;

                try
                {
                    #region 更新数据
                    bool succeed = CallerFactory<IClientsService>.Instance.Update(info, info.C_id);
                    if (succeed)
                    {
                        //可添加其他关联操作

                        return true;
                    }
                }
                catch (Exception ex)
                {
                   LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
                   
               
            } 
                    #endregion
           return false;
        }

        private void SetReadOnly() 
        {
            if (this.ID != string.Empty)
            {
                this.txtC_id.Properties.ReadOnly = true;
                this.txtStation_id.Properties.ReadOnly = true;

            }
        }

        private void SetDiscountmethod()
        {
            if (this.txtDiscountmethod.EditValue!= null ) 
            {
                switch (this.txtDiscountmethod.EditValue.ToString())
                {
                    case "1":
                        this.txtC_discount.Properties.ReadOnly = false;
                        this.txtDiscountrise.Properties.ReadOnly = true;
                        break;
                    case "2":
                        this.txtDiscountrise.Properties.ReadOnly = false;
                        this.txtC_discount.Properties.ReadOnly = true;
                        break;
                    case "3":
                        this.txtDiscountrise.Properties.ReadOnly = false;
                        this.txtC_discount.Properties.ReadOnly = true;
                        break;
                    case "4":
                        this.txtDiscountrise.Properties.ReadOnly = false;
                        this.txtC_discount.Properties.ReadOnly = true;
                        break;
                    case "5":
                        this.txtDiscountrise.Properties.ReadOnly = false;
                        this.txtC_discount.Properties.ReadOnly = true;
                        break;
                    case "6":
                        this.txtDiscountrise.Properties.ReadOnly = false;
                        this.txtC_discount.Properties.ReadOnly = true;
                        break;
                    case "A":
                        this.txtDiscountrise.Properties.ReadOnly = false;
                        this.txtC_discount.Properties.ReadOnly = false;
                        break;
                    case "B":
                        this.txtDiscountrise.Properties.ReadOnly = false;
                        this.txtC_discount.Properties.ReadOnly = true;
                        break;
                    case "*":
                        this.txtDiscountrise.Properties.ReadOnly = false;
                        this.txtC_discount.Properties.ReadOnly = false;
                        break;
                    
                    default:
                        break;
                }
            }
        }

        private void FrmEditClients_Load(object sender, EventArgs e)
        {
            SelectChoese();
            SetReadOnly();
            SetDiscountmethod();
            if (this.txto_id_input.EditValue.ToString() == string.Empty)
            {
                SetDefaultValue();
            }
            if (this.ID == string.Empty)
            {
                this.txtInput_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            Saved = true;
        }
        private void SelectChoese() 
        {
            this.txtC_level.Properties.DisplayMember = "显示值";
            this.txtC_level.Properties.ValueMember = "项目值";
            this.txtC_level.Properties.DataSource = WHC.Dictionary.DictItemUtil.ClientC_LevelbyEditor();

            this.txtC_hy_id.Properties.DisplayMember = "显示值";
            this.txtC_hy_id.Properties.ValueMember = "项目值";
            this.txtC_hy_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Hy_idByEditor();

            this.txtI_class_id.Properties.DisplayMember = "显示值";
            this.txtI_class_id.Properties.ValueMember = "项目值";
            this.txtI_class_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.I_class_idByEditor();

            this.txtCm_id.Properties.DisplayMember = "显示值";
            this.txtCm_id.Properties.ValueMember = "项目值";
            this.txtCm_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cm_idByEditor();

            this.txtClients_credit.Properties.DisplayMember = "显示值";
            this.txtClients_credit.Properties.ValueMember = "项目值";
            this.txtClients_credit.Properties.DataSource = WHC.Dictionary.DictItemUtil.Clients_CreditbyEditor();

            this.txtAccount_credit.Properties.DisplayMember = "显示值";
            this.txtAccount_credit.Properties.ValueMember = "项目值";
            this.txtAccount_credit.Properties.DataSource = WHC.Dictionary.DictItemUtil.Clients_CreditbyEditor();

            this.txtO_id.Properties.DisplayMember = "显示值";
            this.txtO_id.Properties.ValueMember = "项目值";
            this.txtO_id.Properties.DataSource = SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtDiscountmethod.Properties.DisplayMember = "显示值";
            this.txtDiscountmethod.Properties.ValueMember = "项目值";
            this.txtDiscountmethod.Properties.DataSource = WHC.Dictionary.DictItemUtil.DiscountmethodbyEditor();

            this.txtC_jb.Properties.DisplayMember = "显示值";
            this.txtC_jb.Properties.ValueMember = "项目值";
            this.txtC_jb.Properties.DataSource = WHC.Dictionary.DictItemUtil.C_jbByEditor();


            this.txtCc_id.Properties.DisplayMember = "显示值";
            this.txtCc_id.Properties.ValueMember = "项目值";
            this.txtCc_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cc_idByEditor();

            this.txtC_source.Properties.DisplayMember = "显示值";
            this.txtC_source.Properties.ValueMember = "项目值";
            this.txtC_source.Properties.DataSource = WHC.Dictionary.DictItemUtil.C_sourceByEditor();

            this.txtStation_id.Properties.DisplayMember = "显示值";
            this.txtStation_id.Properties.ValueMember = "项目值";
            this.txtStation_id.Properties.DataSource = SecurityUtil.GetValidStationForDropDown();

            this.txtStation_account.Properties.DisplayMember = "显示值";
            this.txtStation_account.Properties.ValueMember = "项目值";
            this.txtStation_account.Properties.DataSource = SecurityUtil.GetValidStationForDropDown();

            this.txtStation_id_xs.Properties.DisplayMember = "显示值";
            this.txtStation_id_xs.Properties.ValueMember = "项目值";
            this.txtStation_id_xs.Properties.DataSource = SecurityUtil.GetValidStationForDropDown();


            this.txtA_id.Properties.DisplayMember = "显示值";
            this.txtA_id.Properties.ValueMember = "项目值";
            this.txtA_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.ArearsByEditor();

            this.txtP_id.Properties.DisplayMember = "显示值";
            this.txtP_id.Properties.ValueMember = "项目值";
            this.txtP_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.ProvinceByEditor();

            this.txtCity_id.Properties.DisplayMember = "显示值";
            this.txtCity_id.Properties.ValueMember = "项目值";
            this.txtCity_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.CitysByEditor();
        }
        private void txtDiscountmethod_EditValueChanged(object sender, EventArgs e)
        {
            SetDiscountmethod();
        }

        private void txtC_department_EditValueChanged(object sender, EventArgs e)
        {
            this.txtC_help_input.Text = Pinyin.GetFirstPY(this.txtC_department.Text);
        }

        private void txtStation_id_EditValueChanged(object sender, EventArgs e)
        {
            if (this.Text.Contains("新建"))
            {
                try
                {
                    this.txtC_id.Text = string.Format("K{0}{1:00000}", this.txtStation_id.EditValue.ToString(), CallerFactory<IClientsService>.Instance.MaxCode(this.txtStation_id.EditValue.ToString()));
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
            }
        }

        private void SetDefaultValue()
        {
            this.txto_id_input.EditValue = Portal.gc.LoginUserInfo.O_id;
        }
        public override void SetControlReadOnly()
        {
            txtStation_id.Properties.ReadOnly = true;
        }
        
    }
}
