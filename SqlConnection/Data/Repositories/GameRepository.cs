using Microsoft.EntityFrameworkCore;
using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{
    public interface IGameRepository : IRepository<Game>
    {
    }
    public class GameRepository :  GenericRepository<Game>, IGameRepository
    {
        private readonly List<string> _saledGames; 

        public GameRepository(SqlDbContext context) : base(context)
        {
            _saledGames = new List<string>
            {
                "fifa","pes","fm25"
            };
        }
        public async Task<IEnumerable<Game>> IsSaledGameAsync()
        {
            return await _table.Where(game => _saledGames.Contains(game.GameName)).ToListAsync();  
        }
        //Game specific methods

    }
}
