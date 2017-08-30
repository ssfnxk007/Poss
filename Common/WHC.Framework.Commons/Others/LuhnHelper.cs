using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WHC.Framework.Commons
{
   public static class LuhnHelper
    {

        /// <summary>
        /// Luhn计算模10“隔位2倍加”校验数字
        /// </summary>
        /// <param name="numberString">numberString</param>
        /// <returns></returns>
        public  static string  GetLuhnVerifyCode(this string numberString)
        {
            bool valid = isValidNumberString(numberString);
            if (valid == false) throw new ArgumentException("Invalid parameter.", "numberString");

            int sum = getMod10Compartment2Sum(numberString);
            return (sum % 10 == 0 ? 0 : 10 - sum % 10).ToString();
        }
        /// <summary>
        /// 按 Luhn计算模10“隔位2倍加”的算法来检验一个数字串的正确性
        /// </summary>
        /// <param name="numberStringWithCheckDigit">numberStringWithCheckDigit</param>
        /// <returns></returns>
        public static bool IsValidForLuhn(this string numberStringWithCheckDigit)
        {
            bool valid = isValidNumberString(numberStringWithCheckDigit);
            if (valid == false) throw new ArgumentException("Invalid parameter.", "numberStringWithCheckDigit");

            string checkDigit =(numberStringWithCheckDigit.Substring(0, numberStringWithCheckDigit.Length - 1).GetLuhnVerifyCode());
            string lastDigit =(numberStringWithCheckDigit[numberStringWithCheckDigit.Length - 1]).ToString();
            return lastDigit == checkDigit;
        }
        /// <summary>
        /// 计算数值的数字和
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static int getDigitsSum(int number)
        {
            int sum = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                sum += Convert.ToInt16(number.ToString()[i].ToString());
            }

            return sum;
        }
        /// <summary>
        /// 计算模10“隔位2倍加”的和
        /// </summary>
        /// <param name="numberString">numberString</param>
        /// <returns></returns>
        private static int getMod10Compartment2Sum(string numberString)
        {
            int sum = 0;
            for (int i = 0; i < numberString.Length; i++)
            {
                int index = numberString.Length - i - 1;
                if (i % 2 == 1) sum += Convert.ToInt16(numberString[index].ToString());
                else sum += getDigitsSum(Convert.ToInt16(numberString[index].ToString()) * 2);
            }

            return sum;
        }
        /// <summary>
        /// 检查输入的数字串是否合法
        /// </summary>
        /// <param name="numberString">numberString</param>
        /// <returns></returns>
        private static bool isValidNumberString(string numberString)
        {
            if (string.IsNullOrEmpty(numberString))
            {
                return false;
            }

            string regextext = @"^[0-9]+$";
            Regex regex = new Regex(regextext, RegexOptions.None);
            return regex.IsMatch(numberString.Trim());
        }
    }
}
