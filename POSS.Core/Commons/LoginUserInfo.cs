using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// 登陆用户的基础信息
    /// </summary>
    public class LoginUserInfo
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string O_id { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string O_Name { get; set; }

        /// <summary>
        /// 所属站点ID
        /// </summary>
        public string Station_ID { get; set; }
        /// <summary>
        /// 库房ID
        /// </summary>
        public String Stock_id { get; set; }
        /// <summary>
        /// 台号
        /// </summary>
        public string Yh_stand_id { get; set; }
        /// <summary>
        /// 所属部门ID
        /// </summary>
        public string D_id { get; set; }

        /// <summary>
        /// 可登陆站点列表
        /// </summary>
        public List<string> StationList { get; set; }
        /// <summary>
        /// 员工密码
        /// </summary>
        public string O_password { get; set; }

    }
}
