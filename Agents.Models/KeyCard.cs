using System.Collections.Generic;

namespace Agents.Models
{
    public class KeyCard : IKeyCard
    {
        public string FirstMovingColor { get; set; }
        public List<string> ColorNames { get; set; } = new List<string>();
    }
}