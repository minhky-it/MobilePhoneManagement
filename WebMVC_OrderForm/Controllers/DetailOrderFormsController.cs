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
    public class DetailOrderFormsController : Controller
    {
        private MOBILEMANAGEMENT db = new MOBILEMANAGEMENT();

        // GET: DetailOrderForms
        public ActionResult Index(string orderID)
        {
            var detailOrderForms = db.DetailOrderForms.Include(d => d.Product).Include(d => d.Staff).Include(d => d.Vendor).Where(d => d.orderID == orderID);
            if (detailOrderForms == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (detailOrderForms == null)
            {
                return HttpNotFound();
            }
            return View(detailOrderForms.ToList());
        }

        // GET: DetailOrderForms/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailOrderForm detailOrderForm = db.DetailOrderForms.Find(id);
            if (detailOrderForm == null)
            {
                return HttpNotFound();
            }
            return View(detailOrderForm);
        }

        // GET: DetailOrderForms/Create
        public ActionResult Create(string orderID)
        {
            ViewBag.orderID = orderID;
            ViewBag.productID = new SelectList(db.Products, "ProductID", "vendorID");
            ViewBag.Staff = new SelectList(db.Staffs, "staffID", "fullname");
            ViewBag.Vendor = new SelectList(db.Vendors, "vendorID", "vendorID");
            return View();
        }

        // POST: DetailOrderForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "orderID,vendorID,staffID,productID,quantity")] DetailOrderForm detailOrderForm)
        {
            if (ModelState.IsValid)
            {
                db.DetailOrderForms.Add(detailOrderForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.productID = new SelectList(db.Products, "ProductID", "vendorID", detailOrderForm.productID);
            ViewBag.staffID = new SelectList(db.Staffs, "staffID", "fullname", detailOrderForm.staffID);
            ViewBag.vendorID = new SelectList(db.Vendors, "vendorID", "vendorID", detailOrderForm.vendorID);
            return View(detailOrderForm);
        }

        // GET: DetailOrderForms/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailOrderForm detailOrderForm = db.DetailOrderForms.Find(id);
            if (detailOrderForm == null)
            {
                return HttpNotFound();
            }
            ViewBag.productID = new SelectList(db.Products, "ProductID", "vendorID", detailOrderForm.productID);
            ViewBag.staffID = new SelectList(db.Staffs, "staffID", "fullname", detailOrderForm.staffID);
            ViewBag.vendorID = new SelectList(db.Vendors, "vendorID", "vendorName", detailOrderForm.vendorID);
            return View(detailOrderForm);
        }

        // POST: DetailOrderForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "orderID,vendorID,staffID,productID,quantity")] DetailOrderForm detailOrderForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detailOrderForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.productID = new SelectList(db.Products, "ProductID", "vendorID", detailOrderForm.productID);
            ViewBag.staffID = new SelectList(db.Staffs, "staffID", "fullname", detailOrderForm.staffID);
            ViewBag.vendorID = new SelectList(db.Vendors, "vendorID", "vendorName", detailOrderForm.vendorID);
            return View(detailOrderForm);
        }

        // GET: DetailOrderForms/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailOrderForm detailOrderForm = db.DetailOrderForms.Find(id);
            if (detailOrderForm == null)
            {
                return HttpNotFound();
            }
            return View(detailOrderForm);
        }

        // POST: DetailOrderForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DetailOrderForm detailOrderForm = db.DetailOrderForms.Find(id);
            db.DetailOrderForms.Remove(detailOrderForm);
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
