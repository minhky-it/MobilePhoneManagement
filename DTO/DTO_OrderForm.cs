using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_OrderForm
    {
        private string id, address, statusPayment, status, deliveryDate;
        public DTO_OrderForm(string id, string address, string statusPayment, string status, string delivery)
        {
            this.id = id;
            this.address = address;
            this.statusPayment = statusPayment;
            this.status = status;
            this.deliveryDate = delivery;
        }

        public string _id
        {
            get { return this.id; }
            set { this.id = value; }
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
