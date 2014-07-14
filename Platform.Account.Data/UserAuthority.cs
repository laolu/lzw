using Platform.Component.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Platform.Account.Data
{
    [Table("UserAuthority")]
    public class UserAuthority : Entity
    {
        public long UserID { get; set; }
        public long MenuID { get; set; }
        public int OperatorAuthority { get; set; }
        public virtual User User { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
