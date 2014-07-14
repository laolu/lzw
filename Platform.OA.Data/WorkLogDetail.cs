namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkLogDetail")]
    public partial class WorkLogDetail : Entity
    {
        

        public int WorkLogId { get; set; }

        public DateTime LogTime { get; set; }

        public string LogTimeDesc { get; set; }

        public string LogItem { get; set; }

        public string LogContent { get; set; }

        public string LogRemark { get; set; }

        public int CreateByUserId { get; set; }



        public virtual WorkLog WorkLog { get; set; }
    }
}
