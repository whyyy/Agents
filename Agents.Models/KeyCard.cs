using System;
using System.Collections.Generic;
using Agents.Models.Helpers;

namespace Agents.Models
{
    public class KeyCard : IKeyCard
    {
        private const int KeyCardSize = 25;
        
        public ColorNames FirstMovingColor { get; set; }
        public List<ColorNames> ColorNames { get; set; } = new List<ColorNames>();
        
        public void GenerateKeyCard()
        {
            while (ColorNames.Count < KeyCardSize)
            {
                var random = new Random();
                ColorNames.Add((ColorNames)random.Next(Enum.GetValues(typeof(ColorNames)).Length));
            }
        }
    }
}