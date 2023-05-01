using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    /// <inheritdoc />
    public partial class AddFkTrainingProgramDayFromTraining : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramIdFK",
                table: "Training");

            migrationBuilder.AlterColumn<long>(
                name: "TrainingProgramIdFK",
                table: "Training",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<Guid>(
                name: "TrainingProgramDayFK",
                table: "Training",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Training_TrainingProgramDayFK",
                table: "Training",
                column: "TrainingProgramDayFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_TrainingProgramDay_TrainingProgramDayFK",
                table: "Training",
                column: "TrainingProgramDayFK",
                principalTable: "TrainingProgramDay",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramIdFK",
                table: "Training",
                column: "TrainingProgramIdFK",
                principalTable: "TrainingProgram",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_TrainingProgramDay_TrainingProgramDayFK",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramIdFK",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_TrainingProgramDayFK",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "TrainingProgramDayFK",
                table: "Training");

            migrationBuilder.AlterColumn<long>(
                name: "TrainingProgramIdFK",
                table: "Training",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_TrainingProgram_TrainingProgramIdFK",
                table: "Training",
                column: "TrainingProgramIdFK",
                principalTable: "TrainingProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
