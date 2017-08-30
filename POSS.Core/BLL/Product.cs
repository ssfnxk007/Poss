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
    /// Product
    /// </summary>
	public class Product : BaseBLL<ProductInfo>
    {
        public Product() : base()
        {
            base.Init(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
        /// <summary>
        /// ������Ʒ��Ϣ���ؼ���Ʒʵ��
        /// </summary>
        /// <param name="where">��������</param>
        /// <param name="station_id">վ����</param>
        /// <param name="m_id">��Ա���</param>
        /// <param name="whc_num">��ʾ��������¼</param>
        /// <returns></returns>
        public List<SimpleProductInfo> Get_simpleproduct(string where, string station_id, string m_id, string whc_num)
        {
            IProduct ip = baseDal as IProduct;
            return ip.Get_simpleproduct(where, station_id, m_id, whc_num);
        }
        /// <summary>
        /// ��ȡ��Ʒ���ⷿuf_GetStockId
        /// </summary>
        /// <param name="prodInfo">��Ʒ��Ϣ</param>
        /// <param name="station_id">վ�����</param>
        /// <returns></returns>
        public string GetStockByProductType(string h_id, string station_id)
        {
            IProduct ip = baseDal as IProduct;
            return ip.GetStockByProductType(h_id, station_id);
        }
        /// <summary>
        /// ��ȡ��Ʒ��Ա�ۿ�
        /// </summary>
        /// <param name="prodInfo">��Ʒ��Ϣ</param>
        /// <param name="station_id">վ�����</param>
        /// <param name="memberInfo">��Ա��Ϣ,��������,���Ա����Ϊ:<RETAIL></param>
        /// <returns></returns>
        public virtual decimal GetMemberDiscountByProduct(string h_id, string station_id, string m_id, int h_amount, decimal h_out_price)
        {
            IProduct ip = baseDal as IProduct;
            return ip.GetMemberDiscountByProduct(h_id, station_id,m_id, h_amount, h_out_price);
        }
    }
}
