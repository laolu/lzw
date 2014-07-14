using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace Platform.Web
{
    public static class DeviceConfig
    {
        public static void EvaluateDisplayMode()
        {
            DisplayModeProvider.Instance.Modes.Insert(0,
            new DefaultDisplayMode("Phone")
            { 
                ContextCondition = (ctx => (
                    (ctx.GetOverriddenUserAgent() != null) &&
                    (                          
                        (ctx.GetOverriddenUserAgent().IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (ctx.GetOverriddenUserAgent().IndexOf("iPod", StringComparison.OrdinalIgnoreCase) >= 0)
                    )
            ))
            });
            //DisplayModeProvider.Instance.Modes.Insert(0,
            //new DefaultDisplayMode("Tablet")
            //{
            //    ContextCondition = (ctx => (
            //        (ctx.GetOverriddenUserAgent() != null) &&
            //        (
            //            (ctx.GetOverriddenUserAgent().IndexOf("iPad", StringComparison.OrdinalIgnoreCase) >= 0) ||
            //            (ctx.GetOverriddenUserAgent().IndexOf("Playbook", StringComparison.OrdinalIgnoreCase) >= 0)
            //        )
            //))
            //});
        }
    }
}