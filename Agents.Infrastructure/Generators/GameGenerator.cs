using Agents.Infrastructure.Helpers;
using Agents.Models;

namespace Agents.Infrastructure.Generators
{
    public class GameGenerator : IGameGenerator
    {
        private IBoard _board;
        private IKeyCard _keyCard;
        
        private readonly IKeyCardGenerator _keyCardGenerator;
        private readonly IBoardGenerator _boardGenerator;

        public GameGenerator(IKeyCardGenerator keyCardGenerator, IBoardGenerator boardGenerator)
        {
            _keyCardGenerator = keyCardGenerator;
            _boardGenerator = boardGenerator;
        }
        
        public void Start()
        {
            PrepareGame();
        }

        private void PrepareGame()
        {
            _keyCard = _keyCardGenerator.GenerateKeyCard();
            _board = _boardGenerator.GenerateBoard(LoadingType.FromTxtFile);
        }
    }
}