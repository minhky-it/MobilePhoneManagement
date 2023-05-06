using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class DTO_Bill
    {
        public string BillID { get; set; }
        public int Total { get; set; }
        public string CreateDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }

        public DTO_Bill()
        {
            // Set default values for properties
            BillID = string.Empty;
            Total = 0;
            CreateDate = string.Empty;
            Address = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            FullName = string.Empty;
        }

        public DTO_Bill(string billID, int total, string createDate, string address, string email, string phone, string fullName)
        {
            BillID = billID;
            Total = total;
            CreateDate = createDate;
            Address = address;
            Email = email;
            Phone = phone;
            FullName = fullName;
        }
    }

}
