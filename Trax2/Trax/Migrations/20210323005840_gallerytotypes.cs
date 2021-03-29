using Microsoft.EntityFrameworkCore.Migrations;

namespace Trax.Migrations
{
    public partial class gallerytotypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GalleryToType_Galleries_GalleryId",
                table: "GalleryToType");

            migrationBuilder.DropForeignKey(
                name: "FK_GalleryToType_GalleryTypes_GalleryTypeId",
                table: "GalleryToType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GalleryToType",
                table: "GalleryToType");

            migrationBuilder.RenameTable(
                name: "GalleryToType",
                newName: "GalleryToTypes");

            migrationBuilder.RenameIndex(
                name: "IX_GalleryToType_GalleryTypeId",
                table: "GalleryToTypes",
                newName: "IX_GalleryToTypes_GalleryTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_GalleryToType_GalleryId",
                table: "GalleryToTypes",
                newName: "IX_GalleryToTypes_GalleryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GalleryToTypes",
                table: "GalleryToTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryToTypes_Galleries_GalleryId",
                table: "GalleryToTypes",
                column: "GalleryId",
                principalTable: "Galleries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryToTypes_GalleryTypes_GalleryTypeId",
                table: "GalleryToTypes",
                column: "GalleryTypeId",
                principalTable: "GalleryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GalleryToTypes_Galleries_GalleryId",
                table: "GalleryToTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GalleryToTypes_GalleryTypes_GalleryTypeId",
                table: "GalleryToTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GalleryToTypes",
                table: "GalleryToTypes");

            migrationBuilder.RenameTable(
                name: "GalleryToTypes",
                newName: "GalleryToType");

            migrationBuilder.RenameIndex(
                name: "IX_GalleryToTypes_GalleryTypeId",
                table: "GalleryToType",
                newName: "IX_GalleryToType_GalleryTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_GalleryToTypes_GalleryId",
                table: "GalleryToType",
                newName: "IX_GalleryToType_GalleryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GalleryToType",
                table: "GalleryToType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryToType_Galleries_GalleryId",
                table: "GalleryToType",
                column: "GalleryId",
                principalTable: "Galleries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryToType_GalleryTypes_GalleryTypeId",
                table: "GalleryToType",
                column: "GalleryTypeId",
                principalTable: "GalleryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
