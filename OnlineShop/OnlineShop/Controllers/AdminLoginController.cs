using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class AdminLoginController : Controller
    {
        IAdminService service = ServiceFactory.GetAdminService();
        Admin admin = new Admin();
        // GET: AdminLogin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            int countRow = service.GetAll().Where(email => email.Username == collection["username"].ToString())
                                    .Where(pass => pass.Password == collection["password"].ToString())
                                    .Count();

            if (countRow == 1)
            {
                IEnumerable<Admin> admin = service.GetAll().Where(email => email.Username == collection["username"].ToString())
                                                                    .Where(pass => pass.Password == collection["password"].ToString());
                foreach (var item in admin)
                {
                    Session["AdminLogin"] = item.AdminID;

                }
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public ActionResult Logout()
        {
            if (Session["AdminLogin"] != null)
            {
                Session["AdminLogin"] = null;
            }

            return RedirectToAction("Index", "AdminLogin");

        }

    }
}
