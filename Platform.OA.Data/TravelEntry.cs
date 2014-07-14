namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TravelEntry")]
    public partial class TravelEntry
    {
        public long ID { get; set; }

        public long OrderID { get; set; }

        public decimal? Sale { get; set; }

        [Column(TypeName = "money")]
        public decimal? Back { get; set; }

        [Column(TypeName = "money")]
        public decimal? money { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(2000)]
        public string Note { get; set; }
    }
}
