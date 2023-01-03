using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using AgileProject.Data;
using AgileProject.Data.Entities;
using AgileProject.Models.GameSystemModels;
using AgileProject.Services.GameSystems;

namespace AgileProject.Services.GameSystem
{
    public class GameSystems : IGameSystems
    {
        private readonly ApplicationDbContext _dbContext;
        public GameSystems(IHttpContextAccessor httpContextAccessor, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateGameSystemsAsync(GameSystemCreate request)
        {
            var GameSystemEntity = new GameSystemEntity
            {
                SystemName = request.SystemName
            };

            _dbContext.GameSystems.Add(GameSystemEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;

            throw new NotImplementedException();
        }

        public async Task<bool> DeleteGameSystemAsync(int GameSystemId)
        {
            var GameSystemEntity = await _dbContext.GameSystems.FindAsync(GameSystemId);

            if (GameSystemEntity?.GameSystemId != 1)
                return false;

            _dbContext.GameSystems.Remove(GameSystemEntity);
            return await _dbContext.SaveChangesAsync() == 1;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GameSystemListItem>> GetAllGameSystemsAsync()
        {
            var gameSystems = await _dbContext.GameSystems
            .Select(entity => new GameSystemListItem
            {
                SystemName = entity.SystemName,
            })
            .ToListAsync();

            throw new NotImplementedException();
        }

        public async Task<bool> UpdateGameSystemAsync(GameSystemUpdate request)
        {
            var GameSystemEntity = await _dbContext.GameSystems.FindAsync(request.Id);

            GameSystemEntity.SystemName = request.SystemName;

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            throw new NotImplementedException();
        }
    }
}