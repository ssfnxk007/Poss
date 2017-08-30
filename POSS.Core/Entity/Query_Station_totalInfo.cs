using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSS.Entity
{
   public class Query_Station_totalInfo
    {
        private string m_Station_id;//站点ID
        private string m_Station_name;//站点名称

        /// <summary>
        /// 站点ID
        /// </summary>
        public string Station_id
        {
            get { return m_Station_id; }
            set { m_Station_id = value; }
        }

        /// <summary>
        /// 站点名称
        /// </summary>
        public string Station_name
        {
            get { return m_Station_name; }
            set { m_Station_name = value; }
        }

    }
}
