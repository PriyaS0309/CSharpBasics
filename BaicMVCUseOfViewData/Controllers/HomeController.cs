using BaicMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaicMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Current Time"] = DateTime.Now.ToLongTimeString();

            ViewData["MyFirstMVCProject"] = "Hello Employee Details are:";

            Employee emp = new Employee();
            emp.EmpId = 111;
            emp.EmpName = "Priya";
            emp.EmpSalary = 20000;

            ViewData["EmployeesDetail"] = emp;


            string[] MyArray = { "Priya", "Shweta", "Pooja" };
            ViewData["arrayIs"] = MyArray;

            return View();
        }
    
    }
}