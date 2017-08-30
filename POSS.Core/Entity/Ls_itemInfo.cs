using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// Ls_itemInfo
    /// </summary>
    [DataContract]
    public class Ls_itemInfo : BaseEntity
    {    
        #region Field Members

        private string m_Ls_id = ""; //          
        private string m_H_id =""; //          
        private decimal m_H_price = 0; //          
        private int m_H_amount = 0; //          
        private decimal m_H_discount = 0; //          
        private string m_S_id; //          
        private int m_Sort_number = 0; //          
        private decimal m_Crush_money = 0; //          
        private decimal m_Tax_crush_money = 0; //          

        #endregion

        #region Property Members
        
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
        public virtual string H_id
        {
            get
            {
                return this.m_H_id;
            }
            set
            {
                this.m_H_id = value;
            }
        }

		[DataMember]
        public virtual decimal H_price
        {
            get
            {
                return this.m_H_price;
            }
            set
            {
                this.m_H_price = value;
            }
        }

		[DataMember]
        public virtual int H_amount
        {
            get
            {
                return this.m_H_amount;
            }
            set
            {
                this.m_H_amount = value;
            }
        }

		[DataMember]
        public virtual decimal H_discount
        {
            get
            {
                return this.m_H_discount;
            }
            set
            {
                this.m_H_discount = value;
            }
        }

		[DataMember]
        public virtual string S_id
        {
            get
            {
                return this.m_S_id;
            }
            set
            {
                this.m_S_id = value;
            }
        }

		[DataMember]
        public virtual int Sort_number
        {
            get
            {
                return this.m_Sort_number;
            }
            set
            {
                this.m_Sort_number = value;
            }
        }

		[DataMember]
        public virtual decimal Crush_money
        {
            get
            {
                return this.m_Crush_money;
            }
            set
            {
                this.m_Crush_money = value;
            }
        }

		[DataMember]
        public virtual decimal Tax_crush_money
        {
            get
            {
                return this.m_Tax_crush_money;
            }
            set
            {
                this.m_Tax_crush_money = value;
            }
        }


        #endregion

    }
}