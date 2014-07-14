namespace Platform.Crm.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitRecord")]
    public partial class VisitRecord
    {
        public int ID { get; set; }

        public int? UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        public int VisitWay { get; set; }

        public int CustomerId { get; set; }

        public int ProjectId { get; set; }

        public int FollowLevel { get; set; }

        public int FollowStep { get; set; }

        public int ProductType { get; set; }

        public int Probability { get; set; }

        [StringLength(400)]
        public string Detail { get; set; }

        public DateTime VisitTime { get; set; }

        public DateTime CreateTime { get; set; }

        public int AreaDemand { get; set; }

        public int PriceResponse { get; set; }

        public int CognitiveChannel { get; set; }

        public int Focus { get; set; }

        public int Motivation { get; set; }

        public int CityId { get; set; }

        public int AreaId { get; set; }
    }
}
