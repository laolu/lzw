namespace Platform.Crm.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contacts
    {
        public int ID { get; set; }

        public int orderID { get; set; }

        public int Type { get; set; }

        public string Name { get; set; }

        public string Post { get; set; }

        public string Telephone { get; set; }

        public string Phone { get; set; }

        public string Phone1 { get; set; }

        public string EMail { get; set; }

        public string QQ { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
