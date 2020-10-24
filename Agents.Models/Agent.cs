using Agents.Models.Helpers;

namespace Agents.Models
{
    public class Agent
    {
        public Agent(AgentColorName agentColorName, bool isStarting)
        {
            
        }
        
        public AgentColorName ColorName { get; set; }
        public int MovesLeft { get; set; }
        public int MovesDone { get; set; }
        public bool IsStarting { get; set; }
    }
}