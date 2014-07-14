namespace Platform.Account.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogException")]
    public partial class LogException : Entity
    {
        public long UserID { get; set; }

        [StringLength(255)]
        public string Thread { get; set; }
        [StringLength(50)]
        public string Level { get; set; }
        [StringLength(255)]
        public string Logger { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        [StringLength(2000)]
        public string Exception { get; set; }

        public virtual User User { get; set; }
    }
}
