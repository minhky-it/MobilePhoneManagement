using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class DAL_OrderForm
    {
        private DTO_OrderForm orderform;

        public DAL_OrderForm(string id, string vendorId, string staffId, string productId, string address, string delivery)
        {
            orderform = new DTO_OrderForm(id, vendorId, staffId, productId, address, delivery);
        }
        public void addQuery()
        {
            string sql = String.Format("INSERT INTO OrderForm VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
            orderform._id, orderform._vendorId, orderform._staffId, orderform._productId, orderform._address, orderform._delivery
            );
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Product";
            return Connection.selectQuery(s);
        }
    }
}
