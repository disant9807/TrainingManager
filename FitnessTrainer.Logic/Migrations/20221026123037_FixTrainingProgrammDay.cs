using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class FixTrainingProgrammDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgramDay_Exercise_ExercisesId",
                table: "TrainingProgramDay");

            migrationBuilder.DropIndex(
                name: "IX_TrainingProgramDay_ExercisesId",
                table: "TrainingProgramDay");

            migrationBuilder.DropColumn(
                name: "ExercisesId",
                table: "TrainingProgramDay");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<long>(
                name: "ExercisesId",
                table: "TrainingProgramDay",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramDay_ExercisesId",
                table: "TrainingProgramDay",
                column: "ExercisesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingProgramDay_Exercise_ExercisesId",
                table: "TrainingProgramDay",
                column: "ExercisesId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
