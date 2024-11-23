using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{
    public class CompanyRepository : GenericRepository<Company>
    {
        public CompanyRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
