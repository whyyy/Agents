using System;
using Agents.Models.Helpers;

namespace Agents.Models
{
    public class Agent  :IAgent
    {
        public Agent(AgentColorName agentColorName, bool isStarting)
        {
            ColorName = agentColorName;
            IsStarting = isStarting;
        }
        
        public AgentColorName ColorName { get; set; }
        public int MovesLeft { get; set; }
        public int MovesDone { get; set; }
        public bool IsStarting { get; set; }

        public void ApplyStartingAgentRules()
        {
            if (IsStarting)
            {
                MovesLeft = 9;
            }
            else
            {
                MovesLeft = 8;
            }
        }
    }
}