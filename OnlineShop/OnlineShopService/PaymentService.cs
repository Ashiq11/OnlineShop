using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;
using OnlineShopData;

namespace OnlineShopService
{
    class PaymentService : IPaymentService
    {
        private IPaymentDataAccess data;

        public PaymentService(IPaymentDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Payment Get(int id)
        {
            return this.data.Get(id);
        }

        public IEnumerable<Payment> GetAll()
        {
            return this.data.GetAll();
        }

        public int Insert(Payment payment)
        {
            return this.data.Insert(payment);
        }

        public int Update(Payment payment)
        {
            return this.data.Update(payment);
        }
    }
}
