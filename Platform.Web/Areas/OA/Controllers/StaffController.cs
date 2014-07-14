﻿using AutoMapper;
using log4net;
using Platform.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Platform.Web.Areas.OA.Controllers
{
    public class StaffController : BaseController
    {
        private readonly IMappingEngine _mapper;
        private readonly ILog _log4Net;
        public StaffController(IMappingEngine mapper, ILog log4Net)
            : base(log4Net)
        {
            _mapper = mapper;
            _log4Net = log4Net;
        }

        public ActionResult Index()
        {
            return PartialView();
        }

    }
}