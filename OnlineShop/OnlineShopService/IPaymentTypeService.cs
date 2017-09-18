using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopService
{
    public interface IPaymentTypeService
    {
        IEnumerable<PaymentType> GetAll();
        PaymentType Get(int id);
        int Insert(PaymentType paymentType);
        int Update(PaymentType paymentType);
        int Delete(int id);
    }
}
