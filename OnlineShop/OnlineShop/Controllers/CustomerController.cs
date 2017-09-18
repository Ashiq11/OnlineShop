using OnlineShopEntity;
using OnlineShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            if (Session["adminlogin"] != null)
            {
                ICustomerService service = ServiceFactory.GetCustomerService();
                IEnumerable<Customer> customer = service.GetAll();

                return View(customer);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            Customer customer = service.Get(id);
            //ViewBag.product1 = service.GetAll().Where(a=> a.ProductID==id) ;
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            Customer customer = new Customer();

            try
            {
                // TODO: Add insert logic here

                customer.FirstName = collection["firstname"].ToString();
                customer.LastName = collection["lastname"].ToString();
                customer.Username = collection["username"].ToString();
                customer.Password = collection["password"].ToString();
                customer.Age =Convert.ToInt32(collection["age"]);
                customer.Gender = collection["gender"].ToString();
                customer.Email = collection["email"].ToString();
                customer.Country = collection["country"].ToString();
                customer.City = collection["city"].ToString();
                customer.Address = collection["address"].ToString();
                customer.Phone = collection["phone"].ToString();
                customer.Status = "Active";
                customer.LastLogin = System.DateTime.Now;

                service.Insert(customer);
                return RedirectToAction("Index", "Customer");

                
            }
            catch
            {
                return View();
            }

        }

        // GET: Customer/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Customer/Register
        [HttpPost]
        public ActionResult Register(FormCollection collection)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            Customer customer = new Customer();

            try
            {
                // TODO: Add insert logic here

                customer.FirstName = collection["firstname"].ToString();
                customer.LastName = collection["lastname"].ToString();
                customer.Username = collection["username"].ToString();
                customer.Password = collection["password"].ToString();
                customer.Age = Convert.ToInt32(collection["age"]);
                customer.Gender = collection["gender"].ToString();
                customer.Email = collection["email"].ToString();
                customer.Country = collection["country"].ToString();
                customer.City = collection["city"].ToString();
                customer.Address = collection["address"].ToString();
                customer.Phone = collection["phone"].ToString();
                customer.Status = "Active";
                customer.LastLogin = System.DateTime.Now;

                service.Insert(customer);
                return RedirectToAction("Index", "Login");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            Customer customer= service.Get(id);
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            Customer customer = service.Get(id);

            try
            {
                // TODO: Update logic here

                customer.FirstName = collection["firstname"].ToString();
                customer.LastName = collection["lastname"].ToString();
                customer.Username = collection["username"].ToString();
                customer.Password = collection["password"].ToString();
                customer.Age = Convert.ToInt32(collection["age"]);
                customer.Gender = collection["gender"].ToString();
                customer.Email = collection["email"].ToString();
                customer.Country = collection["country"].ToString();
                customer.City = collection["city"].ToString();
                customer.Address = collection["address"].ToString();
                customer.Phone = collection["phone"].ToString();
                customer.Status = "Active";
                customer.LastLogin = System.DateTime.Now;

                service.Update(customer);
                return RedirectToAction("Index", "Customer");
            }
            catch
            {
                return View();
            }
        }
        // GET: Customer/Edit/5
        public ActionResult Update(int id)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            Customer customer = service.Get(id);
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Update(int id, FormCollection collection)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            Customer customer = service.Get(id);

            try
            {
                // TODO: Update logic here

                customer.FirstName = collection["firstname"].ToString();
                customer.LastName = collection["lastname"].ToString();
                customer.Username = collection["username"].ToString();
                customer.Password = collection["password"].ToString();
                customer.Age = Convert.ToInt32(collection["age"]);
                customer.Gender = collection["gender"].ToString();
                customer.Email = collection["email"].ToString();
                customer.Country = collection["country"].ToString();
                customer.City = collection["city"].ToString();
                customer.Address = collection["address"].ToString();
                customer.Phone = collection["phone"].ToString();
                customer.Status = "Active";
                customer.LastLogin = System.DateTime.Now;

                service.Update(customer);
                return RedirectToAction("Index", "Customer");
            }
            catch
            {
                return View();
            }
        }


        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            Customer customer = service.Get(id);
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            ICustomerService service = ServiceFactory.GetCustomerService();
            try
            {
                // TODO: Add delete logic here

                service.Delete(id);

                return RedirectToAction("Index","Customer");
            }
            catch
            {
                return View();
            }
        }
    }
}
