namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Branch")]
    public partial class Branch : Entity
    {
        public Branch()
        {
            Staff = new HashSet<Staff>();
            WorkFlowEntry = new HashSet<WorkFlowEntry>();
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Desc { get; set; }

        public int? Type { get; set; }

        public int ParentId { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }

        public virtual ICollection<WorkFlowEntry> WorkFlowEntry { get; set; }
    }
}
