using PlayerManagementSystem.Abstract;
using PlayerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagementSystem.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" adlı oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName+" adlı oyun silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName+" adlı oyun güncellendi.");
        }
    }
}
