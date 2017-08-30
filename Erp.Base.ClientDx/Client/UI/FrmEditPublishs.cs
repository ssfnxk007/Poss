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
    public partial class FrmEditPublishs : BaseEditForm
    {
    	/// <summary>
        /// 创建一个临时对象，方便在附件管理中获取存在的GUID
        /// </summary>
    	private PublishsInfo tempInfo = new PublishsInfo();

    	
        public FrmEditPublishs()
        {
            InitializeComponent();
            InitLookUpEditItem();
        }
                
        /// <summary>
        /// 实现控件输入检查的函数
        /// </summary>
        /// <returns></returns>
        public override bool CheckInput()
        {
            bool result = true;//默认是可以通过

            #region MyRegion
            if (this.txt_Pub_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入出版社编码");
                this.txtPub_name.Focus();
                result = false;
            }else
            if (this.txtPub_name.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入出版社名称");
                this.txtPub_name.Focus();
                result = false;
            }
            else
                if (this.txtClass_id.Text.Trim().Length == 0)
                {
                    MessageDxUtil.ShowTips("请选择出版社类别");
                    this.txtPub_name.Focus();
                    result = false;
                }
            #endregion

            return result;
        }

        private void InitLookUpEditItem()
        {
            txtO_id_input.EditValue = string.Empty;
            txtO_id_Lastmod.EditValue = string.Empty;
            txtP_charge_man.EditValue = string.Empty;
        }

        /// <summary>
        /// 初始化数据字典
        /// </summary>
        private void InitDictItem()
        {
			//初始化代码

            this.txtP_charge_man.Properties.DisplayMember = "显示值";
            this.txtP_charge_man.Properties.ValueMember = "项目值";
            this.txtP_charge_man.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_input.Properties.DisplayMember = "显示值";
            this.txtO_id_input.Properties.ValueMember = "项目值";
            this.txtO_id_input.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_Lastmod.Properties.DisplayMember = "显示值";
            this.txtO_id_Lastmod.Properties.ValueMember = "项目值";
            this.txtO_id_Lastmod.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();


            

        }                        

        /// <summary>
        /// 数据显示的函数
        /// </summary>
        public override void DisplayData()
        {
            InitDictItem();//数据字典加载（公用）

            if (MasterView!=null)
            {
                #region 显示信息
                tempInfo = MasterView.GetFocusedRow() as PublishsInfo;
             
                	 // temptempInfo = tempInfo;//重新给临时对象赋值，使之指向存在的记录对象
                      txt_Pub_id.Text = tempInfo.Pub_id;
                      txtPub_name.Text = tempInfo.Pub_name;
                      txtPub_fullname.Text = tempInfo.Pub_fullname;
                      txtTel.Text = tempInfo.Tel;
                      txtAddress.Text = tempInfo.Address;
                      txtZip.Text = tempInfo.Zip;
                      txtContact_man.Text = tempInfo.Contact_man;
                      txtP_help_input.Text = tempInfo.P_help_input;
                      txtClass_id.EditValue = tempInfo.Class_id;
                      txtP_charge_man.Text = tempInfo.P_charge_man;
                      this.txtO_id_Lastmod.EditValue = tempInfo.O_id_lastmodify;
                      this.txtInput_date.Text = tempInfo.Input_date.ToString("yyyy-MM-dd HH:mm:ss");
                      this.txtLastmod_date.Text = tempInfo.Last_mod_date.ToString("yyyy-MM-dd HH:mm:ss");
                      this.txtO_id_input.EditValue = tempInfo.O_id_input.ToString();
                #endregion
        
            }
           
        }



        public override void ClearScreen()
        {
            this.tempInfo = new PublishsInfo();
            base.ClearScreen();
        }

        /// <summary>
        /// 编辑或者保存状态下取值函数
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(PublishsInfo info)
        {
               info.Pub_id = txt_Pub_id.Text;
               info.Pub_name = txtPub_name.Text;
               info.Pub_fullname = txtPub_fullname.Text;
               info.Tel = txtTel.Text;
               info.Address = txtAddress.Text;
               info.Zip = txtZip.Text;
               info.Contact_man = txtContact_man.Text;
               info.P_help_input = txtP_help_input.Text;
               info.Class_id = txtClass_id.EditValue.ToString();
               info.P_charge_man = txtP_charge_man.Text;
               info.O_id_input = txtO_id_input.EditValue.ToString();
               info.O_id_lastmodify = txtO_id_Lastmod.EditValue.ToString();
               info.Input_date = txtLastmod_date.ToString().ToDateTime();
               info.Last_mod_date = txtLastmod_date.ToString().ToDateTime();
            
           }
         
        /// <summary>
        /// 新增状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveAddNew()
        {
            PublishsInfo info = tempInfo;//必须使用存在的局部变量，因为部分信息可能被附件使用
            SetInfo(info);
            info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;

            try
            {
                #region 新增数据

                bool succeed = CallerFactory<IPublishsService>.Instance.Insert(info);
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

            PublishsInfo info = CallerFactory<IPublishsService>.Instance.FindByID(tempInfo.Pub_id);
            if (info != null)
            {
                SetInfo(info);
                info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;


                try
                {
                    #region 更新数据
                    bool succeed = CallerFactory<IPublishsService>.Instance.Update(info, info.Pub_id);
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

        private void FrmEditPublishs_Load(object sender, EventArgs e)
        {   
            this.txtClass_id.Properties.DisplayMember = "显示值";
            this.txtClass_id.Properties.ValueMember = "项目值";
            this.txtClass_id.Properties.DataSource = WHC.Dictionary.DictItemUtil.Class_idByEditor();
            if (this.txtO_id_input.Text == string.Empty)
            {
                this.txtO_id_input.EditValue = Portal.gc.LoginUserInfo.O_id;
            }
            if (this.ID == string.Empty)
            {
                this.txtInput_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            Saved = true;
           
        }
        private void SetReadOnly()
        {
            if (this.ID != string.Empty)
            {
                this.txt_Pub_id.Properties.ReadOnly = true;

            }
        }

        private void txtPub_fullname_EditValueChanged(object sender, EventArgs e)
        {
            this.txtP_help_input.Text = Pinyin.GetFirstPY(this.txtAddress.Text);
        }
        public override void SetControlReadOnly()
        {
            txt_Pub_id.Properties.ReadOnly = true;
        }
    }
}
