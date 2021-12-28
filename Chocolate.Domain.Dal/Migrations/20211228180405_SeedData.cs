using Microsoft.EntityFrameworkCore.Migrations;

namespace Chocolate.Domain.Dal.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
  INSERT INTO [choco].[ChocolateEntities]
  VALUES 
	('20d098a3-505f-4321-898d-977b4bb2910d', 'Toblerone White', 'Mondolez', 1, 'CH', 9.2, 35.5, 270, '668f285c-e817-4262-9503-d9e96c776496'),
    ('d99c85f5-3f4a-4f72-bf27-bfe8d27c18d8', 'Toblerone Milk', 'Mondolez', 1, 'CH', 7.4, 29.9, 215, '4771c9a1-6f8e-4104-ba89-105c43b511c1'),
	('1cc0a940-996b-46b0-a2e5-c4f3963ea141', 'Alenka', 'Roshen', 0, 'UA', 8.0, 20.8, 198, '668f285c-e817-4262-9503-d9e96c776496');
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
  DELETE FROM [choco].[ChocolateEntities]
  WHERE Id = 'd99c85f5-3f4a-4f72-bf27-bfe8d27c18d8' OR Id = '1cc0a940-996b-46b0-a2e5-c4f3963ea141' OR Id = '20d098a3-505f-4321-898d-977b4bb2910d'
");
        }
    }
}
