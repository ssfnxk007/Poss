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
        /// ���ڻ�ȡ �տʽ�б�
        /// </summary>
        /// <returns></returns>
        DataTable GetPaymathodsCombox();
        /// <summary>
        /// ��ѯ
        /// </summary>
        /// <returns></returns>
         DataTable GetPossConfig();
    }
}