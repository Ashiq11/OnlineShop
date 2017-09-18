using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopService
{
    public interface IOrderDetailService
    {
        IEnumerable<OrderDetail> GetAll();
        OrderDetail Get(int id);
        int Insert(OrderDetail orderDetail);
        int Update(OrderDetail orderDetail);
        int Delete(int id);
    }
}
