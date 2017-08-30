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
    /// Ph
    /// </summary>
	public class Ph : BaseDALSQL<PhInfo>, IPh
	{
		#region 对象实例及构造函数

		public static Ph Instance
		{
			get
			{
				return new Ph();
			}
		}
		public Ph() : base("db_ph","ph_id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override PhInfo DataReaderToEntity(IDataReader dataReader)
		{
			PhInfo info = new PhInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.Ph_id = reader.GetString("ph_id");
			info.O_id = reader.GetString("o_id");
			info.Receive = reader.GetDecimal("receive");
			info.On_time = reader.GetDateTime("on_time");
			info.Off_time = reader.GetDateTime("off_time");
			info.Total_money = reader.GetDecimal("total_money");
			info.Real_money = reader.GetDecimal("real_money");
			info.Stand_id = reader.GetString("stand_id");
			info.Station_id = reader.GetString("station_id");
			info.Pay = reader.GetDecimal("pay");
			info.Charge = reader.GetDecimal("charge");
			info.Other_charge = reader.GetDecimal("other_charge");
			info.Is_commit = reader.GetString("is_commit");
			info.Total_count = reader.GetInt32("total_count");
			info.Input_date = reader.GetDateTime("input_date");
			info.Commit_date = reader.GetDateTime("commit_date");
			info.Other_chareg_mem = reader.GetString("other_chareg_mem");
			info.Last_mod_date = reader.GetDateTime("last_mod_date");
			info.Last_trans_date = reader.GetDateTime("last_trans_date");
			info.Notrigger = reader.GetString("notrigger");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(PhInfo obj)
		{
		    PhInfo info = obj as PhInfo;
			Hashtable hash = new Hashtable(); 
			
			hash.Add("ph_id", info.Ph_id);
 			hash.Add("o_id", info.O_id);
 			hash.Add("receive", info.Receive);
 			hash.Add("on_time", info.On_time);
 			hash.Add("off_time", info.Off_time);
 			hash.Add("total_money", info.Total_money);
 			hash.Add("real_money", info.Real_money);
 			hash.Add("stand_id", info.Stand_id);
 			hash.Add("station_id", info.Station_id);
 			hash.Add("pay", info.Pay);
 			hash.Add("charge", info.Charge);
 			hash.Add("other_charge", info.Other_charge);
 			hash.Add("is_commit", info.Is_commit);
 			hash.Add("total_count", info.Total_count);
 			hash.Add("input_date", info.Input_date);
 			hash.Add("commit_date", info.Commit_date);
 			hash.Add("other_chareg_mem", info.Other_chareg_mem);
 			hash.Add("last_mod_date", info.Last_mod_date);
 			hash.Add("last_trans_date", info.Last_trans_date);
 			hash.Add("notrigger", info.Notrigger);
 				
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
             dict.Add("O_id", "");
             dict.Add("Receive", "");
             dict.Add("On_time", "");
             dict.Add("Off_time", "");
             dict.Add("Total_money", "");
             dict.Add("Real_money", "");
             dict.Add("Stand_id", "");
             dict.Add("Station_id", "");
             dict.Add("Pay", "");
             dict.Add("Charge", "");
             dict.Add("Other_charge", "");
             dict.Add("Is_commit", "");
             dict.Add("Total_count", "");
             dict.Add("Input_date", "");
             dict.Add("Commit_date", "");
             dict.Add("Other_chareg_mem", "");
             dict.Add("Last_mod_date", "");
             dict.Add("Last_trans_date", "");
             dict.Add("Notrigger", "");
             #endregion

            return dict;
        }

        /// <summary>
        /// 获取当前用户的当前PH_ID
        /// </summary>
        /// <param name="Opearator_o_id"></param>
        /// <returns></returns>
        public string GetPh_id(string Opearator_o_id)
        {
            string sql = string.Empty;
            string result = string.Empty;
            if (!string.IsNullOrEmpty(Opearator_o_id))
            {
                sql = string.Format(@"SELECT db_ph.ph_id FROM db_ph WHERE ( db_ph.o_id ='{0}' ) AND ( ( db_ph.is_commit ='1' ) or ( db_ph.is_commit ='2' ) ) ", Opearator_o_id);
            }
            string k = ExecuteScalarBySql(sql) as string;
            if (string.IsNullOrEmpty(k))
            {
                result = "";
            }
            else
            {
                result = k;
            }
            return result;
        }

        /// <summary>
        /// 插入PH
        /// </summary>
        /// <param name="station_id"></param>
        /// <param name="stock_id"></param>
        /// <returns></returns>
        public bool Insert_PH(PhInfo ph)
        {
            bool result = false;
            using (DbTransaction trans = CreateTransaction())
            {

                try
                {
                    ph.Ph_id = GetCode(BillsClass.PH, true, ph.Station_id, trans);
                    result = Insert(ph, trans);
                    if (result)
                    {
                        trans.Commit();
                    }

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    LogTextHelper.Info(ex);
                    
                }

                return result;
            }
        }

        /// <summary>
        /// 更新PH时间为当前时间
        /// </summary>
        /// <param name="ph_id"></param>
        /// <returns></returns>
        public bool Update_PH_id(string ph_id)
        {
            bool resutl = false;
            string sql = string.Empty;
            DateTime now = DateTime.Now;
            //string datetime = now.ToString("yyyy-MM-dd HH:mm:ss:ffff");
            if (!string.IsNullOrEmpty(ph_id))
            {
                sql = string.Format(@"update db_ph SET on_time ='{0}' WHERE db_ph.ph_id ='{1}' ", now, ph_id);
            }
            int k = SqlExecute(sql);
            if (k != 0)
            {
                resutl = true;
            }
            return resutl;
        }

        /// <summary>
        /// 更新 PH挂机状态为工作
        /// </summary>
        /// <param name="ph_id"></param>
        /// <returns></returns>
        public bool update_Ph_id_commit(string ph_id)
        {
            bool result = false;
            string sql = string.Empty;
            if (!string.IsNullOrEmpty(ph_id))
            {
                sql = string.Format(@"update db_ph SET is_commit ='2' WHERE db_ph.ph_id ='{0}' ", ph_id);
            }
            int k = SqlExecute(sql);
            if (k != 0)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 更新台号
        /// </summary>
        /// <param name="ph_id"></param>
        /// <param name="stand_id"></param>
        /// <returns></returns>
        public bool update_Ph_stand_id(string ph_id, string stand_id)
        {
            bool result = false;
            string sql = string.Empty;
            if (!string.IsNullOrEmpty(stand_id))
            {
                sql = string.Format(@"update db_ph set db_ph.stand_id ='{0}' where db_ph.ph_id ='{1}' ", stand_id, ph_id);
            }
            int k = SqlExecute(sql);
            if (k != 0)
            {
                result = true;
            }
            return result;
        }

    }
}