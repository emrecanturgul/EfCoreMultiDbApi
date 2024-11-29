using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
    }
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
