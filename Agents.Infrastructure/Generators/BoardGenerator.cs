using Agents.Infrastructure.Helpers;
using Agents.Models;

namespace Agents.Infrastructure.Generators
{
    public class BoardGenerator : IBoardGenerator
    {
        private readonly IWordsLoader _wordsLoader;
        private readonly IBoard _board;

        public BoardGenerator(IWordsLoader wordsLoader, IBoard board)
        {
            _wordsLoader = wordsLoader;
            _board = board;
        }
        
        public void GenerateBoard(LoadingType loadingType)
        {
            _wordsLoader.LoadWords(loadingType);
            if (_wordsLoader.StringWords.Count < 1)
            {
                return;
            }

            var position = 1;
            foreach (var word in _wordsLoader.StringWords)
            {
                _board.Words.Add(new Word(word, position));
                position++;
            }
        }
    }
}