using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DetailReceipt
    {
        public string BillID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }

        public DTO_DetailReceipt(string billID, string productID, int quantity)
        {
            BillID = billID;
            ProductID = productID;
            Quantity = quantity;
        }
        public DTO_DetailReceipt()
        {
            BillID = string.Empty;
            ProductID = string.Empty;
            Quantity = 0;
        }
    }
}
