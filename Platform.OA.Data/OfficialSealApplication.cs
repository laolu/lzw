namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficialSealApplication")]
    public partial class OfficialSealApplication
    {
        public long ID { get; set; }

        public long WorkToDoID { get; set; }

        public string TypeList { get; set; }

        public string CompanyList { get; set; }

        [Required]
        [StringLength(1000)]
        public string Remark { get; set; }

        public bool IsDelete { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
