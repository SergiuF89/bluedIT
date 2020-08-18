using BluedIT.Models;
using Microsoft.EntityFrameworkCore;

namespace BluedIT.Data
{
  public class Context : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<GroupCategory> GroupCategories { get; set; }
        public DbSet<Category> Categories { get; set; }

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

        modelBuilder.Entity<User>()
            .HasMany(u => u.Posts)
            .WithOne(p => p.User);

        modelBuilder.Entity<Post>()
            .HasMany(p => p.Groups)
            .WithOne(g => g.Post);

            modelBuilder.Entity<GroupCategory>()
        .HasKey(gc => new { gc.GroupId, gc.CategoryId });
        modelBuilder.Entity<GroupCategory>()
            .HasOne(gc => gc.Group)
            .WithMany(g => g.GroupCategories)
            .HasForeignKey(gc => gc.GroupId);
        modelBuilder.Entity<GroupCategory>()
            .HasOne(gc => gc.Category)
            .WithMany(c => c.GroupCategories)
            .HasForeignKey(gc => gc.CategoryId);

            modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            UserName = "Admin",
            Password = "root",
            DateOfBirth = "21-12-1989",
            JoinedOn = "17-08-2020",
            UserClass = "Administrator"
        });


        }
  }
}
