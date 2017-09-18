using Newtonsoft.Json.Linq;
using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class LoginController : Controller
    {
        ICustomerService service = ServiceFactory.GetCustomerService();
        Customer customer = new Customer();


        // GET:  
        public ActionResult Index()
        {

            return View();
        }
        // POST: Login
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            int countRow = service.GetAll().Where(email => email.Username == collection["username"].ToString())
                .Where(pass => pass.Password == collection["password"].ToString()).Count();

            if(countRow==1)
            {
                IEnumerable<Customer> customer = service.GetAll().Where(email => email.Username == collection["username"].ToString())
                    .Where(pass => pass.Password == collection["password"].ToString());

                foreach(var item in customer)
                {
                    Session["CustomerLogin"] = item.CustomerID;
                }
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }

        }

       // GET: Logout
        [HttpGet]
        public ActionResult Logout()
        {
            if (Session["CustomerLogin"] != null)
            {
                Session["CustomerLogin"] = null;
            }

            return RedirectToAction("Index", "Login");

        }

    }
}