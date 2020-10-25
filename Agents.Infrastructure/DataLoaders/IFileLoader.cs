namespace Agents.Infrastructure.DataLoaders
{
    public interface IFileLoader
    {
        public string LoadedWords { get; set; }
        public void Load(string filePath);
    }
}