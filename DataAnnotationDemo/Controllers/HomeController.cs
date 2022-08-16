using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotationDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.Employee e)
        {
            if(ModelState.IsValid==true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data Submitted Successfully')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}