namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkToDo")]
    public partial class WorkToDo : Entity
    {
        public WorkToDo()
        {
            AssessmentApplication = new HashSet<AssessmentApplication>();
            CheckContent = new HashSet<CheckContent>();
            DepartureApplication = new HashSet<DepartureApplication>();
            JobRequirementsApplication = new HashSet<JobRequirementsApplication>();
            Leave = new HashSet<Leave>();
            MaterialApplication = new HashSet<MaterialApplication>();
            MoneyApproval = new HashSet<MoneyApproval>();
            OfficialSealApplication = new HashSet<OfficialSealApplication>();
            OverTimeApplication = new HashSet<OverTimeApplication>();
            PriceAdjustmentApplication = new HashSet<PriceAdjustmentApplication>();
            TravelApplication = new HashSet<TravelApplication>();
            VehicleApplication = new HashSet<VehicleApplication>();
        }

        

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public int WorkFlowID { get; set; }

        public int StaffID { get; set; }

        public int StateNow { get; set; }



        public virtual ICollection<AssessmentApplication> AssessmentApplication { get; set; }

        public virtual ICollection<CheckContent> CheckContent { get; set; }

        public virtual ICollection<DepartureApplication> DepartureApplication { get; set; }

        public virtual ICollection<JobRequirementsApplication> JobRequirementsApplication { get; set; }

        public virtual ICollection<Leave> Leave { get; set; }

        public virtual ICollection<MaterialApplication> MaterialApplication { get; set; }

        public virtual ICollection<MoneyApproval> MoneyApproval { get; set; }

        public virtual ICollection<OfficialSealApplication> OfficialSealApplication { get; set; }

        public virtual ICollection<OverTimeApplication> OverTimeApplication { get; set; }

        public virtual ICollection<PriceAdjustmentApplication> PriceAdjustmentApplication { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual ICollection<TravelApplication> TravelApplication { get; set; }

        public virtual ICollection<VehicleApplication> VehicleApplication { get; set; }

        public virtual WorkFlow WorkFlow { get; set; }
    }
}
