using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// CodeHelper
    /// </summary>
    public static class CodeHelper
    {
        /// <summary>
        /// 获取条形码校验位
        /// </summary>
        /// <param name="barCode">条形码(不含校验码)</param>
        /// <returns>校验码</returns>
        public static string GetBarCodeVerifyCode(this string barCode)
        {
            if (!barCode.IsNumberOnly(false))
            {
                return string.Empty;
            }
            char[] c = barCode.ToArray();
            Array.Reverse(c);
            int iSsum = 0;//奇数和
            int iDsum = 0;//偶数和
            int iSum = 0;//总和
            int iCheck = 0;//校验位
            for (int index = 0; index < c.Length; index++)
            {
                if (index % 2 == 0)
                {
                    iDsum += c[index].ToString().ToInt32();
                }
                else
                {
                    iSsum += c[index].ToString().ToInt32(); 
                }
            
            }
            iSum = iDsum * 3 + iSsum;
            iCheck = 10 - (iSum % 10);

            return iCheck.ToString();
        }

       
    }
}
