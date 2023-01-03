using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgileProject.Services.Game;
using Microsoft.AspNetCore.Http;
using AgileProject.Models.GameViewModels;
//using Microsoft.AspNetCore.Authorization;

namespace AgileProject.WebAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGames _gameService;
        public GameController(IGames gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGame([FromBody] GameCreate request)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await _gameService.CreateGameAsync(request))
                return Ok("Game entry created successfully!");

            return BadRequest("Game could not be entered.");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGames()
        {
            var games = await _gameService.GetAllGamesAsync();
            return Ok(games);
        }
    }
}