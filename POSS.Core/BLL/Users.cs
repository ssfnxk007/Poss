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
    /// Users
    /// </summary>
	public class Users : BaseBLL<UsersInfo>
    {
        public Users() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }

       
        /// <summary>
        /// ��ȡԱ����Ϣ
        /// </summary>
        /// <returns></returns>
        public List<Query_OperatorsInfo> GetO_id()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetO_id();
        }

        /// <summary>
        /// ��ȡվ����Ϣ
        /// </summary>
        /// <returns></returns>
        public List<Query_Station_totalInfo> GetSatation_idByName()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetSatation_idByName();
        }
        /// <summary>
        /// ��ȡ�ⷿ��Ϣ
        /// </summary>
        /// <returns></returns>
        public List<Query_stocksInfo> GetStocks_idByName()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetStocks_idByName();
        }
        /// <summary>
        /// ��ȡ����̨��
        /// </summary>
        /// <returns></returns>
        public List<Query_StandInfo> GetStand_idByName()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetStand_idByName();
        }
        /// <summary>
        /// ���������û���
        /// </summary>
        /// <param name="usinfo"></param>
        /// <returns></returns>
        public bool SaveUser(UsersInfo usinfo)
        {
            IUsers iu = baseDal as IUsers;
            return iu.SaveUser(usinfo);
        }

        /// <summary>
        /// �û���Ϣ
        /// </summary>
        /// <returns></returns>
        public List<UsersInfo> GetUsers_idByName()
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetUsers_idByName();
        }
        /// <summary>
        /// ��֤�û�����
        /// </summary>
        /// <returns></returns>
        public List<UsersInfo> Validation_Users(string o_id)
        {
            IUsers iu = baseDal as IUsers;
            return iu.Validation_Users(o_id);
        }

        /// <summary>
        /// ��ȡ��¼�û���Ϣ
        /// </summary>
        /// <param name="o_id"></param>
        /// <returns></returns>
        public List<UsersInfo> GetDengLuInfo(string o_id)
        {
            IUsers iu = baseDal as IUsers;
            return iu.GetDengLuInfo(o_id);
        }
    }
}
