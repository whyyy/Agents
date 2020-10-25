using Agents.Infrastructure.Helpers;
using NUnit.Framework;

namespace Agents.Infrastructure.Tests
{
    public class StringListCreatorTests
    {
        private IStringListCreator _stringListCreator;
        
        [SetUp]
        public void Setup()
        {
            _stringListCreator = new StringListCreator();
        }

        [Test]
        public void Should_CreateStringList_When_PrepareList()
        {
            var wordsSeparatedWithCommas = "first, second, white, black, small, big";
            var strings = _stringListCreator.PrepareList(wordsSeparatedWithCommas);
            Assert.IsNotEmpty(strings);
        }
    }
}