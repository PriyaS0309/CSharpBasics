using StronglyTypedViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee Id:");
            emp.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            emp.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age:");
            emp.EmployeeAge = int.Parse(Console.ReadLine());
            return View(emp);
        }
    }
}