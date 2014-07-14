namespace Lzw.Common.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    public static class StringExtension
    {
        private static readonly Regex NameExpression = new Regex("([A-Z]+(?=$|[A-Z][a-z])|[A-Z]?[a-z]+)", RegexOptions.Compiled);

        public static string Add(this string str, string addString)
        {
            if (!str.IsNullOrEmpty())
            {
                return (str + addString);
            }
            return "";
        }

        public static bool EqualsTo(this string str, string to)
        {
            return str.EqualsTo(to, false);
        }

        public static bool EqualsTo(this string str, string to, bool ignoreCase)
        {
            return (string.Compare(str, to, ignoreCase) == 0);
        }

        public static string FormatWith(this string instance, params object[] args)
        {
            return string.Format(instance, args);
        }

        public static bool HasValue(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrEmpty(this string instance)
        {
            return string.IsNullOrEmpty(instance);
        }

        public static string[] Split(this string str, string splitString)
        {
            return str.Split(new string[] { splitString }, StringSplitOptions.None);
        }

        public static string ToTitleCase(this string value)
        {
            if (value.IsNullOrEmpty())
            {
                return value;
            }
            if (value.Length == 1)
            {
                return value.ToUpper();
            }
            return (value.Substring(0, 1).ToUpper() + value.Substring(1));
        }

        public static string ToVariableCase(this string value)
        {
            if (value.IsNullOrEmpty())
            {
                return value;
            }
            if (value.Length == 1)
            {
                return value.ToLower();
            }
            return (value.Substring(0, 1).ToLower() + value.Substring(1));
        }


        /// <summary>
        /// 去除所有空格
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveSpace(this string str)
        {
            if (str.IsNullOrEmpty()) return "";
            return str.Replace("", " ").Replace("\r", "").Replace("\n", "");
        }

        /// <summary>
        /// 返回值或DBNull.Value
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static object DBValueOrNull(this string str)
        {
            if (str.IsNullOrEmpty())
            {
                return null;
            }
            else
            {
                return str;
            }
        }

        #region IS 判断

        public static bool IsUrl(this string str)
        {
            if (str.IsNullOrEmpty())
                return false;
            string pattern = @"^(http|https|ftp|rtsp|mms):(\/\/|\\\\)[A-Za-z0-9%\-_@]+\.[A-Za-z0-9%\-_@]+[A-Za-z0-9\.\/=\?%\-&_~`@:\+!;]*$";
            return Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase);
        }

        public static bool IsEmail(this string str)
        {
            return Regex.IsMatch(str, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public static bool IsDecimal(this string str)
        {
            decimal test;
            return decimal.TryParse(str, out test);
        }
        public static bool IsDecimal(this string str, out decimal test)
        {
            return decimal.TryParse(str, out test);
        }

        public static bool IsDouble(this string str)
        {
            double test;
            return double.TryParse(str, out test);
        }
        public static bool IsDouble(this string str, out double test)
        {
            return double.TryParse(str, out test);
        }
        public static bool IsInt(this string str)
        {
            int test;
            return int.TryParse(str, out test);
        }
        public static bool IsInt(this string str, out int test)
        {
            return int.TryParse(str, out test);
        }

        public static bool IsLong(this string str)
        {
            long test;
            return long.TryParse(str, out test);
        }
        public static bool IsLong(this string str, out long test)
        {
            return long.TryParse(str, out test);
        }

        public static bool IsDateTime(this string str)
        {
            DateTime test;
            return DateTime.TryParse(str, out test);
        }
        public static bool IsDateTime(this string str, out DateTime test)
        {
            return DateTime.TryParse(str, out test);
        }

        public static bool IsGuid(this string str)
        {
            Guid test;
            return Guid.TryParse(str, out test);
        }
        public static bool IsGuid(this string str, out Guid test)
        {
            return Guid.TryParse(str, out test);
        } 
        #endregion



        #region TO 类型转换

        public static decimal ToDecimal(this string str, int decimals)
        {
            decimal test;
            return decimal.TryParse(str, out test) ? decimal.Round(test, decimals, MidpointRounding.AwayFromZero) : 0;
        }
        public static decimal ToDecimal(this string str)
        {
            decimal test;
            return decimal.TryParse(str, out test) ? test : 0;
        }
        public static double ToDouble(this string str, int digits)
        {
            double test;
            return double.TryParse(str, out test) ? test.Round(digits) : 0;
        }
        public static double ToDouble(this string str)
        {
            double test;
            return double.TryParse(str, out test) ? test : 0;
        }

        public static short ToShort(this string str)
        {
            short test;
            short.TryParse(str, out test);
            return test;
        }
        public static int? ToIntOrNull(this string str)
        {
            int test;
            if (int.TryParse(str, out test))
            {
                return test;
            }
            else
            {
                return null;
            }
        }
        public static int ToInt(this string str)
        {
            int test;
            int.TryParse(str, out test);
            return test;
        }
        public static int ToInt(this string str, int defaultValue=0)
        {
            int test;
            return int.TryParse(str, out test) ? test : defaultValue;
        }

        public static long ToLong(this string str)
        {
            long test;
            long.TryParse(str, out test);
            return test;
        }
        public static Int16 ToInt16(this string str)
        {
            Int16 test;
            Int16.TryParse(str, out test);
            return test;
        }
        public static Int32 ToInt32(this string str)
        {
            Int32 test;
            Int32.TryParse(str, out test);
            return test;
        }
        public static Int64 ToInt64(this string str)
        {
            Int64 test;
            Int64.TryParse(str, out test);
            return test;
        }

        public static DateTime ToDateTime(this string str)
        {
            DateTime test;
            DateTime.TryParse(str, out test);
            return test;
        }
        public static DateTime? ToDateTimeOrNull(this string str)
        {
            DateTime test;
            if (DateTime.TryParse(str, out test))
            {
                return test;
            }
            return null;
        }

        /// <summary>
        /// 尝试转换为Boolean类型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ToBoolean(this string str)
        {
            bool b;
            return Boolean.TryParse(str, out b) ? b : false;
        } 
        #endregion



        /// <summary>
        /// 过滤sql
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceSql(this string str)
        {
            str = str.Replace("'", "").Replace("--", " ").Replace(";", "");
            return str;
        }


        /// <summary>
        /// 中文全拼
        /// </summary>
        public static string ToQuanPin(this string x)
        {

            int[] iA = new int[]

             {

                 -20319 ,-20317 ,-20304 ,-20295 ,-20292 ,-20283 ,-20265 ,-20257 ,-20242 ,-20230

                 ,-20051 ,-20036 ,-20032 ,-20026 ,-20002 ,-19990 ,-19986 ,-19982 ,-19976 ,-19805

                 ,-19784 ,-19775 ,-19774 ,-19763 ,-19756 ,-19751 ,-19746 ,-19741 ,-19739 ,-19728

                 ,-19725 ,-19715 ,-19540 ,-19531 ,-19525 ,-19515 ,-19500 ,-19484 ,-19479 ,-19467

                 ,-19289 ,-19288 ,-19281 ,-19275 ,-19270 ,-19263 ,-19261 ,-19249 ,-19243 ,-19242

                 ,-19238 ,-19235 ,-19227 ,-19224 ,-19218 ,-19212 ,-19038 ,-19023 ,-19018 ,-19006

                 ,-19003 ,-18996 ,-18977 ,-18961 ,-18952 ,-18783 ,-18774 ,-18773 ,-18763 ,-18756

                 ,-18741 ,-18735 ,-18731 ,-18722 ,-18710 ,-18697 ,-18696 ,-18526 ,-18518 ,-18501

                 ,-18490 ,-18478 ,-18463 ,-18448 ,-18447 ,-18446 ,-18239 ,-18237 ,-18231 ,-18220

                 ,-18211 ,-18201 ,-18184 ,-18183 ,-18181 ,-18012 ,-17997 ,-17988 ,-17970 ,-17964

                 ,-17961 ,-17950 ,-17947 ,-17931 ,-17928 ,-17922 ,-17759 ,-17752 ,-17733 ,-17730

                 ,-17721 ,-17703 ,-17701 ,-17697 ,-17692 ,-17683 ,-17676 ,-17496 ,-17487 ,-17482

                 ,-17468 ,-17454 ,-17433 ,-17427 ,-17417 ,-17202 ,-17185 ,-16983 ,-16970 ,-16942

                 ,-16915 ,-16733 ,-16708 ,-16706 ,-16689 ,-16664 ,-16657 ,-16647 ,-16474 ,-16470

                 ,-16465 ,-16459 ,-16452 ,-16448 ,-16433 ,-16429 ,-16427 ,-16423 ,-16419 ,-16412

                 ,-16407 ,-16403 ,-16401 ,-16393 ,-16220 ,-16216 ,-16212 ,-16205 ,-16202 ,-16187

                 ,-16180 ,-16171 ,-16169 ,-16158 ,-16155 ,-15959 ,-15958 ,-15944 ,-15933 ,-15920

                 ,-15915 ,-15903 ,-15889 ,-15878 ,-15707 ,-15701 ,-15681 ,-15667 ,-15661 ,-15659

                 ,-15652 ,-15640 ,-15631 ,-15625 ,-15454 ,-15448 ,-15436 ,-15435 ,-15419 ,-15416

                 ,-15408 ,-15394 ,-15385 ,-15377 ,-15375 ,-15369 ,-15363 ,-15362 ,-15183 ,-15180

                 ,-15165 ,-15158 ,-15153 ,-15150 ,-15149 ,-15144 ,-15143 ,-15141 ,-15140 ,-15139

                 ,-15128 ,-15121 ,-15119 ,-15117 ,-15110 ,-15109 ,-14941 ,-14937 ,-14933 ,-14930

                 ,-14929 ,-14928 ,-14926 ,-14922 ,-14921 ,-14914 ,-14908 ,-14902 ,-14894 ,-14889

                 ,-14882 ,-14873 ,-14871 ,-14857 ,-14678 ,-14674 ,-14670 ,-14668 ,-14663 ,-14654

                 ,-14645 ,-14630 ,-14594 ,-14429 ,-14407 ,-14399 ,-14384 ,-14379 ,-14368 ,-14355

                 ,-14353 ,-14345 ,-14170 ,-14159 ,-14151 ,-14149 ,-14145 ,-14140 ,-14137 ,-14135

                 ,-14125 ,-14123 ,-14122 ,-14112 ,-14109 ,-14099 ,-14097 ,-14094 ,-14092 ,-14090

                 ,-14087 ,-14083 ,-13917 ,-13914 ,-13910 ,-13907 ,-13906 ,-13905 ,-13896 ,-13894

                 ,-13878 ,-13870 ,-13859 ,-13847 ,-13831 ,-13658 ,-13611 ,-13601 ,-13406 ,-13404

                 ,-13400 ,-13398 ,-13395 ,-13391 ,-13387 ,-13383 ,-13367 ,-13359 ,-13356 ,-13343

                 ,-13340 ,-13329 ,-13326 ,-13318 ,-13147 ,-13138 ,-13120 ,-13107 ,-13096 ,-13095

                 ,-13091 ,-13076 ,-13068 ,-13063 ,-13060 ,-12888 ,-12875 ,-12871 ,-12860 ,-12858

                 ,-12852 ,-12849 ,-12838 ,-12831 ,-12829 ,-12812 ,-12802 ,-12607 ,-12597 ,-12594

                 ,-12585 ,-12556 ,-12359 ,-12346 ,-12320 ,-12300 ,-12120 ,-12099 ,-12089 ,-12074

                 ,-12067 ,-12058 ,-12039 ,-11867 ,-11861 ,-11847 ,-11831 ,-11798 ,-11781 ,-11604

                 ,-11589 ,-11536 ,-11358 ,-11340 ,-11339 ,-11324 ,-11303 ,-11097 ,-11077 ,-11067

                 ,-11055 ,-11052 ,-11045 ,-11041 ,-11038 ,-11024 ,-11020 ,-11019 ,-11018 ,-11014

                 ,-10838 ,-10832 ,-10815 ,-10800 ,-10790 ,-10780 ,-10764 ,-10587 ,-10544 ,-10533

                 ,-10519 ,-10331 ,-10329 ,-10328 ,-10322 ,-10315 ,-10309 ,-10307 ,-10296 ,-10281

                 ,-10274 ,-10270 ,-10262 ,-10260 ,-10256 ,-10254

             };

            string[] sA = new string[]

         {

             "a","ai","an","ang","ao"

 

             ,"ba","bai","ban","bang","bao","bei","ben","beng","bi","bian","biao","bie","bin"

             ,"bing","bo","bu"

 

             ,"ca","cai","can","cang","cao","ce","ceng","cha","chai","chan","chang","chao","che"

             ,"chen","cheng","chi","chong","chou","chu","chuai","chuan","chuang","chui","chun"

             ,"chuo","ci","cong","cou","cu","cuan","cui","cun","cuo"

 

             ,"da","dai","dan","dang","dao","de","deng","di","dian","diao","die","ding","diu"

             ,"dong","dou","du","duan","dui","dun","duo"

 

             ,"e","en","er"

 

             ,"fa","fan","fang","fei","fen","feng","fo","fou","fu"

 

             ,"ga","gai","gan","gang","gao","ge","gei","gen","geng","gong","gou","gu","gua","guai"

             ,"guan","guang","gui","gun","guo"

 

             ,"ha","hai","han","hang","hao","he","hei","hen","heng","hong","hou","hu","hua","huai"

             ,"huan","huang","hui","hun","huo"

 

             ,"ji","jia","jian","jiang","jiao","jie","jin","jing","jiong","jiu","ju","juan","jue"

             ,"jun"

 

             ,"ka","kai","kan","kang","kao","ke","ken","keng","kong","kou","ku","kua","kuai","kuan"

             ,"kuang","kui","kun","kuo"

 

             ,"la","lai","lan","lang","lao","le","lei","leng","li","lia","lian","liang","liao","lie"

             ,"lin","ling","liu","long","lou","lu","lv","luan","lue","lun","luo"

 

             ,"ma","mai","man","mang","mao","me","mei","men","meng","mi","mian","miao","mie","min"

             ,"ming","miu","mo","mou","mu"

 

             ,"na","nai","nan","nang","nao","ne","nei","nen","neng","ni","nian","niang","niao","nie"

             ,"nin","ning","niu","nong","nu","nv","nuan","nue","nuo"

 

             ,"o","ou"

 

             ,"pa","pai","pan","pang","pao","pei","pen","peng","pi","pian","piao","pie","pin","ping"

             ,"po","pu"

 

             ,"qi","qia","qian","qiang","qiao","qie","qin","qing","qiong","qiu","qu","quan","que"

             ,"qun"

 

             ,"ran","rang","rao","re","ren","reng","ri","rong","rou","ru","ruan","rui","run","ruo"

 

             ,"sa","sai","san","sang","sao","se","sen","seng","sha","shai","shan","shang","shao","she"

             ,"shen","sheng","shi","shou","shu","shua","shuai","shuan","shuang","shui","shun","shuo","si"

             ,"song","sou","su","suan","sui","sun","suo"

 

             ,"ta","tai","tan","tang","tao","te","teng","ti","tian","tiao","tie","ting","tong","tou","tu"

             ,"tuan","tui","tun","tuo"

 

             ,"wa","wai","wan","wang","wei","wen","weng","wo","wu"

 

             ,"xi","xia","xian","xiang","xiao","xie","xin","xing","xiong","xiu","xu","xuan","xue","xun"

 

             ,"ya","yan","yang","yao","ye","yi","yin","ying","yo","yong","you","yu","yuan","yue","yun"

 

             ,"za","zai","zan","zang","zao","ze","zei","zen","zeng","zha","zhai","zhan","zhang","zhao"

             ,"zhe","zhen","zheng","zhi","zhong","zhou","zhu","zhua","zhuai","zhuan","zhuang","zhui"

             ,"zhun","zhuo","zi","zong","zou","zu","zuan","zui","zun","zuo"

         };

            byte[] B = new byte[2];

            string s = "";

            char[] c = x.ToCharArray();

            for (int j = 0; j < c.Length; j++)
            {

                B = System.Text.Encoding.Default.GetBytes(c[j].ToString());

                if ((int)(B[0]) <= 160 && (int)(B[0]) >= 0)
                {

                    s += c[j];

                }

                else
                {

                    for (int i = (iA.Length - 1); i >= 0; i--)
                    {

                        if (iA[i] <= (int)(B[0]) * 256 + (int)(B[1]) - 65536)
                        {

                            s += sA[i];

                            break;

                        }

                    }

                }

            }



            return s;

        }

        /// <summary>
        /// 获取汉字拼音的第一个字母
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string ToChineseSpell(this string strText)
        {
            int len = strText.Length;
            string myStr = "";
            for (int i = 0; i < len; i++)
            {
                myStr += ToChineseFullSpell(strText.Substring(i, 1));
            }
            return myStr.ToLower();
        }
        /// <summary>
        /// 获取汉字拼音
        /// </summary>
        /// <param name="cnChar"></param>
        /// <returns></returns>
        public static string ToChineseFullSpell(this string cnChar)
        {
            byte[] arrCN = Encoding.Default.GetBytes(cnChar);
            if (arrCN.Length > 1)
            {
                int area = (short)arrCN[0];
                int pos = (short)arrCN[1];
                int code = (area << 8) + pos;
                int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614, 48119, 48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387, 51446, 52218, 52698, 52698, 52698, 52980, 53689, 54481 };
                for (int i = 0; i < 26; i++)
                {
                    int max = 55290;
                    if (i != 25) max = areacode[i + 1];
                    if (areacode[i] <= code && code < max)
                    {
                        return Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
                    }
                }
                return "x";
            }
            else return cnChar;
        }

        /// <summary>
        /// 截取字符串，汉字两个字节，字母一个字节
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="strLength">字符串长度</param>
        /// <returns></returns>
        public static string Interruption(this string str, int len, string show)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            string tempString = "";
            byte[] s = ascii.GetBytes(str);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                { tempLen += 2; }
                else
                { tempLen += 1; }
                try
                { tempString += str.Substring(i, 1); }
                catch
                { break; }
                if (tempLen > len) break;
            }
            //如果截过则加上半个省略号 
            byte[] mybyte = System.Text.Encoding.Default.GetBytes(str);
            if (mybyte.Length > len)
                tempString += show;
            tempString = tempString.Replace("&nbsp;", " ");
            tempString = tempString.Replace("&lt;", "<");
            tempString = tempString.Replace("&gt;", ">");
            tempString = tempString.Replace('\n'.ToString(), "<br>");
            return tempString;
        }

        /// <summary>
        /// 截取字符串，汉字两个字节，字母一个字节
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="strLength">字符串长度</param>
        /// <returns></returns>
        public static string CutString(this string str, int len, string show = "...")
        {
            return Interruption(str, len, show);
        }

        /// <summary>
        /// 获取左边多少个字符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string Left(this string str, int len)
        {
            if (str == null || len < 1) { return ""; }
            if (len < str.Length)
            { return str.Substring(0, len); }
            else
            { return str; }
        }
        /// <summary>
        /// 获取右边多少个字符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string Right(this string str, int len)
        {
            if (str == null || len < 1) { return ""; }
            if (len < str.Length)
            { return str.Substring(str.Length - len); }
            else
            { return str; }
        }

        /// <summary>
        /// 得到实符串实际长度
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int Size(this string str)
        {
            byte[] strArray = System.Text.Encoding.Default.GetBytes(str);
            int res = strArray.Length;
            return res;
        }
        ///   <summary>   
        ///   去除HTML标记   
        ///   </summary>   
        ///   <param   name="NoHTML">包括HTML的源码   </param>   
        ///   <returns>已经去除后的文字</returns>   
        public static string RemoveHTML(this string Htmlstring)
        {
            //删除脚本   
            Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
            //删除HTML   
            Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);

            Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", "   ", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);

            Htmlstring.Replace("<", "");
            Htmlstring.Replace(">", "");
            Htmlstring.Replace("\r\n", "");
            Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();

            return Htmlstring;
        }
        /// <summary>
        /// 过滤js脚本
        /// </summary>
        /// <param name="strFromText"></param>
        /// <returns></returns>
        public static string RemoveScript(this string html)
        {
            if (html.IsNullOrEmpty()) return string.Empty;
            System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex(@"<script[\s\S]+</script *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex(@" href *= *[\s\S]*script *:", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex(@" on[\s\S]*=", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex4 = new System.Text.RegularExpressions.Regex(@"<iframe[\s\S]+</iframe *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex5 = new System.Text.RegularExpressions.Regex(@"<frameset[\s\S]+</frameset *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            html = regex1.Replace(html, ""); //过滤<script></script>标记
            html = regex2.Replace(html, ""); //过滤href=javascript: (<A>) 属性
            html = regex3.Replace(html, " _disibledevent="); //过滤其它控件的on...事件
            html = regex4.Replace(html, ""); //过滤iframe
            html = regex5.Replace(html, ""); //过滤frameset
            return html;
        }
        /// <summary>
        /// 替换页面标签
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string RemovePageTag(this string html)
        {
            if (html.IsNullOrEmpty()) return string.Empty;
            System.Text.RegularExpressions.Regex regex0 = new System.Text.RegularExpressions.Regex(@"<!DOCTYPE[^>]*>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex(@"<html\s*", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex(@"<head[\s\S]+</head\s*>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex(@"<body\s*", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex4 = new System.Text.RegularExpressions.Regex(@"<form\s*", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex5 = new System.Text.RegularExpressions.Regex(@"</(form|body|head|html)>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            html = regex0.Replace(html, ""); //过滤<html>标记
            html = regex1.Replace(html, "<html\u3000 "); //过滤<html>标记
            html = regex2.Replace(html, ""); //过滤<head>属性
            html = regex3.Replace(html, "<body\u3000 "); //过滤<body>属性
            html = regex4.Replace(html, "<form\u3000 "); //过滤<form>属性
            html = regex5.Replace(html, "</$1\u3000>"); //过滤</html></body></head></form>属性
            return html;
        }

        /// <summary>
        /// 取得html中的图片
        /// </summary>
        /// <param name="HTMLStr"></param>
        /// <returns></returns>
        public static string GetImg(this string text)
        {
            string str = string.Empty;
            Regex r = new Regex(@"<img\s+[^>]*\s*src\s*=\s*([']?)(?<url>\S+)'?[^>]*>", //注意这里的(?<url>\S+)是按正则表达式中的组来处理的，下面的代码中用使用到，也可以更改成其它的HTML标签，以同样的方法获得内容！
            RegexOptions.Compiled);
            Match m = r.Match(text.ToLower());
            if (m.Success)
                str = m.Result("${url}").Replace("\"", "").Replace("'", "");
            return str;
        }
        /// <summary>
        /// 取得html中的所有图片
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string[] GetImgs(this string text)
        {
            List<string> imgs = new List<string>();
            string pat = @"<img\s+[^>]*\s*src\s*=\s*([']?)(?<url>\S+)'?[^>]*>";
            Regex r = new Regex(pat, RegexOptions.Compiled);
            Match m = r.Match(text.ToLower());
            while (m.Success)
            {
                imgs.Add(m.Result("${url}").Replace("\"", "").Replace("'", ""));
                m = m.NextMatch();
            }
            return imgs.ToArray();
        }

        /// <summary>
        /// 字符串是否包含标点符号(不包括_下画线)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool InPunctuation(this string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (char.IsPunctuation(c) && c != '_')
                    return true;
            }
            return false;

        }
        /// <summary>
        /// 去除字符串标点符号和空字符
        /// </summary>
        /// <param name="sourceString"></param>
        /// <returns></returns>
        public static string RemovePunctuationOrEmpty(this string str)
        {
            StringBuilder NewString = new StringBuilder(str.Length);
            char[] charArr = str.ToCharArray();
            foreach (char symbols in charArr)
            {
                if (!char.IsPunctuation(symbols) && !char.IsWhiteSpace(symbols))
                {
                    NewString.Append(symbols);
                }
            }
            return NewString.ToString();
        }
        /// <summary>
        /// HTML编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HtmlEncode(this string str)
        {
            return HttpContext.Current.Server.HtmlEncode(str);
        }
        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UrlEncode(this string str)
        {
            return str.IsNullOrEmpty() ? string.Empty : HttpContext.Current.Server.UrlEncode(str);
        }


        /// <summary>
        /// 返回一个值，该值指示指定的 System.String 对象是否出现在此字符串中。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value">要搜寻的字符串。</param>
        /// <param name="comparisonType">指定搜索规则的枚举值之一</param>
        /// <returns>如果 value 参数出现在此字符串中，或者 value 为空字符串 ("")，则为 true；否则为 false</returns>
        public static bool Contains(this string source, string value, StringComparison comparisonType)
        {
            if (source == null || value == null) { return false; }
            if (value == "") { return true; }
            return (source.IndexOf(value, comparisonType) >= 0);
        }

        /// <summary>
        /// 通过使用默认的相等或字符比较器确定序列是否包含指定的元素。
        /// </summary>
        /// <param name="source">要在其中定位某个值的序列。</param>
        /// <param name="value">要在序列中定位的值。</param>
        /// <param name="comparisonType">指定搜索规则的枚举值之一</param>
        /// <exception cref="System.ArgumentNullException">source 为 null</exception>
        /// <returns>如果源序列包含具有指定值的元素，则为 true；否则为 false。</returns>
        public static bool Contains(this string[] source, string value, StringComparison comparisonType)
        {
            return System.Linq.Enumerable.Contains(source, value, new CompareText(comparisonType));
        }


        /// <summary>
        /// 人名字只留姓，后面用*填充
        /// </summary>
        /// <param name="s"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static string ToStar(this string s, int start = 1)
        {
            var sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(s))
            {
                return "*";
            }
            var firstLetter = s[0];
            var firstIsLetter = 65 < firstLetter && firstLetter < 122;
            if (firstIsLetter)
            {
                var array = s.Split(' ');
                if (array.Length > 1 && array[0].Length <= 10)
                {
                    sb.Append(array[0]);
                    if (!String.IsNullOrWhiteSpace(array[1]))
                    {
                        sb.Append(" ");
                        sb.Append(array[1].Substring(0, 1).ToUpper());
                    }
                    else
                        sb.Append("*");
                }
                else
                {
                    var head = array[0];
                    if (head.Length > 10)
                        head = s.Substring(0, 10);
                    sb.Append(head);
                    sb.Append("*");
                }
            }
            else
            {
                var head = s.Substring(0, start);
                sb.Append(head);
                sb.Append("**");
            }

            return sb.ToString();
        }


        /// <summary>
        /// 价钱区间转Tuple，如200-300转成Tuple<200, 300>
        /// </summary>
        /// <param name="priceParam"></param>
        /// <returns></returns>
        public static Tuple<int, int> ToPriceRange(this string priceParam)
        {
            if (priceParam.Contains("-"))
            {
                var rangeArray = priceParam.Split('-');
                if (rangeArray.Length == 2)
                {
                    var priceRange = new Tuple<int, int>(rangeArray[0].ToInt(), rangeArray[1].ToInt());
                    return priceRange;
                }
            }

            return new Tuple<int, int>(0, 0);
        }


        #region Convert string type to other types
        /// <summary>
        /// 字符串转bool
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defalut"></param>
        /// <returns></returns>
        public static bool ToBool(this string s, bool defalut = false)
        {
            bool result = defalut;
            if (bool.TryParse(s, out result))
                return result;
            else
                return defalut;
        }

        /// <summary>
        /// 字符串转double
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defalut"></param>
        /// <returns></returns>
        public static double ToDouble(this string s, double defalut = 0)
        {
            double result = defalut;
            if (double.TryParse(s, out result))
                return result;
            else
                return defalut;
        }

        /// <summary>
        /// 字符串转decimal
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defalut"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string s, decimal defalut = 0)
        {
            decimal result = defalut;
            if (decimal.TryParse(s, out result))
                return result;
            else
                return defalut;
        }

        /// <summary>
        /// 字符串转GUID
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Guid ToGuid(this string s)
        {
            Guid result = Guid.Empty;
            if (Guid.TryParse(s, out result))
                return result;
            else
                return Guid.Empty;
        }

        /// <summary>
        /// 字符串转日期
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defalut"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string s, DateTime defalut = new DateTime())
        {
            DateTime result = defalut;
            if (DateTime.TryParse(s, out result))
                return result;
            else
                return defalut;
        }

        /// <summary>
        /// 字符串转Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string s) where T : struct
        {
            T result = default(T);
            Enum.TryParse<T>(s, true, out result);
            return result;
        }
        #endregion

        private class CompareText : IEqualityComparer<string>
        {
            private StringComparison m_comparisonType { get; set; }
            public int GetHashCode(string t) { return t.GetHashCode(); }
            public CompareText(StringComparison comparisonType) { this.m_comparisonType = comparisonType; }
            public bool Equals(string x, string y)
            {
                if (x == y) { return true; }
                if (x == null || y == null) { return false; }
                else { return x.Equals(y, m_comparisonType); }
            }



        }

    }
}

