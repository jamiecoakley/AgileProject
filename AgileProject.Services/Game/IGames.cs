using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileProject.Models.GameViewModels;

namespace AgileProject.Services.Game
{
    public interface IGames
    {
        Task<bool> CreateGameAsync(GameCreate request);
        Task<IEnumerable<GameListItem>> GetAllGamesAsync();
        Task<bool> UpdateGameAsync(GameUpdate request);
    }
}