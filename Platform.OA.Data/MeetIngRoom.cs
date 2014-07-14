namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MeetIngRoom")]
    public partial class MeetIngRoom
    {
        public MeetIngRoom()
        {
            MeetIng = new HashSet<MeetIng>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(10)]
        public string CreateTime { get; set; }

        public virtual ICollection<MeetIng> MeetIng { get; set; }
    }
}
