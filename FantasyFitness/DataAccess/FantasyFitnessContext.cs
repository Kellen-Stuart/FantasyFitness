using FantasyFitness.Data;
using Microsoft.EntityFrameworkCore;

namespace FantasyFitness.DataAccess
{
    public class FantasyFitnessContext : DbContext
    {
        public FantasyFitnessContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Goal> Goals { get; set; }
    }
}