using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
   public class SimpleProductInfo: BaseEntity
    {
        private string m_H_isbn;//ISBN号
        private string m_H_name;//图书名称
        private string m_H_id;//内部编码
        private string m_U_id;
        private string m_H_factory;//货源名称
        private string m_H_id_dis;//折扣表里的H_ID
        private decimal m_H_output_discount;//批发折扣
        private decimal m_H_output_discount_ls;//零售折扣
        private decimal m_Limite_zk;//限制折扣
        private decimal m_Limit_date_zk;//限期折扣
        private decimal m_H_output_discount_member_ls;//会员折扣
        private decimal m_H_output_discount_yg;//邮购折扣
        private decimal m_H_output_discount_ps;//配送折扣
        private decimal m_H_output_price;//定价
        private decimal m_Local_price_LS;//本地零售价
        private decimal m_Local_price_PX;//本地批销价
        private int m_Stock_amount;//本地库存数
        private string m_Pub_name;//出版社

        private int m_H_amount = 1;//数量
        private decimal m_Ls_Sum;//合计
        private decimal m_H_Member_Ls;//零售代会员与不代会员折扣
        private string m_H_type;//商品类别
        private string m_S_id;//库房ID

        private string m_M_id;//会员ID

        /// <summary>
        /// 会员ID
        /// </summary>
        public string M_id
        {
            get { return m_M_id; }
            set { m_M_id = value; }
        }

        /// <summary>
        /// 库房ID
        /// </summary>
        public string S_id
        {
            get { return m_S_id; }
            set { m_S_id = value; }
        }

       

        /// <summary>
        /// 商品类别
        /// </summary>
        public string H_type
        {
            get { return m_H_type; }
            set { m_H_type = value; }
        }
        /// <summary>
        /// 出版社
        /// </summary>
        public string Pub_name
        {
            get { return m_Pub_name; }
            set { m_Pub_name = value; }
        }
        /// <summary>
        /// 零售代会员与不代会员折扣
        /// </summary>
        public decimal H_Member_Ls
        {
            get { return m_H_Member_Ls; }
            set { m_H_Member_Ls = value; }
        }


        /// <summary>
        /// 数量默认为1
        /// </summary>
        public int H_amount
        {
            get { return m_H_amount; }
            set { m_H_amount = value; }
        }

        /// <summary>
        /// 合计列 零售定价*数量1*零售折扣
        /// </summary>
        public decimal Ls_Sum
        {
            get { return m_Ls_Sum; }
            set { m_Ls_Sum = value; }
        }
        /// <summary>
        /// ISBN号
        /// </summary>
        public string H_isbn
        {
            get { return m_H_isbn; }
            set { m_H_isbn = value; }
        }

        /// <summary>
        /// 图书名称
        /// </summary>
        public string H_name
        {
            get { return m_H_name; }
            set { m_H_name = value; }
        }

        /// <summary>
        /// 内部编码
        /// </summary>
        public string H_id
        {
            get { return m_H_id; }
            set { m_H_id = value; }
        }

        public string U_id
        {
            get { return m_U_id; }
            set { m_U_id = value; }
        }

        /// <summary>
        /// 货源名称
        /// </summary>
        public string H_factory
        {
            get { return m_H_factory; }
            set { m_H_factory = value; }
        }

        /// <summary>
        /// 折扣表里的H_ID
        /// </summary>
        public string H_id_dis
        {
            get { return m_H_id_dis; }
            set { m_H_id_dis = value; }
        }

        /// <summary>
        /// 批发折扣
        /// </summary>
        public decimal H_output_discount
        {
            get { return m_H_output_discount; }
            set { m_H_output_discount = value; }
        }

        /// <summary>
        /// 零售折扣
        /// </summary>
        public decimal H_output_discount_ls
        {
            get { return m_H_output_discount_ls; }
            set { m_H_output_discount_ls = value; }
        }

        /// <summary>
        /// 限制折扣
        /// </summary>
        public decimal Limite_zk
        {
            get { return m_Limite_zk; }
            set { m_Limite_zk = value; }
        }

        /// <summary>
        /// 限期折扣
        /// </summary>
        public decimal Limit_date_zk
        {
            get { return m_Limit_date_zk; }
            set { m_Limit_date_zk = value; }
        }

        /// <summary>
        /// 会员折扣
        /// </summary>
        public decimal H_output_discount_member_ls
        {
            get { return m_H_output_discount_member_ls; }
            set { m_H_output_discount_member_ls = value; }
        }

        /// <summary>
        /// 邮购折扣
        /// </summary>
        public decimal H_output_discount_yg
        {
            get { return m_H_output_discount_yg; }
            set { m_H_output_discount_yg = value; }
        }

        /// <summary>
        /// 配送折扣
        /// </summary>
        public decimal H_output_discount_ps
        {
            get { return m_H_output_discount_ps; }
            set { m_H_output_discount_ps = value; }
        }

        /// <summary>
        /// 定价
        /// </summary>
        public decimal H_output_price
        {
            get { return m_H_output_price; }
            set { m_H_output_price = value; }
        }

        /// <summary>
        /// 本地零售价
        /// </summary>
        public decimal Local_price_LS
        {
            get { return m_Local_price_LS; }
            set { m_Local_price_LS = value; }
        }

        /// <summary>
        /// 本地批销价
        /// </summary>
        public decimal Local_price_PX
        {
            get { return m_Local_price_PX; }
            set { m_Local_price_PX = value; }
        }

        /// <summary>
        /// 本地库存数
        /// </summary>
        public int Stock_amount
        {
            get { return m_Stock_amount; }
            set { m_Stock_amount = value; }
        }
       
        }
}
