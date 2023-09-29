using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroesApp.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlterEgo",
                table: "SuperHeroes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CatchPhrase",
                table: "SuperHeroes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SuperHeroes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryAbility",
                table: "SuperHeroes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryAbility",
                table: "SuperHeroes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlterEgo",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "CatchPhrase",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "PrimaryAbility",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "SecondaryAbility",
                table: "SuperHeroes");
        }
    }
}
