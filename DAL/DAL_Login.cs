using System.Data;
using DTO;
namespace DAL
{
    public class DAL_Login
    {
        private DTO_Login DTO_Login;

        public DAL_Login(string accountID, string status, string username, string password, string role)
        {
            DTO_Login = new DTO_Login(accountID, status, username, password, role);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Account VALUES ('"+ DTO_Login.AccountID +"', '" + DTO_Login.Status + "', '" + DTO_Login.Username + "', '"+ DTO_Login.Password +"', '" + DTO_Login.Role +"')";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Account";
            return Connection.selectQuery(s);
        }

        public DataTable selectQueryUserPW(string user, string pass)
        {
            string s = string.Format("SELECT * FROM Account WHERE username = '{0}' AND password = '{1}'", user, pass);
            return Connection.selectQuery(s);
        }
    }
}
