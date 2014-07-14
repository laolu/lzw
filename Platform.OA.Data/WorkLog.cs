namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkLog")]
    public partial class WorkLog : Entity
    {
        public WorkLog()
        {
            WorkLogDetail = new HashSet<WorkLogDetail>();
        }

        

        public DateTime LogDate { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        public int CreateByUserId { get; set; }



        public virtual ICollection<WorkLogDetail> WorkLogDetail { get; set; }
    }
}
