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
    public partial class FrmEditWg_card : BaseEditForm
    {
    	/// <summary>
        /// 创建一个临时对象，方便在附件管理中获取存在的GUID
        /// </summary>
    	private Wg_cardInfo tempInfo = new Wg_cardInfo();
        private string n_M_id;
        private string n_M_name;
        private string n_M_tel;
        private string n_Station_id;

     
        public string N_M_tel
        {
            get { return n_M_tel; }
            set { n_M_tel = value; }
        }

        public string N_M_name
        {
            get { return n_M_name; }
            set { n_M_name = value; }
        }

        public string N_M_id
        {
            get { return n_M_id; }
            set { n_M_id = value; }
        }

        public string N_Station_id
        {
            get { return n_Station_id; }
            set { n_Station_id = value; }
        }
    	
        public FrmEditWg_card()
        {
            InitializeComponent();
        }
                
        /// <summary>
        /// 实现控件输入检查的函数
        /// </summary>
        /// <returns></returns>
        public override bool CheckInput()
        {
            bool result = true;//默认是可以通过

            #region MyRegion
            if (this.txtM_id.Text.Trim().Length == 0)
            {
                MessageDxUtil.ShowTips("请输入");
                this.txtM_id.Focus();
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
            this.txtStation_id.Properties.DataSource = BaseUtil.GetAllStationForDropDown();
            this.txtInput_o_id.Properties.DisplayMember = "显示值";
            this.txtInput_o_id.Properties.ValueMember = "项目值";
            this.txtInput_o_id.Properties.DataSource = BaseUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_lastmd.Properties.DisplayMember = "显示值";
            this.txtO_id_lastmd.Properties.ValueMember = "项目值";
            this.txtO_id_lastmd.Properties.DataSource = BaseUtil.GetOperatorOrSaleManByEditor();

            this.txtAct_id.Properties.DisplayMember = "显示值";
            this.txtAct_id.Properties.ValueMember = "项目值";
            this.txtAct_id.Properties.DataSource = BaseUtil.FeedBackLevelByEditor();

            this.txtDef_id.Properties.DisplayMember = "显示值";
            this.txtDef_id.Properties.ValueMember = "项目值";
            this.txtDef_id.Properties.DataSource = BaseUtil.FeedBackLevelByEditor();

            this.txtPack_id.Properties.DisplayMember = "显示值";
            this.txtPack_id.Properties.ValueMember = "项目值";
            this.txtPack_id.Properties.DataSource = BaseUtil.FeedBackLevelByEditor();

            this.txtPrice_id.Properties.DisplayMember = "显示值";
            this.txtPrice_id.Properties.ValueMember = "项目值";
            this.txtPrice_id.Properties.DataSource = BaseUtil.PriceLevelByEditor();

            this.txtSc_id.Properties.DisplayMember = "显示值";
            this.txtSc_id.Properties.ValueMember = "项目值";
            this.txtSc_id.Properties.DataSource = BaseUtil.FeedBackLevelByEditor();




        }                        

        /// <summary>
        /// 数据显示的函数
        /// </summary>
        public override void DisplayData()
        {
            InitDictItem();//数据字典加载（公用）

            if (!string.IsNullOrEmpty(this.txtCd_id.Text))
            {
                #region 显示信息
                Wg_cardInfo info = CallerFactory<IWg_cardService>.Instance.FindByID(this.txtCd_id.Text);
                if (info != null)
                {
                	tempInfo = info;//重新给临时对象赋值，使之指向存在的记录对象
                    //this.ID = info.Cd_id;
                    txtCd_id.Text = info.Cd_id;
                    txtO_id_lastmd.EditValue = info.O_id_lastmod;
                      txtInput_date.Text=info.Input_date.ToString("yyyy-MM-dd HH:mm:ss");	
                      txtInput_o_id.EditValue = info.Input_o_id;
                      txtBuy_product.Text = info.Buy_product;
                      txtBuy_date.Text = info.Buy_date.ToString("yyyy-MM-dd HH:mm:ss");	
                      txtBuy_address.Text = info.Buy_address;
                      txtWant_product.Text = info.Want_product;
                      txtSuggestion.Text = info.Suggestion;
                      txtAct_id.EditValue = info.Act_id;
                      txtPack_id.EditValue = info.Pack_id;
                      txtDef_id.EditValue = info.Def_id;
                      txtSc_id.EditValue = info.Sc_id;
                      txtPrice_id.EditValue = info.Price_id;
                      txtMessage.Text = info.Message;
                      txtCl_date.Text = info.Cl_date.ToString("yyyy-MM-dd HH:mm:ss");
                      txtLast_mod_date.Text = info.Last_mod_date.ToString("yyyy-MM-dd HH:mm:ss");
                } 
                #endregion
                //this.btnOK.Enabled = Portal.gc.HasFunction("Wg_card/Edit");             
            }
            else
            {
                                   //this.btnOK.Enabled = Portal.gc.HasFunction("Wg_card/Add");  
            }
            
            //tempInfo在对象存在则为指定对象，新建则是全新的对象，但有一些初始化的GUID用于附件上传
            //SetAttachInfo(tempInfo);
        }

        //private void SetAttachInfo(Wg_cardInfo info)
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
            this.tempInfo = new Wg_cardInfo();
            base.ClearScreen();
        }

        /// <summary>
        /// 编辑或者保存状态下取值函数
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(Wg_cardInfo info)
        {
            info.M_id = txtM_id.Text;
            info.Input_date = txtInput_date.Text.ToDateTime(); ;
            info.O_id_lastmod = txtO_id_lastmd.EditValue.ToString();
               info.Input_o_id = txtInput_o_id.EditValue.ToString();
               info.Buy_product = txtBuy_product.Text;
               info.Buy_date = txtBuy_date.DateTime;
               info.Buy_address = txtBuy_address.Text;
               info.Want_product = txtWant_product.Text;
               info.Suggestion = txtSuggestion.Text;
               info.Act_id = txtAct_id.EditValue.ToString();
               info.Pack_id = txtPack_id.EditValue.ToString();
               info.Def_id = txtDef_id.EditValue.ToString();
               info.Sc_id = txtSc_id.EditValue.ToString();
               info.Price_id = txtPrice_id.EditValue.ToString();
               info.Message = txtMessage.Text;
               info.Cl_date = txtCl_date.DateTime;
               info.Last_mod_date = txtLast_mod_date.Text.ToDateTime();
               info.Cd_id = txtCd_id.Text;
               info.Station_id = txtStation_id.EditValue.ToString();
           }
         
        /// <summary>
        /// 新增状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveAddNew()
        {
            Wg_cardInfo info = tempInfo;//必须使用存在的局部变量，因为部分信息可能被附件使用
            SetInfo(info);
            info.O_id_lastmod = Portal.gc.LoginUserInfo.O_id;

            try
            {
                #region 新增数据

                bool succeed = CallerFactory<IWg_cardService>.Instance.Insert(info);
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

            Wg_cardInfo info = CallerFactory<IWg_cardService>.Instance.FindByID(ID);
            if (info != null)
            {
                SetInfo(info);
                info.O_id_lastmod = Portal.gc.LoginUserInfo.O_id;

                try
                {
                    #region 更新数据
                    bool succeed = CallerFactory<IWg_cardService>.Instance.Update(info, info.Cd_id);
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

        private void FrmEditWg_card_Load(object sender, EventArgs e)
        {
            txtM_id.Text = n_M_id;
            txtM_name.Text = n_M_name;
            txtStation_id.EditValue = n_Station_id;
            txtM_tel.Text = n_M_tel;
            DisplayData();
            if (this.txtInput_o_id.EditValue.ToString() == string.Empty)
            {
                this.txtInput_o_id.EditValue = Portal.gc.LoginUserInfo.O_id;
            }
            if (this.ID == string.Empty)
            {
                this.txtInput_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            Saved = true;
        }

        private void txtStation_id_EditValueChanged(object sender, EventArgs e)
        {
            if (this.Text.Contains("新建"))
            {
                try
                {
                    this.txtCd_id.Text = string.Format("MK{0}{1:000000000}", this.txtStation_id.EditValue.ToString(), CallerFactory < IWg_cardService>.Instance.MaxCode(this.txtStation_id.EditValue.ToString()));
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
            }
        }

   

     
    }
}
