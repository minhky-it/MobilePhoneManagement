using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMobilePhoneCustomer.Models;

namespace WebMobilePhoneCustomer.Controllers
{
    public class OrderFormsController : Controller
    {
        private MOBILEMANAGEMENTEntities db = new MOBILEMANAGEMENTEntities();

        // GET: OrderForms
        public ActionResult Index()
        {
            var orderForm = db.OrderForm.Include(o => o.Product).Include(o => o.Vendor).Include(o => o.Staff);
            return View(orderForm.ToList());
        }

        // GET: OrderForms/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderForm orderForm = db.OrderForm.Find(id);
            if (orderForm == null)
            {
                return HttpNotFound();
            }
            return View(orderForm);
        }

        // GET: OrderForms/Create
        public ActionResult Create()
        {
            ViewBag.productID = new SelectList(db.Product, "ProductID", "vendorID");
            ViewBag.vendorID = new SelectList(db.Vendor, "vendorID", "vendorName");
            ViewBag.staffID = new SelectList(db.Staff, "staffID", "fullname");
            return View();
        }

        // POST: OrderForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "orderID,vendorID,staffID,productID,address,deliveryDate,quantity")] OrderForm orderForm)
        {
            if (ModelState.IsValid)
            {
                db.OrderForm.Add(orderForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.productID = new SelectList(db.Product, "ProductID", "vendorID", orderForm.productID);
            ViewBag.vendorID = new SelectList(db.Vendor, "vendorID", "vendorName", orderForm.vendorID);
            ViewBag.staffID = new SelectList(db.Staff, "staffID", "fullname", orderForm.staffID);
            return View(orderForm);
        }

        // GET: OrderForms/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderForm orderForm = db.OrderForm.Find(id);
            if (orderForm == null)
            {
                return HttpNotFound();
            }
            ViewBag.productID = new SelectList(db.Product, "ProductID", "vendorID", orderForm.productID);
            ViewBag.vendorID = new SelectList(db.Vendor, "vendorID", "vendorName", orderForm.vendorID);
            ViewBag.staffID = new SelectList(db.Staff, "staffID", "fullname", orderForm.staffID);
            return View(orderForm);
        }

        // POST: OrderForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "orderID,vendorID,staffID,productID,address,deliveryDate,quantity")] OrderForm orderForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.productID = new SelectList(db.Product, "ProductID", "vendorID", orderForm.productID);
            ViewBag.vendorID = new SelectList(db.Vendor, "vendorID", "vendorName", orderForm.vendorID);
            ViewBag.staffID = new SelectList(db.Staff, "staffID", "fullname", orderForm.staffID);
            return View(orderForm);
        }

        // GET: OrderForms/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderForm orderForm = db.OrderForm.Find(id);
            if (orderForm == null)
            {
                return HttpNotFound();
            }
            return View(orderForm);
        }

        // POST: OrderForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            OrderForm orderForm = db.OrderForm.Find(id);
            db.OrderForm.Remove(orderForm);
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
