using PlayerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagementSystem.Abstract
{
    public interface IPlayerService
    {
        void Register(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
