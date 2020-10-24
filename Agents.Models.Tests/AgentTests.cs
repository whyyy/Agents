using Agents.Models.Helpers;
using NUnit.Framework;

namespace Agents.Models.Tests
{
    public class AgentTests
    {
        private IAgent _agent;
        
        [SetUp]
        public void Setup()
        {
            _agent = new Agent(AgentColorName.Red);
        }

        [Test]
        public void Should_HaveNineMovesLeft_When_FirstMoving()
        {
            _agent.IsFirstMoving = true;
            _agent.ApplyStartingAgentRules();
            Assert.AreEqual(9, _agent.MovesLeft);
        }

        [Test]
        public void Should_HaveEightMovesLeft_When_NotFirstMoving()
        {
            _agent.ApplyStartingAgentRules();
            _agent.IsFirstMoving = false;
            Assert.AreEqual(8, _agent.MovesLeft);
        }
    }
}