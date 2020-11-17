using System.Collections.Generic;

namespace Agents.Models
{
    public class Board : IBoard
    {
        public List<Word> Words { get; set; } = new List<Word>();
    }
}