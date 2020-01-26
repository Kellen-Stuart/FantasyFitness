using System;

namespace FantasyFitness.Entity
{
    public class Goal
    {
        public Guid GoalId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Target { get; set; }
        public int Actual { get; set; }
        public string Unit { get; set; }
    }
}
