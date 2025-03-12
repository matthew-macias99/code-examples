using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewerNameFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Review");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_MovieId",
                table: "Review",
                newName: "IX_Review_MovieId");

            migrationBuilder.AddColumn<string>(
                name: "ReviewerName",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Movies_MovieId",
                table: "Review",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movies_MovieId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "ReviewerName",
                table: "Review");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_Review_MovieId",
                table: "Review",
                newName: "IX_Reviews_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Review",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Review",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
