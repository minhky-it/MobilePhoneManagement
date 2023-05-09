using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Login
    {
        string accountID;
        string status;
        string username;
        string password;
        string role;

        public DTO_Login(string accountID, string status, string username, string password, string role)
        {
            this.accountID = accountID;
            this.status = status;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string AccountID { get => accountID; set => accountID = value; }
        public string Status { get => status; set => status = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
