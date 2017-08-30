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
    /// Dz_paymethods
    /// </summary>
	public interface IDz_paymethods : IBaseDAL<Dz_paymethodsInfo>
	{
        /// <summary>
        /// 用于获取 收款方式列表
        /// </summary>
        /// <returns></returns>
        DataTable GetPaymathodsCombox();
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
         DataTable GetPossConfig();
    }
}