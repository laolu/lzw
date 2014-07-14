namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Position")]
    public partial class Position : Entity
    {
        public Position()
        {
            Staff = new HashSet<Staff>();
            WorkFlowEntry = new HashSet<WorkFlowEntry>();
        }

        

        [Required]
        [StringLength(255)]
        public string Name { get; set; }



        public int? Level { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }

        public virtual ICollection<WorkFlowEntry> WorkFlowEntry { get; set; }
    }
}
