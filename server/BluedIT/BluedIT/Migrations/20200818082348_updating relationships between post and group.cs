using Microsoft.EntityFrameworkCore.Migrations;

namespace BluedIT.Migrations
{
    public partial class updatingrelationshipsbetweenpostandgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Groups",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_PostId",
                table: "Groups",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Posts_PostId",
                table: "Groups",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Posts_PostId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_PostId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Groups");
        }
    }
}
