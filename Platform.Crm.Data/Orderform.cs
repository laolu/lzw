namespace Platform.Crm.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orderform")]
    public partial class Orderform
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Order_Date { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Order_Address { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Order_Type { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime Createtime { get; set; }
    }
}
