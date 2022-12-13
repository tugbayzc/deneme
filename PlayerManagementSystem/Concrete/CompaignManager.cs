using PlayerManagementSystem.Abstract;
using PlayerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.Concrete
{
    public class CompaignManager : ICampaignService
    {
        public void AddNewCampaign(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameId+" numaralı oyuna "+ campaign.DiscountRate+ " oranında kampanya eklendi.");
        }

        public void DeleteCampaign(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameId + " numaralı oyundaa " + campaign.CompaignName + " adında var olan kampanya silindi.");
        }

        public void UpdateCampaign(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameId + " numaralı oyun için yapılan kampanya tarihi " + campaign.EndDate + "  olarak güncellendi.");
        }
    }
}
