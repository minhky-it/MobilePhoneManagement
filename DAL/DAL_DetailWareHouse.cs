using System.Data;
using DTO;


namespace DAL
{
    public class DAL_DetailWareHouse
    {
        private DTO_DetailWareHouse detailWareHouse;

        public DAL_DetailWareHouse(string wareHouseID, string productID)
        {
            detailWareHouse = new DTO_DetailWareHouse(wareHouseID, productID);
        }

        public void addQuery()
        {
            string query = "INSERT INTO DETAIL_WAREHOUSE VALUES('" + detailWareHouse.WareHouseID + "','" + detailWareHouse.ProductID + "')";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM DETAIL_WAREHOUSE";
            return Connection.selectQuery(s);
        }

    }
}
