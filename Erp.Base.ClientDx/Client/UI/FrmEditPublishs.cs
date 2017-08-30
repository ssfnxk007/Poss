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
        /// ����һ����ʱ���󣬷����ڸ��������л�ȡ���ڵ�GUID
        /// </summary>
    	private PublishsInfo tempInfo = new PublishsInfo();

    	
        public FrmEditPublishs()
        {
            InitializeComponent();
            InitLookUpEditItem();
        }
                
        /// <summary>
        /// ʵ�ֿؼ�������ĺ���
        /// </summary>
        /// <returns></returns>
        public override bool CheckInput()
        {
            bool result = true;//Ĭ���ǿ���ͨ��

            #region MyRegion
            if (this.txt_Pub_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("��������������");
                this.txtPub_name.Focus();
                result = false;
            }else
            if (this.txtPub_name.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("���������������");
                this.txtPub_name.Focus();
                result = false;
            }
            else
                if (this.txtClass_id.Text.Trim().Length == 0)
                {
                    MessageDxUtil.ShowTips("��ѡ����������");
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
        /// ��ʼ�������ֵ�
        /// </summary>
        private void InitDictItem()
        {
			//��ʼ������

            this.txtP_charge_man.Properties.DisplayMember = "��ʾֵ";
            this.txtP_charge_man.Properties.ValueMember = "��Ŀֵ";
            this.txtP_charge_man.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_input.Properties.DisplayMember = "��ʾֵ";
            this.txtO_id_input.Properties.ValueMember = "��Ŀֵ";
            this.txtO_id_input.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_Lastmod.Properties.DisplayMember = "��ʾֵ";
            this.txtO_id_Lastmod.Properties.ValueMember = "��Ŀֵ";
            this.txtO_id_Lastmod.Properties.DataSource = WHC.Security.SecurityUtil.GetOperatorOrSaleManByEditor();


            

        }                        

        /// <summary>
        /// ������ʾ�ĺ���
        /// </summary>
        public override void DisplayData()
        {
            InitDictItem();//�����ֵ���أ����ã�

            if (MasterView!=null)
            {
                #region ��ʾ��Ϣ
                tempInfo = MasterView.GetFocusedRow() as PublishsInfo;
             
                	 // temptempInfo = tempInfo;//���¸���ʱ����ֵ��ʹָ֮����ڵļ�¼����
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
        /// �༭���߱���״̬��ȡֵ����
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
        /// ����״̬�µ����ݱ���
        /// </summary>
        /// <returns></returns>
        public override bool SaveAddNew()
        {
            PublishsInfo info = tempInfo;//����ʹ�ô��ڵľֲ���������Ϊ������Ϣ���ܱ�����ʹ��
            SetInfo(info);
            info.O_id_lastmodify = Portal.gc.LoginUserInfo.O_id;

            try
            {
                #region ��������

                bool succeed = CallerFactory<IPublishsService>.Instance.Insert(info);
                if (succeed)
                {
                    //�����������������

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
        /// �༭״̬�µ����ݱ���
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
                    #region ��������
                    bool succeed = CallerFactory<IPublishsService>.Instance.Update(info, info.Pub_id);
                    if (succeed)
                    {
                        //�����������������
                       
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
            this.txtClass_id.Properties.DisplayMember = "��ʾֵ";
            this.txtClass_id.Properties.ValueMember = "��Ŀֵ";
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
