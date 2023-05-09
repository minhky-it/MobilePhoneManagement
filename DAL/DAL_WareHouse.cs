using System.Data;
using DTO;

namespace DAL
{
    public class DAL_WareHouse
    {
        private DTO_WareHouse wareHouse;
        
        public DAL_WareHouse(string iD, string dateInput)
        {
            wareHouse = new DTO_WareHouse(iD, dateInput);
        }

        public void addQuery()
        {
            string query = "INSERT INTO WAREHOUSE VALUES('" + wareHouse.ID1 + "','" + wareHouse.DateInput + "')";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM WAREHOUSE";
            return Connection.selectQuery(s);
        }

        // get Datatable desc order
        public DataTable getWarehouseID()
        {
            string s = "select top 1 warehouseID from WAREHOUSE order by warehouseID desc";
            return Connection.selectQuery(s);
        }

        //select detail of warehouse
        public DataTable selectQueryID(string id)
        {
            string s = string.Format("SELECT * FROM DETAIL_WAREHOUSE WHERE warehouseID = '{0}'", id);
            return Connection.selectQuery(s);
        }

        //select all of warehouse
        public DataTable selectQueryDetailAll()
        {
            string s = "SELECT * FROM DETAIL_WAREHOUSE";
            return Connection.selectQuery(s);
        }
    }
}
