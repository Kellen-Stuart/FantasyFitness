using System;

namespace FantasyFitness.Data
{
    public class Goal
    {
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        public int Season { get; set; }
        public int Week { get; set; }
        public GoalType Type { get; set; }
        public string Description { get; set; }
        public int Target { get; set; }
        public int Actual { get; set; }
        public string Unit { get; set; }
    }
}