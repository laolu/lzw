namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepartureApplication")]
    public partial class DepartureApplication
    {
        public long ID { get; set; }

        public long WorkToDoid { get; set; }

        public DateTime Indate { get; set; }

        public DateTime LeaveDate { get; set; }

        public bool IsHaveContract { get; set; }

        [Required]
        [StringLength(4000)]
        public string Note { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsDeleted { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
