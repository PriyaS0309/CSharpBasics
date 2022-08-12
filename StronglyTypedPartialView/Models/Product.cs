using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyTypedPartialView.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int price { get; set; }

        public string  Picture { get; set; }
    }
}