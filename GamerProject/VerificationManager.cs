using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    class VerificationManager : IVerificationServices

    {
        public bool Verification(Gamer gamer)
        {
            if (
                gamer.FirstName == "Ensar" &&
                gamer.LastName == "Aydın" &&
                gamer.IdentitityNumber == 35638988000 &&
                gamer.Birthday == 2000
                )
            {

                return true;
            }
            else
            {
                return false;

            }
            
           
        }
    }
}
