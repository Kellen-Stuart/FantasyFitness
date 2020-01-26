using System.Collections.Generic;
using System.Linq;

namespace FantasyFitness.Entity
{
    public class GoalTypeRepository : IGoalTypeRepository
    {
        public IEnumerable<GoalType> FetchAll()
        { 
            using (var context = new FantasyFitnessContext())
            {
                return context.GoalTypes.Select(x => x);
            }
        }

    }
}
