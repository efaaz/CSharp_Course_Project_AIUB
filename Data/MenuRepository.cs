using Restaurant_Management.Models;
using System;
using System.Data;
using System.Data.SqlClient;

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

        public bool AddMenuItem(MenuItems menu)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string query = "INSERT INTO MenuItems (ItemName, ItemPrice, ItemStatus) VALUES ('"+ menu.ItemName + "', '"+ menu.ItemPrice + "', '"+ menu.ItemStatus + "')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            return true;
        }

        public bool IsMenuItemExists(string itemName)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "SELECT COUNT(*) FROM MenuItems WHERE ItemName = '" + itemName + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if (count > 0)
            {
                return true;
            }


            return false;
        }

        public bool UpdateMenuItem(MenuItems menu)
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
