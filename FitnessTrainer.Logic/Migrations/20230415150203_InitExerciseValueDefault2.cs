using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class InitExerciseValueDefault2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryOfBodyExercise");

            migrationBuilder.CreateTable(
                name: "ExerciseCategoryOfBody",
                columns: table => new
                {
                    ExerciseId = table.Column<long>(type: "INTEGER", nullable: false),
                    CategoryOfBodyId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseCategoryOfBody", x => new { x.ExerciseId, x.CategoryOfBodyId });
                    table.ForeignKey(
                        name: "FK_ExerciseCategoryOfBody_CategoryOfBody_CategoryOfBodyId",
                        column: x => x.CategoryOfBodyId,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseCategoryOfBody_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 2, 2, 100, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.InsertData(
                table: "ExerciseCategoryOfBody",
                columns: new[] { "CategoryOfBodyId", "ExerciseId" },
                values: new object[] { "MyshcaPodnimayushchayaLopatku", 1L });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseCategoryOfBody_CategoryOfBodyId",
                table: "ExerciseCategoryOfBody",
                column: "CategoryOfBodyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseCategoryOfBody");

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

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOfBodyExercise_ExerciseId",
                table: "CategoryOfBodyExercise",
                column: "ExerciseId");
        }
    }
}
