using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Entity
{

    /// <summary>
    /// 前台需要参数
    /// </summary>
    public class Sell_info
    {
        private string m_station_id;//站点
        private string m_stand_id;//台号
        private string m_stock_id;//库房
        private string m_o_name;//员工名称
        private string m_o_id;//员工ID
        private string m_ph_id;//批号

        /// <summary>
        /// 站点
        /// </summary>
        public string Station_id
        {
            get { return m_station_id; }
            set { m_station_id = value; }
        }

        /// <summary>
        /// 台号
        /// </summary>
        public string Stand_id
        {
            get { return m_stand_id; }
            set { m_stand_id = value; }
        }

        /// <summary>
        /// 库房
        /// </summary>
        public string Stock_id
        {
            get { return m_stock_id; }
            set { m_stock_id = value; }
        }

        /// <summary>
        /// 员工名称
        /// </summary>
        public string O_name
        {
            get { return m_o_name; }
            set { m_o_name = value; }
        }

        /// <summary>
        /// 员工ID
        /// </summary>
        public string O_id
        {
            get { return m_o_id; }
            set { m_o_id = value; }
        }

        /// <summary>
        /// 批号
        /// </summary>
        public string Ph_id
        {
            get { return m_ph_id; }
            set { m_ph_id = value; }
        }
    }
}
