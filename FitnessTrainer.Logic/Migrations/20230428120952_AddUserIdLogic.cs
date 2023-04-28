using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdLogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ObjectOfStatistics");

            migrationBuilder.AddColumn<bool>(
                name: "IsEveryone",
                table: "TrainingProgram",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TrainingProgram",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsEveryone",
                table: "Training",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Training",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsEveryone",
                table: "Size",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Size",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsEveryone",
                table: "Goal",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Goal",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsEveryone",
                table: "Exercise",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Exercise",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "IsEveryone", "UserId" },
                values: new object[] { true, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEveryone",
                table: "TrainingProgram");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TrainingProgram");

            migrationBuilder.DropColumn(
                name: "IsEveryone",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "IsEveryone",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "IsEveryone",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "IsEveryone",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exercise");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ObjectOfStatistics",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
