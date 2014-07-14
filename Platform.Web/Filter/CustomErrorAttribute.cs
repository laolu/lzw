using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Platform.Web.Filter
{
    public class CustomErrorAttribute
    {
        #region IExceptionFilter 成员

        public void OnException(ExceptionContext filterContext)
        {
            UrlHelper url = new UrlHelper(filterContext.RequestContext);
            //filterContext.Result = new RedirectResult(url.Action("AboutError", "AboutError"));
        }

        #endregion
    }
}