using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;
using OnlineShopData;

namespace OnlineShopService
{
    class OrderDetailService : IOrderDetailService
    {
        private IOrderDetailDataAccess data;

        public OrderDetailService(IOrderDetailDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public OrderDetail Get(int id)
        {
            return this.data.Get(id);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return this.data.GetAll();
        }

        public int Insert(OrderDetail orderDetail)
        {
            return this.data.Insert(orderDetail);
        }

        public int Update(OrderDetail orderDetail)
        {
            return this.data.Update(orderDetail);
        }
    }
}
