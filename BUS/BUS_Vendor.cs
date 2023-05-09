using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BUS
{
    public class BUS_Vendor
    {
        private DAL_Vendor vendor;
        public BUS_Vendor()
        {
            vendor = new DAL_Vendor();
        }
        public BUS_Vendor(string id, string name, string phone, string email)
        {
            vendor = new DAL_Vendor(id, name, phone, email);
        }

        public DataTable selectQuery()
        {
            return vendor.selectQuery();
        }
    }
}
