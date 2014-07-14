using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using Platform.Account.Data;
using Platform.Account.Data.Context;
using Platform.Account.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Web.Modules
{
    public class AccountModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //注册DBContext上下文
            builder.RegisterType<AccountDBContext>();
            builder.RegisterType<AccountUnitOfWorkContext>();
            //注册Mapping
            RegisterMappings();
            //注册Resgistroy
            var repositories = AppDomain.CurrentDomain.Load("Platform.Account.Data");//可通过文件配置读取相配置字符串
            builder.RegisterAssemblyTypes(repositories)
            .Where(t => t.Name.EndsWith("Repository"))
            .AsImplementedInterfaces();

            //注册所有Services类
            var services = AppDomain.CurrentDomain.Load("Platform.Account.Services");//可通过文件配置读取相配置字符串
            builder.RegisterAssemblyTypes(services)
            .Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces();

            base.Load(builder);
        }

        private void RegisterMappings()
        {
            Mapper.CreateMap<User, UserDto>();
            #region 用户登陆
            
            Mapper.CreateMap<UserLoginDto, User>();
            Mapper.CreateMap<User, UserLoginContext>()
                .ForMember(x => x.Roles, m => m.MapFrom(x => (string.Join(",", x.Roles.Select(t => t.Name).ToList()))));
                //.ForMember(x => x.Menus, m => m.MapFrom(x => (string.Join(",", x.Roles.Select(t=>t.me).ToList()))));
            #endregion
            Mapper.CreateMap<Menu, MenuDto>()
               .ForMember(x => x.Controller, m => m.MapFrom(x => x.MenuCode))
               .ForMember(x => x.Action, m => m.MapFrom(x => x.IndexCode))
               .ForMember(x => x.Area, m => m.MapFrom(x => x.ModuleName));
        }
    }
}
