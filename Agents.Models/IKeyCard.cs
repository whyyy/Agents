using System.Collections.Generic;
using Agents.Models.Helpers;

namespace Agents.Models
{
    public interface IKeyCard
    {
        public ColorNames FirstMovingColor { get; set; }
        public List<ColorNames> ColorNames { get; set; }
        
        public void GenerateKeyCard();
    }
}