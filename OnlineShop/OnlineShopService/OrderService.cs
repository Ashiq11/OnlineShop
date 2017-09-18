using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;
using OnlineShopData;

namespace OnlineShopService
{
    class OrderService : IOrderService
    {
        private IOrderDataAccess data;

        public OrderService(IOrderDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Order Get(int id)
        {
            return this.data.Get(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return this.data.GetAll();
        }

        public int Insert(Order order)
        {
            return this.data.Insert(order);
        }

        public int Update(Order order)
        {
            return this.data.Update(order);
        }
    }
}
