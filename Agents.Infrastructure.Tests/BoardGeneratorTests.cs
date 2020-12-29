using Agents.Data.Consts;
using Agents.Infrastructure.DataLoaders;
using Agents.Infrastructure.Generators;
using Agents.Infrastructure.Helpers;
using Agents.Models;
using NUnit.Framework;

namespace Agents.Infrastructure.Tests
{
    public class BoardGeneratorTests
    {
        private IWordsLoader _wordsLoader;
        private IFileLoader _fileLoader;
        private IStringListCreator _stringListCreator;
        private IBoard _board;
        private IKeyCard _keyCard;
        private IKeyCardGenerator _keyCardGenerator;
        private IBoardGenerator _boardGenerator;

        [SetUp]
        public void Setup()
        {
            _fileLoader = new FileLoader();
            _stringListCreator = new StringListCreator();
            _fileLoader.Load(FileDetails.FilePath);
            _stringListCreator.PrepareList(_fileLoader.LoadedWords);
            _wordsLoader = new WordsLoader(_fileLoader, _stringListCreator);
            _board = new Board();
            _keyCard = new KeyCard();
            _keyCardGenerator = new KeyCardGenerator(_keyCard);
            _keyCardGenerator.GenerateKeyCard();
            _boardGenerator = new BoardGenerator(_wordsLoader, _board, _keyCard);
        }

        [Test]
        public void Should_CreateBoardWith25Words_When_GenerateBoardFromTxtFile()
        {
            _boardGenerator.GenerateBoard(LoadingType.FromTxtFile);
            Assert.IsNotEmpty(_board.Words);
            Assert.AreEqual(25, _board.Words.Count);
        }

        [Test]
        public void Should_CreateBoardWhichMatchesColorsFromKeyCard_When_GenerateBoard()
        {
            _boardGenerator.GenerateBoard(LoadingType.FromTxtFile);
            Assert.IsNotEmpty(_board.Words);
            Assert.AreEqual(_keyCard.ColorNames[2], _board.Words[2].ColorName.ToString());
            Assert.AreEqual(_keyCard.ColorNames[5], _board.Words[5].ColorName.ToString());
            Assert.AreEqual(_keyCard.ColorNames[9], _board.Words[9].ColorName.ToString());
            Assert.AreEqual(_keyCard.ColorNames[24], _board.Words[24].ColorName.ToString());
        }
    }
}