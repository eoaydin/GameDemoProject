using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    public interface ISaleService
    {
        void Buy(Game game, Customer customer, Campaign campaign);
        void Buy(Game game, Customer customer);
    }
}
