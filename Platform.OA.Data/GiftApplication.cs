namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiftApplication")]
    public partial class GiftApplication
    {
        public long ID { get; set; }

        public int Type { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        public string Note { get; set; }

        public long WorktodoID { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
