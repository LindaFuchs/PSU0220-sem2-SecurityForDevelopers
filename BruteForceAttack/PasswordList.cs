using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceAttack
{
    class PasswordList
    {
        public string[] passwordList;

        /// <summary>
        /// Constructor
        /// </summary>
        public PasswordList()
        {
            passwordList = new string[] {   "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                                            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN",
                                            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                                            "fourtytwo", "FOURTYTWO", "42",
                                            "sixhundredandsixtysix", "SIXHUNDREDANDSIXTYSIX", "666",
                                            "MonkeyBanana", "HeartShapedPear", "123456" };
        }
    }
}