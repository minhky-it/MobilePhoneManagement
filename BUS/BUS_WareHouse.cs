using System.Data;
using DAL;

namespace BUS
{
    public class BUS_WareHouse
    {
        DAL_WareHouse wareHouse;

        public BUS_WareHouse ()
        {
            wareHouse = new DAL_WareHouse("", "");
        }

        public BUS_WareHouse(string iD, string dateInput)
        {
            wareHouse = new DAL_WareHouse(iD, dateInput);
        }

        public void addQuery()
        {
            wareHouse.addQuery();
        }

        public DataTable selectQuery()
        {
            return wareHouse.selectQuery();
        }
        //select detail of warehouse
        public DataTable selectQueryID(string id)
        {
            return wareHouse.selectQueryID(id);
        }
        //select all of warehouse
        public DataTable selectQueryDetailAll()
        {
            return wareHouse.selectQueryDetailAll();
        }
    }
}
