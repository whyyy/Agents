using Agents.Models;

namespace Agents.Infrastructure.Generators
{
    public class AgentGenerator : IAgentGenerator
    {
        private readonly IAgent _agent;

        public AgentGenerator(IAgent agent)
        {
            _agent = agent;
        }
        
        public void ApplyStartingAgentRules()
        {
            if (_agent.IsFirstMoving)
            {
                _agent.MovesLeft = 9;
            }
            else
            {
                _agent.MovesLeft = 8;
            }
        }
    }
}