using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LoyaltyManagement.DAL
{
    public class RewardsContext:DbContext
    {
        RewardsContext(DbContextOptions<RewardsContext> options):base(options) { }
    }
}
