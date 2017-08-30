using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSS.Entity
{
  public  class Query_StandInfo
    {
        private string m_Stand_id;//台号ID
        private string m_Stand_name;//台号名称

        /// <summary>
        /// 台号ID
        /// </summary>
        public string Stand_id
        {
            get { return m_Stand_id; }
            set { m_Stand_id = value; }
        }

        /// <summary>
        /// 台号名称
        /// </summary>
        public string Stand_name
        {
            get { return m_Stand_name; }
            set { m_Stand_name = value; }
        }

    }
}
