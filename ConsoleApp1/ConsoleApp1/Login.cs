using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Login
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public Login(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public bool IsCheckLogEmail(string mail, List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == mail)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsCheckLogPass(string pass, List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Password == pass)
                {
                    return true;

                }
            }
            return false;
        }
    }
}
