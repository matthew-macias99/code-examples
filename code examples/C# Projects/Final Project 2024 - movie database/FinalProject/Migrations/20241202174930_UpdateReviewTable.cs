using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReviewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Review");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Review",
                nullable: false,
                oldClrType: typeof(float));


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Review",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Review",
                nullable: true);
            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Review",
                nullable: false,
                oldClrType: typeof(double));

        }
    }
}
