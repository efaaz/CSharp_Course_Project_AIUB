using Restaurant_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_Management.Data
{
    internal class BillingRepository
    {
        public DataTable GetOrderDetails() 
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string OrderQuery = "select OrderId as 'Order ID', TableId as 'Table ID', OrderDate as 'Date', Status as 'Status' from Orders where Status = 'Ready'";
            SqlDataAdapter adp = new SqlDataAdapter(OrderQuery, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            
            return dt;
        }

        public DataTable GetItemDetails(int orderId) { 
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string ItemQuery = "select m.ItemName , m.ItemPrice , oi.Quantity , oi.Quantity*m.ItemPrice from OrderItems oi INNER JOIN Orders o on oi.OrderId=o.OrderId INNER JOIN MenuItems m on oi.ItemId=m.ItemId where o.Status='Ready' and o.OrderId='"+orderId+"'";
            SqlDataAdapter adp = new SqlDataAdapter(ItemQuery, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt =ds.Tables[0];

            return dt;
        }

        public bool GenerateBill(PaymentDetails pd) 
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string Query = "insert into PaymentDetails (OrderId,PaymentMethod,ServiceCharge,Vat,TotalAmount) values(" + pd.OrderId + ", ' " + pd.PaymentMethod +" '," + pd.ServiceCharge +" , " + pd.Vat + ", " +pd.TotalAmount+"  )";
            SqlCommand cmd = new SqlCommand(Query,conn);
            cmd.ExecuteNonQuery();

            string UpdateQuery =" UPDATE Orders SET Status = 'Billed' WHERE OrderId = " + pd.OrderId;
            SqlCommand cmdd = new SqlCommand(UpdateQuery, conn);
            cmdd.ExecuteNonQuery();

            string tableQuery = "UPDATE TablesInfo SET Status = 'Available' WHERE TableId = " + pd.TableId;
            SqlCommand tableCmd = new SqlCommand(tableQuery, conn);
            tableCmd.ExecuteNonQuery();

            return true;
        }
    }
}
