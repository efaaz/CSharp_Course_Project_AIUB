using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.Models;
using Restaurant_Management.Data;

namespace Restaurant_Management.Services
{
    internal class Authentication
    {
        private UserRepository repository = new UserRepository();

        public User Login(string username, string password)
        {
            return repository.GetUser(username, password);
        }
    }
}
