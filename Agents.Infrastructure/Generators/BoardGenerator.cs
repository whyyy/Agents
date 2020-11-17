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
        private readonly IKeyCard _keyCard;

        public BoardGenerator(IWordsLoader wordsLoader, IBoard board, IKeyCard keyCard)
        {
            _wordsLoader = wordsLoader;
            _board = board;
            _keyCard = keyCard;
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

            MatchColorsFromKeyCard();
        }

        private string PickRandomWord()
        {
            var index = _random.Next(_wordsLoader.StringWords.Count);
            return _wordsLoader.StringWords[index];
        }

        private void MatchColorsFromKeyCard()
        {
            for (int index = 0; index < _board.Words.Count; index++)
            {
                _board.Words[index].ColorName = (ColorName)Enum.Parse(typeof(ColorName), _keyCard.ColorNames[index]);
            }
        }
    }
}