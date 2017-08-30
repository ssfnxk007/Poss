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
    /// Member
    /// </summary>
	public class Member : BaseDALSQL<MemberInfo>, IMember
	{
		#region 对象实例及构造函数

		public static Member Instance
		{
			get
			{
				return new Member();
			}
		}
		public Member() : base("db_member","m_id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override MemberInfo DataReaderToEntity(IDataReader dataReader)
		{
			MemberInfo info = new MemberInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.M_id = reader.GetString("m_id");
			info.M_name = reader.GetString("m_name");
			info.M_adress = reader.GetString("m_adress");
			info.M_tel = reader.GetString("m_tel");
			info.M_type = reader.GetString("m_type");
			info.M_sex = reader.GetString("m_sex");
			info.M_national = reader.GetString("m_national");
			info.M_native = reader.GetString("m_native");
			info.M_birthday = reader.GetDateTime("m_birthday");
			info.M_ic = reader.GetString("m_ic");
			info.M_email = reader.GetString("m_email");
			info.Memo = reader.GetString("memo");
			info.M_password = reader.GetString("m_password");
			info.M_help_input = reader.GetString("m_help_input");
			info.M_city = reader.GetString("m_city");
			info.M_province = reader.GetString("m_province");
			info.M_arears = reader.GetString("m_arears");
			info.M_corporation = reader.GetString("m_corporation");
			info.M_zip = reader.GetString("m_zip");
			info.M_degree = reader.GetString("m_degree");
			info.Card_id = reader.GetString("card_id");
			info.Jy_class_id = reader.GetString("jy_class_id");
			info.Station_id = reader.GetString("station_id");
			info.Join_date = reader.GetDateTime("join_date");
			info.End_date = reader.GetDateTime("end_date");
			info.O_id_input = reader.GetString("o_id_input");
			info.Active_flag = reader.GetString("active_flag");
			info.Upgrade_o_id = reader.GetString("upgrade_o_id");
			info.Last_trans_date = reader.GetDateTime("last_trans_date");
			info.Last_mod_date = reader.GetDateTime("last_mod_date");
			info.Notrigger = reader.GetString("notrigger");
			info.M_zw = reader.GetString("m_zw");
			info.M_zy = reader.GetString("m_zy");
			info.M_period = reader.GetString("m_period");
			info.M_income = reader.GetString("m_income");
			info.Jy_flag = reader.GetString("jy_flag");
			info.Focus_flag = reader.GetString("focus_flag");
			info.M_address_song = reader.GetString("m_address_song");
			info.M_station = reader.GetString("m_station");
			info.M_zip_song = reader.GetString("m_zip_song");
			info.M_department_song = reader.GetString("m_department_song");
			info.M_name_accept = reader.GetString("m_name_accept");
			info.M_join_type = reader.GetString("m_join_type");
			info.M_send_letter = reader.GetString("m_send_letter");
			info.M_introduce = reader.GetString("m_introduce");
			info.M_mobile = reader.GetString("m_mobile");
			info.M_mobile_type = reader.GetString("m_mobile_type");
			info.M_ziye = reader.GetString("m_ziye");
			info.M_account = reader.GetString("M_account");
			info.M_question = reader.GetString("M_question");
			info.M_answer = reader.GetString("M_answer");
			info.M_homeland = reader.GetString("M_homeland");
			info.M_school = reader.GetString("M_school");
			info.M_hometel = reader.GetString("M_hometel");
			info.M_worktel = reader.GetString("M_worktel");
			info.M_homepage = reader.GetString("M_homepage");
			info.M_homeaddress = reader.GetString("M_homeaddress");
			info.M_homezipcode = reader.GetString("M_homezipcode");
			info.M_workaddress = reader.GetString("M_workaddress");
			info.M_workzipcode = reader.GetString("M_workzipcode");
			info.M_send_comu = reader.GetString("M_send_comu");
			info.M_fax = reader.GetString("M_fax");
			info.Defer_times = reader.GetInt32("defer_times");
			info.Ls_flag = reader.GetString("ls_flag");
			info.Yg_flag = reader.GetString("yg_flag");
			info.Is_calltemp = reader.GetString("is_calltemp");
			info.Sum_date = reader.GetDateTime("sum_date");
			info.Station_id_yg = reader.GetString("station_id_yg");
			info.O_id_charge = reader.GetString("o_id_charge");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(MemberInfo obj)
		{
		    MemberInfo info = obj as MemberInfo;
			Hashtable hash = new Hashtable(); 
			
			hash.Add("m_id", info.M_id);
 			hash.Add("m_name", info.M_name);
 			hash.Add("m_adress", info.M_adress);
 			hash.Add("m_tel", info.M_tel);
 			hash.Add("m_type", info.M_type);
 			hash.Add("m_sex", info.M_sex);
 			hash.Add("m_national", info.M_national);
 			hash.Add("m_native", info.M_native);
 			hash.Add("m_birthday", info.M_birthday);
 			hash.Add("m_ic", info.M_ic);
 			hash.Add("m_email", info.M_email);
 			hash.Add("memo", info.Memo);
 			hash.Add("m_password", info.M_password);
 			hash.Add("m_help_input", info.M_help_input);
 			hash.Add("m_city", info.M_city);
 			hash.Add("m_province", info.M_province);
 			hash.Add("m_arears", info.M_arears);
 			hash.Add("m_corporation", info.M_corporation);
 			hash.Add("m_zip", info.M_zip);
 			hash.Add("m_degree", info.M_degree);
 			hash.Add("card_id", info.Card_id);
 			hash.Add("jy_class_id", info.Jy_class_id);
 			hash.Add("station_id", info.Station_id);
 			hash.Add("join_date", info.Join_date);
 			hash.Add("end_date", info.End_date);
 			hash.Add("o_id_input", info.O_id_input);
 			hash.Add("active_flag", info.Active_flag);
 			hash.Add("upgrade_o_id", info.Upgrade_o_id);
 			hash.Add("last_trans_date", info.Last_trans_date);
 			hash.Add("last_mod_date", info.Last_mod_date);
 			hash.Add("notrigger", info.Notrigger);
 			hash.Add("m_zw", info.M_zw);
 			hash.Add("m_zy", info.M_zy);
 			hash.Add("m_period", info.M_period);
 			hash.Add("m_income", info.M_income);
 			hash.Add("jy_flag", info.Jy_flag);
 			hash.Add("focus_flag", info.Focus_flag);
 			hash.Add("m_address_song", info.M_address_song);
 			hash.Add("m_station", info.M_station);
 			hash.Add("m_zip_song", info.M_zip_song);
 			hash.Add("m_department_song", info.M_department_song);
 			hash.Add("m_name_accept", info.M_name_accept);
 			hash.Add("m_join_type", info.M_join_type);
 			hash.Add("m_send_letter", info.M_send_letter);
 			hash.Add("m_introduce", info.M_introduce);
 			hash.Add("m_mobile", info.M_mobile);
 			hash.Add("m_mobile_type", info.M_mobile_type);
 			hash.Add("m_ziye", info.M_ziye);
 			hash.Add("M_account", info.M_account);
 			hash.Add("M_question", info.M_question);
 			hash.Add("M_answer", info.M_answer);
 			hash.Add("M_homeland", info.M_homeland);
 			hash.Add("M_school", info.M_school);
 			hash.Add("M_hometel", info.M_hometel);
 			hash.Add("M_worktel", info.M_worktel);
 			hash.Add("M_homepage", info.M_homepage);
 			hash.Add("M_homeaddress", info.M_homeaddress);
 			hash.Add("M_homezipcode", info.M_homezipcode);
 			hash.Add("M_workaddress", info.M_workaddress);
 			hash.Add("M_workzipcode", info.M_workzipcode);
 			hash.Add("M_send_comu", info.M_send_comu);
 			hash.Add("M_fax", info.M_fax);
 			hash.Add("defer_times", info.Defer_times);
 			hash.Add("ls_flag", info.Ls_flag);
 			hash.Add("yg_flag", info.Yg_flag);
 			hash.Add("is_calltemp", info.Is_calltemp);
 			hash.Add("sum_date", info.Sum_date);
 			hash.Add("station_id_yg", info.Station_id_yg);
 			hash.Add("o_id_charge", info.O_id_charge);
 				
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
            dict.Add("M_id", "");
             dict.Add("M_name", "");
             dict.Add("M_adress", "");
             dict.Add("M_tel", "");
             dict.Add("M_type", "");
             dict.Add("M_sex", "");
             dict.Add("M_national", "");
             dict.Add("M_native", "");
             dict.Add("M_birthday", "");
             dict.Add("M_ic", "");
             dict.Add("M_email", "");
             dict.Add("Memo", "");
             dict.Add("M_password", "");
             dict.Add("M_help_input", "");
             dict.Add("M_city", "");
             dict.Add("M_province", "");
             dict.Add("M_arears", "");
             dict.Add("M_corporation", "");
             dict.Add("M_zip", "");
             dict.Add("M_degree", "");
             dict.Add("Card_id", "");
             dict.Add("Jy_class_id", "");
             dict.Add("Station_id", "");
             dict.Add("Join_date", "");
             dict.Add("End_date", "");
             dict.Add("O_id_input", "");
             dict.Add("Active_flag", "");
             dict.Add("Upgrade_o_id", "");
             dict.Add("Last_trans_date", "");
             dict.Add("Last_mod_date", "");
             dict.Add("Notrigger", "");
             dict.Add("M_zw", "");
             dict.Add("M_zy", "");
             dict.Add("M_period", "");
             dict.Add("M_income", "");
             dict.Add("Jy_flag", "");
             dict.Add("Focus_flag", "");
             dict.Add("M_address_song", "");
             dict.Add("M_station", "");
             dict.Add("M_zip_song", "");
             dict.Add("M_department_song", "");
             dict.Add("M_name_accept", "");
             dict.Add("M_join_type", "");
             dict.Add("M_send_letter", "");
             dict.Add("M_introduce", "");
             dict.Add("M_mobile", "");
             dict.Add("M_mobile_type", "");
             dict.Add("M_ziye", "");
             dict.Add("M_account", "");
             dict.Add("M_question", "");
             dict.Add("M_answer", "");
             dict.Add("M_homeland", "");
             dict.Add("M_school", "");
             dict.Add("M_hometel", "");
             dict.Add("M_worktel", "");
             dict.Add("M_homepage", "");
             dict.Add("M_homeaddress", "");
             dict.Add("M_homezipcode", "");
             dict.Add("M_workaddress", "");
             dict.Add("M_workzipcode", "");
             dict.Add("M_send_comu", "");
             dict.Add("M_fax", "");
             dict.Add("Defer_times", "");
             dict.Add("Ls_flag", "");
             dict.Add("Yg_flag", "");
             dict.Add("Is_calltemp", "");
             dict.Add("Sum_date", "");
             dict.Add("Station_id_yg", "");
             dict.Add("O_id_charge", "");
             #endregion

            return dict;
        }

        /// <summary>
        /// 返回会员信息简单实体列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<SimpleMemberInfo> GetMemberInfo(string where)
        {
            List<SimpleMemberInfo> list = new List<SimpleMemberInfo>();
            string cmd = @"
                        SELECT M_id = db_member.m_id,
                            M_name = MAX(db_member.m_name),
                            M_department_song=MAX(dbo.db_member.m_department_song),
                            M_tel = MAX(db_member.m_tel),
                            M_type = MAX(db_member.m_type),
                            Card_id = MAX(db_member.card_id),
                            M_adress = MAX(db_member.m_adress),
                            End_date = MAX(dbo.db_member.end_date),
                            Integral = dbo.uf_GetMemberIntegral(dbo.db_member.m_id),
                            Station_id = MAX(dbo.db_member.station_id),
                            SurplusMoney = dbo.uf_GetMemberSurplusMoney_money(db_member.card_id)
                        FROM db_member,
                            vv_Member_salesTotal
                        WHERE db_member.m_id = dbo.vv_Member_salesTotal.m_id
                              AND active_flag = '1'
                              AND ls_flag = '1'
                              AND card_id = '{0}'
                              OR m_tel = '%{0}%'
                              OR m_name LIKE '%{0}%'
                              OR m_adress LIKE '%{0}%'
                              OR m_department_song LIKE '%{0}%'
                        GROUP BY db_member.m_id,
                            card_id";
            string sql = string.Format(cmd, where);
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(sql);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderMemberInfo(reader));
            }

            return list;
        }
        private SimpleMemberInfo  ReaderMemberInfo(IDataReader ireader)
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

        /// <summary>
        /// 返回指定站点的最大会员编码
        /// </summary>
        /// <param name="station_Id">站点编码</param>
        /// <returns></returns>
        public int MaxCode(string station_Id)
        {
            string cmd = "SELECT ISNULL(MAX(SUBSTRING(m_id, 7, 10)), 0) + 1 FROM  db_member WHERE station_id = '{0}' AND ISNUMERIC(SUBSTRING(m_id, 7, 10)) = 1  AND m_id LIKE 'MM%' ";
            return ExecuteScalarBySql(string.Format(cmd, station_Id), null).ToString().ToInt32();
        }

    }
}