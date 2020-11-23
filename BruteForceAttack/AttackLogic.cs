using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace BruteForceAttack
{
    class AttackLogic
    {
        private InputSimulator inputSimulator = new InputSimulator();

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
        public void CountDown()
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
        }

        /// <summary>
        /// Initiates the attack by calling the SimulateTextEntry method.
        /// </summary>
        /// <param name="passwordList"></param>
        /// <returns>returns false once no more input is available.</returns>
        internal bool DoAttack(PasswordList passwordList)
        {
            Console.WriteLine("Attack pewpew Laz0rz !!!");
            Console.WriteLine("========================");
            KeyboardSimulator keyboardSimulator = new KeyboardSimulator(inputSimulator);

            foreach (string pass in passwordList.passwordList)
            {
                keyboardSimulator.TextEntry(pass);
                inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
            }
            return false;
        }
    }
}
