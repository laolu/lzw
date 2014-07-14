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
    /// Menu
    /// </summary>
	public class MenuRepository : EFRepositoryBase<Menu>,IMenuRepository
	{
        public MenuRepository(AccountUnitOfWorkContext unitOfWork) : base(unitOfWork) { }
	}
}