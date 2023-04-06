using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class AddCategoryOfBodyNewExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryOfBody_Exercise_ExerciseId",
                table: "CategoryOfBody");

            migrationBuilder.DropIndex(
                name: "IX_CategoryOfBody_ExerciseId",
                table: "CategoryOfBody");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "CategoryOfBody");

            migrationBuilder.CreateTable(
                name: "CategoryOfBodyExercise",
                columns: table => new
                {
                    CategoryOfBodiesCode = table.Column<string>(type: "TEXT", nullable: false),
                    ExerciseId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryOfBodyExercise", x => new { x.CategoryOfBodiesCode, x.ExerciseId });
                    table.ForeignKey(
                        name: "FK_CategoryOfBodyExercise_CategoryOfBody_CategoryOfBodiesCode",
                        column: x => x.CategoryOfBodiesCode,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryOfBodyExercise_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOfBodyExercise_ExerciseId",
                table: "CategoryOfBodyExercise",
                column: "ExerciseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryOfBodyExercise");

            migrationBuilder.AddColumn<long>(
                name: "ExerciseId",
                table: "CategoryOfBody",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOfBody_ExerciseId",
                table: "CategoryOfBody",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryOfBody_Exercise_ExerciseId",
                table: "CategoryOfBody",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id");
        }
    }
}
