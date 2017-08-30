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
    /// Ls_card_surplus
    /// </summary>
	public class Ls_card_surplus : BaseDALSQL<Ls_card_surplusInfo>, ILs_card_surplus
	{
		#region 对象实例及构造函数

		public static Ls_card_surplus Instance
		{
			get
			{
				return new Ls_card_surplus();
			}
		}
		public Ls_card_surplus() : base("db_ls_card_surplus","card_id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override Ls_card_surplusInfo DataReaderToEntity(IDataReader dataReader)
		{
			Ls_card_surplusInfo info = new Ls_card_surplusInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.Card_id = reader.GetString("card_id");
			info.Surplus_money = reader.GetDecimal("surplus_money");
			info.Input_date = reader.GetDateTime("input_date");
			info.End_date = reader.GetDateTime("end_date");
			info.Password = reader.GetString("password");
			info.Valid_flag = reader.GetString("valid_flag");
			info.M_id = reader.GetString("m_id");
			info.Memo = reader.GetString("memo");
			info.O_id_input = reader.GetString("o_id_input");
			info.Discount = reader.GetDecimal("discount");
			info.Max_money = reader.GetDecimal("max_money");
			info.Buy_department = reader.GetString("buy_department");
			info.C_id = reader.GetString("c_id");
			info.O_id_operator = reader.GetString("o_id_operator");
			info.Station_id = reader.GetString("station_id");
			info.D_id = reader.GetString("d_id");
			info.Lk_date = reader.GetDateTime("lk_date");
			info.Lk_p_id = reader.GetString("lk_p_id");
			info.Fk_input = reader.GetString("fk_input");
			info.Fk_date = reader.GetDateTime("fk_date");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(Ls_card_surplusInfo obj)
		{
		    Ls_card_surplusInfo info = obj as Ls_card_surplusInfo;
			Hashtable hash = new Hashtable(); 
			
			hash.Add("card_id", info.Card_id);
 			hash.Add("surplus_money", info.Surplus_money);
 			hash.Add("input_date", info.Input_date);
 			hash.Add("end_date", info.End_date);
 			hash.Add("password", info.Password);
 			hash.Add("valid_flag", info.Valid_flag);
 			hash.Add("m_id", info.M_id);
 			hash.Add("memo", info.Memo);
 			hash.Add("o_id_input", info.O_id_input);
 			hash.Add("discount", info.Discount);
 			hash.Add("max_money", info.Max_money);
 			hash.Add("buy_department", info.Buy_department);
 			hash.Add("c_id", info.C_id);
 			hash.Add("o_id_operator", info.O_id_operator);
 			hash.Add("station_id", info.Station_id);
 			hash.Add("d_id", info.D_id);
 			hash.Add("lk_date", info.Lk_date);
 			hash.Add("lk_p_id", info.Lk_p_id);
 			hash.Add("fk_input", info.Fk_input);
 			hash.Add("fk_date", info.Fk_date);
 				
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
            dict.Add("Card_id", "");
             dict.Add("Surplus_money", "");
             dict.Add("Input_date", "");
             dict.Add("End_date", "");
             dict.Add("Password", "");
             dict.Add("Valid_flag", "");
             dict.Add("M_id", "");
             dict.Add("Memo", "");
             dict.Add("O_id_input", "");
             dict.Add("Discount", "");
             dict.Add("Max_money", "");
             dict.Add("Buy_department", "");
             dict.Add("C_id", "");
             dict.Add("O_id_operator", "");
             dict.Add("Station_id", "");
             dict.Add("D_id", "");
             dict.Add("Lk_date", "");
             dict.Add("Lk_p_id", "");
             dict.Add("Fk_input", "");
             dict.Add("Fk_date", "");
             #endregion

            return dict;
        }

        /// <summary>
        /// 以卡号查询会员信息
        /// </summary>
        /// <param name="card">卡号</param>
        /// <returns></returns>
        public List<SimpleMemberInfo> GetMemberByCard(string card)
        {
            List<SimpleMemberInfo> list = new List<SimpleMemberInfo>();
            string cmd = @"
                        SELECT M_id = db_member.m_id,
                        M_name = db_member.m_name,
                        M_department_song = dbo.db_member.m_department_song,
                        M_tel = db_member.m_tel,
                        M_type = db_member.m_type,
                        Card_id = db_member.card_id,
                        M_adress = db_member.m_adress,
                        End_date = dbo.db_member.end_date,
                        Integral = dbo.uf_GetMemberIntegral(dbo.db_member.m_id),
                        Station_id = dbo.db_member.station_id,
                        SurplusMoney = dbo.uf_GetMemberSurplusMoney_money(db_member.card_id)
                    FROM db_member,
                        vv_Member_salesTotal
                    WHERE db_member.m_id = dbo.vv_Member_salesTotal.m_id
                          AND active_flag = '1'
                          AND ls_flag = '1'
                          AND Card_id = '{0}';";
            string sql = string.Format(cmd, card);
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(sql);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderMemberInfo(reader));
            }

            return list;
        }

        private SimpleMemberInfo ReaderMemberInfo(IDataReader ireader)
        {
            SimpleMemberInfo info = new SimpleMemberInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.Card_id = reader.GetString("Card_id");
            info.End_date = reader.GetDateTime("End_date");
            info.Integral = reader.GetString("Integral");
            info.M_adress = reader.GetString("M_adress");
            info.M_department_song = reader.GetString("M_department_song");
            info.M_id = reader.GetString("M_id");
            info.M_name = reader.GetString("M_name");
            info.M_tel = reader.GetString("M_tel");
            info.M_type = reader.GetString("M_type");
            info.Station_id = reader.GetString("Station_id");
            info.SurplusMoney = reader.GetString("SurplusMoney");

            return info;
        }
    }
}