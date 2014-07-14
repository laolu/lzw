namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceAdjustmentApplication")]
    public partial class PriceAdjustmentApplication
    {
        public long ID { get; set; }

        public long WorkToDoid { get; set; }

        [Required]
        [StringLength(4000)]
        public string Note { get; set; }

        [StringLength(4000)]
        public string attachment { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public bool IsDeleted { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
