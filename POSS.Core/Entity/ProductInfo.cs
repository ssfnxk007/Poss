using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using WHC.Framework.ControlUtil;

namespace POSS.Entity
{
    /// <summary>
    /// ProductInfo
    /// </summary>
    [DataContract]
    public class ProductInfo : BaseEntity
    {    
        #region Field Members

        private string m_H_id = System.Guid.NewGuid().ToString(); //          
        private string m_H_type; //          
        private string m_H_level_3; //          
        private string m_H_level_2; //          
        private string m_H_level_1; //          
        private string m_H_name; //          
        private string m_H_run_style; //          
        private string m_U_id; //          
        private string m_Bz_id; //          
        private int m_H_package_ammount = 0; //          
        private string m_H_mem; //          
        private string m_H_factory; //          
        private string m_H_exist = "1"; //          
        private string m_H_isbn; //          
        private decimal m_H_input_price = 0; //          
        private decimal m_H_output_price = 0; //          
        private string m_Pub_id; //          
        private string m_H_mytm = "无"; //          
        private string m_H_writer; //          
        private string m_H_translator; //          
        private string m_Kb_id; //          
        private string m_Zz_id; //          
        private string m_H_banci; //          
        private string m_H_taozhuang; //          
        private string m_H_bak1; //          
        private string m_H_bak2; //          
        private DateTime m_H_publish_date; //          
        private string m_My_help_input; //          
        private int m_H_page_number = 0; //          
        private int m_H_word_number = 0; //          
        private string m_H_serial_book; //          
        private int m_H_yin_number = 0; //          
        private DateTime m_H_input_date; //          
        private decimal m_Hy_price = 0; //          
        private decimal m_H_weight = 0; //          
        private decimal m_H_height = 0; //          
        private string m_Yylb_id; //          
        private DateTime m_H_hopesell; //          
        private string m_Isbn_class; //          
        private string m_Is_my = "0"; //          
        private string m_Is_focus = "0"; //          
        private string m_Yz_id; //          
        private string m_H_period_id; //          
        private string m_H_media; //          
        private string m_Is_export = "0"; //          
        private string m_H_reader; //          
        private string m_Exchange_id; //          
        private string m_Flag_sales_class = "0"; //          
        private string m_Notrigger; //          
        private DateTime m_Last_mod_date; //          
        private DateTime m_Last_trans_date; //          
        private string m_Many_flag = "0"; //          
        private string m_Copyright_id; //          
        private string m_Inside_id; //          
        private string m_Sales_type; //          
        private string m_Vom_class; //          
        private string m_Vom_tj_flag = "0"; //          
        private int m_Pagecount = 0; //          
        private decimal m_Immobility_cost = 0; //          
        private decimal m_Immobility_cost_other = 0; //          
        private string m_O_id_lastmodify; //          
        private int m_Isall = 0; //          
        private string m_H_content; //          
        private string m_H_face; //          
        private string m_H_largeimage; //          
        private string m_H_smallimage; //          
        private string m_H_list; //          
        private decimal m_Pri_sheetcount = 0; //          
        private decimal m_Pri_times = 0; //          
        private string m_O_id_input; //          
        private int m_Account_limit = 0; //          

        #endregion

        #region Property Members
        
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
        public virtual string H_type
        {
            get
            {
                return this.m_H_type;
            }
            set
            {
                this.m_H_type = value;
            }
        }

		[DataMember]
        public virtual string H_level_3
        {
            get
            {
                return this.m_H_level_3;
            }
            set
            {
                this.m_H_level_3 = value;
            }
        }

		[DataMember]
        public virtual string H_level_2
        {
            get
            {
                return this.m_H_level_2;
            }
            set
            {
                this.m_H_level_2 = value;
            }
        }

		[DataMember]
        public virtual string H_level_1
        {
            get
            {
                return this.m_H_level_1;
            }
            set
            {
                this.m_H_level_1 = value;
            }
        }

		[DataMember]
        public virtual string H_name
        {
            get
            {
                return this.m_H_name;
            }
            set
            {
                this.m_H_name = value;
            }
        }

		[DataMember]
        public virtual string H_run_style
        {
            get
            {
                return this.m_H_run_style;
            }
            set
            {
                this.m_H_run_style = value;
            }
        }

		[DataMember]
        public virtual string U_id
        {
            get
            {
                return this.m_U_id;
            }
            set
            {
                this.m_U_id = value;
            }
        }

		[DataMember]
        public virtual string Bz_id
        {
            get
            {
                return this.m_Bz_id;
            }
            set
            {
                this.m_Bz_id = value;
            }
        }

		[DataMember]
        public virtual int H_package_ammount
        {
            get
            {
                return this.m_H_package_ammount;
            }
            set
            {
                this.m_H_package_ammount = value;
            }
        }

		[DataMember]
        public virtual string H_mem
        {
            get
            {
                return this.m_H_mem;
            }
            set
            {
                this.m_H_mem = value;
            }
        }

		[DataMember]
        public virtual string H_factory
        {
            get
            {
                return this.m_H_factory;
            }
            set
            {
                this.m_H_factory = value;
            }
        }

		[DataMember]
        public virtual string H_exist
        {
            get
            {
                return this.m_H_exist;
            }
            set
            {
                this.m_H_exist = value;
            }
        }

		[DataMember]
        public virtual string H_isbn
        {
            get
            {
                return this.m_H_isbn;
            }
            set
            {
                this.m_H_isbn = value;
            }
        }

		[DataMember]
        public virtual decimal H_input_price
        {
            get
            {
                return this.m_H_input_price;
            }
            set
            {
                this.m_H_input_price = value;
            }
        }

		[DataMember]
        public virtual decimal H_output_price
        {
            get
            {
                return this.m_H_output_price;
            }
            set
            {
                this.m_H_output_price = value;
            }
        }

		[DataMember]
        public virtual string Pub_id
        {
            get
            {
                return this.m_Pub_id;
            }
            set
            {
                this.m_Pub_id = value;
            }
        }

		[DataMember]
        public virtual string H_mytm
        {
            get
            {
                return this.m_H_mytm;
            }
            set
            {
                this.m_H_mytm = value;
            }
        }

		[DataMember]
        public virtual string H_writer
        {
            get
            {
                return this.m_H_writer;
            }
            set
            {
                this.m_H_writer = value;
            }
        }

		[DataMember]
        public virtual string H_translator
        {
            get
            {
                return this.m_H_translator;
            }
            set
            {
                this.m_H_translator = value;
            }
        }

		[DataMember]
        public virtual string Kb_id
        {
            get
            {
                return this.m_Kb_id;
            }
            set
            {
                this.m_Kb_id = value;
            }
        }

		[DataMember]
        public virtual string Zz_id
        {
            get
            {
                return this.m_Zz_id;
            }
            set
            {
                this.m_Zz_id = value;
            }
        }

		[DataMember]
        public virtual string H_banci
        {
            get
            {
                return this.m_H_banci;
            }
            set
            {
                this.m_H_banci = value;
            }
        }

		[DataMember]
        public virtual string H_taozhuang
        {
            get
            {
                return this.m_H_taozhuang;
            }
            set
            {
                this.m_H_taozhuang = value;
            }
        }

		[DataMember]
        public virtual string H_bak1
        {
            get
            {
                return this.m_H_bak1;
            }
            set
            {
                this.m_H_bak1 = value;
            }
        }

		[DataMember]
        public virtual string H_bak2
        {
            get
            {
                return this.m_H_bak2;
            }
            set
            {
                this.m_H_bak2 = value;
            }
        }

		[DataMember]
        public virtual DateTime H_publish_date
        {
            get
            {
                return this.m_H_publish_date;
            }
            set
            {
                this.m_H_publish_date = value;
            }
        }

		[DataMember]
        public virtual string My_help_input
        {
            get
            {
                return this.m_My_help_input;
            }
            set
            {
                this.m_My_help_input = value;
            }
        }

		[DataMember]
        public virtual int H_page_number
        {
            get
            {
                return this.m_H_page_number;
            }
            set
            {
                this.m_H_page_number = value;
            }
        }

		[DataMember]
        public virtual int H_word_number
        {
            get
            {
                return this.m_H_word_number;
            }
            set
            {
                this.m_H_word_number = value;
            }
        }

		[DataMember]
        public virtual string H_serial_book
        {
            get
            {
                return this.m_H_serial_book;
            }
            set
            {
                this.m_H_serial_book = value;
            }
        }

		[DataMember]
        public virtual int H_yin_number
        {
            get
            {
                return this.m_H_yin_number;
            }
            set
            {
                this.m_H_yin_number = value;
            }
        }

		[DataMember]
        public virtual DateTime H_input_date
        {
            get
            {
                return this.m_H_input_date;
            }
            set
            {
                this.m_H_input_date = value;
            }
        }

		[DataMember]
        public virtual decimal Hy_price
        {
            get
            {
                return this.m_Hy_price;
            }
            set
            {
                this.m_Hy_price = value;
            }
        }

		[DataMember]
        public virtual decimal H_weight
        {
            get
            {
                return this.m_H_weight;
            }
            set
            {
                this.m_H_weight = value;
            }
        }

		[DataMember]
        public virtual decimal H_height
        {
            get
            {
                return this.m_H_height;
            }
            set
            {
                this.m_H_height = value;
            }
        }

		[DataMember]
        public virtual string Yylb_id
        {
            get
            {
                return this.m_Yylb_id;
            }
            set
            {
                this.m_Yylb_id = value;
            }
        }

		[DataMember]
        public virtual DateTime H_hopesell
        {
            get
            {
                return this.m_H_hopesell;
            }
            set
            {
                this.m_H_hopesell = value;
            }
        }

		[DataMember]
        public virtual string Isbn_class
        {
            get
            {
                return this.m_Isbn_class;
            }
            set
            {
                this.m_Isbn_class = value;
            }
        }

		[DataMember]
        public virtual string Is_my
        {
            get
            {
                return this.m_Is_my;
            }
            set
            {
                this.m_Is_my = value;
            }
        }

		[DataMember]
        public virtual string Is_focus
        {
            get
            {
                return this.m_Is_focus;
            }
            set
            {
                this.m_Is_focus = value;
            }
        }

		[DataMember]
        public virtual string Yz_id
        {
            get
            {
                return this.m_Yz_id;
            }
            set
            {
                this.m_Yz_id = value;
            }
        }

		[DataMember]
        public virtual string H_period_id
        {
            get
            {
                return this.m_H_period_id;
            }
            set
            {
                this.m_H_period_id = value;
            }
        }

		[DataMember]
        public virtual string H_media
        {
            get
            {
                return this.m_H_media;
            }
            set
            {
                this.m_H_media = value;
            }
        }

		[DataMember]
        public virtual string Is_export
        {
            get
            {
                return this.m_Is_export;
            }
            set
            {
                this.m_Is_export = value;
            }
        }

		[DataMember]
        public virtual string H_reader
        {
            get
            {
                return this.m_H_reader;
            }
            set
            {
                this.m_H_reader = value;
            }
        }

		[DataMember]
        public virtual string Exchange_id
        {
            get
            {
                return this.m_Exchange_id;
            }
            set
            {
                this.m_Exchange_id = value;
            }
        }

		[DataMember]
        public virtual string Flag_sales_class
        {
            get
            {
                return this.m_Flag_sales_class;
            }
            set
            {
                this.m_Flag_sales_class = value;
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
        public virtual string Many_flag
        {
            get
            {
                return this.m_Many_flag;
            }
            set
            {
                this.m_Many_flag = value;
            }
        }

		[DataMember]
        public virtual string Copyright_id
        {
            get
            {
                return this.m_Copyright_id;
            }
            set
            {
                this.m_Copyright_id = value;
            }
        }

		[DataMember]
        public virtual string Inside_id
        {
            get
            {
                return this.m_Inside_id;
            }
            set
            {
                this.m_Inside_id = value;
            }
        }

		[DataMember]
        public virtual string Sales_type
        {
            get
            {
                return this.m_Sales_type;
            }
            set
            {
                this.m_Sales_type = value;
            }
        }

		[DataMember]
        public virtual string Vom_class
        {
            get
            {
                return this.m_Vom_class;
            }
            set
            {
                this.m_Vom_class = value;
            }
        }

		[DataMember]
        public virtual string Vom_tj_flag
        {
            get
            {
                return this.m_Vom_tj_flag;
            }
            set
            {
                this.m_Vom_tj_flag = value;
            }
        }

		[DataMember]
        public virtual int Pagecount
        {
            get
            {
                return this.m_Pagecount;
            }
            set
            {
                this.m_Pagecount = value;
            }
        }

		[DataMember]
        public virtual decimal Immobility_cost
        {
            get
            {
                return this.m_Immobility_cost;
            }
            set
            {
                this.m_Immobility_cost = value;
            }
        }

		[DataMember]
        public virtual decimal Immobility_cost_other
        {
            get
            {
                return this.m_Immobility_cost_other;
            }
            set
            {
                this.m_Immobility_cost_other = value;
            }
        }

		[DataMember]
        public virtual string O_id_lastmodify
        {
            get
            {
                return this.m_O_id_lastmodify;
            }
            set
            {
                this.m_O_id_lastmodify = value;
            }
        }

		[DataMember]
        public virtual int Isall
        {
            get
            {
                return this.m_Isall;
            }
            set
            {
                this.m_Isall = value;
            }
        }

		[DataMember]
        public virtual string H_content
        {
            get
            {
                return this.m_H_content;
            }
            set
            {
                this.m_H_content = value;
            }
        }

		[DataMember]
        public virtual string H_face
        {
            get
            {
                return this.m_H_face;
            }
            set
            {
                this.m_H_face = value;
            }
        }

		[DataMember]
        public virtual string H_largeimage
        {
            get
            {
                return this.m_H_largeimage;
            }
            set
            {
                this.m_H_largeimage = value;
            }
        }

		[DataMember]
        public virtual string H_smallimage
        {
            get
            {
                return this.m_H_smallimage;
            }
            set
            {
                this.m_H_smallimage = value;
            }
        }

		[DataMember]
        public virtual string H_list
        {
            get
            {
                return this.m_H_list;
            }
            set
            {
                this.m_H_list = value;
            }
        }

		[DataMember]
        public virtual decimal Pri_sheetcount
        {
            get
            {
                return this.m_Pri_sheetcount;
            }
            set
            {
                this.m_Pri_sheetcount = value;
            }
        }

		[DataMember]
        public virtual decimal Pri_times
        {
            get
            {
                return this.m_Pri_times;
            }
            set
            {
                this.m_Pri_times = value;
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
        public virtual int Account_limit
        {
            get
            {
                return this.m_Account_limit;
            }
            set
            {
                this.m_Account_limit = value;
            }
        }


        #endregion

    }
}