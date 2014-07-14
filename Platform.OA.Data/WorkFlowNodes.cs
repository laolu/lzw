namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkFlowNodes : Entity
    {
        

        [Required]
        public string Name { get; set; }

        public int NodeType { get; set; }


    }
}
