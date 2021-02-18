using GameDemoProject.Adapters;
using GameDemoProject.Concrete;
using GameDemoProject.Entities;
using System;

namespace GameDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Evren",
                LastName = "Aydın",
                DateOfBirth = new DateTime(1900, 05, 11),
                NationalityId = "12345678900"
            };

            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "Haftasonu indirimleri",
                Discount = 0.4
            };

            Game game = new Game
            {
                Id = 1,
                GameName = "Counter Strike",
                Price = 150.00
            };
            //Instance
            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            CampaignManager campaignManager = new CampaignManager();
            SaleManager saleManager = new SaleManager();

            //Gamer Add-Delete-Update
            customerManager.Save(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);

            //Campaign Add-Delete-Update
            campaignManager.AddCampaign(campaign);
            campaignManager.DeleteCampaign(campaign);
            campaignManager.UpdateCampaign(campaign);

            //Sale with/without campaign
            saleManager.Buy(game, customer, campaign);
            saleManager.Buy(game, customer);

            Console.ReadLine();
        }
    }
}
