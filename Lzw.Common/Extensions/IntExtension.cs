namespace Lzw.Common.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    public static class IntExtension
    {
        /// <summary>
        /// 判断一个整型是否包含在指定的值内
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool In(this int i, params int[] ints)
        {
            foreach (int k in ints)
            {
                if (i == k)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

