using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// ע�����������࣬ͨ��Ĭ��ָ��ע����ǰ׺·�������ٵ��ø����ԡ�
    /// </summary>
    public sealed class RegistryHelper
    {
        #region ������������ȡ�ͱ��棩
        private static string Software_Key = @"Software\DeepLand\OrderWater";

        /// <summary>
        /// ��ȡע������ֵ������ü������ڣ��򷵻ؿ��ַ�����
        /// </summary>
        /// <param name="key">ע����</param>
        /// <returns>ָ�������ص�ֵ</returns>
        public static string GetValue(string key)
        {
            return GetValue(Software_Key, key);
        }

        /// <summary>
        /// ��ȡע������ֵ������ü������ڣ��򷵻ؿ��ַ�����
        /// </summary>
        /// <param name="softwareKey">ע������ǰ׺·��</param>
        /// <param name="key">ע����</param>
        /// <returns>ָ�������ص�ֵ</returns>
        public static string GetValue(string softwareKey, string key)
        {
            return GetValue(softwareKey, key, Registry.CurrentUser);
        }

        /// <summary>
        /// ��ȡע������ֵ������ü������ڣ��򷵻ؿ��ַ�����
        /// </summary>
        /// <param name="softwareKey">ע������ǰ׺·��</param>
        /// <param name="key">ע����</param>
        /// <param name="rootRegistry">��ʼ�ĸ��ڵ㣨Registry.CurrentUser����Registry.LocalMachine�ȣ�</param>
        /// <returns>ָ�������ص�ֵ</returns>
        public static string GetValue(string softwareKey, string key, RegistryKey rootRegistry)
        {
            const string parameter = "key";
            if (null == key)
            {
                throw new ArgumentNullException(parameter);
            }

            string strRet = string.Empty;
            try
            {
                RegistryKey regKey = rootRegistry.OpenSubKey(softwareKey);
                strRet = regKey.GetValue(key).ToString();
            }
            catch
            {
                strRet = "";
            }
            return strRet;
        }

        /// <summary>
        /// �����ֵ��ע���
        /// </summary>
        /// <param name="key">ע����</param>
        /// <param name="value">����ֵ����</param>
        /// <returns>�������ɹ�����true������Ϊfalse</returns>
        public static bool SaveValue(string key, string value)
        {
            return SaveValue(Software_Key, key, value);
        }

        /// <summary>
        /// �����ֵ��ע���
        /// </summary>
        /// <param name="softwareKey">ע������ǰ׺·��</param>
        /// <param name="key">ע����</param>
        /// <param name="value">����ֵ����</param>
        /// <returns>�������ɹ�����true������Ϊfalse</returns>
        public static bool SaveValue(string softwareKey, string key, string value)
        {
            return SaveValue(softwareKey, key, value, Registry.CurrentUser);
        }

        /// <summary>
        /// �����ֵ��ע���
        /// </summary>
        /// <param name="softwareKey">ע������ǰ׺·��</param>
        /// <param name="key">ע����</param>
        /// <param name="value">����ֵ����</param>
        /// <param name="rootRegistry">��ʼ�ĸ��ڵ㣨Registry.CurrentUser����Registry.LocalMachine�ȣ�</param>
        /// <returns>�������ɹ�����true������Ϊfalse</returns>
        public static bool SaveValue(string softwareKey, string key, string value, RegistryKey rootRegistry)
        {
            const string parameter1 = "key";
            const string parameter2 = "value";
            if (null == key)
            {
                throw new ArgumentNullException(parameter1);
            }

            if (null == value)
            {
                throw new ArgumentNullException(parameter2);
            }

            RegistryKey reg;
            reg = rootRegistry.OpenSubKey(softwareKey, true);

            if (null == reg)
            {
                reg = rootRegistry.CreateSubKey(softwareKey);
            }
            reg.SetValue(key, value);

            return true;
        } 
        #endregion

        #region �Զ�������������

        /// <summary>
        /// ����Ƿ���ϵͳ����
        /// </summary>
        /// <returns></returns>
        public static bool CheckStartWithWindows()
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (regkey != null && (string)regkey.GetValue(Application.ProductName, "null", RegistryValueOptions.None) != "null")
            {
                Registry.CurrentUser.Flush();
                return true;
            }

            Registry.CurrentUser.Flush();
            return false;
        }

        /// <summary>
        /// ������ϵͳ����
        /// </summary>
        /// <param name="startWin"></param>
        public static void SetStartWithWindows(bool startWin)
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (regkey != null)
            {
                if (startWin)
                {
                    regkey.SetValue(Application.ProductName, Application.ExecutablePath, RegistryValueKind.String);
                }
                else
                {
                    regkey.DeleteValue(Application.ProductName, false);
                }

                Registry.CurrentUser.Flush();
            }
        }

        #endregion
    }
}