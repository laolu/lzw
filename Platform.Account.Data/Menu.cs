using Platform.Component.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Platform.Account.Data
{
    [Table("Menu")]
    public class Menu : Entity
    {
        public Menu() {
            SubMenus = new HashSet<Menu>();
            RoleAuthorities = new HashSet<RoleAuthority>();
            UserAuthorities = new HashSet<UserAuthority>();
        }

        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }
        public long? ParentID { get; set; }

        [StringLength(50)]
        public string ModuleName { get; set; }
        public int MenuType { get; set; }
        public bool IsLeaf { get; set; }
        public int OrderCode { get; set; }

        [StringLength(255)]
        public string MenuIcon { get; set; }

        [StringLength(255)]
        public string MenuCode { get; set; }
        [StringLength(255)]
        public string IndexCode { get; set; }
        public int ClickType { get; set; }
        public int OperatorCode { get; set; }
        public virtual Menu ParentMenu { get; set; }
        public virtual ICollection<Menu> SubMenus { get; set; }
        public virtual ICollection<RoleAuthority> RoleAuthorities { get; set; }
        public virtual ICollection<UserAuthority> UserAuthorities { get; set; }
    }
}
