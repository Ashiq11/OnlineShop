using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class CartController : Controller
    {
        private int isExistinId(int id)
        {
            List<Iteam> cart = (List<Iteam>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductID == id)
                {
                    return i;
                }
            }
            return -1;

        }


        public ActionResult Index(int id)
        {
            Session["iteam"] = (int)Session["iteam"] + 1;
            IProductService service = ServiceFactory.GetProductService();
            Product product = service.Get(id);
            if (Session["cart"] == null)
            {
                List<Iteam> cart = new List<Iteam>();
                cart.Add(new Iteam(product, 1));
                //cart.Add();
                Session["cart"] = cart;
            }
            else
            {
                List<Iteam> cart = (List<Iteam>)Session["cart"];
                int index = isExistinId(id);
                if (index == -1)
                {
                    cart.Add(new Iteam(product, 1));
                }
                else
                {
                    cart[index].Quantity++;
                }
                Session["cart"] = cart;
            }

            return View("Cart");
        }

        public ActionResult View()
        {
            return View("Cart");
        }
        public ActionResult Delete(int id)
        {
            int index = isExistinId(id);
            List<Iteam> cart = (List<Iteam>)Session["cart"];

            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");

        }

    }
}
