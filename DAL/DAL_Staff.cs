﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Staff
    {
        private DTO_Staff staff;
        public DAL_Staff()
        {
            staff = new DTO_Staff();
        }
        public DAL_Staff(string id, string fullname, string email, string phone, string address, string role)
        {
            staff = new DTO_Staff(id, fullname, email, phone, address, role);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Staff";
            return Connection.selectQuery(s);
        }
        public DataTable selectQuerybyID(string id)
        {
            string s = String.Format("SELECT * FROM Staff WHERE staffID = '{0}'", id);
            return Connection.selectQuery(s);
        }
    }
}
