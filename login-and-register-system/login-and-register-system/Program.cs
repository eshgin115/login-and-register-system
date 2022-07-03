using System;
using System.Collections.Generic;

namespace ConsoleApp1
{


    internal class Program
    {
        public static List<User> persons { get; set; } = new List<User>();
        static void Main(string[] args)
        {
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("choose Commands : ");
                string command = Console.ReadLine();
                if (command == "/register")
                {
                    Console.WriteLine("Name : ");
                    string name = Console.ReadLine();

                    Console.WriteLine("LastName : ");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Password : ");
                    string password = Console.ReadLine();
                    Console.WriteLine("PasswordAgain");
                    string passwordAgain = Console.ReadLine();

                    Console.WriteLine("Email :");
                    string email = Console.ReadLine();
                    if (password == passwordAgain)
                    {
                        AddNewPerson(name, lastName, password, email);
                    }
                    else
                    {
                        Console.WriteLine("Password is not correct ");
                    }


                }
                else if (command == "/login")
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter your Email :");
                    string gmail = Console.ReadLine();

                    Console.WriteLine("Please enter your Password :");
                    string pass = Console.ReadLine();

                    Login login = new Login(gmail, pass);

                    if (login.IsCheckLogEmail(gmail, persons) && login.IsCheckLogPass(pass, persons))
                    {
                        Console.WriteLine("You are logged in");
                        Console.WriteLine();


                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }

                }
                else if (command == "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Choose Correct Command");
                }

            }
        }
        public static bool AddNewPerson(string name, string lastname, string email, string password)
        {
            User user = new User(name, lastname, password, email);
            UserValidator uservalidator = new UserValidator();
            if (uservalidator.Check(user))
            {
                persons.Add(user);

                return true;
            }


            Console.WriteLine("Information is not correct");
            return false;
        }




        public static bool IsCheckUnikal(string text)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Email == text)
                {
                    return true;
                }
            }
            return false;
        }


    }
}


