using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// Decimal扩展
    /// </summary>
    public static class DecimalExtension
    {
        /// <summary>
        /// 判断是否为有效的折扣值
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static bool IsDiscount(this decimal decValue)
        {   
            if (decValue <= 1 && decValue >= 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 判断是否为有效的税率值
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static bool IsTaxrate(this decimal decValue)
        {
            if (decValue <= 2 && decValue >= 0)
                return true;
            else
                return false;
        }


        /// <summary>
        /// 获取人民币四会五入值
        /// </summary>
        /// <param name="decValue">原值</param>
        /// <param name="rt">四舍五入方式</param>
        /// <returns></returns>
        public static decimal ToRound(this decimal decValue, RoundType rt)
        {
            decimal result = decValue;
            switch (rt)
            {
                case RoundType.None:
                    result = decValue;
                    break;
                case RoundType.RoundToShiYuan:
                    result = decValue.RoundToTen();
                    break;
                case RoundType.RoundToYuan:
                    result = decValue.RoundToBit();
                    break;
                case RoundType.RoundToJiao:
                    result = decValue.RoundToOnePlaces();
                    break;
                case RoundType.MaxToShiYuan:
                    result = decValue.MaxToTen();
                    break;
                case RoundType.MaxToYuan:
                    result = decValue.MaxToBit();
                    break;
                case RoundType.MaxToJiao:
                    result = decValue.MaxToOnePlaces();
                    break;
                case RoundType.MinToShiYuan:
                    result = decValue.MinToTen();
                    break;
                case RoundType.MinToYuan:
                    result = decValue.MinToBit();
                    break;
                case RoundType.MinToJiao:
                    result = decValue.MinToOnePlaces();
                    break;
                case RoundType.BRMToShiYuan:
                    result = decValue.BRMToTen();
                    break;
                case RoundType.BRMToYuan:
                    result = decValue.BRMToBit();
                    break;
                case RoundType.BRMToJiao:
                    result = decValue.BRMToOnePlaces();
                    break;
                default:
                    result = decValue;
                    break;
            }
            return result;
        }

        #region 四舍五入
        /// <summary>
        /// 四舍五入到十位
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal RoundToTen(this decimal decValue)
        {
            if (decValue == 0) return 0;
            decimal result = 0;
            result = System.Math.Round(decValue / 10, 0).ToString().ToInt32() * 10;
            return result;
        }


        /// <summary>
        /// 四舍五入到个位
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal RoundToBit(this decimal decValue)
        {
            decimal result = 0;
            result = System.Math.Round(decValue, 0);
            return result;
        }

        /// <summary>
        /// 四舍五入保留一位小数
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal RoundToOnePlaces(this decimal decValue)
        {
            if (decValue == 0) return 0;
            decimal result = 0;
            result = System.Math.Round((decValue * 10) / 10 + 0.5M, 1) - 0.5M;
            return result;
        }
        #endregion

        #region 向上取整
        /// <summary>
        /// 向上取整到十位
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal MaxToTen(this decimal decValue)
        {
            if (decValue == 0) return 0;
            decimal result = 0;
            result = System.Math.Ceiling(decValue / 10) * 10;
            return result;
        }
        /// <summary>
        /// 向上取整到个位
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal MaxToBit(this decimal decValue)
        {
            decimal result = 0;
            result = System.Math.Ceiling(decValue);
            return result;
        }
        /// <summary>
        /// 向上取整保留一位小数位数
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal MaxToOnePlaces(this decimal decValue)
        {
            if (decValue == 0) return 0;
            decimal result = 0;
            result = System.Math.Ceiling(decValue * 10) / 10;
            return result;
        }
        #endregion

        #region 向下取整
        /// <summary>
        /// 向上取整到十位
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal MinToTen(this decimal decValue)
        {
            if (decValue == 0) return 0;
            decimal result = 0;
            result = System.Math.Floor(decValue/10) *10;
            return result;
        }
        /// <summary>
        /// 向上取整到个位
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal MinToBit(this decimal decValue)
        {
            decimal result = 0;
            result = System.Math.Floor(decValue);
            return result;
        }
        /// <summary>
        /// 向上取整保留一位小数位数
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal MinToOnePlaces(this decimal decValue)
        {
            if (decValue == 0) return 0;
            decimal result = 0;
            result = System.Math.Floor(decValue * 10) / 10;
            return result;
        }
        #endregion

        #region 银行家舍入法
        /// <summary>
        /// 银行家舍入法到十位
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal BRMToTen(this decimal decValue)
        {
            if (decValue == 0) return 0;
            decimal result = 0;
            result = Math.Round(decValue/10, 0) *10;
            return result;
        }
        /// <summary>
        /// 银行家舍入法到个位
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal BRMToBit(this decimal decValue)
        {
            decimal result = 0;
            result = Math.Round(decValue, 0);
            return result;
        }
        /// <summary>
        /// 银行家舍入法保留一位小数位数
        /// </summary>
        /// <param name="decValue"></param>
        /// <returns></returns>
        public static decimal BRMToOnePlaces(this decimal decValue)
        {
            decimal result = 0;
            result = Math.Round(decValue, 1);
            return result;
        }
        #endregion

        /// <summary>
        /// 获取税额    
        /// 税额=含税收入/（1+x%）*x%
        /// </summary>
        /// <param name="decValue">含税收入</param>
        /// <param name="taxRate">税率</param>
        /// <returns></returns>
        public static decimal GetTaxRateMoney(this decimal decValue, decimal taxRate)
        {
            if (taxRate == 0) return 0;
            return decValue / (1 + taxRate) * taxRate;
        }

        /// <summary>
        /// 获取含税金额
        /// 含税金额=不含税金额+税额 
        /// </summary>
        /// <param name="decValue">不含税金额</param>
        /// <param name="taxRate">税率</param>
        /// <returns></returns>
        public static decimal GetTaxMoney(this decimal decValue,decimal taxRate)
        {
            if(taxRate==0) return decValue;
            return decValue * (1 + taxRate);
        }

        /// <summary>
        ///  获取不含税金额
        ///  不含税金额 = 含税金额/（1+x%）
        /// </summary>
        /// <param name="decValue">含税金额</param>
        /// <param name="taxRate">税率</param>
        /// <returns></returns>
        public static decimal GetNoTaxMoney(this decimal decValue, decimal taxRate)
        {
            if (taxRate == 0) return decValue;
            return decValue / (1 + taxRate);
        }

        /// <summary>
        /// 获取税率
        /// </summary>
        /// <param name="taxMoney">含税金额</param>
        /// <param name="notTaxMoney">不含税金额</param>
        /// <returns></returns>
        public static decimal GetTaxRate(this decimal taxMoney, decimal notTaxMoney)
        {
            if (taxMoney == 0) return 0;
            return taxMoney / notTaxMoney - 1;
        }
    }
}
