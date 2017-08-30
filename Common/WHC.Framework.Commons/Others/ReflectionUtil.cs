using System;
using System.Reflection;
using System.Resources;
using System.Drawing;
using System.IO;
using System.Text;
using System.ComponentModel;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// ������������࣬���ȡ�������ֶΡ����Ե�ֵ�ȷ�����Ϣ��
    /// </summary>
    public sealed class ReflectionUtil
    {
        private ReflectionUtil()
        {
        }

        #region �����ֶ�����
        /// <summary>
        /// �󶨱�ʶ
        /// </summary>
        public static BindingFlags bf = BindingFlags.DeclaredOnly | BindingFlags.Public |
                                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        /// <summary>
        /// ִ�з���
        /// </summary>
        /// <param name="obj">����ʵ��</param>
        /// <param name="methodName">��������</param>
        /// <param name="args">����</param>
        /// <returns></returns>
        public static object InvokeMethod(object obj, string methodName, object[] args)
        {
            object objReturn = null;
            Type type = obj.GetType();
            objReturn = type.InvokeMember(methodName, bf | BindingFlags.InvokeMethod, null, obj, args);
            return objReturn;
        }

        /// <summary>
        /// ���ö���ʵ�����ֶ�ֵ
        /// </summary>
        /// <param name="obj">����ʵ��</param>
        /// <param name="name">�ֶ�����</param>
        /// <param name="value">�ֶ�ֵ</param>
        public static void SetField(object obj, string name, object value)
        {
            FieldInfo fi = obj.GetType().GetField(name, bf);
            fi.SetValue(obj, value);
        }

        /// <summary>
        /// ��ȡ����ʵ�����ֶ�ֵ
        /// </summary>
        /// <param name="obj">����ʵ��</param>
        /// <param name="name">�ֶ�����</param>
        /// <returns></returns>
        public static object GetField(object obj, string name)
        {
            FieldInfo fi = obj.GetType().GetField(name, bf);
            return fi.GetValue(obj);
        }

        /// <summary>
        /// ��ȡ����ʵ�����ֶμ���
        /// </summary>
        /// <param name="obj">����ʵ��</param>
        /// <returns></returns>
        public static FieldInfo[] GetFields(object obj)
        {
            FieldInfo[] fieldInfos = obj.GetType().GetFields(bf);
            return fieldInfos;
        }

        /// <summary>
        /// ���ö���ʵ��������ֵ
        /// </summary>
        /// <param name="obj">����ʵ��</param>
        /// <param name="name">��������</param>
        /// <param name="value">����ֵ</param>
        public static void SetProperty(object obj, string name, object value)
        {
            PropertyInfo fieldInfo = obj.GetType().GetProperty(name, bf);
            value = Convert.ChangeType(value, fieldInfo.PropertyType);
            fieldInfo.SetValue(obj, value, null);
        }

        /// <summary>
        /// ��ȡ����ʵ��������ֵ
        /// </summary>
        /// <param name="obj">����ʵ��</param>
        /// <param name="name">��������</param>
        /// <returns></returns>
        public static object GetProperty(object obj, string name)
        {
            PropertyInfo fieldInfo = obj.GetType().GetProperty(name, bf);
            return fieldInfo.GetValue(obj, null);
        }

        /// <summary>
        /// ��ȡ����ʵ���������б�
        /// </summary>
        /// <param name="obj">����ʵ��</param>
        /// <returns></returns>
        public static PropertyInfo[] GetProperties(object obj)
        {
            PropertyInfo[] propertyInfos = obj.GetType().GetProperties(bf);
            return propertyInfos;
        }

        /// <summary>
        /// �Ѷ�������Ժ�ֵ�����һ����ֵ���ַ�������A=1&B=test
        /// </summary>
        /// <param name="obj">ʵ�����</param>
        /// <param name="includeEmptyProperties">�Ƿ�����հ����Եļ�ֵ</param>
        /// <returns></returns>
        public static string ToNameValuePairs(object obj, bool includeEmptyProperties = true)
        {
            string result = "";

            foreach (PropertyInfo p in obj.GetType().GetProperties())
            {
                var objVal = p.GetValue(obj, null);
                var value = objVal != null ? objVal.ToString() : null;

                if (string.IsNullOrEmpty(value))
                {
                    if (includeEmptyProperties)
                    {
                        if (!string.IsNullOrEmpty(result))
                        {
                            result += "&";
                        }

                        result += string.Format("{0}={1}", p.Name, value);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(result))
                    {
                        result += "&";
                    }

                    result += string.Format("{0}={1}", p.Name, value);
                }
            }

            return result;
        }

        #endregion

        #region ��ȡDescription

        /// <summary>
        /// ��ȡö���ֶε�Description����ֵ
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>return description or value.ToString()</returns>
        public static string GetDescription(Enum value)
        {
            return GetDescription(value, null);
        }

        /// <summary>
        /// Get The Enum Field Description using Description Attribute and 
        /// objects to format the Description.
        /// </summary>
        /// <param name="value">Enum For Which description is required.</param>
        /// <param name="args">An Object array containing zero or more objects to format.</param>
        /// <returns>return null if DescriptionAttribute is not found or return type description</returns>
        public static string GetDescription(Enum value, params object[] args)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string text1;

            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            text1 = (attributes.Length > 0) ? attributes[0].Description : value.ToString();

            if ((args != null) && (args.Length > 0))
            {
                return string.Format(null, text1, args);
            }
            return text1;
        }

        /// <summary>
        ///	��ȡ�ֶε�Description����ֵ
        /// </summary>
        /// <param name="member">Specified Member for which Info is Required</param>
        /// <returns>return null if DescriptionAttribute is not found or return type description</returns>
        public static string GetDescription(MemberInfo member)
        {
            return GetDescription(member, null);
        }

        /// <summary>
        /// Get The Type Description using Description Attribute and 
        /// objects to format the Description.
        /// </summary>
        /// <param name="member"> Specified Member for which Info is Required</param>
        /// <param name="args">An Object array containing zero or more objects to format.</param>
        /// <returns>return <see cref="String.Empty"/> if DescriptionAttribute is 
        /// not found or return type description</returns>
        public static string GetDescription(MemberInfo member, params object[] args)
        {
            string text1;

            if (member == null)
            {
                throw new ArgumentNullException("member");
            }

            if (member.IsDefined(typeof(DescriptionAttribute), false))
            {
                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])member.GetCustomAttributes(typeof(DescriptionAttribute), false);
                text1 = attributes[0].Description;
            }
            else
            {
                return String.Empty;
            }

            if ((args != null) && (args.Length > 0))
            {
                return String.Format(null, text1, args);
            }
            return text1;
        }

        #endregion

        #region ��ȡAttribute��Ϣ

        /// <summary>
        /// ��ȡָ������ʵ����attributes����
        /// </summary>
        /// <param name="attributeType">The attribute Type for which the custom attributes are to be returned.</param>
        /// <param name="assembly">the assembly in which the specified attribute is defined</param>
        /// <returns>Attribute as Object or null if not found.</returns>
        public static object GetAttribute(Type attributeType, Assembly assembly)
        {
            if (attributeType == null)
            {
                throw new ArgumentNullException("attributeType");
            }

            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }


            if (assembly.IsDefined(attributeType, false))
            {
                object[] attributes = assembly.GetCustomAttributes(attributeType, false);

                return attributes[0];
            }

            return null;
        }


        /// <summary>
        /// ��ȡָ������ʵ����attributes����
        /// </summary>
        /// <param name="attributeType">The attribute Type for which the custom attributes are to be returned.</param>
        /// <param name="type">the type on which the specified attribute is defined</param>
        /// <returns>Attribute as Object or null if not found.</returns>
        public static object GetAttribute(Type attributeType, MemberInfo type)
        {
            return GetAttribute(attributeType, type, false);
        }


        /// <summary>
        /// Gets the specified object attributes for type as specified by type with option to serach parent
        /// </summary>
        /// <param name="attributeType">The attribute Type for which the custom attributes are to be returned.</param>
        /// <param name="type">the type on which the specified attribute is defined</param>
        /// <param name="searchParent">if set to <see langword="true"/> [search parent].</param>
        /// <returns>
        /// Attribute as Object or null if not found.
        /// </returns>
        public static object GetAttribute(Type attributeType, MemberInfo type, bool searchParent)
        {
            if (attributeType == null)
            {
                return null;
            }

            if (type == null)
            {
                return null;
            }

            if (!(attributeType.IsSubclassOf(typeof(Attribute))))
            {
                return null;
            }


            if (type.IsDefined(attributeType, searchParent))
            {
                object[] attributes = type.GetCustomAttributes(attributeType, searchParent);

                if (attributes.Length > 0)
                {
                    return attributes[0];
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the collection of all specified object attributes for type as specified by type
        /// </summary>
        /// <param name="attributeType">The attribute Type for which the custom attributes are to be returned.</param>
        /// <param name="type">the type on which the specified attribute is defined</param>
        /// <returns>Attribute as Object or null if not found.</returns>
        public static object[] GetAttributes(Type attributeType, MemberInfo type)
        {
            return GetAttributes(attributeType, type, false);
        }


        /// <summary>
        /// Gets the collection of all specified object attributes for type as specified by type with option to serach parent
        /// </summary>
        /// <param name="attributeType">The attribute Type for which the custom attributes are to be returned.</param>
        /// <param name="type">the type on which the specified attribute is defined</param>
        /// <param name="searchParent">The attribute Type for which the custom attribute is to be returned.</param>
        /// <returns>
        /// Attribute as Object or null if not found.
        /// </returns>
        public static object[] GetAttributes(Type attributeType, MemberInfo type, bool searchParent)
        {
            if (type == null)
            {
                return null;
            }

            if (attributeType == null)
            {
                return null;
            }

            if (!(attributeType.IsSubclassOf(typeof(Attribute))))
            {
                return null;
            }


            if (type.IsDefined(attributeType, false))
            {
                return type.GetCustomAttributes(attributeType, searchParent);
            }

            return null;
        }

        #endregion

        #region ��Դ��ȡ

        /// <summary>
        /// ������Դ���ƻ�ȡͼƬ��Դ��
        /// </summary>
        /// <param name="ResourceName"></param>
        /// <returns></returns>
        public static Stream GetImageResource(string ResourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream(ResourceName);
        }

        /// <summary>
        /// ��ȡ������Դ��λͼ��Դ
        /// </summary>
        /// <param name="assemblyType">�����е�ĳһ��������</param>
        /// <param name="resourceHolder">��Դ�ĸ����ơ����磬��Ϊ��MyResource.en-US.resources������Դ�ļ��ĸ�����Ϊ��MyResource����</param>
        /// <param name="imageName">��Դ������</param>
        public static Bitmap LoadBitmap(Type assemblyType, string resourceHolder, string imageName)
        {
            Assembly thisAssembly = Assembly.GetAssembly(assemblyType);
            ResourceManager rm = new ResourceManager(resourceHolder, thisAssembly);
            return (Bitmap)rm.GetObject(imageName);
        }

        /// <summary>
        ///  ��ȡ������Դ���ı���Դ
        /// </summary>
        /// <param name="assemblyType">�����е�ĳһ��������</param>
        /// <param name="resName">��Դ������</param>
        /// <param name="resourceHolder">��Դ�ĸ����ơ����磬��Ϊ��MyResource.en-US.resources������Դ�ļ��ĸ�����Ϊ��MyResource����</param>
        public static string GetStringRes(Type assemblyType, string resName, string resourceHolder)
        {
            Assembly thisAssembly = Assembly.GetAssembly(assemblyType);
            ResourceManager rm = new ResourceManager(resourceHolder, thisAssembly);
            return rm.GetString(resName);
        }

        /// <summary>
        /// ��ȡ����Ƕ����Դ���ı���ʽ
        /// </summary>
        /// <param name="assemblyType">�����е�ĳһ��������</param>
        /// <param name="charset">�ַ�������</param>
        /// <param name="ResName">Ƕ����Դ���·��</param>
        /// <returns>��û�ҵ�����Դ�򷵻ؿ��ַ�</returns>
        public static string GetManifestString(Type assemblyType, string charset, string ResName)
        {
            Assembly asm = Assembly.GetAssembly(assemblyType);
            Stream st = asm.GetManifestResourceStream(string.Concat(assemblyType.Namespace,
                ".", ResName.Replace("/", ".")));
            if (st == null) { return ""; }
            int iLen = (int)st.Length;
            byte[] bytes = new byte[iLen];
            st.Read(bytes, 0, iLen);
            return (bytes != null) ? Encoding.GetEncoding(charset).GetString(bytes) : "";
        }

        #endregion

        #region ������Ӧʵ��
        /// <summary>
        /// ������Ӧʵ��
        /// </summary>
        /// <param name="type">����</param>
        /// <returns>��Ӧʵ��</returns>
        public static object CreateInstance(string type)
        {
            Type tmp = null;
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; i++)
            {
                tmp = assemblies[i].GetType(type);
                if (tmp != null)
                {
                    return assemblies[i].CreateInstance(type);

                }
            }
            return null;
            //return Assembly.GetExecutingAssembly().CreateInstance(type);
        }

        /// <summary>
        /// ������Ӧʵ��
        /// </summary>
        /// <param name="type">����</param>
        /// <returns>��Ӧʵ��</returns>
        public static object CreateInstance(Type type)
        {
            return CreateInstance(type.FullName);
        } 
        #endregion

    }
}