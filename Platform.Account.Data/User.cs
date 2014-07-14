namespace Platform.Account.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User : Entity
    {
        public User()
        {
            Roles = new HashSet<Role>();
            LogExceptions = new HashSet<LogException>();
            LogUserOperatorInfos = new HashSet<LogUserOperatorInfo>();
        }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(50)]
        public string WorkID { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }
        public int? UserType { get; set; }
        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<UserAuthority> UserAuthorites { get; set; }

        public virtual ICollection<LogException> LogExceptions { get; set; }

        public virtual ICollection<LogUserOperatorInfo> LogUserOperatorInfos { get; set; }
    }
}
