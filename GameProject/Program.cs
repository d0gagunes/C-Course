using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEstateUserValidationManager());
          gamerManager.Add(new Gamer
          { GamerId = 58,
              BirthYear = 2001,
              IdentityNumber = 132343
          });
        }
    } 
}
