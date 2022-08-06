using MVCViewBag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCViewBag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index2()
        {
            ViewBag.Message = "This is View Bag message";

            ViewBag.CurrentTime = DateTime.Now.ToLongTimeString();

            string[] MyFruits = { "Apple", "Orange", "Mango" };
            ViewBag.MyArrayFruits = MyFruits;


            Student st = new Student();
            st.StudentId = 112;
            st.StudentName = "Priya";
            st.StudentAge = 22;

            ViewBag.StudentIno = st;


            TempData["NewMessage"] = "Hello this is TempData Message";

            string[] Myhobbies = { "Watching Movies", "Dancing", "Sports" };
            TempData["Hobbies"] = Myhobbies;

            return View();
        }

        public ActionResult About()
        {
            return View();

        }
    }
}