namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficeSuppliesRequisitionDetail")]
    public partial class OfficeSuppliesRequisitionDetail : Entity
    {
        

        public int OfficeSuppliesRequisitionID { get; set; }

        public int OfficeSupplyID { get; set; }

        public int Num { get; set; }

        public decimal Price { get; set; }

        public DateTime OutDate { get; set; }



        public virtual OfficeSuppliesRequisition OfficeSuppliesRequisition { get; set; }

        public virtual OfficeSupply OfficeSupply { get; set; }
    }
}
