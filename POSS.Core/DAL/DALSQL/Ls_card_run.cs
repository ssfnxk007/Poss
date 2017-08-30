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
    /// Ls_card_run
    /// </summary>
	public class Ls_card_run : BaseDALSQL<Ls_card_runInfo>, ILs_card_run
	{
		#region 对象实例及构造函数

		public static Ls_card_run Instance
		{
			get
			{
				return new Ls_card_run();
			}
		}
		public Ls_card_run() : base("db_ls_card_run","run_id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override Ls_card_runInfo DataReaderToEntity(IDataReader dataReader)
		{
			Ls_card_runInfo info = new Ls_card_runInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.Run_id = reader.GetInt32("run_id");
			info.Source_id = reader.GetString("source_id");
			info.Card_id = reader.GetString("card_id");
			info.Money = reader.GetDecimal("money");
			info.Inout_flag = reader.GetString("inout_flag");
			info.Mem = reader.GetString("mem");
			info.O_id_operator = reader.GetString("o_id_operator");
			info.Input_date = reader.GetDateTime("input_date");
			info.Discount = reader.GetDecimal("discount");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(Ls_card_runInfo obj)
		{
		    Ls_card_runInfo info = obj as Ls_card_runInfo;
			Hashtable hash = new Hashtable(); 
			
 			hash.Add("source_id", info.Source_id);
 			hash.Add("card_id", info.Card_id);
 			hash.Add("money", info.Money);
 			hash.Add("inout_flag", info.Inout_flag);
 			hash.Add("mem", info.Mem);
 			hash.Add("o_id_operator", info.O_id_operator);
 			hash.Add("input_date", info.Input_date);
 			hash.Add("discount", info.Discount);
 				
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
             dict.Add("Source_id", "");
             dict.Add("Card_id", "");
             dict.Add("Money", "");
             dict.Add("Inout_flag", "");
             dict.Add("Mem", "");
             dict.Add("O_id_operator", "");
             dict.Add("Input_date", "");
             dict.Add("Discount", "");
             #endregion

            return dict;
        }

    }
}