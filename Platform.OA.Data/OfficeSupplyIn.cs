namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficeSupplyIn")]
    public partial class OfficeSupplyIn : Entity
    {
        public OfficeSupplyIn()
        {
            OfficeSupplyInDetail = new HashSet<OfficeSupplyInDetail>();
        }

        

        public DateTime InDate { get; set; }

        [Required]
        [StringLength(200)]
        public string SupplierName { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public decimal TotalAmount { get; set; }

        public bool Status { get; set; }

        public bool IsDelete { get; set; }

        public int? StaffID { get; set; }

        [StringLength(255)]
        public string StaffName { get; set; }



        public virtual ICollection<OfficeSupplyInDetail> OfficeSupplyInDetail { get; set; }
    }
}
