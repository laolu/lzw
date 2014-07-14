using System.Web.Mvc;

namespace Platform.Web.Areas.Crm
{
    public class CrmAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Crm";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Crm_default",
                "Crm/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
