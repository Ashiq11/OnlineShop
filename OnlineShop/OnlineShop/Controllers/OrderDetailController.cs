using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class OrderDetailController : Controller
    {
        // GET: OrderDetail
        public ActionResult Index()
        {
            if (Session["adminlogin"] != null)
            {
                IOrderDetailService service = ServiceFactory.GetOrderDetailService();

                IEnumerable<OrderDetail> orderdetail = service.GetAll();
                return View(orderdetail);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
        }

        public ActionResult Delete(int id)
        {
            if (Session["adminlogin"] != null)
            {
                IOrderDetailService service = ServiceFactory.GetOrderDetailService();
                OrderDetail orderdetail = service.Get(id);
                return View(orderdetail);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            IOrderDetailService service = ServiceFactory.GetOrderDetailService();
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

        // GET: Product/Detail/5
        public ActionResult Detail(int id)
        {
            IOrderDetailService service = ServiceFactory.GetOrderDetailService();
            OrderDetail orderdetail = service.Get(id);
            //ViewBag.product1 = service.GetAll().Where(a=> a.ProductID==id) ;
            return View(orderdetail);
        }

    }
}