using BluedIT.Models;
using Microsoft.EntityFrameworkCore;

namespace BluedIT.Data
{
  public class Context : DbContext {
        public DbSet<User> Users { get; set; }
    
  
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(Constant.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable(Constant.Tables.Users);
        modelBuilder.Entity<Groups>().ToTable(Constant.Tables.Groups);
        modelBuilder.Entity<Comment>().ToTable(Constant.Tables.Comments);
        modelBuilder.Entity<Post>().ToTable(Constant.Tables.Posts);



        }
    }
}
