using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;
using OnlineShopData;

namespace OnlineShopService
{
    class CategoryService : ICategoryService
    {
        private ICategoryDataAccess data;

        public CategoryService(ICategoryDataAccess data)
        {
            this.data = data;
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Category Get(int id, bool includeProducts = false)
        {
            return this.data.Get(id, includeProducts);
        }

        public IEnumerable<Category> GetAll(bool includeProducts = false)
        {
            return this.data.GetAll(includeProducts);
        }

        public int Insert(Category category)
        {
            return this.data.Insert(category); ;
        }

        public int Update(Category category)
        {
            return this.data.Update(category);
        }
    }
}
