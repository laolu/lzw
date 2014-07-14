namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckContent")]
    public partial class CheckContent : Entity
    {
        

        public int WorkToDoID { get; set; }

        public int StaffID { get; set; }

        [Required]
        [StringLength(4000)]
        public string Content { get; set; }

        public int CheckType { get; set; }

        public int NodeNumber { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
