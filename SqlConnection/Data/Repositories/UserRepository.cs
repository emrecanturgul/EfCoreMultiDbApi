using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
    }
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SqlDbContext context) : base(context) 
        { 
        
        }
    }
}
