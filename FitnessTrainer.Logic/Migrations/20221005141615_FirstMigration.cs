using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Approach",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Time = table.Column<long>(type: "INTEGER", nullable: false),
                    NumberOfTraining = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    ExerciseId = table.Column<long>(type: "INTEGER", nullable: false),
                    Hard = table.Column<int>(type: "INTEGER", nullable: false),
                    Technicality = table.Column<int>(type: "INTEGER", nullable: false),
                    TrainingId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approach", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryOfBody",
                columns: table => new
                {
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortName = table.Column<string>(type: "TEXT", nullable: false),
                    Decsription = table.Column<string>(type: "TEXT", nullable: false),
                    AvatarId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ExerciseId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryOfBody", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortName = table.Column<string>(type: "TEXT", nullable: false),
                    IsBased = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AvatarId = table.Column<Guid>(type: "TEXT", nullable: true),
                    HardSkill = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ExerciseId = table.Column<long>(type: "INTEGER", nullable: true),
                    TrainingProgramId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgram",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortName = table.Column<string>(type: "TEXT", nullable: false),
                    AvatarId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgram_Image_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Image",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<long>(type: "INTEGER", nullable: false),
                    TrainingProgramId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Training_TrainingProgram_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramDay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExercisesId = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DayRelax = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfTrainingProgram = table.Column<int>(type: "INTEGER", nullable: false),
                    TrainingProgramId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramDay_Exercise_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingProgramDay_TrainingProgram_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "ExerciseId", "Name", "ShortName" },
                values: new object[] { "Back", null, "Спина", null, "Спина", "Спина" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "ExerciseId", "Name", "ShortName" },
                values: new object[] { "Chest", null, "Грудь", null, "Грудь", "Грудь" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "ExerciseId", "Name", "ShortName" },
                values: new object[] { "legs", null, "Ноги", null, "Ноги", "Ноги" });

            migrationBuilder.CreateIndex(
                name: "IX_Approach_ExerciseId",
                table: "Approach",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Approach_TrainingId",
                table: "Approach",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOfBody_AvatarId",
                table: "CategoryOfBody",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOfBody_ExerciseId",
                table: "CategoryOfBody",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_AvatarId",
                table: "Exercise",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ExerciseId",
                table: "Image",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_TrainingProgramId",
                table: "Image",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_TrainingProgramId",
                table: "Training",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgram_AvatarId",
                table: "TrainingProgram",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramDay_ExercisesId",
                table: "TrainingProgramDay",
                column: "ExercisesId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramDay_TrainingProgramId",
                table: "TrainingProgramDay",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Approach_Exercise_ExerciseId",
                table: "Approach",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Approach_Training_TrainingId",
                table: "Approach",
                column: "TrainingId",
                principalTable: "Training",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryOfBody_Exercise_ExerciseId",
                table: "CategoryOfBody",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryOfBody_Image_AvatarId",
                table: "CategoryOfBody",
                column: "AvatarId",
                principalTable: "Image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_Image_AvatarId",
                table: "Exercise",
                column: "AvatarId",
                principalTable: "Image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_TrainingProgram_TrainingProgramId",
                table: "Image",
                column: "TrainingProgramId",
                principalTable: "TrainingProgram",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Exercise_ExerciseId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgram_Image_AvatarId",
                table: "TrainingProgram");

            migrationBuilder.DropTable(
                name: "Approach");

            migrationBuilder.DropTable(
                name: "CategoryOfBody");

            migrationBuilder.DropTable(
                name: "TrainingProgramDay");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "TrainingProgram");
        }
    }
}
