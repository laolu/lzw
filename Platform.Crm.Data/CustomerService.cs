namespace Platform.Crm.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerService")]
    public partial class CustomerService
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ser_TypeID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(10)]
        public string Ser_State { get; set; }

        [StringLength(50)]
        public string Ser_Creator { get; set; }

        public DateTime? Ser_CreateDate { get; set; }

        public DateTime? Ser_Distribute { get; set; }

        [StringLength(50)]
        public string Ser_People { get; set; }

        public DateTime? Ser_DealDate { get; set; }

        [StringLength(50)]
        public string Ser_Result { get; set; }

        public int? Star_ID { get; set; }

        public DateTime? Createtime { get; set; }
    }
}
