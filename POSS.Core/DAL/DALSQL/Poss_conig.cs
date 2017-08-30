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
    /// Poss_conig
    /// </summary>
	public class Poss_conig : BaseDALSQL<Poss_conigInfo>, IPoss_conig
	{
		#region 对象实例及构造函数

		public static Poss_conig Instance
		{
			get
			{
				return new Poss_conig();
			}
		}
		public Poss_conig() : base("Poss_conig","id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override Poss_conigInfo DataReaderToEntity(IDataReader dataReader)
		{
			Poss_conigInfo info = new Poss_conigInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.Id = reader.GetString("id");
			info.Is_jifen = reader.GetString("is_jifen");
			info.Is_ysdh = reader.GetString("is_ysdh");
			info.Taosu = reader.GetString("taosu");
			info.Wx_appid = reader.GetString("wx_appid");
			info.Wx_mchid = reader.GetString("wx_mchid");
			info.Wx_kdy = reader.GetString("wx_kdy");
			info.Wx_appsecret = reader.GetString("wx_appsecret");
			info.Wx_miaosu = reader.GetString("wx_miaosu");
			info.Zfb_appid = reader.GetString("zfb_appid");
			info.Zfb_mchid = reader.GetString("zfb_mchid");
			info.Zfb_kdy = reader.GetString("zfb_kdy");
			info.Zfb_appsecret = reader.GetString("zfb_appsecret");
			info.Zfc_miaosu = reader.GetString("zfc_miaosu");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(Poss_conigInfo obj)
		{
		    Poss_conigInfo info = obj as Poss_conigInfo;
			Hashtable hash = new Hashtable(); 
			
			hash.Add("id", info.Id);
 			hash.Add("is_jifen", info.Is_jifen);
 			hash.Add("is_ysdh", info.Is_ysdh);
 			hash.Add("taosu", info.Taosu);
 			hash.Add("wx_appid", info.Wx_appid);
 			hash.Add("wx_mchid", info.Wx_mchid);
 			hash.Add("wx_kdy", info.Wx_kdy);
 			hash.Add("wx_appsecret", info.Wx_appsecret);
 			hash.Add("wx_miaosu", info.Wx_miaosu);
 			hash.Add("zfb_appid", info.Zfb_appid);
 			hash.Add("zfb_mchid", info.Zfb_mchid);
 			hash.Add("zfb_kdy", info.Zfb_kdy);
 			hash.Add("zfb_appsecret", info.Zfb_appsecret);
 			hash.Add("zfc_miaosu", info.Zfc_miaosu);
 				
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
            dict.Add("Id", "");
             dict.Add("Is_jifen", "");
             dict.Add("Is_ysdh", "");
             dict.Add("Taosu", "");
             dict.Add("Wx_appid", "");
             dict.Add("Wx_mchid", "");
             dict.Add("Wx_kdy", "");
             dict.Add("Wx_appsecret", "");
             dict.Add("Wx_miaosu", "");
             dict.Add("Zfb_appid", "");
             dict.Add("Zfb_mchid", "");
             dict.Add("Zfb_kdy", "");
             dict.Add("Zfb_appsecret", "");
             dict.Add("Zfc_miaosu", "");
             #endregion

            return dict;
        }

        /// <summary>
        /// 插入或更新 
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public bool insetOrUpdate(Poss_conigInfo con)
        {
            bool result = false;
            using(DbTransaction trans = CreateTransaction())
            {
                try
                {
                    if (con != null)
                    {
                        InsertUpdate(con, con.Id,trans);
                        trans.Commit();
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    result = false;
                    LogTextHelper.Error(ex.Message+"保存失败！");
                }
            }
            
            return result;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public List<Poss_conigInfo> GetPossConfig()
        {
            List<Poss_conigInfo> list = new List<Poss_conigInfo>();
            string cmd = @"SELECT 
	                        id=id,
                            is_jifen=is_jifen,
                            is_ysdh=is_ysdh,
                            taosu=taosu,
                            wx_appid=wx_appid,
                            wx_mchid=wx_mchid,
                            wx_kdy=wx_kdy,
                            wx_appsecret=wx_appsecret,
                            wx_miaosu=wx_miaosu,
                            zfb_appid=zfb_appid,
                            zfb_mchid=zfb_mchid,
                            zfb_kdy=zfb_kdy,
                            zfb_appsecret=zfb_appsecret,
                            zfc_miaosu=zfc_miaosu
                        FROM dbo.Poss_conig WHERE id='1'";
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(cmd);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderPossConfig(reader));
            }
            return list;
        }
        private Poss_conigInfo ReaderPossConfig(IDataReader ireader)
        {
            Poss_conigInfo info = new Poss_conigInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.Id = reader.GetString("Id");
            info.Is_jifen = reader.GetString("Is_jifen");
            info.Is_ysdh = reader.GetString("Is_ysdh");
            info.Taosu = reader.GetString("Taosu");
            info.Wx_appid = reader.GetString("Wx_appid");
            info.Wx_appsecret = reader.GetString("Wx_appsecret");
            info.Wx_kdy = reader.GetString("Wx_kdy");
            info.Wx_mchid = reader.GetString("Wx_mchid");
            info.Wx_miaosu = reader.GetString("Wx_miaosu");
            //支付宝的
            //info.Zfb_appid = reader.GetString("Zfb_appid");
            //info.Zfb_appsecret = reader.GetString("Zfb_appsecret");
            //info.Zfb_kdy = reader.GetString("Zfb_kdy");
            //info.Zfb_mchid = reader.GetString("Zfb_mchid");
            //info.Zfc_miaosu = reader.GetString("Zfc_miaosu");
           
            return info;
        }

    }
}