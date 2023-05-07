using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DetailWareHouse
    {
        private string wareHouseID;
        private string productID;

        public DTO_DetailWareHouse(string wareHouseID, string productID)
        {
            this.wareHouseID = wareHouseID;
            this.productID = productID;
        }

        public string WareHouseID { get => wareHouseID; set => wareHouseID = value; }
        public string ProductID { get => productID; set => productID = value; }
    }
}
