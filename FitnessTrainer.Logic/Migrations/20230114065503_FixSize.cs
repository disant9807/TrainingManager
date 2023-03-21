using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class FixSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeItem_CategoryOfBody_BodyCode",
                table: "SizeItem");

            migrationBuilder.AlterColumn<string>(
                name: "BodyCode",
                table: "SizeItem",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeItem_CategoryOfBody_BodyCode",
                table: "SizeItem",
                column: "BodyCode",
                principalTable: "CategoryOfBody",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeItem_CategoryOfBody_BodyCode",
                table: "SizeItem");

            migrationBuilder.AlterColumn<string>(
                name: "BodyCode",
                table: "SizeItem",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeItem_CategoryOfBody_BodyCode",
                table: "SizeItem",
                column: "BodyCode",
                principalTable: "CategoryOfBody",
                principalColumn: "Code");
        }
    }
}
