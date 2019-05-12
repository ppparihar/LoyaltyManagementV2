using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LoyaltyManagement.DAL
{
    public class RewardsContext:DbContext
    {
       public RewardsContext(DbContextOptions<RewardsContext> options):base(options) { }


        public DbSet<Customer> Customers { get; set; }

        public DbSet<Reward> Rewards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Reward>().ToTable("Reward");

        }
    }
}
