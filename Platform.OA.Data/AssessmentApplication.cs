namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssessmentApplication")]
    public partial class AssessmentApplication
    {
        public long ID { get; set; }

        public long WorkToDoid { get; set; }

        public long EmployeeId { get; set; }

        public DateTime InDate { get; set; }

        public int Discipline { get; set; }

        public int Attitude { get; set; }

        public int Perform { get; set; }

        public int Spirit { get; set; }

        public int Ability { get; set; }

        public int Personality { get; set; }

        public int Total { get; set; }

        public int AssessmentType { get; set; }

        public decimal Initial { get; set; }

        public decimal Salary { get; set; }

        public DateTime StartDate { get; set; }

        public string Director { get; set; }

        public string President { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
