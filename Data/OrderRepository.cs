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

            string Orderquery = "insert into Orders (TableId, UserId, OrderDate, Status, TotalPrice) values(" + order.TableId + "','" + order.UserId + "','" + order.OrderDate + "','" + order.Status + "','" + order.TotalPrice + "')";

            SqlCommand cmd = new SqlCommand(Orderquery, conn);

            int orderId = Convert.ToInt32(cmd.ExecuteScalar());
            foreach (OrderItem item in order.Items)
            {
                string itemQuery =
                    "INSERT INTO OrderItem " +
                    "(OrderId, MenuItemId, Quantity, Price) " +
                    "VALUES (" +
                    orderId + ", " +
                    item.ItemId + ", " +
                    item.Quantity + ", " +
                    item.Price + ")";

                SqlCommand itemCmd = new SqlCommand(itemQuery, conn);

                itemCmd.ExecuteNonQuery();
            }
            conn.Close();
            return true;
        }
    }
}
