using AutoMapper;
using log4net;
using Platform.Account.Data;
using Platform.Account.Dtos;
using Platform.Account.IServices;
using Platform.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Platform.Web.Areas.OA.Controllers
{
    public class MyCenterController : BaseController
    {
        private readonly IMappingEngine _mapper;
        private readonly IUserAuthorityService _userAuthorityService;
        private readonly ILog _log4Net;
        public MyCenterController(IUserAuthorityService userAuthorityService, ILog log4Net, IMappingEngine mapper)
            : base(log4Net)
        {
            _mapper = mapper;
            _log4Net=log4Net;
            _userAuthorityService = userAuthorityService;
        }

        public ActionResult Index()
        {
            if (base.UserContext.IsAdministrator())
            {
                return PartialView("_InformationCenter");
            }
            else
            {
            }
            return PartialView("_MarketingCenter");
        }

        public ActionResult CenterMenu()
        {
            IList<MenuDto> menus = null;

                if (base.UserContext.IsAdministrator())
                {
                    menus = menus = _mapper.Map<IList<Menu>, IList<MenuDto>>(_userAuthorityService.GetAllCenterMenus());
                }
                else
                {
                    menus = menus = _mapper.Map<IList<Menu>, IList<MenuDto>>(_userAuthorityService.GetCenterMenusByUserID(base.UserContext.UserID));
                }

            return PartialView(menus);
        }

    }
}
