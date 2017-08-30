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
    /// Users
    /// </summary>
	public interface IUsers : IBaseDAL<UsersInfo>
	{
        /// <summary>
        /// ��ȡԱ����Ϣ
        /// </summary>
        /// <returns></returns>
        List<Query_OperatorsInfo> GetO_id();
        /// <summary>
        /// ��ȡվ����Ϣ
        /// </summary>
        /// <returns></returns>
        List<Query_Station_totalInfo> GetSatation_idByName();

        /// <summary>
        /// ��ȡ�ⷿ��Ϣ
        /// </summary>
        /// <returns></returns>
        List<Query_stocksInfo> GetStocks_idByName();

        /// <summary>
        /// ��ȡ����̨��
        /// </summary>
        /// <returns></returns>
        List<Query_StandInfo> GetStand_idByName();

        /// <summary>
        /// ���������û���
        /// </summary>
        /// <param name="usinfo"></param>
        /// <returns></returns>
        bool SaveUser(UsersInfo usinfo);
        /// <summary>
        /// �û���Ϣ
        /// </summary>
        /// <returns></returns>
        List<UsersInfo> GetUsers_idByName();

        /// <summary>
        /// ��֤�û�����
        /// </summary>
        /// <returns></returns>
        List<UsersInfo> Validation_Users(string o_id);

        /// <summary>
        /// ��ȡ��¼�û���Ϣ
        /// </summary>
        /// <param name="o_id"></param>
        /// <returns></returns>
        List<UsersInfo> GetDengLuInfo(string o_id);
    }
}