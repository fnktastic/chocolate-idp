using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chocolate.Domain.Dal.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "choco");

            migrationBuilder.CreateTable(
                name: "ChocolateEntities",
                schema: "choco",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    CountryOrigin = table.Column<string>(nullable: true),
                    SugarVolume = table.Column<float>(nullable: false),
                    CocoaVolume = table.Column<float>(nullable: false),
                    Calories = table.Column<float>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChocolateEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChocolateEntities",
                schema: "choco");
        }
    }
}
