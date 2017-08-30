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
    /// Ls_card_surplus
    /// </summary>
	public interface ILs_card_surplus : IBaseDAL<Ls_card_surplusInfo>
	{
        /// <summary>
        /// 以卡号查询会员信息
        /// </summary>
        /// <param name="card">卡号</param>
        /// <returns></returns>
        List<SimpleMemberInfo> GetMemberByCard(string card);
    }
}