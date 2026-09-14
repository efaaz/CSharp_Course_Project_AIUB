using Restaurant_Management.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using Restaurant_Management.Models;

namespace Restaurant_Management.Data
{
    internal class ReportRepository
    {
        public Report GenerateSalesReport()
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string totalOrderquery = "SELECT COUNT(*) FROM Orders";

            SqlCommand cmd = new SqlCommand(totalOrderquery, conn);

            int totalOrders = Convert.ToInt32(cmd.ExecuteScalar());


            string totalCompeleteOrderquery = "SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'Completed'";
            SqlCommand cmd2 = new SqlCommand(totalCompeleteOrderquery, conn);
            int totalCompleteOrders = Convert.ToInt32(cmd2.ExecuteScalar());

            string totalSalesQuery = "SELECT SUM(TotalAmount) FROM PaymentDetails";
            SqlCommand cmd3 = new SqlCommand(totalSalesQuery, conn);
            double totalSales = Convert.ToDouble(cmd3.ExecuteScalar());

            Report report = new Report();

            report.TotalOrders = totalOrders;
            report. TotalCompleteOrders = totalCompleteOrders;
            report.TotalSales = totalSales;


            return report;
        }

        public Report GenerateCustomReport(DateTime startDate, DateTime endDate)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string customOrderQuery = "SELECT COUNT(*) FROM Orders WHERE OrderDate WHERE OrderDate >= '" + startDate + "'AND OrderDate <'" + endDate + "'";
            SqlCommand cmd = new SqlCommand(customOrderQuery, conn);
            int totalOrders = Convert.ToInt32(cmd.ExecuteScalar());

            string customCompleteOrderQuery = "SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'Completed' AND OrderDate >= '" + startDate + "' AND OrderDate < '" + endDate + "'";
            SqlCommand cmd1 = new SqlCommand(customCompleteOrderQuery, conn);
            int totalCompleteOrders = Convert.ToInt32(cmd1.ExecuteScalar());

            string customSalesQuery = "SELECT SUM(TotalPrice) FROM Orders WHERE OrderDate >= '" + startDate + "' AND OrderDate < '"     + endDate + "'";
            SqlCommand cmd2 = new SqlCommand(customSalesQuery, conn);
            int totalSales = Convert.ToInt32(cmd2.ExecuteScalar());

            Report report = new Report
            {
                TotalOrders = totalOrders,
                TotalCompleteOrders = totalCompleteOrders,
                TotalSales = totalSales
            };

            return report;

        }

        public DataTable GetOrderTable(DateTime startDate, DateTime endDate)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Orders WHERE OrderDate >= '" + startDate + "' AND OrderDate < '" + endDate + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
