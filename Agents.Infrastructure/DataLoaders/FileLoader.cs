using System.IO;

namespace Agents.Infrastructure.DataLoaders
{
    public class FileLoader : IFileLoader
    {
        public string LoadedWords { get; set; }

        public void Load(string filePath)
        {
            LoadedWords = File.ReadAllText(filePath);
        }
    }
}