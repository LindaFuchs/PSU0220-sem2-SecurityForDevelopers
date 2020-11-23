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
            string start = "\n" + "Welcome Linda" + "\n\n";
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
            bool doingAttack;
            do
            {
                attackLogic.MainAttackAnswerParser();
                attackLogic.CountDown();
                doingAttack = attackLogic.DoAttack(passwordList);
            }
            while (doingAttack);

            bool redo = AttackRedo();
            if (redo)
            {
                StartBruteForce(passwordList, attackLogic);
            }
        }

        /// <summary>
        /// Method responsible for asking and initiating a re-do of the attack
        /// </summary>
        /// <returns>returns true or false, if the attack should be redone</returns>
        private bool AttackRedo()
        {
            Console.WriteLine("Attack finished. Do you want to try again? Y/N");
            return RedoAnswerParser(Console.ReadLine().ToLower());
        }

        /// <summary>
        /// Parses the userinput if the attack should be redone.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>returns true or false depending on if the attack should be redone.</returns>
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