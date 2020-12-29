using Agents.Infrastructure.Helpers;
using Agents.Models;

namespace Agents.Infrastructure.Generators
{
    public interface IBoardGenerator
    {
        IBoard GenerateBoard(LoadingType loadingType);
    }
}