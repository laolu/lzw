using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Platform.Account.Dtos
{
    public class MenuDto
    {
        public long ID { get; set; }
        public long? ParentID { get; set; }
        public string MenuName { get; set; }
        public string MenuIcon { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public int ClickType { get; set; }
        public virtual ICollection<MenuDto> SubMenus { get; set; }
    }
}
