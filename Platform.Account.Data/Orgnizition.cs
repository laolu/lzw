using Platform.Component.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Platform.Account.Data
{
    [Table("Orgnizition")]
    public class Orgnizition : Entity
    {
        public Orgnizition() {
            SubOrgnizitions = new HashSet<Orgnizition>();
            Roles = new HashSet<Role>();
        }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Type { get; set; }

        public long? ParentID { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        public virtual Orgnizition ParentOrgnizition { get; set; }
        public virtual ICollection<Orgnizition> SubOrgnizitions { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
