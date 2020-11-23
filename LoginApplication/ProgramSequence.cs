using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication
{
    class ProgramSequence
    {
        /// <summary>
        /// constructor
        /// </summary>
        public ProgramSequence()
        {
            ProgramStart();
            ProgramMain();
            End();
        }

        /// <summary>
        /// Welcome message
        /// </summary>
        private static void ProgramStart()
        {
            string start = "\n" + "Linda's super insecure login application" + "\n\n";
            Console.WriteLine(start);
        }

        /// <summary>
        /// Main part of the program
        /// Create references to userDetail, loginLogic
        /// </summary>
        private static void ProgramMain()
        {
            UserDetails userDetails = new UserDetails();
            LoginLogic loginLogic = new LoginLogic();
            LoginSequence(userDetails, loginLogic);
        }

        /// <summary>
        /// Main log-in sequence
        /// </summary>
        /// <param name="userDetails">the instance of the userDetails class</param>
        /// <param name="loginLogic">the instance of the LoginLogic class</param>
        private static void LoginSequence(UserDetails userDetails, LoginLogic loginLogic)
        {
            bool doLogin;
            do
            {
                loginLogic.PasswordInput(userDetails, loginLogic.UsernameSelection(userDetails));
                doLogin = ProgramRedo();
                Console.WriteLine("\n");
            }
            while (doLogin);
        }

        /// <summary>
        /// request if the Main login sequence should be rerun.
        /// </summary>
        /// <returns>boolean to indicate if the login main sequence should be rerun.</returns>
        private static bool ProgramRedo()
        {
            Console.WriteLine("type YES to redo" + "\n\n");
            return RedoAnswerParser(Console.ReadLine().ToLower());
        }

        /// <summary>
        /// parses the answer from ProgramRedo
        /// </summary>
        /// <param name="input">the input string</param>
        /// <returns>true if a variation of yes is given. false if a variation of no is given.</returns>
        private static bool RedoAnswerParser(string input)
        {
            bool result = true;
            bool proceed = false;
            do
            {
                if (input == "y" | input == "yes")
                {
                    result = true;
                    proceed = true;
                }
                else if (input == "n" | input == "no")
                {
                    result = false;
                    proceed = true;
                }
                else
                {
                    Console.WriteLine("Please enter Y/N.");
                    input = Console.ReadLine();
                }
            } while (!proceed);
            return result;
        }

        /// <summary>
        /// closing method, goodbye message
        /// </summary>
        private static void End()
        {
            string end = "End of demonstration.";
            Console.WriteLine(end);
            Console.ReadLine();
        }
    }
}
