using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    /// <inheritdoc />
    public partial class AddFkTrainingProgramFromTraining : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_TrainingProgramId",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "TrainingProgramId",
                table: "Training");

            migrationBuilder.AddColumn<long>(
                name: "TrainingProgramIdFK",
                table: "Training",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Training_TrainingProgramIdFK",
                table: "Training",
                column: "TrainingProgramIdFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramIdFK",
                table: "Training",
                column: "TrainingProgramIdFK",
                principalTable: "TrainingProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramIdFK",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_TrainingProgramIdFK",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "TrainingProgramIdFK",
                table: "Training");

            migrationBuilder.AddColumn<long>(
                name: "TrainingProgramId",
                table: "Training",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Training_TrainingProgramId",
                table: "Training",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramId",
                table: "Training",
                column: "TrainingProgramId",
                principalTable: "TrainingProgram",
                principalColumn: "Id");
        }
    }
}
