namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TravelApplication")]
    public partial class TravelApplication
    {
        public long ID { get; set; }

        public long WorkToDoID { get; set; }

        [Required]
        public string Path { get; set; }

        public DateTime TravelDate { get; set; }

        public DateTime BackDate { get; set; }

        public double TravelSumDay { get; set; }

        [StringLength(255)]
        public string PeopleTogether { get; set; }

        public long? CarID { get; set; }

        public decimal TravelAdvance { get; set; }

        [Required]
        [StringLength(1000)]
        public string Remark { get; set; }

        public bool IsDelete { get; set; }

        public int StaffId { get; set; }

        [StringLength(255)]
        public string StaffName { get; set; }

        public DateTime CreateTime { get; set; }

        public int? PromotionID { get; set; }

        [Required]
        [StringLength(50)]
        public string Regional { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
