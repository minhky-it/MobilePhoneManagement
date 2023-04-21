using System;
using System.Data;
using DAL;
namespace BUS
{
    public class BUS_OrderForm
    {
        private DAL_OrderForm orderform;

        public BUS_OrderForm(string id, string vendorId, string staffId, string productId, string address, string delivery, int quantity)
        {
            orderform = new DAL_OrderForm(id, vendorId, staffId, productId, address, delivery, quantity);
        }
        public void addQuery()
        {
            orderform.addQuery();
        }
        public DataTable selectQuery()
        {
            return orderform.selectQuery();
        }
    }
}
