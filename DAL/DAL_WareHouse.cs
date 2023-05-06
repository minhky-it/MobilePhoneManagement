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
    }
}
