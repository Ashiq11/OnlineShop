using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;

namespace OnlineShopData
{
    class CategoryDataAccess : ICategoryDataAccess
    {
        private ProductDBContext context;

        public CategoryDataAccess(ProductDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetAll(bool includeProducts = false)
        {
            if (includeProducts)
            {
                return this.context.Categorys.Include("Products").ToList();
            }
            else
            {
                return this.context.Categorys.ToList();
            }
        }
        public Category Get(int id, bool includeProducts = false)
        {
            if (includeProducts)
            {
                return this.context.Categorys.Include("Products").SingleOrDefault(x => x.CategoryID == id);
            }
            else
            {
                return this.context.Categorys.SingleOrDefault(x => x.CategoryID == id);
            }

        }

        public int Insert(Category category)
        {
            this.context.Categorys.Add(category);
            return this.context.SaveChanges();

        }

        public int Update(Category category)
        {
            Category cat = this.context.Categorys.SingleOrDefault(x => x.CategoryID == category.CategoryID);
            cat.CategoryName = category.CategoryName;
            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Category cat = this.context.Categorys.SingleOrDefault(x => x.CategoryID == id);
            this.context.Categorys.Remove(cat);

            return this.context.SaveChanges();
        }

    }
}
