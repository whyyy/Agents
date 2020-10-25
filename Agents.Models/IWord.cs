using Agents.Models.Helpers;

namespace Agents.Models
{
    public interface IWord
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ColorName ColorName { get; set; }
    }
}