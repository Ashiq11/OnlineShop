using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;
using OnlineShopData;

namespace OnlineShopService
{
    class CustomerService : ICustomerService
    {
        private ICustomerDataAccess data;

        public CustomerService(ICustomerDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Customer Get(int id)
        {
            return this.data.Get(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return this.data.GetAll();
        }

        public int Insert(Customer customer)
        {
            return this.data.Insert(customer);
        }

        public int Update(Customer customer)
        {
            return this.data.Update(customer);
        }

        public bool ValidateCredentials(Customer customer)
        {
            return this.data.ValidateCredentials(customer);
        }
    }
}
