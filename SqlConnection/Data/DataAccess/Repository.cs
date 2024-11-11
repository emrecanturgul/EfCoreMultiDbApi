using Microsoft.EntityFrameworkCore;
using SqlWebApi.Models;
using System.Linq;

namespace SqlWebApi.Data.DataAccess
{
    public interface IRepository
    {
        Task AsyncAddGame(Game game);
        Task<Game> GetGameByIdAsync(int id);
        Task<List<Game>> GetAllAsync();
        Task UpdateGameAsync(Game game);
        Task DeleteGameAsync(int id); 

    }
    public class Repository
    {
        private readonly SqlDbContext _context;
        public Repository(SqlDbContext context)
        {
            _context = context;
        }
        public async Task AsyncAddGame(Game game)
        {
            await _context.Games.AddAsync(game); 
            await _context.SaveChangesAsync(); 
        }
        public async Task<Game> GetGameByIdAsync(int id)
        {
            return await _context.Games.FirstOrDefaultAsync(g => g.GameId == id); 
        }
        public async Task<List<Game>> GetAllAsync()
        {
            return await _context.Games.ToListAsync();
        }
        public async Task UpdateGameAsync(Game game)
        {
            _context.Games.Update(game);
             await _context.SaveChangesAsync(); 
        }
        public async Task DeleteGameAsync(int id)
        {
            Game DeletedGame = await _context.Games.FirstOrDefaultAsync(g => g.GameId == id); 
            _context.Games.Remove(DeletedGame); 
            _context.SaveChanges(); 
        }
    }
}
