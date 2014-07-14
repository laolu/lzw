using Lzw.Common.BootstrapSupport;
using Lzw.Common.Context;
using Lzw.Common.ValidateCode;
using Platform.Account.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Platform.Web.Common
{
    public class CommonController : Controller
    {

        public void Attention(string message)
        {
            TempData.Add(Alerts.ATTENTION, message);
        }

        public void Success(string message)
        {
            TempData.Add(Alerts.SUCCESS, message);
        }

        public void Information(string message)
        {
            TempData.Add(Alerts.INFORMATION, message);
        }

        public void Error(string message)
        {
            TempData.Add(Alerts.ERROR, message);
        }

        [AllowAnonymous]
        public ActionResult VerifyImage()
        {
            var s1 = new ValidateCode_Style4();
            string code = "6666";
            byte[] bytes = s1.CreateImage(out code);
            this.TempData["ValidateCode"] = code;
            return File(bytes, @"image/jpeg");
        }

        [AllowAnonymous]
        public ActionResult Error()
        {
            return PartialView("_Error"); 
        }

        /// <summary>
        /// 如果是Ajax请求的话，清除浏览器缓存
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.HttpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
                filterContext.HttpContext.Response.Cache.SetValidUntilExpires(false);
                filterContext.HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                filterContext.HttpContext.Response.Cache.SetNoStore();
            }
            base.OnResultExecuted(filterContext);
        }
    }
}