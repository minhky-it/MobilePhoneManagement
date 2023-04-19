using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Vendor
    {
        private string id, name, phone, email;

        public DTO_Vendor(string id, string name, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        //GET/SET
        #region
        public string _id
        {
            get => this.id; set => this.id = value;
        }
        public string _name
        {
            get => this.name; set => this.name = value;
        }
        public string _phone
        {
            get => this.phone; set => this.phone = value;
        }
        public string _email
        {
            get => this.email; set => this.email = value;
        }
        #endregion
        //Tostring
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
