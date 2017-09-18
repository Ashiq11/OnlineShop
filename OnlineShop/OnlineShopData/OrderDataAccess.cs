using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;

namespace OnlineShopData
{
    class OrderDataAccess : IOrderDataAccess
    {
        private ProductDBContext context;

        public OrderDataAccess(ProductDBContext context)
        {
            this.context = context;
        }

        public int Delete(int id)
        {
            Order od = this.context.Orders.SingleOrDefault(x => x.OrderID == id);
            this.context.Orders.Remove(od);
            return this.context.SaveChanges();
        }

        public Order Get(int id)
        {
            return this.context.Orders.SingleOrDefault(x => x.OrderID == id);
        }

        public IEnumerable<Order> GetAll()
        {
            return this.context.Orders.ToList();
        }

        public int Insert(Order order)
        {
            this.context.Orders.Add(order);
            return this.context.SaveChanges();

        }

        public int Update(Order order)
        {
            Order od = this.context.Orders.SingleOrDefault(x => x.ID == order.ID);
            od.OrderID = order.OrderID;
            od.ProductID = order.ProductID;
           

            return this.context.SaveChanges();

        }
    }
}
