using Agents.Models.Helpers;
using NUnit.Framework;

namespace Agents.Models.Tests
{
    public class AgentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_HaveNineMovesLeft_When_IsStarting()
        {
            var agent = new Agent(AgentColorName.Red, true);
            agent.ApplyStartingAgentRules();
            Assert.AreEqual(9, agent.MovesLeft);
        }
    }
}