using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// Ls_card_runInfo
    /// </summary>
    [DataContract]
    public class Ls_card_runInfo : BaseEntity
    {    
        #region Field Members

        private int m_Run_id = 0; //          
        private string m_Source_id; //          
        private string m_Card_id; //          
        private decimal m_Money = 0; //          
        private string m_Inout_flag = "0"; //          
        private string m_Mem; //          
        private string m_O_id_operator; //          
        private DateTime m_Input_date = System.DateTime.Now; //          
        private decimal m_Discount = 1; //          

        #endregion

        #region Property Members
        
		[DataMember]
        public virtual int Run_id
        {
            get
            {
                return this.m_Run_id;
            }
            set
            {
                this.m_Run_id = value;
            }
        }

		[DataMember]
        public virtual string Source_id
        {
            get
            {
                return this.m_Source_id;
            }
            set
            {
                this.m_Source_id = value;
            }
        }

		[DataMember]
        public virtual string Card_id
        {
            get
            {
                return this.m_Card_id;
            }
            set
            {
                this.m_Card_id = value;
            }
        }

		[DataMember]
        public virtual decimal Money
        {
            get
            {
                return this.m_Money;
            }
            set
            {
                this.m_Money = value;
            }
        }

		[DataMember]
        public virtual string Inout_flag
        {
            get
            {
                return this.m_Inout_flag;
            }
            set
            {
                this.m_Inout_flag = value;
            }
        }

		[DataMember]
        public virtual string Mem
        {
            get
            {
                return this.m_Mem;
            }
            set
            {
                this.m_Mem = value;
            }
        }

		[DataMember]
        public virtual string O_id_operator
        {
            get
            {
                return this.m_O_id_operator;
            }
            set
            {
                this.m_O_id_operator = value;
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
        public virtual decimal Discount
        {
            get
            {
                return this.m_Discount;
            }
            set
            {
                this.m_Discount = value;
            }
        }


        #endregion

    }
}