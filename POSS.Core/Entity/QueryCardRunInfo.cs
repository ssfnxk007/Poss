using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Entity
{
   public class QueryCardRunInfo
    {
        private string m_Source_Id;//来源号
        private string m_Card_Id;//卡号
        private decimal m_Money;//爱书卡金额
        private int m_InOut_Flag;//单据类型(0-冲值1-消费)
        private string m_o_id_Operator;//操作员
        private string m_Mem;//备注
        private DateTime m_input_Date;//插入日期
        private decimal m_discount;//折扣

        /// <summary>
        /// 来源号
        /// </summary>
        public string Source_Id
        {
            get { return m_Source_Id; }
            set { m_Source_Id = value; }
        }

        /// <summary>
        /// 卡号
        /// </summary>
        public string Card_Id
        {
            get { return m_Card_Id; }
            set { m_Card_Id = value; }
        }

        /// <summary>
        /// 爱书卡金额
        /// </summary>
        public decimal Money
        {
            get { return m_Money; }
            set { m_Money = value; }
        }

        /// <summary>
        /// 单据类型(0-冲值1-消费)
        /// </summary>
        public int InOut_Flag
        {
            get { return m_InOut_Flag; }
            set { m_InOut_Flag = value; }
        }

        /// <summary>
        /// 操作员
        /// </summary>
        public string O_id_Operator
        {
            get { return m_o_id_Operator; }
            set { m_o_id_Operator = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Mem
        {
            get { return m_Mem; }
            set { m_Mem = value; }
        }

        /// <summary>
        /// 插入日期
        /// </summary>
        public DateTime Input_Date
        {
            get { return m_input_Date; }
            set { m_input_Date = value; }
        }

        /// <summary>
        /// 折扣
        /// </summary>
        public decimal Discount
        {
            get { return m_discount; }
            set { m_discount = value; }
        }



    }
}
