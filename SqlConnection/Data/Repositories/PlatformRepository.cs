using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{     
    public interface IPlatformRepository : IRepository<Platform>
    {
    }
    public class PlatformRepository : GenericRepository<Platform>, IPlatformRepository
    {
        public PlatformRepository(SqlDbContext context) : base(context) 
        {

        }
    }
}
