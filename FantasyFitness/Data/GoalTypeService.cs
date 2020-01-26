using FantasyFitness.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyFitness.Data
{
    public class GoalTypeService
    {
        private IGoalTypeRepository _goalTypeRepository;
        public GoalTypeService()
        {
            _goalTypeRepository = new GoalTypeRepository();
        }
        public Task<GoalType[]> GetGoalTypesAsync()
        {
            return Task.FromResult(_goalTypeRepository.FetchAll().ToArray());
        }

    }
}
