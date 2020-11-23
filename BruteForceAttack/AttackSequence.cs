using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BruteForceAttack
{
    class AttackSequence
    {
        /// <summary>
        /// constructor
        /// </summary>
        public AttackSequence()
        {

            AttackStart();
            AttackMainSequence();
            AttackEnd();
        }

        /// <summary>
        /// Welcome Message.
        /// </summary>
        private void AttackStart()
        {
            string start = "Welcome Linda" + "\n ";
            Console.WriteLine(start);
        }


        /// <summary>
        /// Main part of the program
        /// create a reference to PasswordList and AttackLogic
        /// Initiates the brute force attack
        /// </summary>
        private void AttackMainSequence()
        {
            PasswordList passwordList = new PasswordList();
            AttackLogic attackLogic = new AttackLogic();
            StartBruteForce(passwordList, attackLogic);
        }

        /// <summary>
        /// The main attack sequence
        /// </summary>
        /// <param name="passwordList">a reference to an isntance of class containing the list to use for the brute force</param>
        /// <param name="attackLogic">a reference to an instance of the class containing the attack logic</param>
        private void StartBruteForce(PasswordList passwordList, AttackLogic attackLogic)
        {

            bool doAttack;
            do
            {
                attackLogic.MainAttackAnswerParser();
                attackLogic.CountDown();
                attackLogic.DoAttack();
                doAttack = AttackRedo();
                Console.WriteLine("\n");
            }
            while (doAttack);
        }

        

        

        private bool AttackRedo()
        {
            Console.WriteLine("Attack finished. Do you want to try again? Y/N");
            return RedoAnswerParser(Console.ReadLine().ToLower());
        }



        private bool RedoAnswerParser(string input)
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
        private void AttackEnd()
        {
            string end = ("Thank you, come again!");
            Console.WriteLine(end);
            Console.ReadLine();
        }
    }
}