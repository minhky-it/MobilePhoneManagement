using System.Data;
using DAL;

namespace BUS
{
    public class BUS_Products
    {
        DAL_Products products;

        public BUS_Products(string iD, string name, string quantity, string type, string price, string color)
        {
            products = new DAL_Products(iD, name, quantity, type, price, color);
        }

        public void addQuery()
        {
            products.addQuery();
        }

        public DataTable selectQuery()
        {
            return products.selectQuery();
        }
    }
}
