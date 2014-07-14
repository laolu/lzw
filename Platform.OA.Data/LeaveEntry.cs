namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeaveEntry")]
    public partial class LeaveEntry
    {
        public long ID { get; set; }

        public long OrderID { get; set; }

        public long WorkID { get; set; }

        public DateTime CompleteTime { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Leave Leave { get; set; }

        public virtual WorkLogDetail WorkLogDetail { get; set; }
    }
}
