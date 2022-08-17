using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CategoryCRUDSample.Models
{
    
    public class CategoryContext : DbContext
    { 
        public DbSet<Category> CategoriesDB { get; set; }
    }
}