using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_OrderForm
    {
        private string id, vendorId, staffId, productId, address, deliveryDate;
        public DTO_OrderForm(string id, string vendorId, string staffId, string productId, string address, string delivery)
        {
            this.id = id;
            this.vendorId = vendorId;
            this.staffId = staffId;
            this.productId = productId;
            this.address = address;
            this.deliveryDate = delivery;
        }

        public string _id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string _vendorId
        {
            get { return this.vendorId; }
            set { this.vendorId = value; }
        }
        public string _staffId
        {
            get { return this.staffId; }
            set { this.staffId = value; }
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

        public string _delivery
        {
            get { return this.deliveryDate; }
            set { this.deliveryDate = value; }
        }
    }
}
