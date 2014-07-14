using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lzw.Common.ValidateCode.Helper
{
   public class RandomHelper
    {

        /// <summary>
        /// 产生随机字符串
        /// </summary>
        /// <returns>字符串位数</returns>
        public static string GetRandom(int length)
        {
            int number;
            char code;
            string checkCode = String.Empty;
            System.Random random = new Random();

            for (int i = 0; i < length + 1; i++)
            {
                number = random.Next();
                if (number % 2 == 0)
                    code = (char)('0' + (char)(number % 10));
                else
                    code = (char)('A' + (char)(number % 26));
                checkCode += code.ToString();
            }
            return checkCode;
        }
    }
}
