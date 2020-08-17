using BluedIT.Models;
using Microsoft.EntityFrameworkCore;

namespace BluedIT.Data
{
  public class Context : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
  
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(Constant.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable(Constant.Tables.Users);
        modelBuilder.Entity<Group>().ToTable(Constant.Tables.Groups);
        modelBuilder.Entity<Post>().ToTable(Constant.Tables.Posts);
        modelBuilder.Entity<Comment>().ToTable(Constant.Tables.Comments);

        }
    }
}
