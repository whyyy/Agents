using Agents.Infrastructure.Helpers;

namespace Agents.Infrastructure.Generators
{
    public interface IBoardGenerator
    {
        void GenerateBoard(LoadingType loadingType);
    }
}