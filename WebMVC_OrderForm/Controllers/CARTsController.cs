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
    public class CARTsController : Controller
    {
        private MOBILEMANAGEMENT db = new MOBILEMANAGEMENT();

        // GET: CARTs
        public ActionResult Index()
        {
            var cARTs = db.CARTs.Include(c => c.Customer).Include(c => c.Product);
            return View(cARTs.ToList());
        }

        // GET: CARTs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CART cART = db.CARTs.Find(id);
            if (cART == null)
            {
                return HttpNotFound();
            }
            return View(cART);
        }

        // GET: CARTs/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "customerID", "fullname");
            ViewBag.productID = new SelectList(db.Products, "ProductID", "vendorID");
            return View();
        }

        // POST: CARTs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,productID,Total")] CART cART)
        {
            if (ModelState.IsValid)
            {
                db.CARTs.Add(cART);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "customerID", "fullname", cART.CustomerID);
            ViewBag.productID = new SelectList(db.Products, "ProductID", "vendorID", cART.productID);
            return View(cART);
        }

        // GET: CARTs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CART cART = db.CARTs.Find(id);
            if (cART == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "customerID", "fullname", cART.CustomerID);
            ViewBag.productID = new SelectList(db.Products, "ProductID", "vendorID", cART.productID);
            return View(cART);
        }

        // POST: CARTs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,productID,Total")] CART cART)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cART).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "customerID", "fullname", cART.CustomerID);
            ViewBag.productID = new SelectList(db.Products, "ProductID", "vendorID", cART.productID);
            return View(cART);
        }

        // GET: CARTs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CART cART = db.CARTs.Find(id);
            if (cART == null)
            {
                return HttpNotFound();
            }
            return View(cART);
        }

        // POST: CARTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CART cART = db.CARTs.Find(id);
            db.CARTs.Remove(cART);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
