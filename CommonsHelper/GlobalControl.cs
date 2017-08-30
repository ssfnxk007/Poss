using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using WHC.Framework.Commons;
using POSS.Entity;

namespace POSS
{
    public class GlobalControl
    {
        #region 系统全局变量

       
       //public List<PaymethodsInfo> PayMethods = new List<PaymethodsInfo>();
        public RoundType roundType =RoundType.BRMToJiao ;

        /// <summary>
        /// 默认皮肤
        /// </summary>
        public string DefautlStyle
        {
            get
            {
                string result = Portal.iniHelper.IniReadValue("DefaultStyle", "DefaultStyle");
                if (string.IsNullOrWhiteSpace(result))
                    result = "Office 2010 Blue";
                return result;
            }
            set
            {
                Portal.iniHelper.IniWriteValue("DefaultStyle", "DefaultStyle", value);
            }
        }


        #endregion
        public LoginUserInfo loginUserInfo = null;
        ///<summary>
        ///转换框架通用的用户基础信息，方便框架使用
        ///</summary>
        ///<param name="info">权限系统定义的用户信息</param>
        ///<returns></returns>
        public LoginUserInfo ConvertToLoginUser(UsersInfo info)
        {
            LoginUserInfo loginInfo = new LoginUserInfo();
            loginInfo.O_id = info.O_id;
            loginInfo.O_Name = info.O_name;
            loginInfo.Station_ID = info.Station_id;
            loginInfo.Stock_id = info.Stock_id;
           
            loginInfo.Yh_stand_id = info.Yh_stand_id;
            loginInfo.is_sl = info.Is_sl;
            loginInfo.is_zk = info.Is_zk;
            loginInfo.is_zl = info.Is_zl;
            return loginInfo;
        }

        public QueryPossConfig QPossConfig = null;
        /// <summary>
        /// 转换框架通用的 系统设置 ，方便框架使用
        /// </summary>
        /// <param name="Pinfo">全据系统设置</param>
        /// <returns></returns>
        public QueryPossConfig ConvertToPossConfig(Poss_conigInfo Pinfo)
        {
            QueryPossConfig info = new QueryPossConfig();
            info.Id = Pinfo.Id;
            info.Is_jifen = Pinfo.Is_jifen;
            info.Is_ysdh = Pinfo.Is_ysdh;
            info.Taosu = Pinfo.Taosu;
            info.Wx_appid = Pinfo.Wx_appid;
            info.Wx_appsecret = Pinfo.Wx_appsecret;
            info.Wx_key = Pinfo.Wx_kdy;
            info.Wx_mchid = Pinfo.Wx_mchid;
            info.Wx_miaosu = Pinfo.Wx_miaosu;
            info.Is_qtjl = Pinfo.Is_qtjl;
            info.Ls_jfdhbl = Pinfo.Ls_jfdhbl;
            info.Ls_qltfs = Pinfo.Ls_qltfs;
            info.Is_xitongshu = Pinfo.Is_xitongshu;
            //下面是支付宝的
            info.Zfb_alipay_public_key = Pinfo.Zfb_alipay_public_key;
            info.Zfb_appid = Pinfo.Zfb_appid;
            info.Zfb_merchant_private_key = Pinfo.Zfb_merchant_private_key;
            info.Zfb_merchant_public_key = Pinfo.Zfb_merchant_public_key;
            info.Zfb_miaoshu = Pinfo.Zfb_miaoshu;
            info.Zfb_pid = Pinfo.Zfb_pid;
            info.Is_MoveMember = Pinfo.Is_MoveMember;
            return info;
        }

        
    }
}
