namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        public long ID { get; set; }

        public long StaffID { get; set; }

        public long DeputyID { get; set; }

        [Required]
        [StringLength(255)]
        public string WorkIDList { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool ISActivate { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Staff Staff1 { get; set; }
    }
}
