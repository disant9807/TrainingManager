using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class UpdateInitExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryOfBody",
                keyColumns: new[] { "CategoryOfBodyId", "ExerciseId" },
                keyValues: new object[] { "MyshcaPodnimayushchayaLopatku", 1L });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 23, 11, 57, 898, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.InsertData(
                table: "ExerciseCategoryOfBody",
                columns: new[] { "CategoryOfBodyId", "ExerciseId" },
                values: new object[] { "DeltovidnayaMyshca", 1L });

            migrationBuilder.InsertData(
                table: "ExerciseCategoryOfBody",
                columns: new[] { "CategoryOfBodyId", "ExerciseId" },
                values: new object[] { "PlecheluchevayaMyshca", 1L });

            migrationBuilder.InsertData(
                table: "ExerciseCategoryOfBody",
                columns: new[] { "CategoryOfBodyId", "ExerciseId" },
                values: new object[] { "PlechevayaMyshca", 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryOfBody",
                keyColumns: new[] { "CategoryOfBodyId", "ExerciseId" },
                keyValues: new object[] { "DeltovidnayaMyshca", 1L });

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryOfBody",
                keyColumns: new[] { "CategoryOfBodyId", "ExerciseId" },
                keyValues: new object[] { "PlecheluchevayaMyshca", 1L });

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryOfBody",
                keyColumns: new[] { "CategoryOfBodyId", "ExerciseId" },
                keyValues: new object[] { "PlechevayaMyshca", 1L });

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
        }
    }
}
