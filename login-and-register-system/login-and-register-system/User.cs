using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string Name { get; set; }
        public string SurnName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public User(string name, string surnName, string email, string password)
        {
            Name = name;
            SurnName = surnName;
            Password = password;
            Email = email;
        }
    }
}
