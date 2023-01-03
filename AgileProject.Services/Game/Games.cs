using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using AgileProject.Models.GameViewModels;
using AgileProject.Data;
using Microsoft.EntityFrameworkCore;
using AgileProject.Data.Entities;
using AgileProject.Models.GameSystemModels;

namespace AgileProject.Services.Game
{
    public class Games : IGames
    {
        private readonly int _userId;
        private readonly ApplicationDbContext _dbContext;
        public Games(IHttpContextAccessor httpContextAccessor, ApplicationDbContext dbContext)
        {
            // var userClaims = httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
            // var value = userClaims.FindFirst("Id")?.Value;
            // var validId = int.TryParse(value, out _userId);
            // if (!validId)
            //     throw new Exception("Attempted to build GameService without UserId claim");

            _dbContext = dbContext;
        }

        public async Task<bool> CreateGameAsync(GameCreate request)
        {
            var gameEntity = new GameEntity
            {
                Title = request.Title,
                // GameGenre = request.GameGenre,
                // GameSystem = request.GameSystem
            };

            _dbContext.Games.Add(gameEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public async Task<IEnumerable<GameListItem>> GetAllGamesAsync()
        {
            var games = await _dbContext.Games
                //.Where (entity => entity.OwnerId == _userId)
                .Select(entity => new GameListItem
                {
                    // Id = entity.Id,
                    Title = entity.Title,
                    //GameGenre = entity.GameGenre,
                    //GameSystem = entity.GameSystem
                })
                .ToListAsync();

            return games;
        }

        public async Task<GameDetails> GetGameByGameSystem(int gameId)
        {
            var gameEntity = await _dbContext.Games
            .FirstOrDefaultAsync(e =>
            e.Id == gameId && e.GameSystemId == _userId);

            return gameEntity is null ? null : new GameDetails
            {
                Id = gameEntity.Id,
                Title = gameEntity.Title
            };
        }

        public async Task<bool> UpdateGameAsync(GameUpdate request)
        {
            var gameEntity = await _dbContext.Games.FindAsync(request.Id);
            // if (gameEntity?.OwnerId != _userId)
            //     return false;

            gameEntity.Title = request.Title;
            // gameEntity.GameGenre = request.GameGenre;
            // gameEntity.GameSystem = request.GameSystem;

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }
    }
}