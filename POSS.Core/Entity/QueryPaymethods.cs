using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Entity
{
   public class QueryPaymethods
    {
        private string m_pay_id;//支付方式编码
        private string m_pay_name;//支付方式名称
        private decimal m_pay_money;//支付金额
        private decimal m_change_money;//找零金额
        private decimal m_surplus_money;//支付方式余额
        private decimal m_charge_back;//退款金额
        private decimal m_Exchange_rate;//汇率
        private string m_is_charge;//是否找零
        private string m_source_id;//来源编码

        private string m_is_aishuka;//是否爱书卡消费
        /// <summary>
        /// 是否爱书卡消费
        /// </summary>
        public string Is_aishuka
        {
            get { return m_is_aishuka; }
            set { m_is_aishuka = value; }
        }
        //private string m_Pay_barcode;//支付条码

        ///// <summary>
        ///// 支付条码
        ///// </summary>
        //public string Pay_barcode
        //{
        //    get { return m_Pay_barcode; }
        //    set { m_Pay_barcode = value; }
        //}

        /// <summary>
        /// 来源编码
        /// </summary>

        public string Source_id
        {
            get { return m_source_id; }
            set { m_source_id = value; }
        }

        /// <summary>
        /// 支付方式编码
        /// </summary>
      
        public string Pay_id
        {
            get { return m_pay_id; }
            set { m_pay_id = value; }
        }

        /// <summary>
        /// 支付方式名称
        /// </summary>
      
        public string Pay_name
        {
            get { return m_pay_name; }
            set { m_pay_name = value; }
        }

        /// <summary>
        /// 支付金额
        /// </summary>
      
        public decimal Pay_money
        {
            get { return m_pay_money; }
            set { m_pay_money = value; }
        }

        /// <summary>
        /// 找零金额
        /// </summary>
      
        public decimal Change_money
        {
            get { return m_change_money; }
            set { m_change_money = value; }
        }

        /// <summary>
        /// 支付方式余额
        /// </summary>
      
        public decimal Surplus_money
        {
            get { return m_surplus_money; }
            set { m_surplus_money = value; }
        }

        /// <summary>
        /// 退款金额
        /// </summary>
      
        public decimal Charge_back
        {
            get { return m_charge_back; }
            set { m_charge_back = value; }
        }

        /// <summary>
        /// 汇率
        /// </summary>
      
        public decimal Exchange_rate
        {
            get { return m_Exchange_rate; }
            set { m_Exchange_rate = value; }
        }

        /// <summary>
        /// 是否找零
        /// </summary>
      
        public string Is_charge
        {
            get { return m_is_charge; }
            set { m_is_charge = value; }
        }




    }
}
