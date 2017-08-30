using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;


using WHC.Framework.Commons;
using WHC.Security.Entity;
using WHC.Framework.ControlUtil.Facade;
using WHC.Security.Facade;
using WHC.Security.Common;

namespace Erp.Base
{
    public class GlobalControl
    {
        #region 系统全局变量

        public string AppUnit = string.Empty; //单位名称
        public string AppName = string.Empty;  //程序名称
        public string AppWholeName = string.Empty;//单位名称+程序名称
        public string SystemType = "BMS";//系统类型

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

        public LoginUserInfo LoginUserInfo = null;//登陆用户基础信息  
        public LoginStationInfo LoginStationInfo = null; //登陆站点基础信息
        public LoginOwnerInfo LoginOwnerInfo = null;//本单位基础信息

        public Dictionary<string, string> FunctionDict = new Dictionary<string, string>();//登录用户具有的功能字典集合
        public OperatorsInfo UserInfo = null;//登录用户信息
        public Station_totalInfo StationInfo = null; //登陆站点信息
        public OwnerInfo OwnerInfo = null;//本单位信息

        #endregion

        #region 基本操作函数

        ///<summary>
        ///转换框架通用的用户基础信息，方便框架使用
        ///</summary>
        ///<param name="info">权限系统定义的用户信息</param>
        ///<returns></returns>
        public LoginUserInfo ConvertToLoginUser(OperatorsInfo info)
        {
            LoginUserInfo loginInfo = new LoginUserInfo();
            loginInfo.O_id = info.O_id;
            loginInfo.O_Name = info.O_name;
            loginInfo.Station_ID = info.Station_id;
            loginInfo.D_id = info.D_id;
            loginInfo.StationList = new List<string>();
            string[] slist = info.O_stationlist.Split(',');
            foreach (string s in slist)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    loginInfo.StationList.Add(s);
                }
            }
            return loginInfo;
        }

        ///<summary>
        ///转换框架通用的站点基础信息，方便框架使用
        ///</summary>
        ///<param name="info">登陆的站点信息</param>
        ///<returns></returns>
        public LoginStationInfo ConvertToLoginStation(Station_totalInfo info)
        {
            LoginStationInfo loginInfo = new LoginStationInfo();
            loginInfo.Station_id = info.Station_id;
            loginInfo.Station_name = info.Station_name;
            loginInfo.Station_shortame = info.Short_name;
            loginInfo.Input_flag = info.Input_flag.ToBoolean();
            loginInfo.Is_allowimport = info.Is_allowimport.ToBoolean();
            loginInfo.Local_flag = info.Local_flag.ToBoolean();
            return loginInfo;
        }

        ///<summary>
        ///转换框架通用的本单位基础信息，方便框架使用
        ///</summary>
        ///<param name="info">详细的本单位信息</param>
        ///<returns></returns>
        public LoginOwnerInfo ConvertToLoginOwner(OwnerInfo info)
        {
            LoginOwnerInfo loginInfo = new LoginOwnerInfo();
            loginInfo.Account = info.Ow_account;
            loginInfo.Address = info.Ow_address;
            loginInfo.Bank = info.Ow_bank;
            loginInfo.Compute_method = info.Compute_method;
            loginInfo.Database_id = info.Database_id;
            loginInfo.Department = info.Ow_department;
            loginInfo.Fax = info.Ow_fax;
            loginInfo.Is_posserver = info.Is_posserver.ToBoolean();
            loginInfo.Ow_mail = info.Ow_mail;
            loginInfo.Tax = info.Ow_tax;
            loginInfo.Tax_account = info.Ow_tax_account;
            loginInfo.Tax_address = info.Ow_tax_address;
            loginInfo.Tax_bank = info.Ow_tax_bank;
            loginInfo.Tel = info.Ow_tel;
            loginInfo.Zip = info.Ow_zip;
            return loginInfo;
        }

        /// <summary>
        /// 看用户是否具有某个功能
        /// </summary>
        /// <param name="controlID"></param>
        /// <returns></returns>
        public bool HasFunction(string controlID)
        {
            bool result = false;
            if (FunctionDict.ContainsKey("Super")) return true;
            if (string.IsNullOrEmpty(controlID))
            {
                result = true;
            }
            else if (FunctionDict != null && FunctionDict.ContainsKey(controlID))
            {
                result = true;
            }

            return result;
        }




        #endregion
    }
}
