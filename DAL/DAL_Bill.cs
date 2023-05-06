using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class DAL_Bill
    {
        private DTO_Bill bill;
        public DAL_Bill()
        {
            bill = new DTO_Bill();
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Bill";
            return Connection.selectQuery(s);
        }
        public DataTable selectQuerybyID(string id)
        {
            string s = String.Format("SELECT * FROM Bill WHERE billID = '{0}'", id);
            return Connection.selectQuery(s);
        }
        public DataTable selectQueryMonthly(string month)
        {
            string s = String.Format("SELECT * FROM Bill WHERE MONTH(createDate) = '{0}'", month);
            return Connection.selectQuery(s);
        }

        public DataTable selecMonths()
        {
            string s = "SELECT DISTINCT MONTH(createDate) as month FROM Bill";
            return Connection.selectQuery(s);
        }
    }
}
