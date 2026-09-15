using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Data
{
    public class DashBoardRepository
    {
        public int GetOrders()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string OrderQuery = "select count(*) from Orders";
            SqlCommand cmd = new SqlCommand(OrderQuery, conn);

            int orders = Convert.ToInt32(cmd.ExecuteScalar());

            return orders;
        }

        public int GetPendingOrders()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string PendingQuery = "select count(*) from Orders where Status='Pending'";
            SqlCommand cmd = new SqlCommand(PendingQuery, conn);
            int pending = Convert.ToInt32(cmd.ExecuteScalar());
            return pending;
        }

        public int GetPreparingOrders()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string PreparingQuery = "select count(*) from orders where Status = 'Preparing'";
            SqlCommand cmd = new SqlCommand(PreparingQuery, conn);
            int preparing = Convert.ToInt32(cmd.ExecuteScalar());
            return preparing;
        }

        public double GetTotalSales()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string TotalSale = "select ISNULL(sum(TotalPrice),0) from orders";
            SqlCommand cmd = new SqlCommand(TotalSale, conn);
            double totalSale = Convert.ToDouble(cmd.ExecuteScalar());
            return totalSale;
        }
    }
}
