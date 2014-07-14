namespace Lzw.Common.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    public static class ArrayExtension
    {
        public static bool In(this string str, params string[] args)
        {
            foreach (string str2 in args)
            {
                if (str2.Equals(str))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool In<T>(this T t, IEnumerable<T> enumerable)
        {
            return enumerable.Contains<T>(t);
        }

        /// <summary>
        /// 将数组转换为符号分隔的字符串
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="split">分隔符</param>
        /// <returns></returns>
        public static string Join<T>(this T[] arr, string split = ",")
        {
            StringBuilder sb = new StringBuilder(arr.Length * 36);
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i].ToString());
                if (i < arr.Length - 1)
                {
                    sb.Append(split);
                }
            }
            return sb.ToString();
        }
    }
}

