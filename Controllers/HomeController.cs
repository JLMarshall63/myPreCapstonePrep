﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreCapstoneMCV5B.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application Description";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page";

            return View();
        }
    }
}