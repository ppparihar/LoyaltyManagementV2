using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyManagement.Interfaces
{
    public interface IPointsGenerator
    {
        int GetPoints(IProduct product);
    }
}
