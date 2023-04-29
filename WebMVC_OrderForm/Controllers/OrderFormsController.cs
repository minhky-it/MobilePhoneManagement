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
    public class OrderFormsController : Controller
    {
        private MOBILEMANAGEMENT db = new MOBILEMANAGEMENT();

        // GET: OrderForms
        public ActionResult Index()
        {
            return View(db.OrderForms.ToList());
        }

        // GET: OrderForms/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderForm orderForm = db.OrderForms.Find(id);
            if (orderForm == null)
            {
                return HttpNotFound();
            }
            return View(orderForm);
        }

        // GET: OrderForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "orderID,addrress,statusPayment,status,deliveryDate")] OrderForm orderForm)
        {
            if (ModelState.IsValid)
            {
                db.OrderForms.Add(orderForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderForm);
        }

        // GET: OrderForms/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderForm orderForm = db.OrderForms.Find(id);
            if (orderForm == null)
            {
                return HttpNotFound();
            }
            return View(orderForm);
        }

        // POST: OrderForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "orderID,addrress,statusPayment,status,deliveryDate")] OrderForm orderForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderForm);
        }

        // GET: OrderForms/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderForm orderForm = db.OrderForms.Find(id);
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
            OrderForm orderForm = db.OrderForms.Find(id);
            db.OrderForms.Remove(orderForm);
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
