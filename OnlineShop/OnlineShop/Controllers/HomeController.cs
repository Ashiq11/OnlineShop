using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        IProductService service = ServiceFactory.GetProductService();

        public ActionResult Index()
        {
            if (Session["cart"] == null)
            {
                if (Session["cart"] == null)
                {
                    Session["iteam"] = 0;
                    List<Iteam> cart = new List<Iteam>();
                    Session["cart"] = cart;
                    Session["tot"] = 0;
                }
            }

            ViewBag.LatestProducts = service.GetAll();
            return View();
        }
    }
}