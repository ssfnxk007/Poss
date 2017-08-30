using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WHC.Framework.Commons;

namespace 数据库加密
{
    public partial class SQLForm3 : Form
    {
        private static string currentConfig = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"MainFrom.exe.config";
        private static string currentConfig2 = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"POSS.UI.exe.config";
        List<string> k = null;
        public SQLForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //XmlHelper xml = new XmlHelper("");
            //xml.Read()
            k= new List<string>();
            k.Add(currentConfig);
            k.Add(currentConfig2);
        }

        private void SetApp(string sa,string passwd,string ip,string book)
        {
            foreach (var item in k)
            {
                AppConfig app = new AppConfig(item);
                app.AppConfigSet("Data Source", "");
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
