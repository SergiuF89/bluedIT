using Microsoft.EntityFrameworkCore.Migrations;

namespace BluedIT.Migrations
{
    public partial class EditedUserclassaddedmorecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JoinedOn",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserClass",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JoinedOn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserClass",
                table: "Users");
        }
    }
}
