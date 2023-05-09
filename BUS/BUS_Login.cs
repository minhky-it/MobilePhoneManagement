using System.Data;
using DAL;

namespace BUS
{
    public class BUS_Login
    {
        DAL_Login DAL_Login;

        public BUS_Login()
        {
            DAL_Login = new DAL_Login("", "", "", "", "");
        }

        public BUS_Login(string accountID, string status, string username, string password, string role)
        {
            DAL_Login = new DAL_Login(accountID, status, username, password, role);
        }

        public void addQuery()
        {
            DAL_Login.addQuery();
        }

        public DataTable selectQuery()
        {
            return DAL_Login.selectQuery();
        }

        public DataTable selectQueryUserPW(string user, string pass)
        {
            return DAL_Login.selectQueryUserPW(user, pass);
        }

    }
}
