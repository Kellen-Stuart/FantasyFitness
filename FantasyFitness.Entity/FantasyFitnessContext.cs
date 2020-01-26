using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace FantasyFitness.Entity
{
    class FantasyFitnessContext : DbContext
    {
        public FantasyFitnessContext() : base()
        {

        }

        public DbSet<Goal> Goals { get; set; }
        public DbSet<GoalType> GoalTypes { get; set; }
    }
}
