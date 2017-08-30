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
    /// Ph
    /// </summary>
	public class Ph : BaseBLL<PhInfo>
    {
        public Ph() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
        /// <summary>
        /// ��ȡ��ǰ�û��ĵ�ǰPH_ID
        /// </summary>
        /// <param name="Opearator_o_id"></param>
        /// <returns></returns>
        public string GetPh_id(string Opearator_o_id)
        {
            IPh ip = baseDal as IPh;
            return ip.GetPh_id(Opearator_o_id);
        }
        /// <summary>
        /// ����PH
        /// </summary>
        /// <param name="station_id"></param>
        /// <param name="stock_id"></param>
        /// <returns></returns>
        public bool Insert_PH(PhInfo ph)
        {
            IPh ip = baseDal as IPh;
            return ip.Insert_PH(ph);
        }

        /// <summary>
        /// ����PHʱ��Ϊ��ǰʱ��
        /// </summary>
        /// <param name="ph_id"></param>
        /// <returns></returns>
        public bool Update_PH_id(string ph_id)
        {
            IPh ip = baseDal as IPh;
            return ip.Update_PH_id(ph_id);
        }

        /// <summary>
        /// ���� PH�һ�״̬Ϊ����
        /// </summary>
        /// <param name="ph_id"></param>
        /// <returns></returns>
        public bool update_Ph_id_commit(string ph_id)
        {
            IPh ip = baseDal as IPh;
            return ip.update_Ph_id_commit(ph_id);
        }

        /// <summary>
        /// ����̨��
        /// </summary>
        /// <param name="ph_id"></param>
        /// <param name="stand_id"></param>
        /// <returns></returns>
        public bool update_Ph_stand_id(string ph_id, string stand_id)
        {
            IPh ip = baseDal as IPh;
            return ip.update_Ph_stand_id(ph_id,stand_id);
        }
    }
}
