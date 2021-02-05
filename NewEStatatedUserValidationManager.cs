using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStatatedUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
