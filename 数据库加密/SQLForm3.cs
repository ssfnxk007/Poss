using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;

namespace 数据库加密
{
    public partial class SQLForm3 : Form
    {
        private AppConfig appconfig;
        private AppConfig appconfig1;
        private SqlServerInfo sqlserver;

        private static string currentConfig = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"MainFrom.exe.config";
        private static string currentConfig2 = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"POSS.UI.exe.config";
        List<string> k = null;
        public SQLForm3()
        {
            InitializeComponent();
        }

 

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveSqlserver();
            MessageUtil.ShowTips("应用成功!");
        }

        private void SQLForm3_Load(object sender, EventArgs e)
        {
            appconfig = new AppConfig(currentConfig);
            appconfig1 = new AppConfig(currentConfig2);
            InitConfig();
        }

        private void InitConfig()
        {
            string sqlserver = appconfig.GetConnectionString("sqlserver");
            this.sqlserver = new SqlServerInfo(sqlserver);
            //this.t_sa.Text = this.sqlserver.Timeout.ToString();
            this.t_book.Text = this.sqlserver.Database.ToString();
            this.t_sa.Text = this.sqlserver.UserId.ToString();
            this.t_pass.Text =EncodeHelper.DesDecrypt( this.sqlserver.Password.ToString().Trim());
            this.t_port.Text = this.sqlserver.Port.ToString();
            this.t_ip.Text = this.sqlserver.Server.ToString();

        }

        private void SaveSqlserver()
        {
            this.sqlserver.Server = t_ip.Text.Trim();
            this.sqlserver.Port = t_port.Text.Trim(). ToInt32();
            this.sqlserver.Password =EncodeHelper.DesEncrypt( t_pass.Text.Trim());
            //this.sqlserver.Timeout = txtMsSqlConTimeOut.Text.ToInt32();
            this.sqlserver.UserId = t_sa.Text.Trim();
            this.sqlserver.Database = t_book.Text.Trim();
            appconfig.SetDatabaseInfo("sqlserver", this.sqlserver);
            appconfig1.SetDatabaseInfo("sqlserver", this.sqlserver);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
