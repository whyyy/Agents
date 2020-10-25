using System.Collections.Generic;
using Agents.Data.Consts;
using Agents.Infrastructure.DataLoaders;
using Agents.Infrastructure.Generators;
using Agents.Infrastructure.Helpers;

namespace Agents.Infrastructure
{
    public class WordsLoader : IWordsLoader
    {
        private readonly IFileLoader _fileLoader;
        private IStringListCreator _stringListCreator;
        
        public WordsLoader(IFileLoader fileLoader, IStringListCreator stringListCreator)
        {
            _fileLoader = fileLoader;
            _stringListCreator = stringListCreator;
        }

        public List<string> StringWords { get; set; }
        
        public void LoadWords(LoadingType loadingType)
        {
            switch (loadingType)
            {
                case LoadingType.FromTxtFile:
                    _fileLoader.Load(FileDetails.FilePath);
                    StringWords = _stringListCreator.PrepareList(_fileLoader.LoadedWords);
                    break;
            }
        }
    }
}