namespace Lzw.Common.Extensions
{
    using System;

    public static class DoubleExtension
    {

        /// <summary>
        /// 相加
        /// </summary>
        /// <param name="add1"></param>
        /// <param name="add2"></param>
        /// <returns></returns>
        public static double Add(this double d1, double d2)
        {
            return (double)((decimal)d1 + (decimal)d2);
        }
        /// <summary>
        /// 相减
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static double Sub(this double d1, double d2)
        {
            return (double)((decimal)d1 - (decimal)d2);
        }
        /// <summary>
        /// 相乖
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static double Mul(this double d1, double d2)
        {
            return (double)((decimal)d1 * (decimal)d2);
        }
        /// <summary>
        /// 相除
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static double Div(this double d1, double d2)
        {
            return d2 == 0 ? 0 : (double)((decimal)d1 / (decimal)d2);
        }

        public static double Round(this double value, int decimals)
        {
            if (value < 0)
                return Math.Round(value + 5 / Math.Pow(10, decimals + 1), decimals, MidpointRounding.AwayFromZero);
            else
                return Math.Round(value, decimals, MidpointRounding.AwayFromZero);
        }


        /// <summary>
        /// double转整数，类似四舍五入
        /// </summary>
        /// <param name="value">double</param>
        /// <returns>整数</returns>
        public static int ToInt(this double value)
        {
            return ((decimal)value).ToInt();
        }


        public static string ToIntString(this double value)
        {
            return value.ToString("f0");
        }


        /// <summary>
        /// 小数转评分，如3.6转成4，3.3转成3.5，3转成3
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static double ToScore(this double score)
        {
            var decimalNum = score - (int)score;
            if (0 < decimalNum && decimalNum <= 0.5)
                return ((int)score) + 0.5;
            else if (0 < decimalNum && decimalNum > 0.5)
                return ((int)score) + 1;

            return score;
        }

    }
}

