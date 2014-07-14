namespace Platform.Crm.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactPeople")]
    public partial class ContactPeople
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(50)]
        public string Rel_Name { get; set; }

        [StringLength(10)]
        public string Rel_Sex { get; set; }

        [StringLength(50)]
        public string Rel_Job { get; set; }

        [StringLength(50)]
        public string Rel_Phone { get; set; }

        [StringLength(50)]
        public string Rel_Mobile { get; set; }

        [StringLength(150)]
        public string Rel_Memo { get; set; }

        public DateTime? Createtime { get; set; }
    }
}
