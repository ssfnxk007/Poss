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
    /// Member
    /// </summary>
	public class Member : BaseBLL<MemberInfo>
    {
        public Member() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
        /// <summary>
        /// ���ػ�Ա��Ϣ��ʵ���б�
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<SimpleMemberInfo> GetMemberInfo(string where)
        {
            IMember im = baseDal as IMember;
            return im.GetMemberInfo(where);
        }
        /// <summary>
        /// ����ָ��վ�������Ա����
        /// </summary>
        /// <param name="station_Id">վ�����</param>
        /// <returns></returns>
        public int MaxCode(string station_Id)
        {
            IMember im = baseDal as IMember;
            return im.MaxCode(station_Id);
        }
    }
}
