using Agents.Models.Helpers;

namespace Agents.Models
{
    public interface IAgent
    {
        public ColorNames ColorName { get; set; }
        public int MovesLeft { get; set; }
        public int MovesDone { get; set; }
        public bool IsFirstMoving { get; set; }

        public void ApplyStartingAgentRules();
    }
}