namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobRequirementsApplication")]
    public partial class JobRequirementsApplication
    {
        public long ID { get; set; }

        public long WorkToDoid { get; set; }

        [Required]
        [StringLength(4000)]
        public string Job { get; set; }

        [StringLength(255)]
        public string Age { get; set; }

        public int Sex { get; set; }

        public int Marriage { get; set; }

        public string Record { get; set; }

        [StringLength(4000)]
        public string Qualification { get; set; }

        public DateTime CreateTime { get; set; }

        public long IsDeleted { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
