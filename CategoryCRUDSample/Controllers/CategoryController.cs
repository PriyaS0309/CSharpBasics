using CategoryCRUDSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CategoryCRUDSample.Controllers
{
    
    public class CategoryController : Controller
    {
        CategoryContext db = new CategoryContext();

        public EntityState StateEntity { get; private set; }

        // GET: Category
        public ActionResult Index()
        {
            var data = db.CategoriesDB.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category c)
        {
            db.CategoriesDB.Add(c);
            int a=db.SaveChanges();
            if (a>0)
            {
                ViewBag.Message = "Data Insereted Successfully!!";

            }
            else
            {
                ViewBag.Message = "Data not Insereted !!";
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = db.CategoriesDB.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Category c)
        {
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
            return View();
        }

        public ActionResult Delete(int id)
        {
            var d_data = db.CategoriesDB.Where(model => model.ID == id).FirstOrDefault();

            return View(d_data);
        }

        [HttpPost]

        public ActionResult Delete(Category c)
        {
            db.Entry(c).State = EntityState.Deleted;
            db.SaveChanges();

            return View();
        }

    }
}