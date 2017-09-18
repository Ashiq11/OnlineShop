using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;

namespace OnlineShopData
{
    class PaymentDataAccess : IPaymentDataAccess
    {
        private ProductDBContext context;

        public PaymentDataAccess(ProductDBContext context)
        {
            this.context = context;
        }

        public int Delete(int id)
        {
            Payment pay = this.context.Payments.SingleOrDefault(x => x.PaymentID == id);
            this.context.Payments.Remove(pay);
            return this.context.SaveChanges();

        }

        public Payment Get(int id)
        {
            return this.context.Payments.SingleOrDefault(x => x.PaymentID == id);
        }

        public IEnumerable<Payment> GetAll()
        {
            return this.context.Payments.ToList();
        }

        public int Insert(Payment payment)
        {
            this.context.Payments.Add(payment);
            return this.context.SaveChanges();
        }

        public int Update(Payment payment)
        {
            Payment pay = this.context.Payments.SingleOrDefault(x => x.PaymentID == payment.PaymentID);
            pay.Type = payment.Type;
            pay.CreditAmount = payment.CreditAmount;
            pay.DebitAmount = payment.DebitAmount;
            pay.Balance = payment.Balance;

            return this.context.SaveChanges();
        }
    }
}
