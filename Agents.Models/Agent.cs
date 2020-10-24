using System;
using Agents.Models.Helpers;

namespace Agents.Models
{
    public class Agent  :IAgent
    {
        public Agent(ColorNames colorName)
        {
            ColorName = colorName;
        }
        
        public ColorNames ColorName { get; set; }
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