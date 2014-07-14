namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccommodationApplication")]
    public partial class AccommodationApplication
    {
        public long ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Note { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsDeleted { get; set; }

        public long WorkToDoID { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
