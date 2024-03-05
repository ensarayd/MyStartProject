using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    class GamerManager : IGamerServices
    {

      IVerificationServices _verificationServices;

        public GamerManager(IVerificationServices verificationServices)
        {
            _verificationServices = verificationServices;
        }

        public void Add(Gamer gamer)
        {
            if (_verificationServices.Verification(gamer) == true)
            {
                Console.WriteLine("Kayıt Kabul Edildi");
            }
            else
            {
                Console.WriteLine("Kayıt Kabul Edilmedi");
            }
          
        }

        public void Remove(Gamer gamer)
        {

        }

        public void Update(Gamer gamer)
        {
            
        }
    }
}
