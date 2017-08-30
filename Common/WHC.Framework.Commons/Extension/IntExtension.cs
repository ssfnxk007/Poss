using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// INT类型扩展方法
    /// </summary>
    public static class IntExtension
    {
        /// <summary>
        /// 返回包册描述 如某商品包册数为10,数量为28,则返回:2+8(10)
        /// </summary>
        /// <param name="intValue"></param>
        /// <param name="package">包册数</param>
        /// <param name="amount">数量</param>
        /// <returns>如某商品包册数为10,数量为28,则返回:2+8(10)</returns>
        public static string GetPackageDescribe(this int intValue, int package, int amount)
        {
            if(package==0)
                return string.Format("0+{0}(0)",amount);
             
            if (amount==0) 
                return string.Format("0+0({0})",package);

            return string.Format("{0}+{1}({2})",(amount / package).ToString().ToInt32(),amount % package,package);
        }
    }
}
