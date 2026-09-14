using Restaurant_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Data
{
    internal class TableRepository
    {
        public bool IsAvailable(int TableId)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "SELECT Status FROM TablesInfo WHERE TableId = '" + TableId + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            string status = cmd.ExecuteScalar().ToString();

            conn.Close();
            if (status == "Available")
            {
                return true;
            }
            return false;
        }

        public DataTable GetTableInfo()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "SELECT * FROM TablesInfo";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            conn.Close();
            return dt;
        }

        public void AddTable(RestaurantTable table)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "INSERT INTO TablesInfo (TableNumber, Capacity, Status) VALUES ('" + table.TableNumber + "', '" + table.Capacity + "', '" + table.TableStatus.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
