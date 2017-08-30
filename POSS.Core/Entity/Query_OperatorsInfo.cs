using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSS.Entity
{
   public class Query_OperatorsInfo
    {
        private string m_O_id;//员工ID
        private string m_O_name;//员工名称

        /// <summary>
        /// 员工ID
        /// </summary>
        public string O_id
        {
            get { return m_O_id; }
            set { m_O_id = value; }
        }

        /// <summary>
        /// 员工名称
        /// </summary>
        public string O_name
        {
            get { return m_O_name; }
            set { m_O_name = value; }
        }

    }
}
