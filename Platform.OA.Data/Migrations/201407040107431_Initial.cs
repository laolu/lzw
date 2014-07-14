namespace Platform.OA.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AssessmentApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.Staff", "Position_ID", "dbo.Position");
            DropForeignKey("dbo.DepartureApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.JobRequirementsApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.Leave", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.MaterialApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.MoneyApproval", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.OfficialSealApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.OverTimeApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.PriceAdjustmentApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.TravelApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.VehicleApplication", "WorkToDo_ID", "dbo.WorkToDo");
            DropForeignKey("dbo.MaterialEntry", "MaterialApplication_ID", "dbo.MaterialApplication");
            DropIndex("dbo.AssessmentApplication", new[] { "WorkToDo_ID" });
            DropIndex("dbo.Staff", new[] { "Position_ID" });
            DropIndex("dbo.DepartureApplication", new[] { "WorkToDo_ID" });
            DropIndex("dbo.JobRequirementsApplication", new[] { "WorkToDo_ID" });
            DropIndex("dbo.Leave", new[] { "WorkToDo_ID" });
            DropIndex("dbo.MaterialApplication", new[] { "WorkToDo_ID" });
            DropIndex("dbo.MaterialEntry", new[] { "MaterialApplication_ID" });
            DropIndex("dbo.MoneyApproval", new[] { "WorkToDo_ID" });
            DropIndex("dbo.OfficialSealApplication", new[] { "WorkToDo_ID" });
            DropIndex("dbo.OverTimeApplication", new[] { "WorkToDo_ID" });
            DropIndex("dbo.PriceAdjustmentApplication", new[] { "WorkToDo_ID" });
            DropIndex("dbo.TravelApplication", new[] { "WorkToDo_ID" });
            DropIndex("dbo.VehicleApplication", new[] { "WorkToDo_ID" });
            DropColumn("dbo.AssessmentApplication", "WorkToDoid");
            DropColumn("dbo.Staff", "PositionID");
            DropColumn("dbo.DepartureApplication", "WorkToDoid");
            DropColumn("dbo.JobRequirementsApplication", "WorkToDoid");
            DropColumn("dbo.Leave", "WorkToDoid");
            DropColumn("dbo.MaterialApplication", "WorkToDoid");
            DropColumn("dbo.MaterialEntry", "MaterialApplicationID");
            DropColumn("dbo.MoneyApproval", "WorkToDoID");
            DropColumn("dbo.OfficialSealApplication", "WorkToDoID");
            DropColumn("dbo.OverTimeApplication", "WorkToDoid");
            DropColumn("dbo.PriceAdjustmentApplication", "WorkToDoid");
            DropColumn("dbo.TravelApplication", "WorkToDoID");
            DropColumn("dbo.VehicleApplication", "WorkToDoid");
            RenameColumn(table: "dbo.AssessmentApplication", name: "WorkToDo_ID", newName: "WorkToDoid");
            RenameColumn(table: "dbo.Staff", name: "Position_ID", newName: "PositionID");
            RenameColumn(table: "dbo.DepartureApplication", name: "WorkToDo_ID", newName: "WorkToDoid");
            RenameColumn(table: "dbo.JobRequirementsApplication", name: "WorkToDo_ID", newName: "WorkToDoid");
            RenameColumn(table: "dbo.Leave", name: "WorkToDo_ID", newName: "WorkToDoid");
            RenameColumn(table: "dbo.MaterialApplication", name: "WorkToDo_ID", newName: "WorkToDoid");
            RenameColumn(table: "dbo.MoneyApproval", name: "WorkToDo_ID", newName: "WorkToDoID");
            RenameColumn(table: "dbo.OfficialSealApplication", name: "WorkToDo_ID", newName: "WorkToDoID");
            RenameColumn(table: "dbo.OverTimeApplication", name: "WorkToDo_ID", newName: "WorkToDoid");
            RenameColumn(table: "dbo.PriceAdjustmentApplication", name: "WorkToDo_ID", newName: "WorkToDoid");
            RenameColumn(table: "dbo.TravelApplication", name: "WorkToDo_ID", newName: "WorkToDoID");
            RenameColumn(table: "dbo.VehicleApplication", name: "WorkToDo_ID", newName: "WorkToDoid");
            RenameColumn(table: "dbo.MaterialEntry", name: "MaterialApplication_ID", newName: "MaterialApplicationID");
            CreateTable(
                "dbo.AccommodationApplication",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Note = c.String(nullable: false, maxLength: 1000),
                        CreateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        WorkToDoID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WorkToDo", t => t.WorkToDoID, cascadeDelete: true)
                .Index(t => t.WorkToDoID);
            
            CreateTable(
                "dbo.BlackBoard",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 1000),
                        StaffID = c.Long(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Staff", t => t.StaffID)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.LeaveEntry",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        OrderID = c.Long(nullable: false),
                        WorkID = c.Long(nullable: false),
                        CompleteTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        WorkLogDetail_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WorkLogDetail", t => t.WorkLogDetail_ID)
                .ForeignKey("dbo.Leave", t => t.OrderID)
                .Index(t => t.OrderID)
                .Index(t => t.WorkLogDetail_ID);
            
            CreateTable(
                "dbo.OverTimeEntry",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        OrderID = c.Long(nullable: false),
                        WorkID = c.Long(nullable: false),
                        CompleteTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        WorkLogDetail_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WorkLogDetail", t => t.WorkLogDetail_ID)
                .ForeignKey("dbo.OverTimeApplication", t => t.OrderID)
                .Index(t => t.OrderID)
                .Index(t => t.WorkLogDetail_ID);
            
            CreateTable(
                "dbo.DesignApplication",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Note = c.String(nullable: false),
                        ISPrinting = c.Boolean(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        HaveTime = c.DateTime(nullable: false),
                        OverTime = c.DateTime(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        address = c.String(nullable: false, maxLength: 255),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        WorkToDoID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WorkToDo", t => t.WorkToDoID, cascadeDelete: true)
                .Index(t => t.WorkToDoID);
            
            CreateTable(
                "dbo.GiftApplication",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        Note = c.String(nullable: false),
                        WorktodoID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WorkToDo", t => t.WorktodoID, cascadeDelete: true)
                .Index(t => t.WorktodoID);
            
            CreateTable(
                "dbo.MeetIng",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        RoomID = c.Long(nullable: false),
                        StaffIDS = c.String(nullable: false, maxLength: 2000),
                        MeetInData = c.String(maxLength: 4000),
                        CreateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MeetIngRoom", t => t.RoomID)
                .Index(t => t.RoomID);
            
            CreateTable(
                "dbo.MeetIngRoom",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateTime = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductIntroduction",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Note = c.String(),
                        Reason = c.String(),
                        attachment = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        WorktodoID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WorkToDo", t => t.WorktodoID, cascadeDelete: true)
                .Index(t => t.WorktodoID);
            
            CreateTable(
                "dbo.ProductProcurement",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        worktodoID = c.Long(nullable: false),
                        Note = c.String(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        WorkLogDetail_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WorkLogDetail", t => t.WorkLogDetail_ID)
                .Index(t => t.WorkLogDetail_ID);
            
            CreateTable(
                "dbo.ProductProcurementEntry",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        fitmeid = c.Int(nullable: false),
                        number = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeleted = c.Long(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.fitmeid, t.number, t.IsDeleted, t.CreateTime });
            
            CreateTable(
                "dbo.Rankings",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Value = c.String(nullable: false, maxLength: 50),
                        Type = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TravelEntry",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        OrderID = c.Long(nullable: false),
                        Sale = c.Decimal(precision: 18, scale: 2),
                        Back = c.Decimal(storeType: "money"),
                        money = c.Decimal(storeType: "money"),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        Note = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Staff", "CompanyPhone", c => c.String(maxLength: 50));
            AddColumn("dbo.Staff", "Phone", c => c.String(maxLength: 50));
            AddColumn("dbo.Staff", "Fixedline", c => c.String(maxLength: 50));
            AddColumn("dbo.Staff", "Marriage", c => c.Int());
            AddColumn("dbo.Staff", "Political", c => c.Int());
            AddColumn("dbo.Staff", "Phyle", c => c.String(maxLength: 255));
            AddColumn("dbo.Staff", "AccountProperties", c => c.Int());
            AddColumn("dbo.Staff", "HouseholdRegister", c => c.String(maxLength: 255));
            AddColumn("dbo.Staff", "Certificates", c => c.String(maxLength: 255));
            AddColumn("dbo.Staff", "EffectiveTime", c => c.DateTime());
            AddColumn("dbo.Staff", "School", c => c.String(maxLength: 255));
            AddColumn("dbo.Staff", "GraduationTime", c => c.DateTime());
            AddColumn("dbo.Staff", "Education", c => c.Int());
            AddColumn("dbo.Staff", "ContactPerson", c => c.String(maxLength: 255));
            AddColumn("dbo.Staff", "ContactPhone", c => c.String(maxLength: 50));
            AddColumn("dbo.Staff", "Relationship", c => c.String(maxLength: 255));
            AddColumn("dbo.Staff", "OldAddress", c => c.String(maxLength: 100));
            AddColumn("dbo.Staff", "Company", c => c.Int());
            AddColumn("dbo.Staff", "Level", c => c.String(maxLength: 50));
            AddColumn("dbo.Staff", "JiBie", c => c.String(maxLength: 50));
            AddColumn("dbo.Staff", "InDate", c => c.DateTime());
            AddColumn("dbo.Staff", "PositiveDate", c => c.DateTime());
            AddColumn("dbo.Staff", "StartDate", c => c.DateTime());
            AddColumn("dbo.Staff", "EndDate", c => c.DateTime());
            AddColumn("dbo.Staff", "Insurance", c => c.Int());
            AddColumn("dbo.Staff", "PayDate", c => c.DateTime());
            AddColumn("dbo.Staff", "DepartureDate", c => c.DateTime());
            AddColumn("dbo.Staff", "DepartureType", c => c.Int());
            AddColumn("dbo.Staff", "SurrenderDate", c => c.DateTime());
            AddColumn("dbo.Staff", "DepartureNote", c => c.String(maxLength: 1000));
            AddColumn("dbo.Branch", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.Branch", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.Branch", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.WorkFlowEntry", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkFlowEntry", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkFlowEntry", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.Position", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.Position", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.Position", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.WorkFlow", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkFlow", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkFlow", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.WorkToDo", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkToDo", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkToDo", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.CheckContent", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.CheckContent", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.CheckContent", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.MoneyApproval", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.MoneyApproval", "UPamount", c => c.String(maxLength: 255));
            AddColumn("dbo.PriceAdjustmentApplication", "Title", c => c.String(maxLength: 255));
            AddColumn("dbo.TravelApplication", "Path", c => c.String(nullable: false));
            AddColumn("dbo.TravelApplication", "CarID", c => c.Long());
            AddColumn("dbo.TravelApplication", "PromotionID", c => c.Int());
            AddColumn("dbo.TravelApplication", "Regional", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.VehicleApplication", "DriverID", c => c.Long());
            AddColumn("dbo.VehicleApplication", "Number", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.VehicleApplication", "CarID", c => c.Long(nullable: false));
            AddColumn("dbo.VehicleApplication", "StaffName", c => c.String(maxLength: 1000));
            AddColumn("dbo.RepairSys", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.RepairSys", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.RepairSys", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.Notice", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.Notice", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.Notice", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.OfficeSuppliesRequisition", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSuppliesRequisition", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSuppliesRequisition", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.OfficeSuppliesRequisitionDetail", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSuppliesRequisitionDetail", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSuppliesRequisitionDetail", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.OfficeSupply", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSupply", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSupply", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.OfficeSupplyInDetail", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSupplyInDetail", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSupplyInDetail", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.OfficeSupplyIn", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSupplyIn", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OfficeSupplyIn", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.OilCard", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OilCard", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OilCard", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.OilCardLog", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OilCardLog", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.OilCardLog", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.WorkFlowNodes", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkFlowNodes", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkFlowNodes", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.WorkLog", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkLog", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkLog", "UpdateTime", c => c.DateTime());
            AddColumn("dbo.WorkLogDetail", "CreateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkLogDetail", "UpdateName", c => c.String(maxLength: 50));
            AddColumn("dbo.WorkLogDetail", "UpdateTime", c => c.DateTime());
            AlterColumn("dbo.Agent", "StaffID", c => c.Long(nullable: false));
            AlterColumn("dbo.Agent", "DeputyID", c => c.Long(nullable: false));
            AlterColumn("dbo.AssessmentApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.AssessmentApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.Staff", "PositionID", c => c.Long(nullable: false));
            AlterColumn("dbo.Staff", "Principal", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Staff", "Status", c => c.Int(nullable: false));
            AlterColumn("dbo.Staff", "PositionID", c => c.Long(nullable: false));
            AlterColumn("dbo.DepartureApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.DepartureApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.JobRequirementsApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.JobRequirementsApplication", "Record", c => c.String());
            AlterColumn("dbo.JobRequirementsApplication", "IsDeleted", c => c.Long(nullable: false));
            AlterColumn("dbo.JobRequirementsApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.Leave", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.Leave", "AgentID", c => c.Long(nullable: false));
            AlterColumn("dbo.Leave", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.MaterialApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.MaterialApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.MaterialEntry", "MaterialApplicationID", c => c.Long(nullable: false));
            AlterColumn("dbo.MaterialEntry", "MaterialApplicationID", c => c.Long(nullable: false));
            AlterColumn("dbo.MoneyApproval", "WorkToDoID", c => c.Long(nullable: false));
            AlterColumn("dbo.MoneyApproval", "WorkToDoID", c => c.Long(nullable: false));
            AlterColumn("dbo.OfficialSealApplication", "WorkToDoID", c => c.Long(nullable: false));
            AlterColumn("dbo.OfficialSealApplication", "WorkToDoID", c => c.Long(nullable: false));
            AlterColumn("dbo.OverTimeApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.OverTimeApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.PriceAdjustmentApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.PriceAdjustmentApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.TravelApplication", "WorkToDoID", c => c.Long(nullable: false));
            AlterColumn("dbo.TravelApplication", "WorkToDoID", c => c.Long(nullable: false));
            AlterColumn("dbo.VehicleApplication", "WorkToDoid", c => c.Long(nullable: false));
            AlterColumn("dbo.VehicleApplication", "WorkToDoid", c => c.Long(nullable: false));
            CreateIndex("dbo.AssessmentApplication", "WorkToDoid");
            CreateIndex("dbo.Staff", "PositionID");
            CreateIndex("dbo.Agent", "StaffID");
            CreateIndex("dbo.Agent", "DeputyID");
            CreateIndex("dbo.Leave", "WorkToDoid");
            CreateIndex("dbo.Leave", "AgentID");
            CreateIndex("dbo.VehicleApplication", "WorkToDoid");
            CreateIndex("dbo.VehicleApplication", "DriverID");
            CreateIndex("dbo.VehicleApplication", "CarID");
            CreateIndex("dbo.DepartureApplication", "WorkToDoid");
            CreateIndex("dbo.JobRequirementsApplication", "WorkToDoid");
            CreateIndex("dbo.MaterialApplication", "WorkToDoid");
            CreateIndex("dbo.MaterialEntry", "MaterialApplicationID");
            CreateIndex("dbo.MoneyApproval", "WorkToDoID");
            CreateIndex("dbo.OfficialSealApplication", "WorkToDoID");
            CreateIndex("dbo.OverTimeApplication", "WorkToDoid");
            CreateIndex("dbo.PriceAdjustmentApplication", "WorkToDoid");
            CreateIndex("dbo.TravelApplication", "WorkToDoID");
            AddForeignKey("dbo.Agent", "DeputyID", "dbo.Staff", "ID");
            AddForeignKey("dbo.Agent", "StaffID", "dbo.Staff", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Leave", "AgentID", "dbo.Staff", "ID");
            AddForeignKey("dbo.VehicleApplication", "CarID", "dbo.CarInfo", "ID");
            AddForeignKey("dbo.VehicleApplication", "DriverID", "dbo.Staff", "ID");
            AddForeignKey("dbo.AssessmentApplication", "WorkToDoid", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Staff", "PositionID", "dbo.Position", "ID", cascadeDelete: true);
            AddForeignKey("dbo.DepartureApplication", "WorkToDoid", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.JobRequirementsApplication", "WorkToDoid", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Leave", "WorkToDoid", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.MaterialApplication", "WorkToDoid", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.MoneyApproval", "WorkToDoID", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.OfficialSealApplication", "WorkToDoID", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.OverTimeApplication", "WorkToDoid", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.PriceAdjustmentApplication", "WorkToDoid", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.TravelApplication", "WorkToDoID", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.VehicleApplication", "WorkToDoid", "dbo.WorkToDo", "ID", cascadeDelete: true);
            AddForeignKey("dbo.MaterialEntry", "MaterialApplicationID", "dbo.MaterialApplication", "ID", cascadeDelete: true);
            DropColumn("dbo.Agent", "IsDeleted");
            DropColumn("dbo.Agent", "Timestamp");
            DropColumn("dbo.Approval", "IsDeleted");
            DropColumn("dbo.Approval", "CreateTime");
            DropColumn("dbo.Approval", "Timestamp");
            DropColumn("dbo.AssessmentApplication", "IsDeleted");
            DropColumn("dbo.AssessmentApplication", "Timestamp");
            DropColumn("dbo.Staff", "IsDeleted");
            DropColumn("dbo.Staff", "Timestamp");
            DropColumn("dbo.Branch", "Timestamp");
            DropColumn("dbo.WorkFlowEntry", "Timestamp");
            DropColumn("dbo.Position", "Timestamp");
            DropColumn("dbo.WorkFlow", "Timestamp");
            DropColumn("dbo.WorkToDo", "Timestamp");
            DropColumn("dbo.CheckContent", "Timestamp");
            DropColumn("dbo.DepartureApplication", "ContractDate");
            DropColumn("dbo.DepartureApplication", "EndDate");
            DropColumn("dbo.DepartureApplication", "Timestamp");
            DropColumn("dbo.JobRequirementsApplication", "JobType");
            DropColumn("dbo.JobRequirementsApplication", "InTime");
            DropColumn("dbo.JobRequirementsApplication", "LatestTime");
            DropColumn("dbo.JobRequirementsApplication", "Responsibilities");
            DropColumn("dbo.JobRequirementsApplication", "Note");
            DropColumn("dbo.JobRequirementsApplication", "Timestamp");
            DropColumn("dbo.Leave", "IsDeleted");
            DropColumn("dbo.Leave", "Timestamp");
            DropColumn("dbo.MaterialApplication", "Timestamp");
            DropColumn("dbo.MaterialEntry", "Timestamp");
            DropColumn("dbo.MoneyApproval", "Timestamp");
            DropColumn("dbo.OfficialSealApplication", "IsDeleted");
            DropColumn("dbo.OfficialSealApplication", "Timestamp");
            DropColumn("dbo.OverTimeApplication", "IsDeleted");
            DropColumn("dbo.OverTimeApplication", "Timestamp");
            DropColumn("dbo.PriceAdjustmentApplication", "Timestamp");
            DropColumn("dbo.TravelApplication", "TravelPath");
            DropColumn("dbo.TravelApplication", "TravelTool");
            DropColumn("dbo.TravelApplication", "IsHaveDriver");
            DropColumn("dbo.TravelApplication", "IsDeleted");
            DropColumn("dbo.TravelApplication", "Timestamp");
            DropColumn("dbo.VehicleApplication", "IsHaveDriver");
            DropColumn("dbo.VehicleApplication", "Address");
            DropColumn("dbo.VehicleApplication", "CarType");
            DropColumn("dbo.VehicleApplication", "Timestamp");
            DropColumn("dbo.RepairSys", "Timestamp");
            DropColumn("dbo.CarInfo", "IsDeleted");
            DropColumn("dbo.CarInfo", "Timestamp");
            DropColumn("dbo.Notice", "Timestamp");
            DropColumn("dbo.OfficeSuppliesRequisition", "Timestamp");
            DropColumn("dbo.OfficeSuppliesRequisitionDetail", "Timestamp");
            DropColumn("dbo.OfficeSupply", "Timestamp");
            DropColumn("dbo.OfficeSupplyInDetail", "Timestamp");
            DropColumn("dbo.OfficeSupplyIn", "Timestamp");
            DropColumn("dbo.OilCard", "Timestamp");
            DropColumn("dbo.OilCardLog", "Timestamp");
            DropColumn("dbo.WorkFlowNodes", "Timestamp");
            DropColumn("dbo.WorkLog", "Timestamp");
            DropColumn("dbo.WorkLogDetail", "Timestamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkLogDetail", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.WorkLog", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.WorkFlowNodes", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OilCardLog", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OilCard", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OfficeSupplyIn", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OfficeSupplyInDetail", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OfficeSupply", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OfficeSuppliesRequisitionDetail", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OfficeSuppliesRequisition", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Notice", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.CarInfo", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.CarInfo", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.RepairSys", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.VehicleApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.VehicleApplication", "CarType", c => c.Int(nullable: false));
            AddColumn("dbo.VehicleApplication", "Address", c => c.Int(nullable: false));
            AddColumn("dbo.VehicleApplication", "IsHaveDriver", c => c.Boolean(nullable: false));
            AddColumn("dbo.TravelApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.TravelApplication", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.TravelApplication", "IsHaveDriver", c => c.Boolean(nullable: false));
            AddColumn("dbo.TravelApplication", "TravelTool", c => c.String(maxLength: 255));
            AddColumn("dbo.TravelApplication", "TravelPath", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.PriceAdjustmentApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OverTimeApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OverTimeApplication", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.OfficialSealApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.OfficialSealApplication", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.MoneyApproval", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.MaterialEntry", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.MaterialApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Leave", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Leave", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.JobRequirementsApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.JobRequirementsApplication", "Note", c => c.String(nullable: false, maxLength: 4000));
            AddColumn("dbo.JobRequirementsApplication", "Responsibilities", c => c.String(maxLength: 4000));
            AddColumn("dbo.JobRequirementsApplication", "LatestTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.JobRequirementsApplication", "InTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.JobRequirementsApplication", "JobType", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.DepartureApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.DepartureApplication", "EndDate", c => c.DateTime());
            AddColumn("dbo.DepartureApplication", "ContractDate", c => c.DateTime());
            AddColumn("dbo.CheckContent", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.WorkToDo", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.WorkFlow", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Position", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.WorkFlowEntry", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Branch", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Staff", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Staff", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.AssessmentApplication", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.AssessmentApplication", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Approval", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Approval", "CreateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Approval", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Agent", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Agent", "IsDeleted", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.MaterialEntry", "MaterialApplicationID", "dbo.MaterialApplication");
            DropForeignKey("dbo.VehicleApplication", "WorkToDoid", "dbo.WorkToDo");
            DropForeignKey("dbo.TravelApplication", "WorkToDoID", "dbo.WorkToDo");
            DropForeignKey("dbo.PriceAdjustmentApplication", "WorkToDoid", "dbo.WorkToDo");
            DropForeignKey("dbo.OverTimeApplication", "WorkToDoid", "dbo.WorkToDo");
            DropForeignKey("dbo.OfficialSealApplication", "WorkToDoID", "dbo.WorkToDo");
            DropForeignKey("dbo.MoneyApproval", "WorkToDoID", "dbo.WorkToDo");
            DropForeignKey("dbo.MaterialApplication", "WorkToDoid", "dbo.WorkToDo");
            DropForeignKey("dbo.Leave", "WorkToDoid", "dbo.WorkToDo");
            DropForeignKey("dbo.JobRequirementsApplication", "WorkToDoid", "dbo.WorkToDo");
            DropForeignKey("dbo.DepartureApplication", "WorkToDoid", "dbo.WorkToDo");
            DropForeignKey("dbo.Staff", "PositionID", "dbo.Position");
            DropForeignKey("dbo.AssessmentApplication", "WorkToDoid", "dbo.WorkToDo");
            DropForeignKey("dbo.ProductProcurement", "WorkLogDetail_ID", "dbo.WorkLogDetail");
            DropForeignKey("dbo.ProductIntroduction", "WorktodoID", "dbo.WorkToDo");
            DropForeignKey("dbo.MeetIng", "RoomID", "dbo.MeetIngRoom");
            DropForeignKey("dbo.GiftApplication", "WorktodoID", "dbo.WorkToDo");
            DropForeignKey("dbo.DesignApplication", "WorkToDoID", "dbo.WorkToDo");
            DropForeignKey("dbo.AccommodationApplication", "WorkToDoID", "dbo.WorkToDo");
            DropForeignKey("dbo.OverTimeEntry", "OrderID", "dbo.OverTimeApplication");
            DropForeignKey("dbo.OverTimeEntry", "WorkLogDetail_ID", "dbo.WorkLogDetail");
            DropForeignKey("dbo.VehicleApplication", "DriverID", "dbo.Staff");
            DropForeignKey("dbo.VehicleApplication", "CarID", "dbo.CarInfo");
            DropForeignKey("dbo.Leave", "AgentID", "dbo.Staff");
            DropForeignKey("dbo.LeaveEntry", "OrderID", "dbo.Leave");
            DropForeignKey("dbo.LeaveEntry", "WorkLogDetail_ID", "dbo.WorkLogDetail");
            DropForeignKey("dbo.BlackBoard", "StaffID", "dbo.Staff");
            DropForeignKey("dbo.Agent", "StaffID", "dbo.Staff");
            DropForeignKey("dbo.Agent", "DeputyID", "dbo.Staff");
            DropIndex("dbo.ProductProcurement", new[] { "WorkLogDetail_ID" });
            DropIndex("dbo.ProductIntroduction", new[] { "WorktodoID" });
            DropIndex("dbo.MeetIng", new[] { "RoomID" });
            DropIndex("dbo.GiftApplication", new[] { "WorktodoID" });
            DropIndex("dbo.DesignApplication", new[] { "WorkToDoID" });
            DropIndex("dbo.TravelApplication", new[] { "WorkToDoID" });
            DropIndex("dbo.PriceAdjustmentApplication", new[] { "WorkToDoid" });
            DropIndex("dbo.OverTimeEntry", new[] { "WorkLogDetail_ID" });
            DropIndex("dbo.OverTimeEntry", new[] { "OrderID" });
            DropIndex("dbo.OverTimeApplication", new[] { "WorkToDoid" });
            DropIndex("dbo.OfficialSealApplication", new[] { "WorkToDoID" });
            DropIndex("dbo.MoneyApproval", new[] { "WorkToDoID" });
            DropIndex("dbo.MaterialEntry", new[] { "MaterialApplicationID" });
            DropIndex("dbo.MaterialApplication", new[] { "WorkToDoid" });
            DropIndex("dbo.JobRequirementsApplication", new[] { "WorkToDoid" });
            DropIndex("dbo.DepartureApplication", new[] { "WorkToDoid" });
            DropIndex("dbo.VehicleApplication", new[] { "CarID" });
            DropIndex("dbo.VehicleApplication", new[] { "DriverID" });
            DropIndex("dbo.VehicleApplication", new[] { "WorkToDoid" });
            DropIndex("dbo.LeaveEntry", new[] { "WorkLogDetail_ID" });
            DropIndex("dbo.LeaveEntry", new[] { "OrderID" });
            DropIndex("dbo.Leave", new[] { "AgentID" });
            DropIndex("dbo.Leave", new[] { "WorkToDoid" });
            DropIndex("dbo.BlackBoard", new[] { "StaffID" });
            DropIndex("dbo.Agent", new[] { "DeputyID" });
            DropIndex("dbo.Agent", new[] { "StaffID" });
            DropIndex("dbo.Staff", new[] { "PositionID" });
            DropIndex("dbo.AssessmentApplication", new[] { "WorkToDoid" });
            DropIndex("dbo.AccommodationApplication", new[] { "WorkToDoID" });
            AlterColumn("dbo.VehicleApplication", "WorkToDoid", c => c.Long());
            AlterColumn("dbo.VehicleApplication", "WorkToDoid", c => c.Int(nullable: false));
            AlterColumn("dbo.TravelApplication", "WorkToDoID", c => c.Long());
            AlterColumn("dbo.TravelApplication", "WorkToDoID", c => c.Int(nullable: false));
            AlterColumn("dbo.PriceAdjustmentApplication", "WorkToDoid", c => c.Long());
            AlterColumn("dbo.PriceAdjustmentApplication", "WorkToDoid", c => c.Int(nullable: false));
            AlterColumn("dbo.OverTimeApplication", "WorkToDoid", c => c.Long());
            AlterColumn("dbo.OverTimeApplication", "WorkToDoid", c => c.Int(nullable: false));
            AlterColumn("dbo.OfficialSealApplication", "WorkToDoID", c => c.Long());
            AlterColumn("dbo.OfficialSealApplication", "WorkToDoID", c => c.Int(nullable: false));
            AlterColumn("dbo.MoneyApproval", "WorkToDoID", c => c.Long());
            AlterColumn("dbo.MoneyApproval", "WorkToDoID", c => c.Int(nullable: false));
            AlterColumn("dbo.MaterialEntry", "MaterialApplicationID", c => c.Long());
            AlterColumn("dbo.MaterialEntry", "MaterialApplicationID", c => c.Int(nullable: false));
            AlterColumn("dbo.MaterialApplication", "WorkToDoid", c => c.Long());
            AlterColumn("dbo.MaterialApplication", "WorkToDoid", c => c.Int(nullable: false));
            AlterColumn("dbo.Leave", "WorkToDoid", c => c.Long());
            AlterColumn("dbo.Leave", "AgentID", c => c.Int());
            AlterColumn("dbo.Leave", "WorkToDoid", c => c.Int(nullable: false));
            AlterColumn("dbo.JobRequirementsApplication", "WorkToDoid", c => c.Long());
            AlterColumn("dbo.JobRequirementsApplication", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.JobRequirementsApplication", "Record", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.JobRequirementsApplication", "WorkToDoid", c => c.Int(nullable: false));
            AlterColumn("dbo.DepartureApplication", "WorkToDoid", c => c.Long());
            AlterColumn("dbo.DepartureApplication", "WorkToDoid", c => c.Int(nullable: false));
            AlterColumn("dbo.Staff", "PositionID", c => c.Long());
            AlterColumn("dbo.Staff", "Status", c => c.Int());
            AlterColumn("dbo.Staff", "Principal", c => c.Boolean());
            AlterColumn("dbo.Staff", "PositionID", c => c.Int(nullable: false));
            AlterColumn("dbo.AssessmentApplication", "WorkToDoid", c => c.Long());
            AlterColumn("dbo.AssessmentApplication", "WorkToDoid", c => c.Int(nullable: false));
            AlterColumn("dbo.Agent", "DeputyID", c => c.Int(nullable: false));
            AlterColumn("dbo.Agent", "StaffID", c => c.Int(nullable: false));
            DropColumn("dbo.WorkLogDetail", "UpdateTime");
            DropColumn("dbo.WorkLogDetail", "UpdateName");
            DropColumn("dbo.WorkLogDetail", "CreateName");
            DropColumn("dbo.WorkLog", "UpdateTime");
            DropColumn("dbo.WorkLog", "UpdateName");
            DropColumn("dbo.WorkLog", "CreateName");
            DropColumn("dbo.WorkFlowNodes", "UpdateTime");
            DropColumn("dbo.WorkFlowNodes", "UpdateName");
            DropColumn("dbo.WorkFlowNodes", "CreateName");
            DropColumn("dbo.OilCardLog", "UpdateTime");
            DropColumn("dbo.OilCardLog", "UpdateName");
            DropColumn("dbo.OilCardLog", "CreateName");
            DropColumn("dbo.OilCard", "UpdateTime");
            DropColumn("dbo.OilCard", "UpdateName");
            DropColumn("dbo.OilCard", "CreateName");
            DropColumn("dbo.OfficeSupplyIn", "UpdateTime");
            DropColumn("dbo.OfficeSupplyIn", "UpdateName");
            DropColumn("dbo.OfficeSupplyIn", "CreateName");
            DropColumn("dbo.OfficeSupplyInDetail", "UpdateTime");
            DropColumn("dbo.OfficeSupplyInDetail", "UpdateName");
            DropColumn("dbo.OfficeSupplyInDetail", "CreateName");
            DropColumn("dbo.OfficeSupply", "UpdateTime");
            DropColumn("dbo.OfficeSupply", "UpdateName");
            DropColumn("dbo.OfficeSupply", "CreateName");
            DropColumn("dbo.OfficeSuppliesRequisitionDetail", "UpdateTime");
            DropColumn("dbo.OfficeSuppliesRequisitionDetail", "UpdateName");
            DropColumn("dbo.OfficeSuppliesRequisitionDetail", "CreateName");
            DropColumn("dbo.OfficeSuppliesRequisition", "UpdateTime");
            DropColumn("dbo.OfficeSuppliesRequisition", "UpdateName");
            DropColumn("dbo.OfficeSuppliesRequisition", "CreateName");
            DropColumn("dbo.Notice", "UpdateTime");
            DropColumn("dbo.Notice", "UpdateName");
            DropColumn("dbo.Notice", "CreateName");
            DropColumn("dbo.RepairSys", "UpdateTime");
            DropColumn("dbo.RepairSys", "UpdateName");
            DropColumn("dbo.RepairSys", "CreateName");
            DropColumn("dbo.VehicleApplication", "StaffName");
            DropColumn("dbo.VehicleApplication", "CarID");
            DropColumn("dbo.VehicleApplication", "Number");
            DropColumn("dbo.VehicleApplication", "DriverID");
            DropColumn("dbo.TravelApplication", "Regional");
            DropColumn("dbo.TravelApplication", "PromotionID");
            DropColumn("dbo.TravelApplication", "CarID");
            DropColumn("dbo.TravelApplication", "Path");
            DropColumn("dbo.PriceAdjustmentApplication", "Title");
            DropColumn("dbo.MoneyApproval", "UPamount");
            DropColumn("dbo.MoneyApproval", "Type");
            DropColumn("dbo.CheckContent", "UpdateTime");
            DropColumn("dbo.CheckContent", "UpdateName");
            DropColumn("dbo.CheckContent", "CreateName");
            DropColumn("dbo.WorkToDo", "UpdateTime");
            DropColumn("dbo.WorkToDo", "UpdateName");
            DropColumn("dbo.WorkToDo", "CreateName");
            DropColumn("dbo.WorkFlow", "UpdateTime");
            DropColumn("dbo.WorkFlow", "UpdateName");
            DropColumn("dbo.WorkFlow", "CreateName");
            DropColumn("dbo.Position", "UpdateTime");
            DropColumn("dbo.Position", "UpdateName");
            DropColumn("dbo.Position", "CreateName");
            DropColumn("dbo.WorkFlowEntry", "UpdateTime");
            DropColumn("dbo.WorkFlowEntry", "UpdateName");
            DropColumn("dbo.WorkFlowEntry", "CreateName");
            DropColumn("dbo.Branch", "UpdateTime");
            DropColumn("dbo.Branch", "UpdateName");
            DropColumn("dbo.Branch", "CreateName");
            DropColumn("dbo.Staff", "DepartureNote");
            DropColumn("dbo.Staff", "SurrenderDate");
            DropColumn("dbo.Staff", "DepartureType");
            DropColumn("dbo.Staff", "DepartureDate");
            DropColumn("dbo.Staff", "PayDate");
            DropColumn("dbo.Staff", "Insurance");
            DropColumn("dbo.Staff", "EndDate");
            DropColumn("dbo.Staff", "StartDate");
            DropColumn("dbo.Staff", "PositiveDate");
            DropColumn("dbo.Staff", "InDate");
            DropColumn("dbo.Staff", "JiBie");
            DropColumn("dbo.Staff", "Level");
            DropColumn("dbo.Staff", "Company");
            DropColumn("dbo.Staff", "OldAddress");
            DropColumn("dbo.Staff", "Relationship");
            DropColumn("dbo.Staff", "ContactPhone");
            DropColumn("dbo.Staff", "ContactPerson");
            DropColumn("dbo.Staff", "Education");
            DropColumn("dbo.Staff", "GraduationTime");
            DropColumn("dbo.Staff", "School");
            DropColumn("dbo.Staff", "EffectiveTime");
            DropColumn("dbo.Staff", "Certificates");
            DropColumn("dbo.Staff", "HouseholdRegister");
            DropColumn("dbo.Staff", "AccountProperties");
            DropColumn("dbo.Staff", "Phyle");
            DropColumn("dbo.Staff", "Political");
            DropColumn("dbo.Staff", "Marriage");
            DropColumn("dbo.Staff", "Fixedline");
            DropColumn("dbo.Staff", "Phone");
            DropColumn("dbo.Staff", "CompanyPhone");
            DropTable("dbo.TravelEntry");
            DropTable("dbo.Rankings");
            DropTable("dbo.ProductProcurementEntry");
            DropTable("dbo.ProductProcurement");
            DropTable("dbo.ProductIntroduction");
            DropTable("dbo.MeetIngRoom");
            DropTable("dbo.MeetIng");
            DropTable("dbo.GiftApplication");
            DropTable("dbo.DesignApplication");
            DropTable("dbo.OverTimeEntry");
            DropTable("dbo.LeaveEntry");
            DropTable("dbo.BlackBoard");
            DropTable("dbo.AccommodationApplication");
            RenameColumn(table: "dbo.MaterialEntry", name: "MaterialApplicationID", newName: "MaterialApplication_ID");
            RenameColumn(table: "dbo.VehicleApplication", name: "WorkToDoid", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.TravelApplication", name: "WorkToDoID", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.PriceAdjustmentApplication", name: "WorkToDoid", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.OverTimeApplication", name: "WorkToDoid", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.OfficialSealApplication", name: "WorkToDoID", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.MoneyApproval", name: "WorkToDoID", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.MaterialApplication", name: "WorkToDoid", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.Leave", name: "WorkToDoid", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.JobRequirementsApplication", name: "WorkToDoid", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.DepartureApplication", name: "WorkToDoid", newName: "WorkToDo_ID");
            RenameColumn(table: "dbo.Staff", name: "PositionID", newName: "Position_ID");
            RenameColumn(table: "dbo.AssessmentApplication", name: "WorkToDoid", newName: "WorkToDo_ID");
            AddColumn("dbo.VehicleApplication", "WorkToDoid", c => c.Int(nullable: false));
            AddColumn("dbo.TravelApplication", "WorkToDoID", c => c.Int(nullable: false));
            AddColumn("dbo.PriceAdjustmentApplication", "WorkToDoid", c => c.Int(nullable: false));
            AddColumn("dbo.OverTimeApplication", "WorkToDoid", c => c.Int(nullable: false));
            AddColumn("dbo.OfficialSealApplication", "WorkToDoID", c => c.Int(nullable: false));
            AddColumn("dbo.MoneyApproval", "WorkToDoID", c => c.Int(nullable: false));
            AddColumn("dbo.MaterialEntry", "MaterialApplicationID", c => c.Int(nullable: false));
            AddColumn("dbo.MaterialApplication", "WorkToDoid", c => c.Int(nullable: false));
            AddColumn("dbo.Leave", "WorkToDoid", c => c.Int(nullable: false));
            AddColumn("dbo.JobRequirementsApplication", "WorkToDoid", c => c.Int(nullable: false));
            AddColumn("dbo.DepartureApplication", "WorkToDoid", c => c.Int(nullable: false));
            AddColumn("dbo.Staff", "PositionID", c => c.Int(nullable: false));
            AddColumn("dbo.AssessmentApplication", "WorkToDoid", c => c.Int(nullable: false));
            CreateIndex("dbo.VehicleApplication", "WorkToDo_ID");
            CreateIndex("dbo.TravelApplication", "WorkToDo_ID");
            CreateIndex("dbo.PriceAdjustmentApplication", "WorkToDo_ID");
            CreateIndex("dbo.OverTimeApplication", "WorkToDo_ID");
            CreateIndex("dbo.OfficialSealApplication", "WorkToDo_ID");
            CreateIndex("dbo.MoneyApproval", "WorkToDo_ID");
            CreateIndex("dbo.MaterialEntry", "MaterialApplication_ID");
            CreateIndex("dbo.MaterialApplication", "WorkToDo_ID");
            CreateIndex("dbo.Leave", "WorkToDo_ID");
            CreateIndex("dbo.JobRequirementsApplication", "WorkToDo_ID");
            CreateIndex("dbo.DepartureApplication", "WorkToDo_ID");
            CreateIndex("dbo.Staff", "Position_ID");
            CreateIndex("dbo.AssessmentApplication", "WorkToDo_ID");
            AddForeignKey("dbo.MaterialEntry", "MaterialApplication_ID", "dbo.MaterialApplication", "ID");
            AddForeignKey("dbo.VehicleApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.TravelApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.PriceAdjustmentApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.OverTimeApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.OfficialSealApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.MoneyApproval", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.MaterialApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.Leave", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.JobRequirementsApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.DepartureApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
            AddForeignKey("dbo.Staff", "Position_ID", "dbo.Position", "ID");
            AddForeignKey("dbo.AssessmentApplication", "WorkToDo_ID", "dbo.WorkToDo", "ID");
        }
    }
}
