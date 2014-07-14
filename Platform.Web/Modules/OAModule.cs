using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Platform.OA.Data.Context;
using Platform.Account.Data.Context;

namespace Platform.Web.Modules
{
    public class OAModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //注册DBContext上下文
            builder.RegisterType<OADBContext>();
            builder.RegisterType<OAUnitOfWorkContext>();


            //注册Mapping
            RegisterMappings();
            //注册Resgistroy
            var repositories = AppDomain.CurrentDomain.Load("Platform.OA.Data");//可通过文件配置读取相配置字符串
            builder.RegisterAssemblyTypes(repositories)
            .Where(t => t.Name.EndsWith("Repository"))
            .AsImplementedInterfaces();

            //注册所有Services类
            var dataAccess = AppDomain.CurrentDomain.Load("Platform.OA.Services");//可通过文件配置读取相配置字符串
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
