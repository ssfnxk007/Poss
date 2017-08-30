using System;
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
                //AppJiaMi();
                //if (AppGetMi())
                //{
                //    Application.Run(new login());
                //}
                //else
                //{
                //    MessagboxUit.ShowError("请联系开发人员！获取注册号！QQ:85530815");
                //}
            }
            catch (Exception ex)
            {
                MessagboxUit.ShowError(ex.Message);
            }
            Application.Run(new login());

        }
       static string code = string.Empty;
        private static void AppJiaMi()
        {

            //string cpuid = HardwareInfoHelper.GetCPUId();
            //string cpuidcode = EncodeHelper.DesEncrypt(cpuid);
            //string diskid = HardwareInfoHelper.GetDiskID();
            //string diskidcode = EncodeHelper.DesEncrypt(diskid);
            //string cpuname = HardwareInfoHelper.GetCPUName();
            //string cpunamecode = EncodeHelper.DesEncrypt(cpuname);
            string h = HardwareInfoHelper.GetMacAddress();
            string cpuidcode = EncodeHelper.DesEncrypt(h);
            code = cpuidcode;
            try
            {
                if (File.Exists(System.Windows.Forms.Application.StartupPath + "\\Key.Lib")) return;
                FileStream fs = new FileStream(System.Windows.Forms.Application.StartupPath + "\\Key.Lib", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs, Encoding.UTF8);
                sr.WriteLine(code);
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
            string uncode2 = EncodeHelper.DesDecrypt(uncode);
            if (uncode2 == code)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }

    }
}
