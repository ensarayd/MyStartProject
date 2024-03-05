using System;


namespace GamerProject
{
    class program
    {
        public  static void Main(string[] args) 
        {
            GamerManager gamerManager = new GamerManager(new VerificationManager());

            gamerManager.Add(new Gamer
            {
                Birthday = 2000,
                FirstName = "Ensar",
                LastName = "Aydın",
                IdentitityNumber = 35638988000
            }
            );

        }
    }


}