using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
            //this.Database.Migrate();
        }
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().ToTable("Values");
            modelBuilder.Entity<Value>().HasData(
                new Value() { Id = 1, Title = "Title 1", Name = "Value-1" },
                new Value() { Id = 2, Title = "Title 2", Name = "Value-2" },
                new Value() { Id = 3, Title = "Title 3", Name = "Value-3" },
                new Value() { Id = 4, Title = "Title 4", Name = "Value-4" }
           );
        }
    }
}
