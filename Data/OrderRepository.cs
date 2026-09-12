using Restaurant_Management.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Data
{
    internal class OrderRepository
    {

        public bool AddOrder(Order order)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string orderQuery = "insert into Orders (TableId, UserId, OrderDate, Status, TotalPrice) values(" + order.TableId + ", " + order.UserId + ", " + "'" + order.OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + order.Status + "', " +order.TotalPrice +")";
            SqlCommand cmd = new SqlCommand(orderQuery, conn);

            cmd.ExecuteNonQuery();

            // Get the newly inserted OrderId
            string idQuery = "SELECT SCOPE_IDENTITY()";

            SqlCommand idCommand = new SqlCommand(idQuery, conn);

            int orderId = Convert.ToInt32(idCommand.ExecuteScalar());
            foreach (OrderItem item in order.Items)
            {
                if (item == null)
                {
                    continue;
                }
                string itemQuery =
                    "INSERT INTO OrderItems " +
                    "(OrderId, ItemId, Quantity, Price) " +
                    "VALUES (" +
                    orderId + ", " +
                    item.ItemId + ", " +
                    item.Quantity + ", " +
                    item.Price + ")";

                SqlCommand itemCmd = new SqlCommand(itemQuery, conn);

                itemCmd.ExecuteNonQuery();
            }

            string tableQuery = "UPDATE TablesInfo SET Status = 'Occupied' WHERE TableId = " + order.TableId;
            SqlCommand tableCmd = new SqlCommand(tableQuery, conn);
            tableCmd.ExecuteNonQuery();


            conn.Close();
            return true;
        }
    }
}
