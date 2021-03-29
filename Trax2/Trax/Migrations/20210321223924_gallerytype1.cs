using Microsoft.EntityFrameworkCore.Migrations;

namespace Trax.Migrations
{
    public partial class gallerytype1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_GallaryTypes_GalleryTypeId",
                table: "Galleries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GallaryTypes",
                table: "GallaryTypes");

            migrationBuilder.RenameTable(
                name: "GallaryTypes",
                newName: "GalleryTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GalleryTypes",
                table: "GalleryTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_GalleryTypes_GalleryTypeId",
                table: "Galleries",
                column: "GalleryTypeId",
                principalTable: "GalleryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_GalleryTypes_GalleryTypeId",
                table: "Galleries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GalleryTypes",
                table: "GalleryTypes");

            migrationBuilder.RenameTable(
                name: "GalleryTypes",
                newName: "GallaryTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GallaryTypes",
                table: "GallaryTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_GallaryTypes_GalleryTypeId",
                table: "Galleries",
                column: "GalleryTypeId",
                principalTable: "GallaryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
