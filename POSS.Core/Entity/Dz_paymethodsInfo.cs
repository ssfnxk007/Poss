using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// Dz_paymethodsInfo
    /// </summary>
    [DataContract]
    public class Dz_paymethodsInfo : BaseEntity
    {    
        #region Field Members

        private string m_P_id = ""; //          
        private string m_P_name; //          
        private string m_P_mem; //          
        private DateTime m_Last_mod_date; //          
        private DateTime m_Last_trans_date; //          
        private string m_Notrigger; //          
        private decimal m_Exchange_rate = 1; //          
        private string m_Is_sum = "1"; //          

        #endregion

        #region Property Members
        
		[DataMember]
        public virtual string P_id
        {
            get
            {
                return this.m_P_id;
            }
            set
            {
                this.m_P_id = value;
            }
        }

		[DataMember]
        public virtual string P_name
        {
            get
            {
                return this.m_P_name;
            }
            set
            {
                this.m_P_name = value;
            }
        }

		[DataMember]
        public virtual string P_mem
        {
            get
            {
                return this.m_P_mem;
            }
            set
            {
                this.m_P_mem = value;
            }
        }

		[DataMember]
        public virtual DateTime Last_mod_date
        {
            get
            {
                return this.m_Last_mod_date;
            }
            set
            {
                this.m_Last_mod_date = value;
            }
        }

		[DataMember]
        public virtual DateTime Last_trans_date
        {
            get
            {
                return this.m_Last_trans_date;
            }
            set
            {
                this.m_Last_trans_date = value;
            }
        }

		[DataMember]
        public virtual string Notrigger
        {
            get
            {
                return this.m_Notrigger;
            }
            set
            {
                this.m_Notrigger = value;
            }
        }

		[DataMember]
        public virtual decimal Exchange_rate
        {
            get
            {
                return this.m_Exchange_rate;
            }
            set
            {
                this.m_Exchange_rate = value;
            }
        }

		[DataMember]
        public virtual string Is_sum
        {
            get
            {
                return this.m_Is_sum;
            }
            set
            {
                this.m_Is_sum = value;
            }
        }


        #endregion

    }
}