using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// UsersInfo
    /// </summary>
    [DataContract]
    public class UsersInfo : BaseEntity
    {    
        #region Field Members

        private string m_O_id = System.Guid.NewGuid().ToString(); //          
        private string m_O_name; //          
        private string m_Station_id; //          
        private string m_Stock_id; //          
        private string m_Passwd; //          
        private string m_Yh_stand_id; //          
        private string m_Is_word; //          

        #endregion

        #region Property Members
        
		[DataMember]
        public virtual string O_id
        {
            get
            {
                return this.m_O_id;
            }
            set
            {
                this.m_O_id = value;
            }
        }

		[DataMember]
        public virtual string O_name
        {
            get
            {
                return this.m_O_name;
            }
            set
            {
                this.m_O_name = value;
            }
        }

		[DataMember]
        public virtual string Station_id
        {
            get
            {
                return this.m_Station_id;
            }
            set
            {
                this.m_Station_id = value;
            }
        }

		[DataMember]
        public virtual string Stock_id
        {
            get
            {
                return this.m_Stock_id;
            }
            set
            {
                this.m_Stock_id = value;
            }
        }

		[DataMember]
        public virtual string Passwd
        {
            get
            {
                return this.m_Passwd;
            }
            set
            {
                this.m_Passwd = value;
            }
        }

		[DataMember]
        public virtual string Yh_stand_id
        {
            get
            {
                return this.m_Yh_stand_id;
            }
            set
            {
                this.m_Yh_stand_id = value;
            }
        }

		[DataMember]
        public virtual string Is_word
        {
            get
            {
                return this.m_Is_word;
            }
            set
            {
                this.m_Is_word = value;
            }
        }


        #endregion

    }
}