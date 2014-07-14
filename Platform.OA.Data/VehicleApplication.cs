namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleApplication")]
    public partial class VehicleApplication
    {
        public long ID { get; set; }

        public long WorkToDoid { get; set; }

        public long? DriverID { get; set; }

        public decimal Number { get; set; }

        public DateTime UseDate { get; set; }

        public DateTime BackDate { get; set; }

        [Required]
        public string Destination { get; set; }

        public long CarID { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(1000)]
        public string StaffName { get; set; }

        public virtual CarInfo CarInfo { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
