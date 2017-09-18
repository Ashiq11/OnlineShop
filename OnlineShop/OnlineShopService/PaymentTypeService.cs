using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;
using OnlineShopData;

namespace OnlineShopService
{
    class PaymentTypeService : IPaymentTypeService
    {
        private IPaymentTypeDataAccess data;

        public PaymentTypeService(IPaymentTypeDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public PaymentType Get(int id)
        {
            return this.data.Get(id);
        }

        public IEnumerable<PaymentType> GetAll()
        {
            return this.data.GetAll();
        }

        public int Insert(PaymentType paymentType)
        {
            return this.data.Insert(paymentType);
        }

        public int Update(PaymentType paymentType)
        {
            return this.data.Update(paymentType);
        }
    }
}
