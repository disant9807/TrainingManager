using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class fixExerciseToTrainingProgramDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_TrainingProgramDay_TrainingProgramDayId",
                table: "Exercise");

            migrationBuilder.DropIndex(
                name: "IX_Exercise_TrainingProgramDayId",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "TrainingProgramDayId",
                table: "Exercise");

            migrationBuilder.CreateTable(
                name: "ExerciseTrainingProgramDay",
                columns: table => new
                {
                    ExercisesId = table.Column<long>(type: "INTEGER", nullable: false),
                    TrainingProgramDaysId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTrainingProgramDay", x => new { x.ExercisesId, x.TrainingProgramDaysId });
                    table.ForeignKey(
                        name: "FK_ExerciseTrainingProgramDay_Exercise_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseTrainingProgramDay_TrainingProgramDay_TrainingProgramDaysId",
                        column: x => x.TrainingProgramDaysId,
                        principalTable: "TrainingProgramDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTrainingProgramDay_TrainingProgramDaysId",
                table: "ExerciseTrainingProgramDay",
                column: "TrainingProgramDaysId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseTrainingProgramDay");

            migrationBuilder.AddColumn<Guid>(
                name: "TrainingProgramDayId",
                table: "Exercise",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_TrainingProgramDayId",
                table: "Exercise",
                column: "TrainingProgramDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_TrainingProgramDay_TrainingProgramDayId",
                table: "Exercise",
                column: "TrainingProgramDayId",
                principalTable: "TrainingProgramDay",
                principalColumn: "Id");
        }
    }
}
