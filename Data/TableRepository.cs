using Restaurant_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Data
{
    internal class TableRepository
    {

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

        public bool AddTable(RestaurantTable table)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "INSERT INTO TablesInfo (TableNumber, Capacity, Status) VALUES ('" + table.TableNumber + "', '" + table.Capacity + "', '" + table.TableStatus.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public bool IsTableNumberExists(int tableNumber)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "SELECT COUNT(*) FROM TablesInfo WHERE TableNumber = '" + tableNumber + "'";


            SqlCommand cmd = new SqlCommand(query, conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if (count > 0)
            {
                return true;
            }

            
            return false;
        }

        public bool UpdateTableInfo(RestaurantTable table)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "UPDATE TablesInfo SET TableNumber = '" + table.TableNumber + "', Capacity = '" + table.Capacity + "', Status = '" + table.TableStatus.ToString() + "' WHERE TableId = '" + table.TableId + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}
