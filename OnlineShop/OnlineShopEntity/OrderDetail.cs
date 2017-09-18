using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopEntity
{
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public string Address { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }

        public Customer customer { get; set; }


        public List<Order> orders { get; set; }
    }
}
