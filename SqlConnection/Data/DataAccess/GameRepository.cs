using SqlWebApi.Models;
using System.Linq;

namespace SqlWebApi.Data.DataAccess
{
    public class GameRepository
    {
        private readonly SqlDbContext _context;
        public GameRepository(SqlDbContext context)
        {
            _context = context;
        }
        public void AddGame(Game game)
        {
            _context.Games.Add(game); 
            _context.SaveChanges(); 
        }
        public Game GetGameById(int id)
        {
            return _context.Games.FirstOrDefault(g => g.GameId == id); 
        }
        public List<Game> GetAll()
        {
            return _context.Games.ToList();
        }
        public void UpdateGame(Game game)
        {
            _context.Games.Update(game);
            _context.SaveChanges(); 
        }
        public void DeleteGame(int id)
        {
            Game DeletedGame = _context.Games.FirstOrDefault(g => g.GameId == id); 
            _context.Games.Remove(DeletedGame); 
            _context.SaveChanges(); 
        }
    }
}
