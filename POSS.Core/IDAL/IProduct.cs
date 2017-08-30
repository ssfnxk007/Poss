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
    /// Product
    /// </summary>
	public interface IProduct : IBaseDAL<ProductInfo>
	{
        /// <summary>
        /// ������Ʒ��Ϣ���ؼ���Ʒʵ��
        /// </summary>
        /// <param name="where">��������</param>
        /// <param name="station_id">վ����</param>
        /// <param name="m_id">��Ա���</param>
        /// <param name="whc_num">��ʾ��������¼</param>
        /// <returns></returns>
        List<SimpleProductInfo> Get_simpleproduct(string where, string station_id, string m_id, string whc_num);

        /// <summary>
        /// ��ȡ��Ʒ���ⷿuf_GetStockId
        /// </summary>
        /// <param name="prodInfo">��Ʒ��Ϣ</param>
        /// <param name="station_id">վ�����</param>
        /// <returns></returns>
        string GetStockByProductType(string h_id, string station_id);
        /// <summary>
        /// ��ȡ��Ʒ��Ա�ۿ�
        /// </summary>
        /// <param name="prodInfo">��Ʒ��Ϣ</param>
        /// <param name="station_id">վ�����</param>
        /// <param name="memberInfo">��Ա��Ϣ,��������,���Ա����Ϊ:<RETAIL></param>
        /// <returns></returns>
        decimal GetMemberDiscountByProduct(string h_id, string station_id, string m_id, int h_amount, decimal h_out_price);
    }
}