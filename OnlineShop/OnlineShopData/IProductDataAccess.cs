using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopData
{
    public interface IProductDataAccess
    {
        IEnumerable<Product> GetAll(bool includeCategorys = false);
        Product Get(int id, bool includeCategorys = false);
        //IEnumerable<Product> GetAll();
        //Product Get(int id);
        int Insert(Product product);
        int Update(Product product);
        int Delete(int id);
    }
}
