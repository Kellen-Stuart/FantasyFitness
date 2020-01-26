using System;
using System.Collections.Generic;

namespace FantasyFitness.Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FantasyFitnessContext())
            {
                // Initialize Goal Types
                // The admin will be able to configure these later

                context.Database.ExecuteSqlCommand("DELETE FROM GoalTypes");
                var exerciseGoalType = new GoalType
                {
                    GoalTypeId = Guid.NewGuid(),
                    Type = "Exercise"
                };

                var lifestyleGoalType = new GoalType
                {
                    GoalTypeId = Guid.NewGuid(),
                    Type = "Lifestyle"
                };

                var dietGoalType = new GoalType
                {
                    GoalTypeId = Guid.NewGuid(),
                    Type = "Diet"
                };
                var listOfAllGoalTypes = new List<GoalType>
                {
                    exerciseGoalType,
                    lifestyleGoalType,
                    dietGoalType
                };

                foreach(var goalType in listOfAllGoalTypes)
                {
                    context.GoalTypes.Add(goalType);
                }

                context.SaveChanges();
            }
        }
    }
}
