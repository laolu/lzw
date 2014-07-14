namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkFlow")]
    public partial class WorkFlow : Entity
    {
        public WorkFlow()
        {
            WorkFlowEntry = new HashSet<WorkFlowEntry>();
            WorkToDo = new HashSet<WorkToDo>();
        }

        

        [Required]
        [StringLength(255)]
        public string WorkFlowName { get; set; }

        [Required]
        [StringLength(50)]
        public string TableName { get; set; }

        [Required]
        [StringLength(1000)]
        public string TableUrl { get; set; }

        [StringLength(2000)]
        public string Note { get; set; }

        public bool IsActive { get; set; }



        public int? WorkFlowType { get; set; }

        public virtual ICollection<WorkFlowEntry> WorkFlowEntry { get; set; }

        public virtual ICollection<WorkToDo> WorkToDo { get; set; }
    }
}
