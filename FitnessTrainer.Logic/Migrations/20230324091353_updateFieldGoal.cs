using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class updateFieldGoal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubGoal_CategoryOfBody_CategoryOfBodyCode",
                table: "SubGoal");

            migrationBuilder.DropIndex(
                name: "IX_SubGoal_CategoryOfBodyCode",
                table: "SubGoal");

            migrationBuilder.DropColumn(
                name: "CategoryOfBodyCode",
                table: "SubGoal");

            migrationBuilder.AddColumn<string>(
                name: "BodyCode",
                table: "SubGoal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SubGoal_BodyCode",
                table: "SubGoal",
                column: "BodyCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SubGoal_CategoryOfBody_BodyCode",
                table: "SubGoal",
                column: "BodyCode",
                principalTable: "CategoryOfBody",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubGoal_CategoryOfBody_BodyCode",
                table: "SubGoal");

            migrationBuilder.DropIndex(
                name: "IX_SubGoal_BodyCode",
                table: "SubGoal");

            migrationBuilder.DropColumn(
                name: "BodyCode",
                table: "SubGoal");

            migrationBuilder.AddColumn<string>(
                name: "CategoryOfBodyCode",
                table: "SubGoal",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubGoal_CategoryOfBodyCode",
                table: "SubGoal",
                column: "CategoryOfBodyCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SubGoal_CategoryOfBody_CategoryOfBodyCode",
                table: "SubGoal",
                column: "CategoryOfBodyCode",
                principalTable: "CategoryOfBody",
                principalColumn: "Code");
        }
    }
}
