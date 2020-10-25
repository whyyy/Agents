using System.Collections.Generic;
using Agents.Infrastructure.Helpers;

namespace Agents.Infrastructure
{
    public interface IWordsLoader
    {
        public List<string> StringWords { get; set; }
        public void LoadWords(LoadingType loadingType);
    }
}