namespace Platform.Account.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AccountDBContext : DbContext
    {
        public AccountDBContext()
            : base("name=AccountConnectionString")
        {
        }

        public virtual DbSet<LogException> LogException { get; set; }
        public virtual DbSet<LogUserOperatorInfo> LogUserOperatorInfo { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Orgnizition> Orgnizition { get; set; }
        public virtual DbSet<RoleAuthority> RoleAuthority { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAuthority> UserAuthority { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Menu
            modelBuilder.Entity<Menu>()
                .HasMany(e => e.SubMenus)
                .WithOptional(e => e.ParentMenu)
                .HasForeignKey(e => e.ParentID);
            #endregion

            #region Orgnizition
            modelBuilder.Entity<Orgnizition>()
                .HasMany(e => e.SubOrgnizitions)
                .WithOptional(e => e.ParentOrgnizition)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Orgnizitions)
                .WithMany(e => e.Roles)
                .Map(m =>
                {
                    m.MapLeftKey("OrgnizitionID");
                    m.MapRightKey("RoleID");
                    m.ToTable("OrgnizitionRole");
                });
            #endregion

            #region User
            modelBuilder.Entity<User>()
                .HasMany(e => e.Roles)
                .WithMany(e => e.Users)
                .Map(m =>
                {
                    m.MapLeftKey("UserID");
                    m.MapRightKey("RoleID");
                    m.ToTable("UserRole");
                });

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserAuthorites)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LogExceptions)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LogUserOperatorInfos)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserID);
            #endregion

            #region Role
            modelBuilder.Entity<Role>()
                .HasMany(e => e.RoleAuthorities)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleID);
            #endregion

            #region RoleAuthority
            modelBuilder.Entity<RoleAuthority>()
                .HasRequired(e => e.Menu)
                .WithMany(e => e.RoleAuthorities)
                .HasForeignKey(e => e.MenuID);
            #endregion

            #region UserAuthority
            modelBuilder.Entity<UserAuthority>()
                .HasRequired(e => e.Menu)
                .WithMany(e => e.UserAuthorities)
                .HasForeignKey(e => e.MenuID);
            #endregion

        }
    }
}
