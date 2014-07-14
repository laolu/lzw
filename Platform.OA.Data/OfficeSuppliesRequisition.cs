namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficeSuppliesRequisition")]
    public partial class OfficeSuppliesRequisition : Entity
    {
        public OfficeSuppliesRequisition()
        {
            OfficeSuppliesRequisitionDetail = new HashSet<OfficeSuppliesRequisitionDetail>();
        }

        

        public DateTime OutDate { get; set; }

        public int OutStaffID { get; set; }

        [StringLength(255)]
        public string OutStaffName { get; set; }

        [Required]
        [StringLength(255)]
        public string Remark { get; set; }

        public int? StaffID { get; set; }

        [StringLength(255)]
        public string StaffName { get; set; }

        public decimal TotalAmount { get; set; }

        public bool Status { get; set; }

        public bool IsDelete { get; set; }



        public virtual ICollection<OfficeSuppliesRequisitionDetail> OfficeSuppliesRequisitionDetail { get; set; }
    }
}
