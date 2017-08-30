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
    /// Member
    /// </summary>
	public interface IMember : IBaseDAL<MemberInfo>
	{
        /// <summary>
        /// 返回会员信息简单实体列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        List<SimpleMemberInfo> GetMemberInfo(string where);

        /// <summary>
        /// 返回指定站点的最大会员编码
        /// </summary>
        /// <param name="station_Id">站点编码</param>
        /// <returns></returns>
        int MaxCode(string station_Id);
    }
}