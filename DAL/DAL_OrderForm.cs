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

    }
}
