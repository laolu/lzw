namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductIntroduction")]
    public partial class ProductIntroduction
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Note { get; set; }

        public string Reason { get; set; }

        public string attachment { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }

        public long WorktodoID { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
