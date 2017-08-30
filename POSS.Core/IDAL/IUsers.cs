using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;

using WHC.Pager.Entity;
using WHC.Framework.ControlUtil;
using POSS.Entity;

namespace POSS.IDAL
{
    /// <summary>
    /// Users
    /// </summary>
	public interface IUsers : IBaseDAL<UsersInfo>
	{
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <returns></returns>
        List<Query_OperatorsInfo> GetO_id();
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <returns></returns>
        List<Query_Station_totalInfo> GetSatation_idByName();

        /// <summary>
        /// 获取库房信息
        /// </summary>
        /// <returns></returns>
        List<Query_stocksInfo> GetStocks_idByName();

        /// <summary>
        /// 获取零售台号
        /// </summary>
        /// <returns></returns>
        List<Query_StandInfo> GetStand_idByName();

        /// <summary>
        /// 保存或更新用户表
        /// </summary>
        /// <param name="usinfo"></param>
        /// <returns></returns>
        bool SaveUser(UsersInfo usinfo);
        /// <summary>
        /// 用户信息
        /// </summary>
        /// <returns></returns>
        List<UsersInfo> GetUsers_idByName();

        /// <summary>
        /// 验证用户密码
        /// </summary>
        /// <returns></returns>
        List<UsersInfo> Validation_Users(string o_id);

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <param name="o_id"></param>
        /// <returns></returns>
        List<UsersInfo> GetDengLuInfo(string o_id);
    }
}