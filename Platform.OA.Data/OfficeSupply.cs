namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficeSupply")]
    public partial class OfficeSupply : Entity
    {
        public OfficeSupply()
        {
            OfficeSuppliesRequisitionDetail = new HashSet<OfficeSuppliesRequisitionDetail>();
            OfficeSupplyInDetail = new HashSet<OfficeSupplyInDetail>();
        }

        

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Brand { get; set; }

        [StringLength(255)]
        public string OfficeSupplyType { get; set; }

        [Required]
        [StringLength(255)]
        public string Unit { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public int? StaffID { get; set; }

        [StringLength(255)]
        public string StaffName { get; set; }



        public virtual ICollection<OfficeSuppliesRequisitionDetail> OfficeSuppliesRequisitionDetail { get; set; }

        public virtual ICollection<OfficeSupplyInDetail> OfficeSupplyInDetail { get; set; }
    }
}
