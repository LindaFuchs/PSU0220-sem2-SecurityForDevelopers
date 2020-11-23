using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication
{
    class LoginLogic
    {
        /// <summary>
        /// Checks if username exists
        /// </summary>
        /// <param name="userDetails">an instance of UserDetails class</param>
        /// <returns>the username if exists</returns>
        public string UsernameSelection(UserDetails userDetails)
        {
            Console.WriteLine("Username?");
            string input = Console.ReadLine();
            bool valid = false;
            do
            {
                if (input == userDetails.User | input == userDetails.Admin)
                {
                    valid = true;
                    Console.WriteLine("Username: \"" + input + "\" selected." + "\n");
                }
                else
                {
                    Console.WriteLine("Username \"" + input + "\", doesn't exist.");
                    Console.WriteLine("try again." + "\n");
                    input = Console.ReadLine();
                }
            } while (!valid);
            return input;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userDetails">an instance of the UserDetails class</param>
        /// <param name="username">the username given</param>
        public void PasswordInput(UserDetails userDetails, string username)
        {
            Console.WriteLine("Password?");
            string input = Console.ReadLine();
            bool valid = false;
            do
            {
                if (username == userDetails.Admin)
                {
                    if (input == userDetails.AdminPassword)
                    {
                        valid = true;
                        Console.WriteLine("\n" + "####  We're in! ####" + "\n");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Attempted \"" + input + "\", password incorrect.");
                        Console.WriteLine("try again." + "\n");
                        input = Console.ReadLine();
                    }
                }
                else if (username == userDetails.User)
                {
                    if (input == userDetails.UserPassword)
                    {
                        valid = true;
                        Console.WriteLine("\n" + "####  We're in! ####" + "\n");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Attempted \"" + input + "\", password incorrect.");
                        Console.WriteLine("try again." + "\n");
                        input = Console.ReadLine();
                    }
                }
            } while (!valid);
        }
    }
}
