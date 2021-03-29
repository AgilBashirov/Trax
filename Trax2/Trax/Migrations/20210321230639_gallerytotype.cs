using Microsoft.EntityFrameworkCore.Migrations;

namespace Trax.Migrations
{
    public partial class gallerytotype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_GalleryTypes_GalleryTypeId",
                table: "Galleries");

            migrationBuilder.DropIndex(
                name: "IX_Galleries_GalleryTypeId",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "GalleryTypeId",
                table: "Galleries");

            migrationBuilder.CreateTable(
                name: "GalleryToType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryTypeId = table.Column<int>(type: "int", nullable: false),
                    GalleryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryToType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryToType_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleryToType_GalleryTypes_GalleryTypeId",
                        column: x => x.GalleryTypeId,
                        principalTable: "GalleryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryToType_GalleryId",
                table: "GalleryToType",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryToType_GalleryTypeId",
                table: "GalleryToType",
                column: "GalleryTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryToType");

            migrationBuilder.AddColumn<int>(
                name: "GalleryTypeId",
                table: "Galleries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_GalleryTypeId",
                table: "Galleries",
                column: "GalleryTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_GalleryTypes_GalleryTypeId",
                table: "Galleries",
                column: "GalleryTypeId",
                principalTable: "GalleryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
