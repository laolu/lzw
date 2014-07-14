namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialApplication")]
    public partial class MaterialApplication
    {
        public MaterialApplication()
        {
            MaterialEntry = new HashSet<MaterialEntry>();
        }

        public long ID { get; set; }

        public long WorkToDoid { get; set; }

        public DateTime CreateTime { get; set; }

        public bool Isdeleted { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }

        public virtual ICollection<MaterialEntry> MaterialEntry { get; set; }
    }
}
