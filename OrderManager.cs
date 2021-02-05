using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Buy(Gamer gamer, Campaign campaign,Game game)
        {
            Console.WriteLine("Satış gerçekleşti.Oyunun adı: "+game.GameName+" "+ "Oyuncunun adı: "+gamer.FirstName+" Kampanyanın adı:"+" "+campaign.CampaignName);
        }
    }
}
