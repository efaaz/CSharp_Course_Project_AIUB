using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.Models;

namespace Restaurant_Management.Data
{
    internal class UserRepository
    {
        public User GetUser(string username, string password)
        {

            // SQL query
            // Retrieve data
            // Convert database values into User


            User user = new User();

            return user;
        }
        public void AddUser(User user)
        {
            // SQL query
            // Insert data into database
        }

    }
}
