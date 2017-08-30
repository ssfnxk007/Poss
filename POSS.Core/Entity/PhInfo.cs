using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// PhInfo
    /// </summary>
    [DataContract]
    public class PhInfo : BaseEntity
    {    
        #region Field Members

        private string m_Ph_id = System.Guid.NewGuid().ToString(); //          
        private string m_O_id; //          
        private decimal m_Receive = 0; //          
        private DateTime m_On_time; //          
        private DateTime m_Off_time; //          
        private decimal m_Total_money = 0; //          
        private decimal m_Real_money = 0; //          
        private string m_Stand_id; //          
        private string m_Station_id; //          
        private decimal m_Pay = 0; //          
        private decimal m_Charge = 0; //          
        private decimal m_Other_charge = 0; //          
        private string m_Is_commit = "1"; //          
        private int m_Total_count = 0; //          
        private DateTime m_Input_date; //          
        private DateTime m_Commit_date; //          
        private string m_Other_chareg_mem; //          
        private DateTime m_Last_mod_date; //          
        private DateTime m_Last_trans_date; //          
        private string m_Notrigger; //          

        #endregion

        #region Property Members
        
		[DataMember]
        public virtual string Ph_id
        {
            get
            {
                return this.m_Ph_id;
            }
            set
            {
                this.m_Ph_id = value;
            }
        }

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
        public virtual decimal Receive
        {
            get
            {
                return this.m_Receive;
            }
            set
            {
                this.m_Receive = value;
            }
        }

		[DataMember]
        public virtual DateTime On_time
        {
            get
            {
                return this.m_On_time;
            }
            set
            {
                this.m_On_time = value;
            }
        }

		[DataMember]
        public virtual DateTime Off_time
        {
            get
            {
                return this.m_Off_time;
            }
            set
            {
                this.m_Off_time = value;
            }
        }

		[DataMember]
        public virtual decimal Total_money
        {
            get
            {
                return this.m_Total_money;
            }
            set
            {
                this.m_Total_money = value;
            }
        }

		[DataMember]
        public virtual decimal Real_money
        {
            get
            {
                return this.m_Real_money;
            }
            set
            {
                this.m_Real_money = value;
            }
        }

		[DataMember]
        public virtual string Stand_id
        {
            get
            {
                return this.m_Stand_id;
            }
            set
            {
                this.m_Stand_id = value;
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
        public virtual decimal Pay
        {
            get
            {
                return this.m_Pay;
            }
            set
            {
                this.m_Pay = value;
            }
        }

		[DataMember]
        public virtual decimal Charge
        {
            get
            {
                return this.m_Charge;
            }
            set
            {
                this.m_Charge = value;
            }
        }

		[DataMember]
        public virtual decimal Other_charge
        {
            get
            {
                return this.m_Other_charge;
            }
            set
            {
                this.m_Other_charge = value;
            }
        }

		[DataMember]
        public virtual string Is_commit
        {
            get
            {
                return this.m_Is_commit;
            }
            set
            {
                this.m_Is_commit = value;
            }
        }

		[DataMember]
        public virtual int Total_count
        {
            get
            {
                return this.m_Total_count;
            }
            set
            {
                this.m_Total_count = value;
            }
        }

		[DataMember]
        public virtual DateTime Input_date
        {
            get
            {
                return this.m_Input_date;
            }
            set
            {
                this.m_Input_date = value;
            }
        }

		[DataMember]
        public virtual DateTime Commit_date
        {
            get
            {
                return this.m_Commit_date;
            }
            set
            {
                this.m_Commit_date = value;
            }
        }

		[DataMember]
        public virtual string Other_chareg_mem
        {
            get
            {
                return this.m_Other_chareg_mem;
            }
            set
            {
                this.m_Other_chareg_mem = value;
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


        #endregion

    }
}