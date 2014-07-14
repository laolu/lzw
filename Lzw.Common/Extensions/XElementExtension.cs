using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lzw.Common.Extensions
{
    public static class XElementExtension
    {
        /// <summary>
        /// 使用CDATA的方式将value保存在指定的element中
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SetCDataValue(this System.Xml.Linq.XElement element, string value)
        {
            element.RemoveNodes();
            element.Add(new System.Xml.Linq.XCData(value));
        }
    }
}
