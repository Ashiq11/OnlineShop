using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopService
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAll();
        Order Get(int id);
        int Insert(Order order);
        int Update(Order order);
        int Delete(int id);
    }
}
