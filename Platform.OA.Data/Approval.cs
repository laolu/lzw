namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Approval")]
    public partial class Approval
    {
        public long ID { get; set; }

        public int worktodoid { get; set; }

        public int staffid { get; set; }

        public int? deputyid { get; set; }

        public DateTime? startdate { get; set; }

        public DateTime? enddate { get; set; }
    }
}
