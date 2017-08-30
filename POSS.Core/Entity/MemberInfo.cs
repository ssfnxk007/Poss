using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// MemberInfo
    /// </summary>
    [DataContract]
    public class MemberInfo : BaseEntity
    {    
        #region Field Members

        private string m_M_id = System.Guid.NewGuid().ToString(); //          
        private string m_M_name; //          
        private string m_M_adress; //          
        private string m_M_tel; //          
        private string m_M_type; //          
        private string m_M_sex = "男"; //          
        private string m_M_national = "汉"; //          
        private string m_M_native = "中国"; //          
        private DateTime m_M_birthday; //          
        private string m_M_ic; //          
        private string m_M_email; //          
        private string m_Memo; //          
        private string m_M_password; //          
        private string m_M_help_input; //          
        private string m_M_city; //          
        private string m_M_province; //          
        private string m_M_arears; //          
        private string m_M_corporation; //          
        private string m_M_zip; //          
        private string m_M_degree; //          
        private string m_Card_id; //          
        private string m_Jy_class_id; //          
        private string m_Station_id; //          
        private DateTime m_Join_date = System.DateTime.Now; //          
        private DateTime m_End_date; //          
        private string m_O_id_input; //          
        private string m_Active_flag = "1"; //          
        private string m_Upgrade_o_id; //          
        private DateTime m_Last_trans_date; //          
        private DateTime m_Last_mod_date = System.DateTime.Now; //          
        private string m_Notrigger; //          
        private string m_M_zw; //          
        private string m_M_zy; //          
        private string m_M_period; //          
        private string m_M_income; //          
        private string m_Jy_flag = "0"; //          
        private string m_Focus_flag = "0"; //          
        private string m_M_address_song; //          
        private string m_M_station; //          
        private string m_M_zip_song; //          
        private string m_M_department_song; //          
        private string m_M_name_accept; //          
        private string m_M_join_type = "0"; //          
        private string m_M_send_letter = "0"; //          
        private string m_M_introduce; //          
        private string m_M_mobile; //          
        private string m_M_mobile_type = "0"; //          
        private string m_M_ziye; //          
        private string m_M_account; //          
        private string m_M_question; //          
        private string m_M_answer; //          
        private string m_M_homeland; //          
        private string m_M_school; //          
        private string m_M_hometel; //          
        private string m_M_worktel; //          
        private string m_M_homepage; //          
        private string m_M_homeaddress; //          
        private string m_M_homezipcode; //          
        private string m_M_workaddress; //          
        private string m_M_workzipcode; //          
        private string m_M_send_comu; //          
        private string m_M_fax; //          
        private int m_Defer_times = 0; //          
        private string m_Ls_flag = "1"; //          
        private string m_Yg_flag = "1"; //          
        private string m_Is_calltemp = "0"; //          
        private DateTime m_Sum_date; //          
        private string m_Station_id_yg; //          
        private string m_O_id_charge; //          

        #endregion

        #region Property Members
        
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
        public virtual string M_name
        {
            get
            {
                return this.m_M_name;
            }
            set
            {
                this.m_M_name = value;
            }
        }

		[DataMember]
        public virtual string M_adress
        {
            get
            {
                return this.m_M_adress;
            }
            set
            {
                this.m_M_adress = value;
            }
        }

		[DataMember]
        public virtual string M_tel
        {
            get
            {
                return this.m_M_tel;
            }
            set
            {
                this.m_M_tel = value;
            }
        }

		[DataMember]
        public virtual string M_type
        {
            get
            {
                return this.m_M_type;
            }
            set
            {
                this.m_M_type = value;
            }
        }

		[DataMember]
        public virtual string M_sex
        {
            get
            {
                return this.m_M_sex;
            }
            set
            {
                this.m_M_sex = value;
            }
        }

		[DataMember]
        public virtual string M_national
        {
            get
            {
                return this.m_M_national;
            }
            set
            {
                this.m_M_national = value;
            }
        }

		[DataMember]
        public virtual string M_native
        {
            get
            {
                return this.m_M_native;
            }
            set
            {
                this.m_M_native = value;
            }
        }

		[DataMember]
        public virtual DateTime M_birthday
        {
            get
            {
                return this.m_M_birthday;
            }
            set
            {
                this.m_M_birthday = value;
            }
        }

		[DataMember]
        public virtual string M_ic
        {
            get
            {
                return this.m_M_ic;
            }
            set
            {
                this.m_M_ic = value;
            }
        }

		[DataMember]
        public virtual string M_email
        {
            get
            {
                return this.m_M_email;
            }
            set
            {
                this.m_M_email = value;
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
        public virtual string M_password
        {
            get
            {
                return this.m_M_password;
            }
            set
            {
                this.m_M_password = value;
            }
        }

		[DataMember]
        public virtual string M_help_input
        {
            get
            {
                return this.m_M_help_input;
            }
            set
            {
                this.m_M_help_input = value;
            }
        }

		[DataMember]
        public virtual string M_city
        {
            get
            {
                return this.m_M_city;
            }
            set
            {
                this.m_M_city = value;
            }
        }

		[DataMember]
        public virtual string M_province
        {
            get
            {
                return this.m_M_province;
            }
            set
            {
                this.m_M_province = value;
            }
        }

		[DataMember]
        public virtual string M_arears
        {
            get
            {
                return this.m_M_arears;
            }
            set
            {
                this.m_M_arears = value;
            }
        }

		[DataMember]
        public virtual string M_corporation
        {
            get
            {
                return this.m_M_corporation;
            }
            set
            {
                this.m_M_corporation = value;
            }
        }

		[DataMember]
        public virtual string M_zip
        {
            get
            {
                return this.m_M_zip;
            }
            set
            {
                this.m_M_zip = value;
            }
        }

		[DataMember]
        public virtual string M_degree
        {
            get
            {
                return this.m_M_degree;
            }
            set
            {
                this.m_M_degree = value;
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
        public virtual string Jy_class_id
        {
            get
            {
                return this.m_Jy_class_id;
            }
            set
            {
                this.m_Jy_class_id = value;
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
        public virtual DateTime Join_date
        {
            get
            {
                return this.m_Join_date;
            }
            set
            {
                this.m_Join_date = value;
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
        public virtual string Active_flag
        {
            get
            {
                return this.m_Active_flag;
            }
            set
            {
                this.m_Active_flag = value;
            }
        }

		[DataMember]
        public virtual string Upgrade_o_id
        {
            get
            {
                return this.m_Upgrade_o_id;
            }
            set
            {
                this.m_Upgrade_o_id = value;
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
        public virtual string M_zw
        {
            get
            {
                return this.m_M_zw;
            }
            set
            {
                this.m_M_zw = value;
            }
        }

		[DataMember]
        public virtual string M_zy
        {
            get
            {
                return this.m_M_zy;
            }
            set
            {
                this.m_M_zy = value;
            }
        }

		[DataMember]
        public virtual string M_period
        {
            get
            {
                return this.m_M_period;
            }
            set
            {
                this.m_M_period = value;
            }
        }

		[DataMember]
        public virtual string M_income
        {
            get
            {
                return this.m_M_income;
            }
            set
            {
                this.m_M_income = value;
            }
        }

		[DataMember]
        public virtual string Jy_flag
        {
            get
            {
                return this.m_Jy_flag;
            }
            set
            {
                this.m_Jy_flag = value;
            }
        }

		[DataMember]
        public virtual string Focus_flag
        {
            get
            {
                return this.m_Focus_flag;
            }
            set
            {
                this.m_Focus_flag = value;
            }
        }

		[DataMember]
        public virtual string M_address_song
        {
            get
            {
                return this.m_M_address_song;
            }
            set
            {
                this.m_M_address_song = value;
            }
        }

		[DataMember]
        public virtual string M_station
        {
            get
            {
                return this.m_M_station;
            }
            set
            {
                this.m_M_station = value;
            }
        }

		[DataMember]
        public virtual string M_zip_song
        {
            get
            {
                return this.m_M_zip_song;
            }
            set
            {
                this.m_M_zip_song = value;
            }
        }

		[DataMember]
        public virtual string M_department_song
        {
            get
            {
                return this.m_M_department_song;
            }
            set
            {
                this.m_M_department_song = value;
            }
        }

		[DataMember]
        public virtual string M_name_accept
        {
            get
            {
                return this.m_M_name_accept;
            }
            set
            {
                this.m_M_name_accept = value;
            }
        }

		[DataMember]
        public virtual string M_join_type
        {
            get
            {
                return this.m_M_join_type;
            }
            set
            {
                this.m_M_join_type = value;
            }
        }

		[DataMember]
        public virtual string M_send_letter
        {
            get
            {
                return this.m_M_send_letter;
            }
            set
            {
                this.m_M_send_letter = value;
            }
        }

		[DataMember]
        public virtual string M_introduce
        {
            get
            {
                return this.m_M_introduce;
            }
            set
            {
                this.m_M_introduce = value;
            }
        }

		[DataMember]
        public virtual string M_mobile
        {
            get
            {
                return this.m_M_mobile;
            }
            set
            {
                this.m_M_mobile = value;
            }
        }

		[DataMember]
        public virtual string M_mobile_type
        {
            get
            {
                return this.m_M_mobile_type;
            }
            set
            {
                this.m_M_mobile_type = value;
            }
        }

		[DataMember]
        public virtual string M_ziye
        {
            get
            {
                return this.m_M_ziye;
            }
            set
            {
                this.m_M_ziye = value;
            }
        }

		[DataMember]
        public virtual string M_account
        {
            get
            {
                return this.m_M_account;
            }
            set
            {
                this.m_M_account = value;
            }
        }

		[DataMember]
        public virtual string M_question
        {
            get
            {
                return this.m_M_question;
            }
            set
            {
                this.m_M_question = value;
            }
        }

		[DataMember]
        public virtual string M_answer
        {
            get
            {
                return this.m_M_answer;
            }
            set
            {
                this.m_M_answer = value;
            }
        }

		[DataMember]
        public virtual string M_homeland
        {
            get
            {
                return this.m_M_homeland;
            }
            set
            {
                this.m_M_homeland = value;
            }
        }

		[DataMember]
        public virtual string M_school
        {
            get
            {
                return this.m_M_school;
            }
            set
            {
                this.m_M_school = value;
            }
        }

		[DataMember]
        public virtual string M_hometel
        {
            get
            {
                return this.m_M_hometel;
            }
            set
            {
                this.m_M_hometel = value;
            }
        }

		[DataMember]
        public virtual string M_worktel
        {
            get
            {
                return this.m_M_worktel;
            }
            set
            {
                this.m_M_worktel = value;
            }
        }

		[DataMember]
        public virtual string M_homepage
        {
            get
            {
                return this.m_M_homepage;
            }
            set
            {
                this.m_M_homepage = value;
            }
        }

		[DataMember]
        public virtual string M_homeaddress
        {
            get
            {
                return this.m_M_homeaddress;
            }
            set
            {
                this.m_M_homeaddress = value;
            }
        }

		[DataMember]
        public virtual string M_homezipcode
        {
            get
            {
                return this.m_M_homezipcode;
            }
            set
            {
                this.m_M_homezipcode = value;
            }
        }

		[DataMember]
        public virtual string M_workaddress
        {
            get
            {
                return this.m_M_workaddress;
            }
            set
            {
                this.m_M_workaddress = value;
            }
        }

		[DataMember]
        public virtual string M_workzipcode
        {
            get
            {
                return this.m_M_workzipcode;
            }
            set
            {
                this.m_M_workzipcode = value;
            }
        }

		[DataMember]
        public virtual string M_send_comu
        {
            get
            {
                return this.m_M_send_comu;
            }
            set
            {
                this.m_M_send_comu = value;
            }
        }

		[DataMember]
        public virtual string M_fax
        {
            get
            {
                return this.m_M_fax;
            }
            set
            {
                this.m_M_fax = value;
            }
        }

		[DataMember]
        public virtual int Defer_times
        {
            get
            {
                return this.m_Defer_times;
            }
            set
            {
                this.m_Defer_times = value;
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
        public virtual string Yg_flag
        {
            get
            {
                return this.m_Yg_flag;
            }
            set
            {
                this.m_Yg_flag = value;
            }
        }

		[DataMember]
        public virtual string Is_calltemp
        {
            get
            {
                return this.m_Is_calltemp;
            }
            set
            {
                this.m_Is_calltemp = value;
            }
        }

		[DataMember]
        public virtual DateTime Sum_date
        {
            get
            {
                return this.m_Sum_date;
            }
            set
            {
                this.m_Sum_date = value;
            }
        }

		[DataMember]
        public virtual string Station_id_yg
        {
            get
            {
                return this.m_Station_id_yg;
            }
            set
            {
                this.m_Station_id_yg = value;
            }
        }

		[DataMember]
        public virtual string O_id_charge
        {
            get
            {
                return this.m_O_id_charge;
            }
            set
            {
                this.m_O_id_charge = value;
            }
        }


        #endregion

    }
}