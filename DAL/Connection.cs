using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection cn;

        public static void connect()
        {
            string s = "initial catalog = MOBILEMANAGEMENT; data source = MINHKY-PC\\MSSQLSERVER01; integrated security = true";
            cn = new SqlConnection(s);
            cn.Open();
        }

        //Connect and excuted
        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.ExecuteNonQuery();
        }

        //Query statements
        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
