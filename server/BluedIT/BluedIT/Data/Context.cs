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

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Admin",
                Password = "root",
                DateOfBirth = "21-12-1989",
                JoinedOn = "17-08-2020",
                UserClass = "Administrator"
            });

            modelBuilder.Entity<Group>().HasData(new Group
            {
                GroupName = "Fortnite",
                GroupCategory = "Gaming",
                GroupDescription = "The developer supported, community-run subreddit dedicated " +
                "to the Fortnite: Battle Royale game mode by Epic Games. Tailored for those who want " +
                "to keep up to date on the pro scene, tournaments, competitive plays and figure out new " +
                "tips/tricks on how to play the current meta."
            });

            modelBuilder.Entity<Group>().HasData(new Group
            {
                GroupName = "RocketLeague",
                GroupCategory = "Gaming",
                GroupDescription = "Rocket-powered cars meet soccer in Psyonix's success title Rocket League. " +
                "Join the community for Rocket League news, discussion, highlights and more!"
            });

            modelBuilder.Entity<Group>().HasData(new Group
            {
                GroupName = "MTB",
                GroupCategory = "Sports",
                GroupDescription = "A cycling community enthusiastic about mountain " +
                "biking and all things related."
            });

            modelBuilder.Entity<Group>().HasData(new Group
            {
                GroupName = "Vegan",
                GroupCategory = "Health & Fitness",
                GroupDescription = "This is a place for people who are vegans " +
                "or interested in veganism to share links, ideas, or recipes. "
            });

        }
  }
}
