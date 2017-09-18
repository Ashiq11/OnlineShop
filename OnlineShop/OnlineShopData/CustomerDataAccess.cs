using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;

namespace OnlineShopData
{
    class CustomerDataAccess : ICustomerDataAccess
    {
        private ProductDBContext context;

        public CustomerDataAccess(ProductDBContext context)
        {
            this.context = context;
        }

        public int Delete(int id)
        {
            Customer cu = this.context.Customers.SingleOrDefault(x => x.CustomerID == id);
            this.context.Customers.Remove(cu);
            return this.context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return this.context.Customers.SingleOrDefault(x => x.CustomerID == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return this.context.Customers.ToList();
        }

        public int Insert(Customer customer)
        {
            this.context.Customers.Add(customer);
            return this.context.SaveChanges();
        }

        public int Update(Customer customer)
        {
            Customer cu = this.context.Customers.SingleOrDefault(x => x.CustomerID == customer.CustomerID);
            cu.Password = customer.Password;
            return this.context.SaveChanges();
        }

        public bool ValidateCredentials(Customer customer)
        {
            Customer cu = this.context.Customers.SingleOrDefault(x => x.Username == customer.Username && x.Password == customer.Password);
            if (cu == null)
            {
                return false;
            }
            else
            {
                customer.CustomerID = cu.CustomerID;
                return true;
            }
        }
    }
}
