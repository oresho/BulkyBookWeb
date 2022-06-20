using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BulkyBookWeb
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(b => b.CreatedDateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }

        public override EntityEntry Update(object entity)
        {
            return base.Update(entity);
        }

        public ApplicationDbContext(DbContextOptions options)
                : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}