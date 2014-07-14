using log4net;
using Lzw.Common.BootstrapSupport;
using Lzw.Common.Context;
using Platform.Account.Dtos;
using Platform.Component.Tools;
using Platform.Web.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Platform.Web.Common
{
    [BaseAuthorizeAttribute]
    public abstract class BaseController : CommonController
    {
         
        private readonly ILog _log;

        public UserLoginContext UserContext
        {
            get
            {
                var principal = this.User as LzwFormsPrincipal<UserLoginContext>;
                var userContext = principal.UserData;
                return userContext;
            }
        }
        public BaseController(ILog log)
        {
            _log = log;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AjaxLogOff()
        {
            FormsAuthentication.SignOut();

            var result = new OperationResult(OperationResultType.Success);

            return Json(result);
        }


        protected override void OnException(ExceptionContext filterContext)
        {
            // 标记异常已处理
            filterContext.ExceptionHandled = true;
            //记录错误日志
            _log.Error(string.Format(filterContext.Exception.Message), filterContext.Exception);
            // 跳转到错误页
            filterContext.Result = new RedirectResult(Url.Action("Error",new {@area="" }));
        }
    }
}
