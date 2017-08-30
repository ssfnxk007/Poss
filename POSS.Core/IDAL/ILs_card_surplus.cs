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
        /// �Կ��Ų�ѯ��Ա��Ϣ
        /// </summary>
        /// <param name="card">����</param>
        /// <returns></returns>
        List<SimpleMemberInfo> GetMemberByCard(string card);
    }
}