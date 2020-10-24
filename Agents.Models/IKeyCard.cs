using System.Collections.Generic;

namespace Agents.Models
{
    public interface IKeyCard
    {
        public string  FirstMovingColor { get; set; }
        public List<string> ColorNames { get; set; }
        
        public void GenerateKeyCard();
    }
}