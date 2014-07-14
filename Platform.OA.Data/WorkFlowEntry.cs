namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkFlowEntry")]
    public partial class WorkFlowEntry : Entity
    {
        

        public int WorkFlowID { get; set; }

        public int NoteSerils { get; set; }

        public int PositionID { get; set; }

        public int? BranchID { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Position Position { get; set; }

        public virtual WorkFlow WorkFlow { get; set; }
    }
}
