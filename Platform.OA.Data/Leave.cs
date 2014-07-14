namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Leave")]
    public partial class Leave
    {
        public Leave()
        {
            LeaveEntry = new HashSet<LeaveEntry>();
        }

        public long ID { get; set; }

        public long WorkToDoid { get; set; }

        public int Types { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Times { get; set; }

        [Required]
        [StringLength(4000)]
        public string Note { get; set; }

        public long AgentID { get; set; }

        [StringLength(4000)]
        public string Jobs { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }

        public virtual ICollection<LeaveEntry> LeaveEntry { get; set; }
    }
}
