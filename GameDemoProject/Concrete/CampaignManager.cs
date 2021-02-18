using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrete
{
    public class CampaignManager:ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("The Campaign Created!");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("The Campaign Deleted!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("The Campaign Updated");
        }
    }
}
