using Restaurant_Management.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management.Data
{
    internal class OrderRepository
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
            string query = "SELECT TableId as 'Table ID', TableNumber as 'Table Number', Status FROM TablesInfo";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            conn.Close();
            return dt;
        }
        public bool AddOrder(Order order)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string orderQuery = "INSERT INTO Orders (TableId, UserId, OrderDate, Status, TotalPrice) VALUES (" + order.TableId + ", " + order.UserId + ", " + "'" + order.OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + order.Status + "', " +order.TotalPrice +")";
            SqlCommand cmd = new SqlCommand(orderQuery, conn);

            cmd.ExecuteNonQuery();

            string idQuery = "SELECT SCOPE_IDENTITY()";

            SqlCommand idCommand = new SqlCommand(idQuery, conn);

            int orderId = Convert.ToInt32(idCommand.ExecuteScalar());
            foreach (OrderItem item in order.Items)
            {
                if (item == null)
                {
                    continue;
                }
                string itemQuery = "INSERT INTO OrderItems (OrderId, ItemId, Quantity, Price) VALUES (" + orderId + ", " + item.ItemId + ", " + item.Quantity + ", " + item.Price + ")";

                SqlCommand itemCmd = new SqlCommand(itemQuery, conn);

                itemCmd.ExecuteNonQuery();
            }

            string tableQuery = "UPDATE TablesInfo SET Status = 'Occupied' WHERE TableId = '" + order.TableId + "'";
            SqlCommand tableCmd = new SqlCommand(tableQuery, conn);
            tableCmd.ExecuteNonQuery();


            conn.Close();
            return true;
        }
    }
}
