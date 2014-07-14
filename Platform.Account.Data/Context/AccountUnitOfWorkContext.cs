using Platform.Component.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Platform.Account.Data.Context
{
    public class AccountUnitOfWorkContext : UnitOfWorkContextBase
    {
        public AccountUnitOfWorkContext(AccountDBContext dbContext)
            : base(dbContext)
        {

        }
    }
}
