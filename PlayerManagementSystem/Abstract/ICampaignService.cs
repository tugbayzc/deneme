using PlayerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagementSystem.Abstract
{
    public interface ICampaignService
    {
        void AddNewCampaign(Game game,Campaign campaign);
        void DeleteCampaign(Game game,Campaign campaign);
        void UpdateCampaign(Game game, Campaign campaign);
    }
}
