using OnlineShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll(bool includeProducts = false);
        Category Get(int id, bool includeProducts = false);
        int Insert(Category category);
        int Update(Category category);
        int Delete(int id);
    }
}
