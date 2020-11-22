using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psu0220_Sem_2_SecurityForDevelopers
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "\n" + "Welcome to Security for Developers Exam - BruteForce Demo!";
            string loginPrompt = "";
            string end = "End of demonstration.";

            UserDetails userDetails = new UserDetails();
            LoginLogic loginLogic = new LoginLogic();
            BruteForce BruteForce = new BruteForce();

            Console.WriteLine(start);
            Console.WriteLine(loginPrompt);


            Console.ReadLine();


            Console.WriteLine(end);
        }





    }
}
