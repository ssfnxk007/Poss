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
    /// Dz_paymethods
    /// </summary>
	public class Dz_paymethods : BaseBLL<Dz_paymethodsInfo>
    {
        public Dz_paymethods() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
        /// <summary>
        /// 用于获取 收款方式列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetPaymathodsCombox()
        {
            IDz_paymethods id = baseDal as IDz_paymethods;
            return id.GetPaymathodsCombox();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public DataTable GetPossConfig()
        {
            IDz_paymethods id = baseDal as IDz_paymethods;
            return id.GetPossConfig( );
        }
    }
}
