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
    /// Member
    /// </summary>
	public interface IMember : IBaseDAL<MemberInfo>
	{
        /// <summary>
        /// ���ػ�Ա��Ϣ��ʵ���б�
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        List<SimpleMemberInfo> GetMemberInfo(string where);

        /// <summary>
        /// ����ָ��վ�������Ա����
        /// </summary>
        /// <param name="station_Id">վ�����</param>
        /// <returns></returns>
        int MaxCode(string station_Id);
    }
}