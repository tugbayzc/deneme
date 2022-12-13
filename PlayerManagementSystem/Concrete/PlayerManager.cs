using PlayerManagementSystem.Abstract;
using PlayerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagementSystem.Concrete
{
    public class PlayerManager : IPlayerService
    {
        
        public void Delete(Player player)
        {
            Console.WriteLine(player.FullName + " adlı oyuncunun kaydı silindi!");
        }

        

        public void Register(Player player)
        {
            Console.WriteLine(player.FullName+ " adlı oyuncunun kaydı eklendi! ");
        }

        

        public void Update(Player player)
        {
            Console.WriteLine(player.FullName+" adlı oyuncu bilgileri güncellendi!");
        }
    }
}
