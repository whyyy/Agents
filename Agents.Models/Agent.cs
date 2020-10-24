using System;
using Agents.Models.Helpers;

namespace Agents.Models
{
    public class Agent  :IAgent
    {
        public Agent(AgentColorName agentColorName, bool isFirstMoving)
        {
            ColorName = agentColorName;
            IsFirstMoving = isFirstMoving;
        }
        
        public AgentColorName ColorName { get; set; }
        public int MovesLeft { get; set; }
        public int MovesDone { get; set; }
        public bool IsFirstMoving { get; set; }

        public void ApplyStartingAgentRules()
        {
            if (IsFirstMoving)
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