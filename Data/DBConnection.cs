using System.Data.SqlClient;


namespace Restaurant_Management.Data
{
    public static class DBConnection
    {
        // Sohag's String
        private static readonly string ConnectionString = "Data Source=DESKTOP-U1CVD57;Initial Catalog=Restaurent Management;Integrated Security=True;";

        // Efaz's String
 
         //private static readonly string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Restaurant Managemnet;Integrated Security=True;";

        //private static readonly string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Restaurant Managemnet;Integrated Security=True;";


        // Fatema's String
         //private static readonly string ConnectionString = "Server=DESKTOP-K846D67\\MSSQLSERVER01;Database=RestaurantManagementDB;Trusted_Connection=True;";



        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
