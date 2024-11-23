using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
