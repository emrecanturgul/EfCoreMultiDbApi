using Microsoft.EntityFrameworkCore;
using SqlWebApi.Models;
using System.Security.Cryptography.X509Certificates;

namespace SqlWebApi.Data
{
    public class SqlDbContext : DbContext
    {
        
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }    
        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; } 
        public DbSet<Comment> Comments { get; set; } 
        public DbSet<Platform> Platforms { get; set; } 
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().Property(g=>g.ReleaseDate).IsRequired();
            modelBuilder.Entity<Game>().Property(g=>g.PlayMode).IsRequired();
            modelBuilder.Entity<Game>().HasMany(g => g.Platforms).
                WithMany(p => p.Games).UsingEntity(j => j.ToTable("GamePlatforms"));

            modelBuilder.Entity<Game>().HasOne(g=>g.Company).WithMany(c=>c.Games).HasForeignKey(g=>g.CompanyId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Comment>().HasOne(r => r.User).WithMany(u => u.Comments).HasForeignKey(r => r.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Comment>().HasOne(c => c.Game).WithMany(g => g.Comments).HasForeignKey(r => r.GameId).OnDelete(DeleteBehavior.Cascade);  

        }


    }
    }
