namespace Platform.Account.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<Platform.Account.Data.Context.AccountDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Platform.Account.Data.Context.AccountDBContext context)
        {
            //初始化数据
            if (context.User.FirstOrDefault(x => x.LoginName == "系统") == null)
            {
                #region 初始化数据

                var sysUser = new User
                {
                    LoginName = "系统",
                    Password = "1",
                    UserType = 0
                };
                //系统用户
                context.User.AddOrUpdate(sysUser);
                //管理员
                var role_admin = new Role
                {
                    Name = "系统管理员",
                    Remark = "系统超级管理员",
                    RoleType = 1,
                    CreateName = sysUser.LoginName
                };

                role_admin.Users.Add(new User
                {
                    LoginName = "admin",
                    Password = FormsAuthentication.HashPasswordForStoringInConfigFile("1", "md5"),
                    UserType = 1,
                    CreateName = sysUser.LoginName,
                    RealName="管理员",
                });
                context.Role.AddOrUpdate(role_admin);
                //初始化组织机构

                #region 组织机构
                var root = new Orgnizition()
                        {
                            Name = "总裁办",
                        };
                var org1 = new Orgnizition()
                {
                    Name = "人力部",
                };
                var org2 = new Orgnizition()
                {
                    Name = "行政部",
                };
                var center1 = new Orgnizition()
                {
                    Name = "管理中心",
                };
                center1.SubOrgnizitions.Add(org1);
                center1.SubOrgnizitions.Add(org2);
                root.SubOrgnizitions.Add(center1);

                var center2 = new Orgnizition()
                {
                    Name = "营销中心",
                };


                var dept1 = new Orgnizition()
                {
                    Name = "渠道事业",
                };
                var org3 = new Orgnizition()
                {
                    Name = "销售部",
                };
                var org4 = new Orgnizition()
                {
                    Name = "内控部",
                };
                dept1.SubOrgnizitions.Add(org3);
                dept1.SubOrgnizitions.Add(org4);
                center2.SubOrgnizitions.Add(dept1);

                var dept2 = new Orgnizition()
                {
                    Name = "中工事业",
                };
                var org5 = new Orgnizition()
                {
                    Name = "销售部",
                };
                var org6 = new Orgnizition()
                {
                    Name = "内控部",
                };
                dept2.SubOrgnizitions.Add(org5);
                dept2.SubOrgnizitions.Add(org6);
                center2.SubOrgnizitions.Add(dept2);

                var dept3 = new Orgnizition()
                {
                    Name = "终端事业",
                };
                center2.SubOrgnizitions.Add(dept3);

                //var dept4 = new Orgnizition()
                //{
                //    Name = "市场策划",
                //};
                //center2.SubOrgnizitions.Add(dept4);
                //var dept5 = new Orgnizition()
                //{
                //    Name = "客群维护",
                //};
                //center2.SubOrgnizitions.Add(dept5);
                //var dept6 = new Orgnizition()
                //{
                //    Name = "品牌整合",
                //};

                //var dept7 = new Orgnizition()
                //{
                //    Name = "生产制造",
                //};



                root.SubOrgnizitions.Add(center2);
                var center3 = new Orgnizition()
                {
                    Name = "产品中心",
                };
                root.SubOrgnizitions.Add(center3);
                var center4 = new Orgnizition()
                {
                    Name = "财务中心",
                };
                root.SubOrgnizitions.Add(center4);
                var center5 = new Orgnizition()
                {
                    Name = "信息中心",
                };
                root.SubOrgnizitions.Add(center5);

                context.Orgnizition.AddOrUpdate(root);
                
                #endregion

                //初始化系统菜单
                
                #region OA菜单

                var oa_menu = new Menu
                {
                    MenuName = "OA办公自动化",
                    MenuIcon = "fa fa-tachometer",
                    OrderCode = 1,
                    MenuType = 1,
                };
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "我的中心",
                    IsLeaf = true,
                    OrderCode = 1,
                    MenuCode="MyCenter",
                    ModuleName="OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "单位公告",
                    IsLeaf = true,
                    OrderCode = 2,
                    MenuCode = "Notice",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "单位制度",
                    IsLeaf = true,
                    OrderCode = 3,
                    MenuCode = "Institution",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "组织架构",
                    IsLeaf = true,
                    OrderCode = 4,
                    MenuCode = "Orgnizition",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "通讯录",
                    IsLeaf = true,
                    OrderCode = 5,
                    MenuCode = "AdreessBook",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "单位介绍",
                    IsLeaf = true,
                    OrderCode = 6,
                    MenuCode = "Info",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "文件共享",
                    IsLeaf = true,
                    OrderCode = 7,
                    MenuCode = "Doc",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "办公用品",
                    IsLeaf = true,
                    OrderCode = 8,
                    MenuCode = "OfficeSupply",
                    ModuleName = "OA",
                    MenuType = 1,
                });

                context.Menu.AddOrUpdate(oa_menu);
                #endregion

                #region CRM 菜单

                var crm_menu = new Menu
                {
                    MenuName = "CRM客户管理",
                    IsLeaf = false,
                    MenuIcon = "fa fa-users",
                    MenuType = 1,
                };

                #endregion

                #region SRM 菜单

                var srm_menu = new Menu
                {
                    MenuName = "SRM厂家管理",
                    IsLeaf = false,
                    MenuIcon = "fa fa-university",
                    MenuType = 1,
                };

                context.Menu.AddOrUpdate(srm_menu);
                #endregion

                #region ERP 菜单

                var erp_menu = new Menu
                {
                    MenuName = "ERP产品管理",
                    IsLeaf = false,
                    MenuIcon = "fa fa-life-ring",
                    MenuType = 1,
                };

                context.Menu.AddOrUpdate(erp_menu);
                #endregion

                #region 物流配送

                var logistics_menu = new Menu
                {
                    MenuName = "物流配送",
                    IsLeaf = false,
                    MenuIcon = "fa fa-truck",
                    MenuType = 1,
                };
                context.Menu.AddOrUpdate(logistics_menu);
                #endregion

                #region 外勤助手

                var assistant_menu = new Menu
                {
                    MenuName = "外勤助手",
                    IsLeaf = false,
                    MenuIcon = "fa fa-road",
                    MenuType = 1,
                };

                context.Menu.AddOrUpdate(assistant_menu);
                #endregion

                #region 电子商务

                var e_menu = new Menu
                {
                    MenuName = "电子商务",
                    IsLeaf = false,
                    MenuIcon = "fa fa-shopping-cart",
                    MenuType = 1,
                };
                context.Menu.AddOrUpdate(e_menu);
                #endregion
                
                #region 基础设置

                var setting_menu = new Menu
                {
                    MenuName = "基础设置",
                    MenuIcon = "fa fa-cogs",
                    OrderCode = 999,
                    MenuType = 1,
                };
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "人员管理",
                    IsLeaf = true,
                    MenuCode = "User",
                    ModuleName = "Account",
                    OrderCode = 1,
                    MenuType = 1,
                });
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "角色管理",
                    IsLeaf = true,
                    OrderCode = 2,
                    MenuType = 1,
                    MenuCode = "Role",
                    ModuleName = "Account",
                });
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "组织机构管理",
                    IsLeaf = true,
                    OrderCode = 3,
                    MenuType = 1,
                    MenuCode = "Orgnizition",
                    ModuleName = "Account",
                });
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "菜单管理",
                    IsLeaf = true,
                    OrderCode = 4,
                    MenuType = 1,
                    MenuCode = "Menu",
                    ModuleName = "Account",
                });
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "后台任务管理",
                    IsLeaf = true,
                    OrderCode = 5,
                    MenuType = 1,
                    MenuCode = "Task",
                    ModuleName = "Account",
                });
                context.Menu.AddOrUpdate(setting_menu);
                #endregion

                //初始化中心菜单

                #region 个人
                var my_menu = new Menu
                {
                    MenuName = "个人",
                    OrderCode = 1,
                    MenuType = 2,
                };
                my_menu.SubMenus.Add(new Menu {
                    MenuName = "内部信息",
                    IsLeaf = true,
                    MenuCode = "Message",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-envelope-o",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_menu.SubMenus.Add(new Menu
                {
                    MenuName = "企业邮箱",
                    IsLeaf = true,
                    MenuCode = "Email",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-envelope",
                    OrderCode = 2,
                    MenuType = 2,
                    ClickType=1,//_blank
                });
                my_menu.SubMenus.Add(new Menu
                {
                    MenuName = "个人档案",
                    IsLeaf = true,
                    MenuCode = "Staff",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-user",
                    OrderCode = 3,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_menu);
                #endregion
                #region 计划
                var my_plan = new Menu
                {
                    MenuName = "计划",
                    OrderCode = 2,
                    MenuType = 2,
                };
                my_plan.SubMenus.Add(new Menu
                {
                    MenuName = "年度计划",
                    IsLeaf = true,
                    MenuCode = "Plan",
                    IndexCode="Year",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-bookmark",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_plan.SubMenus.Add(new Menu
                {
                    MenuName = "月度计划",
                    IsLeaf = true,
                    MenuCode = "Plan",
                    IndexCode="Month",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-bookmark-o",
                    OrderCode = 2,
                    MenuType = 2,
                });
                my_plan.SubMenus.Add(new Menu
                {
                    MenuName = "周计划",
                    IsLeaf = true,
                    MenuCode = "Plan",
                    IndexCode="Week",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-book",
                    OrderCode = 3,
                    MenuType = 2,
                });
                my_plan.SubMenus.Add(new Menu
                {
                    MenuName = "工作日志",
                    IsLeaf = true,
                    MenuCode = "WorkLog",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-building-o",
                    OrderCode = 4,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_plan);
                #endregion
                #region 审批流
                var my_approval_flow = new Menu
                {
                    MenuName = "审批",
                    OrderCode = 3,
                    MenuType = 2,
                };
                my_approval_flow.SubMenus.Add(new Menu
                {
                    MenuName = "我的申请",
                    IsLeaf = true,
                    IndexCode="My",
                    MenuCode = "WorkFlow",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-laptop",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_approval_flow.SubMenus.Add(new Menu
                {
                    MenuName = "待办工作",
                    IsLeaf = true,
                    IndexCode="WorkToDo",
                    MenuCode = "WorkFlow",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-gavel",
                    OrderCode = 2,
                    MenuType = 2,
                });
                my_approval_flow.SubMenus.Add(new Menu
                {
                    MenuName = "在途审批",
                    IsLeaf = true,
                    IndexCode="In",
                    MenuCode = "WorkFlow",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-retweet",
                    OrderCode = 3,
                    MenuType = 2,
                });
                my_approval_flow.SubMenus.Add(new Menu
                {
                    MenuName = "申请流程",
                    IsLeaf = true,
                    MenuCode = "WorkFlow",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-pencil-square-o",
                    OrderCode = 4,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_approval_flow);
                #endregion
                #region 互动
                var my_exchange = new Menu
                {
                    MenuName = "互动",
                    OrderCode = 4,
                    MenuType = 2,
                };
                my_exchange.SubMenus.Add(new Menu
                {
                    MenuName = "问题管理",
                    IsLeaf = true,
                    MenuCode = "QA",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-question-circle",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_exchange.SubMenus.Add(new Menu
                {
                    MenuName = "会议管理",
                    IsLeaf = true,
                    MenuCode = "Meetting",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-share-alt-square",
                    OrderCode = 2,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_exchange);
                #endregion
                #region 团队
                var my_team = new Menu
                {
                    MenuName = "团队",
                    OrderCode = 5,
                    MenuType = 2,
                };
                my_team.SubMenus.Add(new Menu
                {
                    MenuName = "日志",
                    IsLeaf = true,
                    MenuCode = "Team",
                    IndexCode="WorkLog",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-flag",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_team.SubMenus.Add(new Menu
                {
                    MenuName = "周计划",
                    IsLeaf = true,
                    MenuCode = "Team",
                    IndexCode="WeakPlan",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-flag-checkered",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_team.SubMenus.Add(new Menu
                {
                    MenuName = "月计划",
                    IsLeaf = true,
                    MenuCode = "Team",
                    IndexCode="MonthPlan",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-flag-o",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_team.SubMenus.Add(new Menu
                {
                    MenuName = "问题",
                    IsLeaf = true,
                    MenuCode = "Team",
                    IndexCode="QA",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-question",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_team.SubMenus.Add(new Menu
                {
                    MenuName = "考勤",
                    IsLeaf = true,
                    MenuCode = "Team",
                    IndexCode = "Attence",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-clock-o",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_team.SubMenus.Add(new Menu
                {
                    MenuName = "考核",
                    IsLeaf = true,
                    MenuCode = "Team",
                    IndexCode = "Performance",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-user-md",
                    OrderCode = 1,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_team);
                #endregion

                #endregion
            }
        }
    }
}
