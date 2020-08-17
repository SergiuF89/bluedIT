using Microsoft.EntityFrameworkCore.Migrations;

namespace BluedIT.Migrations
{
    public partial class AddeddefaultGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupName", "GroupCategory", "GroupDescription" },
                values: new object[,]
                {
                    { "Fortnite", "Gaming", "The developer supported, community-run subreddit dedicated to the Fortnite: Battle Royale game mode by Epic Games. Tailored for those who want to keep up to date on the pro scene, tournaments, competitive plays and figure out new tips/tricks on how to play the current meta." },
                    { "RocketLeague", "Gaming", "Rocket-powered cars meet soccer in Psyonix's success title Rocket League. Join the community for Rocket League news, discussion, highlights and more!" },
                    { "MTB", "Sports", "A cycling community enthusiastic about mountain biking and all things related." },
                    { "Vegan", "Health & Fitness", "This is a place for people who are vegans or interested in veganism to share links, ideas, or recipes. " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupName",
                keyValue: "Fortnite");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupName",
                keyValue: "MTB");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupName",
                keyValue: "RocketLeague");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupName",
                keyValue: "Vegan");
        }
    }
}
