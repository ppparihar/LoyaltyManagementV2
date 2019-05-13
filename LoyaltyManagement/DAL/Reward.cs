using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyManagement.DAL
{
    public class Reward
    {
        public int RewardID { get; set; }

        public int CustomerID { get; set; }

        public int TotalPoints { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Customer Customer { get; set; }
    }
}
