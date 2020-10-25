using Agents.Infrastructure.Generators;
using FakeItEasy;
using NUnit.Framework;

namespace Agents.Models.Tests
{
    public class AgentTests
    {
        private IAgent _agent;
        private IAgentGenerator _agentGenerator;
        
        [SetUp]
        public void Setup()
        {
            _agent = A.Fake<IAgent>();
            _agentGenerator = new AgentGenerator(_agent);
        }

        [Test]
        public void Should_HaveNineMovesLeft_When_FirstMoving()
        {
            _agent.IsFirstMoving = true;
            _agentGenerator.ApplyStartingAgentRules();
            Assert.AreEqual(9, _agent.MovesLeft);
        }

        [Test]
        public void Should_HaveEightMovesLeft_When_NotFirstMoving()
        {            
            _agent.IsFirstMoving = false;
            _agentGenerator.ApplyStartingAgentRules();
            Assert.AreEqual(8, _agent.MovesLeft);
        }
    }
}