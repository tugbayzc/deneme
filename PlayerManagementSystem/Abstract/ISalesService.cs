using PlayerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagementSystem.Abstract
{
    public interface ISalesService
    {
        void Sell(Game game,Player player);
        void Cancel(Game game,Player player);
    }
}
