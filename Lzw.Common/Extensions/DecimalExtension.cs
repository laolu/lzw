namespace Lzw.Common.Extensions
{
    using System;

    public static class DecimalExtension
    {
        /// <summary>
        /// 格式化数字，三位加逗号
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToFormatString(this decimal str)
        {
            string str1 = str.ToString();
            return str1.IndexOf('.') >= 0 ? str.ToString("#,##0" + ".".PadRight(str1.Substring(str1.IndexOf('.')).Length, '0')) : str.ToString("#,##0");
        }

        public static decimal Round(this decimal dec, int decimals = 2)
        {
            return Math.Round(dec, decimals, MidpointRounding.AwayFromZero);
        }
        /// <summary>
        /// 小数转整数，类似四舍五入
        /// </summary>
        /// <param name="value">小数</param>
        /// <returns>整数</returns>
        public static int ToInt(this decimal value)
        {
            var decimalNum = value - (int)value;
            if (decimalNum >= 0.5m)
                return ((int)value) + 1;
            else
                return (int)value;
        }


        public static string ToIntString(this decimal value)
        {
            return value.ToString("f0");
        }



        /// <summary>
        /// 小数转成价格，如3.123123会转成3.12
        /// </summary>
        /// <param name="price"></param>
        /// <param name="format">小数位数格式</param>
        /// <returns></returns>
        public static string ToPrice(this decimal price, string format = "0.00")
        {
            return price.ToString(format);
        }

        /// <summary>
        /// 价格区间，会转成如 200-300
        /// </summary>
        /// <param name="fromPrice"></param>
        /// <param name="toPrice"></param>
        /// <returns></returns>
        public static string ToShortPriceRange(this decimal fromPrice, decimal toPrice)
        {
            if (fromPrice == toPrice)
                return fromPrice.ToShortPrice();
            else
                return string.Format("{0}-{1}", fromPrice.ToShortPrice(), toPrice.ToShortPrice());
        }

        /// <summary>
        /// 转成价格，如200.45将转成200，小于0时将转成"暂无价格"
        /// </summary>
        /// <param name="price"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        public static string ToShortPrice(this decimal price, int decimalPlaces = 0)
        {
            if (price < 0)
                return "暂无价格";
            return price.ToString("f" + decimalPlaces);
        }

        /// <summary>
        /// 转成价格，如"¥200/晚起"
        /// </summary>
        /// <param name="price"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToCnDayPrice(this decimal price, string format = "0.00")
        {
            if (price < 0)
                return "暂无报价";

            return string.Format("&yen;{0}/晚起", price.ToString(format));
        }

        /// <summary>
        /// 转成价格，如"¥200"
        /// </summary>
        /// <param name="price"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToCnPrice(this decimal price, string format = "0.00")
        {
            if (price < 0)
                return "暂无报价";

            return string.Format("&yen;{0}", price.ToString(format));
        }
    }
}

