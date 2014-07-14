namespace Platform.Account.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogException",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        UserID = c.Long(nullable: false),
                        Thread = c.String(maxLength: 255),
                        Level = c.String(maxLength: 50),
                        Logger = c.String(maxLength: 255),
                        Message = c.String(maxLength: 4000),
                        Exception = c.String(maxLength: 2000),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateName = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateName = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        LoginName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        WorkID = c.String(maxLength: 50),
                        RealName = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        UserType = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateName = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateName = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LogUserOperatorInfo",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        UserID = c.Long(nullable: false),
                        Thread = c.String(maxLength: 255),
                        Level = c.String(maxLength: 50),
                        Logger = c.String(maxLength: 255),
                        Message = c.String(maxLength: 4000),
                        Exception = c.String(maxLength: 2000),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateName = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateName = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        RoleType = c.Int(nullable: false),
                        Remark = c.String(maxLength: 255),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateName = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateName = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orgnizition",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.Int(nullable: false),
                        ParentID = c.Long(),
                        Remark = c.String(maxLength: 255),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateName = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateName = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orgnizition", t => t.ParentID)
                .Index(t => t.ParentID);
            
            CreateTable(
                "dbo.RoleAuthority",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        RoleID = c.Long(nullable: false),
                        MenuID = c.Long(nullable: false),
                        OperatorAuthority = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateName = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateName = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menu", t => t.MenuID, cascadeDelete: true)
                .ForeignKey("dbo.Role", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.MenuID);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        MenuName = c.String(nullable: false, maxLength: 50),
                        ParentID = c.Long(),
                        ModuleName = c.String(maxLength: 50),
                        MenuType = c.Int(nullable: false),
                        IsLeaf = c.Boolean(nullable: false),
                        OrderCode = c.Int(nullable: false),
                        MenuIcon = c.String(maxLength: 255),
                        MenuCode = c.String(maxLength: 255),
                        IndexCode = c.String(maxLength: 255),
                        ClickType = c.Int(nullable: false),
                        OperatorCode = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateName = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateName = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menu", t => t.ParentID)
                .Index(t => t.ParentID);
            
            CreateTable(
                "dbo.UserAuthority",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        UserID = c.Long(nullable: false),
                        MenuID = c.Long(nullable: false),
                        OperatorAuthority = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateName = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateName = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menu", t => t.MenuID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.MenuID);
            
            CreateTable(
                "dbo.OrgnizitionRole",
                c => new
                    {
                        OrgnizitionID = c.Long(nullable: false),
                        RoleID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrgnizitionID, t.RoleID })
                .ForeignKey("dbo.Role", t => t.OrgnizitionID, cascadeDelete: true)
                .ForeignKey("dbo.Orgnizition", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.OrgnizitionID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        UserID = c.Long(nullable: false),
                        RoleID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.RoleID })
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Role", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.RoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAuthority", "UserID", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleID", "dbo.Role");
            DropForeignKey("dbo.UserRole", "UserID", "dbo.User");
            DropForeignKey("dbo.RoleAuthority", "RoleID", "dbo.Role");
            DropForeignKey("dbo.RoleAuthority", "MenuID", "dbo.Menu");
            DropForeignKey("dbo.UserAuthority", "MenuID", "dbo.Menu");
            DropForeignKey("dbo.Menu", "ParentID", "dbo.Menu");
            DropForeignKey("dbo.OrgnizitionRole", "RoleID", "dbo.Orgnizition");
            DropForeignKey("dbo.OrgnizitionRole", "OrgnizitionID", "dbo.Role");
            DropForeignKey("dbo.Orgnizition", "ParentID", "dbo.Orgnizition");
            DropForeignKey("dbo.LogUserOperatorInfo", "UserID", "dbo.User");
            DropForeignKey("dbo.LogException", "UserID", "dbo.User");
            DropIndex("dbo.UserRole", new[] { "RoleID" });
            DropIndex("dbo.UserRole", new[] { "UserID" });
            DropIndex("dbo.OrgnizitionRole", new[] { "RoleID" });
            DropIndex("dbo.OrgnizitionRole", new[] { "OrgnizitionID" });
            DropIndex("dbo.UserAuthority", new[] { "MenuID" });
            DropIndex("dbo.UserAuthority", new[] { "UserID" });
            DropIndex("dbo.Menu", new[] { "ParentID" });
            DropIndex("dbo.RoleAuthority", new[] { "MenuID" });
            DropIndex("dbo.RoleAuthority", new[] { "RoleID" });
            DropIndex("dbo.Orgnizition", new[] { "ParentID" });
            DropIndex("dbo.LogUserOperatorInfo", new[] { "UserID" });
            DropIndex("dbo.LogException", new[] { "UserID" });
            DropTable("dbo.UserRole");
            DropTable("dbo.OrgnizitionRole");
            DropTable("dbo.UserAuthority");
            DropTable("dbo.Menu");
            DropTable("dbo.RoleAuthority");
            DropTable("dbo.Orgnizition");
            DropTable("dbo.Role");
            DropTable("dbo.LogUserOperatorInfo");
            DropTable("dbo.User");
            DropTable("dbo.LogException");
        }
    }
}
