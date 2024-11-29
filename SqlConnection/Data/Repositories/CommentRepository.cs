using SqlWebApi.Data.DataAccess;
using SqlWebApi.Models;

namespace SqlWebApi.Data.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
    }
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
