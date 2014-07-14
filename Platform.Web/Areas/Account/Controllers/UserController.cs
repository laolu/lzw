using AutoMapper;
using log4net;
using Mvc.JQuery.Datatables;
using Platform.Account.Data;
using Platform.Account.Dtos;
using Platform.Account.IServices;
using Platform.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Platform.Web.Areas.Account.Controllers
{
    public class UserController : BaseController
    {
        private readonly IMappingEngine _mapper;
        private readonly ILog _log4Net;
        private readonly IUserService _userService;
        public UserController(IUserService userService, IMappingEngine mapper, ILog log4Net)
            : base(log4Net)
        {
            _mapper = mapper;
            _log4Net = log4Net;
            _userService = userService;
        }
        public ActionResult Index()
        {
            _userService.Entities();
            return PartialView();
        }

        public DataTablesResult<UserDto> DataTable(DataTablesParam dataTableParam)
        {
            IList<UserDto> users = _mapper.Map<IList<User>, IList<UserDto>>(_userService.Entities().Where(x=>x.UserType!=0).ToList()); ;
            return DataTablesResult.CreateResultUsingEnumerable(users, dataTableParam);
        }

    }
}
