using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management.Data
{
    
    internal class KitchenRepository
    {
        public DataTable GetAllOrders()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string query = "SELECT OrderId as 'Order ID', TableId as 'Table ID', Status FROM Orders WHERE Status = 'Pending' OR Status = 'Preparing'";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable GetOrderItems(int orderId)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string query = "SELECT m.ItemName, oi.Quantity FROM OrderItems oi INNER JOIN MenuItems m ON oi.ItemId = m.ItemId WHERE oi.OrderId = '" + orderId + "'";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }


        public bool UpdateOrderStatus(int orderid, string status)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "UPDATE Orders SET Status = '"+status+"' WHERE OrderId = '"+orderid+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            return true;
        }
    }
}
