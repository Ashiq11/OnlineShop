using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopEntity
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        // [ForeignKey("CategoryId")]
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public double Discount { get; set; }
        public int UnitInStock { get; set; }
        public bool ProductAvailable { get; set; }
        public string Image { get; set; }

        public Category category { get; set; }

        public List<Order> Orders { get; set; }
    }
}
