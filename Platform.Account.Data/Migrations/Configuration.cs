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
            //��ʼ������
            if (context.User.FirstOrDefault(x => x.LoginName == "ϵͳ") == null)
            {
                #region ��ʼ������

                var sysUser = new User
                {
                    LoginName = "ϵͳ",
                    Password = "1",
                    UserType = 0
                };
                //ϵͳ�û�
                context.User.AddOrUpdate(sysUser);
                //����Ա
                var role_admin = new Role
                {
                    Name = "ϵͳ����Ա",
                    Remark = "ϵͳ��������Ա",
                    RoleType = 1,
                    CreateName = sysUser.LoginName
                };

                role_admin.Users.Add(new User
                {
                    LoginName = "admin",
                    Password = FormsAuthentication.HashPasswordForStoringInConfigFile("1", "md5"),
                    UserType = 1,
                    CreateName = sysUser.LoginName,
                    RealName="����Ա",
                });
                context.Role.AddOrUpdate(role_admin);
                //��ʼ����֯����

                #region ��֯����
                var root = new Orgnizition()
                        {
                            Name = "�ܲð�",
                        };
                var org1 = new Orgnizition()
                {
                    Name = "������",
                };
                var org2 = new Orgnizition()
                {
                    Name = "������",
                };
                var center1 = new Orgnizition()
                {
                    Name = "��������",
                };
                center1.SubOrgnizitions.Add(org1);
                center1.SubOrgnizitions.Add(org2);
                root.SubOrgnizitions.Add(center1);

                var center2 = new Orgnizition()
                {
                    Name = "Ӫ������",
                };


                var dept1 = new Orgnizition()
                {
                    Name = "������ҵ",
                };
                var org3 = new Orgnizition()
                {
                    Name = "���۲�",
                };
                var org4 = new Orgnizition()
                {
                    Name = "�ڿز�",
                };
                dept1.SubOrgnizitions.Add(org3);
                dept1.SubOrgnizitions.Add(org4);
                center2.SubOrgnizitions.Add(dept1);

                var dept2 = new Orgnizition()
                {
                    Name = "�й���ҵ",
                };
                var org5 = new Orgnizition()
                {
                    Name = "���۲�",
                };
                var org6 = new Orgnizition()
                {
                    Name = "�ڿز�",
                };
                dept2.SubOrgnizitions.Add(org5);
                dept2.SubOrgnizitions.Add(org6);
                center2.SubOrgnizitions.Add(dept2);

                var dept3 = new Orgnizition()
                {
                    Name = "�ն���ҵ",
                };
                center2.SubOrgnizitions.Add(dept3);

                //var dept4 = new Orgnizition()
                //{
                //    Name = "�г��߻�",
                //};
                //center2.SubOrgnizitions.Add(dept4);
                //var dept5 = new Orgnizition()
                //{
                //    Name = "��Ⱥά��",
                //};
                //center2.SubOrgnizitions.Add(dept5);
                //var dept6 = new Orgnizition()
                //{
                //    Name = "Ʒ������",
                //};

                //var dept7 = new Orgnizition()
                //{
                //    Name = "��������",
                //};



                root.SubOrgnizitions.Add(center2);
                var center3 = new Orgnizition()
                {
                    Name = "��Ʒ����",
                };
                root.SubOrgnizitions.Add(center3);
                var center4 = new Orgnizition()
                {
                    Name = "��������",
                };
                root.SubOrgnizitions.Add(center4);
                var center5 = new Orgnizition()
                {
                    Name = "��Ϣ����",
                };
                root.SubOrgnizitions.Add(center5);

                context.Orgnizition.AddOrUpdate(root);
                
                #endregion

                //��ʼ��ϵͳ�˵�
                
                #region OA�˵�

                var oa_menu = new Menu
                {
                    MenuName = "OA�칫�Զ���",
                    MenuIcon = "fa fa-tachometer",
                    OrderCode = 1,
                    MenuType = 1,
                };
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "�ҵ�����",
                    IsLeaf = true,
                    OrderCode = 1,
                    MenuCode="MyCenter",
                    ModuleName="OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��λ����",
                    IsLeaf = true,
                    OrderCode = 2,
                    MenuCode = "Notice",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��λ�ƶ�",
                    IsLeaf = true,
                    OrderCode = 3,
                    MenuCode = "Institution",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��֯�ܹ�",
                    IsLeaf = true,
                    OrderCode = 4,
                    MenuCode = "Orgnizition",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "ͨѶ¼",
                    IsLeaf = true,
                    OrderCode = 5,
                    MenuCode = "AdreessBook",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��λ����",
                    IsLeaf = true,
                    OrderCode = 6,
                    MenuCode = "Info",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "�ļ�����",
                    IsLeaf = true,
                    OrderCode = 7,
                    MenuCode = "Doc",
                    ModuleName = "OA",
                    MenuType = 1,
                });
                oa_menu.SubMenus.Add(new Menu
                {
                    MenuName = "�칫��Ʒ",
                    IsLeaf = true,
                    OrderCode = 8,
                    MenuCode = "OfficeSupply",
                    ModuleName = "OA",
                    MenuType = 1,
                });

                context.Menu.AddOrUpdate(oa_menu);
                #endregion

                #region CRM �˵�

                var crm_menu = new Menu
                {
                    MenuName = "CRM�ͻ�����",
                    IsLeaf = false,
                    MenuIcon = "fa fa-users",
                    MenuType = 1,
                };

                #endregion

                #region SRM �˵�

                var srm_menu = new Menu
                {
                    MenuName = "SRM���ҹ���",
                    IsLeaf = false,
                    MenuIcon = "fa fa-university",
                    MenuType = 1,
                };

                context.Menu.AddOrUpdate(srm_menu);
                #endregion

                #region ERP �˵�

                var erp_menu = new Menu
                {
                    MenuName = "ERP��Ʒ����",
                    IsLeaf = false,
                    MenuIcon = "fa fa-life-ring",
                    MenuType = 1,
                };

                context.Menu.AddOrUpdate(erp_menu);
                #endregion

                #region ��������

                var logistics_menu = new Menu
                {
                    MenuName = "��������",
                    IsLeaf = false,
                    MenuIcon = "fa fa-truck",
                    MenuType = 1,
                };
                context.Menu.AddOrUpdate(logistics_menu);
                #endregion

                #region ��������

                var assistant_menu = new Menu
                {
                    MenuName = "��������",
                    IsLeaf = false,
                    MenuIcon = "fa fa-road",
                    MenuType = 1,
                };

                context.Menu.AddOrUpdate(assistant_menu);
                #endregion

                #region ��������

                var e_menu = new Menu
                {
                    MenuName = "��������",
                    IsLeaf = false,
                    MenuIcon = "fa fa-shopping-cart",
                    MenuType = 1,
                };
                context.Menu.AddOrUpdate(e_menu);
                #endregion
                
                #region ��������

                var setting_menu = new Menu
                {
                    MenuName = "��������",
                    MenuIcon = "fa fa-cogs",
                    OrderCode = 999,
                    MenuType = 1,
                };
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��Ա����",
                    IsLeaf = true,
                    MenuCode = "User",
                    ModuleName = "Account",
                    OrderCode = 1,
                    MenuType = 1,
                });
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��ɫ����",
                    IsLeaf = true,
                    OrderCode = 2,
                    MenuType = 1,
                    MenuCode = "Role",
                    ModuleName = "Account",
                });
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��֯��������",
                    IsLeaf = true,
                    OrderCode = 3,
                    MenuType = 1,
                    MenuCode = "Orgnizition",
                    ModuleName = "Account",
                });
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "�˵�����",
                    IsLeaf = true,
                    OrderCode = 4,
                    MenuType = 1,
                    MenuCode = "Menu",
                    ModuleName = "Account",
                });
                setting_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��̨�������",
                    IsLeaf = true,
                    OrderCode = 5,
                    MenuType = 1,
                    MenuCode = "Task",
                    ModuleName = "Account",
                });
                context.Menu.AddOrUpdate(setting_menu);
                #endregion

                //��ʼ�����Ĳ˵�

                #region ����
                var my_menu = new Menu
                {
                    MenuName = "����",
                    OrderCode = 1,
                    MenuType = 2,
                };
                my_menu.SubMenus.Add(new Menu {
                    MenuName = "�ڲ���Ϣ",
                    IsLeaf = true,
                    MenuCode = "Message",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-envelope-o",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_menu.SubMenus.Add(new Menu
                {
                    MenuName = "��ҵ����",
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
                    MenuName = "���˵���",
                    IsLeaf = true,
                    MenuCode = "Staff",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-user",
                    OrderCode = 3,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_menu);
                #endregion
                #region �ƻ�
                var my_plan = new Menu
                {
                    MenuName = "�ƻ�",
                    OrderCode = 2,
                    MenuType = 2,
                };
                my_plan.SubMenus.Add(new Menu
                {
                    MenuName = "��ȼƻ�",
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
                    MenuName = "�¶ȼƻ�",
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
                    MenuName = "�ܼƻ�",
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
                    MenuName = "������־",
                    IsLeaf = true,
                    MenuCode = "WorkLog",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-building-o",
                    OrderCode = 4,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_plan);
                #endregion
                #region ������
                var my_approval_flow = new Menu
                {
                    MenuName = "����",
                    OrderCode = 3,
                    MenuType = 2,
                };
                my_approval_flow.SubMenus.Add(new Menu
                {
                    MenuName = "�ҵ�����",
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
                    MenuName = "���칤��",
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
                    MenuName = "��;����",
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
                    MenuName = "��������",
                    IsLeaf = true,
                    MenuCode = "WorkFlow",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-pencil-square-o",
                    OrderCode = 4,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_approval_flow);
                #endregion
                #region ����
                var my_exchange = new Menu
                {
                    MenuName = "����",
                    OrderCode = 4,
                    MenuType = 2,
                };
                my_exchange.SubMenus.Add(new Menu
                {
                    MenuName = "�������",
                    IsLeaf = true,
                    MenuCode = "QA",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-question-circle",
                    OrderCode = 1,
                    MenuType = 2,
                });
                my_exchange.SubMenus.Add(new Menu
                {
                    MenuName = "�������",
                    IsLeaf = true,
                    MenuCode = "Meetting",
                    ModuleName = "OA",
                    MenuIcon = "fa fa-share-alt-square",
                    OrderCode = 2,
                    MenuType = 2,
                });
                context.Menu.AddOrUpdate(my_exchange);
                #endregion
                #region �Ŷ�
                var my_team = new Menu
                {
                    MenuName = "�Ŷ�",
                    OrderCode = 5,
                    MenuType = 2,
                };
                my_team.SubMenus.Add(new Menu
                {
                    MenuName = "��־",
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
                    MenuName = "�ܼƻ�",
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
                    MenuName = "�¼ƻ�",
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
                    MenuName = "����",
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
                    MenuName = "����",
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
                    MenuName = "����",
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
