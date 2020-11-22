using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psu0220_Sem_2_SecurityForDevelopers
{
    class BruteForce
    {
        public string[] passwordList;

        public BruteForce()
        {
            passwordList = new string[] {   "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                                            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN",
                                            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                                            "fourtytwo", "FOURTYTWO", "42",
                                            "sixhundredandsixtysix", "SIXHUNDREDANDSIXTYSIX", "666",
                                            "MonkeyBanana", "HeartShapedPear", "AccessDenied" };
        }

        public void StartAttack()
        {

        }


    }
}
