using Agents.Data.Consts;
using Agents.Infrastructure.DataLoaders;
using NUnit.Framework;

namespace Agents.Infrastructure.Tests
{
    public class FileLoaderTests
    {
        private IFileLoader _fileLoader;
        [SetUp]
        public void Setup()
        {
            _fileLoader = new FileLoader();
        }

        [Test]
        public void Should_OpenFile_When_Load()
        {
            _fileLoader.Load(FileDetails.FilePath);
        }

        [Test]
        public void Should_LoadedWordsNotBeEmpty_When_Load()
        {
            _fileLoader.Load(FileDetails.FilePath);
            Assert.IsNotEmpty(_fileLoader.LoadedWords);
        }
    }
}