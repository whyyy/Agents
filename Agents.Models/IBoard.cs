using System.Collections.Generic;

namespace Agents.Models
{
    public interface IBoard
    {
        public List<Word> Words { get; set; }
    }
}