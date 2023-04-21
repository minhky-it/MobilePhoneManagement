using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_Staff
    {
        private DAL_Staff staff;
        public BUS_Staff()
        {
            staff = new DAL_Staff();
        }
        public BUS_Staff(string id, string fullname, string email, string phone, string address, string role)
        {
            staff = new DAL_Staff(id, fullname, email, phone, address, role);
        }

        public DataTable selectQuery()
        {
            return staff.selectQuery();
        }

        public DataTable selectQuerybyID(string id)
        {
            return staff.selectQuerybyID(id);
        }
    }
}
