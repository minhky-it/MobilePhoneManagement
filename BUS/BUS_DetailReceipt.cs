using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BUS
{
    public class BUS_DetailReceipt
    {
        private DAL_DetailReceipt details;

        public BUS_DetailReceipt()
        {
            details = new DAL_DetailReceipt();
        }
        public DataTable selectQuery()
        {
            return details.selectQuery();
        }
        public DataTable selectQuerybyID(string id)
        {
            return details.selectQuerybyID(id);
        }
        public DataTable topselling()
        {
            return details.topselling();
        }
    }
}
