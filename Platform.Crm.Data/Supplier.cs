namespace Platform.Crm.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(2000)]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        public string Brand { get; set; }

        public int State { get; set; }

        [StringLength(255)]
        public string Bank { get; set; }

        public string Account { get; set; }

        public string LegalPerson { get; set; }

        public int Area { get; set; }

        [StringLength(255)]
        public string Fax { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
