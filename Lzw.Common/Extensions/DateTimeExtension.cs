namespace Lzw.Common.Extensions
{
    using System;
    using System.Runtime.CompilerServices;

    public static class DateTimeExtension
    {
        public static DateTime ShortDateValue(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        /// <summary>
        /// 返回带星期的日期格式
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToDateWeekString(this DateTime date)
        {
            string week = string.Empty;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Friday: week = "五"; break;
                case DayOfWeek.Monday: week = "一"; break;
                case DayOfWeek.Saturday: week = "六"; break;
                case DayOfWeek.Sunday: week = "日"; break;
                case DayOfWeek.Thursday: week = "四"; break;
                case DayOfWeek.Tuesday: week = "二"; break;
                case DayOfWeek.Wednesday: week = "三"; break;
            }
            return date.ToString("yyyy年M月d日 ") + "星期" + week;
        }
        /// <summary>
        /// 返回带星期的日期时间格式
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToDateTimeWeekString(this DateTime date)
        {
            string week = string.Empty;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Friday: week = "五"; break;
                case DayOfWeek.Monday: week = "一"; break;
                case DayOfWeek.Saturday: week = "六"; break;
                case DayOfWeek.Sunday: week = "日"; break;
                case DayOfWeek.Thursday: week = "四"; break;
                case DayOfWeek.Tuesday: week = "二"; break;
                case DayOfWeek.Wednesday: week = "三"; break;
            }
            return date.ToString("yyyy年M月d日H时m分") + " 星期" + week;
        }


        /// <summary>
        /// 将时间精确到哪个级别
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="cutTicks"></param>
        /// <returns></returns>
        public static DateTime CutOff(this DateTime dateTime, long cutTicks = TimeSpan.TicksPerSecond)
        {
            return new DateTime(dateTime.Ticks - (dateTime.Ticks % cutTicks), dateTime.Kind);
        }

        /// <summary>
        /// 把时间转换成字符串如：2013-8-2
        /// </summary>
        /// <param name="dateTime">DateTime</param>
        /// <returns></returns>
        public static string ToCnDataString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 把时间转换成字符串如：2013-8-2
        /// </summary>
        /// <param name="dateTime">DateTime</param>
        /// <returns></returns>
        public static string ToCnDataString(this DateTime? dateTime)
        {
            return dateTime == null ? string.Empty : dateTime.Value.ToCnDataString();
        }



        /// <summary>
        /// 日期转当前天，跟今天比，如转成“今天”，“昨天”，不符和就转成如“2012-8-2”
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToDay(this DateTime date)
        {
            string s = "";
            var now = DateTime.Now.Day;
            if (now == date.Day)
            {
                s = "今天";
            }
            else if (now - date.Day == 1)
            {
                s = "昨天";
            }
            else
            {
                s = date.ToString("yyyy-MM-dd");
            }
            return s;
        }

        /// <summary>
        /// 日期转星期几，如"星期日", "星期一"
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToWeek(this string date)
        {
            var dayOfWeek = Convert.ToInt32(date.ToDateTime().DayOfWeek);

            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            return weekdays[dayOfWeek];
        }
    }
}

    

