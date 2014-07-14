using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Web.Script.Serialization;

namespace Lzw.Common.Context
{
    public class UserInfoContext : IPrincipal
    {
        public int UserID{get;set;}
        public string UserName { get; set; }
        public string RealName { get; set; }
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }

        #region IPrincipal Members

        [ScriptIgnore]
        public IIdentity Identity
        {
            get { throw new NotImplementedException(); }
        }

        public bool HasPermission(string permission)
        {
            return true;
        }

        public bool IsInRole(string role)
        {
            if (String.Compare(role, "Admin", StringComparison.OrdinalIgnoreCase) == 0)
                return true;
            else
                return false;
        }

        #endregion
    }
}
