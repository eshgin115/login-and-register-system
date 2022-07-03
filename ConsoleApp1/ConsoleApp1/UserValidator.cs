using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UserValidator : Validator
    {

        public bool Check(User user)
        {
            return IsCheckName(user.Name) & IsCheckLastName(user.SurnName) & IsCheckemail(user.Email);

        }
        public void Show(User user)
        {
            Console.Write(user.Name);
            Console.WriteLine(user.SurnName);
        }
        public bool IsCheckName(string text)
        {
            if (IsCheckLentgh(text, 3, 30))
            {
                return true;
            }
            Console.WriteLine("Name Lentgh is not correct");
            return false;
        }
        public bool IsCheckLastName(string text)
        {
            if (IsCheckLentgh(text, 5, 20))
            {
                return true;
            }
            Console.WriteLine("LastName Lentgh is not correct");
            return false;
        }

        public bool IsCheckemail(string mail)
        {
            if (IsCheckChar(mail))
            {
                return true;
            }
            Console.WriteLine("Mail is Not Correct");
            return false;
        }
        public bool IsCheckUnikalEmail(string text)
        {
            if (Program.IsCheckUnikal(text))
            {
                return true;
            }
            Console.WriteLine("Email exists ");
            return false;
        }

        internal void Show(string name)
        {
            throw new NotImplementedException();
        }
    }
}
