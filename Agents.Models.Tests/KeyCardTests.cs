using System.Linq;
using Agents.Models.Helpers;
using NUnit.Framework;

namespace Agents.Models.Tests
{
    public class KeyCardTests
    {
        private IKeyCard _keyCard;
        
        [SetUp]
        public void Setup()
        {
            _keyCard = new KeyCard();
        }

        [Test]
        public void Should_GenerateKeyCardWith25Items_When_GenerateKeyCard()
        {
            _keyCard.GenerateKeyCard();
            Assert.AreEqual(25, _keyCard.ColorNames.Count);
        }

        [Test]
        public void Should_KeyCardHaveOneBlackItem_When_GenerateKeyCard()
        {
            _keyCard.GenerateKeyCard();
            Assert.AreEqual(25, _keyCard.ColorNames.Count);
            Assert.AreEqual(1, _keyCard.ColorNames.Count(c => c.Equals(nameof(ColorName.Black))));
        }        
        
        [Test]
        public void Should_KeyCardHaveSevenYellowItems_When_GenerateKeyCard()
        {
            _keyCard.GenerateKeyCard();
            Assert.AreEqual(25, _keyCard.ColorNames.Count);
            Assert.AreEqual(7, _keyCard.ColorNames.Count(c => c.Equals(nameof(ColorName.Yellow))));
        }

        [Test]
        public void Should_FirstMovingColorHaveNineItems_When_GenerateKeyCard()
        {
            _keyCard.GenerateKeyCard();
            
            Assert.AreEqual(25, _keyCard.ColorNames.Count);
            Assert.AreEqual(7, _keyCard.ColorNames.Count(c => c.Equals(nameof(ColorName.Yellow))));

            if (_keyCard.FirstMovingColor == nameof(ColorName.Blue))
            {
                Assert.AreEqual(9, _keyCard.ColorNames.Count(c => c.Equals(nameof(ColorName.Blue))));
                Assert.AreEqual(8, _keyCard.ColorNames.Count(c => c.Equals(nameof(ColorName.Red))));
            }
            if (_keyCard.FirstMovingColor == nameof(ColorName.Red))
            {
                Assert.AreEqual(9, _keyCard.ColorNames.Count(c => c.Equals(nameof(ColorName.Red))));
                Assert.AreEqual(8, _keyCard.ColorNames.Count(c => c.Equals(nameof(ColorName.Blue))));
            }
        }
    }
}