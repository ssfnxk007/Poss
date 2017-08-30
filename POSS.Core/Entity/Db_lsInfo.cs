using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// Db_lsInfo
    /// </summary>
    [DataContract]
    public class Db_lsInfo : BaseEntity
    {    
        #region Field Members

        private string m_Ph_id; //          
        private string m_Ls_id = System.Guid.NewGuid().ToString(); //          
        private int m_Total_count = 0; //          
        private decimal m_Total_money = 0; //          
        private decimal m_Real_money = 0; //          
        private string m_M_id; //          
        private DateTime m_Ls_datetime; //          
        private decimal m_Charge = 0; //          
        private string m_Stand_id; //          
        private string m_O_id; //          
        private decimal m_Already_money = 0; //          
        private string m_Sum_flag = "1"; //          
        private string m_Is_stock = "create default [审核默认值设为0] as 0"; //          
        private string m_Is_sum = "create default [审核默认值设为0] as 0"; //          
        private string m_Station_id; //          
        private decimal m_Change = 0; //          
        private string m_Sum_id; //          
        private string m_Tax_id; //          
        private DateTime m_Last_mod_date = System.DateTime.Now; //          
        private DateTime m_Last_trans_date; //          
        private string m_Notrigger; //          
        private string m_Ls_flag = "0"; //          
        private int m_Total_amount = '0'; //          
        private string m_Ls_back_id; //          
        private string m_Salesother_id; //          
        private string m_Desk_id; //          
        private string m_Waiter_id; //          
        private string m_Memo; //          
        private decimal m_Total_money_avoid = 0; //          
        private decimal m_Real_money_avoid = 0; //          

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
        public virtual string Ls_id
        {
            get
            {
                return this.m_Ls_id;
            }
            set
            {
                this.m_Ls_id = value;
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
        public virtual DateTime Ls_datetime
        {
            get
            {
                return this.m_Ls_datetime;
            }
            set
            {
                this.m_Ls_datetime = value;
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
        public virtual decimal Already_money
        {
            get
            {
                return this.m_Already_money;
            }
            set
            {
                this.m_Already_money = value;
            }
        }

		[DataMember]
        public virtual string Sum_flag
        {
            get
            {
                return this.m_Sum_flag;
            }
            set
            {
                this.m_Sum_flag = value;
            }
        }

		[DataMember]
        public virtual string Is_stock
        {
            get
            {
                return this.m_Is_stock;
            }
            set
            {
                this.m_Is_stock = value;
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
        public virtual decimal Change
        {
            get
            {
                return this.m_Change;
            }
            set
            {
                this.m_Change = value;
            }
        }

		[DataMember]
        public virtual string Sum_id
        {
            get
            {
                return this.m_Sum_id;
            }
            set
            {
                this.m_Sum_id = value;
            }
        }

		[DataMember]
        public virtual string Tax_id
        {
            get
            {
                return this.m_Tax_id;
            }
            set
            {
                this.m_Tax_id = value;
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
        public virtual string Ls_flag
        {
            get
            {
                return this.m_Ls_flag;
            }
            set
            {
                this.m_Ls_flag = value;
            }
        }

		[DataMember]
        public virtual int Total_amount
        {
            get
            {
                return this.m_Total_amount;
            }
            set
            {
                this.m_Total_amount = value;
            }
        }

		[DataMember]
        public virtual string Ls_back_id
        {
            get
            {
                return this.m_Ls_back_id;
            }
            set
            {
                this.m_Ls_back_id = value;
            }
        }

		[DataMember]
        public virtual string Salesother_id
        {
            get
            {
                return this.m_Salesother_id;
            }
            set
            {
                this.m_Salesother_id = value;
            }
        }

		[DataMember]
        public virtual string Desk_id
        {
            get
            {
                return this.m_Desk_id;
            }
            set
            {
                this.m_Desk_id = value;
            }
        }

		[DataMember]
        public virtual string Waiter_id
        {
            get
            {
                return this.m_Waiter_id;
            }
            set
            {
                this.m_Waiter_id = value;
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
        public virtual decimal Total_money_avoid
        {
            get
            {
                return this.m_Total_money_avoid;
            }
            set
            {
                this.m_Total_money_avoid = value;
            }
        }

		[DataMember]
        public virtual decimal Real_money_avoid
        {
            get
            {
                return this.m_Real_money_avoid;
            }
            set
            {
                this.m_Real_money_avoid = value;
            }
        }


        #endregion

    }
}