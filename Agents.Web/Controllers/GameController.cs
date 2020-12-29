using Agents.Infrastructure.Generators;
using Microsoft.AspNetCore.Mvc;

namespace Agents.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly IKeyCardGenerator _keyCardGenerator;
        private readonly IGameGenerator _gameGenerator;

        public GameController(IGameGenerator gameGenerator)
        {
            _gameGenerator = gameGenerator;
        }
        
        [HttpGet]
        public string Get()
        {
            _gameGenerator.Start();
            return "Game Started";
        }
    }
}