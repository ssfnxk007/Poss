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
    /// Pos_muli_pay
    /// </summary>
	public class Pos_muli_pay : BaseBLL<Pos_muli_payInfo>
    {
        public Pos_muli_pay() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
        /// <summary>
        /// 零售单保存
        /// </summary>
        /// <param name="lsinof"></param>
        /// <param name="itemlist"></param>
        /// <param name="paylist"></param>
        /// <returns></returns>
        public LsInfo Save(LsInfo lsinof, List<Ls_itemInfo> itemlist, List<QueryPaymethods> paylist)
        {
            IPos_muli_pay ip = baseDal as IPos_muli_pay;
            return ip.Save(lsinof, itemlist, paylist);
        }
        /// <summary>
        /// 零售出库
        /// </summary>
        /// <param name="ls_id"></param>
        /// <returns></returns>
        public bool Is_stockLs(LsInfo ls_id)
        {
            IPos_muli_pay ip = baseDal as IPos_muli_pay;
            return ip.Is_stockLs(ls_id);
        }
    }
}
