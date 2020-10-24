using System.Collections.Generic;
using Agents.Models.Helpers;

namespace Agents.Models
{
    public class KeyCard : IKeyCard
    {
        private List<ColorNames> _colorNames;
        
        public ColorNames FirstMovingColor { get; set; }
        
        public void GenerateKeyCard()
        {
            throw new System.NotImplementedException();
        }
    }
}