using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Controllers
{
    public class Iteam
    {
        private Product product = new Product();

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Iteam()
        {

        }

        public Iteam(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;

        }
    }
}