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
        /// 检索商品信息返回简单商品实体
        /// </summary>
        /// <param name="where">检索条件</param>
        /// <param name="station_id">站点编号</param>
        /// <param name="m_id">会员编号</param>
        /// <param name="whc_num">显示多少条记录</param>
        /// <returns></returns>
        List<SimpleProductInfo> Get_simpleproduct(string where, string station_id, string m_id, string whc_num);

        /// <summary>
        /// 获取商品类别库房uf_GetStockId
        /// </summary>
        /// <param name="prodInfo">商品信息</param>
        /// <param name="station_id">站点编码</param>
        /// <returns></returns>
        string GetStockByProductType(string h_id, string station_id);
        /// <summary>
        /// 获取商品会员折扣
        /// </summary>
        /// <param name="prodInfo">商品信息</param>
        /// <param name="station_id">站点编码</param>
        /// <param name="memberInfo">会员信息,如是零售,则会员编码为:<RETAIL></param>
        /// <returns></returns>
        decimal GetMemberDiscountByProduct(string h_id, string station_id, string m_id, int h_amount, decimal h_out_price);
    }
}