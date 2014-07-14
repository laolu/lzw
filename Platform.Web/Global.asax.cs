using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Reflection;

using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using Platform.Web.Modules;
using log4net;
using Lzw.Common.Context;
using Platform.Account.Dtos;
using Mvc.JQuery.Datatables;


namespace Platform.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            LzwFormsPrincipal<UserLoginContext>.TrySetUserInfo(app.Context);
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(typeof(DataTablesParam), new Mvc.JQuery.Datatables.DataTablesModelBinder());

            DeviceConfig.EvaluateDisplayMode();

            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.Register(_ => Mapper.Engine).As<IMappingEngine>().SingleInstance();

            builder.RegisterModule(new AccountModule());
            builder.RegisterModule(new OAModule());
            builder.RegisterModule(new CrmModule());
            builder.RegisterModule(new LoggingModule());

            var container = builder.Build();
            DependencyResolver.SetResolver(new Autofac.Integration.Mvc.AutofacDependencyResolver(container));
        }
    }
}