using System.Collections.Generic;

namespace Agents.Infrastructure.Helpers
{
    public interface IStringListCreator
    {
        public List<string> PrepareList(string wordsSeparatedWithCommas);
    }
}