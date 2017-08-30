using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// Ls_card_surplusInfo
    /// </summary>
    [DataContract]
    public class Ls_card_surplusInfo : BaseEntity
    {    
        #region Field Members

        private string m_Card_id = System.Guid.NewGuid().ToString(); //          
        private decimal m_Surplus_money = 0; //          
        private DateTime m_Input_date = System.DateTime.Now; //          
        private DateTime m_End_date = System.DateTime.Now; //          
        private string m_Password; //          
        private string m_Valid_flag = "1"; //          
        private string m_M_id; //          
        private string m_Memo; //          
        private string m_O_id_input; //          
        private decimal m_Discount = 1; //          
        private decimal m_Max_money = 0; //          
        private string m_Buy_department; //          
        private string m_C_id; //          
        private string m_O_id_operator; //          
        private string m_Station_id; //          
        private string m_D_id; //          
        private DateTime m_Lk_date; //          
        private string m_Lk_p_id; //          
        private string m_Fk_input; //          
        private DateTime m_Fk_date; //          

        #endregion

        #region Property Members
        
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
        public virtual decimal Surplus_money
        {
            get
            {
                return this.m_Surplus_money;
            }
            set
            {
                this.m_Surplus_money = value;
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
        public virtual DateTime End_date
        {
            get
            {
                return this.m_End_date;
            }
            set
            {
                this.m_End_date = value;
            }
        }

		[DataMember]
        public virtual string Password
        {
            get
            {
                return this.m_Password;
            }
            set
            {
                this.m_Password = value;
            }
        }

		[DataMember]
        public virtual string Valid_flag
        {
            get
            {
                return this.m_Valid_flag;
            }
            set
            {
                this.m_Valid_flag = value;
            }
        }

		[DataMember]
        public virtual string M_id
        {
            get
            {
                return this.m_M_id;
            }
            set
            {
                this.m_M_id = value;
            }
        }

		[DataMember]
        public virtual string Memo
        {
            get
            {
                return this.m_Memo;
            }
            set
            {
                this.m_Memo = value;
            }
        }

		[DataMember]
        public virtual string O_id_input
        {
            get
            {
                return this.m_O_id_input;
            }
            set
            {
                this.m_O_id_input = value;
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

		[DataMember]
        public virtual decimal Max_money
        {
            get
            {
                return this.m_Max_money;
            }
            set
            {
                this.m_Max_money = value;
            }
        }

		[DataMember]
        public virtual string Buy_department
        {
            get
            {
                return this.m_Buy_department;
            }
            set
            {
                this.m_Buy_department = value;
            }
        }

		[DataMember]
        public virtual string C_id
        {
            get
            {
                return this.m_C_id;
            }
            set
            {
                this.m_C_id = value;
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
        public virtual string D_id
        {
            get
            {
                return this.m_D_id;
            }
            set
            {
                this.m_D_id = value;
            }
        }

		[DataMember]
        public virtual DateTime Lk_date
        {
            get
            {
                return this.m_Lk_date;
            }
            set
            {
                this.m_Lk_date = value;
            }
        }

		[DataMember]
        public virtual string Lk_p_id
        {
            get
            {
                return this.m_Lk_p_id;
            }
            set
            {
                this.m_Lk_p_id = value;
            }
        }

		[DataMember]
        public virtual string Fk_input
        {
            get
            {
                return this.m_Fk_input;
            }
            set
            {
                this.m_Fk_input = value;
            }
        }

		[DataMember]
        public virtual DateTime Fk_date
        {
            get
            {
                return this.m_Fk_date;
            }
            set
            {
                this.m_Fk_date = value;
            }
        }


        #endregion

    }
}