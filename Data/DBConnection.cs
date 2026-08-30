using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Data
{
    public static class DBConnection
    {
        private static readonly string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Restaurant Managemnet;Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
