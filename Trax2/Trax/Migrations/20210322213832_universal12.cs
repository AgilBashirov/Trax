using Microsoft.EntityFrameworkCore.Migrations;

namespace Trax.Migrations
{
    public partial class universal12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UpTitle",
                table: "Universal",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpTitle",
                table: "Universal");
        }
    }
}
