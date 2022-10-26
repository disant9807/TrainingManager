using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class addNewFieldsAndFixTrainingAproach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Approach_Exercise_ExerciseId",
                table: "Approach");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramId",
                table: "Training");

            migrationBuilder.AlterColumn<long>(
                name: "TrainingProgramId",
                table: "Training",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<long>(
                name: "ExerciseId",
                table: "Approach",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Approach_Exercise_ExerciseId",
                table: "Approach",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramId",
                table: "Training",
                column: "TrainingProgramId",
                principalTable: "TrainingProgram",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Approach_Exercise_ExerciseId",
                table: "Approach");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramId",
                table: "Training");

            migrationBuilder.AlterColumn<long>(
                name: "TrainingProgramId",
                table: "Training",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ExerciseId",
                table: "Approach",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Approach_Exercise_ExerciseId",
                table: "Approach",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramId",
                table: "Training",
                column: "TrainingProgramId",
                principalTable: "TrainingProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
