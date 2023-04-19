using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class DAL_Vendor
    {
        private DTO_Vendor vendor;
        public DAL_Vendor(string id, string name, string phone, string email)
        {
            vendor = new DTO_Vendor(id, name, phone, email);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Vendor";
            return Connection.selectQuery(s);
        }
    }
}
