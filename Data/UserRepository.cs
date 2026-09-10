using Restaurant_Management.Enums;
using Restaurant_Management.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management.Data
{
    internal class UserRepository
    {
        public void AddUser(User user)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string query = "insert into Users (UserName, Email, Role, Password) values('"+user.Username+"','"+user.Email+"','"+user.Role.ToString() + "','"+user.Password+"')";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public User GetUser(string username, string password)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string query =
                "SELECT UserId, UserName, Email, Role FROM Users WHERE UserName = '" + username + "' AND Password = '" + password + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable table = ds.Tables[0];

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                User user = new User()
                {
                    UserId = Convert.ToInt32(row["UserId"]),
                    Username = row["UserName"].ToString(),
                    Email = row["Email"].ToString(),
                    Role = (UserRole)Enum.Parse(
                        typeof(UserRole),
                        row["Role"].ToString()
                    )
                };

                return user;
            }

            return null;
        }


    }
}
