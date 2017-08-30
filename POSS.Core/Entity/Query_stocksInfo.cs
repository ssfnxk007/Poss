using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSS.Entity
{
   public class Query_stocksInfo
    {
        private string m_S_id;//库房编号
        private string m_S_name;//库房名称

        /// <summary>
        /// 库房编号
        /// </summary>
        public string S_id
        {
            get { return m_S_id; }
            set { m_S_id = value; }
        }

        /// <summary>
        /// 库房名称
        /// </summary>
        public string S_name
        {
            get { return m_S_name; }
            set { m_S_name = value; }
        }
    }
}
