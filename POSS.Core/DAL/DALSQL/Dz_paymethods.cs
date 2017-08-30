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
    /// Dz_paymethods
    /// </summary>
	public class Dz_paymethods : BaseDALSQL<Dz_paymethodsInfo>, IDz_paymethods
    {
        #region 对象实例及构造函数

        public static Dz_paymethods Instance
        {
            get
            {
                return new Dz_paymethods();
            }
        }
        public Dz_paymethods() : base("dz_paymethods", "p_id")
        {
        }

        #endregion

        /// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dr">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        protected override Dz_paymethodsInfo DataReaderToEntity(IDataReader dataReader)
        {
            Dz_paymethodsInfo info = new Dz_paymethodsInfo();
            SmartDataReader reader = new SmartDataReader(dataReader);

            info.P_id = reader.GetString("p_id");
            info.P_name = reader.GetString("p_name");
            info.P_mem = reader.GetString("p_mem");
            info.Last_mod_date = reader.GetDateTime("last_mod_date");
            info.Last_trans_date = reader.GetDateTime("last_trans_date");
            info.Notrigger = reader.GetString("notrigger");
            info.Exchange_rate = reader.GetDecimal("exchange_rate");
            info.Is_sum = reader.GetString("is_sum");

            return info;
        }

        /// <summary>
        /// 将实体对象的属性值转化为Hashtable对应的键值
        /// </summary>
        /// <param name="obj">有效的实体对象</param>
        /// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(Dz_paymethodsInfo obj)
        {
            Dz_paymethodsInfo info = obj as Dz_paymethodsInfo;
            Hashtable hash = new Hashtable();

            hash.Add("p_id", info.P_id);
            hash.Add("p_name", info.P_name);
            hash.Add("p_mem", info.P_mem);
            hash.Add("last_mod_date", info.Last_mod_date);
            hash.Add("last_trans_date", info.Last_trans_date);
            hash.Add("notrigger", info.Notrigger);
            hash.Add("exchange_rate", info.Exchange_rate);
            hash.Add("is_sum", info.Is_sum);

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
            dict.Add("P_id", "");
            dict.Add("P_name", "");
            dict.Add("P_mem", "");
            dict.Add("Last_mod_date", "");
            dict.Add("Last_trans_date", "");
            dict.Add("Notrigger", "");
            dict.Add("Exchange_rate", "");
            dict.Add("Is_sum", "");
            #endregion

            return dict;
        }


        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public DataTable GetPossConfig()
        {
            QueryPaymethods info = new QueryPaymethods();
            string cmd = @"SELECT
	                        P_id=p_id ,
                            P_name=p_name ,
                            Exchange_rate=exchange_rate 
                        FROM dbo.dz_paymethods";
           
            DataTable dt=  SqlTable(cmd);
            dt.TableName = "dz_paymethods";
            
            return dt;

        }
        private Dz_paymethodsInfo ReaderPayMethods(IDataReader ireader)
        {
            Dz_paymethodsInfo info = new Dz_paymethodsInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.Exchange_rate = reader.GetDecimal("Exchange_rate");
            //info.Is_sum = reader.GetString("Is_sum");
            //info.Last_mod_date = reader.GetDateTime("Last_mod_date");
            //info.Last_trans_date = reader.GetDateTime("Last_trans_date");
            //info.Notrigger = reader.GetString("Notrigger");
            info.P_id = reader.GetString("P_id");
            info.P_mem = reader.GetString("P_mem");
            //info.P_name = reader.GetString("P_name");
            return info;
        }

        /// <summary>
        /// 用于获取 收款方式列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetPaymathodsCombox()
        {
            DataTable dt = new DataTable();
            string cmd = @"SELECT p_id AS [项目值],p_name AS [显示值] FROM dbo.dz_paymethods WHERE dz_paymethods.p_id <> '!!!!'  AND    ( dz_paymethods.p_id <> '****' ) AND  ( dz_paymethods.p_id <> '$$$$' )   ";
            return SqlTable(cmd);
        }




    }
}