using Agents.Models;

namespace Agents.Infrastructure.Generators
{
    public interface IKeyCardGenerator
    {
        public IKeyCard GenerateKeyCard();
    }
}