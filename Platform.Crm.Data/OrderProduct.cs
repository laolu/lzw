namespace Platform.Crm.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderProduct")]
    public partial class OrderProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderformID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Product_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public double Order_Num { get; set; }

        public DateTime? Createtime { get; set; }
    }
}
