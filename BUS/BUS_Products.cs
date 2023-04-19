using System.Data;
using DAL;

namespace BUS
{
    public class BUS_Products
    {
        DAL_Products products;

        public BUS_Products(string iD, string vendorId, string name, string quantity, string type, string price, string color)
        {
            products = new DAL_Products(iD, vendorId,  name, quantity, type, price, color);
        }

        public void addQuery()
        {
            products.addQuery();
        }

        public DataTable selectQuery()
        {
            return products.selectQuery();
        }

        //Select by vendorID
        public DataTable selectVendorId(string id)
        {
            return products.selectVendorId(id);
        }
    }
}
