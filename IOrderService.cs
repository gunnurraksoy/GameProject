using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderService
    {
        void Buy(Gamer gamer,Campaign campaign,Game game);
    }
}
