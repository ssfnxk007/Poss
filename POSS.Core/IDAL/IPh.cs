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
    /// Ph
    /// </summary>
	public interface IPh : IBaseDAL<PhInfo>
	{

        /// <summary>
        /// ��ȡ��ǰ�û��ĵ�ǰPH_ID
        /// </summary>
        /// <param name="Opearator_o_id"></param>
        /// <returns></returns>
        string GetPh_id(string Opearator_o_id);
        /// <summary>
        /// ����PH
        /// </summary>
        /// <param name="station_id"></param>
        /// <param name="stock_id"></param>
        /// <returns></returns>
        bool Insert_PH(PhInfo ph);

        /// <summary>
        /// ����PHʱ��Ϊ��ǰʱ��
        /// </summary>
        /// <param name="ph_id"></param>
        /// <returns></returns>
        bool Update_PH_id(string ph_id);

        /// <summary>
        /// ���� PH�һ�״̬Ϊ����
        /// </summary>
        /// <param name="ph_id"></param>
        /// <returns></returns>
        bool update_Ph_id_commit(string ph_id);
        /// <summary>
        /// ����̨��
        /// </summary>
        /// <param name="ph_id"></param>
        /// <param name="stand_id"></param>
        /// <returns></returns>
        bool update_Ph_stand_id(string ph_id, string stand_id);

    }
}