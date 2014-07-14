using Platform.Component.Data;
using Platform.OA.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Platform.Account.Data.Context
{
    public class OAUnitOfWorkContext : UnitOfWorkContextBase
    {
        public OAUnitOfWorkContext(OADBContext dbContext)
            : base(dbContext)
        {

        }
    }
}
