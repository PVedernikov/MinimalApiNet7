using Microsoft.EntityFrameworkCore;
using MinimalApiService.Data.Models;

namespace MinimalApiService.Data
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext() { }

        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options) { }

        DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Database.db");
        }
    }
}
