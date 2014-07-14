namespace Platform.Account.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role : Entity
    {
        public Role()
        {
            Users = new HashSet<User>();
            Orgnizitions = new HashSet<Orgnizition>();
            RoleAuthorities = new HashSet<RoleAuthority>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int RoleType { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Orgnizition> Orgnizitions { get; set; }
        public virtual ICollection<RoleAuthority> RoleAuthorities { get; set; }
    }
}
