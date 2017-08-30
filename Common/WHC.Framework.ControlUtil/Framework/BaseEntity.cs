using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.Commons;

namespace WHC.Framework.ControlUtil
{
	/// <summary>
	/// 框架实体类的基类
	/// </summary>
    [DataContract]
	public class BaseEntity
	{
        private string m_CurrentLoginUserId;
        private bool m_Checked;

        /// <summary>
        /// 当前登录用户ID。该字段不保存到数据表中，只用于记录用户的操作日志。
        /// </summary>
        [DataMember]
        public string CurrentLoginUserId
        {
            get { return m_CurrentLoginUserId; }
            set { m_CurrentLoginUserId = value; }
        }
        /// <summary>
        /// 当前实体的检测信息,该字段不保存到数据表中,只用于处理过程中的检测信息。
        /// </summary>
        [DataMember]
        public bool Checked
        {
            get { return m_Checked; }
            set { m_Checked = value; }
        }
	}
}
