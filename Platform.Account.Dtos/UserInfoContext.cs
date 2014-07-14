using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Web.Script.Serialization;

namespace Platform.Account.Dtos
{
    public class UserLoginContext : IPrincipal
    {
        public int UserID{get;set;}
        public string LoginName { get; set; }
        public string WorkID { get; set; }
        public string RealName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? UserType { get; set; }
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public string Roles { get; set; }
        public string Menus { get; set; }

        #region IPrincipal Members

        [ScriptIgnore]
        public IIdentity Identity
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsAdministrator() {
            return IsInRole("系统管理员");
        }

        public bool IsInRole(string role)
        {
            if (this.Roles.Split(',').Contains(role))
                return true;
            else
                return false;
        }

        #endregion
    }
}
