using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgileProject.Models;
using AgileProject.Models.GameSystemModels;
using AgileProject.Services.GameSystem;
using AgileProject.Services.GameSystems;

namespace AgileProject.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameSystemController : ControllerBase
    {
        private readonly IGameSystems _gameSystems;
        public GameSystemController(IGameSystems gameSystems)
        {
            _gameSystems = gameSystems;
        }

        // Get API/GameSystem
        [HttpGet]
        public async Task<IActionResult> GetAllGameSystems()
        {
            var gameSystems = await _gameSystems.GetAllGameSystemsAsync();
                return Ok(gameSystems);
        }

        // Post API/GameSystem
        [HttpPost("Add")]
        public async Task<IActionResult> CreateGameSystem([FromBody] GameSystemCreate request)
        {
            if (!ModelState.IsValid)
            return BadRequest(ModelState);

            if (await _gameSystems.CreateGameSystemsAsync(request))
            return Ok("Game System created successfully.");

            return BadRequest("Game System could not be created.");
        }

        // Put API/GameSystem
        [HttpPut]
        public async Task<IActionResult> UpdateGameSystemById([FromBody] GameSystemUpdate request)
        {
            if (!ModelState.IsValid)
            return BadRequest(ModelState);

            return await _gameSystems.UpdateGameSystemAsync(request)
            ? Ok("Game System updated successfully.")
            : BadRequest("Game System could not be updated.");
        }

        [HttpDelete("gameSystemId:int")]
        public async Task<IActionResult> DeleteGameSystem([FromRoute] int gameSystemId)
        {
            return await _gameSystems.DeleteGameSystemAsync(gameSystemId)
            ? Ok($"Game System {gameSystemId} was deleted successfully.")
            : BadRequest($"Game System {gameSystemId} could not be deleted.");
        }
    }
}