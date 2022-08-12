using StronglyTypedPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedPartialView.Controllers
{
    public class HomeController : Controller
    {
        List<Product> ProductList = new List<Product>()
        {
            new Product{ProductId=1,ProductName="AC",price=50000,Picture="~/AC.jpg"},
             new Product{ProductId=2,ProductName="TV",price=50000,Picture="~/tv.jpg"},
              new Product{ProductId=3,ProductName="Laptop",price=50000,Picture="~/laptop.jpg"}
        };
      

        // GET: Home
        public ActionResult Index()
        {
            return View(ProductList);
        }
    }
}