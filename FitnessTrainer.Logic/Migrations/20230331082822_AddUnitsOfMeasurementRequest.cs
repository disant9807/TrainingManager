using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class AddUnitsOfMeasurementRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeItem_UnitsOfMeasurement_CodeUnitsOfMeasurement",
                table: "SizeItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubGoal_UnitsOfMeasurement_CodeUnitsOfMeasurement",
                table: "SubGoal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitsOfMeasurement",
                table: "UnitsOfMeasurement");

            migrationBuilder.RenameTable(
                name: "UnitsOfMeasurement",
                newName: "UnitsOfMeasurements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitsOfMeasurements",
                table: "UnitsOfMeasurements",
                column: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeItem_UnitsOfMeasurements_CodeUnitsOfMeasurement",
                table: "SizeItem",
                column: "CodeUnitsOfMeasurement",
                principalTable: "UnitsOfMeasurements",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubGoal_UnitsOfMeasurements_CodeUnitsOfMeasurement",
                table: "SubGoal",
                column: "CodeUnitsOfMeasurement",
                principalTable: "UnitsOfMeasurements",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeItem_UnitsOfMeasurements_CodeUnitsOfMeasurement",
                table: "SizeItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SubGoal_UnitsOfMeasurements_CodeUnitsOfMeasurement",
                table: "SubGoal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitsOfMeasurements",
                table: "UnitsOfMeasurements");

            migrationBuilder.RenameTable(
                name: "UnitsOfMeasurements",
                newName: "UnitsOfMeasurement");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitsOfMeasurement",
                table: "UnitsOfMeasurement",
                column: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeItem_UnitsOfMeasurement_CodeUnitsOfMeasurement",
                table: "SizeItem",
                column: "CodeUnitsOfMeasurement",
                principalTable: "UnitsOfMeasurement",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubGoal_UnitsOfMeasurement_CodeUnitsOfMeasurement",
                table: "SubGoal",
                column: "CodeUnitsOfMeasurement",
                principalTable: "UnitsOfMeasurement",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
