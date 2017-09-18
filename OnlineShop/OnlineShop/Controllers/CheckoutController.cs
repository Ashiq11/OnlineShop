using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class CheckoutController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            if (Session["CustomerLogin"] != null)
            {
                return View("Checkout");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            if (!string.IsNullOrEmpty(collection["address"].ToString()))
            {
                if (Session["CustomerLogin"] != null)
                {
                    IOrderDetailService service = ServiceFactory.GetOrderDetailService();

                    OrderDetail orderdetail = new OrderDetail();
                    // TODO: Add insert logic here
                    orderdetail.CustomerID = (int)Session["CustomerLogin"];
                    orderdetail.Quantity = (int)Session["iteam"];
                    orderdetail.TotalAmount = (double)Session["tot"];
                    orderdetail.Address = collection["address"].ToString();
                    orderdetail.OrderDate = System.DateTime.Now;
                    orderdetail.DeliveryDate = System.DateTime.Now;

                    service.Insert(orderdetail);
                    int id = orderdetail.OrderID;
                    IOrderService service1 = ServiceFactory.GetOrderService();
                    Order order = new Order();
                    foreach (Iteam im in (List<Iteam>)Session["cart"])
                    {
                        order.OrderID = id;
                        order.ProductID = im.Product.ProductID;
                        service1.Insert(order);
                    }



                    ViewBag.address = collection["address"].ToString();
                    Session["iteam"] = 0;
                    List<Iteam> cart = new List<Iteam>();
                    Session["cart"] = cart;
                    Session["tot"] = 0;
                    return View("CheckoutPayment");

                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }

            else
            {
                ViewBag.message = "You Must Enter The Address Field";
                return View("Checkout");
            }
        }
    }
}