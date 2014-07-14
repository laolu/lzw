namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OilCardLog")]
    public partial class OilCardLog : Entity
    {
        

        public int OilCardID { get; set; }

        public decimal Amount { get; set; }

        public DateTime LogDate { get; set; }

        public bool Status { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        public int? StaffID { get; set; }

        [StringLength(255)]
        public string StaffName { get; set; }



        public virtual OilCard OilCard { get; set; }
    }
}
