using Microsoft.EntityFrameworkCore;
using MinimalApiService.Data.Models;

namespace MinimalApiService.Data
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext() 
        {
            Database.EnsureCreated();
        }

        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Database.db");
        }
    }
}
