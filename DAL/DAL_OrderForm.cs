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

        public DAL_OrderForm(string id, string address, string statusPayment, string status, string delivery)
        {
            orderform = new DTO_OrderForm(id, address, statusPayment, status, delivery);
        }
        public void addQuery()
        {
            string sql = String.Format("INSERT INTO OrderForm VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
            orderform._id, orderform._address, orderform._statusPayment, orderform._status, orderform._delivery);
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM OrderForm";
            return Connection.selectQuery(s);
        }

        //Detail of Order
        public DataTable selectQueryID(string id)
        {
            string s = String.Format("SELECT * FROM DetailOrderForm WHERE orderID = '{0}'", id);
            return Connection.selectQuery(s);
        }
        //All goods out
        public DataTable selectQueryGoodsOut()
        {
            string s = String.Format("SELECT D.* FROM DetailOrderForm D INNER JOIN OrderForm X ON X.orderID = D.orderID WHERE X.status = 'delivered'");
            return Connection.selectQuery(s);
        }
        // select by orderID
        public DataTable selectByOrderID (string orderID)
        {
            string sql = String.Format("SELECT * FROM OrderForm WHERE orderID = '{0}'", orderID);
            return Connection.selectQuery(sql);
        }

    }
}
