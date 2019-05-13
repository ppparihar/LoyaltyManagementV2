using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoyaltyManagement.Common;

namespace LoyaltyManagement.Interfaces
{
    public interface IRewadsRepository
    {
        Option<int> GetPoints(int customerId);

        void AddPoints(int customerId, int points);

        void Redeem(int customerId, int points);

    }
}
