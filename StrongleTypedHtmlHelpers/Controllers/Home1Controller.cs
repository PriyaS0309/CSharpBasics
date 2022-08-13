﻿using StrongleTypedHtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrongleTypedHtmlHelpers.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculation c)
        {
           int num1 = c.num1;
            int num2 = c.num2;
            int result = num1 + num2;

            ViewBag.Result = result;

            return View();
        }
    }
}