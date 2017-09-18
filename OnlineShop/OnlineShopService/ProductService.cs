using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;
using OnlineShopData;

namespace OnlineShopService
{
    class ProductService : IProductService
    {
        private IProductDataAccess data;

        public ProductService(IProductDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Product Get(int id, bool includeCategorys = false)
        {
            return this.data.Get(id, includeCategorys);
        }

        public IEnumerable<Product> GetAll(bool includeCategorys = false)
        {
            return this.data.GetAll(includeCategorys);
        }

        public int Insert(Product product)
        {
            return this.data.Insert(product);
        }

        public int Update(Product product)
        {
            return this.data.Update(product);
        }
    }
}
