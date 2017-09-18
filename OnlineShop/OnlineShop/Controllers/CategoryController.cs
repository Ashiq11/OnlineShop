using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            ICategoryService service = ServiceFactory.GetCategoryService();
            IEnumerable<Category> category = service.GetAll();
            return View(category);
        }

        // GET: Category
        public ActionResult Create()
        {
            return View();
        }
        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ICategoryService service = ServiceFactory.GetCategoryService();
            Category category = new Category();

           try
           {
                category.CategoryName = collection["CategoryName"].ToString();
                service.Insert(category);
                return RedirectToAction("Index", "Category");
            }
            catch
            {
                return View();
            }
                     
        }

        public ActionResult Details(int id)
        {
            ICategoryService service = ServiceFactory.GetCategoryService();
            Category category = service.Get(id);
            return View(category);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            ICategoryService service = ServiceFactory.GetCategoryService();
            Category category = service.Get(id);
            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            ICategoryService service = ServiceFactory.GetCategoryService();
            Category category = service.Get(id);

            try
            {
                // TODO: Add insert logic here
                category.CategoryName = collection["CategoryName"].ToString();

                service.Update(category);

                return RedirectToAction("Index", "Category");
            }
            catch
            {
                return View();
            }
        }
        //GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            ICategoryService service = ServiceFactory.GetCategoryService();
            Category category = service.Get(id);
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            ICategoryService service = ServiceFactory.GetCategoryService();
            
            try
            {
                service.Delete(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index", "Category");
            }
            catch
            {
                return View();
            }
        }
    }
}