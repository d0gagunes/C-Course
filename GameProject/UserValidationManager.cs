using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Name == "Doga" && gamer.Surname=="Gunes" && gamer.GamerId==58 && gamer.HomeTown=="Istanbul" && gamer.IdentityNumber==132343 && gamer.BirthYear==2001)
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
