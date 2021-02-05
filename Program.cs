using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumber = 12345 });

            OrderManager orderManager = new OrderManager();
            CampaignManager campaignManager = new CampaignManager();



            campaignManager.Add(new Campaign { CampaignId = 1, CampaignName = "YarıYarıya kampanyası", Discount = 50 });

            orderManager.Buy(new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumber = 12345 },
            new Campaign { CampaignId = 1, CampaignName = "YarıYarıya kampanyası", Discount = 50 },new Game {GameId=1,GameName="League of Legends",GamePrice=45});


        }
    }
}
