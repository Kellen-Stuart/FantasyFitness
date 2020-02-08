using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FantasyFitness.Data;

namespace ImportExcel
{
    public static class ExcelParser
    {
        // todo: write a test for this
        public static List<Team> GetTeams()
        {
            return File.ReadAllLines("Goals_Sheet.csv")
                .Skip(1)
                .Select(x => x.Split(','))
                .Select(x => new Team
                {
                    Id = Guid.NewGuid(),
                    Name = x[0]
                }).ToList();
        }

        // todo: write a test for this
        public static List<Goal> GetGoals()
        {
            return File.ReadAllLines("Goals_Sheet.csv")
                .Skip(1)
                .Select(x => x.Split(','))
                .Select(x => new Goal
                {
                    Id = Guid.NewGuid(),
                    Season = int.Parse(x[1]),
                    Week = int.Parse(x[2]),
                    Type = ParseStringToGoalType(x[3]),
                    Description = x[4],
                    Target = int.Parse(x[5]),
                    Actual = int.Parse(x[6]),
                    Unit = x[7]
                }).ToList();
        }

        private static GoalType ParseStringToGoalType(string rawGoalTypeString)
        {
            Enum.TryParse(rawGoalTypeString, out GoalType goalTypeValue);
            return goalTypeValue;
        }
    }
}