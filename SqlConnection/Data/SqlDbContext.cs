using Microsoft.EntityFrameworkCore;
using SqlWebApi.Models;
using System.Security.Cryptography.X509Certificates;

namespace SqlWebApi.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }    
        public DbSet<MyEntity> MyEntities { get; set; } 
        
    }
    }
