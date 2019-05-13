using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoyaltyManagement.Interfaces;
using LoyaltyManagement.DAL;
using Microsoft.EntityFrameworkCore;
using LoyaltyManagement.Common;

namespace LoyaltyManagement.Repositories
{
    public class RewadsRepository : IRewadsRepository
    {
        private readonly DbContextOptions<RewardsContext> contextOptions;

        public RewadsRepository(DbContextOptions<RewardsContext> contextOptions)
        {
            Gaurd.IsNotNull(contextOptions, nameof(contextOptions));

            this.contextOptions = contextOptions;
        }

        public void AddPoints(int customerId, int points)
        {
            using (var context = new RewardsContext(contextOptions))
            {
                var reward = context.Rewards
                             .Where(r => r.CustomerID == customerId)
                             .FirstOrDefault();

                if (reward == null)
                {
                    reward = new Reward
                    {
                        CustomerID = customerId
                    };
                    context.Rewards.Add(reward);
                }

                // todo: Need to handle Redeem and Add points simultaneously case.
                reward.TotalPoints += points;
                context.SaveChanges();
            }
        }

        public Option<int> GetPoints(int customerId)
        {
            using (var context = new RewardsContext(contextOptions))
            {
                var reward = context.Rewards
                             .Where(r => r.CustomerID == customerId)
                             .FirstOrDefault();

                return reward == null
                    ? Option<int>.CreateEmpty()
                    : Option<int>.Create(reward.TotalPoints);

            }
        }

        public void Redeem(int customerId, int points)
        {
            using (var context = new RewardsContext(contextOptions))
            {
                var reward = context.Rewards
                             .Where(r => r.CustomerID == customerId)
                             .FirstOrDefault();

                // todo: Need to throw right Exception
                if (reward == null)
                {
                    throw new InvalidOperationException(string.Format("There are no rewards for customer Id: {0}", customerId));
                }
                if (reward.TotalPoints < points)
                {
                    throw new InvalidOperationException(string.Format(" Can't Redeem points. Pointts to redeem {0} is more than holding points {1}", points, reward.TotalPoints));
                }
                // todo: Need to handle Redeem and Add points simultaneously case.
                reward.TotalPoints -= points;
                context.SaveChanges();
            }
        }
    }
}
