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

using WHC.Framework.ControlUtil.Facade;
using Erp.Base.ServiceCaller;
using Erp.Base.Facade;
using Erp.Base.Entity;

namespace Erp.Base.UI
{
    public partial class FrmEditMember : BaseEditForm
    {
    	/// <summary>
        /// ����һ����ʱ���󣬷����ڸ��������л�ȡ���ڵ�GUID
        /// </summary>
    	private MemberInfo tempInfo = new MemberInfo();
    	
        public FrmEditMember()
        {
            InitializeComponent();
            InitDictItem();
            txtO_id_input.EditValue = string.Empty;
            txtO_id_modify.EditValue = string.Empty;
        }
                
        /// <summary>
        /// ʵ�ֿؼ�������ĺ���
        /// </summary>
        /// <returns></returns>
        public override bool CheckInput()
        {
            bool result = true;//Ĭ���ǿ���ͨ��

            #region MyRegion
            if (this.txtM_name.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("�������Ա����");
                this.txtM_name.Focus();
                result = false;
            }

            if (this.txtM_type.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("��ѡ���Ա����");
                this.txtM_name.Focus();
                result = false;
            }
            if (txtM_zy.Text.Length==0)
            {
                MessageDxUtil.ShowTips("��ѡ���Ա���");
                this.txtM_zy.Focus();
                result = false;
            }
            #endregion

            return result;
        }

        /// <summary>
        /// ��ʼ�������ֵ�
        /// </summary>
        private void InitDictItem()
        {
			//��ʼ������
            #region �Ա�
            this.txtM_sex.Properties.DisplayMember = "��ʾֵ";
            this.txtM_sex.Properties.ValueMember = "��Ŀֵ";
            this.txtM_sex.Properties.DataSource = WHC.Dictionary.DictItemUtil.SexbyEditor();
            #endregion

            #region ����վ��/����վ��
            this.txtStation_id.Properties.DataSource = BaseUtil.GetAllStationForDropDown();
            this.txtStation_id_yg.Properties.DataSource = BaseUtil.GetAllStationForDropDown();
            #endregion

            #region ��Ա����
            this.txtM_type.Properties.DisplayMember = "��ʾֵ";
            this.txtM_type.Properties.ValueMember = "��Ŀֵ";
            this.txtM_type.Properties.DataSource = WHC.Dictionary.DictItemUtil.M_typeByEditor();
            #endregion

            #region ��Ա���
            this.txtM_zy.Properties.DisplayMember = "��ʾֵ";
            this.txtM_zy.Properties.ValueMember = "��Ŀֵ";
            this.txtM_zy.Properties.DataSource = WHC.Dictionary.DictItemUtil.M_zyByEditor();
            #endregion

            #region ��᷽ʽ
            this.txtM_join_type.Properties.DisplayMember = "��ʾֵ";
            this.txtM_join_type.Properties.ValueMember = "��Ŀֵ";
            this.txtM_join_type.Properties.DataSource = WHC.Dictionary.DictItemUtil.M_Join_typeByEditor();
            #endregion

            #region ����ҵ���޸��ˡ�������
            this.txtO_id_charge.Properties.DisplayMember = "��ʾֵ";
            this.txtO_id_charge.Properties.ValueMember = "��Ŀֵ";
            this.txtO_id_charge.Properties.DataSource = BaseUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_input.Properties.DisplayMember = "��ʾֵ";
            this.txtO_id_input.Properties.ValueMember = "��Ŀֵ";
            this.txtO_id_input.Properties.DataSource = BaseUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_modify.Properties.DisplayMember = "��ʾֵ";
            this.txtO_id_modify.Properties.ValueMember = "��Ŀֵ";
            this.txtO_id_modify.Properties.DataSource = BaseUtil.GetOperatorOrSaleManByEditor();

            #endregion

            #region �Ƿ��š��Ƿ�Ա�����Ƿ����ۡ��Ƿ���ġ��Ƿ��������Ƿ���Ч
            this.txtM_send_letter.Properties.DisplayMember = "��ʾֵ";
            this.txtM_send_letter.Properties.ValueMember = "��Ŀֵ";
            this.txtM_send_letter.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtFocus_flag.Properties.DisplayMember = "��ʾֵ";
            this.txtFocus_flag.Properties.ValueMember = "��Ŀֵ";
            this.txtFocus_flag.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtLs_flag.Properties.DisplayMember = "��ʾֵ";
            this.txtLs_flag.Properties.ValueMember = "��Ŀֵ";
            this.txtLs_flag.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtJy_flag.Properties.DisplayMember = "��ʾֵ";
            this.txtJy_flag.Properties.ValueMember = "��Ŀֵ";
            this.txtJy_flag.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtYg_flag.Properties.DisplayMember = "��ʾֵ";
            this.txtYg_flag.Properties.ValueMember = "��Ŀֵ";
            this.txtYg_flag.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();

            this.txtActive_flag.Properties.DisplayMember = "��ʾֵ";
            this.txtActive_flag.Properties.ValueMember = "��Ŀֵ";
            this.txtActive_flag.Properties.DataSource = WHC.Dictionary.DictItemUtil.YesOrNoByEditor();
            
            #endregion

            #region �ֻ�����
            this.txtM_mobile_type.Properties.DisplayMember = "��ʾֵ";
            this.txtM_mobile_type.Properties.ValueMember = "��Ŀֵ";
            this.txtM_mobile_type.Properties.DataSource = BaseUtil.MoblieTypeByEditor();
            #endregion

            #region ѧ��
            this.txtM_degree.Properties.DisplayMember = "��ʾֵ";
            this.txtM_degree.Properties.ValueMember = "��Ŀֵ";
            this.txtM_degree.Properties.DataSource = WHC.Dictionary.DictItemUtil.MemberDegreeByEditor();
            #endregion

            #region �������
            this.txtM_period.Properties.DisplayMember = "��ʾֵ";
            this.txtM_period.Properties.ValueMember = "��Ŀֵ";
            this.txtM_period.Properties.DataSource = WHC.Dictionary.DictItemUtil.MemberPeriodByEditor();
            #endregion

            #region ְ��
            this.txtM_zw.Properties.DisplayMember = "��ʾֵ";
            this.txtM_zw.Properties.ValueMember = "��Ŀֵ";
            this.txtM_zw.Properties.DataSource = WHC.Dictionary.DictItemUtil.DutyByEditor();
            #endregion

            #region ְҵ
            this.txtM_ziye.Properties.DisplayMember = "��ʾֵ";
            this.txtM_ziye.Properties.ValueMember = "��Ŀֵ";
            this.txtM_ziye.Properties.DataSource = WHC.Dictionary.DictItemUtil.MemberZyByEditor();
            #endregion

            #region �־ӳ���
            this.txtM_city.Properties.DisplayMember = "ʡ������";
            this.txtM_city.Properties.DisplayMember = "��������";
            this.txtM_city.Properties.ValueMember = "���б���";
            this.txtM_city.Properties.DataSource = WHC.Dictionary.DictItemUtil.CitysByEditor();
            #endregion

            #region �־�ʡ��
             this.txtM_province.Properties.DisplayMember = "��������";
             this.txtM_province.Properties.DisplayMember = "ʡ������";
             this.txtM_province.Properties.ValueMember = "ʡ�ݱ���";
            this.txtM_province.Properties.DataSource = WHC.Dictionary.DictItemUtil.ProvinceByEditor();
            #endregion

            #region ��������
            this.txtM_arears.Properties.DisplayMember = "��ʾֵ";
            this.txtM_arears.Properties.ValueMember = "��Ŀֵ";
            this.txtM_arears.Properties.DataSource = WHC.Dictionary.DictItemUtil.ArearsByEditor();
            #endregion

            #region ����ˮƽ
            this.txtM_income.Properties.DisplayMember = "��ʾֵ";
            this.txtM_income.Properties.ValueMember = "��Ŀֵ";
            this.txtM_income.Properties.DataSource = WHC.Dictionary.DictItemUtil.M_IncomeByEditor();
            #endregion

            #region ����
            this.txtM_native.Properties.DisplayMember = "��ʾֵ";
            this.txtM_native.Properties.ValueMember = "��Ŀֵ";
            this.txtM_native.Properties.DataSource = WHC.Dictionary.DictItemUtil.M_NativeByEditor();
            #endregion

            #region ����
            this.txtM_national.Properties.DisplayMember = "��ʾֵ";
            this.txtM_national.Properties.ValueMember = "��Ŀֵ";
            this.txtM_national.Properties.DataSource = WHC.Dictionary.DictItemUtil.M_NationalByEditor();

            #endregion

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
                tempInfo = MasterView.GetFocusedRow() as MemberInfo;
                if (tempInfo != null)
                {
                   
                     txtM_name.Text = tempInfo.M_name;
                      txtM_adress.Text = tempInfo.M_adress;
                      txtM_tel.Text = tempInfo.M_tel;
                      txtM_type.EditValue = tempInfo.M_type;
                      txtM_sex.EditValue = tempInfo.M_sex;
                      txtM_national.EditValue = tempInfo.M_national;
                      txtM_native.EditValue = tempInfo.M_native;
                      txtM_birthday.Text=tempInfo.M_birthday.ToString();	
                      txtM_ic.Text = tempInfo.M_ic;
                      txtM_email.Text = tempInfo.M_email;
                      txtMemo.Text = tempInfo.Memo;
                      txtM_password.Text = tempInfo.M_password;
                      txtM_help_input.Text = tempInfo.M_help_input;
                      txtM_city.EditValue = tempInfo.M_city;
                      txtM_province.EditValue = tempInfo.M_province;
                      txtM_arears.EditValue = tempInfo.M_arears;
                      txtM_corporation.Text = tempInfo.M_corporation;
                      txtM_zip.Text = tempInfo.M_zip;
                      txtM_degree.EditValue = tempInfo.M_degree;
                      txtCard_id.Text = tempInfo.Card_id;
                      txtStation_id.EditValue = tempInfo.Station_id;
                      txtJoin_date.Text = tempInfo.Join_date.ToString("yyyy/MM/dd");
                      txtEnd_date.Text = tempInfo.End_date.ToString("yyyy/MM/dd");	
                      txtO_id_input.EditValue = tempInfo.O_id_input;
                      txtActive_flag.EditValue = tempInfo.Active_flag;
                      txtLast_mod_date.Text = tempInfo.Last_mod_date.ToString("yyyy/MM/dd");	
                      txtM_id.Text = tempInfo.M_id;
                      txtM_zw.EditValue = tempInfo.M_zw;
                      txtM_zy.EditValue = tempInfo.M_zy;
                      txtM_period.EditValue = tempInfo.M_period;
                      txtM_income.EditValue = tempInfo.M_income;
                      txtJy_flag.EditValue = tempInfo.Jy_flag;
                      txtFocus_flag.EditValue = tempInfo.Focus_flag;
                      txtM_address_song.Text = tempInfo.M_address_song;
                      txtM_station.Text = tempInfo.M_station;
                      txtM_zip_song.Text = tempInfo.M_zip_song;
                      txtM_department_song.Text = tempInfo.M_department_song;
                      txtM_name_accept.Text = tempInfo.M_name_accept;
                      txtM_join_type.Text = tempInfo.M_join_type;
                      txtM_send_letter.EditValue = tempInfo.M_send_letter;
                      txtM_introduce.Text = tempInfo.M_introduce;
                      txtM_mobile.Text = tempInfo.M_mobile;
                      txtM_mobile_type.EditValue = tempInfo.M_mobile_type;
                      txtM_ziye.EditValue = tempInfo.M_ziye;
                      txtM_fax.Text = tempInfo.M_fax;
                      txtLs_flag.EditValue = tempInfo.Ls_flag;
                      txtYg_flag.EditValue = tempInfo.Yg_flag;
                      txtSum_date.Text = tempInfo.Sum_date.ToString("yyyy/MM/dd");
                      txtStation_id_yg.EditValue = tempInfo.Station_id_yg;
                      txtO_id_charge.EditValue = tempInfo.O_id_charge;
                      txtO_id_modify.EditValue = tempInfo.O_id_modify;
                      txtInput_date.Text = tempInfo.Input_date.ToString("yyyy/MM/dd");	
                    } 
                #endregion
                
            }
            else
            {
                                                                                    
            }
            
           
        }
        public override void ClearScreen()
        {
            this.tempInfo = new MemberInfo();
            base.ClearScreen();
        }

        /// <summary>
        /// �༭���߱���״̬��ȡֵ����
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(MemberInfo info)
        {
               info.M_name = txtM_name.Text;
               info.M_adress = txtM_adress.Text;
               info.M_tel = txtM_tel.Text;
               info.M_type = txtM_type.EditValue.ToString();
               info.M_sex = txtM_sex.EditValue.ToString();
               info.M_national = txtM_national.EditValue.ToString();
               info.M_native = txtM_native.EditValue.ToString();
               info.M_birthday = txtM_birthday.Text.ToDateTime();
               info.M_ic = txtM_ic.Text;
               info.M_email = txtM_email.Text;
               info.Memo = txtMemo.Text;
               info.M_password = txtM_password.Text;
               info.M_help_input = txtM_help_input.Text;
               info.M_city = txtM_city.EditValue.ToString();
               info.M_province = txtM_province.EditValue.ToString();
               info.M_arears = txtM_arears.EditValue.ToString();
               info.M_corporation = txtM_corporation.Text;
               info.M_zip = txtM_zip.Text;
               info.M_degree = txtM_degree.EditValue.ToString();
               info.Card_id = txtCard_id.Text;
               info.Station_id = txtStation_id.EditValue.ToString();
               info.Join_date = txtJoin_date.Text.ToDateTime();
               info.End_date = txtEnd_date.Text.ToDateTime();
               info.O_id_input = txtO_id_input.EditValue.ToString();
               info.Active_flag = txtActive_flag.EditValue.ToString();
               info.Last_mod_date = txtLast_mod_date.Text.ToDateTime();
               info.M_id = txtM_id.Text;
               info.M_zw = txtM_zw.EditValue.ToString();
               info.M_zy = txtM_zy.EditValue.ToString();
               info.M_period = txtM_period.EditValue.ToString();
               info.M_income = txtM_income.EditValue.ToString();
               info.Jy_flag = txtJy_flag.EditValue.ToString();
               info.Focus_flag = txtFocus_flag.EditValue.ToString();
               info.M_address_song = txtM_address_song.Text;
               info.M_station = txtM_station.Text;
               info.M_zip_song = txtM_zip_song.Text;
               info.M_department_song = txtM_department_song.Text;
               info.M_name_accept = txtM_name_accept.Text;
               info.M_join_type = txtM_join_type.EditValue.ToString();
               info.M_send_letter = txtM_send_letter.EditValue.ToString();
               info.M_introduce = txtM_introduce.Text;
               info.M_mobile = txtM_mobile.Text;
               info.M_mobile_type = txtM_mobile_type.EditValue.ToString();
               info.M_ziye = txtM_ziye.EditValue.ToString();
               info.M_fax = txtM_fax.Text;
               info.Ls_flag = txtLs_flag.EditValue.ToString();
               info.Yg_flag = txtYg_flag.EditValue.ToString();
               info.Sum_date = txtSum_date.Text.ToDateTime();
               info.Station_id_yg = txtStation_id_yg.EditValue.ToString();
               info.O_id_charge = txtO_id_charge.EditValue.ToString();
               info.O_id_modify = txtO_id_modify.EditValue.ToString();
               info.Input_date = txtInput_date.Text.ToDateTime();
           }
         
        /// <summary>
        /// ����״̬�µ����ݱ���
        /// </summary>
        /// <returns></returns>
        public override bool SaveAddNew()
        {

            tempInfo = new MemberInfo();//����ʹ�ô��ڵľֲ���������Ϊ������Ϣ���ܱ�����ʹ��
            SetInfo(tempInfo);
            tempInfo.O_id_modify = Portal.gc.LoginUserInfo.O_id;
            try
            {
                #region ��������
                //����Ƿ���������ͬ�ؼ��ֵļ�¼
                bool exist = CallerFactory<IMemberService>.Instance.IsExistKey("card_id", tempInfo.Card_id);
                if (exist)
                {
                    MessageDxUtil.ShowTips(string.Format("����{0}�Ѵ���,������", txtCard_id.Text));
                    return false;
                }

                bool succeed = CallerFactory<IMemberService>.Instance.Insert(tempInfo);
                if (succeed)
                {
                    //�����������������
                    if (MasterView.DataSource != null)
                    {
                        ((List<MemberInfo>)this.MasterView.DataSource).Add(tempInfo);
                        MasterView.RefreshData();
                        MasterView.MoveLast();
                        this.rowIndex = MasterView.FocusedRowHandle;
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
        /// �༭״̬�µ����ݱ���
        /// </summary>
        /// <returns></returns>
        public override bool SaveUpdated()
        {
            string condition = string.Format("card_id ='{0}' and m_id <> '{1}' ", this.txtCard_id.Text, txtM_id.Text);
            bool exist = CallerFactory<IMemberService>.Instance.IsExistRecord(condition);
            if (exist)
            {
                MessageDxUtil.ShowTips(string.Format("����{0}�Ѵ���,������",txtCard_id.Text));
                return false;
            }

            MemberInfo info = CallerFactory<IMemberService>.Instance.FindByID(tempInfo.M_id);
            if (info != null)
            {
                SetInfo(info);
                info.O_id_modify = Portal.gc.LoginUserInfo.O_id;

                try
                {
                    #region ��������
                    bool succeed = CallerFactory<IMemberService>.Instance.Update(info, info.M_id);
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

        private void FrmEditMember_Load(object sender, EventArgs e)
        {
            if (this.txtO_id_input.EditValue.ToString() == string.Empty)
            {
                txtO_id_input.EditValue=Portal.gc.LoginUserInfo.O_id;
            }
            if (this.ID == string.Empty)
            {
                this.txtInput_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.btnFeedback.Enabled = false;
            }
            Saved = true;
        }

        private void txtStation_id_EditValueChanged(object sender, EventArgs e)
        {
            if (this.Text.Contains("�½�"))
            {
                try
                {
                    this.txtM_id.Text = string.Format("MM{0}{1:000000000}", this.txtStation_id.EditValue.ToString(), CallerFactory<IMemberService>.Instance.MaxCode(this.txtStation_id.EditValue.ToString()));
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
            }
        }

        private void txtM_birthday_EditValueChanged(object sender, EventArgs e)
        {
          int age = System.DateTime.Now.ToString().Substring(0, 4).ToInt32()-txtM_birthday.Text.Substring(0, 4).ToInt32();
          txtM_age.Text = age.ToString();
        }

        private void btnHobby_Click(object sender, EventArgs e) 
        {
            FrmEditWg_card f = new FrmEditWg_card();
            f.N_M_id = this.txtM_id.Text;
            f.N_M_name = this.txtM_name.Text;
            f.N_M_tel = this.txtM_tel.Text;
            f.N_Station_id = this.txtStation_id.EditValue.ToString();
            f.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        public override void SetDefault()
        {
            txtLs_flag.EditValue="1";
            txtJy_flag.EditValue="1";
            txtYg_flag.EditValue = "1";
            txtM_sex.EditValue = "0";
            txtSum_date.EditValue = DateTime.Now;
            txtJoin_date.EditValue = DateTime.Now;
            txtEnd_date.EditValue = DateTime.Now.AddYears(2);
        }
        public override void SetControlReadOnly()
        {
            this.txtCard_id.Properties.ReadOnly = true;
            this.txtStation_id.Properties.ReadOnly = true;

        }
       
    }
}
