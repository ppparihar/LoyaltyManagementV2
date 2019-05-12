using LoyaltyManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyManagement.Models
{
    public class GoldCard : ICard
    {
        public int MaxLimit
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
