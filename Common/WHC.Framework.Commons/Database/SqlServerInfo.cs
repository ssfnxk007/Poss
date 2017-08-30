using System;
using System.Text;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// SQLServer数据库字符串解析操作辅助类
    /// </summary>
    public class SqlServerInfo
    {
        #region 构造方法
        /// <summary>
        /// 构造函数
        /// </summary>
        public SqlServerInfo()
        {
        }

        /// <summary>
        /// 可以接受三种格式的数据库连接字符串
        /// 1. 服务名称=(local);数据库名称=EDNSM;用户名称=sa;用户密码=123456;连接超时=30
        /// 2. Data Source=(local);Initial Catalog=EDNSM;User ID=sa;Password=123456;ConnectionTimeout=30;
        /// 3. server=(local);uid=sa;pwd=;ConnectionTimeout=30;
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        public SqlServerInfo(string connectionString)
        {
            #region 服务器名

            this.server = this.GetSubItemValue(connectionString, "服务名称");
            if (this.server == null)
            {
                this.server = this.GetSubItemValue(connectionString, "Data Source");
            }
            if (this.server == null)
            {
                this.server = this.GetSubItemValue(connectionString, "server");
            }
            if (this.server.Contains(","))
            {
                try
                {
                    this.port = GetSubItemValue(this.server, false).ToInt32();
                }
                catch (Exception)
                {
                    this.port = 1433;
                }
                this.server = GetSubItemValue(this.server, true);
            }

            #endregion



            #region 数据库名

            this.database = this.GetSubItemValue(connectionString, "数据库名称");
            if (this.database == null)
            {
                this.database = this.GetSubItemValue(connectionString, "Initial Catalog");
            }
            if (this.database == null)
            {
                this.database = this.GetSubItemValue(connectionString, "database");
            }

            #endregion

            #region 用户名称

            this.userID = this.GetSubItemValue(connectionString, "用户名称");
            if (this.userID == null)
            {
                this.userID = this.GetSubItemValue(connectionString, "User ID");
            }
            if (this.userID == null)
            {
                this.userID = this.GetSubItemValue(connectionString, "uid");
            }

            #endregion

            #region 用户密码

            this.password = this.GetSubItemValue(connectionString, "用户密码");
            if (this.password == null)
            {
                this.password = this.GetSubItemValue(connectionString, "Password");
            }
            if (this.password == null)
            {
                this.password = this.GetSubItemValue(connectionString, "pwd");
            }
            if (this.encryptPass)
            {
                this.password = WHC.Framework.Commons.EncodeHelper.Base64Decrypt(this.password);
            }

            #endregion

            #region 连接超时

            object timeout = this.GetSubItemValue(connectionString, "连接超时");
            if (timeout == null)
            {
                timeout = this.GetSubItemValue(connectionString, "Connect Timeout");
            }
            if (timeout == null)
            {
                timeout = this.GetSubItemValue(connectionString, "Connection Timeout");
            }
            if (timeout == null)
            {
                this.timeout = 30;
            }
            else
            {
                this.timeout = timeout.ToString().ToInt32();
            }
            #endregion
        }
        
        #endregion

        #region 变量及属性

        /// <summary>
        /// 数据库服务器
        /// </summary>
        public string Server
        {
            get { return server; }
            set { this.server = value; }
        }

        /// <summary>
        /// 数据库端口号
        /// </summary>
        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        /// <summary>
        /// 数据库
        /// </summary>
        public string Database
        {
            get { return database; }
            set { this.database = value; }
        }

        /// <summary>
        /// 访问用户名
        /// </summary>
        public string UserId
        {
            get { return userID; }
            set { this.userID = value; }
        }

        /// <summary>
        /// 访问密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        /// <summary>
        /// 连接超时
        /// </summary>
        public int Timeout
        {
            get { return timeout; }
            set { timeout = value; }
        }

        /// <summary>
        /// 是否对数据库密码进行加密
        /// </summary>
        public bool EncryptPass
        {
            get { return encryptPass; }
            set { encryptPass = value; }
        }

        private string server;
        private string database;
        private string userID;
        private string password;
        private int timeout = 30;
        private int port = 1433;
        private bool encryptPass = false;

        
        


        #endregion

        #region 连接字符串
        /// <summary>
        /// 加密后的连接字符串
        /// </summary>
        public string EncryptConnectionString
        {
            get
            {
                return
                    EncodeBase64(this.ConnectionString);
            }
        }


        /// <summary>
        /// 没有加密的字符串
        /// </summary>
        public string ConnectionString
        {
            get
            {
                string connString = "";
                if (!string.IsNullOrEmpty(UserId) && !string.IsNullOrEmpty(Password))
                {
                    connString = string.Format("Persist Security Info=False;Data Source={0};Initial Catalog={1};User ID={2};Password={3};Packet Size=4096;Pooling=true;Max Pool Size=100;Min Pool Size=1;Connection Timeout={4}",
                        this.server, this.database, this.userID, this.encryptPass?WHC.Framework.Commons.EncodeHelper.Base64Encrypt(this.password):this.password, this.timeout);
                }
                else
                {
                    connString = string.Format("Persist Security Info=False;Data Source={0};Initial Catalog={1};Integrated Security=SSPI;Packet Size=4096;Pooling=true;Max Pool Size=100;Min Pool Size=1;Connection Timeout={2}",
                                                  this.server, this.database, this.timeout);
                }
                return connString;
            }
        }

        


        /// <summary>
        /// 提供OLEDB数据源的链接字符串
        /// </summary>
        public string OleDbConnectionString
        {
            get
            {
                string connectionPrefix = "Driver={SQL Server};";
                return connectionPrefix + this.ConnectionString;
            }
        }

        #endregion

        #region 辅助函数

        /// <summary>
        /// 获取给定字符串中的子节点的值, 如果不存在返回Null
        /// </summary>
        /// <param name="itemValueString">多个值的字符串</param>
        /// <param name="subKeyName"></param>
        /// <returns></returns>
        private string GetSubItemValue(string itemValueString, string subKeyName)
        {
            string[] item = itemValueString.Split(new char[] { ';' });
            for (int i = 0; i < item.Length; i++)
            {
                string itemValue = item[i].ToLower();
                if (itemValue.IndexOf(subKeyName.ToLower()) >= 0) //如果含有指定的关键字
                {
                    int startIndex = item[i].IndexOf("="); //等号开始的位置
                    return item[i].Substring(startIndex + 1); //获取等号后面的值即为Value
                }
            }
            return null;
        }

        /// <summary>
        /// 获取某节点下用逗号分隔的字符串，如：server=192.168.1.1,1433
        /// </summary>
        /// <param name="itemValuestring">源字符串</param>
        /// <param name="isStart">是否返回第一个字符串</param>
        /// <returns>如：server=192.168.1.1,1433，isStart为真返回：192.168.1.1，否则返回：1433</returns>
        private string GetSubItemValue(string itemValuestring,bool isStart)
        {
            string[] item = itemValuestring.Split(new char[] { ',' });
            try
            {
                if (isStart)
                {
                    return item[0];
                }
                else
                {
                    return item[1];
                }
            }
            catch (Exception)
            {
                return itemValuestring;
            }
        }


        private string EncodeBase64(string source)
        {
            byte[] buffer1 = Encoding.UTF8.GetBytes(source);
            return Convert.ToBase64String(buffer1, 0, buffer1.Length);
        }

        #endregion
    }
}