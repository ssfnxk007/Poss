using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Entity
{
   public class UserInfo
    {
        private string m_o_id;//用户编号
        private string m_o_name;//用户名称
        private string m_station_id;//站点编号
        private string m_stock_id;//库房编号
        private string m_passwd;//密码
        private string m_yh_stand_id;//零售台号

        /// <summary>
        /// 用户编号
        /// </summary>
        public string O_id
        {
            get { return m_o_id; }
            set { m_o_id = value; }
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string O_name
        {
            get { return m_o_name; }
            set { m_o_name = value; }
        }

        /// <summary>
        /// 站点编号
        /// </summary>
        public string Station_id
        {
            get { return m_station_id; }
            set { m_station_id = value; }
        }

        /// <summary>
        /// 库房编号
        /// </summary>
        public string Stock_id
        {
            get { return m_stock_id; }
            set { m_stock_id = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Passwd
        {
            get { return m_passwd; }
            set { m_passwd = value; }
        }

        /// <summary>
        /// 零售台号
        /// </summary>
        public string Yh_stand_id
        {
            get { return m_yh_stand_id; }
            set { m_yh_stand_id = value; }
        }






    }
}
