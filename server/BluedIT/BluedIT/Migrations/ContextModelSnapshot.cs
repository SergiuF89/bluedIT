﻿// <auto-generated />
using BluedIT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BluedIT.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BluedIT.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostedOn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BluedIT.Models.Group", b =>
                {
                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupName");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupName = "Fortnite",
                            GroupCategory = "Gaming",
                            GroupDescription = "The developer supported, community-run subreddit dedicated to the Fortnite: Battle Royale game mode by Epic Games. Tailored for those who want to keep up to date on the pro scene, tournaments, competitive plays and figure out new tips/tricks on how to play the current meta."
                        },
                        new
                        {
                            GroupName = "RocketLeague",
                            GroupCategory = "Gaming",
                            GroupDescription = "Rocket-powered cars meet soccer in Psyonix's success title Rocket League. Join the community for Rocket League news, discussion, highlights and more!"
                        },
                        new
                        {
                            GroupName = "MTB",
                            GroupCategory = "Sports",
                            GroupDescription = "A cycling community enthusiastic about mountain biking and all things related."
                        },
                        new
                        {
                            GroupName = "Vegan",
                            GroupCategory = "Health & Fitness",
                            GroupDescription = "This is a place for people who are vegans or interested in veganism to share links, ideas, or recipes. "
                        });
                });

            modelBuilder.Entity("BluedIT.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupName");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BluedIT.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JoinedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserClass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = "21-12-1989",
                            JoinedOn = "17-08-2020",
                            Name = "Admin",
                            Password = "root",
                            UserClass = "Administrator"
                        });
                });

            modelBuilder.Entity("BluedIT.Models.Post", b =>
                {
                    b.HasOne("BluedIT.Models.Group", "Group")
                        .WithMany("Posts")
                        .HasForeignKey("GroupName");
                });
#pragma warning restore 612, 618
        }
    }
}
