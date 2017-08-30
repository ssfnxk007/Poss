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
    /// Pos_muli_pay
    /// </summary>
	public interface IPos_muli_pay : IBaseDAL<Pos_muli_payInfo>
	{
        /// <summary>
        /// 零售单保存
        /// </summary>
        /// <param name="lsinof"></param>
        /// <param name="itemlist"></param>
        /// <param name="paylist"></param>
        /// <returns></returns>
         LsInfo Save(LsInfo lsinof, List<Ls_itemInfo> itemlist, List<QueryPaymethods> paylist);
        /// <summary>
        /// 零售出库
        /// </summary>
        /// <param name="ls_id"></param>
        /// <returns></returns>
        bool Is_stockLs(LsInfo ls_id);
    }
}