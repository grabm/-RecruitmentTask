using CodeReviewTask.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeReviewTask.Database.Contexts
{
    public class CodeReviewTaskContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=users.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Name);
            });
        }
    }
}