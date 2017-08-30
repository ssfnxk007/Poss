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
    /// Users
    /// </summary>
	public class Users : BaseDALSQL<UsersInfo>, IUsers
    {
        #region 对象实例及构造函数

        public static Users Instance
        {
            get
            {
                return new Users();
            }
        }
        public Users() : base("Users", "o_id")
        {
        }

        #endregion

        /// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dr">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        protected override UsersInfo DataReaderToEntity(IDataReader dataReader)
        {
            UsersInfo info = new UsersInfo();
            SmartDataReader reader = new SmartDataReader(dataReader);

            info.O_id = reader.GetString("o_id");
            info.O_name = reader.GetString("o_name");
            info.Station_id = reader.GetString("station_id");
            info.Stock_id = reader.GetString("stock_id");
            info.Passwd = reader.GetString("passwd");
            info.Yh_stand_id = reader.GetString("yh_stand_id");
            info.Is_word = reader.GetString("is_word");

            return info;
        }

        /// <summary>
        /// 将实体对象的属性值转化为Hashtable对应的键值
        /// </summary>
        /// <param name="obj">有效的实体对象</param>
        /// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(UsersInfo obj)
        {
            UsersInfo info = obj as UsersInfo;
            Hashtable hash = new Hashtable();

            hash.Add("o_id", info.O_id);
            hash.Add("o_name", info.O_name);
            hash.Add("station_id", info.Station_id);
            hash.Add("stock_id", info.Stock_id);
            hash.Add("passwd", info.Passwd);
            hash.Add("yh_stand_id", info.Yh_stand_id);
            hash.Add("is_word", info.Is_word);

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
            dict.Add("O_id", "");
            dict.Add("O_name", "");
            dict.Add("Station_id", "");
            dict.Add("Stock_id", "");
            dict.Add("Passwd", "");
            dict.Add("Yh_stand_id", "");
            dict.Add("Is_word", "");
            #endregion

            return dict;
        }


        #region 获取用户信息
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <returns></returns>
        public List<Query_OperatorsInfo> GetO_id()
        {
            List<Query_OperatorsInfo> list = new List<Query_OperatorsInfo>();
            string cmd = string.Empty;
            cmd = @"SELECT  O_id = o_id ,
                                    O_name = o_name
                            FROM    db_operators
                            WHERE   o_exist = '1'";
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(cmd);

            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderQuery_OperatorIdByName(reader));
            }
            return list;
        }
        private Query_OperatorsInfo ReaderQuery_OperatorIdByName(IDataReader ireader)
        {
            Query_OperatorsInfo info = new Query_OperatorsInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.O_id = reader.GetString("O_id");
            info.O_name = reader.GetString("O_name");
            return info;
        }
        #endregion

        #region 获取站点信息
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <returns></returns>
        public List<Query_Station_totalInfo> GetSatation_idByName()
        {
            List<Query_Station_totalInfo> list = new List<Query_Station_totalInfo>();
            string cmd = @"SELECT  Station_id=station_id ,
                            Station_name=station_name
                    FROM    dbo.db_station_total
                    WHERE   is_exists = '1'";
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(cmd);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderQuery_StationIdByName(reader));
            }
            return list;
        }
        private Query_Station_totalInfo ReaderQuery_StationIdByName(IDataReader ireader)
        {
            Query_Station_totalInfo info = new Query_Station_totalInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.Station_id = reader.GetString("Station_id");
            info.Station_name = reader.GetString("Station_name");
            return info;

        }
        #endregion

        #region 获取库房信息
        /// <summary>
        /// 获取库房信息
        /// </summary>
        /// <returns></returns>
        public List<Query_stocksInfo> GetStocks_idByName()
        {
            List<Query_stocksInfo> list = new List<Query_stocksInfo>();
            string cmd = @"SELECT  S_id=s_id ,
                                S_name=s_name
                        FROM    dbo.db_stocks
                        WHERE   s_limit = '1'";
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(cmd);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderQuery_StockIdByName(reader));
            }
            return list;
        }
        private Query_stocksInfo ReaderQuery_StockIdByName(IDataReader ireader)
        {
            Query_stocksInfo info = new Query_stocksInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.S_id = reader.GetString("S_id");
            info.S_name = reader.GetString("S_name");
            return info;
        }
        #endregion

        #region 获取零售台号
        /// <summary>
        /// 获取零售台号
        /// </summary>
        /// <returns></returns>
        public List<Query_StandInfo> GetStand_idByName()
        {
            List<Query_StandInfo> list = new List<Query_StandInfo>();
            string cmd = @"SELECT  Stand_id=stand_id ,
                                    Stand_name=stand_name
        
                            FROM    db_stand";
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(cmd);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderQuery_StandIdByName(reader));
            }
            return list;
        }
        private Query_StandInfo ReaderQuery_StandIdByName(IDataReader ireader)
        {
            Query_StandInfo info = new Query_StandInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.Stand_id = reader.GetString("Stand_id");
            info.Stand_name = reader.GetString("Stand_name");
            return info;
        }
        #endregion

        #region 保存或更新用户表
        /// <summary>
        /// 保存或更新用户表
        /// </summary>
        /// <param name="usinfo"></param>
        /// <returns></returns>
        public bool SaveUser(UsersInfo usinfo)
        {

            using (DbTransaction trans = CreateTransaction())
            {
                try
                {
                    InsertUpdate(usinfo, "o_id", trans);
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    LogTextHelper.WriteLine(ex.Message);
                    trans.Rollback();
                    return false;
                }
            }
        } 
        #endregion

        #region 用户信息
        /// <summary>
        /// 用户信息
        /// </summary>
        /// <returns></returns>
        public List<UsersInfo> GetUsers_idByName()
        {
            List<UsersInfo> list = new List<UsersInfo>();
            string cmd = @"SELECT o_id,o_name FROM Users WHERE is_word='1'";
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(cmd);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderUsers_IdByName(reader));
            }
            return list;
        }
        private UsersInfo ReaderUsers_IdByName(IDataReader ireader)
        {
            UsersInfo info = new UsersInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.O_id = reader.GetString("O_id");
            info.O_name = reader.GetString("O_name");
            return info;
        }
        #endregion

        /// <summary>
        /// 验证用户密码
        /// </summary>
        /// <returns></returns>
        public List<UsersInfo> Validation_Users(string o_id)
        {
            List<UsersInfo> list = new List<UsersInfo>();
            string cmd = @"SELECT o_id,passwd FROM Users WHERE is_word='1' AND o_id='{0}'";
            string sql = string.Empty;
            sql = string.Format(cmd, o_id);
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(sql);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderUsers(reader));
            }
            return list;
        }
        private UsersInfo ReaderUsers(IDataReader ireader)
        {
            UsersInfo info = new UsersInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.O_id = reader.GetString("O_id");
            info.Passwd = reader.GetString("Passwd");
            return info;
        }

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <param name="o_id"></param>
        /// <returns></returns>
        public List<UsersInfo> GetDengLuInfo(string o_id)
        {
            List<UsersInfo> list = new List<UsersInfo>();
            string cmd = @"SELECT * FROM Users WHERE is_word='1' AND o_id='{0}'";
            string sql = string.Format(cmd, o_id);
            Database db = CreateDatabase();
            DbCommand command = db.GetSqlStringCommand(sql);
            IDataReader reader = db.ExecuteReader(command);
            while (reader.Read())
            {
                list.Add(ReaderDenLuUsers(reader));
            }
            return list;
        }
        private UsersInfo ReaderDenLuUsers(IDataReader ireader)
        {
            UsersInfo info = new UsersInfo();
            SmartDataReader reader = new SmartDataReader(ireader);
            info.O_id = reader.GetString("O_id");
            info.O_name = reader.GetString("O_name");
            info.Station_id = reader.GetString("Station_id");
            info.Stock_id = reader.GetString("Stock_id");
            info.Yh_stand_id = reader.GetString("Yh_stand_id");
            info.Is_word = reader.GetString("Is_word");
            return info;
        }
    }
}