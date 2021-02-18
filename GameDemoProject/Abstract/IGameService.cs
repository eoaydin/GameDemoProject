using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    public interface IGameService
    {
        void AddGame(Game game);
        void RemoveGame(Game game);
    }
}
