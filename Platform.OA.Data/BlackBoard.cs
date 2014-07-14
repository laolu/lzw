namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlackBoard")]
    public partial class BlackBoard
    {
        public long ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Title { get; set; }

        public long StaffID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime endDate { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
