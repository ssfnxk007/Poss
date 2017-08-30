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
    /// Ls
    /// </summary>
	public class Ls : BaseDALSQL<LsInfo>, ILs
	{
		#region 对象实例及构造函数

		public static Ls Instance
		{
			get
			{
				return new Ls();
			}
		}
		public Ls() : base("db_ls","ls_id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override LsInfo DataReaderToEntity(IDataReader dataReader)
		{
			LsInfo info = new LsInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.Ph_id = reader.GetString("ph_id");
			info.Ls_id = reader.GetString("ls_id");
			info.Total_count = reader.GetInt32("total_count");
			info.Total_money = reader.GetDecimal("total_money");
			info.Real_money = reader.GetDecimal("real_money");
			info.M_id = reader.GetString("m_id");
			info.Ls_datetime = reader.GetDateTime("ls_datetime");
			info.Charge = reader.GetDecimal("charge");
			info.Stand_id = reader.GetString("stand_id");
			info.O_id = reader.GetString("o_id");
			info.Already_money = reader.GetDecimal("already_money");
			info.Sum_flag = reader.GetString("sum_flag");
			info.Is_stock = reader.GetString("is_stock");
			info.Is_sum = reader.GetString("is_sum");
			info.Station_id = reader.GetString("station_id");
			info.Change = reader.GetDecimal("change");
			info.Sum_id = reader.GetString("sum_id");
			info.Tax_id = reader.GetString("tax_id");
			info.Last_mod_date = reader.GetDateTime("last_mod_date");
			info.Last_trans_date = reader.GetDateTime("last_trans_date");
			info.Notrigger = reader.GetString("notrigger");
			info.Ls_flag = reader.GetString("ls_flag");
			info.Total_amount = reader.GetInt32("total_amount");
			info.Ls_back_id = reader.GetString("ls_back_id");
			info.Salesother_id = reader.GetString("salesother_id");
			info.Desk_id = reader.GetString("desk_id");
			info.Waiter_id = reader.GetString("waiter_id");
			info.Memo = reader.GetString("memo");
			info.Total_money_avoid = reader.GetDecimal("total_money_avoid");
			info.Real_money_avoid = reader.GetDecimal("real_money_avoid");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(LsInfo obj)
		{
		    LsInfo info = obj as LsInfo;
			Hashtable hash = new Hashtable(); 
			
			hash.Add("ph_id", info.Ph_id);
 			hash.Add("ls_id", info.Ls_id);
 			hash.Add("total_count", info.Total_count);
 			hash.Add("total_money", info.Total_money);
 			hash.Add("real_money", info.Real_money);
 			hash.Add("m_id", info.M_id);
 			hash.Add("ls_datetime", info.Ls_datetime);
 			hash.Add("charge", info.Charge);
 			hash.Add("stand_id", info.Stand_id);
 			hash.Add("o_id", info.O_id);
 			hash.Add("already_money", info.Already_money);
 			hash.Add("sum_flag", info.Sum_flag);
 			hash.Add("is_stock", info.Is_stock);
 			hash.Add("is_sum", info.Is_sum);
 			hash.Add("station_id", info.Station_id);
 			hash.Add("change", info.Change);
 			hash.Add("sum_id", info.Sum_id);
 			hash.Add("tax_id", info.Tax_id);
 			hash.Add("last_mod_date", info.Last_mod_date);
 			hash.Add("last_trans_date", info.Last_trans_date);
 			hash.Add("notrigger", info.Notrigger);
 			hash.Add("ls_flag", info.Ls_flag);
 			hash.Add("total_amount", info.Total_amount);
 			hash.Add("ls_back_id", info.Ls_back_id);
 			hash.Add("salesother_id", info.Salesother_id);
 			hash.Add("desk_id", info.Desk_id);
 			hash.Add("waiter_id", info.Waiter_id);
 			hash.Add("memo", info.Memo);
 			hash.Add("total_money_avoid", info.Total_money_avoid);
 			hash.Add("real_money_avoid", info.Real_money_avoid);
 				
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
            dict.Add("Ph_id", "");
             dict.Add("Ls_id", "");
             dict.Add("Total_count", "");
             dict.Add("Total_money", "");
             dict.Add("Real_money", "");
             dict.Add("M_id", "");
             dict.Add("Ls_datetime", "");
             dict.Add("Charge", "");
             dict.Add("Stand_id", "");
             dict.Add("O_id", "");
             dict.Add("Already_money", "");
             dict.Add("Sum_flag", "");
             dict.Add("Is_stock", "");
             dict.Add("Is_sum", "");
             dict.Add("Station_id", "");
             dict.Add("Change", "");
             dict.Add("Sum_id", "");
             dict.Add("Tax_id", "");
             dict.Add("Last_mod_date", "");
             dict.Add("Last_trans_date", "");
             dict.Add("Notrigger", "");
             dict.Add("Ls_flag", "");
             dict.Add("Total_amount", "");
             dict.Add("Ls_back_id", "");
             dict.Add("Salesother_id", "");
             dict.Add("Desk_id", "");
             dict.Add("Waiter_id", "");
             dict.Add("Memo", "");
             dict.Add("Total_money_avoid", "");
             dict.Add("Real_money_avoid", "");
             #endregion

            return dict;
        }

    }
}