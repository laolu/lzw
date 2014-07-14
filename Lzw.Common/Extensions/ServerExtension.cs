using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lzw.Common.Extensions
{
    public static class ServerExtension
    {
        /// <summary>
        /// 获取与 Web 服务器上的指定虚拟路径相对应的物理文件路径。
        /// </summary>
        /// <param name="Server"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string MapPathExt(this HttpServerUtility Server, string path)
        {
            if (path.StartsWith(@"\\") || path.Contains(":"))
            {
                return path;
            }
            else
            {
                return Server.MapPath(path);
            }
        }
    }
}
