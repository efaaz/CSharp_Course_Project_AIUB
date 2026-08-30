using System;
using Restaurant_Management.Enums;
using Restaurant_Management.Models;
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
        }
        public User GetUser(string username, string password)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string query =
                "SELECT UserId, UserName, Email, Role FROM Users WHERE UserName = '" + username + "' AND Password = '" + password + "'";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                User user = new User()
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    Username = reader["UserName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Role = (UserRole)Enum.Parse(
                            typeof(UserRole),
                            reader["Role"].ToString()
                    )
                };
                reader.Close();
                conn.Close();

                return user;
            }

            reader.Close();
            conn.Close();

            return null;
        }


    }
}
