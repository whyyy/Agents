using System;
using Agents.Models.Helpers;

namespace Agents.Models
{
    public class Agent : IAgent
    {
        public Agent(ColorName colorName)
        {
            ColorName = colorName;
        }
        
        public ColorName ColorName { get; set; }
        public int MovesLeft { get; set; }
        public int MovesDone { get; set; }
        public bool IsFirstMoving { get; set; }
    }
}