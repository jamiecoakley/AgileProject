using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using AgileProject.Data;
using AgileProject.Data.Entities;
using AgileProject.Models;
using AgileProject.Models.GameSystemModels;
using AgileProject.Services.GameSystems;

namespace AgileProject.Services.GameSystem
{
    public class GameSystems : IGameSystems
    {
        private readonly ApplicationDbContext _dbContext;
        public GameSystems(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateGameSystemAsync(GameSystemCreate request)
        {
            var GameSystemEntity = new GameSystemEntity
            {
                SystemName = request.SystemName
            };

        _dbContext.GameSystems.Add(GameSystemEntity);

        var numberOfChanges = await _dbContext.SaveChangesAsync();
        return numberOfChanges == 1;
        }

        // public async Task<IEnumerable<GameSystemListItem>> GetAllGameSystemsAsync()
        // {
        //     var gameSystems = await _dbContext.GameSystems
        //         .Where(entity => entity.Id == 1)
        //         .Select(entity => new GameSystemListItem)
        //         {
                    
        //         }
        //         .ToListAsync();
            
        //     return GameSystems;
        // }
    }
}