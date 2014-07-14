namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialEntry")]
    public partial class MaterialEntry
    {
        public long ID { get; set; }

        public long MaterialApplicationID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Number { get; set; }

        public decimal Price { get; set; }

        public decimal Amount { get; set; }

        [StringLength(4000)]
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsDeleted { get; set; }

        public virtual MaterialApplication MaterialApplication { get; set; }
    }
}
