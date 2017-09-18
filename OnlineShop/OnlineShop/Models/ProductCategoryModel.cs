using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class ProductCategoryModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public double Discount { get; set; }
        public int UnitInStock { get; set; }
        public bool ProductAvailable { get; set; }
        public string Image { get; set; }
    }
}