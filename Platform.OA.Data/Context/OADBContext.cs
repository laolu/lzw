namespace Platform.OA.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OADBContext : DbContext
    {
        public OADBContext()
            : base("name=OAConnectionString")
        {
        }
        public virtual DbSet<AccommodationApplication> AccommodationApplication { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Approval> Approval { get; set; }
        public virtual DbSet<AssessmentApplication> AssessmentApplication { get; set; }
        public virtual DbSet<BlackBoard> BlackBoard { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<CarInfo> CarInfo { get; set; }
        public virtual DbSet<CheckContent> CheckContent { get; set; }
        public virtual DbSet<DepartureApplication> DepartureApplication { get; set; }
        public virtual DbSet<DesignApplication> DesignApplication { get; set; }
        public virtual DbSet<GiftApplication> GiftApplication { get; set; }
        public virtual DbSet<JobRequirementsApplication> JobRequirementsApplication { get; set; }
        public virtual DbSet<Leave> Leave { get; set; }
        public virtual DbSet<LeaveEntry> LeaveEntry { get; set; }
        public virtual DbSet<MaterialApplication> MaterialApplication { get; set; }
        public virtual DbSet<MaterialEntry> MaterialEntry { get; set; }
        public virtual DbSet<MeetIng> MeetIng { get; set; }
        public virtual DbSet<MeetIngRoom> MeetIngRoom { get; set; }
        public virtual DbSet<MoneyApproval> MoneyApproval { get; set; }
        public virtual DbSet<Notice> Notice { get; set; }
        public virtual DbSet<OfficeSuppliesRequisition> OfficeSuppliesRequisition { get; set; }
        public virtual DbSet<OfficeSuppliesRequisitionDetail> OfficeSuppliesRequisitionDetail { get; set; }
        public virtual DbSet<OfficeSupply> OfficeSupply { get; set; }
        public virtual DbSet<OfficeSupplyIn> OfficeSupplyIn { get; set; }
        public virtual DbSet<OfficeSupplyInDetail> OfficeSupplyInDetail { get; set; }
        public virtual DbSet<OfficialSealApplication> OfficialSealApplication { get; set; }
        public virtual DbSet<OilCard> OilCard { get; set; }
        public virtual DbSet<OilCardLog> OilCardLog { get; set; }
        public virtual DbSet<OverTimeApplication> OverTimeApplication { get; set; }
        public virtual DbSet<OverTimeEntry> OverTimeEntry { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<PriceAdjustmentApplication> PriceAdjustmentApplication { get; set; }
        public virtual DbSet<ProductIntroduction> ProductIntroduction { get; set; }
        public virtual DbSet<ProductProcurement> ProductProcurement { get; set; }
        public virtual DbSet<Rankings> Rankings { get; set; }
        public virtual DbSet<RepairSys> RepairSys { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<TravelApplication> TravelApplication { get; set; }
        public virtual DbSet<TravelEntry> TravelEntry { get; set; }
        public virtual DbSet<VehicleApplication> VehicleApplication { get; set; }
        public virtual DbSet<WorkFlow> WorkFlow { get; set; }
        public virtual DbSet<WorkFlowEntry> WorkFlowEntry { get; set; }
        public virtual DbSet<WorkFlowNodes> WorkFlowNodes { get; set; }
        public virtual DbSet<WorkLog> WorkLog { get; set; }
        public virtual DbSet<WorkLogDetail> WorkLogDetail { get; set; }
        public virtual DbSet<WorkToDo> WorkToDo { get; set; }
        public virtual DbSet<ProductProcurementEntry> ProductProcurementEntry { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarInfo>()
                            .HasMany(e => e.VehicleApplication)
                            .WithRequired(e => e.CarInfo)
                            .HasForeignKey(e => e.CarID)
                            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leave>()
                .HasMany(e => e.LeaveEntry)
                .WithRequired(e => e.Leave)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeetIngRoom>()
                .Property(e => e.CreateTime)
                .IsFixedLength();

            modelBuilder.Entity<MeetIngRoom>()
                .HasMany(e => e.MeetIng)
                .WithRequired(e => e.MeetIngRoom)
                .HasForeignKey(e => e.RoomID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OilCard>()
                .HasMany(e => e.OilCard1)
                .WithOptional(e => e.OilCard2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<OverTimeApplication>()
                .HasMany(e => e.OverTimeEntry)
                .WithRequired(e => e.OverTimeApplication)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Agent)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.DeputyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Agent1)
                .WithRequired(e => e.Staff1)
                .HasForeignKey(e => e.StaffID);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.AssessmentApplication)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.BlackBoard)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.CheckContent)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Leave)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.AgentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.VehicleApplication)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.DriverID);

            modelBuilder.Entity<TravelEntry>()
                .Property(e => e.Back)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TravelEntry>()
                .Property(e => e.money)
                .HasPrecision(19, 4);

            //modelBuilder.Entity<WorkLogDetail>()
            //    .HasMany(e => e.LeaveEntry)
            //    .WithRequired(e => e.WorkLogDetail)
            //    .HasForeignKey(e => e.WorkID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WorkLogDetail>()
            //    .HasMany(e => e.OverTimeEntry)
            //    .WithRequired(e => e.WorkLogDetail)
            //    .HasForeignKey(e => e.WorkID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WorkLogDetail>()
            //    .HasMany(e => e.ProductProcurement)
            //    .WithRequired(e => e.WorkLogDetail)
            //    .HasForeignKey(e => e.worktodoID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WorkToDo>()
            //    .HasMany(e => e.AccommodationApplication)
            //    .WithRequired(e => e.WorkToDo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WorkToDo>()
            //    .HasMany(e => e.DesignApplication)
            //    .WithRequired(e => e.WorkToDo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WorkToDo>()
            //    .HasMany(e => e.GiftApplication)
            //    .WithRequired(e => e.WorkToDo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WorkToDo>()
            //    .HasMany(e => e.ProductIntroduction)
            //    .WithRequired(e => e.WorkToDo)
            //    .WillCascadeOnDelete(false);
        }
    }
}
