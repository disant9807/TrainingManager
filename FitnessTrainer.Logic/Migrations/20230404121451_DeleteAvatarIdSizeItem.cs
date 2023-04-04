using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class DeleteAvatarIdSizeItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeItem_Image_AvatarId",
                table: "SizeItem");

            migrationBuilder.DropIndex(
                name: "IX_SizeItem_AvatarId",
                table: "SizeItem");

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "SizeItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AvatarId",
                table: "SizeItem",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SizeItem_AvatarId",
                table: "SizeItem",
                column: "AvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeItem_Image_AvatarId",
                table: "SizeItem",
                column: "AvatarId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
