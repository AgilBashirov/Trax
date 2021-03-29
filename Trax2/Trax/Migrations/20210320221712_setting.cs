using Microsoft.EntityFrameworkCore.Migrations;

namespace Trax.Migrations
{
    public partial class setting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadEmail",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "HeadPhone",
                table: "Settings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HeadEmail",
                table: "Settings",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadPhone",
                table: "Settings",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
