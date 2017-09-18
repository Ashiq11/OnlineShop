using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;

namespace OnlineShopData
{
    class PaymentTypeDataAccess : IPaymentTypeDataAccess
    {
        private ProductDBContext context;

        public PaymentTypeDataAccess(ProductDBContext context)
        {
            this.context = context;
        }

        public int Delete(int id)
        {
            PaymentType pt = this.context.PaymentTypes.SingleOrDefault(x => x.PaymentTypeID == id);
            this.context.PaymentTypes.Remove(pt);
            return this.context.SaveChanges();
        }

        public PaymentType Get(int id)
        {
            return this.context.PaymentTypes.SingleOrDefault(x => x.PaymentTypeID == id);
        }

        public IEnumerable<PaymentType> GetAll()
        {
            return this.context.PaymentTypes.ToList();
        }

        public int Insert(PaymentType paymentType)
        {
            this.context.PaymentTypes.Add(paymentType);
            return this.context.SaveChanges();
        }

        public int Update(PaymentType paymentType)
        {
            PaymentType pt = this.context.PaymentTypes.SingleOrDefault(x => x.PaymentTypeID == paymentType.PaymentTypeID);
            pt.TypeName = paymentType.TypeName;
            return this.context.SaveChanges();
        }
    }
}
