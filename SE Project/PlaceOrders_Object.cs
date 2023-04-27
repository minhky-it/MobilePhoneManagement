using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SE_Project
{
    public class PlaceOrders_Object
    {
        // new table
        private string statusPayment, status;

        // old table
        private string id, staffId, vendorId, productId, address, deliveryTime, payment;
        private int quantity;
        private DataTable listProduct;

        public PlaceOrders_Object(){ }

        // Order form
        public PlaceOrders_Object(string id, string address, string statusPayment, string status, string deliver)
        {
            this.id = id;
            this.address = address;
            this.statusPayment = statusPayment;
            this.status = status;
            this.deliveryTime = deliver;
        }

        // Detail Order Form
        public PlaceOrders_Object(string id, string vendorId, string staffId, string productId, int quantity)
        {
            this.id = id;
            this.vendorId = vendorId;
            this.staffId = staffId;
            this.productId = productId;
            this.quantity = quantity;
        }

        public string _id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string _staffId
        {
            get { return this.staffId; }
            set { this.staffId = value; }
        }
        public string _vendorId
        {
            get { return this.vendorId; }
            set { this.vendorId = value; }
        }
        public string _productId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }
        public string _address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string _deliverytime
        {
            get { return this.deliveryTime; }
            set { this.deliveryTime = value; }
        }
       
        public DataTable _data
        {
            get { return listProduct; }
            set { listProduct = value; }
        }
        public int _quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        // new table
        public string _statusPayment
        {
            get { return this.statusPayment; }
            set { this.statusPayment = value; }
        }

        public string _status
        {
            get { return this.status; }
            set { this.status = value; }
        }
    }
}
