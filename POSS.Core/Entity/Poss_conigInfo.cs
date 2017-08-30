using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// Poss_conigInfo
    /// </summary>
    [DataContract]
    public class Poss_conigInfo : BaseEntity
    {    
        #region Field Members

        private string m_Id = System.Guid.NewGuid().ToString(); //          
        private string m_Is_jifen; //          
        private string m_Is_ysdh; //          
        private string m_Taosu; //          
        private string m_Wx_appid; //          
        private string m_Wx_mchid; //          
        private string m_Wx_kdy; //          
        private string m_Wx_appsecret; //          
        private string m_Wx_miaosu; //          
        private string m_Zfb_appid; //          
        private string m_Zfb_mchid; //          
        private string m_Zfb_kdy; //          
        private string m_Zfb_appsecret; //          
        private string m_Zfc_miaosu; //          

        #endregion

        #region Property Members
        
		[DataMember]
        public virtual string Id
        {
            get
            {
                return this.m_Id;
            }
            set
            {
                this.m_Id = value;
            }
        }

		[DataMember]
        public virtual string Is_jifen
        {
            get
            {
                return this.m_Is_jifen;
            }
            set
            {
                this.m_Is_jifen = value;
            }
        }

		[DataMember]
        public virtual string Is_ysdh
        {
            get
            {
                return this.m_Is_ysdh;
            }
            set
            {
                this.m_Is_ysdh = value;
            }
        }

		[DataMember]
        public virtual string Taosu
        {
            get
            {
                return this.m_Taosu;
            }
            set
            {
                this.m_Taosu = value;
            }
        }

		[DataMember]
        public virtual string Wx_appid
        {
            get
            {
                return this.m_Wx_appid;
            }
            set
            {
                this.m_Wx_appid = value;
            }
        }

		[DataMember]
        public virtual string Wx_mchid
        {
            get
            {
                return this.m_Wx_mchid;
            }
            set
            {
                this.m_Wx_mchid = value;
            }
        }

		[DataMember]
        public virtual string Wx_kdy
        {
            get
            {
                return this.m_Wx_kdy;
            }
            set
            {
                this.m_Wx_kdy = value;
            }
        }

		[DataMember]
        public virtual string Wx_appsecret
        {
            get
            {
                return this.m_Wx_appsecret;
            }
            set
            {
                this.m_Wx_appsecret = value;
            }
        }

		[DataMember]
        public virtual string Wx_miaosu
        {
            get
            {
                return this.m_Wx_miaosu;
            }
            set
            {
                this.m_Wx_miaosu = value;
            }
        }

		[DataMember]
        public virtual string Zfb_appid
        {
            get
            {
                return this.m_Zfb_appid;
            }
            set
            {
                this.m_Zfb_appid = value;
            }
        }

		[DataMember]
        public virtual string Zfb_mchid
        {
            get
            {
                return this.m_Zfb_mchid;
            }
            set
            {
                this.m_Zfb_mchid = value;
            }
        }

		[DataMember]
        public virtual string Zfb_kdy
        {
            get
            {
                return this.m_Zfb_kdy;
            }
            set
            {
                this.m_Zfb_kdy = value;
            }
        }

		[DataMember]
        public virtual string Zfb_appsecret
        {
            get
            {
                return this.m_Zfb_appsecret;
            }
            set
            {
                this.m_Zfb_appsecret = value;
            }
        }

		[DataMember]
        public virtual string Zfc_miaosu
        {
            get
            {
                return this.m_Zfc_miaosu;
            }
            set
            {
                this.m_Zfc_miaosu = value;
            }
        }


        #endregion

    }
}