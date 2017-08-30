using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// 用于字符串转换其他类型的扩展函数
    /// </summary>
    public static class StringExtensionMethod
    {
        #region 字符串转换其他格式
        /// <summary>
        /// 转换字符串为日期类型
        /// </summary>
        /// <param name="str">字符串内容</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string str)
        {
            str = ConvertHelper.ConvertToDBC(str);//先转换为半角字符串
            DateTime defaultValue = Convert.ToDateTime("1900-1-1");
            bool converted = DateTime.TryParse(str, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 转换字符串为Int类型，可以指定默认值
        /// </summary>
        /// <param name="str">字符串内容</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static int ToInt32(this string str, int defaultValue = 0)
        {
            str = ConvertHelper.ConvertToDBC(str);//先转换为半角字符串
            bool converted = int.TryParse(str, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 转换字符串为Int16类型，可以指定默认值
        /// </summary>
        /// <param name="str">字符串内容</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static int ToInt16(this string str, Int16 defaultValue = 0)
        {
            str = ConvertHelper.ConvertToDBC(str);//先转换为半角字符串
            bool converted = Int16.TryParse(str, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 转换字符串为byte类型，可以指定默认值
        /// </summary>
        /// <param name="str">字符串内容</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static byte ToByte(this string str, byte defaultValue = 0)
        {
            str = ConvertHelper.ConvertToDBC(str);//先转换为半角字符串
            bool converted = byte.TryParse(str, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 转换字符串为double类型，可以指定默认值
        /// </summary>
        /// <param name="str">字符串内容</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static double ToDouble(this string str, double defaultValue = 0)
        {
            str = ConvertHelper.ConvertToDBC(str);//先转换为半角字符串
            bool converted = double.TryParse(str, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 转换字符串为decimal类型，可以指定默认值
        /// </summary>
        /// <param name="str">字符串内容</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string str, decimal defaultValue = 0M)
        {
            str = ConvertHelper.ConvertToDBC(str);//先转换为半角字符串
            bool converted = decimal.TryParse(str, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 转换字符串为float类型，可以指定默认值
        /// </summary>
        /// <param name="str">字符串内容</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static float ToFloat(this string str, float defaultValue = 0)
        {
            str = ConvertHelper.ConvertToDBC(str);//先转换为半角字符串
            bool converted = float.TryParse(str, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 转换字符串为float类型，可以指定默认值
        /// </summary>
        /// <param name="str">字符串内容</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static bool ToBoolean(this string str)
        {
            bool defaultValue = false;
            bool converted = bool.TryParse(str, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 生成SQL语句
        /// </summary>
        /// <param name="str"></param>
        /// 
        /// <returns></returns>
        public static string ToAndSqlSyntax(this string str,string strExists)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;
            if (string.IsNullOrWhiteSpace(strExists))
            {
                return str;
            }
            else
            {
                return string.Format(" AND {0}", str);
            }
        }

        /// <summary>
        /// 生成SQL语句
        /// </summary>
        /// <param name="str"></param>
        /// 
        /// <returns></returns>
        public static string ToOrSqlSyntax(this string str, string strExists)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;
            if (string.IsNullOrWhiteSpace(strExists))
            {
                return str;
            }
            else
            {
                return string.Format(" OR {0}", str);
            }
        }

        /// <summary>
        /// 生成SQL语句描述
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToSqlSyntaxDescribe(this string str,string strExists)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;
            if (string.IsNullOrWhiteSpace(strExists))
            {
                return str;
            }
            else
            {
                return string.Format(" ，并且 {0}", str);
            }
        }

        /// <summary>
        /// 将字符串按指定字符分割为List<string>
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="spitChar">分隔符</param>
        /// <returns></returns>
        public static List<string> ToListString(this string str,char spitChar)
        {
            List<string> list = new List<string>();
            if (string.IsNullOrWhiteSpace(str)) return list;
            string[] values = str.Split(spitChar);
            foreach (string value in values)
            {
                list.Add(value);
            }
            return list;
        }

        /// <summary>
        /// 生成SQL条件
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="column">列名</param>
        /// <param name="joinchar">连接字符串:and ,or </param>
        /// <param name="strExists">已存在的条件</param>
        /// <returns></returns>
        public static string ToSqlSyntax(this string str, string column, string joinchar, string strExists)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;
            if (string.IsNullOrWhiteSpace(strExists))
            {
                return string.Format("{0} {1}", column, str);
            }
            else
            {
                return string.Format("{0} {1} {2}", column, joinchar, str);
            }
        }


       
        #endregion

        #region 其他辅助方法

        /// <summary>
        /// true, if is valid email address
        /// </summary>
        /// <param name="s">email address to test</param>
        /// <returns>true, if is valid email address</returns>
        public static bool IsValidEmailAddress(this string s)
        {
            return new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,6}$").IsMatch(s);
        }

        /// <summary>
        /// Checks if url is valid. 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsValidUrl(this string url)
        {
            string strRegex = "^(https?://)"
        + "?(([0-9a-z_!~*'().&=+$%-]+: )?[0-9a-z_!~*'().&=+$%-]+@)?" //user@
        + @"(([0-9]{1,3}\.){3}[0-9]{1,3}" // IP- 199.194.52.184
        + "|" // allows either IP or domain
        + @"([0-9a-z_!~*'()-]+\.)*" // tertiary domain(s)- www.
        + @"([0-9a-z][0-9a-z-]{0,61})?[0-9a-z]" // second level domain
        + @"(\.[a-z]{2,6})?)" // first level domain- .com or .museum is optional
        + "(:[0-9]{1,5})?" // port number- :80
        + "((/?)|" // a slash isn't required if there is no file name
        + "(/[0-9a-z_!~*'().;?:@&=+$,%#-]+)+/?)$";
            return new Regex(strRegex).IsMatch(url);
        }

        /// <summary>
        /// Check if url (http) is available.
        /// </summary>
        /// <param name="httpUri">url to check</param>
        /// <example>
        /// string url = "www.codeproject.com;
        /// if( !url.UrlAvailable())
        ///     ...codeproject is not available
        /// </example>
        /// <returns>true if available</returns>
        public static bool UrlAvailable(this string httpUrl)
        {
            if (!httpUrl.StartsWith("http://") || !httpUrl.StartsWith("https://"))
                httpUrl = "http://" + httpUrl;
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(httpUrl);
                myRequest.Method = "GET";
                myRequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myRequest.GetResponse();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Reverse the string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }
        
        /// <summary>
        /// Reduce string to shorter preview which is optionally ended by some string (...).
        /// </summary>
        /// <param name="s">string to reduce</param>
        /// <param name="count">Length of returned string including endings.</param>
        /// <param name="endings">optional edings of reduced text</param>
        /// <example>
        /// string description = "This is very long description of something";
        /// string preview = description.Reduce(20,"...");
        /// produce -> "This is very long..."
        /// </example>
        /// <returns></returns>
        public static string Reduce(this string s, int count, string endings)
        {
            if (count < endings.Length)
                throw new Exception("Failed to reduce to less then endings length.");
            int sLength = s.Length;
            int len = sLength;
            if (endings != null)
                len += endings.Length;
            if (count > sLength)
                return s; //it's too short to reduce
            s = s.Substring(0, sLength - len + count);
            if (endings != null)
                s += endings;
            return s;
        }

        /// <summary>
        /// remove white space, not line end
        /// Useful when parsing user input such phone,
        /// price int.Parse("1 000 000".RemoveSpaces(),.....
        /// </summary>
        /// <param name="s"></param>
        /// <param name="value">string without spaces</param>
        public static string RemoveSpaces(this string s)
        {
            return s.Replace(" ", "");
        }

        /// <summary>
        /// true, if the string can be parse as Double respective Int32
        /// Spaces are not considred.
        /// </summary>
        /// <param name="s">input string</param>
        /// <param name="floatpoint">true, if Double is considered,
        /// otherwhise Int32 is considered.</param>
        /// <returns>true, if the string contains only digits or float-point</returns>
        public static bool IsNumber(this string s, bool floatpoint)
        {
            int i;
            double d;
            string withoutWhiteSpace = s.RemoveSpaces();
            if (floatpoint)
            {
                return double.TryParse(withoutWhiteSpace, NumberStyles.Any,
                    Thread.CurrentThread.CurrentUICulture, out d);
            }
            else
            {
                return int.TryParse(withoutWhiteSpace, out i);
            }
        }

        /// <summary>
        /// true, if the string contains only digits or float-point.
        /// Spaces are not considred.
        /// </summary>
        /// <param name="s">input string</param>
        /// <param name="floatpoint">true, if float-point is considered</param>
        /// <returns>true, if the string contains only digits or float-point</returns>
        public static bool IsNumberOnly(this string s, bool floatpoint)
        {
            s = s.Trim();
            if (s.Length == 0)
                return false;
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    if (floatpoint && (c == '.' || c == ','))
                        continue;
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Remove accent from strings 
        /// </summary>
        /// <example>
        ///  input:  "Příliš žluťoučký kůň úpěl ďábelské ódy."
        ///  result: "Prilis zlutoucky kun upel dabelske ody."
        /// </example>
        /// <param name="s"></param>
        /// <remarks>founded at http://stackoverflow.com/questions/249087/
        /// how-do-i-remove-diacritics-accents-from-a-string-in-net</remarks>
        /// <returns>string without accents</returns>
        public static string RemoveDiacritics(this string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }

        /// <summary>
        /// Replace \r\n or \n by <br />
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Nl2Br(this string s)
        {
            return s.Replace("\r\n", "<br />").Replace("\n", "<br />");
        }


        static MD5CryptoServiceProvider s_md5 = null;
        /// <summary>
        /// 使用MD5加密字符串
        /// </summary>
        /// <param name="s">输入字符串</param>
        /// <returns></returns>
        public static string MD5(this string s)
        {
            if (s_md5 == null) //creating only when needed
                s_md5 = new MD5CryptoServiceProvider();
            Byte[] newdata = Encoding.Default.GetBytes(s);
            Byte[] encrypted = s_md5.ComputeHash(newdata);
            return BitConverter.ToString(encrypted).Replace("-", "").ToLower();
        }


        /// <summary>
        /// 返回某字符串在源字符串中出现的次数
        /// </summary>
        /// <param name="strSource">源字符串</param>
        /// <param name="seach">要统计的字符串</param>
        /// <returns>出现的次数</returns>
        public static int StringCount(this string strSource, string seach)
        {
            int iCount = 0, iLen = 0;
            iLen = seach.Length;
            if (iLen > strSource.Length) return 0;
            for (int i = 0; i < strSource.Length; i++)
            {
                if ((i + iLen) > strSource.Length) break;
                if (strSource.Substring(i, iLen) == seach)
                {
                    iCount++;
                }
            }
            return iCount;
        }

       
        public static string BuildSqlString(this string strSource,char spltstring)
        {
            StringBuilder sb=new StringBuilder();
            string[] v = strSource.Split(spltstring);
            foreach (string s in v)
            {
                sb.AppendFormat("'{0}',",s.Replace(" ",""));
            }
            string value = sb.ToString();
            return value.Substring(0, value.Length - 1);
            
        }

        public static string ToMaskString(this string value)
        {
            string text = value.Trim();
            int length = text.Length;

            if (length == 0 || length == 1)
            {
                return value;
            }
            else if (length == 2)
            {
                return string.Format("***{0}", value.Substring(1, 1));
            }
            else if (length == 3)
            {
                return string.Format("**{0}", value.Substring(1, 2));
            }
            else if (length == 4)
            {
                return string.Format("*{0}", value.Substring(1, 3));
            }
            else
            {
                return string.Format("****{0}", value.Substring(length - 4, 4));
            }

            
        }
        #endregion
    }
}
