namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarInfo")]
    public partial class CarInfo
    {
        public CarInfo()
        {
            VehicleApplication = new HashSet<VehicleApplication>();
        }

        public long ID { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<VehicleApplication> VehicleApplication { get; set; }
    }
}
