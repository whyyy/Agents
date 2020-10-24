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
    }
}