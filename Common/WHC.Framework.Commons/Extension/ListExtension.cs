using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WHC.Framework.Commons;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// List泛型集合扩展类
    /// </summary>
    public static class ListExtension
    {

        /// <summary>
        /// 将List泛型集合写入文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fileName"></param>
        public static void WriteToTxtFile<T>(this List<T> t, string fileName)
        {
            StringBuilder detail = new StringBuilder();
            object value;
            foreach (var info in t)
            {
                foreach (var p in info.GetType().GetProperties())
                {
                    value = p.GetValue(info, null);
                    detail.Append(value == null ? string.Empty : value.ToString());
                    detail.Append("\t");
                }
                detail.Append("\r\n");
            }
            WHC.Framework.Commons.FileUtil.WriteText(fileName, detail.ToString());
        }

        /// <summary>
        /// 将txt文件中的值添加到泛型集合中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fileName"></param>
        public static List<T> ReadByTxtFile<T>(this List<T> t, string fileName) where T :new()
        {
            if (!WHC.Framework.Commons.FileUtil.IsExistFile(fileName)) return null;
            List<T> list = new List<T>();
            string detail = FileUtil.FileToString(fileName);
            string[] items = detail.Split('\r','\n');
            string[] item;
            foreach(string s in items)
            {
                if (string.IsNullOrEmpty(s)) continue;
                T info = new T();
                item = s.Split('\t');
                PropertyInfo[] pis = info.GetType().GetProperties();
                for(int index=0;index<pis.Length;index++)
                {
                    try
                    {
                        pis[index].SetValue(info, GetPropertiesValue(pis[index], item[index]), null);
                    }
                    catch (Exception)
                    {
                        pis[index].SetValue(info, null, null);
                    }
                }
                list.Add(info);
            }
            return list;
        }
        /// <summary>
        /// 获取某属性的值
        /// </summary>
        /// <param name="p"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static object GetPropertiesValue(PropertyInfo p, string value)
        {
            object result = new object();
            switch ((p.PropertyType).FullName)
            {
                case "System.Decimal":
                    result = value.ToDecimal();
                    break;
                case "System.Int32":
                    result = value.ToInt32();
                    break;
                case "System.DateTime":
                    result = value.ToDateTime();
                    break;
                case "System.Int16":
                    result = value.ToInt16();
                    break;
                case "System.Boolean":
                    result = value.ToBoolean();
                    break;
                default:
                    result = value;
                    break;
            }
            return result;
        }

        /// <summary>
        /// 分解String类型的List为:a,b,c,d,e格式的字符串
        /// </summary>
        /// <param name="strList"></param>
        /// <returns></returns>
        public static string ResolveListToString(this List<string> strList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in strList)
            {
                if (string.IsNullOrEmpty(sb.ToString()))
                {
                    sb.Append(s);
                }
                else
                {
                    sb.AppendFormat("{0},",s);
                }
            }
            return sb.ToString();
        
        }

        /// <summary>
        /// 将一个List转换为含：项目值，显示值两列的DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="displayMember">显示的成员名称</param>
        /// <param name="valueMember">项目值的成员名称</param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this List<T> list,string displayMember,string valueMember) where T:class
        {
            DataTable dt = DataTableHelper.CreateTable("string|项目值,string|显示值");
            foreach (var i in list)
            {
                try
                {
                    DataRow r = dt.NewRow();
                    r[0] = i.GetType().GetProperty(valueMember).GetValue(i, null);
                    r[1] = i.GetType().GetProperty(displayMember).GetValue(i, null);
                    dt.Rows.Add(r);
                }
                catch (Exception)
                {
                    continue;
                }
                
            }

            return dt;
        }
    }
}
