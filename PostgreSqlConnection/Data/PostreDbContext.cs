using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PostgreSqlWebAPI.Models;

namespace PostgreSqlConnection.EfCore
{
    public class PostreDbContext :DbContext
    { 
        public PostreDbContext(DbContextOptions<PostreDbContext> options) : base(options) { }


        
        public DbSet<Product> Products { get; set; } 
    }
}
