namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DesignApplication")]
    public partial class DesignApplication
    {
        public long ID { get; set; }

        public int Type { get; set; }

        [Required]
        public string Note { get; set; }

        public bool ISPrinting { get; set; }

        public int CompanyID { get; set; }

        public DateTime HaveTime { get; set; }

        public DateTime OverTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }

        public long WorkToDoID { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
