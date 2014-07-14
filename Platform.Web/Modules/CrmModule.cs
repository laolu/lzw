using Autofac;
using Autofac.Integration.Mvc;
using Platform.Crm.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Web.Modules
{
    public class CrmModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //注册DBContext上下文
            builder.RegisterType<CrmDbContext>();
            builder.RegisterType<CrmUnitOfWorkContext>();
            //注册Mapping
            RegisterMappings();
            //注册Resgistroy
            var repositories = AppDomain.CurrentDomain.Load("Platform.Crm.Data");//可通过文件配置读取相配置字符串
            builder.RegisterAssemblyTypes(repositories)
            .Where(t => t.Name.EndsWith("Repository"))
            .AsImplementedInterfaces();

            //注册所有Services类
            var dataAccess = AppDomain.CurrentDomain.Load("Platform.Crm.Services");//可通过文件配置读取相配置字符串
            builder.RegisterAssemblyTypes(dataAccess)
            .Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces();

            base.Load(builder);
        }

        private void RegisterMappings()
        {
            
        }
    }
}
