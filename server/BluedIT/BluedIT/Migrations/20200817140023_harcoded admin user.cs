using Microsoft.EntityFrameworkCore.Migrations;

namespace BluedIT.Migrations
{
    public partial class harcodedadminuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "JoinedOn", "Name", "Password", "UserClass" },
                values: new object[] { 1, "21-12-1989", "17-08-2020", "Admin", "root", "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
