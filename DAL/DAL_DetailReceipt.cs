using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class DAL_DetailReceipt
    {
        private readonly DTO_DetailReceipt details;

        public DAL_DetailReceipt()
        {
            details = new DTO_DetailReceipt();
        }
        public DataTable selectQuery()
        {
            string s = "SELECT * FROM DetailReceipt";
            return Connection.selectQuery(s);
        }
        public DataTable selectQuerybyID(string id)
        {
            string s = String.Format("SELECT * FROM DetailReceipt WHERE billID = '{0}'", id);
            return Connection.selectQuery(s);
        }

        public DataTable topselling()
        {
            string s = "SELECT p.ProductID, p.vendorID, p.name, p.type, p.price, p.color "+
                        "FROM Product p "+
                        "JOIN DetailReceipt d ON p.ProductID = d.productID "+
                        "WHERE d.productID = p.productID "+
                        "GROUP BY p.ProductID, p.vendorID, p.name, p.type, p.price, p.color " +
                        "ORDER BY SUM(d.quantity) DESC";
            return Connection.selectQuery(s);
        }
    }
}
