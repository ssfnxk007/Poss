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
    /// Ls_card_surplus
    /// </summary>
	public class Ls_card_surplus : BaseBLL<Ls_card_surplusInfo>
    {
        public Ls_card_surplus() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
        /// <summary>
        /// 以卡号查询会员信息
        /// </summary>
        /// <param name="card">卡号</param>
        /// <returns></returns>
        public List<SimpleMemberInfo> GetMemberByCard(string card)
        {
            ILs_card_surplus Icard = baseDal as ILs_card_surplus;
            return Icard.GetMemberByCard(card);
        }
    }
}
