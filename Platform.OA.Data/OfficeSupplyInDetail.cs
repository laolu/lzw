namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficeSupplyInDetail")]
    public partial class OfficeSupplyInDetail : Entity
    {
        

        public int OfficeSupplyInID { get; set; }

        public int OfficeSupplyID { get; set; }

        public DateTime InDate { get; set; }

        public int Num { get; set; }

        public decimal Price { get; set; }



        public virtual OfficeSupply OfficeSupply { get; set; }

        public virtual OfficeSupplyIn OfficeSupplyIn { get; set; }
    }
}
