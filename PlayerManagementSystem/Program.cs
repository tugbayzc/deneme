using CustomerManagementSystem.Concrete;
using PlayerManagementSystem.Concrete;
using PlayerManagementSystem.Entities;
using System;
namespace PlayerManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                FullName = "Tuğba Yazıcı",
                PlayerId=1,
                DateOfBirth= new DateTime(1996,4,20),
                TCNo="52236125542"
            };

            Player player2 = new Player
            {
                PlayerId = 2,
                FullName = "Ömer Sina",
                TCNo = "5465432132",
                DateOfBirth = new DateTime(2003, 5, 4)
            };

            Game game1 = new Game 
            { 
                GameId = 1, 
                GameName = "Metin2", 
                GamePrice = 20.5 
            };

            Campaign campaign1 = new Campaign
            {
                CompaignName = "kasım indirimi",
                CompaignId = 1,
                StartDate = new DateTime(2022, 11, 1),
                EndDate = new DateTime(2022, 11, 30)
            };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Delete(player2);
            
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            
            CompaignManager campaignManager = new CompaignManager();
            campaignManager.UpdateCampaign(game1, campaign1);

        }
    }
}
