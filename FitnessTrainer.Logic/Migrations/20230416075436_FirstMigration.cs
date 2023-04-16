using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitsOfMeasurements",
                columns: table => new
                {
                    Code = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsOfMeasurements", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Approach",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NumberOfTraining = table.Column<int>(type: "integer", nullable: false),
                    ExerciseId = table.Column<long>(type: "bigint", nullable: true),
                    TrainingId = table.Column<long>(type: "bigint", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approach", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApproachItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    approachId = table.Column<Guid>(type: "uuid", nullable: false),
                    Time = table.Column<long>(type: "bigint", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    NumberOfApproach = table.Column<int>(type: "integer", nullable: false),
                    Hard = table.Column<int>(type: "integer", nullable: false),
                    Technicality = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproachItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApproachItem_Approach_approachId",
                        column: x => x.approachId,
                        principalTable: "Approach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryOfBody",
                columns: table => new
                {
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    Decsription = table.Column<string>(type: "text", nullable: false),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryOfBody", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "SizeItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SizeId = table.Column<long>(type: "bigint", nullable: false),
                    BodyCode = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    CodeUnitsOfMeasurement = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeItem_CategoryOfBody_BodyCode",
                        column: x => x.BodyCode,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeItem_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeItem_UnitsOfMeasurements_CodeUnitsOfMeasurement",
                        column: x => x.CodeUnitsOfMeasurement,
                        principalTable: "UnitsOfMeasurements",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubGoal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BodyCode = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    CodeUnitsOfMeasurement = table.Column<string>(type: "text", nullable: false),
                    GoalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGoal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubGoal_CategoryOfBody_BodyCode",
                        column: x => x.BodyCode,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubGoal_Goal_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubGoal_UnitsOfMeasurements_CodeUnitsOfMeasurement",
                        column: x => x.CodeUnitsOfMeasurement,
                        principalTable: "UnitsOfMeasurements",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryOfBodyExercise",
                columns: table => new
                {
                    CategoryOfBodiesCode = table.Column<string>(type: "text", nullable: false),
                    ExerciseId = table.Column<long>(type: "bigint", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    IsBased = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    HardSkill = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTrainingProgramDay",
                columns: table => new
                {
                    ExercisesId = table.Column<long>(type: "bigint", nullable: false),
                    TrainingProgramDaysId = table.Column<Guid>(type: "uuid", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false),
                    ExerciseId = table.Column<long>(type: "bigint", nullable: true),
                    SizeItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    TrainingProgramId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Image_SizeItem_SizeItemId",
                        column: x => x.SizeItemId,
                        principalTable: "SizeItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgram",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false)
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<long>(type: "bigint", nullable: false),
                    TrainingProgramId = table.Column<long>(type: "bigint", nullable: true),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Training_TrainingProgram_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramDay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DayRelax = table.Column<int>(type: "integer", nullable: false),
                    NumberOfTrainingProgram = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramId = table.Column<long>(type: "bigint", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramDay_TrainingProgram_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Approach_ExerciseId",
                table: "Approach",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Approach_TrainingId",
                table: "Approach",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproachItem_approachId",
                table: "ApproachItem",
                column: "approachId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOfBody_AvatarId",
                table: "CategoryOfBody",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOfBodyExercise_ExerciseId",
                table: "CategoryOfBodyExercise",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_AvatarId",
                table: "Exercise",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTrainingProgramDay_TrainingProgramDaysId",
                table: "ExerciseTrainingProgramDay",
                column: "TrainingProgramDaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ExerciseId",
                table: "Image",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_SizeItemId",
                table: "Image",
                column: "SizeItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_TrainingProgramId",
                table: "Image",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeItem_BodyCode",
                table: "SizeItem",
                column: "BodyCode");

            migrationBuilder.CreateIndex(
                name: "IX_SizeItem_CodeUnitsOfMeasurement",
                table: "SizeItem",
                column: "CodeUnitsOfMeasurement");

            migrationBuilder.CreateIndex(
                name: "IX_SizeItem_SizeId",
                table: "SizeItem",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGoal_BodyCode",
                table: "SubGoal",
                column: "BodyCode");

            migrationBuilder.CreateIndex(
                name: "IX_SubGoal_CodeUnitsOfMeasurement",
                table: "SubGoal",
                column: "CodeUnitsOfMeasurement");

            migrationBuilder.CreateIndex(
                name: "IX_SubGoal_GoalId",
                table: "SubGoal",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_TrainingProgramId",
                table: "Training",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgram_AvatarId",
                table: "TrainingProgram",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramDay_TrainingProgramId",
                table: "TrainingProgramDay",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Approach_Exercise_ExerciseId",
                table: "Approach",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Approach_Training_TrainingId",
                table: "Approach",
                column: "TrainingId",
                principalTable: "Training",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryOfBody_Image_AvatarId",
                table: "CategoryOfBody",
                column: "AvatarId",
                principalTable: "Image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryOfBodyExercise_Exercise_ExerciseId",
                table: "CategoryOfBodyExercise",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_Image_AvatarId",
                table: "Exercise",
                column: "AvatarId",
                principalTable: "Image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTrainingProgramDay_TrainingProgramDay_TrainingProgr~",
                table: "ExerciseTrainingProgramDay",
                column: "TrainingProgramDaysId",
                principalTable: "TrainingProgramDay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_TrainingProgram_TrainingProgramId",
                table: "Image",
                column: "TrainingProgramId",
                principalTable: "TrainingProgram",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Exercise_ExerciseId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryOfBody_Image_AvatarId",
                table: "CategoryOfBody");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgram_Image_AvatarId",
                table: "TrainingProgram");

            migrationBuilder.DropTable(
                name: "ApproachItem");

            migrationBuilder.DropTable(
                name: "CategoryOfBodyExercise");

            migrationBuilder.DropTable(
                name: "ExerciseTrainingProgramDay");

            migrationBuilder.DropTable(
                name: "SubGoal");

            migrationBuilder.DropTable(
                name: "Approach");

            migrationBuilder.DropTable(
                name: "TrainingProgramDay");

            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "SizeItem");

            migrationBuilder.DropTable(
                name: "TrainingProgram");

            migrationBuilder.DropTable(
                name: "CategoryOfBody");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasurements");
        }
    }
}
