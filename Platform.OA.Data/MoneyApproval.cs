namespace Platform.OA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MoneyApproval")]
    public partial class MoneyApproval
    {
        public long ID { get; set; }

        public long WorkToDoID { get; set; }

        public string recCompany { get; set; }

        public string BankName { get; set; }

        public string BankAccount { get; set; }

        public decimal amount { get; set; }

        public string payType { get; set; }

        public string note { get; set; }

        public string attachment { get; set; }

        public DateTime CreateTime { get; set; }

        public int Type { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string UPamount { get; set; }

        public virtual WorkToDo WorkToDo { get; set; }
    }
}
