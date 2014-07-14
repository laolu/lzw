namespace Platform.OA.Data
{
    using Platform.Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OilCard")]
    public partial class OilCard : Entity
    {
        public OilCard()
        {
            OilCard1 = new HashSet<OilCard>();
            OilCardLog = new HashSet<OilCardLog>();
        }

        

        [Required]
        [StringLength(255)]
        public string CardNo { get; set; }

        [StringLength(255)]
        public string CarNo { get; set; }

        public int CardType { get; set; }

        public decimal Amount { get; set; }

        public bool Status { get; set; }

        public long? ParentId { get; set; }



        public virtual ICollection<OilCard> OilCard1 { get; set; }

        public virtual OilCard OilCard2 { get; set; }

        public virtual ICollection<OilCardLog> OilCardLog { get; set; }
    }
}
