using System;
using System.Collections.Generic;
using System.Data.Entity;
using OnlineShopEntity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopData
{
    class ProductDBContext : DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }

    }
}
