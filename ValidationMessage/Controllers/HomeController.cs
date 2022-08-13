using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ValidationMessage.Controllers
{
    
    public class HomeController : Controller
    {
        string EmailPattern = @"^ ( [\w\.\-]+)@ ( [\w\-]+) ( (\. (\w) {2,3})+)$";
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]                                                           //when submit button hits it sends request to the controller and httppost is called
        public ActionResult Index(string name,string email,string age)           
        {
            if(name.Equals("")==true)                                            //checking the condition
            {
                ModelState.AddModelError("name","Name is required");
                //ViewData["nameError"] = "*";
            }
            if (email.Equals("") == true)
            {
                ModelState.AddModelError("email","Email is required");
               // ViewData["emailError"] = "*";

            }
            else
            {
                if(Regex.IsMatch(email,EmailPattern)==false)
                {
                    ModelState.AddModelError("email","Email Id is Invalid");
                }
            }
            if (age.Equals("") == true)
            {
                ModelState.AddModelError("age","Age is required");
                //ViewData["ageError"] = "*";

            }
            if (ModelState.IsValid==true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data has been submitted !!!')</script>";               //display message box
                ModelState.Clear();            //clear the fields
            }
            return View();
        }
    }
}