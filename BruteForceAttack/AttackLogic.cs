using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceAttack
{
    class AttackLogic
    {

        /// <summary>
        /// Asks confirmation to start the attack.
        /// Parses to answer to ensure it is correct, asks again if wrong.
        /// </summary>
        public void MainAttackAnswerParser()
        {
            Console.WriteLine("Type 'Execute' to begin the attack." + "\n ");
            string input = Console.ReadLine();
            bool proceed = false;
            do
            {
                if (input == "execute" | input == "start")
                {
                    Console.WriteLine("Input " + "\"" + input + "\"" + " accepted");
                    proceed = true;
                }
                else
                {
                    Console.WriteLine("I am afraid I can not let you do that Linda.");
                    Console.WriteLine("Try again.");
                    Console.WriteLine("Type 'Execute' to begin the attack." + "\n ");
                    input = Console.ReadLine();
                    
                }
            } while (!proceed);
        }



        /// <summary>
        /// Countdown method, counts down 5 seconds.
        /// </summary>
        public bool CountDown()
        {
            bool b = false;

            b = fiveseconds();

            bool fiveseconds()
            {
                Console.WriteLine("Attack starting in 5");
                Task.WaitAll(Task.Delay(1000));

                Console.WriteLine("Attack starting in 4");
                Task.WaitAll(Task.Delay(1000));

                Console.WriteLine("Attack starting in 3");
                Task.WaitAll(Task.Delay(1000));

                Console.WriteLine("Attack starting in 2");
                Task.WaitAll(Task.Delay(1000));

                Console.WriteLine("Attack starting in 1");
                Task.WaitAll(Task.Delay(1000));

                Console.WriteLine("Commencing Attack");
                Task.WaitAll(Task.Delay(1000));

                return true;
            }

            do
            {

            } while (!b);

            return b;

        }

        internal void DoAttack()
        {
            Console.WriteLine("Attack pewpew"); ;
        }
    }
}
