using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class FixFkGoal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubGoal_Goal_PurposeId",
                table: "SubGoal");

            migrationBuilder.RenameColumn(
                name: "PurposeId",
                table: "SubGoal",
                newName: "GoalId");

            migrationBuilder.RenameIndex(
                name: "IX_SubGoal_PurposeId",
                table: "SubGoal",
                newName: "IX_SubGoal_GoalId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubGoal_Goal_GoalId",
                table: "SubGoal",
                column: "GoalId",
                principalTable: "Goal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubGoal_Goal_GoalId",
                table: "SubGoal");

            migrationBuilder.RenameColumn(
                name: "GoalId",
                table: "SubGoal",
                newName: "PurposeId");

            migrationBuilder.RenameIndex(
                name: "IX_SubGoal_GoalId",
                table: "SubGoal",
                newName: "IX_SubGoal_PurposeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubGoal_Goal_PurposeId",
                table: "SubGoal",
                column: "PurposeId",
                principalTable: "Goal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
