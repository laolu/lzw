using Platform.Component.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Platform.Crm.Data.Context
{
    public class CrmUnitOfWorkContext : UnitOfWorkContextBase
    {
        public CrmUnitOfWorkContext(CrmDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
