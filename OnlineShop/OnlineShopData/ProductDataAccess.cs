using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopEntity;

namespace OnlineShopData
{
    class ProductDataAccess : IProductDataAccess
    {
        private ProductDBContext context;

        public ProductDataAccess(ProductDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetAll(bool includeCategorys = false)
        {
            if (includeCategorys)
            {
                return this.context.Products.Include("Categorys").ToList();
            }
            else
            {
                return this.context.Products.ToList();
            }
        }
        public Product Get(int id, bool includeCategorys = false)
        {
            if (includeCategorys)
            {
                return this.context.Products.Include("Categorys").SingleOrDefault(x => x.ProductID == id);
            }
            else
            {
                return this.context.Products.SingleOrDefault(x => x.ProductID == id);
            }
        }

        public int Insert(Product product)
        {
            this.context.Products.Add(product);
            return this.context.SaveChanges();
        }

        public int Update(Product product)
        {
            Product pro = this.context.Products.SingleOrDefault(x => x.ProductID == product.ProductID);
            pro.ProductName = product.ProductName;
            pro.CategoryID = product.CategoryID;
            pro.UnitPrice = product.UnitPrice;
            pro.Description = product.Description;
            pro.Size = product.Size;
            pro.Discount = product.Discount;
            pro.UnitInStock = product.UnitInStock;
            pro.ProductAvailable = product.ProductAvailable;
            pro.Image = product.Image;

            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Product pro = this.context.Products.SingleOrDefault(x => x.ProductID == id);
            this.context.Products.Remove(pro);

            return this.context.SaveChanges();
        }

    }
}
