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
using WHC.Security;

namespace Erp.Base.UI
{
    public partial class FrmEditFactory : BaseEditForm
    {
    	/// <summary>
        /// 创建一个临时对象，方便在附件管理中获取存在的GUID
        /// </summary>
    	private FactoryInfo tempInfo = new FactoryInfo();

        #region 自定义属性
      
        
        #endregion
        public FrmEditFactory()
        {
            InitializeComponent();
            InitLookUpEditItem();
            this.Load +=FrmEditFactory_Load;
        }

        #region 静态调用
        public static void ShowEditFactory(string f_id)
        {
            List<string> IDList = new List<string>();
            IDList.Add(f_id);
            FrmEditFactory ec = new FrmEditFactory();
            ec.Text = "货源信息";
            ec.ID = f_id;
            ec.IDList = IDList;
            ec.ShowDialog();
            ec.Dispose();
        }

        #endregion   
        private void InitLookUpEditItem()
        {
            this.txtI_class_id.EditValue = string.Empty;
            this.txtCm_id.EditValue = string.Empty;
            this.txtStation_account.EditValue = string.Empty;
            this.txtHy_id.EditValue = string.Empty;
            this.txtO_id.EditValue = string.Empty;
            this.txtClients_credit.EditValue = string.Empty;
            this.txtP_id.EditValue = string.Empty;
            this.txtZn_path_id.EditValue = string.Empty;
            this.txtStation_id.EditValue = string.Empty;
            this.txtF_account_style.EditValue = string.Empty;
            this.txtF_level.EditValue = string.Empty;
            txtF_account_style.EditValue = string.Empty;
            txtO_id_input.EditValue = string.Empty;
            txtO_id_lastmod.EditValue = string.Empty;
          

        }   
                
        /// <summary>
        /// 实现控件输入检查的函数
        /// </summary>
        /// <returns></returns>
        public override bool CheckInput()
        {
            bool result = true;//默认是可以通过

            #region MyRegion
            if (this.txtFc_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请选择货源类别");
                this.txtFc_id.Focus();
                result = false;
            }
            else if (this.txtF_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入货源编码");
                this.txtF_department.Focus();
                result = false;
            }
             else if (this.txtF_department.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入货源名称");
                this.txtF_department.Focus();
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
            this.txtO_id_input.Properties.DisplayMember = "显示值";
            this.txtO_id_input.Properties.ValueMember = "项目值";
            this.txtO_id_input.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_lastmod.Properties.DisplayMember = "显示值";
            this.txtO_id_lastmod.Properties.ValueMember = "项目值";
            this.txtO_id_lastmod.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            //this.txtStation_id.Properties.DisplayMember = "显示值";
            //this.txtStation_id.Properties.ValueMember = "项目值";
            //this.txtStation_id.Properties.DataSource = WHC.Security.DALSQL.Station_total.Instance.GetValidStationForDropDown();

            //this.txtStation_account.Properties.DisplayMember = "显示值";
            //this.txtStation_account.Properties.ValueMember = "项目值";
            //this.txtStation_account.Properties.DataSource = WHC.Security.DALSQL.Station_total.Instance.GetValidStationForDropDown();


        }
        private void SetReadOnly()
        {
            if (this.ID != string.Empty)
            {
                this.txtF_id.Properties.ReadOnly = true;
                this.txtStation_id.Properties.ReadOnly = true;

            }
        }
        /// <summary>
        /// 数据显示的函数
        /// </summary>
        public override void DisplayData()
        {
            InitDictItem();//数据字典加载（公用）
            if (this.MasterView != null)
            {
                #region 显示
                tempInfo = MasterView.GetFocusedRow() as FactoryInfo;
                txtF_id.EditValue = tempInfo.F_id;
                txtFc_id.EditValue = tempInfo.Fc_id;
                txtF_birth.Text = tempInfo.F_birth.ToShortDateString();
                txtF_contact_man.Text = tempInfo.F_contact_man;
                txtF_department.Text = tempInfo.F_department;
                txtF_address.Text = tempInfo.F_address;
                txtF_tel.Text = tempInfo.F_tel;
                txtF_fax.Text = tempInfo.F_fax;
                txtF_level.EditValue = tempInfo.F_level;
                txtF_help_input.Text = tempInfo.F_help_input;
                txtF_account.Text = tempInfo.F_account;
                txtF_bank.Text = tempInfo.F_bank;
                txtF_tax.Text = tempInfo.F_tax;
                txtF_zip.Text = tempInfo.F_zip;
                txtF_mail.Text = tempInfo.F_mail;
                txtF_tax_address.Text = tempInfo.F_tax_address;
                txtO_id.EditValue = tempInfo.O_id;
                txtCm_id.EditValue = tempInfo.Cm_id;
                txtF_mem.Text = tempInfo.F_mem;
                txtF_tax_tel.Text = tempInfo.F_tax_tel;
                txtClients_credit.EditValue = tempInfo.Clients_credit;
                txtF_account_name.Text = tempInfo.F_account_name;
                txtF_back_address.Text = tempInfo.F_back_address;
                txtF_department_simple.Text = tempInfo.F_department_simple;
                txtF_jb.EditValue = tempInfo.F_jb;
                txtF_law_man.Text = tempInfo.F_law_man;
                txtF_abstract.Text = tempInfo.F_abstract;
                txtHy_id.EditValue = tempInfo.Hy_id;
                txtZn_path_id.EditValue = tempInfo.Zn_path_id;
                txtLimit_money.Text = tempInfo.Limit_money.ToString();
                txtLimit_day.Text = tempInfo.Limit_day.ToString();
                txtF_discount.Text = tempInfo.F_discount.ToString("p2");
                txtF_back.Text = tempInfo.F_back.ToString("p2");
                txtArrear_f_id.Text = tempInfo.Arrear_f_id;
                txtStation_account.EditValue = tempInfo.Station_account;
                txtStation_id.EditValue = tempInfo.Station_id;
                txtContract_id.Text = tempInfo.Contract_id;
                txtYyzz_id.Text = tempInfo.Yyzz_id;
                txtP_id.EditValue = tempInfo.P_id;
                txtI_class_id.EditValue = tempInfo.I_class_id;
                txtBack_limit_date.Text = tempInfo.Back_limit_date.ToString();
                txtF_handset.Text = tempInfo.F_handset;
                txtF_back_man.Text = tempInfo.F_back_man;
                txtF_back_tel.Text = tempInfo.F_back_tel;
                txtF_account_style.EditValue = tempInfo.F_account_style;
                txtCustom_id.Text = tempInfo.Custom_id;
                txtParent_factory.Text = tempInfo.Parent_factory;
                this.txtLast_mod_time.Text = tempInfo.Last_mod_date.ToString("yyyy-MM-dd HH:mm:ss");
                this.txtO_id_lastmod.EditValue = tempInfo.O_id_lastmodify; 
                #endregion
            }

        
            
            //tempInfo在对象存在则为指定对象，新建则是全新的对象，但有一些初始化的GUID用于附件上传
            //SetAttachInfo(tempInfo);
        }

        //private void SetAttachInfo(FactoryInfo info)
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
            this.tempInfo = new FactoryInfo();
            base.ClearScreen();
        }

        /// <summary>
        /// 编辑或者保存状态下取值函数
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(FactoryInfo info)
        {
               info.F_id = txtF_id.Text;
               info.Fc_id = txtFc_id.EditValue.ToString();
               info.F_birth = txtF_birth.DateTime;
               info.F_contact_man = txtF_contact_man.Text;
               info.F_department = txtF_department.Text;
               info.F_address = txtF_address.Text;
               info.F_tel = txtF_tel.Text;
               info.F_fax = txtF_fax.Text;
               info.F_level = txtF_level.EditValue.ToString();
               info.F_help_input = txtF_help_input.Text;
               info.F_account = txtF_account.Text;
               info.F_bank = txtF_bank.Text;
               info.F_tax = txtF_tax.Text;
               info.F_zip = txtF_zip.Text;
               info.F_mail = txtF_mail.Text;
               info.F_tax_address = txtF_tax_address.Text;
               info.O_id = txtO_id.EditValue.ToString();
               info.Cm_id = txtCm_id.EditValue.ToString();
               info.F_mem = txtF_mem.Text;
               info.F_tax_tel = txtF_tax_tel.Text;
               info.Clients_credit = txtClients_credit.EditValue.ToString();
               info.F_account_name = txtF_account_name.Text;
               info.F_back_address = txtF_back_address.Text;
               info.F_department_simple = txtF_department_simple.Text;
               info.F_jb = txtF_jb.EditValue.ToString();
               info.F_law_man = txtF_law_man.Text;
               info.F_abstract = txtF_abstract.Text;
               info.Hy_id = txtHy_id.EditValue.ToString();
               info.Zn_path_id = txtZn_path_id.EditValue.ToString();
               info.Limit_money = txtLimit_money.Text.ToInt32();
               info.Limit_day = txtLimit_day.Text.ToInt32();
               info.F_discount = txtF_discount.EditValue.ToString().ToDecimal();
               info.F_back = txtF_back.EditValue.ToString().ToDecimal();
               info.Arrear_f_id = txtArrear_f_id.Text;
               info.Station_account = txtStation_account.EditValue.ToString();
               info.Station_id = txtStation_id.EditValue.ToString();
               info.Contract_id = txtContract_id.Text;
               info.Yyzz_id = txtYyzz_id.Text;
               info.P_id = txtP_id.EditValue.ToString();
               info.I_class_id = txtI_class_id.EditValue.ToString();
               info.Back_limit_date = txtBack_limit_date.Text.ToInt32();
               info.F_handset = txtF_handset.Text;
               info.F_back_man = txtF_back_man.Text;
               info.F_back_tel = txtF_back_tel.Text;
               info.F_account_style = txtF_account_style.Text;
               info.Custom_id = txtCustom_id.Text;
               info.Parent_factory = txtParent_factory.Text;
               info.O_id_input = txtO_id_input.EditValue.ToString();
               info.Input_date = txtinput_dae.Text.ToDateTime();
               info.Last_mod_date = txtLast_mod_time.Text.ToDateTime();
               info.O_id_lastmodify = txtO_id_lastmod.EditValue.ToString();
           }
         
        /// <summary>
        /// 新增状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveAddNew()
        {
            FactoryInfo info = tempInfo;//必须使用存在的局部变量，因为部分信息可能被附件使用
            SetInfo(info);
            info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;

           
            try
            {
                #region 新增数据
                bool succeed = CallerFactory<IFactoryService>.Instance.Insert(info);
                if (succeed)
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
            return false;
        }                 

        /// <summary>
        /// 编辑状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveUpdated()
        {

            FactoryInfo info = CallerFactory<IFactoryService>.Instance.FindByID(tempInfo.F_id);
            if (info != null)
            {
                SetInfo(info);
                info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;

                
                try
                {
                    #region 更新数据
                    bool succeed = CallerFactory<IFactoryService>.Instance.Update(info, info.F_id);
                    if (succeed)
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
        private void SelectChoese() 
        {
            this.txtF_level.Properties.DisplayMember = "显示值";
            this.txtF_level.Properties.ValueMember = "项目值";
            this.txtF_level.Properties.DataSource = WHC.Dictionary.DictItemUtil.ClientC_LevelbyEditor();

            this.txtHy_id.Properties.DisplayMember = "显示值";
            this.txtHy_id.Properties.ValueMember = "项目值";
            this.txtHy_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Hy_idByEditor();

            this.txtI_class_id.Properties.DisplayMember = "显示值";
            this.txtI_class_id.Properties.ValueMember = "项目值";
            this.txtI_class_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.I_class_idByEditor();

            this.txtCm_id.Properties.DisplayMember = "显示值";
            this.txtCm_id.Properties.ValueMember = "项目值";
            this.txtCm_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Cm_idByEditor();

            this.txtClients_credit.Properties.DisplayMember = "显示值";
            this.txtClients_credit.Properties.ValueMember = "项目值";
            this.txtClients_credit.Properties.DataSource = WHC.Dictionary.DictItemUtil.Clients_CreditbyEditor();

            this.txtO_id.Properties.DisplayMember = "显示值";
            this.txtO_id.Properties.ValueMember = "项目值";
            this.txtO_id.Properties.DataSource = SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtF_jb.Properties.DisplayMember = "显示值";
            this.txtF_jb.Properties.ValueMember = "项目值";
            this.txtF_jb.Properties.DataSource = WHC.Dictionary.DictItemUtil.F_jbByEditor();

            this.txtStation_id.Properties.DisplayMember = "显示值";
            this.txtStation_id.Properties.ValueMember = "项目值";
            this.txtStation_id.Properties.DataSource = SecurityUtil.GetValidStationForDropDown();

            this.txtStation_account.Properties.DisplayMember = "显示值";
            this.txtStation_account.Properties.ValueMember = "项目值";
            this.txtStation_account.Properties.DataSource = SecurityUtil.GetValidStationForDropDown();

            this.txtP_id.Properties.DisplayMember = "显示值";
            this.txtP_id.Properties.ValueMember = "项目值";
            this.txtP_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Pay_idByEditor();

             this.txtZn_path_id.Properties.DisplayMember = "显示值";
             this.txtZn_path_id.Properties.ValueMember = "项目值";
             this.txtZn_path_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.PathByEditor();

              this.txtFc_id.Properties.DisplayMember = "显示值";
              this.txtFc_id.Properties.ValueMember = "项目值";
              this.txtFc_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Fc_idByEditor();

            //this.txtF_account_style.Properties.DataSource=WHC.Dictionary.DictItemUtil

        }
        private void FrmEditFactory_Load(object sender, EventArgs e)
        {
            if (this.txtO_id_input.Text == string.Empty)
            {
                SetDefaultValue();
            }
            if (this.ID == string.Empty)
            {
                this.txtinput_dae.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            
           // this.Text = "货源信息";
            SetReadOnly();
            SelectChoese();
            Saved = true;

        }

        private void txtF_department_EditValueChanged(object sender, EventArgs e)
        {
            this.txtF_help_input.Text = Pinyin.GetFirstPY(this.txtF_department.Text);
        }

        private void txtStation_id_EditValueChanged(object sender, EventArgs e)
        {
            if (this.Text.Contains("新建"))
            {
                try
                {
                    this.txtF_id.Text = string.Format("G{0}{1:00000}", this.txtStation_id.EditValue.ToString(), CallerFactory<IFactoryService>.Instance.MaxCode(this.txtStation_id.EditValue.ToString()));
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
            this.txtO_id_input.EditValue = Portal.gc.LoginUserInfo.O_id;   
        }
        public override void SetControlReadOnly()
        {
            txtStation_id.Properties.ReadOnly = true;
            txtStation_account.Properties.ReadOnly = true;
        }
    }
}
