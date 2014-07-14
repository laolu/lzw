namespace Platform.Crm.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CrmDbContext : DbContext
    {
        public CrmDbContext()
            : base("name=CrmConnectionString")
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<VisitRecord> VisitRecord { get; set; }
        public virtual DbSet<ContactPeople> ContactPeople { get; set; }
        public virtual DbSet<CustomerService> CustomerService { get; set; }
        public virtual DbSet<Orderform> Orderform { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerService>()
                .Property(e => e.Ser_State)
                .IsFixedLength();

            modelBuilder.Entity<OrderProduct>()
                .Property(e => e.Product_ID)
                .IsFixedLength();
        }
    }
}
