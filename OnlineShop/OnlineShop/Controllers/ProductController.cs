using OnlineShop.Models;
using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        IProductService service = ServiceFactory.GetProductService();
        // GET: Product
        public ActionResult Index()
        {
            IProductService service = ServiceFactory.GetProductService();
           IEnumerable<Product> product = service.GetAll();
            return View(product);
        }
       // GET: Product/CategoryList/5
        public ActionResult ProductList()
        {  
            IEnumerable<Product> productlist = service.GetAll(true); // true = including category

            List<ProductCategoryModel> viewProductList = new List<ProductCategoryModel>(); // ProductCategoryModel is a view only model

            foreach (Product p in productlist)
            {
                ProductCategoryModel product = new ProductCategoryModel()
                {
                    ProductID =p.ProductID,
                    ProductName =p.ProductName,
                    CategoryName=p.category.CategoryName,
                    UnitPrice=p.UnitPrice,
                    Description=p.Description,
                    Size=p.Size,
                    Discount=p.Discount,
                    UnitInStock=p.UnitInStock,
                    ProductAvailable=p.ProductAvailable,
                    Image=p.Image
                };

                viewProductList.Add(product);
            }

            return View(viewProductList);
    }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            IProductService service = ServiceFactory.GetProductService();
            Product product = service.Get(id);
            //ViewBag.product1 = service.GetAll().Where(a=> a.ProductID==id) ;
            return View(product);
        }
        // GET: Product/Details/5
        public ActionResult MobileDetails(int id)
        {
            if (Session["adminlogin"] != null)
            {
                IProductService service = ServiceFactory.GetProductService();
                Product product = service.Get(id);
                //ViewBag.product1 = service.GetAll().Where(a=> a.ProductID==id) ;
                ViewBag.Mobile = service.GetAll();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");

            }
        }
        // GET: Product/Detail/5
        public ActionResult Detail(int id)
        {
            if (Session["adminlogin"] != null)
            {

                IProductService service = ServiceFactory.GetProductService();
                Product product = service.Get(id);
                //ViewBag.product1 = service.GetAll().Where(a=> a.ProductID==id) ;
                return View(product);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");

            }
        }

        // GET: Product/Create
        public ActionResult AddProduct()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult AddProduct(FormCollection collection)
        {
            IProductService service = ServiceFactory.GetProductService();

            Product product = new Product();

            try
            {
                // TODO: Add insert logic here
                product.ProductName = collection["name"].ToString();
                product.CategoryID = Convert.ToInt32( collection["categoryId"]);
                product.UnitPrice = Convert.ToDouble( collection["unitPrice"]);
                product.Description = collection["description"].ToString();
                product.Size = collection["size"].ToString();
                product.Discount = Convert.ToDouble(collection["discount"]);
                product.UnitInStock =Convert.ToInt32( collection["stock"]);
                product.ProductAvailable = true;
                product.Image = collection["Image"].ToString();

                service.Insert(product);

                return RedirectToAction("Index", "Product");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            IProductService service = ServiceFactory.GetProductService();
            Product product = service.Get(id);
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            IProductService service = ServiceFactory.GetProductService();

            Product product = service.Get(id);

            try
            {
                // TODO: Add insert logic here
                product.ProductName = collection["name"].ToString();
                product.CategoryID = Convert.ToInt32(collection["categoryId"]);
                product.UnitPrice = Convert.ToDouble(collection["unitPrice"]);
                product.Description = collection["description"].ToString();
                product.Size = collection["size"].ToString();
                product.Discount = Convert.ToDouble(collection["discount"]);
                product.UnitInStock = Convert.ToInt32(collection["stock"]);
                product.ProductAvailable = true;
                product.Image = collection["Image"].ToString();

                service.Update(product);

                return RedirectToAction("Index", "Product");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            IProductService service = ServiceFactory.GetProductService();
            Product product = service.Get(id);
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            IProductService service = ServiceFactory.GetProductService();
            //Product product = service.Get(id);
            try
            {
                service.Delete(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
