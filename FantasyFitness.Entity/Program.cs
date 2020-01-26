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
                var exerciseGoalType = new GoalType
                {
                    Type = "Exercise"
                };

                var lifestyleGoalType = new GoalType
                {
                    Type = "Lifestyle"
                };

                var dietGoalType = new GoalType
                {
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
            }
        }
    }
}
