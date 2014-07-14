namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MeetIng")]
    public partial class MeetIng
    {
        public long ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public long RoomID { get; set; }

        [Required]
        [StringLength(2000)]
        public string StaffIDS { get; set; }

        [StringLength(4000)]
        public string MeetInData { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsDeleted { get; set; }

        public virtual MeetIngRoom MeetIngRoom { get; set; }
    }
}
