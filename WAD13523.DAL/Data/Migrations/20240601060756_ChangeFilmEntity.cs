using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WAD13523.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFilmEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Films");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Films",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
