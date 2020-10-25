using System;
using System.Collections.Generic;
using System.Linq;
using Agents.Models;
using Agents.Models.Helpers;

namespace Agents.Infrastructure.Generators
{
    public class KeyCardGenerator : IKeyCardGenerator
    {
        private readonly IKeyCard _keyCard;
        private readonly Random _random;
        private List<string> _availableColors = new List<string>();
        private int _addedBlueItemsCounter;
        private int _addedRedItemsCounter;
        private int _addedYellowItemsCounter;
        private int _blueItemsMaxQuantity;
        private int _redItemsMaxQuantity;

        public KeyCardGenerator(IKeyCard keyCard)
        {
            _random = new Random();
            _keyCard = keyCard;
        }
        
        public void GenerateKeyCard()
        {
            PickFirstMovingColor();
            SetMaxQuantities();
            PrepareColors();
            FillKeyCard();
        }

        private void FillKeyCard()
        {
            do
            {
                var drawnColor = PickRandomColor();
                _keyCard.ColorNames.Add(drawnColor);
                switch (drawnColor)
                {
                    case nameof(ColorName.Black):
                        _availableColors.Remove(nameof(ColorName.Black));
                        break;
                    case nameof(ColorName.Blue):
                        _addedBlueItemsCounter++;
                        if (_blueItemsMaxQuantity == _addedBlueItemsCounter)
                        {
                            _availableColors.Remove(nameof(ColorName.Blue));
                        }
                        break;
                    case nameof(ColorName.Red):
                        _addedRedItemsCounter++;
                        if (_redItemsMaxQuantity == _addedRedItemsCounter)
                        {
                            _availableColors.Remove(nameof(ColorName.Red));
                        }

                        break;
                    case nameof(ColorName.Yellow):
                        _addedYellowItemsCounter++;
                        if (KeyCardRule.YellowItemsMaxQuantity == _addedYellowItemsCounter)
                        {
                            _availableColors.Remove(nameof(ColorName.Yellow));
                        }

                        break;
                }
            } while (_keyCard.ColorNames.Count != KeyCardRule.KeyCardSize);
        }

        private void PrepareColors()
        {
            _availableColors = ((ColorName[]) Enum.GetValues(typeof(ColorName))).Select(c => c.ToString()).ToList();
        }

         private string PickRandomColor()
         {
             var index = _random.Next(_availableColors.Count);
             return _availableColors[index];
         }

         private void PickFirstMovingColor()
         {
             var startColors = new List<string> {nameof(ColorName.Blue), nameof(ColorName.Red)};
             var index = _random.Next(startColors.Count);
             _keyCard.FirstMovingColor = startColors[index];
         }

         private void SetMaxQuantities()
         {
             switch (_keyCard.FirstMovingColor)
             {
                 case nameof(ColorName.Blue):
                     _blueItemsMaxQuantity = 9;
                     _redItemsMaxQuantity = 8;
                     break;
                 case nameof(ColorName.Red):
                     _redItemsMaxQuantity = 9;
                     _blueItemsMaxQuantity = 8;
                     break;
             }
         }
    }
}