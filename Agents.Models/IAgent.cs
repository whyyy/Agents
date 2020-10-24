using Agents.Models.Helpers;

namespace Agents.Models
{
    public interface IAgent
    {
        public AgentColorName ColorName { get; set; }
        public int MovesLeft { get; set; }
        public int MovesDone { get; set; }
        public bool IsStarting { get; set; }

        public void ApplyStartingAgentRules();
    }
}