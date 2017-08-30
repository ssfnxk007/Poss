using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// 登陆站点信息
    /// </summary>
   public class LoginStationInfo
    {
        private string m_station_id;
        private string m_station_name;
        private string m_station_shortname;
        private bool m_local_flag;
        private bool m_is_allowimport;
        private bool m_input_flag;

       /// <summary>
       /// 站点编码
       /// </summary>
        public string Station_id
        {
            get { return m_station_id; }
            set { m_station_id = value; }
        }

       /// <summary>
       /// 站点名称
       /// </summary>
        public string Station_name
        {
            get { return m_station_name; }
            set { m_station_name = value; }
        }

       /// <summary>
       /// 站点简称
       /// </summary>
        public string Station_shortame
        {
            get { return m_station_shortname; }
            set { m_station_shortname = value; }
        }

       /// <summary>
       /// 是否为本地站点
       /// </summary>
        public bool Local_flag
        {
            get { return m_local_flag; }
            set { m_local_flag = value; }
        }

       /// <summary>
       /// 是否导入
       /// </summary>
        public bool Is_allowimport
        {
            get { return m_is_allowimport; }
            set { m_is_allowimport = value; }
        }

       /// <summary>
       /// 是否录单站点
       /// </summary>
        public bool Input_flag
        {
            get { return m_input_flag; }
            set { m_input_flag = value; }
        }

    }
}
