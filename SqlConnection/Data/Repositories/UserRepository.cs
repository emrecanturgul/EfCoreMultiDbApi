using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{
    public class UserRepository : GenericRepository<User> 
    {
        public UserRepository(SqlDbContext context) : base(context) 
        { 
        
        }
    }
}
