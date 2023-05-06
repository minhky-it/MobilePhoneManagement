using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebMVC_OrderForm.Models;
using System.Net.Mail;

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
        public ActionResult Details(string cusID, string productID)
        {
            if (cusID == null || productID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CART cART = db.CARTs.Find(new[] {cusID, productID });
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
            ViewBag.productID = new SelectList(db.Products, "ProductID", "ProductID");
            return View();
        }

        // POST: CARTs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,productID,price, quantity")] CART cART)
        {
            if (ModelState.IsValid)
            {
                db.CARTs.Add(cART);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "customerID", "fullname", cART.CustomerID);
            ViewBag.productID = new SelectList(db.Products, "ProductID", "productID", cART.productID);
            return View(cART);
        }

        // GET: CARTs/Edit/5
        public ActionResult Edit(string CustomerID, string productID)
        {
            if (CustomerID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CART cART = db.CARTs.Find(new[] { CustomerID, productID });
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
        public ActionResult Edit([Bind(Include = "CustomerID,productID,quantity")] CART cART)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cART).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "customerID", "fullname", cART.CustomerID);
            ViewBag.productID = new SelectList(db.Products, "ProductID", "ProductID", cART.productID);
            return View(cART);
        }

        // GET: CARTs/Delete/5
        public ActionResult Delete(string CustomerID, string productID)
        {
            if (CustomerID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CART cART = db.CARTs.Find(new[] { CustomerID, productID});
            if (cART == null)
            {
                return HttpNotFound();
            }
            return View(cART);
        }

        // POST: CARTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string CustomerID, string productID)
        {
            CART cART = db.CARTs.Find(new[] { CustomerID, productID });
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
        public ActionResult OrderConfirm()
        {
            var cARTs = db.CARTs.Include(c => c.Customer).Include(c => c.Product);
            return View(cARTs);
        }

        [HttpPost]
        public async Task<ActionResult> MakeOrder(FormCollection form)
        {
            string fullName = form["fullname"];
            string email = form["email"];
            string address = form["address"];
            string phone = form["phone"];
            double total = Convert.ToDouble(form["total"]);
            var cARTs = db.CARTs.Include(c => c.Customer).Include(c => c.Product).ToList();

            
            // Use the value of the full name input field as needed

            // generates a random number between 1000 and 9999
            Random random = new Random();
            DateTime currentDateTime = DateTime.Now;
            Bill bill = new Bill();
            bill.billID = random.Next(1000, 999999).ToString();
            bill.total = total;
            bill.createDate = currentDateTime;
            bill.address = address;
            bill.phone = phone;
            bill.email = email;
            bill.fullname = fullName;
            if (ModelState.IsValid)
            {
                db.Bills.Add(bill);
                await db.SaveChangesAsync();
            }

            foreach (var item in cARTs)
            {
                DetailReceipt detail = new DetailReceipt
                {
                    billID = bill.billID,
                    productID = item.productID,
                    quantity = item.quantity
                };

                db.DetailReceipts.Add(detail);
                await db.SaveChangesAsync();
            }
            db.CARTs.RemoveRange(db.CARTs);
            db.SaveChanges();

            //Prepair email
            string body = $@"<!DOCTYPE html>
            <html>
            <head>
                <title>Order Confirmation</title>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        font-size: 16px;
                        line-height: 1.5;
                        background-color: #f4f4f4;
                    }}
                    .container {{
                        max-width: 600px;
                        margin: 0 auto;
                        padding: 20px;
                        background-color: #fff;
                        border-radius: 10px;
                        box-shadow: 0px 0px 10px rgba(0,0,0,0.2);
                    }}
                    h1 {{
                        font-size: 24px;
                        margin-bottom: 20px;
                        text-align: center;
                    }}
                    table {{
                        width: 100%;
                        border-collapse: collapse;
                        margin-bottom: 20px;
                    }}
                    th, td {{
                        padding: 10px;
                        text-align: left;
                        border-bottom: 1px solid #ddd;
                    }}
                    th {{
                        background-color: #f2f2f2;
                    }}
                    .bold {{
                        font-weight: bold;
                    }}
                    .text-right {{
                        text-align: right;
                    }}
                    .thanks {{
                        font-size: 18px;
                        font-style: italic;
                        margin-top: 20px;
                        text-align: center;
                    }}
                </style>
            </head>
            <body>
                <div class=""container"">
                    <h1>Order Confirmation</h1>
                    <table>
                        <tr>
                            <td class=""bold"">Order ID:</td>
                            <td>{bill.billID}</td>
                        </tr>
                        <tr>
                            <td class=""bold"">Order Date:</td>
                            <td>{bill.createDate}</td>
                        </tr>
                        <tr>
                            <td class=""bold"">Full Name:</td>
                            <td>{bill.fullname}</td>
                        </tr>
                        <tr>
                            <td class=""bold"">Email:</td>
                            <td>{bill.email}</td>
                        </tr>
                        <tr>
                            <td class=""bold"">Phone:</td>
                            <td>{bill.phone}</td>
                        </tr>
                        <tr>
                            <td class=""bold"">Address:</td>
                            <td>{bill.address}</td>
                        </tr>
                        <tr>
                            <td class=""bold"">Total:</td>
                            <td class=""text-right"">{bill.total}</td>
                        </tr>
                    </table>
                    <p class=""thanks"">Thank you for your order!</p>
                </div>
            </body>
            </html>";
            MailMessage message = new MailMessage();
            message.Body = body;
            //Send email
            // Create a new MailMessage object
            message.From = new MailAddress("minhky.book@gmail.com"); // Replace with your own email address
            message.To.Add(new MailAddress(email)); // Replace with the recipient email address
            message.Subject = "ORDER " + bill.billID + " Notification";
            message.IsBodyHtml = true;
            

            // Create a new SmtpClient object and set the Gmail SMTP server details
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = true;
            client.Credentials = new NetworkCredential("kkmobile.test.mvc@gmail.com", "hzkkshmhlrcabykd");
            client.EnableSsl = true;
            // Send the email
            client.Send(message);

            return RedirectToAction("Succeed");
        }

        public ActionResult Succeed()
        {
            return View("Succeed");
        }
    }
}
