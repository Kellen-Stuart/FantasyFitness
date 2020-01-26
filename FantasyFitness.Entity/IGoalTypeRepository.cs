using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyFitness.Entity
{
    public interface IGoalTypeRepository
    {
        IEnumerable<GoalType> FetchAll();
    }
}
