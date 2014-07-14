namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RepairSys : Entity
    {
        

        public string RequirePeople { get; set; }

        public string BranchName { get; set; }

        public int? BranchID { get; set; }

        public int RequireType { get; set; }

        public string RequireContent { get; set; }

        public int priority { get; set; }

        public int StaffID { get; set; }

        public string DealDate { get; set; }

        public string note { get; set; }

        public int Status { get; set; }

        public string attachment { get; set; }



        public virtual Staff Staff { get; set; }
    }
}
