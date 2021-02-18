using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Buy(Game game, Customer customer, Campaign campaign)
        {
            Console.WriteLine("Sevgili " + customer.FirstName + " " + game.GameName.ToUpper() + " oyunu kütüphanene eklendi.\n" + game.Price*campaign.Discount + " TL indirimle birlikte" +
                " oyun " + (game.Price * (1 - campaign.Discount)).ToString() + " TL'ye satın alındı.");
        }
        public void Buy(Game game, Customer customer)
        {
            Console.WriteLine("Sevgili " + customer.FirstName + " " + game.GameName.ToUpper() + " oyunu kütüphanene eklendi. Ödenen ücret: " + game.Price + " TL");
        }
    }
}
