namespace Lzw.Common.Extensions
{
    using Lzw.Common.Helper;
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Xml;

    public static class ObjectExtension
    {
        public static bool ToBool(this object obj)
        {
            return ConvertHelper.ObjToBool(obj);
        }

        public static DateTime? ToDateNull(this object obj)
        {
            return ConvertHelper.ObjToDateNull(obj);
        }

        public static decimal ToDecimal(this object obj)
        {
            return ConvertHelper.ObjToDecimal(obj);
        }

        public static decimal? ToDecimalNull(this object obj)
        {
            return ConvertHelper.ObjToDecimalNull(obj);
        }

        public static int ToInt(this object obj)
        {
            return ConvertHelper.ObjToInt(obj);
        }

        public static int? ToIntNull(this object obj)
        {
            return ConvertHelper.ObjToIntNull(obj);
        }

        public static string ToStr(this object obj)
        {
            return ConvertHelper.ObjToStr(obj);
        }

        /// <summary>
        /// 尝试格式化日期字符串
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string DateFormat(this object date, string format = "yyyy/MM/dd")
        {
            if (date == null) { return string.Empty; }
            DateTime d;
            if (!date.ToString().IsDateTime(out d))
            {
                return date.ToString();
            }
            else
            {
                return d.ToString(format);
            }
        }


        /// <summary>
        /// 序列化对象为xml字符串
        /// </summary>
        /// <param name="obj">要序列化的对象</param>
        /// <returns>xml格式字符串</returns>
        public static string Serialize(this object obj)
        {
            if (obj == null) { return ""; }
            Type type = obj.GetType();
            if (type.IsSerializable)
            {
                try
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type);
                    XmlWriterSettings xset = new XmlWriterSettings();
                    xset.CloseOutput = true;
                    xset.Encoding = Encoding.UTF8;
                    xset.Indent = true;
                    xset.CheckCharacters = false;
                    System.Xml.XmlWriter xw = System.Xml.XmlWriter.Create(sb, xset);
                    xs.Serialize(xw, obj);
                    xw.Flush();
                    xw.Close();
                    return sb.ToString();
                }
                catch { return ""; }
            }
            else
            {
                return "";
            }
        }
    }
}

