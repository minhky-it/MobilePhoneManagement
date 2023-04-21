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
        private string id, staffId, vendorId, productId, address, deliveryTime, payment;
        private DataTable listProduct;
        public PlaceOrders_Object(string id, string staffId, string vendorId, string productId, string add, string time, string payment)
        {
            this.id = id;
            this.staffId = staffId;
            this.vendorId = vendorId;
            this.productId = productId;
            this.address = add;
            this.deliveryTime = time;
            this.payment = payment;
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
        public string _payment
        {
            get { return this.payment; }
            set { this.payment = value; }
        }
        public DataTable _data
        {
            get { return listProduct; }
            set { listProduct = value; }
        }
    }
}
