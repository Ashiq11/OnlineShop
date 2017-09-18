using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopData
{
    public interface IPaymentDataAccess
    {
        IEnumerable<Payment> GetAll();
        Payment Get(int id);
        int Insert(Payment payment);
        int Update(Payment payment);
        int Delete(int id);
    }
}
