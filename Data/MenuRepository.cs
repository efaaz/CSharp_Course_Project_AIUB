using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Data
{
    internal class MenuRepository
    {
        public DataTable GetAllMenuItems()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "SELECT * FROM MenuItems ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public bool IsAvailable(int itemId)
        {
            // query to database checking if a itemid=5 is available
            return true; 
        }
    }
}
