namespace Platform.Crm.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int ID { get; set; }

        public int? CityID { get; set; }

        public int? Grade { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Cus_Name { get; set; }

        [StringLength(50)]
        public string Cus_Address { get; set; }

        [StringLength(50)]
        public string Cus_Post { get; set; }

        [StringLength(50)]
        public string Cus_Phone { get; set; }

        [StringLength(50)]
        public string Cus_Fax { get; set; }

        [StringLength(50)]
        public string Cus_Web { get; set; }

        [StringLength(50)]
        public string Cus_Permit { get; set; }

        [StringLength(50)]
        public string Cus_Person { get; set; }

        [StringLength(50)]
        public string Cus_Fund { get; set; }

        [StringLength(50)]
        public string Cus_Turnover { get; set; }

        [StringLength(50)]
        public string Cus_Bank { get; set; }

        [StringLength(50)]
        public string Cus_BankNo { get; set; }

        [StringLength(50)]
        public string Cus_Dtax { get; set; }

        [StringLength(50)]
        public string Cus_Gtax { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? State { get; set; }
    }
}
