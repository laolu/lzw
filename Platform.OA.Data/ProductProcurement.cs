namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductProcurement")]
    public partial class ProductProcurement
    {
        public long ID { get; set; }

        public long worktodoID { get; set; }

        [Required]
        public string Note { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual WorkLogDetail WorkLogDetail { get; set; }
    }
}
