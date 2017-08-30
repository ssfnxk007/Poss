using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;

using POSS.Entity;
using POSS.IDAL;
using WHC.Pager.Entity;
using WHC.Framework.ControlUtil;

namespace POSS.BLL
{
    /// <summary>
    /// Users
    /// </summary>
	public class Users : BaseBLL<UsersInfo>
    {
        public Users() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }

       
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <returns></returns>
        public List<Query_OperatorsInfo> GetO_id()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetO_id();
        }

        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <returns></returns>
        public List<Query_Station_totalInfo> GetSatation_idByName()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetSatation_idByName();
        }
        /// <summary>
        /// 获取库房信息
        /// </summary>
        /// <returns></returns>
        public List<Query_stocksInfo> GetStocks_idByName()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetStocks_idByName();
        }
        /// <summary>
        /// 获取零售台号
        /// </summary>
        /// <returns></returns>
        public List<Query_StandInfo> GetStand_idByName()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetStand_idByName();
        }
        /// <summary>
        /// 保存或更新用户表
        /// </summary>
        /// <param name="usinfo"></param>
        /// <returns></returns>
        public bool SaveUser(UsersInfo usinfo)
        {
            IUsers iu = baseDal as IUsers;
            return iu.SaveUser(usinfo);
        }

        /// <summary>
        /// 用户信息
        /// </summary>
        /// <returns></returns>
        public List<UsersInfo> GetUsers_idByName()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetUsers_idByName();
        }
        /// <summary>
        /// 验证用户密码
        /// </summary>
        /// <returns></returns>
        public List<UsersInfo> Validation_Users(string o_id)
        {
            IUsers iu = baseDal as IUsers;
            return iu.Validation_Users(o_id);
        }

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <param name="o_id"></param>
        /// <returns></returns>
        public List<UsersInfo> GetDengLuInfo(string o_id)
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetDengLuInfo(o_id);
        }
    }
}
