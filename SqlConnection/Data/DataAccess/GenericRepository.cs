using Microsoft.EntityFrameworkCore;
using SqlWebApi.Models;
using System.Linq;

namespace SqlWebApi.Data.DataAccess
{
    public interface IRepository<T> where T : class, IEntity , new()
    {    

        Task AddAsync(T Entity);
        Task<T?> GetAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity); 

    }
    public class GenericRepository<T> : IRepository<T> where T : class , IEntity , new()
    {
        private readonly SqlDbContext _context;
        private readonly DbSet<T> _table; 
        public GenericRepository(SqlDbContext context)
        {
            _context = context;
            _table = _context.Set<T>(); 
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity); 
            await _context.SaveChangesAsync(); 
            
        }
        public async Task<T?> GetAsync(Guid id)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
            
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task UpdateAsync(T entity) 
        {
            _context.Set<T>().Update(entity);
             await _context.SaveChangesAsync(); 
        }
        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity); 
            await _context.SaveChangesAsync(); 
        }
    }
}
