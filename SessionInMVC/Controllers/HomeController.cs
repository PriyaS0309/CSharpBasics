using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomePage
        public ActionResult Index()
        {
            ViewData["Var1"] = "This is ViewData result";
            ViewBag.Var2 = "This is ViewBag result";
            TempData["Var3"] = "This is TempData Result";
            Session["Var4"] = "This is a new Session";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}