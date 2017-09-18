using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopService
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll(bool includeCategorys = false);
        Product Get(int id, bool includeCategorys = false);
        int Insert(Product product);
        int Update(Product product);
        int Delete(int id);
    }
}
