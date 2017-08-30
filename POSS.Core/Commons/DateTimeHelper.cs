using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Globalization;
using WHC.Framework.Commons;
using POSS;
namespace POSS
{
    /// <summary>
    /// 时间相关操作辅助类库
    /// </summary>
    public class DateTimeHelper
    {
        private DateTime dt = DateTime.Now;

        /// <summary>
        /// 获取某一年有多少周
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>该年周数</returns>
        public static int GetWeekAmount(int year)
        {
            var end = new DateTime(year, 12, 31); //该年最后一天
            var gc = new GregorianCalendar();
            return gc.GetWeekOfYear(end, CalendarWeekRule.FirstDay, DayOfWeek.Monday); //该年星期数
        }

        /// <summary>
        /// 返回年度第几个星期   默认星期日是第一天
        /// </summary>
        /// <param name="date">时间</param>
        /// <returns></returns>
        public static int WeekOfYear(DateTime date)
        {
            System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar();
            return gc.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }

        /// <summary>
        /// 返回年度第几个星期
        /// </summary>
        /// <param name="date">时间</param>
        /// <param name="week">一周的开始日期</param>
        /// <returns></returns>
        public static int WeekOfYear(DateTime date, DayOfWeek week)
        {
            System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar();
            return gc.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstDay, week);
        }


        /// <summary>
        /// 得到一年中的某周的起始日和截止日
        /// 年 nYear
        /// 周数 nNumWeek
        /// 周始 out dtWeekStart
        /// 周终 out dtWeekeEnd
        /// </summary>
        /// <param name="nYear">年份</param>
        /// <param name="nNumWeek">第几周</param>
        /// <param name="dtWeekStart">开始日期</param>
        /// <param name="dtWeekeEnd">结束日期</param>
        public static void GetWeekTime(int nYear, int nNumWeek, out DateTime dtWeekStart, out DateTime dtWeekeEnd)
        {
            DateTime dt = new DateTime(nYear, 1, 1);
            dt = dt + new TimeSpan((nNumWeek - 1) * 7, 0, 0, 0);
            dtWeekStart = dt.AddDays(-(int)dt.DayOfWeek + (int)DayOfWeek.Monday);
            dtWeekeEnd = dt.AddDays((int)DayOfWeek.Saturday - (int)dt.DayOfWeek + 1);
        }

        /// <summary>
        /// 得到一年中的某周的起始日和截止日    周一到周五  工作日
        /// </summary>
        /// <param name="nYear">年份</param>
        /// <param name="nNumWeek">第几周</param>
        /// <param name="dtWeekStart">开始日期</param>
        /// <param name="dtWeekeEnd">结束日期</param>
        public static void GetWeekWorkTime(int nYear, int nNumWeek, out DateTime dtWeekStart, out DateTime dtWeekeEnd)
        {
            DateTime dt = new DateTime(nYear, 1, 1);
            dt = dt + new TimeSpan((nNumWeek - 1) * 7, 0, 0, 0);
            dtWeekStart = dt.AddDays(-(int)dt.DayOfWeek + (int)DayOfWeek.Monday);
            dtWeekeEnd = dt.AddDays((int)DayOfWeek.Saturday - (int)dt.DayOfWeek + 1).AddDays(-2);
        }

        #region P/Invoke 设置本地时间

        [DllImport("kernel32.dll")]
        private static extern bool SetLocalTime(ref SYSTEMTIME time);

        [StructLayout(LayoutKind.Sequential)]
        private struct SYSTEMTIME
        {
            public short year;
            public short month;
            public short dayOfWeek;
            public short day;
            public short hour;
            public short minute;
            public short second;
            public short milliseconds;
        }

        /// <summary>
        /// 设置本地计算机时间
        /// </summary>
        /// <param name="dt">DateTime对象</param>
        public static void SetLocalTime(DateTime dt)
        {
            SYSTEMTIME st;

            st.year = (short)dt.Year;
            st.month = (short)dt.Month;
            st.dayOfWeek = (short)dt.DayOfWeek;
            st.day = (short)dt.Day;
            st.hour = (short)dt.Hour;
            st.minute = (short)dt.Minute;
            st.second = (short)dt.Second;
            st.milliseconds = (short)dt.Millisecond;

            SetLocalTime(ref st);
        }

        #endregion

        #region 获取网络时间
        /// <summary>
        /// 获取中国国家授时中心网络服务器时间发布的当前时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetChineseDateTime()
        {
            DateTime res = DateTime.MinValue;
            try
            {
                string url = "http://www.time.ac.cn/stime.asp";
                HttpHelper helper = new HttpHelper();
                helper.Encoding = Encoding.Default;
                string html = helper.GetHtml(url);
                string patDt = @"\d{4}年\d{1,2}月\d{1,2}日";
                string patHr = @"hrs\s+=\s+\d{1,2}";
                string patMn = @"min\s+=\s+\d{1,2}";
                string patSc = @"sec\s+=\s+\d{1,2}";
                Regex regDt = new Regex(patDt);
                Regex regHr = new Regex(patHr);
                Regex regMn = new Regex(patMn);
                Regex regSc = new Regex(patSc);

                res = DateTime.Parse(regDt.Match(html).Value);
                int hr = GetInt(regHr.Match(html).Value, false);
                int mn = GetInt(regMn.Match(html).Value, false);
                int sc = GetInt(regSc.Match(html).Value, false);
                res = res.AddHours(hr).AddMinutes(mn).AddSeconds(sc);
            }
            catch { }
            return res;
        }

        /// <summary>
        /// 从指定的字符串中获取整数
        /// </summary>
        /// <param name="origin">原始的字符串</param>
        /// <param name="fullMatch">是否完全匹配，若为false，则返回字符串中的第一个整数数字</param>
        /// <returns>整数数字</returns>
        private static int GetInt(string origin, bool fullMatch)
        {
            if (string.IsNullOrEmpty(origin))
            {
                return 0;
            }
            origin = origin.Trim();
            if (!fullMatch)
            {
                string pat = @"-?\d+";
                Regex reg = new Regex(pat);
                origin = reg.Match(origin.Trim()).Value;
            }
            int res = 0;
            int.TryParse(origin, out res);
            return res;
        }
        #endregion

        #region 类实例方法
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public DateTimeHelper()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dateTime">时间</param>
        public DateTimeHelper(DateTime dateTime)
        {
            dt = dateTime;
        }

        /// <summary>
        /// 构造函数（字符窜时间）
        /// </summary>
        /// <param name="dateTime">时间</param>
        public DateTimeHelper(string dateTime)
        {
            dt = DateTime.Parse(dateTime);
        }

        /// <summary>
        /// 基于给定（或当前）日期的偏移日期
        /// </summary>
        /// <param name="days">7天前:-7 7天后:+7</param>
        /// <returns></returns>
        public string GetTheDay(int? days)
        {
            int day = days ?? 0;
            return dt.AddDays(day).ToShortDateString();
        }

        /// <summary>
        /// 周日
        /// </summary>
        /// <param name="weeks">上周-1 下周+1 本周0</param>
        /// <returns></returns>
        public string GetSunday(int? weeks)
        {
            int week = weeks ?? 0;
            return dt.AddDays(Convert.ToDouble((0 - Convert.ToInt16(dt.DayOfWeek))) + 7 * week).ToShortDateString();
        }

        /// <summary>
        /// 周六
        /// </summary>
        /// <param name="weeks">上周-1 下周+1 本周0</param>
        /// <returns></returns>
        public string GetSaturday(int? weeks)
        {
            int week = weeks ?? 0;
            return dt.AddDays(Convert.ToDouble((6 - Convert.ToInt16(dt.DayOfWeek))) + 7 * week).ToShortDateString();
        }

        /// <summary>
        /// 月第一天
        /// </summary>
        /// <param name="months">上月-1 本月0 下月1</param>
        /// <returns></returns>
        public string GetFirstDayOfMonth(int? months)
        {
            int month = months ?? 0;
            return DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(month).ToShortDateString();
        }

        /// <summary>
        /// 月最后一天
        /// </summary>
        /// <param name="months">上月0 本月1 下月2</param>
        /// <returns></returns>
        public string GetLastDayOfMonth(int? months)
        {
            int month = months ?? 0;
            return DateTime.Parse(dt.ToString("yyyy-MM-01")).AddMonths(month).AddDays(-1).ToShortDateString();
        }

        /// <summary>
        /// 年度第一天
        /// </summary>
        /// <param name="years">上年度-1 下年度+1</param>
        /// <returns></returns>
        public string GetFirstDayOfYear(int? years)
        {
            int year = years ?? 0;
            return DateTime.Parse(dt.ToString("yyyy-01-01")).AddYears(year).ToShortDateString();
        }

        /// <summary>
        /// 年度最后一天
        /// </summary>
        /// <param name="years">上年度0 本年度1 下年度2</param>
        /// <returns></returns>
        public string GetLastDayOfYear(int? years)
        {
            int year = years ?? 0;
            return DateTime.Parse(dt.ToString("yyyy-01-01")).AddYears(year).AddDays(-1).ToShortDateString();
        }

        /// <summary>
        /// 季度第一天
        /// </summary>
        /// <param name="quarters">上季度-1 下季度+1</param>
        /// <returns></returns>
        public string GetFirstDayOfQuarter(int? quarters)
        {
            int quarter = quarters ?? 0;
            return dt.AddMonths(quarter * 3 - ((dt.Month - 1) % 3)).ToString("yyyy-MM-01");
        }

        /// <summary>
        /// 季度最后一天
        /// </summary>
        /// <param name="quarters">上季度0 本季度1 下季度2</param>
        /// <returns></returns>
        public string GetLastDayOfQuarter(int? quarters)
        {
            int quarter = quarters ?? 0;
            return DateTime.Parse(dt.AddMonths(quarter * 3 - ((dt.Month - 1) % 3)).ToString("yyyy-MM-01")).AddDays(-1).ToShortDateString();
        }

        /// <summary>
        /// 中文星期
        /// </summary>
        /// <returns></returns>
        public string GetDayOfWeekCN()
        {
            string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            return Day[Convert.ToInt16(dt.DayOfWeek)];
        }

        /// <summary>
        /// 获取星期数字形式,周一开始
        /// </summary>
        /// <returns></returns>
        public int GetDayOfWeekNum()
        {
            int day = (Convert.ToInt16(dt.DayOfWeek) == 0) ? 7 : Convert.ToInt16(dt.DayOfWeek);
            return day;
        }

        /// <summary>
        /// 获取一个日期的第n周在一个月的Day
        /// </summary>
        /// <param name="theWeek">第n周，如果数字大于当月的周数，则取最后一周</param>
        /// <returns></returns>
        public int GetWeekStartDayOfMonth(int theWeek)
        {
            DateTime d = new DateTime(dt.Year, dt.Month, 1);
            int days = GetDaysOfMonth(dt.Year, dt.Month);
            int dayOffset =((Convert.ToInt16(d.DayOfWeek) == 0) ? 7 : Convert.ToInt16(d.DayOfWeek));
            if (theWeek <= 0 || theWeek == 1)//第1周
            {
                return dayOffset == 1 ? 1: 9 - dayOffset;
            }
            else if (theWeek == 2)//第2周
            {
                return (dayOffset == 1 ? 1 : 9 - dayOffset) + 7;
            }
            else if (theWeek == 3)//第3周
            {
                return (dayOffset == 1 ? 1 : 9 - dayOffset) + 7 * 2;
            }
            else if (theWeek == 4 && ((dayOffset == 1 ? 1 : 9 - dayOffset) + 7 * 3) >= days)//第4周
            {
                return (dayOffset == 1 ? 1 : 9 - dayOffset) + 7 * 2;
            }
            else if (theWeek == 4 && ((dayOffset == 1 ? 1 : 9 - dayOffset) + 7 * 3) <= days)
            {
                return (dayOffset == 1 ? 1 : 9 - dayOffset) + 7 * 3;
            }
            else if (theWeek > 4 && ((dayOffset == 1 ? 1 : 9 - dayOffset) + 7 * 4) <= days)
            {
                return (dayOffset == 1 ? 1 : 9 - dayOffset) + 7 * 4;
            }
            else
            {
                return (dayOffset == 1 ? 1 : 9 - dayOffset) + 7 * 3;
            }
           
        }

        /// <summary>
        /// 获取一个月有多少天
        /// </summary>
        /// <returns></returns>
        public int GetDaysOfMonth(int year,int month)
        {
            DateTime d = new DateTime(year, month, 1);
            TimeSpan tt = d.AddMonths(1) - d;
            return tt.Days;
        }

        #endregion

        #region 其他转换静态方法

        /// <summary>
        /// C#的时间到Javascript的时间的转换
        /// </summary>
        /// <param name="TheDate"></param>
        /// <returns></returns>
        public static long ConvertTimeToJS(DateTime TheDate)
        {
            //string time = (System.DateTime.Now.Subtract(Convert.ToDateTime("1970-01-01 8:0:0"))).TotalMilliseconds.ToString();
            //long d = MilliTimeStamp(DateTime.Now);

            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = TheDate.ToUniversalTime();
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            return (long)ts.TotalMilliseconds;
        }

        /// <summary>
        /// PHP的时间转换成C#中的DateTime
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static DateTime ConvertPHPToTime(long time)
        {
            DateTime timeStamp = new DateTime(1970, 1, 1);  //得到1970年的时间戳
            long t = (time + 8 * 60 * 60) * 10000000 + timeStamp.Ticks;
            DateTime dt = new DateTime(t);
            return dt;
        }

        /// <summary>
        ///  C#中的DateTime转换成PHP的时间
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ConvertTimeToPHP(DateTime time)
        {
            DateTime timeStamp = new DateTime(1970, 1, 1);  //得到1970年的时间戳
            long a = (DateTime.UtcNow.Ticks - timeStamp.Ticks) / 10000000;  //注意这里有时区问题，用now就要减掉8个小时
            return a;
        }

        /// <summary>
        /// 获取两个时间的时间差
        /// </summary>
        /// <param name="beginTime">开始时间</param>
        /// <param name="enddate">结束时间</param>
        /// <returns></returns>
        public static string GetDiffTime(DateTime beginTime, DateTime enddate)
        {
            int i = 0;
            return GetDiffTime(beginTime, enddate, ref i);
        }

        /// <summary>
        /// 计算2个时间差
        /// </summary>
        /// <param name="beginTime">开始时间</param>
        /// <param name="enddate">结束时间</param>
        /// <param name="mindTime">提醒时间</param>
        /// <returns></returns>
        public static string GetDiffTime(DateTime beginTime, DateTime enddate, ref int mindTime)
        {
            string strResout = string.Empty;
            //获得2时间的时间间隔秒计算
            //TimeSpan span = enddate - beginTime;
            TimeSpan span = enddate.Subtract(beginTime);

            int iTatol = Convert.ToInt32(span.TotalSeconds);
            int iMinutes = 1 * 60;
            int iHours = iMinutes * 60;
            int iDay = iHours * 24;
            int iMonth = iDay * 30;
            int iYear = iMonth * 12;

            //提醒时间,到了返回1,否则返回0
            if (mindTime > iTatol && iTatol > 0)
            {
                mindTime = 1;
            }
            else
            {
                mindTime = 0;
            }

            if (iTatol > iYear)
            {
                strResout += iTatol / iYear + "年";
                iTatol = iTatol % iYear;//剩余
            }
            if (iTatol > iMonth)
            {
                strResout += iTatol / iMonth + "月";
                iTatol = iTatol % iMonth;
            }
            if (iTatol > iDay)
            {
                strResout += iTatol / iDay + "天";
                iTatol = iTatol % iDay;

            }
            if (iTatol > iHours)
            {
                strResout += iTatol / iHours + "小时";
                iTatol = iTatol % iHours;
            }
            if (iTatol > iMinutes)
            {
                strResout += iTatol / iMinutes + "分";
                iTatol = iTatol % iMinutes;
            }
            strResout += iTatol + "秒";

            return strResout;
        }

        /// <summary>
        /// 获得两个日期的间隔
        /// </summary>
        /// <param name="DateTime1">日期一。</param>
        /// <param name="DateTime2">日期二。</param>
        /// <returns>日期间隔TimeSpan。</returns>
        public static TimeSpan GetDiffTime2(DateTime DateTime1, DateTime DateTime2)
        {
            TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
            TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            return ts;
        }

        /// <summary>
        /// 得到随机日期
        /// </summary>
        /// <param name="time1">起始日期</param>
        /// <param name="time2">结束日期</param>
        /// <returns>间隔日期之间的 随机日期</returns>
        public static DateTime GetRandomTime(DateTime time1, DateTime time2)
        {
            Random random = new Random();
            DateTime minTime = new DateTime();
            DateTime maxTime = new DateTime();

            System.TimeSpan ts = new System.TimeSpan(time1.Ticks - time2.Ticks);

            // 获取两个时间相隔的秒数
            double dTotalSecontds = ts.TotalSeconds;
            int iTotalSecontds = 0;

            if (dTotalSecontds > System.Int32.MaxValue)
            {
                iTotalSecontds = System.Int32.MaxValue;
            }
            else if (dTotalSecontds < System.Int32.MinValue)
            {
                iTotalSecontds = System.Int32.MinValue;
            }
            else
            {
                iTotalSecontds = (int)dTotalSecontds;
            }

            if (iTotalSecontds > 0)
            {
                minTime = time2;
                maxTime = time1;
            }
            else if (iTotalSecontds < 0)
            {
                minTime = time1;
                maxTime = time2;
            }
            else
            {
                return time1;
            }

            int maxValue = iTotalSecontds;

            if (iTotalSecontds <= System.Int32.MinValue)
                maxValue = System.Int32.MinValue + 1;

            int i = random.Next(System.Math.Abs(maxValue));
            return minTime.AddSeconds(i);
        }

        #endregion

        #region 日期控件
        /// <summary>
        /// 前一天
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues YesterDay()
        {
            DateTimeValues value = new DateTimeValues();
            value.StartDateTime = DateTime.Today.AddDays(-1).ToShortDateString().ToDateTime();
            value.EndDateTime = (DateTime.Today.AddDays(-1).ToShortDateString() + " 23:59:59").ToDateTime();

            return value;
        }

        /// <summary>
        /// 今天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTimeValues Today()
        {
            DateTimeValues value = new DateTimeValues();
            value.StartDateTime = DateTime.Today.ToShortDateString().ToDateTime();
            value.EndDateTime = (DateTime.Today.ToShortDateString() + " 23:59:59").ToDateTime();

            return value;
        }

        /// <summary>
        /// 本周
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues ThisWeek()
        {
            DateTimeValues value = new DateTimeValues();
            int iSub = 0;
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    iSub = 0;
                    break;
                case DayOfWeek.Tuesday:
                    iSub = 1;
                    break;
                case DayOfWeek.Wednesday:
                    iSub = 2;
                    break;
                case DayOfWeek.Thursday:
                    iSub = 3;
                    break;
                case DayOfWeek.Friday:
                    iSub = 4;
                    break;
                case DayOfWeek.Saturday:
                    iSub = 5;
                    break;
                case DayOfWeek.Sunday:
                    iSub = 6;
                    break;
                default:
                    iSub = 0;
                    break;
            }
            value.StartDateTime = DateTime.Now.AddDays(-(iSub + 1)).ToShortDateString().ToDateTime();
            value.EndDateTime = (DateTime.Now.ToShortDateString() + " 23:59:59").ToDateTime();

            return value;
        }

        /// <summary>
        /// 本月
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues ThisMonth()
        {
            DateTimeValues value = new DateTimeValues();
            int iSub = DateTime.Now.Day;
            value.StartDateTime = DateTime.Now.AddDays(-iSub + 1).ToShortDateString().ToDateTime();
            value.EndDateTime= (DateTime.Now.ToShortDateString() + " 23:59:59").ToDateTime();
            return value;
        }

        /// <summary>
        /// 当年
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues ThisYear()
        {
            DateTimeValues value = new DateTimeValues();
            int NowMonth = DateTime.Now.Month;
            int NowDay = DateTime.Now.Day;
            value.EndDateTime = (DateTime.Now.ToShortDateString() + " 23:59:59").ToDateTime();
            value.StartDateTime= DateTime.Now.AddDays(1 - NowDay).AddMonths(1 - NowMonth).ToShortDateString().ToDateTime();
            return value;
        }

        /// <summary>
        /// 近一周
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues NearWeek()
        {
            DateTimeValues value = new DateTimeValues();
         value.StartDateTime = DateTime.Now.AddDays(-7).ToShortDateString().ToDateTime();
            value.EndDateTime = (DateTime.Now.ToShortDateString() + " 23:59:59").ToDateTime();
            return value;
        }

        /// <summary>
        /// 近一月
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues NearMonth()
        {
            DateTimeValues value = new DateTimeValues();
            value.StartDateTime = DateTime.Now.AddMonths(-1).ToShortDateString().ToDateTime();
            value.EndDateTime = (DateTime.Now.ToShortDateString() + " 23:59:59").ToDateTime();
            return value;
        }

        /// <summary>
        /// 近一年
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues NearYear()
        {
            DateTimeValues value = new DateTimeValues();
            value.StartDateTime = DateTime.Now.AddYears(-1).ToShortDateString().ToDateTime();
            value.EndDateTime = (DateTime.Now.ToShortDateString() + " 23:59:59").ToDateTime();
            return value;
        }

        /// <summary>
        /// 上一周
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues LastWeek()
        {
            DateTimeValues value = new DateTimeValues();
            int iSub = 0;
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    iSub = 0;
                    break;
                case DayOfWeek.Tuesday:
                    iSub = 1;
                    break;
                case DayOfWeek.Wednesday:
                    iSub = 2;
                    break;
                case DayOfWeek.Thursday:
                    iSub = 3;
                    break;
                case DayOfWeek.Friday:
                    iSub = 4;
                    break;
                case DayOfWeek.Saturday:
                    iSub = 5;
                    break;
                case DayOfWeek.Sunday:
                    iSub = 6;
                    break;
                default:
                    iSub = 0;
                    break;
            }
            value.StartDateTime = DateTime.Now.Date.AddDays(-(iSub + 7));
            value.EndDateTime = (DateTime.Now.Date.AddDays((6 - iSub - 7)).ToShortDateString() + " 23:59:59").ToDateTime();
            return value;
        }

        /// <summary>
        /// 上一月
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues LastMonth()
        {
            DateTimeValues value = new DateTimeValues();
            int iSub = DateTime.Now.AddMonths(-1).Day;
            int iDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.AddMonths(-1).Month);
            value.StartDateTime = DateTime.Today.AddMonths(-1).AddDays(-(iSub - 1)).ToString().ToDateTime();
            value.EndDateTime = (DateTime.Today.AddMonths(-1).AddDays(iDays - iSub).ToShortDateString() + " 23:59:59").ToDateTime();
            return value;
        }

        /// <summary>
        /// 上一年
        /// </summary>
        /// <returns></returns>
        public static DateTimeValues LastYear()
        {
            DateTimeValues value = new DateTimeValues();
            int iSub = DateTime.Now.AddYears(-1).DayOfYear;
            value.StartDateTime = DateTime.Now.AddYears(-1).AddDays(-(iSub - 1)).ToShortDateString().ToDateTime();
            value.EndDateTime = DateTime.Parse(DateTime.Today.AddYears(-1).Year.ToString() + "-12-31 23:59:59").ToString().ToDateTime();
            return value;
        }
        #endregion
    }
}
