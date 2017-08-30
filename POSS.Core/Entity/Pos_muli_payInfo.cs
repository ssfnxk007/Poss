using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// Pos_muli_payInfo
    /// </summary>
    [DataContract]
    public class Pos_muli_payInfo : BaseEntity
    {    
        #region Field Members

        private string m_Pos_id = ""; //          
        private string m_Pos_pay_id = ""; //          
        private decimal m_Pos_charge = 0; //          
        private string m_Source_id = ""; //          

        #endregion

        #region Property Members
        
		[DataMember]
        public virtual string Pos_id
        {
            get
            {
                return this.m_Pos_id;
            }
            set
            {
                this.m_Pos_id = value;
            }
        }

		[DataMember]
        public virtual string Pos_pay_id
        {
            get
            {
                return this.m_Pos_pay_id;
            }
            set
            {
                this.m_Pos_pay_id = value;
            }
        }

		[DataMember]
        public virtual decimal Pos_charge
        {
            get
            {
                return this.m_Pos_charge;
            }
            set
            {
                this.m_Pos_charge = value;
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


        #endregion

    }
}