using Platform.Account.Dtos;
using Platform.Account.Data;
using Platform.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using log4net;
using Lzw.Common.BootstrapSupport;
using Platform.Account.IServices;
using Lzw.Common.Context;
using System.Web.Security;
using Lzw.Common.ValidateCode;
using Platform.Component.Tools;
using Platform.Web.Filter;

namespace Platform.Web.Controllers
{
    [BaseAuthorizeAttribute]
    public class HomeController : CommonController
    {
        private readonly IMappingEngine _mapper; 
        private readonly ILog _log;
        private readonly IUserService _userService;
        private readonly IUserAuthorityService _userAuthorityService;
        public HomeController(IUserService userService, IUserAuthorityService userAuthorityService,IMappingEngine mapper, ILog log)
        {
            _mapper = mapper;
            _log = log;
            _userService = userService;
            _userAuthorityService = userAuthorityService;
        }


        public ActionResult Index()
        {
            Information("欢迎大家使用联动智能化OA系统，如有任何问题请勿着急，将错误提交到技术部");
            return View();
        }

        public ActionResult SysMenu()
        {
            var principal = this.User as LzwFormsPrincipal<UserLoginContext>;
            var userContext = principal.UserData;
            IList<MenuDto> menus=null;
            if (userContext != null)
            {
                if (userContext.IsAdministrator())
                {
                    menus = _mapper.Map<IList<Menu>, IList<MenuDto>>(_userAuthorityService.GetAllSysMenus());
                }
                else
                {
                    menus = _mapper.Map<IList<Menu>, IList<MenuDto>>(_userAuthorityService.GetSysMenusByUserID(userContext.UserID));
                }
            }
            return PartialView("_Menu",menus);
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            var dto = new UserLoginDto();
            
            return View(dto);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLoginDto dto, string returnUrl)
        {
            if (dto.VerifyCode != this.TempData["ValidateCode"].ToString())
            {
                ModelState.AddModelError("", "验证码错误");
                return View(dto);
            }
            if (ModelState.IsValid && _userService.ValidateUser(dto.LoginName, dto.Password))
            {
                var model=_userService.GetUserInfoByLoginName(dto.LoginName);

                var userloginContext = _mapper.Map<User, UserLoginContext>(model);

                LzwFormsPrincipal<UserLoginContext>.SignIn(dto.LoginName, userloginContext, 120);

                //记录登陆日志
                //_log.Debug("asdasdasdasd");

                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "提供的用户名或密码不正确。");
            }

            return View(dto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            var result = new OperationResult(OperationResultType.Success);
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AjaxLogOff()
        {
            FormsAuthentication.SignOut();

            var result = new OperationResult(OperationResultType.Success);
            
            return Json(result);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
