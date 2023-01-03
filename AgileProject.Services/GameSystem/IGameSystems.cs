using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileProject.Models.GameSystemModels;
using AgileProject.Models;

namespace AgileProject.Services.GameSystems
{
    public interface IGameSystems
    {
        Task<bool> CreateGameSystemsAsync(GameSystemCreate request);
        Task<IEnumerable<GameSystemListItem>> GetAllGameSystemsAsync();
        Task<bool> UpdateGameSystemAsync(GameSystemUpdate request);
        Task<bool> DeleteGameSystemAsync (int GameSystemId);
    }
}