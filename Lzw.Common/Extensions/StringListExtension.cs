using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lzw.Common.Extensions
{
    public static class StringListExtension
    {

        public static string ToString(this IList<string> strList, char split)
        {
            return strList.ToString(split.ToString());
        }

        public static string ToString(this IList<string> strList, string split)
        {
            StringBuilder sb = new StringBuilder(strList.Count * 10);
            for (int i = 0; i < strList.Count; i++)
            {
                sb.Append(strList[i]);
                if (i < strList.Count - 1)
                {
                    sb.Append(split);
                }
            }
            return sb.ToString();
        }
    }
}
