using System;
using Agents.Infrastructure.Helpers;
using Agents.Models;
using Agents.Models.Helpers;

namespace Agents.Infrastructure.Generators
{
    public class BoardGenerator : IBoardGenerator
    {
        private readonly IWordsLoader _wordsLoader;
        private readonly IBoard _board;
        private readonly Random _random;

        public BoardGenerator(IWordsLoader wordsLoader, IBoard board)
        {
            _wordsLoader = wordsLoader;
            _board = board;
            _random = new Random();
        }
        
        public void GenerateBoard(LoadingType loadingType)
        {
            _wordsLoader.LoadWords(loadingType);
            if (_wordsLoader.StringWords.Count < 1)
            {
                return;
            }

            var position = 1;

            while (_board.Words.Count < KeyCardRule.KeyCardSize)
            {
                var word = PickRandomWord();
                _board.Words.Add(new Word(word, position));
                _wordsLoader.StringWords.Remove(word);
                position++;
            }
        }

        private string PickRandomWord()
        {
            var index = _random.Next(_wordsLoader.StringWords.Count);
            return _wordsLoader.StringWords[index];
        }
    }
}