using System;
using System.Collections.Generic;
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
    }
}
