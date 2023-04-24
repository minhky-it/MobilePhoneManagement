using System.Data;
using DAL;

namespace BUS
{
    public class BUS_Products
    {
        DAL_Products products;
        public BUS_Products() {
            products = new DAL_Products("", "", "", "", "", "", "");
        }
        public BUS_Products(string iD, string vendorID, string name, string quantity, string type, string price, string color)
        {
            products = new DAL_Products(iD, vendorID, name, quantity, type, price, color);
        }

        public void addQuery()
        {
            products.addQuery();
        }

        public DataTable selectQuery()
        {
            return products.selectQuery();
        }

        // Select by vendorID
        public DataTable selectVendorId(string id)
        {
            return products.selectVendorId(id);
        }

        // Select by orderID
        public DataTable selectOrderId(string id)
        {
            return products.selectOrderId(id);
        }
    }
}
