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
    /// Ls_item
    /// </summary>
	public class Ls_item : BaseDALSQL<Ls_itemInfo>, ILs_item
	{
		#region 对象实例及构造函数

		public static Ls_item Instance
		{
			get
			{
				return new Ls_item();
			}
		}
		public Ls_item() : base("db_ls_item","ls_id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override Ls_itemInfo DataReaderToEntity(IDataReader dataReader)
		{
			Ls_itemInfo info = new Ls_itemInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.Ls_id = reader.GetString("ls_id");
			info.H_id = reader.GetString("h_id");
			info.H_price = reader.GetDecimal("h_price");
			info.H_amount = reader.GetInt32("h_amount");
			info.H_discount = reader.GetDecimal("h_discount");
			info.S_id = reader.GetString("s_id");
			info.Sort_number = reader.GetInt32("sort_number");
			info.Crush_money = reader.GetDecimal("crush_money");
			info.Tax_crush_money = reader.GetDecimal("tax_crush_money");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(Ls_itemInfo obj)
		{
		    Ls_itemInfo info = obj as Ls_itemInfo;
			Hashtable hash = new Hashtable(); 
			
			hash.Add("ls_id", info.Ls_id);
 			hash.Add("h_id", info.H_id);
 			hash.Add("h_price", info.H_price);
 			hash.Add("h_amount", info.H_amount);
 			hash.Add("h_discount", info.H_discount);
 			hash.Add("s_id", info.S_id);
 			hash.Add("sort_number", info.Sort_number);
 			hash.Add("crush_money", info.Crush_money);
 			hash.Add("tax_crush_money", info.Tax_crush_money);
 				
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
            dict.Add("Ls_id", "");
             dict.Add("H_id", "");
             dict.Add("H_price", "");
             dict.Add("H_amount", "");
             dict.Add("H_discount", "");
             dict.Add("S_id", "");
             dict.Add("Sort_number", "");
             dict.Add("Crush_money", "");
             dict.Add("Tax_crush_money", "");
             #endregion

            return dict;
        }

    }
}