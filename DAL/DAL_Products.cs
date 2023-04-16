using System.Data;
using DTO;

namespace DAL
{
    public class DAL_Products
    {
        private Products products;
        public DAL_Products(string iD, string name, string quantity, string type, string price, string color)
        {
            products = new Products(iD, name, quantity, type, price, color);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Product VALUES ('" + products.ID1 + "','" + products.Name + "'," + products.Quantity + ",'" + products.Type + "'," + products.Price + ",'" + products.Color + "')";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Product";
            return Connection.selectQuery(s);
        }
    }
}
