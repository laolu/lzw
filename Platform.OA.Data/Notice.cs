namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notice")]
    public partial class Notice : Entity
    {
        

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public string Content { get; set; }

        public int BranchId { get; set; }

        public bool IsActive { get; set; }

        public int? StaffId { get; set; }

        [StringLength(255)]
        public string StaffName { get; set; }


    }
}
