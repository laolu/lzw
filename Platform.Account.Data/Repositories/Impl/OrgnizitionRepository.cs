using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using Platform.Component.Data;
using Platform.Account.Data;
using Platform.Account.Data.Context;
using Platform.Account.Data.Repositories;

namespace Platform.Account.Data.Repositories.Impl
{
	/// <summary>
    /// Orgnizition
    /// </summary>
	public class OrgnizitionRepository : EFRepositoryBase<Orgnizition>,IOrgnizitionRepository
	{
        public OrgnizitionRepository(AccountUnitOfWorkContext unitOfWork) : base(unitOfWork) { }
	}
}