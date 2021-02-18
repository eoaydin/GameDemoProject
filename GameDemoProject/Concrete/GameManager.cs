using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrete
{
    public class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun sisteme eklendi.");
        }

        public void RemoveGame(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun sistemden kaldırıldı.");
        }
    }
}
