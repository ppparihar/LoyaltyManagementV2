using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyManagement.Interfaces
{
    public interface IRewadsRepository
    {
        int GetPoints(int customerId);

        void AddPoints(int points, int customerId);

        bool Redeem(int points, int customerId);
       
    }
}
