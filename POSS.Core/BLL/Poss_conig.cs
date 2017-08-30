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
    /// Poss_conig
    /// </summary>
	public class Poss_conig : BaseBLL<Poss_conigInfo>
    {
        public Poss_conig() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
        /// <summary>
        /// 插入或更新 
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public bool insetOrUpdate(Poss_conigInfo con)
        {
            IPoss_conig ip = baseDal as IPoss_conig;
            return ip.insetOrUpdate(con);
        }        /// <summary>
                 /// 查询
                 /// </summary>
                 /// <returns></returns>
        public List<Poss_conigInfo> GetPossConfig()
        {
            IPoss_conig ip = baseDal as IPoss_conig;
            return ip.GetPossConfig();
        }
    }
}
