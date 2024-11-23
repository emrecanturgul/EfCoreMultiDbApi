using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{
    public class PlatformRepository : GenericRepository<Platform>
    {
        public PlatformRepository(SqlDbContext context) : base(context) 
        {

        }
    }
}
