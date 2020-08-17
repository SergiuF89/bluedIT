using Microsoft.EntityFrameworkCore.Migrations;

namespace BluedIT.Migrations
{
    public partial class madechangestopostandgroupmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_GroupName",
                table: "Posts",
                column: "GroupName");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Groups_GroupName",
                table: "Posts",
                column: "GroupName",
                principalTable: "Groups",
                principalColumn: "GroupName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Groups_GroupName",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_GroupName",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "Posts");
        }
    }
}
