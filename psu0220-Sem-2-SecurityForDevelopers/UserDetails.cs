using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psu0220_Sem_2_SecurityForDevelopers
{
    class UserDetails
    {
        public string[,] validLogins;

        public UserDetails()
        {
            validLogins = new string[,] { { "admin", "42" }, { "user", "MonkeyBanana" } };
        }



    }
}
