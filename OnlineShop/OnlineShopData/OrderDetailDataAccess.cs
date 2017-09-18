using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;

namespace OnlineShopData
{
    class OrderDetailDataAccess : IOrderDetailDataAccess
    {
        private ProductDBContext context;

        public OrderDetailDataAccess(ProductDBContext context)
        {
            this.context = context;
        }

        public int Delete(int id)
        {
            OrderDetail odt = this.context.OrderDetails.SingleOrDefault(x => x.OrderID == id);
            this.context.OrderDetails.Remove(odt);
            return this.context.SaveChanges();
        }

        public OrderDetail Get(int id)
        {
            return this.context.OrderDetails.SingleOrDefault(x => x.OrderID == id);

        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return this.context.OrderDetails.ToList();
        }

        public int Insert(OrderDetail orderDetail)
        {
            this.context.OrderDetails.Add(orderDetail);
            return this.context.SaveChanges();
        }

        public int Update(OrderDetail orderDetail)
        {
            OrderDetail odt = this.context.OrderDetails.SingleOrDefault(x => x.OrderID == orderDetail.OrderID);
            odt.CustomerID = orderDetail.CustomerID;
            odt.Quantity = orderDetail.Quantity;
            odt.TotalAmount = orderDetail.TotalAmount;
            odt.Address = orderDetail.Address;
            odt.OrderDate = orderDetail.OrderDate;
            odt.DeliveryDate = orderDetail.DeliveryDate;

            return this.context.SaveChanges();
        }
    }
}
