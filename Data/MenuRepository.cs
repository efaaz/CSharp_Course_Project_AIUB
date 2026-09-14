using System.Data;
using System.Data.SqlClient;
using Restaurant_Management.Models;

namespace Restaurant_Management.Data
{
    internal class MenuRepository
    {
        public DataTable GetAllMenuItems()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "SELECT * FROM MenuItems ";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public bool AddMenuItem(MenuItem menu)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string query = "INSERT INTO MenuItems (ItemName, ItemPrice, ItemStatus) VALUES ('"+ menu.ItemName + "', '"+ menu.ItemPrice + "', '"+ menu.ItemStatus + "')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            return true;
        }

        public bool UpdateMenuItem(MenuItem menu)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "UPDATE MenuItems SET ItemName = '" + menu.ItemName + "', ItemPrice = '" + menu.ItemPrice + "', ItemStatus = '" + menu.ItemStatus + "' WHERE ItemId = '" + menu.ItemId + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}
