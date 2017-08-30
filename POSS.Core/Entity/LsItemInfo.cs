using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Entity
{
    /// <summary>
    /// 用于显示的零售明细实体
    /// </summary>
    public class LsItemInfo 
    {
        private string m_Ls_id;//零售单号
        private string m_H_id;//商品编码
        private string m_H_name;//商品名称
        private string m_H_isbn;//条码
        private string m_U_id;//计量单位
        private decimal m_H_price;//定价
        private int m_H_amount;//数量
        private decimal m_H_discount;//折扣
        private string m_S_id;//库位编码
        private int m_Sort_number;//序号
        private decimal m_Cush_money;//成本
        private int m_H_amount_back;//退货数量
        private decimal m_Real_money;//实际金额
        private decimal m_Sub_money;//优惠金额
        private decimal m_Tax_rate = 0;//税率
        private string m_Avoid_flag;        //是否累计

        /// <summary>
        /// 该条明细是否可以累计积分
        /// </summary>
        public string Avoid_flag
        {
            get { return m_Avoid_flag; }
            set { m_Avoid_flag = value; }
        }


        /// <summary>
        /// 税率
        /// </summary>
       
        public decimal Tax_rate
        {
            get { return m_Tax_rate; }
            set { m_Tax_rate = value; }
        }


        /// <summary>
        /// 优惠金额
        /// </summary>
       
        public decimal Sub_money
        {
            get { return m_Sub_money; }
            set { m_Sub_money = value; }
        }

        /// <summary>
        /// 实际金额
        /// </summary>
       
        public decimal Real_money
        {
            get { return m_Real_money; }
            set { m_Real_money = value; }
        }

        /// <summary>
        /// 零售单号
        /// </summary>
       
        public string Ls_id
        {
            get { return m_Ls_id; }
            set { m_Ls_id = value; }
        }

        /// <summary>
        /// 商品编码
        /// </summary>
       
        public string H_id
        {
            get { return m_H_id; }
            set { m_H_id = value; }
        }

        /// <summary>
        /// 商品名称
        /// </summary>
       
        public string H_name
        {
            get { return m_H_name; }
            set { m_H_name = value; }
        }

        /// <summary>
        /// 条码
        /// </summary>
       
        public string H_isbn
        {
            get { return m_H_isbn; }
            set { m_H_isbn = value; }
        }

        /// <summary>
        /// 计量单位
        /// </summary>
       
        public string U_id
        {
            get { return m_U_id; }
            set { m_U_id = value; }
        }

        /// <summary>
        /// 定价
        /// </summary>
       
        public decimal H_price
        {
            get { return m_H_price; }
            set { m_H_price = value; }
        }

        /// <summary>
        /// 数量
        /// </summary>
       
        public int H_amount
        {
            get { return m_H_amount; }
            set { m_H_amount = value; }
        }

        /// <summary>
        /// 折扣
        /// </summary>
       
        public decimal H_discount
        {
            get { return m_H_discount; }
            set { m_H_discount = value; }
        }

        /// <summary>
        /// 库位编码
        /// </summary>
       
        public string S_id
        {
            get { return m_S_id; }
            set { m_S_id = value; }
        }

        /// <summary>
        /// 序号
        /// </summary>
       
        public int Sort_number
        {
            get { return m_Sort_number; }
            set { m_Sort_number = value; }
        }

        /// <summary>
        /// 成本
        /// </summary>
       
        public decimal Crush_money
        {
            get { return m_Cush_money; }
            set { m_Cush_money = value; }
        }

        /// <summary>
        /// 退货数量
        /// </summary>
       
        public int H_amount_back
        {
            get { return m_H_amount_back; }
            set { m_H_amount_back = value; }
        }


    }
}
