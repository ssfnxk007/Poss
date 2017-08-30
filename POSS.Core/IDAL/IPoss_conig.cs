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
    /// Poss_conig
    /// </summary>
	public interface IPoss_conig : IBaseDAL<Poss_conigInfo>
	{
        /// <summary>
        /// �������� 
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        bool insetOrUpdate(Poss_conigInfo con);
        /// <summary>
        /// ��ѯ
        /// </summary>
        /// <returns></returns>
        List<Poss_conigInfo> GetPossConfig();
    }
}