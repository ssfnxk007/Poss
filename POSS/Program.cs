using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;

namespace POSS
{
   
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                AppJiaMi();
                if (AppGetMi())
                {
                    Application.Run(new login());
                }
                else
                {
                    MessagboxUit.ShowError("请联系开发人员！获取注册号！QQ:85530815");
                }
            }
            catch (Exception ex)
            {
                MessagboxUit.ShowError(ex.Message+ "请联系开发人员！获取注册号！QQ:85530815");
            }
           // Application.Run(new login());

        }
       static string code = string.Empty;
        static string code1 = string.Empty;
        private static void AppJiaMi()
        {

            string h = GetYhRegeidt("pos_manager");
            string cpuidcode = EncodeHelper.DesEncrypt(h);
            string h1 = GetYhRegeidt("lend");
            string cpuidcode1 = EncodeHelper.DesEncrypt(h1);
            string h2 = GetYhRegeidt("vipcard");
            string cpuidcode2 = EncodeHelper.DesEncrypt(h2);
            code = cpuidcode+"ss"+cpuidcode1+"fn"+cpuidcode2+"xk";
            
            code1 =cpuidcode1 + "0833" + cpuidcode + "126";
            try
            {
                if (File.Exists(System.Windows.Forms.Application.StartupPath + "\\Key.Lib")) return;
                FileStream fs = new FileStream(System.Windows.Forms.Application.StartupPath + "\\Key.Lib", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs, Encoding.UTF8);
                sr.WriteLine(EncodeHelper.Base64Encrypt(code+'|'+code1));
                sr.Close();
                fs.Close();
                

            }
            catch (Exception ex)
            {
                MessagboxUit.ShowError("程序出错！" + ex.Message.ToString());
            }

        }
        private static bool AppGetMi()
        {
            bool result = false;
            FileStream fs = new FileStream(System.Windows.Forms.Application.StartupPath + "\\License.Lib", FileMode.Open, FileAccess.Read);
            StreamReader sR3 = new StreamReader(fs, Encoding.UTF8);
            string uncode = sR3.ReadToEnd();
            string uncode2 = EncodeHelper.Base64Decrypt(uncode);
            string uncode3= EncodeHelper.Base64Decrypt(uncode2);
            string[] kk ;
            kk= uncode3.Split('|');
            string mk = string.Empty;
            foreach (var item in kk)
            {
                mk += item;
            }
            if (mk == code + code1)
            {
                result = true;
            }
            return result;

        }
       
        /// <summary>
        /// 获取益华注册表文件
        /// </summary>
        /// <param name="voew"></param>
        /// <returns></returns>
        private static string GetYhRegeidt(string voew)
        {
            string path = @"SOFTWARE\ODBC\ODBCINST.INI";
            string path1 = @"SOFTWARE\WOW6432Node\ODBC\ODBCINST.INI";
            string kk = string.Empty;
            if (!string.IsNullOrEmpty(RegistryHelper.GetValue(path, voew)))
            {
                kk = RegistryHelper.GetValue(path, voew);
            }
            else
            {
                kk = RegistryHelper.GetValue(path1, voew);
            }
            return kk;
        }
    }
}
