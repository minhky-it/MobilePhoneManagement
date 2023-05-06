using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BUS
{
    public class BUS_Bill
    {
        private DAL_Bill bill;

        public BUS_Bill()
        {
            bill = new DAL_Bill();
        }
        public DataTable selectQuery()
        {
            return bill.selectQuery();
        }
        public DataTable selectQuerybyID(string ID)
        {
            return bill.selectQuerybyID(ID);
        }
        public DataTable selecMonths()
        {
            return bill.selecMonths();
        }
        public DataTable selectQueryMonthly(string month)
        {
            return bill.selectQueryMonthly(month);
        }
    }
}
