using PlayerManagementSystem.Abstract;
using PlayerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagementSystem.Concrete
{
    public class SaleManager : ISalesService
    {
        public void Cancel(Game game, Player player)
        {
            Console.WriteLine(player.FullName+ "  adlı oyuncu "+ game.GameId+ " numaralı oyunun satın alımını iptal etti.");
        }

        public void Sell(Game game, Player player)
        {
            Console.WriteLine(player.FullName+" adlı oyn-uncu "+ game.GameId+ " numaralı oyunu satın aldı.");
        }
    }
}
