using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMVC_OrderForm.Models;
namespace WebMVC_OrderForm.Controllers
{
    public class HomeController : Controller
    {
        private MOBILEMANAGEMENT db = new MOBILEMANAGEMENT();
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Vendor);
            return View(products.ToList());
        }
        public ActionResult Add(string id)
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "customerID", "fullname");
            ViewBag.productID = new SelectList(db.Products, "ProductID", "ProductID");
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}