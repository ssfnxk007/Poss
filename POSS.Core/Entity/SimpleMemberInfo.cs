using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Entity
{
   public class SimpleMemberInfo
    {
        private string m_m_id;
        private string m_m_name;//会员名
        private string m_m_department_song;//作为以后的扩展列
        private string m_m_tel;//会员电话
        private string m_m_type;//会员类别
        private string m_card_id;//卡号
        private string m_m_adress;//作为微信ID使用
        private DateTime m_end_date;//到期日期
        private string m_integral;//会员积分
        private string m_station_id;//会员站点
        private string m_surplusMoney;//会员卡内余额

        public string M_id
        {
            get { return m_m_id; }
            set { m_m_id = value; }
        }

        /// <summary>
        /// 会员名
        /// </summary>
        public string M_name
        {
            get { return m_m_name; }
            set { m_m_name = value; }
        }

        /// <summary>
        /// 作为以后的扩展列
        /// </summary>
        public string M_department_song
        {
            get { return m_m_department_song; }
            set { m_m_department_song = value; }
        }

        /// <summary>
        /// 会员电话
        /// </summary>
        public string M_tel
        {
            get { return m_m_tel; }
            set { m_m_tel = value; }
        }

        /// <summary>
        /// 会员类别
        /// </summary>
        public string M_type
        {
            get { return m_m_type; }
            set { m_m_type = value; }
        }

        /// <summary>
        /// 卡号
        /// </summary>
        public string Card_id
        {
            get { return m_card_id; }
            set { m_card_id = value; }
        }

        /// <summary>
        /// 作为微信ID使用
        /// </summary>
        public string M_adress
        {
            get { return m_m_adress; }
            set { m_m_adress = value; }
        }

        /// <summary>
        /// 到期日期
        /// </summary>
        public DateTime End_date
        {
            get { return m_end_date; }
            set { m_end_date = value; }
        }

        /// <summary>
        /// 会员积分
        /// </summary>
        public string Integral
        {
            get { return m_integral; }
            set { m_integral = value; }
        }

        /// <summary>
        /// 会员站点
        /// </summary>
        public string Station_id
        {
            get { return m_station_id; }
            set { m_station_id = value; }
        }

        /// <summary>
        /// 会员卡内余额
        /// </summary>
        public string SurplusMoney
        {
            get { return m_surplusMoney; }
            set { m_surplusMoney = value; }
        }



    }
}
