using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;

using WHC.Pager.Entity;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using Microsoft.Practices.EnterpriseLibrary.Data;
using POSS.Entity;
using POSS.IDAL;

namespace POSS.DALSQL
{
    /// <summary>
    /// Product
    /// </summary>
	public class Product : BaseDALSQL<ProductInfo>, IProduct
	{
		#region 对象实例及构造函数

		public static Product Instance
		{
			get
			{
				return new Product();
			}
		}
		public Product() : base("db_product","h_id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override ProductInfo DataReaderToEntity(IDataReader dataReader)
		{
			ProductInfo info = new ProductInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.H_id = reader.GetString("h_id");
			info.H_type = reader.GetString("h_type");
			info.H_level_3 = reader.GetString("h_level_3");
			info.H_level_2 = reader.GetString("h_level_2");
			info.H_level_1 = reader.GetString("h_level_1");
			info.H_name = reader.GetString("h_name");
			info.H_run_style = reader.GetString("h_run_style");
			info.U_id = reader.GetString("u_id");
			info.Bz_id = reader.GetString("bz_id");
			info.H_package_ammount = reader.GetInt32("h_package_ammount");
			info.H_mem = reader.GetString("h_mem");
			info.H_factory = reader.GetString("h_factory");
			info.H_exist = reader.GetString("h_exist");
			info.H_isbn = reader.GetString("h_isbn");
			info.H_input_price = reader.GetDecimal("h_input_price");
			info.H_output_price = reader.GetDecimal("h_output_price");
			info.Pub_id = reader.GetString("pub_id");
			info.H_mytm = reader.GetString("h_mytm");
			info.H_writer = reader.GetString("h_writer");
			info.H_translator = reader.GetString("h_translator");
			info.Kb_id = reader.GetString("kb_id");
			info.Zz_id = reader.GetString("zz_id");
			info.H_banci = reader.GetString("h_banci");
			info.H_taozhuang = reader.GetString("h_taozhuang");
			info.H_bak1 = reader.GetString("h_bak1");
			info.H_bak2 = reader.GetString("h_bak2");
			info.H_publish_date = reader.GetDateTime("h_publish_date");
			info.My_help_input = reader.GetString("my_help_input");
			info.H_page_number = reader.GetInt32("h_page_number");
			info.H_word_number = reader.GetInt32("h_word_number");
			info.H_serial_book = reader.GetString("h_serial_book");
			info.H_yin_number = reader.GetInt32("h_yin_number");
			info.H_input_date = reader.GetDateTime("h_input_date");
			info.Hy_price = reader.GetDecimal("hy_price");
			info.H_weight = reader.GetDecimal("h_weight");
			info.H_height = reader.GetDecimal("h_height");
			info.Yylb_id = reader.GetString("yylb_id");
			info.H_hopesell = reader.GetDateTime("h_hopesell");
			info.Isbn_class = reader.GetString("isbn_class");
			info.Is_my = reader.GetString("is_my");
			info.Is_focus = reader.GetString("is_focus");
			info.Yz_id = reader.GetString("yz_id");
			info.H_period_id = reader.GetString("h_period_id");
			info.H_media = reader.GetString("h_media");
			info.Is_export = reader.GetString("is_export");
			info.H_reader = reader.GetString("h_reader");
			info.Exchange_id = reader.GetString("exchange_id");
			info.Flag_sales_class = reader.GetString("flag_sales_class");
			info.Notrigger = reader.GetString("notrigger");
			info.Last_mod_date = reader.GetDateTime("last_mod_date");
			info.Last_trans_date = reader.GetDateTime("last_trans_date");
			info.Many_flag = reader.GetString("many_flag");
			info.Copyright_id = reader.GetString("copyright_id");
			info.Inside_id = reader.GetString("inside_id");
			info.Sales_type = reader.GetString("sales_type");
			info.Vom_class = reader.GetString("vom_class");
			info.Vom_tj_flag = reader.GetString("vom_tj_flag");
			info.Pagecount = reader.GetInt32("pagecount");
			info.Immobility_cost = reader.GetDecimal("immobility_cost");
			info.Immobility_cost_other = reader.GetDecimal("immobility_cost_other");
			info.O_id_lastmodify = reader.GetString("o_id_lastmodify");
			info.Isall = reader.GetInt32("isall");
			info.H_content = reader.GetString("h_content");
			info.H_face = reader.GetString("h_face");
			info.H_largeimage = reader.GetString("h_largeimage");
			info.H_smallimage = reader.GetString("h_smallimage");
			info.H_list = reader.GetString("h_list");
			info.Pri_sheetcount = reader.GetDecimal("pri_sheetcount");
			info.Pri_times = reader.GetDecimal("pri_times");
			info.O_id_input = reader.GetString("o_id_input");
			info.Account_limit = reader.GetInt32("account_limit");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(ProductInfo obj)
		{
		    ProductInfo info = obj as ProductInfo;
			Hashtable hash = new Hashtable(); 
			
			hash.Add("h_id", info.H_id);
 			hash.Add("h_type", info.H_type);
 			hash.Add("h_level_3", info.H_level_3);
 			hash.Add("h_level_2", info.H_level_2);
 			hash.Add("h_level_1", info.H_level_1);
 			hash.Add("h_name", info.H_name);
 			hash.Add("h_run_style", info.H_run_style);
 			hash.Add("u_id", info.U_id);
 			hash.Add("bz_id", info.Bz_id);
 			hash.Add("h_package_ammount", info.H_package_ammount);
 			hash.Add("h_mem", info.H_mem);
 			hash.Add("h_factory", info.H_factory);
 			hash.Add("h_exist", info.H_exist);
 			hash.Add("h_isbn", info.H_isbn);
 			hash.Add("h_input_price", info.H_input_price);
 			hash.Add("h_output_price", info.H_output_price);
 			hash.Add("pub_id", info.Pub_id);
 			hash.Add("h_mytm", info.H_mytm);
 			hash.Add("h_writer", info.H_writer);
 			hash.Add("h_translator", info.H_translator);
 			hash.Add("kb_id", info.Kb_id);
 			hash.Add("zz_id", info.Zz_id);
 			hash.Add("h_banci", info.H_banci);
 			hash.Add("h_taozhuang", info.H_taozhuang);
 			hash.Add("h_bak1", info.H_bak1);
 			hash.Add("h_bak2", info.H_bak2);
 			hash.Add("h_publish_date", info.H_publish_date);
 			hash.Add("my_help_input", info.My_help_input);
 			hash.Add("h_page_number", info.H_page_number);
 			hash.Add("h_word_number", info.H_word_number);
 			hash.Add("h_serial_book", info.H_serial_book);
 			hash.Add("h_yin_number", info.H_yin_number);
 			hash.Add("h_input_date", info.H_input_date);
 			hash.Add("hy_price", info.Hy_price);
 			hash.Add("h_weight", info.H_weight);
 			hash.Add("h_height", info.H_height);
 			hash.Add("yylb_id", info.Yylb_id);
 			hash.Add("h_hopesell", info.H_hopesell);
 			hash.Add("isbn_class", info.Isbn_class);
 			hash.Add("is_my", info.Is_my);
 			hash.Add("is_focus", info.Is_focus);
 			hash.Add("yz_id", info.Yz_id);
 			hash.Add("h_period_id", info.H_period_id);
 			hash.Add("h_media", info.H_media);
 			hash.Add("is_export", info.Is_export);
 			hash.Add("h_reader", info.H_reader);
 			hash.Add("exchange_id", info.Exchange_id);
 			hash.Add("flag_sales_class", info.Flag_sales_class);
 			hash.Add("notrigger", info.Notrigger);
 			hash.Add("last_mod_date", info.Last_mod_date);
 			hash.Add("last_trans_date", info.Last_trans_date);
 			hash.Add("many_flag", info.Many_flag);
 			hash.Add("copyright_id", info.Copyright_id);
 			hash.Add("inside_id", info.Inside_id);
 			hash.Add("sales_type", info.Sales_type);
 			hash.Add("vom_class", info.Vom_class);
 			hash.Add("vom_tj_flag", info.Vom_tj_flag);
 			hash.Add("pagecount", info.Pagecount);
 			hash.Add("immobility_cost", info.Immobility_cost);
 			hash.Add("immobility_cost_other", info.Immobility_cost_other);
 			hash.Add("o_id_lastmodify", info.O_id_lastmodify);
 			hash.Add("isall", info.Isall);
 			hash.Add("h_content", info.H_content);
 			hash.Add("h_face", info.H_face);
 			hash.Add("h_largeimage", info.H_largeimage);
 			hash.Add("h_smallimage", info.H_smallimage);
 			hash.Add("h_list", info.H_list);
 			hash.Add("pri_sheetcount", info.Pri_sheetcount);
 			hash.Add("pri_times", info.Pri_times);
 			hash.Add("o_id_input", info.O_id_input);
 			hash.Add("account_limit", info.Account_limit);
 				
			return hash;
		}

        /// <summary>
        /// 获取字段中文别名（用于界面显示）的字典集合
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, string> GetColumnNameAlias()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            #region 添加别名解析
            //dict.Add("ID", "编号");
            dict.Add("H_id", "");
             dict.Add("H_type", "");
             dict.Add("H_level_3", "");
             dict.Add("H_level_2", "");
             dict.Add("H_level_1", "");
             dict.Add("H_name", "");
             dict.Add("H_run_style", "");
             dict.Add("U_id", "");
             dict.Add("Bz_id", "");
             dict.Add("H_package_ammount", "");
             dict.Add("H_mem", "");
             dict.Add("H_factory", "");
             dict.Add("H_exist", "");
             dict.Add("H_isbn", "");
             dict.Add("H_input_price", "");
             dict.Add("H_output_price", "");
             dict.Add("Pub_id", "");
             dict.Add("H_mytm", "");
             dict.Add("H_writer", "");
             dict.Add("H_translator", "");
             dict.Add("Kb_id", "");
             dict.Add("Zz_id", "");
             dict.Add("H_banci", "");
             dict.Add("H_taozhuang", "");
             dict.Add("H_bak1", "");
             dict.Add("H_bak2", "");
             dict.Add("H_publish_date", "");
             dict.Add("My_help_input", "");
             dict.Add("H_page_number", "");
             dict.Add("H_word_number", "");
             dict.Add("H_serial_book", "");
             dict.Add("H_yin_number", "");
             dict.Add("H_input_date", "");
             dict.Add("Hy_price", "");
             dict.Add("H_weight", "");
             dict.Add("H_height", "");
             dict.Add("Yylb_id", "");
             dict.Add("H_hopesell", "");
             dict.Add("Isbn_class", "");
             dict.Add("Is_my", "");
             dict.Add("Is_focus", "");
             dict.Add("Yz_id", "");
             dict.Add("H_period_id", "");
             dict.Add("H_media", "");
             dict.Add("Is_export", "");
             dict.Add("H_reader", "");
             dict.Add("Exchange_id", "");
             dict.Add("Flag_sales_class", "");
             dict.Add("Notrigger", "");
             dict.Add("Last_mod_date", "");
             dict.Add("Last_trans_date", "");
             dict.Add("Many_flag", "");
             dict.Add("Copyright_id", "");
             dict.Add("Inside_id", "");
             dict.Add("Sales_type", "");
             dict.Add("Vom_class", "");
             dict.Add("Vom_tj_flag", "");
             dict.Add("Pagecount", "");
             dict.Add("Immobility_cost", "");
             dict.Add("Immobility_cost_other", "");
             dict.Add("O_id_lastmodify", "");
             dict.Add("Isall", "");
             dict.Add("H_content", "");
             dict.Add("H_face", "");
             dict.Add("H_largeimage", "");
             dict.Add("H_smallimage", "");
             dict.Add("H_list", "");
             dict.Add("Pri_sheetcount", "");
             dict.Add("Pri_times", "");
             dict.Add("O_id_input", "");
             dict.Add("Account_limit", "");
             #endregion

            return dict;
        }


        /// <summary>
        /// 检索商品信息返回简单商品实体
        /// </summary>
        /// <param name="where">检索条件</param>
        /// <param name="station_id">站点编号</param>
        /// <param name="m_id">会员编号</param>
        /// <param name="whc_num">显示多少条记录</param>
        /// <returns></returns>
        public List<SimpleProductInfo> Get_simpleproduct(string where, string station_id, string m_id, string whc_num)
        {
            List<SimpleProductInfo> list = new List<SimpleProductInfo>();
            string cmd = string.Empty;
            cmd = @"SELECT  top({1})
                            H_isbn=db_product.h_isbn ,
                            H_name=db_product.h_name ,
                            H_id=db_product.h_id ,
                            U_id=db_product.u_id ,
                            H_factory=db_product.h_factory ,
                            H_id_dis=db_product_discount.h_id ,
                            H_output_discount=db_product_discount.h_output_discount ,
                            H_output_discount_ls=db_product_discount.h_output_discount_ls ,
                           
                            Limite_zk=db_product_discount.limite_zk ,
                            Limit_date_zk=db_product_discount.limit_date_zk ,
                            H_output_discount_yg=db_product_discount.h_output_discount_yg ,
                            H_output_discount_ps=db_product_discount.h_output_discount_ps ,
                            H_output_price=db_product.h_output_price ,
                            H_output_discount_member_ls=db_product_discount.h_output_discount_member_ls ,
                          
                            Stock_ammount=dbo.uf_GetStockAmount('{2}','',db_product.h_id),
                            H_type=dbo.db_product.h_type,
                            Pub_name=dbo.uf_getPubName(db_product.pub_id),
                            Ls_sum=dbo.uf_getproductprice_ls(db_product.h_id)*1*( h_output_discount_ls)
                    FROM    db_product_discount ,
                            db_product
                    WHERE   ( ( db_product_discount.h_id = db_product.h_id ) ) and h_exist='1' 
                        {0}
                    ";
            string sql = string.Empty;
            if (!string.IsNullOrEmpty(where))
            {
                sql = string.Format(cmd,  where, whc_num, station_id);
            }
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(sql);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderSimpleProduct(reader));
            }
            return list;
        }
        private SimpleProductInfo ReaderSimpleProduct(IDataReader ireader)
        {
            SimpleProductInfo info = new SimpleProductInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.H_factory = reader.GetString("H_factory");
            info.H_id = reader.GetString("H_id");
            info.H_id_dis = reader.GetString("H_id_dis");
            info.H_isbn = reader.GetString("H_isbn");
            info.H_name = reader.GetString("H_name");
            info.H_output_discount = reader.GetDecimal("H_output_discount");
            info.H_output_discount_ls = reader.GetDecimal("H_output_discount_ls");
            info.H_output_discount_member_ls = reader.GetDecimal("H_output_discount_member_ls");
            info.H_output_discount_ps = reader.GetDecimal("H_output_discount_ps");
            info.H_output_discount_yg = reader.GetDecimal("H_output_discount_yg");
            info.H_output_price = reader.GetDecimal("H_output_price");
            info.Limite_zk = reader.GetDecimal("Limite_zk");
            info.Limit_date_zk = reader.GetDecimal("Limit_date_zk");
            //info.Local_price_LS = reader.GetDecimal("Local_price_LS");
            //info.Local_price_PX = reader.GetDecimal("Local_price_PX");
            info.Stock_amount = reader.GetInt32("Stock_ammount");
            info.U_id = reader.GetString("U_id");
            info.Ls_Sum = reader.GetDecimal("Ls_sum");
            //info.H_Member_Ls = reader.GetDecimal("H_Member_Ls");
            info.Pub_name = reader.GetString("Pub_name");
            info.H_type = reader.GetString("H_type");
            //info.M_id = reader.GetString("M_id");
            return info;

        }

        /// <summary>
        /// 获得某一站点、某图书出库时，应出库房
        /// </summary>
        /// <param name="station_id">站点编码</param>
        /// <param name="h_id">商品编码</param>
        /// <param name="amount">出库数量</param>
        /// <param name="flag_method">0代表如果不多个库房则不理睬，1代表如果有多个库房，则取数量取小的，2代表如果有多个库房则取数最大的</param>
        /// <param name="flag_negative">0表示允许负库存,1表示禁止负库存</param>
        /// <returns></returns>
        public string GetHistoryStock(string station_id, string h_id, int amount, string flag_method, string flag_negative)
        {
            string cmd = "SELECT dbo.uf_GetHistoryStock ( '{0}' , '{1}' , {2} , '{3}' , '{4}' )";
            cmd = string.Format(cmd, station_id, h_id, amount, flag_method, flag_negative);
            return ExecuteScalarBySql(cmd).ToString();
        }
        /// <summary>
        /// 获取商品类别库房uf_GetStockId
        /// </summary>
        /// <param name="prodInfo">商品信息</param>
        /// <param name="station_id">站点编码</param>
        /// <returns></returns>
        public string GetStockByProductType(string h_id, string station_id)
        {
            string cmdText = "SELECT dbo.uf_GetStockId ('{1}' , h_type ) FROM db_product WHERE h_id ='{0}' ";
            return ExecuteScalarBySql(string.Format(cmdText, h_id, station_id)).ToString();
        }


        /// <summary>
        /// 获取商品会员折扣
        /// </summary>
        /// <param name="prodInfo">商品信息</param>
        /// <param name="station_id">站点编码</param>
        /// <param name="memberInfo">会员信息,如是零售,则会员编码为:<RETAIL></param>
        /// <returns></returns>
        public virtual decimal GetMemberDiscountByProduct(string h_id, string station_id, string  m_id,int h_amount,decimal h_out_price)
        {
            string cmd = "SELECT TOP 1 dbo.uf_GetMemberLSDisCOUNT('{0}','{1}','{2}',{3},{4},'{5}')";
            cmd = string.Format(cmd, station_id, m_id,h_id, h_amount, h_out_price,DateTime.Now);
            return ExecuteScalarBySql(cmd).ToString().ToDecimal();
           

        }

    }
}