using System.Data;
using DAL;


namespace BUS
{
    public class BUS_DetailWareHouse
    {
        DAL_DetailWareHouse detailWareHouse;

        public BUS_DetailWareHouse()
        {
            detailWareHouse = new DAL_DetailWareHouse("", "");
        }

        public BUS_DetailWareHouse(string wareHouseID, string productID)
        {
            detailWareHouse = new DAL_DetailWareHouse(wareHouseID, productID);
        }

        public void addQuery()
        {
            detailWareHouse.addQuery();
        }

        public DataTable selectQuery()
        {
            return detailWareHouse.selectQuery();
        }
    }
}
