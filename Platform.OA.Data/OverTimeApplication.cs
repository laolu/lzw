namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OverTimeApplication")]
    public partial class OverTimeApplication
    {
        public OverTimeApplication()
        {
            OverTimeEntry = new HashSet<OverTimeEntry>();
        }

        public long ID { get; set; }

        public long WorkToDoid { get; set; }

        public int TypesID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public double Times { get; set; }

        [Required]
        [StringLength(4000)]
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }

        public virtual ICollection<OverTimeEntry> OverTimeEntry { get; set; }
    }
}
