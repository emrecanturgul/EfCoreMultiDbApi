using Microsoft.EntityFrameworkCore;
using Postgre_Sql_Connection.Models;

namespace Postgre_Sql_Connection.Data
{
    public class PostgreDbContext : DbContext
    {
        public PostgreDbContext(DbContextOptions<PostgreDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Product>  Products{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
        }
    }
}
