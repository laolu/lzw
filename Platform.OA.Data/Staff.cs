namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        public Staff()
        {
            Agent = new HashSet<Agent>();
            Agent1 = new HashSet<Agent>();
            AssessmentApplication = new HashSet<AssessmentApplication>();
            BlackBoard = new HashSet<BlackBoard>();
            CheckContent = new HashSet<CheckContent>();
            Leave = new HashSet<Leave>();
            RepairSys = new HashSet<RepairSys>();
            WorkToDo = new HashSet<WorkToDo>();
            VehicleApplication = new HashSet<VehicleApplication>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(300)]
        public string CoverPicture { get; set; }

        public int Gender { get; set; }

        public long PositionID { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string CompanyPhone { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fixedline { get; set; }

        public int? Marriage { get; set; }

        public int? Political { get; set; }

        [StringLength(255)]
        public string Phyle { get; set; }

        public int? AccountProperties { get; set; }

        [StringLength(255)]
        public string HouseholdRegister { get; set; }

        [StringLength(255)]
        public string Certificates { get; set; }

        public DateTime? EffectiveTime { get; set; }

        [StringLength(255)]
        public string School { get; set; }

        public DateTime? GraduationTime { get; set; }

        public int? Education { get; set; }

        [StringLength(255)]
        public string ContactPerson { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        [StringLength(255)]
        public string Relationship { get; set; }

        public string Email { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string OldAddress { get; set; }

        public int? Company { get; set; }

        [StringLength(50)]
        public string Level { get; set; }

        [StringLength(50)]
        public string JiBie { get; set; }

        public DateTime? InDate { get; set; }

        public DateTime? PositiveDate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Insurance { get; set; }

        public DateTime? PayDate { get; set; }

        public DateTime? DepartureDate { get; set; }

        public int? DepartureType { get; set; }

        public DateTime? SurrenderDate { get; set; }

        [StringLength(1000)]
        public string DepartureNote { get; set; }

        public long? BranchId { get; set; }

        public bool Principal { get; set; }

        public int Status { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<Agent> Agent { get; set; }

        public virtual ICollection<Agent> Agent1 { get; set; }

        public virtual ICollection<AssessmentApplication> AssessmentApplication { get; set; }

        public virtual ICollection<BlackBoard> BlackBoard { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual ICollection<CheckContent> CheckContent { get; set; }

        public virtual ICollection<Leave> Leave { get; set; }

        public virtual Position Position { get; set; }

        public virtual ICollection<RepairSys> RepairSys { get; set; }

        public virtual ICollection<WorkToDo> WorkToDo { get; set; }

        public virtual ICollection<VehicleApplication> VehicleApplication { get; set; }
    }
}
