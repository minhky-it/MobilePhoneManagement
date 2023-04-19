using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        private string id, fullname, email, phone, address, role;

        //Constructor
        public DTO_Staff(string id, string fullname, string email, string phone, string address, string role)
        {
            this.id = id;
            this.fullname = fullname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.role = role;
        }

        //GET/SET
        #region
        public string _id
        {
            get => this.id; set => this.id = value;
        }

        public string _fullname
        {
            get => this.fullname; set => this.fullname = value;
        }
        
        public string _email
        {
            get => this.email; set => this.email = value;
        }
        
        public string _phone
        {
            get => this.phone; set => this.phone = value;
        }

        public string _address
        {
            get => this.address; set => this.address = value;
        }

        public string _role
        {
            get => this.role; set => this.role = value;
        }
        #endregion

        //Tostring
        public override string ToString()
        {
            return base.ToString();
        }
    }
}