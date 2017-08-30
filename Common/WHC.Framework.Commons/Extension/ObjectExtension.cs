using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// Object扩展方法
    /// </summary>
   public static class ObjectExtension
    {
       /// <summary>
       /// 获取属性描述值
       /// </summary>
       /// <param name="o"></param>
       /// <returns></returns>
       public static Dictionary<string, string> GetDescription(this object val)
       {
           Dictionary<string, string> result = new Dictionary<string, string>();
           try
           {
               PropertyInfo[] properties = val.GetType().GetProperties();
               for (int i = 0; i < properties.Length; i++)
               {
                   DescriptionAttribute[] attributes = (DescriptionAttribute[])properties[i].GetCustomAttributes(typeof(DescriptionAttribute), true);
                   result.Add(properties[i].Name, (attributes.Length > 0) ? attributes[0].Description : properties[i].Name);
               }
           }
           catch
           {
           }
           return result;
       }

       /// <summary>
       /// 获取对象所有属性名称
       /// </summary>
       /// <param name="val"></param>
       /// <returns></returns>
       public static List<string> GetProperties(this object val)
       {
           PropertyInfo[] properties = val.GetType().GetProperties();
           List<string> propList = new List<string>();
           for (int i = 0; i < properties.Length; i++)
           {
               propList.Add(properties[i].Name);
           }
           return propList;
       }

       
    }
}
